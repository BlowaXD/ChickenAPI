using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.Game.Components
{
    public class BattleComponent : IComponent
    {
        public BattleComponent(IEntity entity) => Entity = entity;
        public int Hp { get; set; }
        public int HpMax { get; set; }
        public int Mp { get; set; }
        public int MpMax { get; set; }
        public IEntity Entity { get; }
    }
}