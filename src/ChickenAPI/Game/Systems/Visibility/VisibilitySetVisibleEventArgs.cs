using ChickenAPI.ECS.Systems;

namespace ChickenAPI.Game.Systems.Visibility
{
    public class VisibilitySetVisibleEventArgs : SystemEventArgs
    {
        public bool Broadcast { get; set; }
    }
}