using System;
using ChickenAPI.Data.AccessLayer.Repository;

namespace ChickenAPI.Data.TransferObjects
{
    public class CharacterSkillDto : ISynchronizedDto
    {
        public Guid Id { get; set; }
    }
}