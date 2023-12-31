// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkObjectManager
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Terrain
{
  public class ChunkObjectManager : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkWaypoints;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkPortals;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetherSpawnPositions;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewChunkObjectOwners;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequiredQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollectionJobHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindNewChunkObjectOwnersJob_Build_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindNewChunkObjectOwnersJob_Build_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnObjects_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_7;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkWaypointsAsync_Public_NativeHashMap_2_TerrainChunk_ChunkWaypointData_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkPortalsAsync_Public_NativeHashMap_2_TerrainChunk_FixedList512_1_ChunkPortalData_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNetherSpawnPositionsAsync_Public_NativeList_1_NetherSpawnPositionData_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindNewLoadedChunkObjectOwners_Build_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnObjects_Private_Void_EntityCommandBuffer_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateChunkObject_Private_Static_Entity_EntityCommandBuffer_TerrainChunk_StaticTransformIndex_byref_float4x4_byref_float4x4_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSceneDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFindNewChunkObjectOwnersJob_Build_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 766346, RefRangeEnd = 766348, XrefRangeStart = 766346, XrefRangeEnd = 766346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeHashMap<TerrainChunk, ChunkWaypointData> GetChunkWaypointsAsync(
      out JobHandle deps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref deps;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr_GetChunkWaypointsAsync_Public_NativeHashMap_2_TerrainChunk_ChunkWaypointData_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeHashMap<TerrainChunk, ChunkWaypointData>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 766348, RefRangeEnd = 766351, XrefRangeStart = 766348, XrefRangeEnd = 766348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeHashMap<TerrainChunk, FixedList512<ChunkPortalData>> GetChunkPortalsAsync(
      out JobHandle deps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref deps;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr_GetChunkPortalsAsync_Public_NativeHashMap_2_TerrainChunk_FixedList512_1_ChunkPortalData_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeHashMap<TerrainChunk, FixedList512<ChunkPortalData>>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 766351, RefRangeEnd = 766355, XrefRangeStart = 766351, XrefRangeEnd = 766351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<NetherSpawnPositionData> GetNetherSpawnPositionsAsync(
      out JobHandle deps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref deps;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr_GetNetherSpawnPositionsAsync_Public_NativeList_1_NetherSpawnPositionData_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<NetherSpawnPositionData>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766355, XrefRangeEnd = 766387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkObjectManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766387, XrefRangeEnd = 766399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkObjectManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766399, XrefRangeEnd = 766422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkObjectManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766436, RefRangeEnd = 766437, XrefRangeStart = 766422, XrefRangeEnd = 766436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FindNewLoadedChunkObjectOwners_Build()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr_FindNewLoadedChunkObjectOwners_Build_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766463, RefRangeEnd = 766464, XrefRangeStart = 766437, XrefRangeEnd = 766463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SpawnObjects(EntityCommandBuffer commandBuffer, bool serverWasLoaded)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &serverWasLoaded;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr_SpawnObjects_Private_Void_EntityCommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 766481, RefRangeEnd = 766484, XrefRangeStart = 766464, XrefRangeEnd = 766481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity InstantiateChunkObject(
      EntityCommandBuffer commandBuffer,
      TerrainChunk terrainChunk,
      StaticTransformIndex staticTransformIndex,
      [In] ref float4x4 chunkTransform,
      [In] ref float4x4 chunkObjectTRS,
      Entity prefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &staticTransformIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunkTransform;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunkObjectTRS;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr_InstantiateChunkObject_Private_Static_Entity_EntityCommandBuffer_TerrainChunk_StaticTransformIndex_byref_float4x4_byref_float4x4_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddSceneDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr_AddSceneDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766484, XrefRangeEnd = 766519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddSceneMetadataDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkMetadataLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkObjectManager()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766519, XrefRangeEnd = 766575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkObjectManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766575, XrefRangeEnd = 766591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFindNewChunkObjectOwnersJob_Build_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr___GetEntityQuery_ForFindNewChunkObjectOwnersJob_Build_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766595, RefRangeEnd = 766596, XrefRangeStart = 766591, XrefRangeEnd = 766595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766600, RefRangeEnd = 766601, XrefRangeStart = 766596, XrefRangeEnd = 766600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkObjectManager()
    {
      Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkObjectManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr);
      ChunkObjectManager.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (_SpawnBarrier));
      ChunkObjectManager.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ChunkObjectManager.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (_TerrainManager));
      ChunkObjectManager.NativeFieldInfoPtr__ChunkWaypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (_ChunkWaypoints));
      ChunkObjectManager.NativeFieldInfoPtr__ChunkPortals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (_ChunkPortals));
      ChunkObjectManager.NativeFieldInfoPtr__NetherSpawnPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (_NetherSpawnPositions));
      ChunkObjectManager.NativeFieldInfoPtr__NewChunkObjectOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (_NewChunkObjectOwners));
      ChunkObjectManager.NativeFieldInfoPtr__RequiredQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (_RequiredQuery));
      ChunkObjectManager.NativeFieldInfoPtr_CollectionJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (CollectionJobHandle));
      ChunkObjectManager.NativeFieldInfoPtr___FindNewChunkObjectOwnersJob_Build_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, "<>FindNewChunkObjectOwnersJob_Build_entityQuery");
      ChunkObjectManager.NativeFieldInfoPtr___FindNewChunkObjectOwnersJob_Build_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, "<>FindNewChunkObjectOwnersJob_Build_profilerMarker");
      ChunkObjectManager.NativeFieldInfoPtr___SpawnObjects_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, "<>SpawnObjects_LambdaJob0_profilerMarker");
      ChunkObjectManager.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_7));
      ChunkObjectManager.NativeMethodInfoPtr_GetChunkWaypointsAsync_Public_NativeHashMap_2_TerrainChunk_ChunkWaypointData_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667708);
      ChunkObjectManager.NativeMethodInfoPtr_GetChunkPortalsAsync_Public_NativeHashMap_2_TerrainChunk_FixedList512_1_ChunkPortalData_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667709);
      ChunkObjectManager.NativeMethodInfoPtr_GetNetherSpawnPositionsAsync_Public_NativeList_1_NetherSpawnPositionData_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667710);
      ChunkObjectManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667711);
      ChunkObjectManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667712);
      ChunkObjectManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667713);
      ChunkObjectManager.NativeMethodInfoPtr_FindNewLoadedChunkObjectOwners_Build_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667714);
      ChunkObjectManager.NativeMethodInfoPtr_SpawnObjects_Private_Void_EntityCommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667715);
      ChunkObjectManager.NativeMethodInfoPtr_InstantiateChunkObject_Private_Static_Entity_EntityCommandBuffer_TerrainChunk_StaticTransformIndex_byref_float4x4_byref_float4x4_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667716);
      ChunkObjectManager.NativeMethodInfoPtr_AddSceneDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667717);
      ChunkObjectManager.NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667718);
      ChunkObjectManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667719);
      ChunkObjectManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667720);
      ChunkObjectManager.NativeMethodInfoPtr___GetEntityQuery_ForFindNewChunkObjectOwnersJob_Build_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667721);
      ChunkObjectManager.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667722);
      ChunkObjectManager.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, 100667723);
    }

    public ChunkObjectManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeHashMap<TerrainChunk, ChunkWaypointData> _ChunkWaypoints
    {
      get
      {
        return *(NativeHashMap<TerrainChunk, ChunkWaypointData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__ChunkWaypoints));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__ChunkWaypoints), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<TerrainChunk, ChunkWaypointData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<TerrainChunk, FixedList512<ChunkPortalData>> _ChunkPortals
    {
      get
      {
        return *(NativeHashMap<TerrainChunk, FixedList512<ChunkPortalData>>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__ChunkPortals));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__ChunkPortals), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<TerrainChunk, FixedList512<ChunkPortalData>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<NetherSpawnPositionData> _NetherSpawnPositions
    {
      get
      {
        return *(NativeList<NetherSpawnPositionData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__NetherSpawnPositions));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__NetherSpawnPositions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<NetherSpawnPositionData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<ChunkObjectManager.NewChunkObjectOwnerToProcess> _NewChunkObjectOwners
    {
      get
      {
        return *(NativeList<ChunkObjectManager.NewChunkObjectOwnerToProcess>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__NewChunkObjectOwners));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__NewChunkObjectOwners), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ChunkObjectManager.NewChunkObjectOwnerToProcess>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _RequiredQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__RequiredQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__RequiredQuery)) = value;
      }
    }

    public unsafe JobHandle CollectionJobHandle
    {
      get
      {
        return *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr_CollectionJobHandle));
      }
      [param: In] set
      {
        *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr_CollectionJobHandle)) = value;
      }
    }

    public unsafe EntityQuery __FindNewChunkObjectOwnersJob_Build_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr___FindNewChunkObjectOwnersJob_Build_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr___FindNewChunkObjectOwnersJob_Build_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FindNewChunkObjectOwnersJob_Build_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr___FindNewChunkObjectOwnersJob_Build_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr___FindNewChunkObjectOwnersJob_Build_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnObjects_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr___SpawnObjects_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr___SpawnObjects_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_7
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_7));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_7)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NewChunkObjectOwnerToProcess
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkObjectOwnerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Chunk;
      [FieldOffset(0)]
      public Entity ChunkObjectOwnerEntity;
      [FieldOffset(8)]
      public TerrainChunk Chunk;

      static NewChunkObjectOwnerToProcess()
      {
        Il2CppClassPointerStore<ChunkObjectManager.NewChunkObjectOwnerToProcess>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, nameof (NewChunkObjectOwnerToProcess));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkObjectManager.NewChunkObjectOwnerToProcess>.NativeClassPtr);
        ChunkObjectManager.NewChunkObjectOwnerToProcess.NativeFieldInfoPtr_ChunkObjectOwnerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.NewChunkObjectOwnerToProcess>.NativeClassPtr, nameof (ChunkObjectOwnerEntity));
        ChunkObjectManager.NewChunkObjectOwnerToProcess.NativeFieldInfoPtr_Chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.NewChunkObjectOwnerToProcess>.NativeClassPtr, nameof (Chunk));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkObjectManager.NewChunkObjectOwnerToProcess>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Terrain.ChunkObjectManager/<>c__DisplayClass16_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass16_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_newChunkObjectOwners;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__FindNewLoadedChunkObjectOwners_Build_b__0_Internal_Void_byref_TerrainChunkLoadedEvent_0;
      [FieldOffset(0)]
      public NativeList<ChunkObjectManager.NewChunkObjectOwnerToProcess> newChunkObjectOwners;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass16_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _FindNewLoadedChunkObjectOwners_Build_b__0(
        [In] ref TerrainChunkLoadedEvent loadedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref loadedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass16_0.NativeMethodInfoPtr__FindNewLoadedChunkObjectOwners_Build_b__0_Internal_Void_byref_TerrainChunkLoadedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass16_0()
      {
        Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, "<>c__DisplayClass16_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass16_0>.NativeClassPtr);
        ChunkObjectManager.__c__DisplayClass16_0.NativeFieldInfoPtr_newChunkObjectOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass16_0>.NativeClassPtr, nameof (newChunkObjectOwners));
        ChunkObjectManager.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass16_0>.NativeClassPtr, 100667724);
        ChunkObjectManager.__c__DisplayClass16_0.NativeMethodInfoPtr__FindNewLoadedChunkObjectOwners_Build_b__0_Internal_Void_byref_TerrainChunkLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass16_0>.NativeClassPtr, 100667725);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass16_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Terrain.ChunkObjectManager/<>c__DisplayClass17_0")]
    public sealed class __c__DisplayClass17_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr_metadatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_getChunkMetadata;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverWasLoaded;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_lookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTerrainPortals;
      private static readonly System.IntPtr NativeFieldInfoPtr_getChunkPortal;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SpawnObjects_b__0_Internal_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass17_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SpawnObjects_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass17_0.NativeMethodInfoPtr__SpawnObjects_b__0_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass17_0()
      {
        Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, "<>c__DisplayClass17_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr);
        ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_entitiesToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, nameof (entitiesToProcess));
        ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_metadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, nameof (metadatas));
        ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_getChunkMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, nameof (getChunkMetadata));
        ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_serverWasLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, nameof (serverWasLoaded));
        ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
        ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_lookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, nameof (lookupMap));
        ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, nameof (commandBuffer));
        ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_getTerrainPortals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, nameof (getTerrainPortals));
        ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_getChunkPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, nameof (getChunkPortal));
        ChunkObjectManager.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, 100667726);
        ChunkObjectManager.__c__DisplayClass17_0.NativeMethodInfoPtr__SpawnObjects_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, 100667727);
      }

      public __c__DisplayClass17_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass17_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass17_0>.NativeClassPtr, data));
      }

      public unsafe NativeList<ChunkObjectManager.NewChunkObjectOwnerToProcess> entitiesToProcess
      {
        get
        {
          return *(NativeList<ChunkObjectManager.NewChunkObjectOwnerToProcess>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_entitiesToProcess));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_entitiesToProcess), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ChunkObjectManager.NewChunkObjectOwnerToProcess>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<TerrainChunk, Entity> metadatas
      {
        get
        {
          return *(NativeHashMap<TerrainChunk, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_metadatas));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_metadatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<TerrainChunk, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<TerrainChunkMetadata> getChunkMetadata
      {
        get
        {
          return *(ComponentDataFromEntity<TerrainChunkMetadata>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_getChunkMetadata));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_getChunkMetadata), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<TerrainChunkMetadata>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool serverWasLoaded
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_serverWasLoaded));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_serverWasLoaded)) = value;
        }
      }

      public unsafe ChunkObjectManager __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ChunkObjectManager) null : new ChunkObjectManager(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap lookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_lookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_lookupMap)) = value;
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe BufferFromEntity<TerrainChunkPortalBuffer> getTerrainPortals
      {
        get
        {
          return *(BufferFromEntity<TerrainChunkPortalBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_getTerrainPortals));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_getTerrainPortals), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<TerrainChunkPortalBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<ChunkPortal> getChunkPortal
      {
        get
        {
          return *(ComponentDataFromEntity<ChunkPortal>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_getChunkPortal));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkObjectManager.__c__DisplayClass17_0.NativeFieldInfoPtr_getChunkPortal), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<ChunkPortal>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Terrain.ChunkObjectManager/ProjectM.Terrain.<>c__DisplayClass_FindNewChunkObjectOwnersJob_Build")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FindNewChunkObjectOwnersJob_Build
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_newChunkObjectOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TerrainChunkLoadedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkObjectManager_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<ChunkObjectManager.NewChunkObjectOwnerToProcess> newChunkObjectOwners;
      [FieldOffset(16)]
      public ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766082, XrefRangeEnd = 766085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref TerrainChunkLoadedEvent loadedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref loadedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TerrainChunkLoadedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ChunkObjectManager.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ChunkObjectManager.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766085, XrefRangeEnd = 766087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 766092, RefRangeEnd = 766093, XrefRangeStart = 766087, XrefRangeEnd = 766092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 766095, RefRangeEnd = 766096, XrefRangeStart = 766093, XrefRangeEnd = 766095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ChunkObjectManager componentSystem,
        ref ChunkObjectManager.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkObjectManager_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766096, XrefRangeEnd = 766100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766100, XrefRangeEnd = 766106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindNewChunkObjectOwnersJob_Build()
      {
        Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, "<>c__DisplayClass_FindNewChunkObjectOwnersJob_Build");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr);
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeFieldInfoPtr_newChunkObjectOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, nameof (newChunkObjectOwners));
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, nameof (_runtimes));
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TerrainChunkLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, 100667728);
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, 100667729);
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, 100667730);
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, 100667731);
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, 100667732);
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkObjectManager_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, 100667733);
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, 100667734);
        ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, 100667735);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_loadedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkObjectManager_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<TerrainChunkLoadedEvent> forParameter_loadedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 766002, RefRangeEnd = 766003, XrefRangeStart = 765999, XrefRangeEnd = 766002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ChunkObjectManager componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkObjectManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 766006, RefRangeEnd = 766007, XrefRangeStart = 766003, XrefRangeEnd = 766006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_loadedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_loadedEvent));
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders>.NativeClassPtr, 100667736);
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders>.NativeClassPtr, 100667737);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_loadedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<TerrainChunkLoadedEvent>.Runtime runtime_loadedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_loadedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_loadedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Terrain.ChunkObjectManager/ProjectM.Terrain.<>c__DisplayClass_FindNewChunkObjectOwnersJob_Build/ProjectM.Terrain.RunWithoutJobSystem_00000F68$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, "RunWithoutJobSystem_00000F68$PostfixBurstDelegate");
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667738);
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667739);
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667740);
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667741);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Terrain.ChunkObjectManager/ProjectM.Terrain.<>c__DisplayClass_FindNewChunkObjectOwnersJob_Build/ProjectM.Terrain.RunWithoutJobSystem_00000F68$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766007, XrefRangeEnd = 766021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766021, XrefRangeEnd = 766039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766039, XrefRangeEnd = 766054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 766081, RefRangeEnd = 766082, XrefRangeStart = 766054, XrefRangeEnd = 766081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build>.NativeClassPtr, "RunWithoutJobSystem_00000F68$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667742);
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667743);
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667744);
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667745);
          ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667747);
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
            IL2CPP.il2cpp_field_static_get_value(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChunkObjectManager.__c__DisplayClass_FindNewChunkObjectOwnersJob_Build.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Terrain.ChunkObjectManager/ProjectM.Terrain.<>c__DisplayClass_SpawnObjects_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SpawnObjects_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr_metadatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_getChunkMetadata;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverWasLoaded;
      private static readonly System.IntPtr NativeFieldInfoPtr_lookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTerrainPortals;
      private static readonly System.IntPtr NativeFieldInfoPtr_getChunkPortal;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ChunkWaypointMetadata_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_NetherSpawnPositionMetadata_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ChunkScenePortalMetadata_2;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkObjectManager_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeList<ChunkObjectManager.NewChunkObjectOwnerToProcess> entitiesToProcess;
      [FieldOffset(16)]
      public NativeHashMap<TerrainChunk, Entity> metadatas;
      [FieldOffset(32)]
      public ComponentDataFromEntity<TerrainChunkMetadata> getChunkMetadata;
      [FieldOffset(64)]
      public bool serverWasLoaded;
      [FieldOffset(72)]
      public PrefabLookupMap lookupMap;
      [FieldOffset(120)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(136)]
      public BufferFromEntity<TerrainChunkPortalBuffer> getTerrainPortals;
      [FieldOffset(176)]
      public ComponentDataFromEntity<ChunkPortal> getChunkPortal;
      [FieldOffset(208)]
      public ComponentDataFromEntity<ChunkWaypointMetadata> _ComponentDataFromEntity_ChunkWaypointMetadata_0;
      [FieldOffset(240)]
      public ComponentDataFromEntity<NetherSpawnPositionMetadata> _ComponentDataFromEntity_NetherSpawnPositionMetadata_1;
      [FieldOffset(272)]
      public ComponentDataFromEntity<ChunkScenePortalMetadata> _ComponentDataFromEntity_ChunkScenePortalMetadata_2;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766181, XrefRangeEnd = 766325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 766325, RefRangeEnd = 766326, XrefRangeStart = 766325, XrefRangeEnd = 766325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ChunkObjectManager.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 766326, RefRangeEnd = 766327, XrefRangeStart = 766326, XrefRangeEnd = 766326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ChunkObjectManager.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 766328, RefRangeEnd = 766329, XrefRangeStart = 766327, XrefRangeEnd = 766328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 766339, RefRangeEnd = 766340, XrefRangeStart = 766329, XrefRangeEnd = 766339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ChunkObjectManager componentSystem,
        ref ChunkObjectManager.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkObjectManager_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766340, XrefRangeEnd = 766344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 766345, RefRangeEnd = 766346, XrefRangeStart = 766344, XrefRangeEnd = 766345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnObjects_LambdaJob0()
      {
        Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager>.NativeClassPtr, "<>c__DisplayClass_SpawnObjects_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr);
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_entitiesToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (entitiesToProcess));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_metadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (metadatas));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_getChunkMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (getChunkMetadata));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_serverWasLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (serverWasLoaded));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_lookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (lookupMap));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (commandBuffer));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_getTerrainPortals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (getTerrainPortals));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_getChunkPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (getChunkPortal));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_ChunkWaypointMetadata_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_ChunkWaypointMetadata_0));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_NetherSpawnPositionMetadata_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_NetherSpawnPositionMetadata_1));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_ChunkScenePortalMetadata_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_ChunkScenePortalMetadata_2));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, 100667748);
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, 100667749);
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, 100667750);
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, 100667751);
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChunkObjectManager_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, 100667752);
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, 100667753);
        ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, 100667754);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.Terrain.ChunkObjectManager/ProjectM.Terrain.<>c__DisplayClass_SpawnObjects_LambdaJob0/ProjectM.Terrain.RunWithoutJobSystem_00000F70$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000F70$PostfixBurstDelegate");
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100667755);
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100667756);
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100667757);
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100667758);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Terrain.ChunkObjectManager/ProjectM.Terrain.<>c__DisplayClass_SpawnObjects_LambdaJob0/ProjectM.Terrain.RunWithoutJobSystem_00000F70$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766106, XrefRangeEnd = 766120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766120, XrefRangeEnd = 766138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766138, XrefRangeEnd = 766153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 766180, RefRangeEnd = 766181, XrefRangeStart = 766153, XrefRangeEnd = 766180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000F70$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667759);
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667760);
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667761);
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667762);
          ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667764);
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
            IL2CPP.il2cpp_field_static_get_value(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChunkObjectManager.__c__DisplayClass_SpawnObjects_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
