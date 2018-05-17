using System;
using ChickenAPI.ECS.Contexts;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.ECS.Systems
{
    public abstract class NotifiableSystemBase : SystemBase, INotifiableSystem
    {
        protected NotifiableSystemBase(IEntityManager entityManager) : base(entityManager)
        {
        }

        public virtual void Execute(IEntity entity, SystemEventArgs e)
        {
            // no base implementation yet
            throw new NotImplementedException();
        }
    }
}