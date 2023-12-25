// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkMapZoneSpawnOnLoad
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Terrain
{
  public class ChunkMapZoneSpawnOnLoad : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZoneCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequiredQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZonePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr___ChunkMapZoneSpawnOnLoad_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ChunkMapZoneSpawnOnLoad_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeMapZones_Private_Int32_Entity_TerrainChunkMetadata_NativeHashMap_2_MapZoneId_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterMapZones_Private_Static_Void_BoundsMinMax_MapZoneId_MapZoneFlags_Entity_NativeHashMap_2_MapZoneId_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForChunkMapZoneSpawnOnLoad_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192221, XrefRangeEnd = 1192271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192271, XrefRangeEnd = 1192282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1192370, RefRangeEnd = 1192371, XrefRangeStart = 1192282, XrefRangeEnd = 1192370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int DeserializeMapZones(
      Entity sceneSectionEntity,
      TerrainChunkMetadata chunkMetadata,
      NativeHashMap<MapZoneId, SpatialMapZoneData> mapZoneLookup,
      NativeArray<FixedList512<SpatialMapZoneData>> spatialMapZoneCollection,
      Entity metadataEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &sceneSectionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkMetadata;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mapZoneLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &spatialMapZoneCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &metadataEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_DeserializeMapZones_Private_Int32_Entity_TerrainChunkMetadata_NativeHashMap_2_MapZoneId_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1192397, RefRangeEnd = 1192398, XrefRangeStart = 1192371, XrefRangeEnd = 1192397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_RegisterMapZones_Private_Static_Void_BoundsMinMax_MapZoneId_MapZoneFlags_Entity_NativeHashMap_2_MapZoneId_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192398, XrefRangeEnd = 1192439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkMetadataLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkMapZoneSpawnOnLoad()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192439, XrefRangeEnd = 1192459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192459, XrefRangeEnd = 1192475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForChunkMapZoneSpawnOnLoad_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr___GetEntityQuery_ForChunkMapZoneSpawnOnLoad_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ChunkMapZoneSpawnOnLoad()
    {
      Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.Terrain", nameof (ChunkMapZoneSpawnOnLoad));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr);
      ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__MapZoneCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (_MapZoneCollectionSystem));
      ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (_TerrainManager));
      ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__RequiredQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (_RequiredQuery));
      ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__MapZonePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (_MapZonePrefab));
      ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr___ChunkMapZoneSpawnOnLoad_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, "<>ChunkMapZoneSpawnOnLoad_entityQuery");
      ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr___ChunkMapZoneSpawnOnLoad_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, "<>ChunkMapZoneSpawnOnLoad_profilerMarker");
      ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663526);
      ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663527);
      ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663528);
      ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_DeserializeMapZones_Private_Int32_Entity_TerrainChunkMetadata_NativeHashMap_2_MapZoneId_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663529);
      ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_RegisterMapZones_Private_Static_Void_BoundsMinMax_MapZoneId_MapZoneFlags_Entity_NativeHashMap_2_MapZoneId_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663530);
      ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663531);
      ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663532);
      ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663533);
      ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663534);
      ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr___GetEntityQuery_ForChunkMapZoneSpawnOnLoad_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663535);
    }

    public ChunkMapZoneSpawnOnLoad(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapZoneCollectionSystem _MapZoneCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__MapZoneCollectionSystem));
        return pointer == System.IntPtr.Zero ? (MapZoneCollectionSystem) null : new MapZoneCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__MapZoneCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _RequiredQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__RequiredQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__RequiredQuery)) = value;
      }
    }

    public unsafe Entity _MapZonePrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__MapZonePrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__MapZonePrefab)) = value;
      }
    }

    public unsafe EntityQuery __ChunkMapZoneSpawnOnLoad_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr___ChunkMapZoneSpawnOnLoad_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr___ChunkMapZoneSpawnOnLoad_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ChunkMapZoneSpawnOnLoad_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr___ChunkMapZoneSpawnOnLoad_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr___ChunkMapZoneSpawnOnLoad_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Terrain.ChunkMapZoneSpawnOnLoad/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_metadatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapZoneLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_spatialMapZoneCollection;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_TerrainChunkMetadataLoadedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref TerrainChunkMetadataLoadedEvent loadedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref loadedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_TerrainChunkMetadataLoadedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr);
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr_metadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr, nameof (metadatas));
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr_mapZoneLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr, nameof (mapZoneLookup));
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr_spatialMapZoneCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr, nameof (spatialMapZoneCollection));
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr, 100663536);
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_TerrainChunkMetadataLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr, 100663537);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0>.NativeClassPtr, data));
      }

      public unsafe ChunkMapZoneSpawnOnLoad __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ChunkMapZoneSpawnOnLoad) null : new ChunkMapZoneSpawnOnLoad(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<TerrainChunk, Entity> metadatas
      {
        get
        {
          return *(NativeHashMap<TerrainChunk, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr_metadatas));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr_metadatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<TerrainChunk, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<MapZoneId, SpatialMapZoneData> mapZoneLookup
      {
        get
        {
          return *(NativeHashMap<MapZoneId, SpatialMapZoneData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr_mapZoneLookup));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr_mapZoneLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<MapZoneId, SpatialMapZoneData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<FixedList512<SpatialMapZoneData>> spatialMapZoneCollection
      {
        get
        {
          return *(NativeArray<FixedList512<SpatialMapZoneData>>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr_spatialMapZoneCollection));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0.NativeFieldInfoPtr_spatialMapZoneCollection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<FixedList512<SpatialMapZoneData>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Terrain.ChunkMapZoneSpawnOnLoad/ProjectM.Terrain.<>c__DisplayClass_ChunkMapZoneSpawnOnLoad")]
    public sealed class __c__DisplayClass_ChunkMapZoneSpawnOnLoad : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_metadatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapZoneLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_spatialMapZoneCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TerrainChunkMetadataLoadedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkMapZoneSpawnOnLoad_byref___c__DisplayClass7_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1192198, RefRangeEnd = 1192199, XrefRangeStart = 1192170, XrefRangeEnd = 1192198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref TerrainChunkMetadataLoadedEvent loadedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref loadedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TerrainChunkMetadataLoadedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192199, XrefRangeEnd = 1192200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1192201, RefRangeEnd = 1192202, XrefRangeStart = 1192200, XrefRangeEnd = 1192201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192202, XrefRangeEnd = 1192212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1192218, RefRangeEnd = 1192219, XrefRangeStart = 1192212, XrefRangeEnd = 1192218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1192220, RefRangeEnd = 1192221, XrefRangeStart = 1192219, XrefRangeEnd = 1192220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ChunkMapZoneSpawnOnLoad componentSystem,
        ref ChunkMapZoneSpawnOnLoad.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkMapZoneSpawnOnLoad_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ChunkMapZoneSpawnOnLoad()
      {
        Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad>.NativeClassPtr, "<>c__DisplayClass_ChunkMapZoneSpawnOnLoad");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr);
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, "<>4__this");
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr_metadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (metadatas));
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr_mapZoneLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (mapZoneLookup));
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr_spatialMapZoneCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (spatialMapZoneCollection));
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (_runtimes));
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (_performLambdaDelegate));
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TerrainChunkMetadataLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663538);
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663539);
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663540);
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663542);
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663543);
        ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkMapZoneSpawnOnLoad_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, 100663544);
      }

      public __c__DisplayClass_ChunkMapZoneSpawnOnLoad(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_ChunkMapZoneSpawnOnLoad()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, data));
      }

      public unsafe ChunkMapZoneSpawnOnLoad __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ChunkMapZoneSpawnOnLoad) null : new ChunkMapZoneSpawnOnLoad(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<TerrainChunk, Entity> metadatas
      {
        get
        {
          return *(NativeHashMap<TerrainChunk, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr_metadatas));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr_metadatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<TerrainChunk, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<MapZoneId, SpatialMapZoneData> mapZoneLookup
      {
        get
        {
          return *(NativeHashMap<MapZoneId, SpatialMapZoneData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr_mapZoneLookup));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr_mapZoneLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<MapZoneId, SpatialMapZoneData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<FixedList512<SpatialMapZoneData>> spatialMapZoneCollection
      {
        get
        {
          return *(NativeArray<FixedList512<SpatialMapZoneData>>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr_spatialMapZoneCollection));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr_spatialMapZoneCollection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<FixedList512<SpatialMapZoneData>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_loadedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkMapZoneSpawnOnLoad_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<TerrainChunkMetadataLoadedEvent> forParameter_loadedEvent;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192162, XrefRangeEnd = 1192165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ChunkMapZoneSpawnOnLoad componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkMapZoneSpawnOnLoad_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1192169, RefRangeEnd = 1192170, XrefRangeStart = 1192165, XrefRangeEnd = 1192169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_loadedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_loadedEvent));
          ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkMapZoneSpawnOnLoad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders>.NativeClassPtr, 100663545);
          ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders>.NativeClassPtr, 100663546);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_loadedEvent;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<TerrainChunkMetadataLoadedEvent>.StructuralChangeRuntime runtime_loadedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_loadedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_loadedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkMapZoneSpawnOnLoad.__c__DisplayClass_ChunkMapZoneSpawnOnLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
