﻿using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;

namespace ChickenAPI.Data.AccessLayer
{
    public interface IItemService : IMappedRepository<ItemDto>
    {
        
    }
}