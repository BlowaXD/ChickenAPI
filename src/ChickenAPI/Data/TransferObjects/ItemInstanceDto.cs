using System;
using ChickenAPI.Data.AccessLayer.Repository;

namespace ChickenAPI.Data.TransferObjects
{
    public class ItemInstanceDto : ISynchronizedDto
    {
        public Guid Id { get; set; }

        public long Vnum { get; set; }
        public ItemDto Item { get; set; }

        public byte Design { get; set; }
    }
}