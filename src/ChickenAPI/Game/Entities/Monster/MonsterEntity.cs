using System;
using System.Collections.Generic;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.Data.TransferObjects.Map;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Entities.Monster
{
    public class MonsterEntity : EntityBase
    {
        public MonsterEntity(MapNpcMonsterDto dto) : base(EntityType.Monster)
        {
            Components = new Dictionary<Type, IComponent>
            {
                {
                    typeof(VisibilityComponent), new VisibilityComponent(this)
                    {
                        IsVisible = true
                    }
                },
                { typeof(BattleComponent), new BattleComponent(this)
                {
                    Hp = dto.Data.MaxHp,
                    HpMax =  dto.Data.MaxHp,
                    Mp = dto.Data.MaxMp,
                    MpMax = dto.Data.MaxMp
                } },
                {
                    typeof(MovableComponent), new MovableComponent(this)
                    {
                        Actual = new Position<short> { X = dto.Position.X, Y = dto.Position.Y },
                        Destination = new Position<short> { X = dto.Position.X, Y = dto.Position.Y }
                    }
                },
                { typeof(NpcMonsterComponent), new NpcMonsterComponent(this, dto) }
            };
        }

        public override void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}