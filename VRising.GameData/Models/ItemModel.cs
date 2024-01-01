// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.ItemModel
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;
using System.Diagnostics;
using Unity.Entities;
using VRising.GameData.Models.Base;
using VRising.GameData.Models.Internals;
using VRising.GameData.Utils;

#nullable disable
namespace VRising.GameData.Models
{
  public class ItemModel : EntityModel
  {
    internal ItemModel(Entity entity)
      : base(entity)
    {
      PrefabGUID? prefabGuid = this.Internals.PrefabGUID;
      ref PrefabGUID? local = ref prefabGuid;
      this.PrefabName = local.HasValue ? local.GetValueOrDefault().GetPrefabName() : (string) null;
      this.ManagedGameData = new BaseManagedDataModel(VRising.GameData.GameData.World, this.Internals);
    }

    [field: DebuggerBrowsable]
    public BaseManagedDataModel ManagedGameData { get; }

    [field: DebuggerBrowsable]
    public string PrefabName { get; }

    public string Name => this.ManagedGameData?.ManagedItemData?.Name.ToString();

    public ItemCategory ItemCategory
    {
      get
      {
        ItemData? itemData = this.Internals.ItemData;
        ref ItemData? local = ref itemData;
        return !local.HasValue ? ItemCategory.NONE : local.GetValueOrDefault().ItemCategory;
      }
    }

    public ItemType ItemType
    {
      get
      {
        ItemData? itemData = this.Internals.ItemData;
        ref ItemData? local = ref itemData;
        return !local.HasValue ? ItemType.Stackable : local.GetValueOrDefault().ItemType;
      }
    }

    public EquipmentType EquipmentType
    {
      get
      {
        EquippableData? equippableData = this.Internals.EquippableData;
        ref EquippableData? local = ref equippableData;
        return !local.HasValue ? EquipmentType.None : local.GetValueOrDefault().EquipmentType;
      }
    }
  }
}
