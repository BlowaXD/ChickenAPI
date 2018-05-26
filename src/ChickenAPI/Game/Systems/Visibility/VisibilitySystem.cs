using System;
using System.Linq;
using System.Linq.Expressions;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Packets.Game.Server;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Systems.Visibility
{
    public class VisibilitySystem : NotifiableSystemBase
    {
        private static readonly Logger Log = Logger.GetLogger<VisibilitySystem>();
        public VisibilitySystem(IEntityManager entityManager) : base(entityManager)
        {
        }

        protected override Expression<Func<IEntity, bool>> Filter =>
            entity => entity.Type == EntityType.Player || entity.Type == EntityType.Monster || entity.Type == EntityType.Mate || entity.Type == EntityType.Npc;

        public override void Execute(IEntity entity, SystemEventArgs e)
        {
            if (!Match(entity))
            {
                return;
            }
            switch (e)
            {
                case VisibilitySetInvisibleEventArgs invisibleEvent:
                    SetInvisible(entity, invisibleEvent);
                    break;

                case VisibilitySetVisibleEventArgs visibleEvent:
                    SetVisible(entity, visibleEvent);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void SetVisible(IEntity entity, VisibilitySetVisibleEventArgs args)
        {
            Log.Info($"[ENTITY:{entity.Id}] VISIBLE");
            entity.GetComponent<VisibilityComponent>().IsVisible = true;
            if (!args.Broadcast)
            {
                return;
            }

            foreach (IEntity entityy in entity.EntityManager.Entities)
            {
                if (entityy.Id == entity.Id || !Match(entityy))
                {
                    continue;
                }
                if (!(entity is IPlayerEntity session))
                {
                    continue;
                }

                if (!(entityy is IPlayerEntity player))
                {
                    continue;
                }

                if (args.IsChangingMapLayer)
                {
                    session.SendPacket(new InPacketBase(player));
                }

                player.SendPacket(new InPacketBase(session));
                // todo player entity
            }
        }

        private void SetInvisible(IEntity entity, VisibilitySetInvisibleEventArgs args)
        {
            Log.Info($"[ENTITY:{entity.Id}] INVISIBLE");
            entity.GetComponent<VisibilityComponent>().IsVisible = false;
            if (!args.Broadcast)
            {
                return;
            }

            foreach (IEntity entityy in entity.EntityManager.Entities)
            {
                if (entityy.Id == entity.Id || !Match(entityy))
                {
                    continue;
                }
                if (entityy is IPlayerEntity player)
                {
                    player.SendPacket(new OutPacketBase(player));
                }
            }
        }
    }
}