using ChickenAPI.Data.TransferObjects.Item;
using ChickenAPI.ECS.Systems;

namespace ChickenAPI.Game.Systems.Inventory
{
    public class InventoryAddItemEventArgs : SystemEventArgs
    {
        public ItemDto Item { get; set; }

        public short Amount { get; set; }
    }
}
