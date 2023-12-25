// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerritorySpawnSystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Terrain
{
  public class TerritorySpawnSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZoneCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterMapZones_Private_Static_Void_BoundsMinMax_MapZoneId_MapZoneFlags_Entity_NativeHashMap_2_MapZoneId_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193057, XrefRangeEnd = 1193089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TerritorySpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193089, XrefRangeEnd = 1193144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TerritorySpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193144, XrefRangeEnd = 1193170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RegisterMapZones(
      BoundsMinMax worldBounds,
      MapZoneId zoneId,
      MapZoneFlags zoneFlags,
      Entity zoneEntity,
      NativeHashMap<MapZoneId, SpatialMapZoneData> mapZoneLookup,
      NativeArray<FixedList512<SpatialMapZoneData>> spatialMapZoneLookup)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &zoneId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &zoneFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &zoneEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mapZoneLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &spatialMapZoneLookup;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritorySpawnSystem.NativeMethodInfoPtr_RegisterMapZones_Private_Static_Void_BoundsMinMax_MapZoneId_MapZoneFlags_Entity_NativeHashMap_2_MapZoneId_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerritorySpawnSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritorySpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TerritorySpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TerritorySpawnSystem()
    {
      Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.Terrain", nameof (TerritorySpawnSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr);
      TerritorySpawnSystem.NativeFieldInfoPtr__MapZoneCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr, nameof (_MapZoneCollectionSystem));
      TerritorySpawnSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr, nameof (_Query));
      TerritorySpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr, 100663601);
      TerritorySpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr, 100663602);
      TerritorySpawnSystem.NativeMethodInfoPtr_RegisterMapZones_Private_Static_Void_BoundsMinMax_MapZoneId_MapZoneFlags_Entity_NativeHashMap_2_MapZoneId_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr, 100663603);
      TerritorySpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr, 100663604);
      TerritorySpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr, 100663605);
    }

    public TerritorySpawnSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MapZoneCollectionSystem _MapZoneCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritorySpawnSystem.NativeFieldInfoPtr__MapZoneCollectionSystem));
        return pointer == System.IntPtr.Zero ? (MapZoneCollectionSystem) null : new MapZoneCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritorySpawnSystem.NativeFieldInfoPtr__MapZoneCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritorySpawnSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritorySpawnSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LoadedCastleTerritory
    {
      static LoadedCastleTerritory()
      {
        Il2CppClassPointerStore<TerritorySpawnSystem.LoadedCastleTerritory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerritorySpawnSystem>.NativeClassPtr, nameof (LoadedCastleTerritory));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerritorySpawnSystem.LoadedCastleTerritory>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerritorySpawnSystem.LoadedCastleTerritory>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
