using ChickenAPI.Events.Player;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Entities.Player
{
    public partial class Character
    {
        public event TypedSenderEventHandler<Game.Entities.Player.Character, ConnectEventArgs> Connected;
        public event TypedSenderEventHandler<Game.Entities.Player.Character, ConnectEventArgs> Disconnected;

        protected virtual void OnConnected(ConnectEventArgs e)
        {
            Connected?.Invoke(this, e);
        }

        protected virtual void OnDisconnected(ConnectEventArgs e)
        {
            Disconnected?.Invoke(this, e);
        }
    }
}