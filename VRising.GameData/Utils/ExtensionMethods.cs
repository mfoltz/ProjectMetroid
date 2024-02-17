// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Utils.ExtensionMethods
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;
using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using VRising.GameData.Models;
using VRising.GameData.Models.Internals;

#nullable disable
namespace VRising.GameData.Utils
{
  public static class ExtensionMethods
  {
    public static string GetPrefabName(this PrefabGUID prefabGuid)
    {
      try
      {
        return VRising.GameData.GameData.Systems.PrefabCollectionSystem.PrefabGuidToNameDictionary[prefabGuid].ToString();
      }
      catch
      {
        return (string) null;
      }
    }

    public static IEnumerable<BaseEntityModel> ToEnumerable(this EntityQuery entityQuery)
    {
      NativeArray<Entity> entities = entityQuery.ToEntityArray(Allocator.Temp);
      foreach (Entity entity1 in entities)
      {
        Entity entity = entity1;
        yield return new BaseEntityModel(VRising.GameData.GameData.World, entity);
        entity = new Entity();
      }
    }

    public static IEnumerable<NpcModel> AsNpcs(this EntityQuery entityQuery)
    {
      NativeArray<Entity> entities = entityQuery.ToEntityArray(Allocator.Temp);
      foreach (Entity entity1 in entities)
      {
        Entity entity = entity1;
        yield return new NpcModel(entity);
        entity = new Entity();
      }
    }

    public static DateTime ToDateTime(this long unixDateTime)
    {
      return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds((double) unixDateTime);
    }

    public static double Distance(this float3 pos1, float3 pos2)
    {
      return Math.Sqrt(Math.Pow((double) pos1.x - (double) pos2.x, 2.0) + Math.Pow((double) pos1.z - (double) pos2.z, 2.0));
    }
  }
}
