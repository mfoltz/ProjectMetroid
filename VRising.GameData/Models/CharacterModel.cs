// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.CharacterModel
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using System.Diagnostics;
using Unity.Entities;
using VRising.GameData.Models.Internals;

#nullable disable
namespace VRising.GameData.Models
{
  public class CharacterModel
  {
    [field: DebuggerBrowsable]
    public Entity Entity { get; }

    [field: DebuggerBrowsable]
    public BaseEntityModel Internals { get; }

    public EquipmentModel Equipment
    {
      get
      {
        return !this.Internals.Equipment.HasValue ? (EquipmentModel) null : new EquipmentModel(this.Internals.Equipment.Value);
      }
    }

    internal CharacterModel(Entity entity)
    {
      this.Entity = entity;
      this.Internals = new BaseEntityModel(VRising.GameData.GameData.World, entity);
    }
  }
}
