﻿using ChickenAPI.ECS.Systems;

namespace ChickenAPI.Game.Systems.Inventory.Args
{
    public class InventoryGeneratePacketDetailsEventArgs : SystemEventArgs
    {
        public InventorySystem System { get; set; }
    }
}