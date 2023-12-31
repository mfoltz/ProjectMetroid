// Decompiled with JetBrains decompiler
// Type: ProjectM.MapZoneCollectionSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class MapZoneCollectionSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SpatialMapZoneLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__EmptyList;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZoneLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZoneCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__GlobalZone;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMapZoneCollection_Public_MapZoneCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMapZoneLookupsForWriting_Public_Void_byref_NativeHashMap_2_MapZoneId_SpatialMapZoneData_byref_NativeArray_1_FixedList512_1_SpatialMapZoneData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetChunkIndex_Public_Static_Boolean_TerrainChunk_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalMapZone_Public_Void_Nullable_Unboxed_1_SpatialMapZoneData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 762313, RefRangeEnd = 762324, XrefRangeStart = 762313, XrefRangeEnd = 762313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapZoneCollection GetMapZoneCollection()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneCollectionSystem.NativeMethodInfoPtr_GetMapZoneCollection_Public_MapZoneCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MapZoneCollection*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 762326, RefRangeEnd = 762328, XrefRangeStart = 762324, XrefRangeEnd = 762326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetMapZoneLookupsForWriting(
      out NativeHashMap<MapZoneId, SpatialMapZoneData> mapZoneLookup,
      out NativeArray<FixedList512<SpatialMapZoneData>> spatialLookup)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref mapZoneLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spatialLookup;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneCollectionSystem.NativeMethodInfoPtr_GetMapZoneLookupsForWriting_Public_Void_byref_NativeHashMap_2_MapZoneId_SpatialMapZoneData_byref_NativeArray_1_FixedList512_1_SpatialMapZoneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 762331, RefRangeEnd = 762334, XrefRangeStart = 762328, XrefRangeEnd = 762331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetChunkIndex(TerrainChunk terrainChunk, out int chunkIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &terrainChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunkIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneCollectionSystem.NativeMethodInfoPtr_TryGetChunkIndex_Public_Static_Boolean_TerrainChunk_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762334, XrefRangeEnd = 762348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapZoneCollectionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762348, XrefRangeEnd = 762357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapZoneCollectionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapZoneCollectionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetGlobalMapZone(Nullable_Unboxed<SpatialMapZoneData> globaLMapZone)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &globaLMapZone;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneCollectionSystem.NativeMethodInfoPtr_SetGlobalMapZone_Public_Void_Nullable_Unboxed_1_SpatialMapZoneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapZoneCollectionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneCollectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapZoneCollectionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapZoneCollectionSystem()
    {
      Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapZoneCollectionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr);
      MapZoneCollectionSystem.NativeFieldInfoPtr__SpatialMapZoneLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, nameof (_SpatialMapZoneLookup));
      MapZoneCollectionSystem.NativeFieldInfoPtr__EmptyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, nameof (_EmptyList));
      MapZoneCollectionSystem.NativeFieldInfoPtr__MapZoneLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, nameof (_MapZoneLookup));
      MapZoneCollectionSystem.NativeFieldInfoPtr__MapZoneCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, nameof (_MapZoneCollection));
      MapZoneCollectionSystem.NativeFieldInfoPtr__GlobalZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, nameof (_GlobalZone));
      MapZoneCollectionSystem.NativeMethodInfoPtr_GetMapZoneCollection_Public_MapZoneCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, 100667361);
      MapZoneCollectionSystem.NativeMethodInfoPtr_GetMapZoneLookupsForWriting_Public_Void_byref_NativeHashMap_2_MapZoneId_SpatialMapZoneData_byref_NativeArray_1_FixedList512_1_SpatialMapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, 100667362);
      MapZoneCollectionSystem.NativeMethodInfoPtr_TryGetChunkIndex_Public_Static_Boolean_TerrainChunk_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, 100667363);
      MapZoneCollectionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, 100667364);
      MapZoneCollectionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, 100667365);
      MapZoneCollectionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, 100667366);
      MapZoneCollectionSystem.NativeMethodInfoPtr_SetGlobalMapZone_Public_Void_Nullable_Unboxed_1_SpatialMapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, 100667367);
      MapZoneCollectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, 100667368);
      MapZoneCollectionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollectionSystem>.NativeClassPtr, 100667369);
    }

    public MapZoneCollectionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeArray<FixedList512<SpatialMapZoneData>> _SpatialMapZoneLookup
    {
      get
      {
        return *(NativeArray<FixedList512<SpatialMapZoneData>>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneCollectionSystem.NativeFieldInfoPtr__SpatialMapZoneLookup));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneCollectionSystem.NativeFieldInfoPtr__SpatialMapZoneLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<FixedList512<SpatialMapZoneData>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeReference<FixedList512<SpatialMapZoneData>> _EmptyList
    {
      get
      {
        return *(NativeReference<FixedList512<SpatialMapZoneData>>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneCollectionSystem.NativeFieldInfoPtr__EmptyList));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneCollectionSystem.NativeFieldInfoPtr__EmptyList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeReference<FixedList512<SpatialMapZoneData>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<MapZoneId, SpatialMapZoneData> _MapZoneLookup
    {
      get
      {
        return *(NativeHashMap<MapZoneId, SpatialMapZoneData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneCollectionSystem.NativeFieldInfoPtr__MapZoneLookup));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneCollectionSystem.NativeFieldInfoPtr__MapZoneLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<MapZoneId, SpatialMapZoneData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe MapZoneCollection _MapZoneCollection
    {
      get
      {
        return *(MapZoneCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneCollectionSystem.NativeFieldInfoPtr__MapZoneCollection));
      }
      [param: In] set
      {
        *(MapZoneCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneCollectionSystem.NativeFieldInfoPtr__MapZoneCollection)) = value;
      }
    }

    public unsafe Nullable_Unboxed<SpatialMapZoneData> _GlobalZone
    {
      get
      {
        return *(Nullable_Unboxed<SpatialMapZoneData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneCollectionSystem.NativeFieldInfoPtr__GlobalZone));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneCollectionSystem.NativeFieldInfoPtr__GlobalZone), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<SpatialMapZoneData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
