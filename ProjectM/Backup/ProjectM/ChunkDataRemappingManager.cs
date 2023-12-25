// Decompiled with JetBrains decompiler
// Type: ProjectM.ChunkDataRemappingManager
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class ChunkDataRemappingManager : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplacedDropTablesByChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplacedRandomizedSpawnChainsByChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplacedMapIconNamesByChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConvertOnDemand;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapIconNamesReplaced;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleLoadedChunks_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_WorldAssetSingleton_14;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDropTableByChunkLookup_Public_ChunkRemappingLookup_1_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomizedSpawnChainByChunkLookup_Public_ChunkRemappingLookup_1_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMapIconNameByChunkLookup_Public_ChunkRemappingLookup_1_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleLoadedChunks_Private_Void_NativeArray_1_TerrainChunkLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1012652, RefRangeEnd = 1012653, XrefRangeStart = 1012651, XrefRangeEnd = 1012652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkRemappingLookup<PrefabGUID> GetDropTableByChunkLookup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.NativeMethodInfoPtr_GetDropTableByChunkLookup_Public_ChunkRemappingLookup_1_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ChunkRemappingLookup<PrefabGUID>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1012654, RefRangeEnd = 1012655, XrefRangeStart = 1012653, XrefRangeEnd = 1012654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkRemappingLookup<PrefabGUID> GetRandomizedSpawnChainByChunkLookup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.NativeMethodInfoPtr_GetRandomizedSpawnChainByChunkLookup_Public_ChunkRemappingLookup_1_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ChunkRemappingLookup<PrefabGUID>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1012656, RefRangeEnd = 1012657, XrefRangeStart = 1012655, XrefRangeEnd = 1012656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkRemappingLookup<LocalizationKey> GetMapIconNameByChunkLookup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.NativeMethodInfoPtr_GetMapIconNameByChunkLookup_Public_ChunkRemappingLookup_1_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ChunkRemappingLookup<LocalizationKey>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012657, XrefRangeEnd = 1012675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkDataRemappingManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012675, XrefRangeEnd = 1012686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkDataRemappingManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012686, XrefRangeEnd = 1012730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkDataRemappingManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1012745, RefRangeEnd = 1012746, XrefRangeStart = 1012730, XrefRangeEnd = 1012745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleLoadedChunks(
      NativeArray<TerrainChunkLoadedEvent> chunkLoadedEvents)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &chunkLoadedEvents;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.NativeMethodInfoPtr_HandleLoadedChunks_Private_Void_NativeArray_1_TerrainChunkLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkMetadataLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012746, XrefRangeEnd = 1012780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkDataRemappingManager()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012780, XrefRangeEnd = 1012804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkDataRemappingManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1012808, RefRangeEnd = 1012809, XrefRangeStart = 1012804, XrefRangeEnd = 1012808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkDataRemappingManager()
    {
      Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ChunkDataRemappingManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr);
      ChunkDataRemappingManager.NativeFieldInfoPtr__EntityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, nameof (_EntityQuery));
      ChunkDataRemappingManager.NativeFieldInfoPtr__ReplacedDropTablesByChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, nameof (_ReplacedDropTablesByChunk));
      ChunkDataRemappingManager.NativeFieldInfoPtr__ReplacedRandomizedSpawnChainsByChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, nameof (_ReplacedRandomizedSpawnChainsByChunk));
      ChunkDataRemappingManager.NativeFieldInfoPtr__ReplacedMapIconNamesByChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, nameof (_ReplacedMapIconNamesByChunk));
      ChunkDataRemappingManager.NativeFieldInfoPtr__ConvertOnDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, nameof (_ConvertOnDemand));
      ChunkDataRemappingManager.NativeFieldInfoPtr__MapIconNamesReplaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, nameof (_MapIconNamesReplaced));
      ChunkDataRemappingManager.NativeFieldInfoPtr___HandleLoadedChunks_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, "<>HandleLoadedChunks_LambdaJob0_profilerMarker");
      ChunkDataRemappingManager.NativeFieldInfoPtr__SingletonEntityQuery_WorldAssetSingleton_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, nameof (_SingletonEntityQuery_WorldAssetSingleton_14));
      ChunkDataRemappingManager.NativeMethodInfoPtr_GetDropTableByChunkLookup_Public_ChunkRemappingLookup_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678890);
      ChunkDataRemappingManager.NativeMethodInfoPtr_GetRandomizedSpawnChainByChunkLookup_Public_ChunkRemappingLookup_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678891);
      ChunkDataRemappingManager.NativeMethodInfoPtr_GetMapIconNameByChunkLookup_Public_ChunkRemappingLookup_1_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678892);
      ChunkDataRemappingManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678893);
      ChunkDataRemappingManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678894);
      ChunkDataRemappingManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678895);
      ChunkDataRemappingManager.NativeMethodInfoPtr_HandleLoadedChunks_Private_Void_NativeArray_1_TerrainChunkLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678896);
      ChunkDataRemappingManager.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678897);
      ChunkDataRemappingManager.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678898);
      ChunkDataRemappingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678899);
      ChunkDataRemappingManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678900);
      ChunkDataRemappingManager.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, 100678901);
    }

    public ChunkDataRemappingManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _EntityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__EntityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__EntityQuery)) = value;
      }
    }

    public unsafe NativeHashMap<ChunkRemapping_Unboxed<PrefabGUID>, PrefabGUID> _ReplacedDropTablesByChunk
    {
      get
      {
        return *(NativeHashMap<ChunkRemapping_Unboxed<PrefabGUID>, PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__ReplacedDropTablesByChunk));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__ReplacedDropTablesByChunk), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<ChunkRemapping_Unboxed<PrefabGUID>, PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<ChunkRemapping_Unboxed<PrefabGUID>, PrefabGUID> _ReplacedRandomizedSpawnChainsByChunk
    {
      get
      {
        return *(NativeHashMap<ChunkRemapping_Unboxed<PrefabGUID>, PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__ReplacedRandomizedSpawnChainsByChunk));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__ReplacedRandomizedSpawnChainsByChunk), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<ChunkRemapping_Unboxed<PrefabGUID>, PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<ChunkRemapping_Unboxed<LocalizationKey>, LocalizationKey> _ReplacedMapIconNamesByChunk
    {
      get
      {
        return *(NativeHashMap<ChunkRemapping_Unboxed<LocalizationKey>, LocalizationKey>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__ReplacedMapIconNamesByChunk));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__ReplacedMapIconNamesByChunk), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<ChunkRemapping_Unboxed<LocalizationKey>, LocalizationKey>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<PrefabGUID> _ConvertOnDemand
    {
      get
      {
        return *(NativeList<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__ConvertOnDemand));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__ConvertOnDemand), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _MapIconNamesReplaced
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__MapIconNamesReplaced));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__MapIconNamesReplaced)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleLoadedChunks_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr___HandleLoadedChunks_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr___HandleLoadedChunks_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_WorldAssetSingleton_14
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__SingletonEntityQuery_WorldAssetSingleton_14));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkDataRemappingManager.NativeFieldInfoPtr__SingletonEntityQuery_WorldAssetSingleton_14)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ChunkDataRemappingManager/<>c__DisplayClass12_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass12_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_chunkLoadedEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropTableHashMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_randomizedSpawnTableHashMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleLoadedChunks_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public NativeArray<TerrainChunkLoadedEvent> chunkLoadedEvents;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public NativeHashMap<ChunkRemapping_Unboxed<PrefabGUID>, PrefabGUID> dropTableHashMap;
      [FieldOffset(40)]
      public NativeHashMap<ChunkRemapping_Unboxed<PrefabGUID>, PrefabGUID> randomizedSpawnTableHashMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleLoadedChunks_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass12_0.NativeMethodInfoPtr__HandleLoadedChunks_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass12_0>.NativeClassPtr);
        ChunkDataRemappingManager.__c__DisplayClass12_0.NativeFieldInfoPtr_chunkLoadedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass12_0>.NativeClassPtr, nameof (chunkLoadedEvents));
        ChunkDataRemappingManager.__c__DisplayClass12_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass12_0>.NativeClassPtr, nameof (entityManager));
        ChunkDataRemappingManager.__c__DisplayClass12_0.NativeFieldInfoPtr_dropTableHashMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass12_0>.NativeClassPtr, nameof (dropTableHashMap));
        ChunkDataRemappingManager.__c__DisplayClass12_0.NativeFieldInfoPtr_randomizedSpawnTableHashMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass12_0>.NativeClassPtr, nameof (randomizedSpawnTableHashMap));
        ChunkDataRemappingManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass12_0>.NativeClassPtr, 100678902);
        ChunkDataRemappingManager.__c__DisplayClass12_0.NativeMethodInfoPtr__HandleLoadedChunks_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass12_0>.NativeClassPtr, 100678903);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass12_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ChunkDataRemappingManager/ProjectM.<>c__DisplayClass_HandleLoadedChunks_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleLoadedChunks_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_chunkLoadedEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropTableHashMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_randomizedSpawnTableHashMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkDataRemappingManager_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeArray<TerrainChunkLoadedEvent> chunkLoadedEvents;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public NativeHashMap<ChunkRemapping_Unboxed<PrefabGUID>, PrefabGUID> dropTableHashMap;
      [FieldOffset(40)]
      public NativeHashMap<ChunkRemapping_Unboxed<PrefabGUID>, PrefabGUID> randomizedSpawnTableHashMap;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012578, XrefRangeEnd = 1012615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1012615, RefRangeEnd = 1012616, XrefRangeStart = 1012615, XrefRangeEnd = 1012615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ChunkDataRemappingManager.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1012616, RefRangeEnd = 1012617, XrefRangeStart = 1012616, XrefRangeEnd = 1012616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ChunkDataRemappingManager.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1012618, RefRangeEnd = 1012619, XrefRangeStart = 1012617, XrefRangeEnd = 1012618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1012620, RefRangeEnd = 1012621, XrefRangeStart = 1012619, XrefRangeEnd = 1012620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ChunkDataRemappingManager componentSystem,
        ref ChunkDataRemappingManager.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkDataRemappingManager_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012621, XrefRangeEnd = 1012625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1012650, RefRangeEnd = 1012651, XrefRangeStart = 1012625, XrefRangeEnd = 1012650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleLoadedChunks_LambdaJob0()
      {
        Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkDataRemappingManager>.NativeClassPtr, "<>c__DisplayClass_HandleLoadedChunks_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr);
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeFieldInfoPtr_chunkLoadedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, nameof (chunkLoadedEvents));
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeFieldInfoPtr_dropTableHashMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, nameof (dropTableHashMap));
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeFieldInfoPtr_randomizedSpawnTableHashMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, nameof (randomizedSpawnTableHashMap));
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, 100678904);
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, 100678905);
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, 100678906);
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, 100678907);
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkDataRemappingManager_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, 100678908);
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, 100678909);
        ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, 100678910);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.ChunkDataRemappingManager/ProjectM.<>c__DisplayClass_HandleLoadedChunks_LambdaJob0/ProjectM.RunWithoutJobSystem_000039D8$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(11)]
        [CachedScanResults(RefRangeStart = 108813, RefRangeEnd = 108824, XrefRangeStart = 108813, XrefRangeEnd = 108824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000039D8$PostfixBurstDelegate");
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100678911);
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100678912);
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100678913);
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100678914);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ChunkDataRemappingManager/ProjectM.<>c__DisplayClass_HandleLoadedChunks_LambdaJob0/ProjectM.RunWithoutJobSystem_000039D8$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012503, XrefRangeEnd = 1012517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012517, XrefRangeEnd = 1012535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012535, XrefRangeEnd = 1012550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1012577, RefRangeEnd = 1012578, XrefRangeStart = 1012550, XrefRangeEnd = 1012577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000039D8$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678915);
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678916);
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678917);
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678918);
          ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678920);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChunkDataRemappingManager.__c__DisplayClass_HandleLoadedChunks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
