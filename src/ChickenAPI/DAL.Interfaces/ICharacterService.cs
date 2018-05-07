﻿using System.Collections.Generic;
using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Dtos;
using ChickenAPI.Enums;
using ChickenAPI.Enums.Game.Character;

namespace ChickenAPI.DAL.Interfaces
{
    public interface ICharacterService : IMappedRepository<CharacterDto>
    {
        /// <summary>
        /// Will return all the <see cref="CharacterDto"/> that are in <see cref="CharacterState.Active"/> state
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        IEnumerable<CharacterDto> GetActiveByAccountId(long accountId);

        /// <summary>
        /// Will return the <see cref="CharacterState.Active"/> <see cref="CharacterDto"/> associated to its accountId & slot
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="slot"></param>
        /// <returns></returns>
        CharacterDto GetByAccountIdAndSlot(long accountId, byte slot);
    }
}