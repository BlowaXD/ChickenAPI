using ChickenAPI.Data.AccessLayer.Repository;

namespace ChickenAPI.Data.TransferObjects
{
    public class DropDto : IMappedDto
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public int Amount { get; set; }
        public long MonsterId{ get; set; }
        public int DropChance { get; set; }
    }
}