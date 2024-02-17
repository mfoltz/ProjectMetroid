// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.Base.EntityModel
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;
using System.Diagnostics;
using Unity.Entities;
using VRising.GameData.Models.Internals;

#nullable disable
namespace VRising.GameData.Models.Base
{
  public abstract class EntityModel
  {
    protected EntityModel(Entity entity)
    {
      this.Entity = entity;
      this.Internals = new BaseEntityModel(VRising.GameData.GameData.World, entity);
    }

    [field: DebuggerBrowsable]
    public Entity Entity { get; }

    public PrefabGUID PrefabGUID => this.Internals.PrefabGUID.GetValueOrDefault();

    [field: DebuggerBrowsable]
    public BaseEntityModel Internals { get; }
  }
}
