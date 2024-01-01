// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.EquipmentModel
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;
using System.Diagnostics;
using Unity.Entities;

#nullable disable
namespace VRising.GameData.Models
{
  public class EquipmentModel
  {
    [field: DebuggerBrowsable]
    public Equipment Internals { get; }

    public ItemModel Chest
    {
      get
      {
        return !(this.Internals.ArmorChestSlotEntity._Entity != Entity.Null) ? (ItemModel) null : new ItemModel(this.Internals.ArmorChestSlotEntity._Entity);
      }
    }

    public ItemModel Leg
    {
      get
      {
        return !(this.Internals.ArmorLegsSlotEntity._Entity != Entity.Null) ? (ItemModel) null : new ItemModel(this.Internals.ArmorLegsSlotEntity._Entity);
      }
    }

    public ItemModel Headgear
    {
      get
      {
        return !(this.Internals.ArmorHeadgearSlotEntity._Entity != Entity.Null) ? (ItemModel) null : new ItemModel(this.Internals.ArmorHeadgearSlotEntity._Entity);
      }
    }

    public ItemModel Footgear
    {
      get
      {
        return !(this.Internals.ArmorFootgearSlotEntity._Entity != Entity.Null) ? (ItemModel) null : new ItemModel(this.Internals.ArmorFootgearSlotEntity._Entity);
      }
    }

    public ItemModel Gloves
    {
      get
      {
        return !(this.Internals.ArmorGlovesSlotEntity._Entity != Entity.Null) ? (ItemModel) null : new ItemModel(this.Internals.ArmorGlovesSlotEntity._Entity);
      }
    }

    public ItemModel Cloak
    {
      get
      {
        return !(this.Internals.CloakSlotEntity._Entity != Entity.Null) ? (ItemModel) null : new ItemModel(this.Internals.CloakSlotEntity._Entity);
      }
    }

    public ItemModel Weapon
    {
      get
      {
        return !(this.Internals.WeaponSlotEntity._Entity != Entity.Null) ? (ItemModel) null : new ItemModel(this.Internals.WeaponSlotEntity._Entity);
      }
    }

    public ItemModel Jewelry
    {
      get
      {
        return !(this.Internals.GrimoireSlotEntity._Entity != Entity.Null) ? (ItemModel) null : new ItemModel(this.Internals.GrimoireSlotEntity._Entity);
      }
    }

    public float ArmorLevel => this.Internals.ArmorLevel.Value;

    public float WeaponLevel => this.Internals.WeaponLevel.Value;

    public float SpellLevel => this.Internals.SpellLevel.Value;

    public float Level => this.ArmorLevel + this.WeaponLevel + this.SpellLevel;

    public EquipmentModel(Equipment equipment) => this.Internals = equipment;
  }
}
