using System.Linq;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Enums.Packets;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Packets.Game.Server;

namespace ChickenAPI.Game.Systems.Chat
{
    public class ChatSystem : NotifiableSystemBase
    {
        public ChatSystem(IEntityManager entityManager) : base(entityManager)
        {
        }

        public override void Execute(IEntity entity, SystemEventArgs e)
        {
            switch (e)
            {
                case PlayerChatEventArg playerChatEvent:
                    PlayerChat(entity, playerChatEvent);
                    break;
            }
        }

        private void PlayerChat(IEntity entity, PlayerChatEventArg args)
        {
            var sayPacket = new SayPacket
            {
                Type = SayColorType.White,
                Message = args.Message,
                VisualType = VisualType.Character,
                VisualId = args.SenderId
            };
            
            foreach (IEntity entityy in entity.EntityManager.Entities.Where(s => s.Type == EntityType.Player && s.Id != entity.Id))
            {
                if (!(entityy is IPlayerEntity session))
                {
                    continue;
                }

                session.SendPacket(sayPacket);
            }
        }
    }
}