using System;
using ChickenAPI.Data.AccessLayer.Repository;

namespace ChickenAPI.Data.TransferObjects.Item
{
    public class ItemInstanceDto : ISynchronizedDto
    {
        public long Vnum { get; set; }
        public ItemDto Item { get; set; }

        public byte Design { get; set; }
        public Guid Id { get; set; }
    }
}