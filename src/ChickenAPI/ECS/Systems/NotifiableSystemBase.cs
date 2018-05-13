using System;
using ChickenAPI.ECS.Contexts;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.ECS.Systems
{
    public abstract class NotifiableSystemBase : SystemBase, INotifiableSystem
    {
        protected NotifiableSystemBase(IContext context) : base(context)
        {
        }

        public virtual void Execute(IEntity entity, SystemEventArgs e)
        {
            // no base implementation yet
            throw new NotImplementedException();
        }
    }
}