using System;
using ChickenAPI.Data.AccessLayer.Repository;

namespace ChickenAPI.Data.TransferObjects
{
    public class ItemInstanceDto : ISynchronizedDto
    {
        public ItemDto Item { get; set; }

        public long Vnum { get; set; }

        public byte Design { get; set; }
        public Guid Id { get; set; }
    }
}