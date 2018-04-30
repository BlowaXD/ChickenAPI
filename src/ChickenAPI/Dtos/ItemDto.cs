using ChickenAPI.DAL.Interfaces.Repository;

namespace ChickenAPI.Dtos
{
    /// <summary>
    /// Items
    /// </summary>
    public class ItemDto : IMappedDto
    {
        public long Id { get; set; }
    }
}