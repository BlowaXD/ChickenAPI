using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using ChickenAPI.Data.AccessLayer.Item;
using ChickenAPI.Data.TransferObjects.Item;
using ChickenAPI.ECS.Entities;
using ChickenAPI.ECS.Systems;
using ChickenAPI.Enums.Game.Items;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Entities;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Game.Systems.Inventory.Args;
using ChickenAPI.Packets.Game.Server;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Systems.Inventory
{
    public class InventorySystem : NotifiableSystemBase
    {
        private const short MAX_AMOUNT_PER_SLOT = 999;

        public InventorySystem(IEntityManager em) : base(em)
        {
        }

        public override void Execute(IEntity entity, SystemEventArgs e)
        {
            var inventory = entity.GetComponent<InventoryComponent>();
            if (inventory == null)
            {
                return;
            }

            switch (e)
            {
                case InventoryAddItemEventArgs addItemEventArgs:
                    AddItem(inventory, addItemEventArgs);
                    break;

                case InventoryDropItemEventArgs dropItemEventArgs:
                    DropItem(inventory, dropItemEventArgs);
                    break;

                case InventoryDestroyItemEventArgs destroyItemEventArgs:
                    DestroyItem(inventory, destroyItemEventArgs);
                    break;

                case InventoryGeneratePacketDetailsEventArgs detailsEventArgs:
                    if (!(entity is IPlayerEntity player))
                    {
                        return;
                    }

                    GenerateInventoryPackets(inventory, detailsEventArgs, player);
                    break;

                case InventoryInitializeEventArgs initEvent:
                    InitializeInventory(inventory, entity as IPlayerEntity);
                    break;
            }
        }

        private void InitializeInventory(InventoryComponent inventory, IPlayerEntity player)
        {
            var characterItemService = Container.Instance.Resolve<IItemInstanceService>();
            IEnumerable<ItemInstanceDto> items = characterItemService.GetByCharacterId(player.Character.Id);
            if (items == null || !items.Any())
            {

            }
            foreach (ItemInstanceDto item in items)
            {
                switch (item.Type)
                {
                    case InventoryType.Equipment:
                        inventory.Equipment[item.Slot] = item;
                        break;
                    case InventoryType.Etc:
                        inventory.Etc[item.Slot] = item;
                        break;
                    case InventoryType.Wear:
                        inventory.Wear[item.Slot] = item;
                        break;
                    case InventoryType.Main:
                        inventory.Main[item.Slot] = item;
                        break;
                }
            }
        }

        private static IvnPacket GenerateInventoryPacket(InventoryType type, IEnumerable<ItemInstanceDto> items)
        {
            var packet = new IvnPacket
            {
                InventoryType = type,
            };
            switch (type)
            {
                case InventoryType.Equipment:
                    packet.Wearables = items.Select(s => new IvnPacketItem
                    {
                        InventorySlot = s.Slot,
                        ItemVNum = s.ItemId,
                        Rare = s.Rarity,
                        Upgrade = s.Upgrade,
                        Unknown = 0,
                    }).ToList();
                    break;
                case InventoryType.Etc:
                case InventoryType.Main:
                    packet.Main = items.Select(s => new InvPacketMainItem
                    {
                        InventorySlot = s.Slot,
                        ItemVNum = s.ItemId,
                        Amount = s.Amount,
                        Unknown = 0
                    }).ToList();
                    break;
            }

            return packet;
        }

        private static void GenerateInventoryPackets(InventoryComponent inv, InventoryGeneratePacketDetailsEventArgs args, IPlayerEntity player)
        {
            player.SendPacket(GenerateInventoryPacket(InventoryType.Equipment, inv.Equipment));
            player.SendPacket(GenerateInventoryPacket(InventoryType.Main, inv.Main));
            player.SendPacket(GenerateInventoryPacket(InventoryType.Etc, inv.Etc));
            player.SendPacket(GenerateInventoryPacket(InventoryType.Wear, inv.Wear));
        }

        private static void AddItem(InventoryComponent inv, InventoryAddItemEventArgs args)
        {
            ItemInstanceDto[] subinv = GetSubInvFromItemInstance(inv, args.ItemInstance.Item);

            short slot = GetFirstFreeSlot(subinv);

            if (slot == -1)
            {
                //Not enough space
                return;
            }

            subinv.Append(args.ItemInstance);
        }

        private static void DropItem(InventoryComponent inv, InventoryDropItemEventArgs args)
        {
            if (!args.ItemInstance.Item.IsDroppable)
            {
                //Item is not droppable
                return;
            }

            ItemInstanceDto[] subinv = GetSubInvFromItemInstance(inv, args.ItemInstance.Item);

            int itemIndex = Array.FindIndex(subinv, x => x.Slot == args.ItemInstance.Slot);

            subinv[itemIndex] = null;
        }

        private static void DestroyItem(InventoryComponent inv, InventoryDestroyItemEventArgs args)
        {
            ItemInstanceDto[] subinv = GetSubInvFromItemInstance(inv, args.ItemInstance.Item);

            int itemIndex = Array.FindIndex(subinv, x => x.Slot == args.ItemInstance.Slot);

            subinv[itemIndex] = null;
        }

        private static short GetFirstFreeSlot(IReadOnlyCollection<ItemInstanceDto> subinventory)
        {
            for (int i = 0; i < subinventory.Count; i++)
            {
                ItemInstanceDto item = subinventory.First(x => x.Slot == i);

                if (item == null)
                {
                    return (short)i;
                }
            }

            return -1;
        }

        private static ItemInstanceDto[] GetSubInvFromItemInstance(InventoryComponent inv, ItemDto item)
        {
            switch (item.Type)
            {
                case InventoryType.Wear:
                    return inv.Wear;
                case InventoryType.Equipment:
                    return inv.Equipment;
                case InventoryType.Main:
                    return inv.Main;
                case InventoryType.Etc:
                    return inv.Etc;
                default:
                    return null;
            }
        }
    }
}