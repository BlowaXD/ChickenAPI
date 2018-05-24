using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.Game.Components
{
    public class BattleComponent : IComponent
    {

        public BattleComponent(IEntity entity)
        {
            Hp = 100;
            HpMax = 200;
            Mp = 100;
            MpMax = 200;
            Entity = entity;
        }

        public int Hp { get; set; }

        public int HpMax { get; set; }

        public int Mp { get; set; }

        public int MpMax { get; set; }

        public short Morph { get; set; }

        public bool CanAttack { get; set; }

        public bool CanMove { get; set; }

        public IEntity Entity { get; }
    }
}