using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Enums.Game.BCard;

namespace ChickenAPI.Data.TransferObjects
{
    public class BCardDto : IMappedDto
    {
        public long Id { get; set; }

        public BCardRelationType RelationType { get; set; }
        public long RelationId { get; set; }
    }
}