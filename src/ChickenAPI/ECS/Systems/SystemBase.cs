using System;
using System.Linq.Expressions;
using ChickenAPI.ECS.Entities;

namespace ChickenAPI.ECS.Systems
{
    public abstract class SystemBase : ISystem
    {
        private Func<IEntity, bool> _filter;

        protected SystemBase(IEntityManager entityManager) => EntityManager = entityManager;


        /// <summary>
        ///     Gets filter of the system.
        /// </summary>
        /// <remarks>
        ///     This filter is used to check if the entities needs to be updated by this system.
        /// </remarks>
        protected virtual Expression<Func<IEntity, bool>> Filter { get; }

        public IEntityManager EntityManager { get; }

        public virtual void Execute(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Match(IEntity entity)
        {
            _filter = _filter ?? Filter.Compile();

            return (bool)_filter?.Invoke(entity);
        }
    }
}