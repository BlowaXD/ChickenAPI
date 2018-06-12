using System;
using ChickenAPI.Data.AccessLayer.Repository;

namespace ChickenAPI.Data.TransferObjects.Item
{
    public class ItemInstanceDto : ISynchronizedDto
    {
        public ItemDto Item { get; set; }

        public byte Design { get; set; }

        public Guid Id { get; set; }

        public short Amount { get; set; }

        public short Slot { get; set; }
    }
}