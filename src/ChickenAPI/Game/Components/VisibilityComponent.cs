﻿using System;
using ChickenAPI.ECS.Components;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Components
{
    public class VisibilityComponent : ComponentBase
    {
        public static event TypedSenderEventHandler<IEntity, VisibilityChangeArgs> VisibilityChange;

        private bool _isVisible;

        public bool IsVisible
        {
            get => _isVisible;
            set
            {
                _isVisible = value;
                OnVisibilityChange(Entity, new VisibilityChangeArgs { IsVisible = _isVisible });
            }
        }

        public VisibilityComponent(IEntity entity) : base(entity)
        {
        }

        protected virtual void OnVisibilityChange(IEntity sender, VisibilityChangeArgs e)
        {
            VisibilityChange?.Invoke(sender, e);
        }
    }

    public class VisibilityChangeArgs : EventArgs
    {
        public bool IsVisible { get; set; }
    }
}