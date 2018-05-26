using ChickenAPI.ECS.Systems;
using System;
using System.Collections.Generic;
using System.Text;
using ChickenAPI.Data.TransferObjects;

namespace ChickenAPI.Game.Systems.Inventory
{
    public class InventoryAddItemEventArgs : SystemEventArgs
    {
        public ItemDto Item { get; set; }

        public short Amount { get; set; }
    }
}
