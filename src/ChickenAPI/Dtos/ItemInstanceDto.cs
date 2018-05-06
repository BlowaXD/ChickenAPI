using System;
using ChickenAPI.DAL.Interfaces.Repository;

namespace ChickenAPI.Dtos
{
    public class ItemInstanceDto : ISynchronizedDto
    {
        public ItemDto Item { get; set; }

        public long Vnum { get; set; }

        public byte Design { get; set; }
        public Guid Id { get; set; }
    }
}