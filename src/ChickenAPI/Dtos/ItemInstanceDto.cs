using System;
using ChickenAPI.DAL.Interfaces.Repository;

namespace ChickenAPI.Dtos
{
    public class ItemInstanceDto : ISynchronizedDto
    {
        public Guid Id { get; set; }
    }
}