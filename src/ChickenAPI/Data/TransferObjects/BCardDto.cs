using ChickenAPI.Data.AccessLayer.Repository;

namespace ChickenAPI.Data.TransferObjects
{
    public class BCardDto : IMappedDto
    {
        public long Id { get; set; }
        public long NpcMonsterId { get; set; }
        public byte Type { get; set; }
        public byte SubType { get; set; }
        public bool IsLevelScaled { get; set; }
        public bool IsLevelDivided { get; set; }
        public short FirstData { get; set; }
        public short SecondData { get; set; }
        public short ThirdData { get; set; }
        public int CastType { get; set; }
    }
}