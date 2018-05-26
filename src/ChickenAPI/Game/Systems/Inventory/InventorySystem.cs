using System;
using System.Collections.Generic;
using System.Text;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Game.Components;

namespace ChickenAPI.Game.Systems.Inventory
{
    public class InventorySystem : NotifiableSystemBase
    {
        public InventorySystem(IEntityManager em) : base(em)
        {

        }

        public override void Execute(IEntity entity, SystemEventArgs e)
        {
            var inventory = entity.GetComponent<InventoryComponent>();

            switch (e)
            {
                case InventoryAddItemEventArgs addItemEventArgs:
                    AddItem(inventory, addItemEventArgs);
                    break;
            }
        }

        private void AddItem(InventoryComponent inv, InventoryAddItemEventArgs args)
        {

        }
    }
}
