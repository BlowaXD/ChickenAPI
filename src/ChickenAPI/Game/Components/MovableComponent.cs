using System;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Components
{
    /// <summary>
    /// 
    /// </summary>
    public class MovableComponent : IComponent
    {
        public MovableComponent(IEntity entity)
        {
            Entity = entity;
        }

        public IEntity Entity { get; set; }


        public static event TypedSenderEventHandler<IEntity, MoveEventArgs> Move;

        /// <summary>
        /// Entity Walking Speed
        /// </summary>
        public byte Speed { get; set; }

        public Position<short> Destination { get; set; }
        public Position<short> Actual { get; set; }
        public DateTime LastMove { get; private set; }
        public DateTime NextMove { get; set; }

        private static void OnMove(IEntity sender, MoveEventArgs e)
        {
            e.Component.LastMove = DateTime.Now;
            // todo tick the systems update
            e.Component.NextMove = DateTime.Now;
            Move?.Invoke(sender, e);
        }
    }

    public class MoveEventArgs : EventArgs
    {
        public MovableComponent Component { get; set; }
        public Position<short> Old { get; set; }
        public Position<short> New { get; set; }
    }
}