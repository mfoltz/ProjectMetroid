// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleTerritoryExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public static class CastleTerritoryExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCastleTerritory_Public_Static_Boolean_byref_MapZoneCollection_byref_EntityManager_int2_byref_CastleTerritory_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794092, RefRangeEnd = 794094, XrefRangeStart = 794057, XrefRangeEnd = 794092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetCastleTerritory(
      [In] ref this MapZoneCollection mapZoneCollection,
      [In] ref EntityManager entityManager,
      int2 worldTile,
      out CastleTerritory castleTerritory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref mapZoneCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleTerritory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritoryExtensions.NativeMethodInfoPtr_TryGetCastleTerritory_Public_Static_Boolean_byref_MapZoneCollection_byref_EntityManager_int2_byref_CastleTerritory_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleTerritoryExtensions()
    {
      Il2CppClassPointerStore<CastleTerritoryExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CastleTerritoryExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTerritoryExtensions>.NativeClassPtr);
      CastleTerritoryExtensions.NativeMethodInfoPtr_TryGetCastleTerritory_Public_Static_Boolean_byref_MapZoneCollection_byref_EntityManager_int2_byref_CastleTerritory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryExtensions>.NativeClassPtr, 100669998);
    }

    public CastleTerritoryExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
