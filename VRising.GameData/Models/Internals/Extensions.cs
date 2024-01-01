// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.Internals.Extensions
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;
using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace VRising.GameData.Models.Internals
{
  internal static class Extensions
  {
    public static List<T> GetBufferInternal<T>(this EntityManager entityManager, Entity entity) where T : new()
    {
      try
      {
        DynamicBuffer<T> buffer = entityManager.GetBuffer<T>(entity);
        List<T> bufferInternal = new List<T>();
        NativeArray<T>.Enumerator enumerator = buffer.GetEnumerator();
        while (enumerator.MoveNext())
        {
          T current = enumerator.Current;
          bufferInternal.Add(current);
        }
        return bufferInternal;
      }
      catch (Exception ex)
      {
        return (List<T>) null;
      }
    }

    public static bool HasComponentInternal<T>(this EntityManager entityManager, Entity entity)
    {
      try
      {
        return entityManager.HasComponent<T>(entity);
      }
      catch
      {
        return false;
      }
    }

    public static bool TryGetComponentDataInternal<T>(
      this EntityManager entityManager,
      Entity entity,
      out T value)
      where T : new()
    {
      try
      {
        value = entityManager.GetComponentData<T>(entity);
        return true;
      }
      catch
      {
        value = default (T);
        return false;
      }
    }

    public static T GetManagedComponentDataInternal<T>(this World world, BaseEntityModel entity) where T : class
    {
      PrefabGUID? prefabGuid = entity.PrefabGUID;
      return !prefabGuid.HasValue ? default (T) : world.GetExistingSystem<GameDataSystem>().ManagedDataRegistry.GetOrDefault<T>(prefabGuid.Value);
    }
  }
}
