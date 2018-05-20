using System;
using System.Collections.Generic;
using System.Text;
using ChickenAPI.Enums.Game.Portals;

namespace ChickenAPI.Game.Maps
{
    public class Portal
    {
        public Portal()
        {
            
        }

        public PortalType Type { get; }
        public IMapLayer Origin { get; }
        public IMapLayer Destination { get; }
        public bool IsAvailable { get; }
        public short X { get; }
        public short Y { get; }
    }
}
