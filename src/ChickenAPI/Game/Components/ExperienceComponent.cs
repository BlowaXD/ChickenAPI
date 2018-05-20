using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums;
using ChickenAPI.Enums.Game.Character;

namespace ChickenAPI.Game.Components
{
    public class ExperienceComponent : IComponent
    {
        public ExperienceComponent(IEntity entity) => Entity = entity;
    
        public byte Level { get; set; }

        public byte HeroLevel { get; set; }

        public byte JobLevel { get; set; }

        public byte SpecialistLevel { get; set; }

        public IEntity Entity { get; }
    }
}