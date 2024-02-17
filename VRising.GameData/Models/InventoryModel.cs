// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.InventoryModel
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Entities;
using VRising.GameData.Models.Data;
using VRising.GameData.Models.Internals;

#nullable disable
namespace VRising.GameData.Models
{
  public class InventoryModel
  {
    private readonly CharacterModel _characterModel;

    internal InventoryModel(CharacterModel characterModel) => this._characterModel = characterModel;

    public List<InventoryItemData> Items => this.GetInventoryItems();

    private List<InventoryItemData> GetInventoryItems()
    {
      Entity inventoryEntity;
      InventoryUtilities.TryGetInventoryEntity(VRising.GameData.GameData.World.EntityManager, this._characterModel.Entity, out inventoryEntity);
      List<InventoryBuffer> inventoryBuffers = new BaseEntityModel(VRising.GameData.GameData.World, inventoryEntity).InventoryBuffers;
      return inventoryBuffers == null ? new List<InventoryItemData>() : inventoryBuffers.Select<InventoryBuffer, InventoryItemData>((Func<InventoryBuffer, int, InventoryItemData>) ((i, index) =>
      {
        Entity entity = i.ItemType.GuidHash == 0 ? Entity.Null : VRising.GameData.GameData.Systems.PrefabCollectionSystem.PrefabLookupMap[i.ItemType];
        return new InventoryItemData()
        {
          Item = new ItemModel(entity),
          Stacks = i.Amount,
          Slot = index
        };
      })).ToList<InventoryItemData>();
    }
  }
}
