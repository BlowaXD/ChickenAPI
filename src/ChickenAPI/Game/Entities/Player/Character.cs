using System;
using System.Collections.Generic;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Contexts;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;

namespace ChickenAPI.Game.Entities.Player
{
    public partial class Character : IEntity
    {
        private readonly Dictionary<Type, IComponent> _components;

        public Character()
        {
            _components = new Dictionary<Type, IComponent>
            {
                { typeof(VisibilityComponent), new VisibilityComponent(this) }
            };
        }

        public long Id { get; set; }

        public IContext Context => null;

        public EntityType Type => EntityType.Player;

        public void AddComponent<T>(T component) where T : IComponent
        {
            throw new System.NotImplementedException();
        }

        public void RemoveComponent<T>(T component) where T : IComponent
        {
            throw new System.NotImplementedException();
        }

        public bool HasComponent<T>(T component) where T : IComponent => _components.ContainsKey(typeof(T));

        public T GetComponent<T>() where T : class, IComponent => !_components.TryGetValue(typeof(T), out IComponent component) ? null : component as T;
    }
}