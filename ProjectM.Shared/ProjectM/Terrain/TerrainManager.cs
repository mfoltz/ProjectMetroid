// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainManager
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Scenes;

#nullable disable
namespace ProjectM.Terrain
{
  public class TerrainManager : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__InputJobHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkMetadataLoadedEventPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkLoadedEventPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkUnloadedEventPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkMetadatasToInitializeQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewLoadedMetadataQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewTerrainChunksQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnloadedTerrainChunksQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataInitializedSingleton;
    private static readonly System.IntPtr NativeFieldInfoPtr__RuntimeSettingsSingleton;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadedTerrainChunkSceneEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadedTerrainChunkEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainChunkMetadatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__SubSceneMetadataEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkDatabaseInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitingForChunksToLoadOnStartupCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsServer;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainChunksJobHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitingForChunksToLoadOnStartup;
    private static readonly System.IntPtr NativeFieldInfoPtr__ScenesLoadedThisSession;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitializeTerrainFlags;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsWorldInitialized_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ChunkDatabaseInitialized_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_WaitingForChunksToLoadOnStartupCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunksAndComplete_Public_TerrainChunkLookup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunksAsync_Public_TerrainChunkLookup_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetScenesLoadedThisSession_Public_NativeHashSet_1_SubSceneGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkMetadatas_Public_NativeHashMap_2_TerrainChunk_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnloadChunk_Public_Void_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUnloadChunkScene_Private_Void_ChunkSceneId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeMetadatas_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrLoadSceneMetadataEntity_Public_Entity_Boolean_SubSceneGUID_byref_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadChunk_Public_Entity_TerrainChunk_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadChunkScene_Private_Entity_LoadTerrainChunkRequest_Boolean_byref_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadChunkCustom_Public_Static_Entity_SceneSystem_LoadTerrainChunkRequest_LoadToTargetWorld_SceneLoadFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe bool IsWorldInitialized
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 767671, RefRangeEnd = 767680, XrefRangeStart = 767670, XrefRangeEnd = 767671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_get_IsWorldInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool ChunkDatabaseInitialized
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_get_ChunkDatabaseInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int WaitingForChunksToLoadOnStartupCount
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_get_WaitingForChunksToLoadOnStartupCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 767681, RefRangeEnd = 767697, XrefRangeStart = 767680, XrefRangeEnd = 767681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerrainChunkLookup GetChunksAndComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_GetChunksAndComplete_Public_TerrainChunkLookup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunkLookup*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 767698, RefRangeEnd = 767709, XrefRangeStart = 767697, XrefRangeEnd = 767698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerrainChunkLookup GetChunksAsync(out JobHandle inputDeps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref inputDeps;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_GetChunksAsync_Public_TerrainChunkLookup_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunkLookup*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe NativeHashSet<ProjectM.SubSceneGUID> GetScenesLoadedThisSession()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_GetScenesLoadedThisSession_Public_NativeHashSet_1_SubSceneGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeHashSet<ProjectM.SubSceneGUID>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 762015, RefRangeEnd = 762027, XrefRangeStart = 762015, XrefRangeEnd = 762027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddInputJobHandle(JobHandle jobHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &jobHandle;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe NativeHashMap<TerrainChunk, Entity> GetChunkMetadatas()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_GetChunkMetadatas_Public_NativeHashMap_2_TerrainChunk_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeHashMap<TerrainChunk, Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767709, XrefRangeEnd = 767850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TerrainManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767863, RefRangeEnd = 767864, XrefRangeStart = 767850, XrefRangeEnd = 767863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnloadChunk(TerrainChunk terrainChunk)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &terrainChunk;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_UnloadChunk_Public_Void_TerrainChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767864, XrefRangeEnd = 767876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryUnloadChunkScene(ChunkSceneId chunkSceneId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &chunkSceneId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_TryUnloadChunkScene_Private_Void_ChunkSceneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767876, XrefRangeEnd = 767901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TerrainManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767901, XrefRangeEnd = 767955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TerrainManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767996, RefRangeEnd = 767997, XrefRangeStart = 767955, XrefRangeEnd = 767996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeMetadatas()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_InitializeMetadatas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768004, RefRangeEnd = 768005, XrefRangeStart = 767997, XrefRangeEnd = 768004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetOrLoadSceneMetadataEntity(
      bool loadIfMissing,
      ProjectM.SubSceneGUID subSceneGUID,
      out bool startedLoading,
      int loadPriority = 1)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &loadIfMissing;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &subSceneGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref startedLoading;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &loadPriority;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_GetOrLoadSceneMetadataEntity_Public_Entity_Boolean_SubSceneGUID_byref_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 768033, RefRangeEnd = 768035, XrefRangeStart = 768005, XrefRangeEnd = 768033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity TryLoadChunk(TerrainChunk chunk, bool loadSynchronously = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadSynchronously;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_TryLoadChunk_Public_Entity_TerrainChunk_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768107, RefRangeEnd = 768108, XrefRangeStart = 768035, XrefRangeEnd = 768107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity TryLoadChunkScene(
      LoadTerrainChunkRequest request,
      bool trimPersistentData,
      out bool startedLoadingMetadata,
      bool loadSynchronously = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &trimPersistentData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref startedLoadingMetadata;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &loadSynchronously;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_TryLoadChunkScene_Private_Entity_LoadTerrainChunkRequest_Boolean_byref_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768108, XrefRangeEnd = 768129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity LoadChunkCustom(
      SceneSystem sceneSystem,
      LoadTerrainChunkRequest loadTerrainChunkRequest,
      LoadToTargetWorld loadToTargetWorld,
      SceneLoadFlags customFlags = (SceneLoadFlags) 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sceneSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadTerrainChunkRequest;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &loadToTargetWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &customFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr_LoadChunkCustom_Public_Static_Entity_SceneSystem_LoadTerrainChunkRequest_LoadToTargetWorld_SceneLoadFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerrainManager()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TerrainManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TerrainManager()
    {
      Il2CppClassPointerStore<TerrainManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr);
      TerrainManager.NativeFieldInfoPtr__InputJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_InputJobHandle));
      TerrainManager.NativeFieldInfoPtr__ChunkMetadataLoadedEventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_ChunkMetadataLoadedEventPrefab));
      TerrainManager.NativeFieldInfoPtr__ChunkLoadedEventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_ChunkLoadedEventPrefab));
      TerrainManager.NativeFieldInfoPtr__ChunkUnloadedEventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_ChunkUnloadedEventPrefab));
      TerrainManager.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_EventQuery));
      TerrainManager.NativeFieldInfoPtr__ChunkMetadatasToInitializeQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_ChunkMetadatasToInitializeQuery));
      TerrainManager.NativeFieldInfoPtr__NewLoadedMetadataQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_NewLoadedMetadataQuery));
      TerrainManager.NativeFieldInfoPtr__NewTerrainChunksQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_NewTerrainChunksQuery));
      TerrainManager.NativeFieldInfoPtr__UnloadedTerrainChunksQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_UnloadedTerrainChunksQuery));
      TerrainManager.NativeFieldInfoPtr__SceneSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_SceneSystem));
      TerrainManager.NativeFieldInfoPtr__GameDataInitializedSingleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_GameDataInitializedSingleton));
      TerrainManager.NativeFieldInfoPtr__RuntimeSettingsSingleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_RuntimeSettingsSingleton));
      TerrainManager.NativeFieldInfoPtr__LoadedTerrainChunkSceneEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_LoadedTerrainChunkSceneEntities));
      TerrainManager.NativeFieldInfoPtr__LoadedTerrainChunkEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_LoadedTerrainChunkEntities));
      TerrainManager.NativeFieldInfoPtr__TerrainChunkMetadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_TerrainChunkMetadatas));
      TerrainManager.NativeFieldInfoPtr__SubSceneMetadataEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_SubSceneMetadataEntities));
      TerrainManager.NativeFieldInfoPtr__ChunkDatabaseInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_ChunkDatabaseInitialized));
      TerrainManager.NativeFieldInfoPtr__WaitingForChunksToLoadOnStartupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_WaitingForChunksToLoadOnStartupCount));
      TerrainManager.NativeFieldInfoPtr__IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_IsServer));
      TerrainManager.NativeFieldInfoPtr__TerrainChunksJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_TerrainChunksJobHandle));
      TerrainManager.NativeFieldInfoPtr__WaitingForChunksToLoadOnStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_WaitingForChunksToLoadOnStartup));
      TerrainManager.NativeFieldInfoPtr__ScenesLoadedThisSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (_ScenesLoadedThisSession));
      TerrainManager.NativeFieldInfoPtr_InitializeTerrainFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (InitializeTerrainFlags));
      TerrainManager.NativeMethodInfoPtr_get_IsWorldInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667926);
      TerrainManager.NativeMethodInfoPtr_get_ChunkDatabaseInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667927);
      TerrainManager.NativeMethodInfoPtr_get_WaitingForChunksToLoadOnStartupCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667928);
      TerrainManager.NativeMethodInfoPtr_GetChunksAndComplete_Public_TerrainChunkLookup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667929);
      TerrainManager.NativeMethodInfoPtr_GetChunksAsync_Public_TerrainChunkLookup_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667930);
      TerrainManager.NativeMethodInfoPtr_GetScenesLoadedThisSession_Public_NativeHashSet_1_SubSceneGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667931);
      TerrainManager.NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667932);
      TerrainManager.NativeMethodInfoPtr_GetChunkMetadatas_Public_NativeHashMap_2_TerrainChunk_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667933);
      TerrainManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667934);
      TerrainManager.NativeMethodInfoPtr_UnloadChunk_Public_Void_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667935);
      TerrainManager.NativeMethodInfoPtr_TryUnloadChunkScene_Private_Void_ChunkSceneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667936);
      TerrainManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667937);
      TerrainManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667938);
      TerrainManager.NativeMethodInfoPtr_InitializeMetadatas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667939);
      TerrainManager.NativeMethodInfoPtr_GetOrLoadSceneMetadataEntity_Public_Entity_Boolean_SubSceneGUID_byref_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667940);
      TerrainManager.NativeMethodInfoPtr_TryLoadChunk_Public_Entity_TerrainChunk_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667941);
      TerrainManager.NativeMethodInfoPtr_TryLoadChunkScene_Private_Entity_LoadTerrainChunkRequest_Boolean_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667942);
      TerrainManager.NativeMethodInfoPtr_LoadChunkCustom_Public_Static_Entity_SceneSystem_LoadTerrainChunkRequest_LoadToTargetWorld_SceneLoadFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667943);
      TerrainManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667944);
      TerrainManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, 100667945);
    }

    public TerrainManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe JobHandleManager _InputJobHandle
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__InputJobHandle));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__InputJobHandle)) = value;
      }
    }

    public unsafe Entity _ChunkMetadataLoadedEventPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ChunkMetadataLoadedEventPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ChunkMetadataLoadedEventPrefab)) = value;
      }
    }

    public unsafe Entity _ChunkLoadedEventPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ChunkLoadedEventPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ChunkLoadedEventPrefab)) = value;
      }
    }

    public unsafe Entity _ChunkUnloadedEventPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ChunkUnloadedEventPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ChunkUnloadedEventPrefab)) = value;
      }
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe EntityQuery _ChunkMetadatasToInitializeQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ChunkMetadatasToInitializeQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ChunkMetadatasToInitializeQuery)) = value;
      }
    }

    public unsafe EntityQuery _NewLoadedMetadataQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__NewLoadedMetadataQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__NewLoadedMetadataQuery)) = value;
      }
    }

    public unsafe EntityQuery _NewTerrainChunksQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__NewTerrainChunksQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__NewTerrainChunksQuery)) = value;
      }
    }

    public unsafe EntityQuery _UnloadedTerrainChunksQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__UnloadedTerrainChunksQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__UnloadedTerrainChunksQuery)) = value;
      }
    }

    public unsafe SceneSystem _SceneSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__SceneSystem));
        return pointer == System.IntPtr.Zero ? (SceneSystem) null : new SceneSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__SceneSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<GameDataInitializedSingleton> _GameDataInitializedSingleton
    {
      get
      {
        return *(SingletonAccessor<GameDataInitializedSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__GameDataInitializedSingleton));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__GameDataInitializedSingleton), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<GameDataInitializedSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerRuntimeSettings> _RuntimeSettingsSingleton
    {
      get
      {
        return *(SingletonAccessor<ServerRuntimeSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__RuntimeSettingsSingleton));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__RuntimeSettingsSingleton), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerRuntimeSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<ChunkSceneId, Entity> _LoadedTerrainChunkSceneEntities
    {
      get
      {
        return *(NativeHashMap<ChunkSceneId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__LoadedTerrainChunkSceneEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__LoadedTerrainChunkSceneEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<ChunkSceneId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<ChunkSceneId, Entity> _LoadedTerrainChunkEntities
    {
      get
      {
        return *(NativeHashMap<ChunkSceneId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__LoadedTerrainChunkEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__LoadedTerrainChunkEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<ChunkSceneId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<TerrainChunk, Entity> _TerrainChunkMetadatas
    {
      get
      {
        return *(NativeHashMap<TerrainChunk, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__TerrainChunkMetadatas));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__TerrainChunkMetadatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<TerrainChunk, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<ProjectM.SubSceneGUID, Entity> _SubSceneMetadataEntities
    {
      get
      {
        return *(NativeHashMap<ProjectM.SubSceneGUID, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__SubSceneMetadataEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__SubSceneMetadataEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<ProjectM.SubSceneGUID, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _ChunkDatabaseInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ChunkDatabaseInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ChunkDatabaseInitialized)) = value;
      }
    }

    public unsafe int _WaitingForChunksToLoadOnStartupCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__WaitingForChunksToLoadOnStartupCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__WaitingForChunksToLoadOnStartupCount)) = value;
      }
    }

    public unsafe bool _IsServer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__IsServer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__IsServer)) = value;
      }
    }

    public unsafe JobHandleManager _TerrainChunksJobHandle
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__TerrainChunksJobHandle));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__TerrainChunksJobHandle)) = value;
      }
    }

    public unsafe NativeHashSet<TerrainChunk> _WaitingForChunksToLoadOnStartup
    {
      get
      {
        return *(NativeHashSet<TerrainChunk>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__WaitingForChunksToLoadOnStartup));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__WaitingForChunksToLoadOnStartup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<TerrainChunk>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashSet<ProjectM.SubSceneGUID> _ScenesLoadedThisSession
    {
      get
      {
        return *(NativeHashSet<ProjectM.SubSceneGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ScenesLoadedThisSession));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr__ScenesLoadedThisSession), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<ProjectM.SubSceneGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe InitializeTerrainFlags InitializeTerrainFlags
    {
      get
      {
        return *(InitializeTerrainFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr_InitializeTerrainFlags));
      }
      [param: In] set
      {
        *(InitializeTerrainFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerrainManager.NativeFieldInfoPtr_InitializeTerrainFlags)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ProcessedMetadataTag
    {
      static ProcessedMetadataTag()
      {
        Il2CppClassPointerStore<TerrainManager.ProcessedMetadataTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (ProcessedMetadataTag));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainManager.ProcessedMetadataTag>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainManager.ProcessedMetadataTag>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LoadedMetadataTag
    {
      static LoadedMetadataTag()
      {
        Il2CppClassPointerStore<TerrainManager.LoadedMetadataTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (LoadedMetadataTag));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainManager.LoadedMetadataTag>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainManager.LoadedMetadataTag>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StartedLoadingTag
    {
      static StartedLoadingTag()
      {
        Il2CppClassPointerStore<TerrainManager.StartedLoadingTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (StartedLoadingTag));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainManager.StartedLoadingTag>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainManager.StartedLoadingTag>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RegisteredLoadedTerrainChunk
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SceneId;
      [FieldOffset(0)]
      public ChunkSceneId SceneId;

      static RegisteredLoadedTerrainChunk()
      {
        Il2CppClassPointerStore<TerrainManager.RegisteredLoadedTerrainChunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (RegisteredLoadedTerrainChunk));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainManager.RegisteredLoadedTerrainChunk>.NativeClassPtr);
        TerrainManager.RegisteredLoadedTerrainChunk.NativeFieldInfoPtr_SceneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisteredLoadedTerrainChunk>.NativeClassPtr, nameof (SceneId));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainManager.RegisteredLoadedTerrainChunk>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RegisterNewTerrainsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkSceneIdType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_WaitingForChunksToLoad;
      private static readonly System.IntPtr NativeFieldInfoPtr_LoadedEventPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsServer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<ChunkSceneId> ChunkSceneIdType;
      [FieldOffset(40)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(56)]
      public NativeHashMap<ChunkSceneId, Entity> TerrainChunks;
      [FieldOffset(72)]
      public NativeHashSet<TerrainChunk> WaitingForChunksToLoad;
      [FieldOffset(88)]
      public Entity LoadedEventPrefab;
      [FieldOffset(96)]
      public bool IsServer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767547, XrefRangeEnd = 767589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TerrainManager.RegisterNewTerrainsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RegisterNewTerrainsJob()
      {
        Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (RegisterNewTerrainsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr);
        TerrainManager.RegisterNewTerrainsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr, nameof (EntityType));
        TerrainManager.RegisterNewTerrainsJob.NativeFieldInfoPtr_ChunkSceneIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr, nameof (ChunkSceneIdType));
        TerrainManager.RegisterNewTerrainsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr, nameof (CommandBuffer));
        TerrainManager.RegisterNewTerrainsJob.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr, nameof (TerrainChunks));
        TerrainManager.RegisterNewTerrainsJob.NativeFieldInfoPtr_WaitingForChunksToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr, nameof (WaitingForChunksToLoad));
        TerrainManager.RegisterNewTerrainsJob.NativeFieldInfoPtr_LoadedEventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr, nameof (LoadedEventPrefab));
        TerrainManager.RegisterNewTerrainsJob.NativeFieldInfoPtr_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr, nameof (IsServer));
        TerrainManager.RegisterNewTerrainsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr, 100667946);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainManager.RegisterNewTerrainsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UnregisterDeletedTerrainsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_RegisterDataType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnloadedEventPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsServer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<TerrainManager.RegisteredLoadedTerrainChunk> RegisterDataType;
      [FieldOffset(40)]
      public Entity UnloadedEventPrefab;
      [FieldOffset(48)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(64)]
      public NativeHashMap<ChunkSceneId, Entity> TerrainChunks;
      [FieldOffset(80)]
      public bool IsServer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767589, XrefRangeEnd = 767627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TerrainManager.UnregisterDeletedTerrainsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UnregisterDeletedTerrainsJob()
      {
        Il2CppClassPointerStore<TerrainManager.UnregisterDeletedTerrainsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (UnregisterDeletedTerrainsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedTerrainsJob>.NativeClassPtr);
        TerrainManager.UnregisterDeletedTerrainsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedTerrainsJob>.NativeClassPtr, nameof (EntityType));
        TerrainManager.UnregisterDeletedTerrainsJob.NativeFieldInfoPtr_RegisterDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedTerrainsJob>.NativeClassPtr, nameof (RegisterDataType));
        TerrainManager.UnregisterDeletedTerrainsJob.NativeFieldInfoPtr_UnloadedEventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedTerrainsJob>.NativeClassPtr, nameof (UnloadedEventPrefab));
        TerrainManager.UnregisterDeletedTerrainsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedTerrainsJob>.NativeClassPtr, nameof (CommandBuffer));
        TerrainManager.UnregisterDeletedTerrainsJob.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedTerrainsJob>.NativeClassPtr, nameof (TerrainChunks));
        TerrainManager.UnregisterDeletedTerrainsJob.NativeFieldInfoPtr_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedTerrainsJob>.NativeClassPtr, nameof (IsServer));
        TerrainManager.UnregisterDeletedTerrainsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedTerrainsJob>.NativeClassPtr, 100667947);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedTerrainsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UnregisterDeletedLoadRequestsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_LoadRequestFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_LoadedTerrainChunkSceneEntities;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<LoadTerrainChunkRequest> LoadRequestFromEntity;
      [FieldOffset(32)]
      public NativeHashMap<ChunkSceneId, Entity> LoadedTerrainChunkSceneEntities;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767627, XrefRangeEnd = 767653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TerrainManager.UnregisterDeletedLoadRequestsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UnregisterDeletedLoadRequestsJob()
      {
        Il2CppClassPointerStore<TerrainManager.UnregisterDeletedLoadRequestsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (UnregisterDeletedLoadRequestsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedLoadRequestsJob>.NativeClassPtr);
        TerrainManager.UnregisterDeletedLoadRequestsJob.NativeFieldInfoPtr_LoadRequestFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedLoadRequestsJob>.NativeClassPtr, nameof (LoadRequestFromEntity));
        TerrainManager.UnregisterDeletedLoadRequestsJob.NativeFieldInfoPtr_LoadedTerrainChunkSceneEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedLoadRequestsJob>.NativeClassPtr, nameof (LoadedTerrainChunkSceneEntities));
        TerrainManager.UnregisterDeletedLoadRequestsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedLoadRequestsJob>.NativeClassPtr, 100667948);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainManager.UnregisterDeletedLoadRequestsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RegisterNewMetadatasJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkMetadataType;
      private static readonly System.IntPtr NativeFieldInfoPtr_SceneMetadataEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSceneReference;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetResolvedSections;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_LoadedEventPrefab;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<TerrainChunkMetadata> ChunkMetadataType;
      [FieldOffset(40)]
      public NativeHashMap<ProjectM.SubSceneGUID, Entity> SceneMetadataEntities;
      [FieldOffset(56)]
      public ComponentDataFromEntity<SceneReference> GetSceneReference;
      [FieldOffset(88)]
      public BufferFromEntity<ResolvedSectionEntity> GetResolvedSections;
      [FieldOffset(128)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(144)]
      public Entity LoadedEventPrefab;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767653, XrefRangeEnd = 767670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TerrainManager.RegisterNewMetadatasJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RegisterNewMetadatasJob()
      {
        Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainManager>.NativeClassPtr, nameof (RegisterNewMetadatasJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr);
        TerrainManager.RegisterNewMetadatasJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr, nameof (EntityType));
        TerrainManager.RegisterNewMetadatasJob.NativeFieldInfoPtr_ChunkMetadataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr, nameof (ChunkMetadataType));
        TerrainManager.RegisterNewMetadatasJob.NativeFieldInfoPtr_SceneMetadataEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr, nameof (SceneMetadataEntities));
        TerrainManager.RegisterNewMetadatasJob.NativeFieldInfoPtr_GetSceneReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr, nameof (GetSceneReference));
        TerrainManager.RegisterNewMetadatasJob.NativeFieldInfoPtr_GetResolvedSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr, nameof (GetResolvedSections));
        TerrainManager.RegisterNewMetadatasJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr, nameof (CommandBuffer));
        TerrainManager.RegisterNewMetadatasJob.NativeFieldInfoPtr_LoadedEventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr, nameof (LoadedEventPrefab));
        TerrainManager.RegisterNewMetadatasJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr, 100667949);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainManager.RegisterNewMetadatasJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
