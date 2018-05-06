using System;
using ChickenAPI.DAL.Interfaces.Repository;

namespace ChickenAPI.Dtos
{
    public class ItemInstanceDto : ISynchronizedDto
    {
        public Guid Id { get; set; }

        public ItemDto Item { get; set; }

        public long Vnum { get; set; }

        public byte Design { get; set; }
    }
}