// Decompiled with JetBrains decompiler
// Type: ProjectM.SubScenePrefabSpawnerSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Gameplay;
using ProjectM.Terrain;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class SubScenePrefabSpawnerSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnChainQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NeutralTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequiredPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnNetworkedSubScenePrefabs_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnNetworkedSubScenePrefabs_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnSpawnChainSubScenePrefabs_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnSpawnChainSubScenePrefabs_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ConvertNetworkedPrefabsOnDemand_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ConvertNetworkedPrefabsOnDemand_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ConvertNetworkedSpawnChainsOnDemand_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ConvertNetworkedSpawnChainsOnDemand_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertNetworkedPrefabsOnDemand_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindRequiredNetworkedChildrenRecursively_Private_Static_Void_NativeList_1_PrefabGUID_PrefabGUID_PrefabLookupMap_ComponentDataFromEntity_1_NetworkedPrefabChildren_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSceneDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawnNetworkedSubScenePrefabs_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawnSpawnChainSubScenePrefabs_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForConvertNetworkedPrefabsOnDemand_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForConvertNetworkedSpawnChainsOnDemand_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083865, XrefRangeEnd = 1083886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083886, XrefRangeEnd = 1083895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083895, XrefRangeEnd = 1083943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertNetworkedPrefabsOnDemand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_ConvertNetworkedPrefabsOnDemand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1083961, RefRangeEnd = 1083962, XrefRangeStart = 1083943, XrefRangeEnd = 1083961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FindRequiredNetworkedChildrenRecursively(
      NativeList<PrefabGUID> requiredPrefabs,
      PrefabGUID prefabGuid,
      PrefabLookupMap prefabLookupMap,
      ComponentDataFromEntity<NetworkedPrefabChildren> getNetworkedPrefabChildren)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &requiredPrefabs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getNetworkedPrefabChildren;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_FindRequiredNetworkedChildrenRecursively_Private_Static_Void_NativeList_1_PrefabGUID_PrefabGUID_PrefabLookupMap_ComponentDataFromEntity_1_NetworkedPrefabChildren_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddSceneMetadataDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkMetadataLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083962, XrefRangeEnd = 1083990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddSceneDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_AddSceneDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SubScenePrefabSpawnerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083990, XrefRangeEnd = 1084128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084128, XrefRangeEnd = 1084147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawnNetworkedSubScenePrefabs_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnNetworkedSubScenePrefabs_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084147, XrefRangeEnd = 1084166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawnSpawnChainSubScenePrefabs_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnSpawnChainSubScenePrefabs_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084166, XrefRangeEnd = 1084185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForConvertNetworkedPrefabsOnDemand_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForConvertNetworkedPrefabsOnDemand_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084185, XrefRangeEnd = 1084204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForConvertNetworkedSpawnChainsOnDemand_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForConvertNetworkedSpawnChainsOnDemand_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084208, RefRangeEnd = 1084209, XrefRangeStart = 1084204, XrefRangeEnd = 1084208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084213, RefRangeEnd = 1084214, XrefRangeStart = 1084209, XrefRangeEnd = 1084213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084218, RefRangeEnd = 1084219, XrefRangeStart = 1084214, XrefRangeEnd = 1084218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084223, RefRangeEnd = 1084224, XrefRangeStart = 1084219, XrefRangeEnd = 1084223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SubScenePrefabSpawnerSystem()
    {
      Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SubScenePrefabSpawnerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr);
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__NetworkedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, nameof (_NetworkedQuery));
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__SpawnChainQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, nameof (_SpawnChainQuery));
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__NeutralTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, nameof (_NeutralTeam));
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, nameof (_ServerTime));
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__RequiredPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, nameof (_RequiredPrefabs));
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnNetworkedSubScenePrefabs_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>SpawnNetworkedSubScenePrefabs_entityQuery");
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnNetworkedSubScenePrefabs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>SpawnNetworkedSubScenePrefabs_profilerMarker");
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnSpawnChainSubScenePrefabs_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>SpawnSpawnChainSubScenePrefabs_entityQuery");
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnSpawnChainSubScenePrefabs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>SpawnSpawnChainSubScenePrefabs_profilerMarker");
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedPrefabsOnDemand_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>ConvertNetworkedPrefabsOnDemand_entityQuery");
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedPrefabsOnDemand_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>ConvertNetworkedPrefabsOnDemand_profilerMarker");
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedSpawnChainsOnDemand_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>ConvertNetworkedSpawnChainsOnDemand_entityQuery");
      SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedSpawnChainsOnDemand_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>ConvertNetworkedSpawnChainsOnDemand_profilerMarker");
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685326);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685327);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685328);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_ConvertNetworkedPrefabsOnDemand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685329);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_FindRequiredNetworkedChildrenRecursively_Private_Static_Void_NativeList_1_PrefabGUID_PrefabGUID_PrefabLookupMap_ComponentDataFromEntity_1_NetworkedPrefabChildren_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685330);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685331);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_AddSceneDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685332);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685333);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685334);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnNetworkedSubScenePrefabs_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685335);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnSpawnChainSubScenePrefabs_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685336);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForConvertNetworkedPrefabsOnDemand_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685337);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForConvertNetworkedSpawnChainsOnDemand_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685338);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685339);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685340);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685341);
      SubScenePrefabSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, 100685342);
    }

    public SubScenePrefabSpawnerSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _NetworkedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__NetworkedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__NetworkedQuery)) = value;
      }
    }

    public unsafe EntityQuery _SpawnChainQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__SpawnChainQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__SpawnChainQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<NeutralTeam> _NeutralTeam
    {
      get
      {
        return *(SingletonAccessor<NeutralTeam>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__NeutralTeam));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__NeutralTeam), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<NeutralTeam>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<PrefabGUID> _RequiredPrefabs
    {
      get
      {
        return *(NativeList<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__RequiredPrefabs));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr__RequiredPrefabs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __SpawnNetworkedSubScenePrefabs_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnNetworkedSubScenePrefabs_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnNetworkedSubScenePrefabs_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnNetworkedSubScenePrefabs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnNetworkedSubScenePrefabs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnNetworkedSubScenePrefabs_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SpawnSpawnChainSubScenePrefabs_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnSpawnChainSubScenePrefabs_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnSpawnChainSubScenePrefabs_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnSpawnChainSubScenePrefabs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnSpawnChainSubScenePrefabs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___SpawnSpawnChainSubScenePrefabs_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ConvertNetworkedPrefabsOnDemand_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedPrefabsOnDemand_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedPrefabsOnDemand_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ConvertNetworkedPrefabsOnDemand_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedPrefabsOnDemand_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedPrefabsOnDemand_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ConvertNetworkedSpawnChainsOnDemand_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedSpawnChainsOnDemand_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedSpawnChainsOnDemand_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ConvertNetworkedSpawnChainsOnDemand_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedSpawnChainsOnDemand_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.NativeFieldInfoPtr___ConvertNetworkedSpawnChainsOnDemand_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/<>c__DisplayClass9_0")]
    public sealed class __c__DisplayClass9_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnAccessors;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_neutralTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref SubSceneNetworkedPrefab subScenePrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref subScenePrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity, [In] ref SubSceneSpawnChainPrefab subScenePrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref subScenePrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr);
        SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_spawnAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (spawnAccessors));
        SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
        SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_neutralTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (neutralTeam));
        SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (serverTime));
        SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, 100685343);
        SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, 100685344);
        SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, 100685345);
      }

      public __c__DisplayClass9_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass9_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, data));
      }

      public unsafe NetworkedSubScenePrefabSpawning.DataAccessors spawnAccessors
      {
        get
        {
          return *(NetworkedSubScenePrefabSpawning.DataAccessors*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_spawnAccessors));
        }
        [param: In] set
        {
          *(NetworkedSubScenePrefabSpawning.DataAccessors*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_spawnAccessors)) = value;
        }
      }

      public unsafe SubScenePrefabSpawnerSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SubScenePrefabSpawnerSystem) null : new SubScenePrefabSpawnerSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity neutralTeam
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_neutralTeam));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_neutralTeam)) = value;
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe ServerTime serverTime
      {
        get
        {
          return *(ServerTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(ServerTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubScenePrefabSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/<>c__DisplayClass13_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass13_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_convertOnDemand;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddSceneDependencies_b__0_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddSceneDependencies_b__1_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0;
      [FieldOffset(0)]
      public ConvertOnDemandContext convertOnDemand;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass13_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddSceneDependencies_b__0(
        Entity entity,
        [In] ref SubSceneNetworkedPrefab subScenePrefab)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref subScenePrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__AddSceneDependencies_b__0_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddSceneDependencies_b__1(
        Entity entity,
        [In] ref SubSceneSpawnChainPrefab subScenePrefab)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref subScenePrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__AddSceneDependencies_b__1_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass13_0()
      {
        Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass13_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass13_0>.NativeClassPtr);
        SubScenePrefabSpawnerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_convertOnDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (convertOnDemand));
        SubScenePrefabSpawnerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass13_0>.NativeClassPtr, 100685346);
        SubScenePrefabSpawnerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__AddSceneDependencies_b__0_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass13_0>.NativeClassPtr, 100685347);
        SubScenePrefabSpawnerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__AddSceneDependencies_b__1_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass13_0>.NativeClassPtr, 100685348);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass13_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_SpawnNetworkedSubScenePrefabs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SpawnNetworkedSubScenePrefabs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnAccessors;
      private static readonly System.IntPtr NativeFieldInfoPtr_neutralTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_StaticTransformIndex_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TeamReference_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Script_InspectTarget_Data_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ProfessorCoil_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NetworkedSubScenePrefabSpawning.DataAccessors spawnAccessors;
      [FieldOffset(208)]
      public Entity neutralTeam;
      [FieldOffset(216)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(232)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(264)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_1;
      [FieldOffset(296)]
      public ComponentDataFromEntity<StaticTransformIndex> _ComponentDataFromEntity_StaticTransformIndex_2;
      [FieldOffset(328)]
      public ComponentDataFromEntity<TeamReference> _ComponentDataFromEntity_TeamReference_3;
      [FieldOffset(360)]
      public ComponentDataFromEntity<Script_InspectTarget_Data> _ComponentDataFromEntity_Script_InspectTarget_Data_4;
      [FieldOffset(392)]
      public ComponentDataFromEntity<ProfessorCoil> _ComponentDataFromEntity_ProfessorCoil_5;
      [FieldOffset(424)]
      public SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(464)]
      public unsafe SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083380, XrefRangeEnd = 1083424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SubSceneNetworkedPrefab subScenePrefab)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref subScenePrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083424, RefRangeEnd = 1083425, XrefRangeStart = 1083424, XrefRangeEnd = 1083424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083425, RefRangeEnd = 1083426, XrefRangeStart = 1083425, XrefRangeEnd = 1083425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083426, XrefRangeEnd = 1083428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083434, RefRangeEnd = 1083435, XrefRangeStart = 1083428, XrefRangeEnd = 1083434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083455, RefRangeEnd = 1083456, XrefRangeStart = 1083435, XrefRangeEnd = 1083455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SubScenePrefabSpawnerSystem componentSystem,
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083456, XrefRangeEnd = 1083460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083460, XrefRangeEnd = 1083466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnNetworkedSubScenePrefabs()
      {
        Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_SpawnNetworkedSubScenePrefabs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr_spawnAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (spawnAccessors));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr_neutralTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (neutralTeam));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (spawnCommandBuffer));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_1));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_StaticTransformIndex_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_StaticTransformIndex_2));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_TeamReference_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_TeamReference_3));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_Script_InspectTarget_Data_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_Script_InspectTarget_Data_4));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_ProfessorCoil_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_ProfessorCoil_5));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (_runtimes));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, 100685349);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, 100685350);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, 100685351);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, 100685352);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, 100685353);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, 100685354);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, 100685355);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, 100685356);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_subScenePrefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SubSceneNetworkedPrefab> forParameter_subScenePrefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083299, RefRangeEnd = 1083300, XrefRangeStart = 1083295, XrefRangeEnd = 1083299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SubScenePrefabSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083304, RefRangeEnd = 1083305, XrefRangeStart = 1083300, XrefRangeEnd = 1083304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_subScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_subScenePrefab));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, 100685357);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, 100685358);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_subScenePrefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SubSceneNetworkedPrefab>.Runtime runtime_subScenePrefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_subScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_subScenePrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_SpawnNetworkedSubScenePrefabs/ProjectM.RunWithoutJobSystem_00004D63$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, "RunWithoutJobSystem_00004D63$PostfixBurstDelegate");
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685359);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685360);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685361);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685362);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_SpawnNetworkedSubScenePrefabs/ProjectM.RunWithoutJobSystem_00004D63$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083305, XrefRangeEnd = 1083319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083319, XrefRangeEnd = 1083337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083337, XrefRangeEnd = 1083352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083379, RefRangeEnd = 1083380, XrefRangeStart = 1083352, XrefRangeEnd = 1083379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs>.NativeClassPtr, "RunWithoutJobSystem_00004D63$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685363);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685364);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685365);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685366);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685368);
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
            IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnNetworkedSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_SpawnSpawnChainSubScenePrefabs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SpawnSpawnChainSubScenePrefabs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnAccessors;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_StaticTransformIndex_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SpawnChainConstants_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AutoChainInstanceData_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NetworkedSubScenePrefabSpawning.DataAccessors spawnAccessors;
      [FieldOffset(208)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(224)]
      public ServerTime serverTime;
      [FieldOffset(264)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(296)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_1;
      [FieldOffset(328)]
      public ComponentDataFromEntity<StaticTransformIndex> _ComponentDataFromEntity_StaticTransformIndex_2;
      [FieldOffset(360)]
      public ComponentDataFromEntity<SpawnChainData.SpawnChainConstants> _ComponentDataFromEntity_SpawnChainConstants_3;
      [FieldOffset(392)]
      public ComponentDataFromEntity<AutoChainInstanceData> _ComponentDataFromEntity_AutoChainInstanceData_4;
      [FieldOffset(424)]
      public SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(464)]
      public unsafe SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083551, XrefRangeEnd = 1083599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SubSceneSpawnChainPrefab subScenePrefab)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref subScenePrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083599, RefRangeEnd = 1083600, XrefRangeStart = 1083599, XrefRangeEnd = 1083599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083600, RefRangeEnd = 1083601, XrefRangeStart = 1083600, XrefRangeEnd = 1083600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083601, XrefRangeEnd = 1083603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083609, RefRangeEnd = 1083610, XrefRangeStart = 1083603, XrefRangeEnd = 1083609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083627, RefRangeEnd = 1083628, XrefRangeStart = 1083610, XrefRangeEnd = 1083627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SubScenePrefabSpawnerSystem componentSystem,
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083628, XrefRangeEnd = 1083632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083632, XrefRangeEnd = 1083638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnSpawnChainSubScenePrefabs()
      {
        Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_SpawnSpawnChainSubScenePrefabs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr_spawnAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (spawnAccessors));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (spawnCommandBuffer));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (serverTime));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_1));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_StaticTransformIndex_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_StaticTransformIndex_2));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_SpawnChainConstants_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_SpawnChainConstants_3));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_AutoChainInstanceData_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_AutoChainInstanceData_4));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (_runtimes));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, 100685369);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, 100685370);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, 100685371);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, 100685372);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, 100685373);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, 100685374);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, 100685375);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, 100685376);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_subScenePrefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SubSceneSpawnChainPrefab> forParameter_subScenePrefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083470, RefRangeEnd = 1083471, XrefRangeStart = 1083466, XrefRangeEnd = 1083470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SubScenePrefabSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083475, RefRangeEnd = 1083476, XrefRangeStart = 1083471, XrefRangeEnd = 1083475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_subScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_subScenePrefab));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, 100685377);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, 100685378);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_subScenePrefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SubSceneSpawnChainPrefab>.Runtime runtime_subScenePrefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_subScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_subScenePrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_SpawnSpawnChainSubScenePrefabs/ProjectM.RunWithoutJobSystem_00004D6C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, "RunWithoutJobSystem_00004D6C$PostfixBurstDelegate");
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685379);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685380);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685381);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685382);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_SpawnSpawnChainSubScenePrefabs/ProjectM.RunWithoutJobSystem_00004D6C$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083476, XrefRangeEnd = 1083490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083490, XrefRangeEnd = 1083508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083508, XrefRangeEnd = 1083523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083550, RefRangeEnd = 1083551, XrefRangeStart = 1083523, XrefRangeEnd = 1083550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs>.NativeClassPtr, "RunWithoutJobSystem_00004D6C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685383);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685384);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685385);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685386);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685388);
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
            IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_SpawnSpawnChainSubScenePrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_ConvertNetworkedPrefabsOnDemand")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ConvertNetworkedPrefabsOnDemand
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_convertOnDemand;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ConvertOnDemandContext convertOnDemand;
      [FieldOffset(64)]
      public SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1083727, RefRangeEnd = 1083729, XrefRangeStart = 1083723, XrefRangeEnd = 1083727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SubSceneNetworkedPrefab subScenePrefab)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref subScenePrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1083729, RefRangeEnd = 1083733, XrefRangeStart = 1083729, XrefRangeEnd = 1083729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1083733, RefRangeEnd = 1083736, XrefRangeStart = 1083733, XrefRangeEnd = 1083733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083736, XrefRangeEnd = 1083738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083744, RefRangeEnd = 1083745, XrefRangeStart = 1083738, XrefRangeEnd = 1083744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083747, RefRangeEnd = 1083748, XrefRangeStart = 1083745, XrefRangeEnd = 1083747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SubScenePrefabSpawnerSystem componentSystem,
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083748, XrefRangeEnd = 1083752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083752, XrefRangeEnd = 1083758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ConvertNetworkedPrefabsOnDemand()
      {
        Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_ConvertNetworkedPrefabsOnDemand");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeFieldInfoPtr_convertOnDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, nameof (convertOnDemand));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, nameof (_runtimes));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneNetworkedPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, 100685389);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, 100685390);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, 100685391);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, 100685392);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, 100685393);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, 100685394);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, 100685395);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, 100685396);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_subScenePrefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SubSceneNetworkedPrefab> forParameter_subScenePrefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083642, RefRangeEnd = 1083643, XrefRangeStart = 1083638, XrefRangeEnd = 1083642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SubScenePrefabSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083647, RefRangeEnd = 1083648, XrefRangeStart = 1083643, XrefRangeEnd = 1083647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_subScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_subScenePrefab));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, 100685397);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, 100685398);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_subScenePrefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SubSceneNetworkedPrefab>.Runtime runtime_subScenePrefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_subScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_subScenePrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_ConvertNetworkedPrefabsOnDemand/ProjectM.RunWithoutJobSystem_00004D75$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, "RunWithoutJobSystem_00004D75$PostfixBurstDelegate");
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685399);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685400);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685401);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685402);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_ConvertNetworkedPrefabsOnDemand/ProjectM.RunWithoutJobSystem_00004D75$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083648, XrefRangeEnd = 1083662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083662, XrefRangeEnd = 1083680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083680, XrefRangeEnd = 1083695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083722, RefRangeEnd = 1083723, XrefRangeStart = 1083695, XrefRangeEnd = 1083722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand>.NativeClassPtr, "RunWithoutJobSystem_00004D75$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685403);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685404);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685405);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685406);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685408);
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
            IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedPrefabsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_convertOnDemand;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ConvertOnDemandContext convertOnDemand;
      [FieldOffset(64)]
      public SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1083727, RefRangeEnd = 1083729, XrefRangeStart = 1083727, XrefRangeEnd = 1083729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SubSceneSpawnChainPrefab subScenePrefab)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref subScenePrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1083729, RefRangeEnd = 1083733, XrefRangeStart = 1083729, XrefRangeEnd = 1083733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1083733, RefRangeEnd = 1083736, XrefRangeStart = 1083733, XrefRangeEnd = 1083736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083843, XrefRangeEnd = 1083845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083851, RefRangeEnd = 1083852, XrefRangeStart = 1083845, XrefRangeEnd = 1083851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1083854, RefRangeEnd = 1083855, XrefRangeStart = 1083852, XrefRangeEnd = 1083854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SubScenePrefabSpawnerSystem componentSystem,
        ref SubScenePrefabSpawnerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083855, XrefRangeEnd = 1083859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083859, XrefRangeEnd = 1083865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand()
      {
        Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeFieldInfoPtr_convertOnDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, nameof (convertOnDemand));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, nameof (_runtimes));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SubSceneSpawnChainPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, 100685409);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, 100685410);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, 100685411);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, 100685412);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, 100685413);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, 100685414);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, 100685415);
        SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, 100685416);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_subScenePrefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SubSceneSpawnChainPrefab> forParameter_subScenePrefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083762, RefRangeEnd = 1083763, XrefRangeStart = 1083758, XrefRangeEnd = 1083762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SubScenePrefabSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083767, RefRangeEnd = 1083768, XrefRangeStart = 1083763, XrefRangeEnd = 1083767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_subScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_subScenePrefab));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SubScenePrefabSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, 100685417);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, 100685418);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_subScenePrefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SubSceneSpawnChainPrefab>.Runtime runtime_subScenePrefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_subScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_subScenePrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand/ProjectM.RunWithoutJobSystem_00004D7E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, "RunWithoutJobSystem_00004D7E$PostfixBurstDelegate");
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685419);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685420);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685421);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685422);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SubScenePrefabSpawnerSystem/ProjectM.<>c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand/ProjectM.RunWithoutJobSystem_00004D7E$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083768, XrefRangeEnd = 1083782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083782, XrefRangeEnd = 1083800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083800, XrefRangeEnd = 1083815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1083842, RefRangeEnd = 1083843, XrefRangeStart = 1083815, XrefRangeEnd = 1083842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand>.NativeClassPtr, "RunWithoutJobSystem_00004D7E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685423);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685424);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685425);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685426);
          SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685428);
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
            IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SubScenePrefabSpawnerSystem.__c__DisplayClass_ConvertNetworkedSpawnChainsOnDemand.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
