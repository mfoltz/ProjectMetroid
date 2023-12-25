// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainTransitionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class SpawnChainTransitionSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnChainTransitionResults;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChainsToProcess;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlacementSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__SystemName;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnChainDebugEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr___EnqueueTransitionEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___EnqueueTransitionEvents_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChainsToProcessAndComplete_Protected_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateSystem_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroySystem_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpawnChainTransitions_Protected_Void_EntityCommandBuffer_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintTransitions_Private_Void_NativeList_1_SpawnChainTransitionDebugInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabName_Private_String_PrefabCollectionSystem_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnChainPrefabInstance_Public_Static_Void_Entity_Entity_Int32_float3_quaternion_EntityCommandBuffer_Nullable_Unboxed_1_AutoChainTransitionConstants_Double_byref_TransitionDatas_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AttachEssentialSpawnChainInstanceComponents_Public_Static_Void_Entity_Int32_Entity_Entity_EntityCommandBuffer_Nullable_Unboxed_1_AutoChainTransitionConstants_Double_byref_TransitionDatas_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForEnqueueTransitionEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071696, XrefRangeEnd = 1071697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<Entity> GetChainsToProcessAndComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.NativeMethodInfoPtr_GetChainsToProcessAndComplete_Protected_NativeList_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071697, XrefRangeEnd = 1071721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071721, XrefRangeEnd = 1071734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnChainTransitionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnCreateSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnChainTransitionSystem.NativeMethodInfoPtr_OnCreateSystem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnDestroySystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnChainTransitionSystem.NativeMethodInfoPtr_OnDestroySystem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1071819, RefRangeEnd = 1071821, XrefRangeStart = 1071734, XrefRangeEnd = 1071819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSpawnChainTransitions(
      EntityCommandBuffer spawnCommandBuffer,
      EntityCommandBuffer destroyCommandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.NativeMethodInfoPtr_UpdateSpawnChainTransitions_Protected_Void_EntityCommandBuffer_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1071869, RefRangeEnd = 1071870, XrefRangeStart = 1071821, XrefRangeEnd = 1071869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintTransitions(
      NativeList<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo> transitions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &transitions;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.NativeMethodInfoPtr_PrintTransitions_Private_Void_NativeList_1_SpawnChainTransitionDebugInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1071933, RefRangeEnd = 1071936, XrefRangeStart = 1071870, XrefRangeEnd = 1071933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetPrefabName(PrefabCollectionSystem prefabCollection, Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.NativeMethodInfoPtr_GetPrefabName_Private_String_PrefabCollectionSystem_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1071951, RefRangeEnd = 1071953, XrefRangeStart = 1071936, XrefRangeEnd = 1071951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SpawnChainPrefabInstance(
      Entity spawnChain,
      Entity prefabEntity,
      int prefabChainElementIndex,
      float3 translation,
      quaternion rotation,
      EntityCommandBuffer spawnCommandBuffer,
      Nullable_Unboxed<AutoChainTransitionConstants> autoChainElementConstants,
      double forwardedAutoChainTransitionSurplus,
      ref SpawnChainTransitionSystem.TransitionDatas transitionDatas)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &spawnChain;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabChainElementIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &autoChainElementConstants;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &forwardedAutoChainTransitionSurplus;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref transitionDatas;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.NativeMethodInfoPtr_SpawnChainPrefabInstance_Public_Static_Void_Entity_Entity_Int32_float3_quaternion_EntityCommandBuffer_Nullable_Unboxed_1_AutoChainTransitionConstants_Double_byref_TransitionDatas_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1072012, RefRangeEnd = 1072014, XrefRangeStart = 1071953, XrefRangeEnd = 1072012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AttachEssentialSpawnChainInstanceComponents(
      Entity spawnChain,
      int spawnChainElementIndex,
      Entity newInstance,
      Entity spawnedPrefab,
      EntityCommandBuffer spawnCommandBuffer,
      Nullable_Unboxed<AutoChainTransitionConstants> autoChainElementConstants,
      double forwardedAutoChainTransitionSurplus,
      ref SpawnChainTransitionSystem.TransitionDatas transitionDatas)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &spawnChain;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnChainElementIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newInstance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnedPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &autoChainElementConstants;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &forwardedAutoChainTransitionSurplus;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref transitionDatas;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.NativeMethodInfoPtr_AttachEssentialSpawnChainInstanceComponents_Public_Static_Void_Entity_Int32_Entity_Entity_EntityCommandBuffer_Nullable_Unboxed_1_AutoChainTransitionConstants_Double_byref_TransitionDatas_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainTransitionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1072047, RefRangeEnd = 1072049, XrefRangeStart = 1072014, XrefRangeEnd = 1072047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnChainTransitionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072049, XrefRangeEnd = 1072065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForEnqueueTransitionEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.NativeMethodInfoPtr___GetEntityQuery_ForEnqueueTransitionEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1072069, RefRangeEnd = 1072070, XrefRangeStart = 1072065, XrefRangeEnd = 1072069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnChainTransitionSystem()
    {
      Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnChainTransitionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr);
      SpawnChainTransitionSystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (_EventQuery));
      SpawnChainTransitionSystem.NativeFieldInfoPtr__LastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (_LastFrame));
      SpawnChainTransitionSystem.NativeFieldInfoPtr__SpawnChainTransitionResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (_SpawnChainTransitionResults));
      SpawnChainTransitionSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      SpawnChainTransitionSystem.NativeFieldInfoPtr__ChainsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (_ChainsToProcess));
      SpawnChainTransitionSystem.NativeFieldInfoPtr__PlacementSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (_PlacementSystemData));
      SpawnChainTransitionSystem.NativeFieldInfoPtr__SystemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (_SystemName));
      SpawnChainTransitionSystem.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (_ServerTime));
      SpawnChainTransitionSystem.NativeFieldInfoPtr__SpawnChainDebugEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (_SpawnChainDebugEnabled));
      SpawnChainTransitionSystem.NativeFieldInfoPtr___EnqueueTransitionEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, "<>EnqueueTransitionEvents_entityQuery");
      SpawnChainTransitionSystem.NativeFieldInfoPtr___EnqueueTransitionEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, "<>EnqueueTransitionEvents_profilerMarker");
      SpawnChainTransitionSystem.NativeMethodInfoPtr_GetChainsToProcessAndComplete_Protected_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684415);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684416);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684417);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_OnCreateSystem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684418);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_OnDestroySystem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684419);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_UpdateSpawnChainTransitions_Protected_Void_EntityCommandBuffer_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684420);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_PrintTransitions_Private_Void_NativeList_1_SpawnChainTransitionDebugInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684421);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_GetPrefabName_Private_String_PrefabCollectionSystem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684422);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_SpawnChainPrefabInstance_Public_Static_Void_Entity_Entity_Int32_float3_quaternion_EntityCommandBuffer_Nullable_Unboxed_1_AutoChainTransitionConstants_Double_byref_TransitionDatas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684423);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_AttachEssentialSpawnChainInstanceComponents_Public_Static_Void_Entity_Int32_Entity_Entity_EntityCommandBuffer_Nullable_Unboxed_1_AutoChainTransitionConstants_Double_byref_TransitionDatas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684424);
      SpawnChainTransitionSystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684425);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684426);
      SpawnChainTransitionSystem.NativeMethodInfoPtr___GetEntityQuery_ForEnqueueTransitionEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684427);
      SpawnChainTransitionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, 100684428);
    }

    public SpawnChainTransitionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe JobHandle _LastFrame
    {
      get
      {
        return *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__LastFrame));
      }
      [param: In] set
      {
        *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__LastFrame)) = value;
      }
    }

    public unsafe NativeList<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo> _SpawnChainTransitionResults
    {
      get
      {
        return *(NativeList<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__SpawnChainTransitionResults));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__SpawnChainTransitionResults), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<Entity> _ChainsToProcess
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__ChainsToProcess));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__ChainsToProcess), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public GetPlacementResult.SystemData _PlacementSystemData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__PlacementSystemData);
        return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__PlacementSystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FixedString64 _SystemName
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__SystemName));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__SystemName)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<SpawnChainDebugEnabled> _SpawnChainDebugEnabled
    {
      get
      {
        return *(SingletonAccessor<SpawnChainDebugEnabled>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__SpawnChainDebugEnabled));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr__SpawnChainDebugEnabled), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SpawnChainDebugEnabled>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __EnqueueTransitionEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr___EnqueueTransitionEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr___EnqueueTransitionEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __EnqueueTransitionEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr___EnqueueTransitionEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.NativeFieldInfoPtr___EnqueueTransitionEvents_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SpawnChainTransitionDebugInfo
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Pos;
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;
      private static readonly System.IntPtr NativeFieldInfoPtr_Blocked;
      private static readonly System.IntPtr NativeFieldInfoPtr_TestedPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockedByEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockReason;
      [FieldOffset(0)]
      public float3 Pos;
      [FieldOffset(12)]
      public SpawnChainTransitionSystem.TransitionResult Result;
      [FieldOffset(16)]
      public bool Blocked;
      [FieldOffset(20)]
      public Entity TestedPrefab;
      [FieldOffset(28)]
      public Entity BlockedByEntity;
      [FieldOffset(36)]
      public BlockReason BlockReason;

      static SpawnChainTransitionDebugInfo()
      {
        Il2CppClassPointerStore<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (SpawnChainTransitionDebugInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>.NativeClassPtr);
        SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo.NativeFieldInfoPtr_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>.NativeClassPtr, nameof (Pos));
        SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>.NativeClassPtr, nameof (Result));
        SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo.NativeFieldInfoPtr_Blocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>.NativeClassPtr, nameof (Blocked));
        SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo.NativeFieldInfoPtr_TestedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>.NativeClassPtr, nameof (TestedPrefab));
        SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo.NativeFieldInfoPtr_BlockedByEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>.NativeClassPtr, nameof (BlockedByEntity));
        SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo.NativeFieldInfoPtr_BlockReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>.NativeClassPtr, nameof (BlockReason));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TransitionDatas
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerElapsedSeconds;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkedSpawnChainChild;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetStaticTransformCompatible;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetStaticTransformIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAutoChainInstanceData;
      [FieldOffset(0)]
      public double ServerElapsedSeconds;
      [FieldOffset(8)]
      public ComponentDataFromEntity<NetworkedSpawnChainChild> GetNetworkedSpawnChainChild;
      [FieldOffset(40)]
      public ComponentDataFromEntity<StaticTransformCompatible> GetStaticTransformCompatible;
      [FieldOffset(72)]
      public ComponentDataFromEntity<StaticTransformIndex> GetStaticTransformIndex;
      [FieldOffset(104)]
      public ComponentDataFromEntity<AutoChainInstanceData> GetAutoChainInstanceData;

      static TransitionDatas()
      {
        Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionDatas>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (TransitionDatas));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionDatas>.NativeClassPtr);
        SpawnChainTransitionSystem.TransitionDatas.NativeFieldInfoPtr_ServerElapsedSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionDatas>.NativeClassPtr, nameof (ServerElapsedSeconds));
        SpawnChainTransitionSystem.TransitionDatas.NativeFieldInfoPtr_GetNetworkedSpawnChainChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionDatas>.NativeClassPtr, nameof (GetNetworkedSpawnChainChild));
        SpawnChainTransitionSystem.TransitionDatas.NativeFieldInfoPtr_GetStaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionDatas>.NativeClassPtr, nameof (GetStaticTransformCompatible));
        SpawnChainTransitionSystem.TransitionDatas.NativeFieldInfoPtr_GetStaticTransformIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionDatas>.NativeClassPtr, nameof (GetStaticTransformIndex));
        SpawnChainTransitionSystem.TransitionDatas.NativeFieldInfoPtr_GetAutoChainInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionDatas>.NativeClassPtr, nameof (GetAutoChainInstanceData));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionDatas>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum TransitionResult
    {
      InvalidRequest,
      Success,
      EndOfChain,
      CancelTransition,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TransitionJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileModel;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRandomizedSpawnChainChild;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnChainChild;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnChain;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnChainInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAutoChainInstanceData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetActiveChildElement;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRandomizedSpawnChain;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChainTransitionResults;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkedSpawnChainChild;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetStaticTransformIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerElapsedSeconds;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementJobParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPlacementResultMarker;
      private static readonly System.IntPtr NativeFieldInfoPtr_ApplyPlacementResultMarker;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_byref_SpawnChainTransitionEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateActiveChainElementBasedOnResult_Private_Void_TransitionResultData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PrepareSpawn_Private_TransitionResultData_byref_SpawnChainTransitionEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsValidTransitionRequest_Private_Boolean_SpawnChainTransitionEvent_byref_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPrefabToSpawn_Private_Boolean_TransitionId_byref_SpawnChainTransitionEvent_SpawnChainConstants_byref_SpawnChainInstance_float4x4_Nullable_Unboxed_1_Int32_byref_Int32_byref_PrefabToSpawnData_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<TileModel> GetTileModel;
      [FieldOffset(32)]
      public ComponentDataFromEntity<RandomizedSpawnChainChild> GetRandomizedSpawnChainChild;
      [FieldOffset(64)]
      public ComponentDataFromEntity<SpawnChainChild> GetSpawnChainChild;
      [FieldOffset(96)]
      public ComponentDataFromEntity<SpawnChainData.SpawnChainConstants> GetSpawnChain;
      [FieldOffset(128)]
      public ComponentDataFromEntity<SpawnChainData.SpawnChainInstance> GetSpawnChainInstance;
      [FieldOffset(160)]
      public ComponentDataFromEntity<AutoChainInstanceData> GetAutoChainInstanceData;
      [FieldOffset(192)]
      public ComponentDataFromEntity<SpawnChainData.ActiveChildElement> GetActiveChildElement;
      [FieldOffset(224)]
      public ComponentDataFromEntity<RandomizedSpawnChain> GetRandomizedSpawnChain;
      [FieldOffset(256)]
      public NativeList<SpawnChainTransitionSystem.SpawnChainTransitionDebugInfo> SpawnChainTransitionResults;
      [FieldOffset(272)]
      public ComponentDataFromEntity<NetworkedSpawnChainChild> GetNetworkedSpawnChainChild;
      [FieldOffset(304)]
      public ComponentDataFromEntity<StaticTransformIndex> GetStaticTransformIndex;
      [FieldOffset(336)]
      public PrefabLookupMap PrefabLookupMap;
      [FieldOffset(384)]
      public double ServerElapsedSeconds;
      [FieldOffset(392)]
      public FullPlacementJobData PlacementJobParams;
      [FieldOffset(4360)]
      public ProfilerMarker GetPlacementResultMarker;
      [FieldOffset(4368)]
      public ProfilerMarker ApplyPlacementResultMarker;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071280, RefRangeEnd = 1071281, XrefRangeStart = 1071226, XrefRangeEnd = 1071280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute([In] ref SpawnChainTransitionEvent transitionEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref transitionEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.TransitionJob.NativeMethodInfoPtr_Execute_Public_Void_byref_SpawnChainTransitionEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1071301, RefRangeEnd = 1071304, XrefRangeStart = 1071281, XrefRangeEnd = 1071301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateActiveChainElementBasedOnResult(
        SpawnChainTransitionSystem.TransitionJob.TransitionResultData transitionResult)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &transitionResult;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.TransitionJob.NativeMethodInfoPtr_UpdateActiveChainElementBasedOnResult_Private_Void_TransitionResultData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071376, RefRangeEnd = 1071377, XrefRangeStart = 1071304, XrefRangeEnd = 1071376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnChainTransitionSystem.TransitionJob.TransitionResultData PrepareSpawn(
        [In] ref SpawnChainTransitionEvent transitionEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref transitionEvent;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.TransitionJob.NativeMethodInfoPtr_PrepareSpawn_Private_TransitionResultData_byref_SpawnChainTransitionEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SpawnChainTransitionSystem.TransitionJob.TransitionResultData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071399, RefRangeEnd = 1071400, XrefRangeStart = 1071377, XrefRangeEnd = 1071399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool IsValidTransitionRequest(
        SpawnChainTransitionEvent transitionEvent,
        out Entity activeEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &transitionEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeEntity;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.TransitionJob.NativeMethodInfoPtr_IsValidTransitionRequest_Private_Boolean_SpawnChainTransitionEvent_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1071440, RefRangeEnd = 1071442, XrefRangeStart = 1071400, XrefRangeEnd = 1071440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetPrefabToSpawn(
        SpawnChainData.TransitionId transitionId,
        [In] ref SpawnChainTransitionEvent transitionEvent,
        SpawnChainData.SpawnChainConstants chainConstants,
        [In] ref SpawnChainData.SpawnChainInstance chainInstance,
        float4x4 localToWorld,
        Nullable_Unboxed<int> lastFailedImportance,
        out int importance,
        out SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData prefabToSpawn)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &transitionId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref transitionEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &chainConstants;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref chainInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &localToWorld;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &lastFailedImportance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref importance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabToSpawn;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.TransitionJob.NativeMethodInfoPtr_TryGetPrefabToSpawn_Private_Boolean_TransitionId_byref_SpawnChainTransitionEvent_SpawnChainConstants_byref_SpawnChainInstance_float4x4_Nullable_Unboxed_1_Int32_byref_Int32_byref_PrefabToSpawnData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TransitionJob()
      {
        Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, nameof (TransitionJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr);
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetTileModel));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetRandomizedSpawnChainChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetRandomizedSpawnChainChild));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetSpawnChainChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetSpawnChainChild));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetSpawnChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetSpawnChain));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetSpawnChainInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetSpawnChainInstance));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetAutoChainInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetAutoChainInstanceData));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetActiveChildElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetActiveChildElement));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetRandomizedSpawnChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetRandomizedSpawnChain));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_SpawnChainTransitionResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (SpawnChainTransitionResults));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetNetworkedSpawnChainChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetNetworkedSpawnChainChild));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetStaticTransformIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetStaticTransformIndex));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (PrefabLookupMap));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_ServerElapsedSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (ServerElapsedSeconds));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_PlacementJobParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (PlacementJobParams));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_GetPlacementResultMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (GetPlacementResultMarker));
        SpawnChainTransitionSystem.TransitionJob.NativeFieldInfoPtr_ApplyPlacementResultMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (ApplyPlacementResultMarker));
        SpawnChainTransitionSystem.TransitionJob.NativeMethodInfoPtr_Execute_Public_Void_byref_SpawnChainTransitionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, 100684429);
        SpawnChainTransitionSystem.TransitionJob.NativeMethodInfoPtr_UpdateActiveChainElementBasedOnResult_Private_Void_TransitionResultData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, 100684430);
        SpawnChainTransitionSystem.TransitionJob.NativeMethodInfoPtr_PrepareSpawn_Private_TransitionResultData_byref_SpawnChainTransitionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, 100684431);
        SpawnChainTransitionSystem.TransitionJob.NativeMethodInfoPtr_IsValidTransitionRequest_Private_Boolean_SpawnChainTransitionEvent_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, 100684432);
        SpawnChainTransitionSystem.TransitionJob.NativeMethodInfoPtr_TryGetPrefabToSpawn_Private_Boolean_TransitionId_byref_SpawnChainTransitionEvent_SpawnChainConstants_byref_SpawnChainInstance_float4x4_Nullable_Unboxed_1_Int32_byref_Int32_byref_PrefabToSpawnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, 100684433);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct TransitionResultData
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_TransitionResult;
        private static readonly System.IntPtr NativeFieldInfoPtr_UsePlacementResult;
        private static readonly System.IntPtr NativeFieldInfoPtr_PlacementResult;
        private static readonly System.IntPtr NativeFieldInfoPtr_RequestHasValidTarget;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChainEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_ActiveChainElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_PrefabToSpawn;
        [FieldOffset(0)]
        public SpawnChainTransitionSystem.TransitionResult TransitionResult;
        [FieldOffset(4)]
        public bool UsePlacementResult;
        [FieldOffset(8)]
        public PlacementResult PlacementResult;
        [FieldOffset(152)]
        public bool RequestHasValidTarget;
        [FieldOffset(156)]
        public Entity SpawnChainEntity;
        [FieldOffset(164)]
        public Entity ActiveChainElement;
        [FieldOffset(176)]
        public SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData PrefabToSpawn;

        static TransitionResultData()
        {
          Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob>.NativeClassPtr, nameof (TransitionResultData));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr);
          SpawnChainTransitionSystem.TransitionJob.TransitionResultData.NativeFieldInfoPtr_TransitionResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr, nameof (TransitionResult));
          SpawnChainTransitionSystem.TransitionJob.TransitionResultData.NativeFieldInfoPtr_UsePlacementResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr, nameof (UsePlacementResult));
          SpawnChainTransitionSystem.TransitionJob.TransitionResultData.NativeFieldInfoPtr_PlacementResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr, nameof (PlacementResult));
          SpawnChainTransitionSystem.TransitionJob.TransitionResultData.NativeFieldInfoPtr_RequestHasValidTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr, nameof (RequestHasValidTarget));
          SpawnChainTransitionSystem.TransitionJob.TransitionResultData.NativeFieldInfoPtr_SpawnChainEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr, nameof (SpawnChainEntity));
          SpawnChainTransitionSystem.TransitionJob.TransitionResultData.NativeFieldInfoPtr_ActiveChainElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr, nameof (ActiveChainElement));
          SpawnChainTransitionSystem.TransitionJob.TransitionResultData.NativeFieldInfoPtr_PrefabToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr, nameof (PrefabToSpawn));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct PrefabToSpawnData
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChainElementIndex;
          private static readonly System.IntPtr NativeFieldInfoPtr_TRS;
          private static readonly System.IntPtr NativeFieldInfoPtr_PrefabEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_DestroyChainTransitionEnd;
          private static readonly System.IntPtr NativeFieldInfoPtr_ForwardedAutoChainTransitionSurplus;
          private static readonly System.IntPtr NativeFieldInfoPtr_AutoChainConfig;
          [FieldOffset(0)]
          public int SpawnChainElementIndex;
          [FieldOffset(4)]
          public float4x4 TRS;
          [FieldOffset(68)]
          public Entity PrefabEntity;
          [FieldOffset(76)]
          public bool DestroyChainTransitionEnd;
          [FieldOffset(80)]
          public double ForwardedAutoChainTransitionSurplus;
          [FieldOffset(88)]
          public Nullable_Unboxed<AutoChainTransitionConstants> AutoChainConfig;

          static PrefabToSpawnData()
          {
            Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData>.NativeClassPtr, nameof (PrefabToSpawnData));
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData>.NativeClassPtr);
            SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData.NativeFieldInfoPtr_SpawnChainElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData>.NativeClassPtr, nameof (SpawnChainElementIndex));
            SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData.NativeFieldInfoPtr_TRS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData>.NativeClassPtr, nameof (TRS));
            SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData.NativeFieldInfoPtr_PrefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData>.NativeClassPtr, nameof (PrefabEntity));
            SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData.NativeFieldInfoPtr_DestroyChainTransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData>.NativeClassPtr, nameof (DestroyChainTransitionEnd));
            SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData.NativeFieldInfoPtr_ForwardedAutoChainTransitionSurplus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData>.NativeClassPtr, nameof (ForwardedAutoChainTransitionSurplus));
            SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData.NativeFieldInfoPtr_AutoChainConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData>.NativeClassPtr, nameof (AutoChainConfig));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionSystem.TransitionJob.TransitionResultData.PrefabToSpawnData>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SpawnChainTransitionSystem/<>c__DisplayClass15_0")]
    public sealed class __c__DisplayClass15_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnChainDebug;
      private static readonly System.IntPtr NativeFieldInfoPtr_systemName;
      private static readonly System.IntPtr NativeFieldInfoPtr_chainsToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr_getQueuedRequests;
      private static readonly System.IntPtr NativeFieldInfoPtr_transitionJob;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSpawnChainTransitions_b__0_Internal_Void_byref_SpawnChainTransitionEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSpawnChainTransitions_b__1_Internal_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass15_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSpawnChainTransitions_b__0(
        [In] ref SpawnChainTransitionEvent transitionEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref transitionEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateSpawnChainTransitions_b__0_Internal_Void_byref_SpawnChainTransitionEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSpawnChainTransitions_b__1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateSpawnChainTransitions_b__1_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass15_0()
      {
        Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, "<>c__DisplayClass15_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr);
        SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
        SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_spawnChainDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (spawnChainDebug));
        SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_systemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (systemName));
        SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_chainsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (chainsToProcess));
        SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_getQueuedRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (getQueuedRequests));
        SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_transitionJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (transitionJob));
        SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, 100684434);
        SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateSpawnChainTransitions_b__0_Internal_Void_byref_SpawnChainTransitionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, 100684435);
        SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateSpawnChainTransitions_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, 100684436);
      }

      public __c__DisplayClass15_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass15_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass15_0>.NativeClassPtr, data));
      }

      public unsafe SpawnChainTransitionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SpawnChainTransitionSystem) null : new SpawnChainTransitionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool spawnChainDebug
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_spawnChainDebug));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_spawnChainDebug)) = value;
        }
      }

      public unsafe FixedString64 systemName
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_systemName));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_systemName)) = value;
        }
      }

      public unsafe NativeList<Entity> chainsToProcess
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_chainsToProcess));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_chainsToProcess), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<SpawnChainData.QueuedTransitionRequests> getQueuedRequests
      {
        get
        {
          return *(BufferFromEntity<SpawnChainData.QueuedTransitionRequests>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_getQueuedRequests));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_getQueuedRequests), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<SpawnChainData.QueuedTransitionRequests>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SpawnChainTransitionSystem.TransitionJob transitionJob
      {
        get
        {
          return *(SpawnChainTransitionSystem.TransitionJob*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_transitionJob));
        }
        [param: In] set
        {
          *(SpawnChainTransitionSystem.TransitionJob*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_transitionJob)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.SpawnChainTransitionSystem/ProjectM.<>c__DisplayClass_EnqueueTransitionEvents")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_EnqueueTransitionEvents
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnChainDebug;
      private static readonly System.IntPtr NativeFieldInfoPtr_systemName;
      private static readonly System.IntPtr NativeFieldInfoPtr_chainsToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ActiveChildElement_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_QueuedTransitionRequests_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_SpawnChainTransitionEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainTransitionSystem_byref___c__DisplayClass15_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public bool spawnChainDebug;
      [FieldOffset(2)]
      public FixedString64 systemName;
      [FieldOffset(72)]
      public NativeList<Entity> chainsToProcess;
      [FieldOffset(88)]
      public ComponentDataFromEntity<SpawnChainData.ActiveChildElement> _ComponentDataFromEntity_ActiveChildElement_0;
      [FieldOffset(120)]
      public BufferFromEntity<SpawnChainData.QueuedTransitionRequests> _BufferFromEntity_QueuedTransitionRequests_1;
      [FieldOffset(160)]
      public ComponentDataFromEntity<Disabled> _ComponentDataFromEntity_Disabled_2;
      [FieldOffset(192)]
      public SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(224)]
      public unsafe SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071525, XrefRangeEnd = 1071561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref SpawnChainTransitionEvent transitionEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref transitionEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_SpawnChainTransitionEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071561, RefRangeEnd = 1071562, XrefRangeStart = 1071561, XrefRangeEnd = 1071561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SpawnChainTransitionSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071562, RefRangeEnd = 1071563, XrefRangeStart = 1071562, XrefRangeEnd = 1071562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SpawnChainTransitionSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071563, XrefRangeEnd = 1071565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071570, RefRangeEnd = 1071571, XrefRangeStart = 1071565, XrefRangeEnd = 1071570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071582, RefRangeEnd = 1071583, XrefRangeStart = 1071571, XrefRangeEnd = 1071582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SpawnChainTransitionSystem componentSystem,
        ref SpawnChainTransitionSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainTransitionSystem_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071583, XrefRangeEnd = 1071587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071587, XrefRangeEnd = 1071593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_EnqueueTransitionEvents()
      {
        Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, "<>c__DisplayClass_EnqueueTransitionEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr);
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr_spawnChainDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (spawnChainDebug));
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr_systemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (systemName));
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr_chainsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (chainsToProcess));
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr__ComponentDataFromEntity_ActiveChildElement_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (_ComponentDataFromEntity_ActiveChildElement_0));
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr__BufferFromEntity_QueuedTransitionRequests_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (_BufferFromEntity_QueuedTransitionRequests_1));
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (_ComponentDataFromEntity_Disabled_2));
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (_runtimes));
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_SpawnChainTransitionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, 100684437);
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, 100684438);
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, 100684439);
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, 100684440);
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, 100684441);
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainTransitionSystem_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, 100684442);
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, 100684443);
        SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, 100684444);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_transitionEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainTransitionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<SpawnChainTransitionEvent> forParameter_transitionEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1071445, RefRangeEnd = 1071446, XrefRangeStart = 1071442, XrefRangeEnd = 1071445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SpawnChainTransitionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainTransitionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1071449, RefRangeEnd = 1071450, XrefRangeStart = 1071446, XrefRangeEnd = 1071449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_transitionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_transitionEvent));
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainTransitionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders>.NativeClassPtr, 100684445);
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders>.NativeClassPtr, 100684446);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_transitionEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<SpawnChainTransitionEvent>.Runtime runtime_transitionEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_transitionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_transitionEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SpawnChainTransitionSystem/ProjectM.<>c__DisplayClass_EnqueueTransitionEvents/ProjectM.RunWithoutJobSystem_00004A42$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, "RunWithoutJobSystem_00004A42$PostfixBurstDelegate");
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684447);
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684448);
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684449);
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684450);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SpawnChainTransitionSystem/ProjectM.<>c__DisplayClass_EnqueueTransitionEvents/ProjectM.RunWithoutJobSystem_00004A42$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071450, XrefRangeEnd = 1071464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071464, XrefRangeEnd = 1071482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071482, XrefRangeEnd = 1071497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1071524, RefRangeEnd = 1071525, XrefRangeStart = 1071497, XrefRangeEnd = 1071524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents>.NativeClassPtr, "RunWithoutJobSystem_00004A42$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684451);
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684452);
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684453);
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684454);
          SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684456);
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
            IL2CPP.il2cpp_field_static_get_value(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SpawnChainTransitionSystem.__c__DisplayClass_EnqueueTransitionEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SpawnChainTransitionSystem/ProjectM.<>c__DisplayClass_ProcessChainTransitions")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessChainTransitions
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_chainsToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr_getQueuedRequests;
      private static readonly System.IntPtr NativeFieldInfoPtr_systemName;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnChainDebug;
      private static readonly System.IntPtr NativeFieldInfoPtr_transitionJob;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainTransitionSystem_byref___c__DisplayClass15_0_0;
      [FieldOffset(0)]
      public NativeList<Entity> chainsToProcess;
      [FieldOffset(16)]
      public BufferFromEntity<SpawnChainData.QueuedTransitionRequests> getQueuedRequests;
      [FieldOffset(56)]
      public FixedString64 systemName;
      [FieldOffset(120)]
      public bool spawnChainDebug;
      [FieldOffset(128)]
      public SpawnChainTransitionSystem.TransitionJob transitionJob;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071593, XrefRangeEnd = 1071689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071692, RefRangeEnd = 1071693, XrefRangeStart = 1071689, XrefRangeEnd = 1071692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SpawnChainTransitionSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071693, XrefRangeEnd = 1071694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071695, RefRangeEnd = 1071696, XrefRangeStart = 1071694, XrefRangeEnd = 1071695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SpawnChainTransitionSystem componentSystem,
        ref SpawnChainTransitionSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainTransitionSystem_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessChainTransitions()
      {
        Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainTransitionSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessChainTransitions");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr);
        SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeFieldInfoPtr_chainsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr, nameof (chainsToProcess));
        SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeFieldInfoPtr_getQueuedRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr, nameof (getQueuedRequests));
        SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeFieldInfoPtr_systemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr, nameof (systemName));
        SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeFieldInfoPtr_spawnChainDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr, nameof (spawnChainDebug));
        SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeFieldInfoPtr_transitionJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr, nameof (transitionJob));
        SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr, 100684457);
        SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr, 100684458);
        SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr, 100684459);
        SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainTransitionSystem_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr, 100684460);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionSystem.__c__DisplayClass_ProcessChainTransitions>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
