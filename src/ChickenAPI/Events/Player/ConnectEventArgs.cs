using System;
using ChickenAPI.Session;

namespace ChickenAPI.Events.Player
{
    public class ConnectEventArgs : EventArgs
    {
        public ISession Session { get; set; }

        public DateTime Date { get; set; }
    }
}