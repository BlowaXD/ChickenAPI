using ChickenAPI.Data.AccessLayer.Repository;

namespace ChickenAPI.Data.TransferObjects
{
    public class BCardDto : IMappedDto
    {
        public long Id { get; set; }

        public byte SubType { get; set; }

        public byte Type { get; set; }

        public int FirstData { get; set; }

        public int SecondData { get; set; }

        public int ThirdData { get; set; }

        public long? CardId { get; set; }

        public long? ItemId { get; set; }

        public long? SkillId { get; set; }

        public long? NpcMonsterId { get; set; }

        public byte CastType { get; set; }

        public bool IsLevelScaled { get; set; }

        public bool IsLevelDivided { get; set; }
    }
}