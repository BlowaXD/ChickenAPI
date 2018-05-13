using ChickenAPI.ECS.Entities;

namespace ChickenAPI.ECS.Components
{
    public abstract class ComponentBase : IComponent
    {
        protected ComponentBase(IEntity entity)
        {
            Owner = entity;
        }

        protected readonly IEntity Owner;
        public IEntity Entity => Owner;
    }
}