// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.NpcModel
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;
using System;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using VRising.GameData.Models.Base;

#nullable disable
namespace VRising.GameData.Models
{
  public class NpcModel : EntityModel
  {
    private readonly HashSet<UnitCategory> _npcCategories = new HashSet<UnitCategory>()
    {
      UnitCategory.Beast,
      UnitCategory.Demon,
      UnitCategory.Human,
      UnitCategory.Undead,
      UnitCategory.Mechanical
    };

    internal NpcModel(Entity entity)
      : base(entity)
    {
      EntityCategory? entityCategory = this.Internals.EntityCategory;
      if (!entityCategory.HasValue || entityCategory.Value.MainCategory != MainEntityCategory.Unit || !this._npcCategories.Contains(entityCategory.Value.UnitCategory))
        throw new Exception("Given entity is not a NPC.");
    }

    public new PrefabGUID PrefabGUID => this.Internals.PrefabGUID.GetValueOrDefault();

    public bool IsDead => this.Internals.Dead.HasValue;

    public float LifeTime
    {
      get
      {
        ProjectM.LifeTime? lifeTime = this.Internals.LifeTime;
        ref ProjectM.LifeTime? local = ref lifeTime;
        return !local.HasValue ? 0.0f : local.GetValueOrDefault().Duration;
      }
    }

    public float3 Position
    {
      get
      {
        LocalToWorld? localToWorld = this.Internals.LocalToWorld;
        ref LocalToWorld? local = ref localToWorld;
        return !local.HasValue ? new float3() : local.GetValueOrDefault().Position;
      }
    }

    public bool HasDropTable => this.Internals.DropTable;
  }
}
