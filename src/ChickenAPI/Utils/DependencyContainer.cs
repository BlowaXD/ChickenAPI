using System;
using System.Collections.Generic;

namespace ChickenAPI.Utils
{
    /// <summary>
    /// Singleton that holds instances of objects
    /// </summary>
    public class DependencyContainer
    {
        private readonly Dictionary<Type, object> _objects = new Dictionary<Type, object>();

        /// <summary>
        /// Register an instance of <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        public void Register<T>(T instance) where T : class
        {
            _objects[typeof(T)] = instance;
        }

        /// <summary>
        /// Get the instance that deserve the <see cref="Type"/> given as the typeparam
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Get<T>() where T : class => !_objects.TryGetValue(typeof(T), out object instance) ? null : instance as T;

        private static readonly Lazy<DependencyContainer> LazyInstance = new Lazy<DependencyContainer>(() => new DependencyContainer());
        public static DependencyContainer Instance => LazyInstance.Value;
    }
}