﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;

namespace ChickenAPI.Data.AccessLayer
{
    public interface IBCardService : IMappedRepository<BCardDto>
    {
        Task<IEnumerable<BCardDto>> GetBySkillIdAsync(long skillId);

        Task<IEnumerable<BCardDto>> GetByMapMonsterIdAsync(long monsterId);

        Task<IEnumerable<BCardDto>> GetByCardIdAsync(long cardId);

        Task<IEnumerable<BCardDto>> GetByItemIdAsync(long itemId);
    }
}