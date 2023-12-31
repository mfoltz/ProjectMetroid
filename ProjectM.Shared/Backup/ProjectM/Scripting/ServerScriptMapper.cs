// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ServerScriptMapper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Shared;
using ProjectM.Terrain;
using ProjectM.Tiles;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Physics;

#nullable disable
namespace ProjectM.Scripting
{
  public class ServerScriptMapper : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityComponentsToAdd;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnFuncs;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdateFuncs;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyFuncs;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnTickFuncs;
    private static readonly System.IntPtr NativeFieldInfoPtr__MessageFuncs;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityCastStartedCallbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityCastUpdateCallbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityPreCastFinishedCallbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityPreCastEndedCallbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityPostCastFinishedCallbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityPostCastEndedCallbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityCastEndedCallbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityInterruptedCallbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameplayEventCallbackFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__ScheduledFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__StatChangeCallbackFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__TriggerCallbackFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__GlobalDeathFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnKillFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnDeathFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnSpawnedFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__GenericEventFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnPlacementResultFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerGameManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DetectModificationLeaksSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionDetectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr__DistanceHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__ColliderCastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__RayCastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__HitResults;
    private static readonly System.IntPtr NativeFieldInfoPtr__Names;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__DayNightCycleAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConditionCheckerFactory;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameplayEventsSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__HashedTypeToTypeLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__TempEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServerGameManager_Public_ServerGameManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallGameplayCallbackFuncs_Public_Void_Entity_byref_ScriptMethodReference_byref_GameplayEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallAbilityCastStartedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastStartedData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallAbilityCastUpdateCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastUpdateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallAbilityPreCastFinishedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastFinishedData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallAbilityPreCastEndedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallAbilityPostCastFinishedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastFinishedData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallAbilityPostCastEndedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallAbilityCastEndedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallAbilityInterruptedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityInterruptedData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallSpawnFuncs_Public_Void_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallUpdateFuncs_Public_Void_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallDestroyFuncs_Public_Void_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallOnTickFuncs_Public_Void_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallMessageFuncs_Public_Void_Entity_Int32_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AssertHasDependencies_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallStatChangeCallbackFunction_Public_Void_Entity_Int32_byref_StatChangeEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallTriggerCallbackFunction_Public_Void_Entity_Int32_NativeArray_1_HitResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallScheduledFunction_Public_Void_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallGlobalDeathFunction_Public_Void_Entity_Int32_NativeArray_1_DeathEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallOnKillFunction_Public_Void_Entity_Int32_Entity_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallOnDeathFunction_Public_Void_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallOnSpawnedFunction_Public_Void_Entity_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallGenericEventFunction_Public_Void_Entity_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallOnPlacementResultFunction_Public_Void_Entity_Int32_PlacementResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFunctions_Private_Void_String_Type_byref_RequiredScriptComponents_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBaseClassesFromHotReload_Public_Void_Entity_PrefabGuidComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBaseClasses_Public_Void_Entity_PrefabGUID_NativeArray_1_HashedTypesBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterType_Private_Void_Type_List_1_String_byref_RequiredScriptComponents_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDependencies_Public_Void_EntityCommandBuffer_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeDependencies_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTriggerFunctionHash_Internal_Int32_TriggerCallbackDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStatChangeFunctionHash_Internal_Int32_StatChangeCallbackDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetScheduledFunctionHash_Internal_Int32_ScheduledFunctionDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalDeathFunctionHash_Internal_Int32_GlobalDeathDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOnKillFunctionHash_Internal_Int32_OnKillDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOnDeathFunctionHash_Internal_Int32_OnDeathDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOnSpawnedFunctionHash_Internal_Int32_OnSpawnedDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericEventFunctionHash_Internal_Int32_GenericEventDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlacementResultFunctionHash_Public_Int32_OnPlacementResultDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearBatchComponentTracker_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginBatchedAddComponents_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndBatchedAddComponents_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777647, XrefRangeEnd = 777918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerScriptMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777918, XrefRangeEnd = 777934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerScriptMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777934, XrefRangeEnd = 777935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerGameManager GetServerGameManager()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_GetServerGameManager_Public_ServerGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerGameManager*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 777964, RefRangeEnd = 777965, XrefRangeStart = 777935, XrefRangeEnd = 777964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallGameplayCallbackFuncs(
      Entity targetEntity,
      [In] ref ScriptMethodReference scriptReference,
      [In] ref GameplayEvent gameplayEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref scriptReference;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallGameplayCallbackFuncs_Public_Void_Entity_byref_ScriptMethodReference_byref_GameplayEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 777983, RefRangeEnd = 777984, XrefRangeStart = 777965, XrefRangeEnd = 777983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallAbilityCastStartedCallbacks(
      Entity targetEntity,
      PrefabGUID prefabGuid,
      [In] ref AbilityCastStartedData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallAbilityCastStartedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastStartedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778002, RefRangeEnd = 778003, XrefRangeStart = 777984, XrefRangeEnd = 778002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallAbilityCastUpdateCallbacks(
      Entity targetEntity,
      PrefabGUID prefabGuid,
      [In] ref AbilityCastUpdateData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallAbilityCastUpdateCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastUpdateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 778021, RefRangeEnd = 778025, XrefRangeStart = 778003, XrefRangeEnd = 778021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallAbilityPreCastFinishedCallbacks(
      Entity targetEntity,
      PrefabGUID prefabGuid,
      [In] ref AbilityCastFinishedData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallAbilityPreCastFinishedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastFinishedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 778043, RefRangeEnd = 778047, XrefRangeStart = 778025, XrefRangeEnd = 778043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallAbilityPreCastEndedCallbacks(
      Entity targetEntity,
      PrefabGUID prefabGuid,
      [In] ref AbilityCastEndedData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallAbilityPreCastEndedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 778065, RefRangeEnd = 778069, XrefRangeStart = 778047, XrefRangeEnd = 778065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallAbilityPostCastFinishedCallbacks(
      Entity targetEntity,
      PrefabGUID prefabGuid,
      [In] ref AbilityCastFinishedData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallAbilityPostCastFinishedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastFinishedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 778087, RefRangeEnd = 778091, XrefRangeStart = 778069, XrefRangeEnd = 778087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallAbilityPostCastEndedCallbacks(
      Entity targetEntity,
      PrefabGUID prefabGuid,
      [In] ref AbilityCastEndedData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallAbilityPostCastEndedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 778109, RefRangeEnd = 778113, XrefRangeStart = 778091, XrefRangeEnd = 778109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallAbilityCastEndedCallbacks(
      Entity targetEntity,
      PrefabGUID prefabGuid,
      [In] ref AbilityCastEndedData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallAbilityCastEndedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 778131, RefRangeEnd = 778135, XrefRangeStart = 778113, XrefRangeEnd = 778131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallAbilityInterruptedCallbacks(
      Entity targetEntity,
      PrefabGUID prefabGuid,
      [In] ref AbilityInterruptedData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallAbilityInterruptedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityInterruptedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 778153, RefRangeEnd = 778156, XrefRangeStart = 778135, XrefRangeEnd = 778153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallSpawnFuncs(Entity entity, PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallSpawnFuncs_Public_Void_Entity_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778174, RefRangeEnd = 778175, XrefRangeStart = 778156, XrefRangeEnd = 778174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallUpdateFuncs(Entity entity, PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallUpdateFuncs_Public_Void_Entity_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 778193, RefRangeEnd = 778196, XrefRangeStart = 778175, XrefRangeEnd = 778193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallDestroyFuncs(Entity entity, PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallDestroyFuncs_Public_Void_Entity_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 778214, RefRangeEnd = 778216, XrefRangeStart = 778196, XrefRangeEnd = 778214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallOnTickFuncs(Entity entity, PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallOnTickFuncs_Public_Void_Entity_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778234, RefRangeEnd = 778235, XrefRangeStart = 778216, XrefRangeEnd = 778234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallMessageFuncs(Entity entity, int functionNameHash, PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &functionNameHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallMessageFuncs_Public_Void_Entity_Int32_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 778235, RefRangeEnd = 778258, XrefRangeStart = 778235, XrefRangeEnd = 778235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AssertHasDependencies()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_AssertHasDependencies_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 778273, RefRangeEnd = 778275, XrefRangeStart = 778258, XrefRangeEnd = 778273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallStatChangeCallbackFunction(
      Entity targetEntity,
      int functionHash,
      ref StatChangeEvent statChangeEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &functionHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref statChangeEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallStatChangeCallbackFunction_Public_Void_Entity_Int32_byref_StatChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778290, RefRangeEnd = 778291, XrefRangeStart = 778275, XrefRangeEnd = 778290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallTriggerCallbackFunction(
      Entity targetEntity,
      int functionHash,
      NativeArray<HitResult> hits)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &functionHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallTriggerCallbackFunction_Public_Void_Entity_Int32_NativeArray_1_HitResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778306, RefRangeEnd = 778307, XrefRangeStart = 778291, XrefRangeEnd = 778306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallScheduledFunction(Entity targetEntity, int functionHash)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &functionHash;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallScheduledFunction_Public_Void_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 778322, RefRangeEnd = 778324, XrefRangeStart = 778307, XrefRangeEnd = 778322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallGlobalDeathFunction(
      Entity targetEntity,
      int functionHash,
      NativeArray<DeathEvent> deathEvents)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &functionHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deathEvents;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallGlobalDeathFunction_Public_Void_Entity_Int32_NativeArray_1_DeathEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778339, RefRangeEnd = 778340, XrefRangeStart = 778324, XrefRangeEnd = 778339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallOnKillFunction(
      Entity targetEntity,
      int functionHash,
      Entity killed,
      Entity killer,
      Entity source)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &functionHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &killed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &killer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallOnKillFunction_Public_Void_Entity_Int32_Entity_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778355, RefRangeEnd = 778356, XrefRangeStart = 778340, XrefRangeEnd = 778355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallOnDeathFunction(Entity targetEntity, int functionHash)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &functionHash;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallOnDeathFunction_Public_Void_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 778371, RefRangeEnd = 778374, XrefRangeStart = 778356, XrefRangeEnd = 778371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallOnSpawnedFunction(
      Entity targetEntity,
      int functionHash,
      Entity spawnedEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &functionHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnedEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallOnSpawnedFunction_Public_Void_Entity_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778389, RefRangeEnd = 778390, XrefRangeStart = 778374, XrefRangeEnd = 778389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallGenericEventFunction(
      Entity targetEntity,
      int functionHash,
      Entity eventEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &functionHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallGenericEventFunction_Public_Void_Entity_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778405, RefRangeEnd = 778406, XrefRangeStart = 778390, XrefRangeEnd = 778405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallOnPlacementResultFunction(
      Entity targetEntity,
      int functionHash,
      PlacementResult placementResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &functionHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &placementResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_CallOnPlacementResultFunction_Public_Void_Entity_Int32_PlacementResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 778500, RefRangeEnd = 778502, XrefRangeStart = 778406, XrefRangeEnd = 778500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFunctions(
      string name,
      Il2CppSystem.Type type,
      ref ServerScriptMapper.RequiredScriptComponents componentsToAdd)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref componentsToAdd;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_SetFunctions_Private_Void_String_Type_byref_RequiredScriptComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778502, XrefRangeEnd = 778579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterBaseClassesFromHotReload(
      Entity entity,
      PrefabGuidComponent prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabGuid);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_RegisterBaseClassesFromHotReload_Public_Void_Entity_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778666, RefRangeEnd = 778667, XrefRangeStart = 778579, XrefRangeEnd = 778666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterBaseClasses(
      Entity entity,
      PrefabGUID prefabGuid,
      NativeArray<HashedTypesBuffer> hashedTypes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hashedTypes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_RegisterBaseClasses_Public_Void_Entity_PrefabGUID_NativeArray_1_HashedTypesBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778682, RefRangeEnd = 778683, XrefRangeStart = 778667, XrefRangeEnd = 778682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterType(
      Il2CppSystem.Type parentType,
      List<string> names,
      ref ServerScriptMapper.RequiredScriptComponents componentsToAdd)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) names);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref componentsToAdd;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_RegisterType_Private_Void_Type_List_1_String_byref_RequiredScriptComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778683, XrefRangeEnd = 778691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerScriptMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 778720, RefRangeEnd = 778727, XrefRangeStart = 778691, XrefRangeEnd = 778720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrepareDependencies(
      EntityCommandBuffer spawnCommandBuffer,
      EntityCommandBuffer destroyCommandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_PrepareDependencies_Public_Void_EntityCommandBuffer_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 778727, RefRangeEnd = 778734, XrefRangeStart = 778727, XrefRangeEnd = 778727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FinalizeDependencies()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_FinalizeDependencies_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778734, XrefRangeEnd = 778804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 778808, RefRangeEnd = 778810, XrefRangeStart = 778804, XrefRangeEnd = 778808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetTriggerFunctionHash(
      ServerScriptMapper.TriggerCallbackDelegate function)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) function);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_GetTriggerFunctionHash_Internal_Int32_TriggerCallbackDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778810, XrefRangeEnd = 778814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetStatChangeFunctionHash(
      ServerScriptMapper.StatChangeCallbackDelegate function)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) function);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_GetStatChangeFunctionHash_Internal_Int32_StatChangeCallbackDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778814, XrefRangeEnd = 778818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetScheduledFunctionHash(
      ServerScriptMapper.ScheduledFunctionDelegate function)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) function);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_GetScheduledFunctionHash_Internal_Int32_ScheduledFunctionDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778818, XrefRangeEnd = 778822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetGlobalDeathFunctionHash(ServerScriptMapper.GlobalDeathDelegate function)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) function);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_GetGlobalDeathFunctionHash_Internal_Int32_GlobalDeathDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778822, XrefRangeEnd = 778826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetOnKillFunctionHash(ServerScriptMapper.OnKillDelegate function)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) function);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_GetOnKillFunctionHash_Internal_Int32_OnKillDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778826, XrefRangeEnd = 778830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetOnDeathFunctionHash(ServerScriptMapper.OnDeathDelegate function)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) function);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_GetOnDeathFunctionHash_Internal_Int32_OnDeathDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778830, XrefRangeEnd = 778834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetOnSpawnedFunctionHash(ServerScriptMapper.OnSpawnedDelegate function)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) function);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_GetOnSpawnedFunctionHash_Internal_Int32_OnSpawnedDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778838, RefRangeEnd = 778839, XrefRangeStart = 778834, XrefRangeEnd = 778838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetGenericEventFunctionHash(ServerScriptMapper.GenericEventDelegate function)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) function);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_GetGenericEventFunctionHash_Internal_Int32_GenericEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778843, RefRangeEnd = 778844, XrefRangeStart = 778839, XrefRangeEnd = 778843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetPlacementResultFunctionHash(
      ServerScriptMapper.OnPlacementResultDelegate function)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) function);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_GetPlacementResultFunctionHash_Public_Int32_OnPlacementResultDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 778867, RefRangeEnd = 778870, XrefRangeStart = 778844, XrefRangeEnd = 778867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearBatchComponentTracker()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_ClearBatchComponentTracker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778871, RefRangeEnd = 778872, XrefRangeStart = 778870, XrefRangeEnd = 778871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BeginBatchedAddComponents()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_BeginBatchedAddComponents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 778946, RefRangeEnd = 778947, XrefRangeStart = 778872, XrefRangeEnd = 778946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndBatchedAddComponents()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr_EndBatchedAddComponents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778947, XrefRangeEnd = 778960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerScriptMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778960, XrefRangeEnd = 778968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0<T>(
      ServerScriptMapper.RequiredScriptComponents required,
      ServerScriptMapper.RequiredScriptComponents flags,
      NativeList<ComponentType> list)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &required;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &list;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.MethodInfoStoreGeneric_Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerScriptMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerScriptMapper()
    {
      Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ServerScriptMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr);
      ServerScriptMapper.NativeFieldInfoPtr__EntityComponentsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_EntityComponentsToAdd));
      ServerScriptMapper.NativeFieldInfoPtr__SpawnFuncs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_SpawnFuncs));
      ServerScriptMapper.NativeFieldInfoPtr__UpdateFuncs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_UpdateFuncs));
      ServerScriptMapper.NativeFieldInfoPtr__DestroyFuncs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_DestroyFuncs));
      ServerScriptMapper.NativeFieldInfoPtr__OnTickFuncs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_OnTickFuncs));
      ServerScriptMapper.NativeFieldInfoPtr__MessageFuncs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_MessageFuncs));
      ServerScriptMapper.NativeFieldInfoPtr__AbilityCastStartedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_AbilityCastStartedCallbacks));
      ServerScriptMapper.NativeFieldInfoPtr__AbilityCastUpdateCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_AbilityCastUpdateCallbacks));
      ServerScriptMapper.NativeFieldInfoPtr__AbilityPreCastFinishedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_AbilityPreCastFinishedCallbacks));
      ServerScriptMapper.NativeFieldInfoPtr__AbilityPreCastEndedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_AbilityPreCastEndedCallbacks));
      ServerScriptMapper.NativeFieldInfoPtr__AbilityPostCastFinishedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_AbilityPostCastFinishedCallbacks));
      ServerScriptMapper.NativeFieldInfoPtr__AbilityPostCastEndedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_AbilityPostCastEndedCallbacks));
      ServerScriptMapper.NativeFieldInfoPtr__AbilityCastEndedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_AbilityCastEndedCallbacks));
      ServerScriptMapper.NativeFieldInfoPtr__AbilityInterruptedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_AbilityInterruptedCallbacks));
      ServerScriptMapper.NativeFieldInfoPtr__GameplayEventCallbackFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_GameplayEventCallbackFunctions));
      ServerScriptMapper.NativeFieldInfoPtr__ScheduledFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_ScheduledFunctions));
      ServerScriptMapper.NativeFieldInfoPtr__StatChangeCallbackFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_StatChangeCallbackFunctions));
      ServerScriptMapper.NativeFieldInfoPtr__TriggerCallbackFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_TriggerCallbackFunctions));
      ServerScriptMapper.NativeFieldInfoPtr__GlobalDeathFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_GlobalDeathFunctions));
      ServerScriptMapper.NativeFieldInfoPtr__OnKillFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_OnKillFunctions));
      ServerScriptMapper.NativeFieldInfoPtr__OnDeathFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_OnDeathFunctions));
      ServerScriptMapper.NativeFieldInfoPtr__OnSpawnedFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_OnSpawnedFunctions));
      ServerScriptMapper.NativeFieldInfoPtr__GenericEventFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_GenericEventFunctions));
      ServerScriptMapper.NativeFieldInfoPtr__OnPlacementResultFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_OnPlacementResultFunctions));
      ServerScriptMapper.NativeFieldInfoPtr__ServerGameManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_ServerGameManager));
      ServerScriptMapper.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_ModificationSystem));
      ServerScriptMapper.NativeFieldInfoPtr__DetectModificationLeaksSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_DetectModificationLeaksSystem));
      ServerScriptMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ServerScriptMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_GameDataSystem));
      ServerScriptMapper.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_CollisionSystem));
      ServerScriptMapper.NativeFieldInfoPtr__CollisionDetectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_CollisionDetectionSystem));
      ServerScriptMapper.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_TerrainManager));
      ServerScriptMapper.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_TileWorldSystem));
      ServerScriptMapper.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_TilePolygons));
      ServerScriptMapper.NativeFieldInfoPtr__DistanceHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_DistanceHits));
      ServerScriptMapper.NativeFieldInfoPtr__ColliderCastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_ColliderCastHits));
      ServerScriptMapper.NativeFieldInfoPtr__RayCastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_RayCastHits));
      ServerScriptMapper.NativeFieldInfoPtr__HitResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_HitResults));
      ServerScriptMapper.NativeFieldInfoPtr__Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_Names));
      ServerScriptMapper.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_ServerTimeAccessor));
      ServerScriptMapper.NativeFieldInfoPtr__DayNightCycleAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_DayNightCycleAccessor));
      ServerScriptMapper.NativeFieldInfoPtr__ConditionCheckerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_ConditionCheckerFactory));
      ServerScriptMapper.NativeFieldInfoPtr__GameplayEventsSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_GameplayEventsSystem));
      ServerScriptMapper.NativeFieldInfoPtr__SpellModCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_SpellModCollectionSystem));
      ServerScriptMapper.NativeFieldInfoPtr__HashedTypeToTypeLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_HashedTypeToTypeLookup));
      ServerScriptMapper.NativeFieldInfoPtr__TempEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (_TempEntity));
      ServerScriptMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668822);
      ServerScriptMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668823);
      ServerScriptMapper.NativeMethodInfoPtr_GetServerGameManager_Public_ServerGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668824);
      ServerScriptMapper.NativeMethodInfoPtr_CallGameplayCallbackFuncs_Public_Void_Entity_byref_ScriptMethodReference_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668825);
      ServerScriptMapper.NativeMethodInfoPtr_CallAbilityCastStartedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastStartedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668826);
      ServerScriptMapper.NativeMethodInfoPtr_CallAbilityCastUpdateCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastUpdateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668827);
      ServerScriptMapper.NativeMethodInfoPtr_CallAbilityPreCastFinishedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastFinishedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668828);
      ServerScriptMapper.NativeMethodInfoPtr_CallAbilityPreCastEndedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668829);
      ServerScriptMapper.NativeMethodInfoPtr_CallAbilityPostCastFinishedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastFinishedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668830);
      ServerScriptMapper.NativeMethodInfoPtr_CallAbilityPostCastEndedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668831);
      ServerScriptMapper.NativeMethodInfoPtr_CallAbilityCastEndedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668832);
      ServerScriptMapper.NativeMethodInfoPtr_CallAbilityInterruptedCallbacks_Public_Void_Entity_PrefabGUID_byref_AbilityInterruptedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668833);
      ServerScriptMapper.NativeMethodInfoPtr_CallSpawnFuncs_Public_Void_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668834);
      ServerScriptMapper.NativeMethodInfoPtr_CallUpdateFuncs_Public_Void_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668835);
      ServerScriptMapper.NativeMethodInfoPtr_CallDestroyFuncs_Public_Void_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668836);
      ServerScriptMapper.NativeMethodInfoPtr_CallOnTickFuncs_Public_Void_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668837);
      ServerScriptMapper.NativeMethodInfoPtr_CallMessageFuncs_Public_Void_Entity_Int32_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668838);
      ServerScriptMapper.NativeMethodInfoPtr_AssertHasDependencies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668839);
      ServerScriptMapper.NativeMethodInfoPtr_CallStatChangeCallbackFunction_Public_Void_Entity_Int32_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668840);
      ServerScriptMapper.NativeMethodInfoPtr_CallTriggerCallbackFunction_Public_Void_Entity_Int32_NativeArray_1_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668841);
      ServerScriptMapper.NativeMethodInfoPtr_CallScheduledFunction_Public_Void_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668842);
      ServerScriptMapper.NativeMethodInfoPtr_CallGlobalDeathFunction_Public_Void_Entity_Int32_NativeArray_1_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668843);
      ServerScriptMapper.NativeMethodInfoPtr_CallOnKillFunction_Public_Void_Entity_Int32_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668844);
      ServerScriptMapper.NativeMethodInfoPtr_CallOnDeathFunction_Public_Void_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668845);
      ServerScriptMapper.NativeMethodInfoPtr_CallOnSpawnedFunction_Public_Void_Entity_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668846);
      ServerScriptMapper.NativeMethodInfoPtr_CallGenericEventFunction_Public_Void_Entity_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668847);
      ServerScriptMapper.NativeMethodInfoPtr_CallOnPlacementResultFunction_Public_Void_Entity_Int32_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668848);
      ServerScriptMapper.NativeMethodInfoPtr_SetFunctions_Private_Void_String_Type_byref_RequiredScriptComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668849);
      ServerScriptMapper.NativeMethodInfoPtr_RegisterBaseClassesFromHotReload_Public_Void_Entity_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668850);
      ServerScriptMapper.NativeMethodInfoPtr_RegisterBaseClasses_Public_Void_Entity_PrefabGUID_NativeArray_1_HashedTypesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668851);
      ServerScriptMapper.NativeMethodInfoPtr_RegisterType_Private_Void_Type_List_1_String_byref_RequiredScriptComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668852);
      ServerScriptMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668853);
      ServerScriptMapper.NativeMethodInfoPtr_PrepareDependencies_Public_Void_EntityCommandBuffer_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668854);
      ServerScriptMapper.NativeMethodInfoPtr_FinalizeDependencies_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668855);
      ServerScriptMapper.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668856);
      ServerScriptMapper.NativeMethodInfoPtr_GetTriggerFunctionHash_Internal_Int32_TriggerCallbackDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668857);
      ServerScriptMapper.NativeMethodInfoPtr_GetStatChangeFunctionHash_Internal_Int32_StatChangeCallbackDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668858);
      ServerScriptMapper.NativeMethodInfoPtr_GetScheduledFunctionHash_Internal_Int32_ScheduledFunctionDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668859);
      ServerScriptMapper.NativeMethodInfoPtr_GetGlobalDeathFunctionHash_Internal_Int32_GlobalDeathDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668860);
      ServerScriptMapper.NativeMethodInfoPtr_GetOnKillFunctionHash_Internal_Int32_OnKillDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668861);
      ServerScriptMapper.NativeMethodInfoPtr_GetOnDeathFunctionHash_Internal_Int32_OnDeathDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668862);
      ServerScriptMapper.NativeMethodInfoPtr_GetOnSpawnedFunctionHash_Internal_Int32_OnSpawnedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668863);
      ServerScriptMapper.NativeMethodInfoPtr_GetGenericEventFunctionHash_Internal_Int32_GenericEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668864);
      ServerScriptMapper.NativeMethodInfoPtr_GetPlacementResultFunctionHash_Public_Int32_OnPlacementResultDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668865);
      ServerScriptMapper.NativeMethodInfoPtr_ClearBatchComponentTracker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668866);
      ServerScriptMapper.NativeMethodInfoPtr_BeginBatchedAddComponents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668867);
      ServerScriptMapper.NativeMethodInfoPtr_EndBatchedAddComponents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668868);
      ServerScriptMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668869);
      ServerScriptMapper.NativeMethodInfoPtr_Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668870);
      ServerScriptMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, 100668871);
    }

    public ServerScriptMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Dictionary<ServerScriptMapper.RequiredScriptComponents, NativeList<Entity>> _EntityComponentsToAdd
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__EntityComponentsToAdd));
        return pointer == System.IntPtr.Zero ? (Dictionary<ServerScriptMapper.RequiredScriptComponents, NativeList<Entity>>) null : new Dictionary<ServerScriptMapper.RequiredScriptComponents, NativeList<Entity>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__EntityComponentsToAdd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.SpawnDelegate> _SpawnFuncs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__SpawnFuncs));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.SpawnDelegate>) null : new GameFunction<ServerScriptMapper.SpawnDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__SpawnFuncs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.UpdateDelegate> _UpdateFuncs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__UpdateFuncs));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.UpdateDelegate>) null : new GameFunction<ServerScriptMapper.UpdateDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__UpdateFuncs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.DestroyDelegate> _DestroyFuncs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__DestroyFuncs));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.DestroyDelegate>) null : new GameFunction<ServerScriptMapper.DestroyDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__DestroyFuncs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.OnTickDelegate> _OnTickFuncs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__OnTickFuncs));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.OnTickDelegate>) null : new GameFunction<ServerScriptMapper.OnTickDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__OnTickFuncs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GenericGameFunction<ServerScriptMapper.MessageDelegate> _MessageFuncs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__MessageFuncs));
        return pointer == System.IntPtr.Zero ? (GenericGameFunction<ServerScriptMapper.MessageDelegate>) null : new GenericGameFunction<ServerScriptMapper.MessageDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__MessageFuncs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.AbilityCastStartedCallbackDelegate> _AbilityCastStartedCallbacks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityCastStartedCallbacks));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.AbilityCastStartedCallbackDelegate>) null : new GameFunction<ServerScriptMapper.AbilityCastStartedCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityCastStartedCallbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.AbilityCastUpdateCallbackDelegate> _AbilityCastUpdateCallbacks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityCastUpdateCallbacks));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.AbilityCastUpdateCallbackDelegate>) null : new GameFunction<ServerScriptMapper.AbilityCastUpdateCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityCastUpdateCallbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate> _AbilityPreCastFinishedCallbacks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityPreCastFinishedCallbacks));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate>) null : new GameFunction<ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityPreCastFinishedCallbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.AbilityPreCastEndedCallbackDelegate> _AbilityPreCastEndedCallbacks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityPreCastEndedCallbacks));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.AbilityPreCastEndedCallbackDelegate>) null : new GameFunction<ServerScriptMapper.AbilityPreCastEndedCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityPreCastEndedCallbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate> _AbilityPostCastFinishedCallbacks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityPostCastFinishedCallbacks));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate>) null : new GameFunction<ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityPostCastFinishedCallbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.AbilityPostCastEndedCallbackDelegate> _AbilityPostCastEndedCallbacks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityPostCastEndedCallbacks));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.AbilityPostCastEndedCallbackDelegate>) null : new GameFunction<ServerScriptMapper.AbilityPostCastEndedCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityPostCastEndedCallbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.AbilityCastEndedCallbackDelegate> _AbilityCastEndedCallbacks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityCastEndedCallbacks));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.AbilityCastEndedCallbackDelegate>) null : new GameFunction<ServerScriptMapper.AbilityCastEndedCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityCastEndedCallbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ServerScriptMapper.AbilityInterruptCallbackDelegate> _AbilityInterruptedCallbacks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityInterruptedCallbacks));
        return pointer == System.IntPtr.Zero ? (GameFunction<ServerScriptMapper.AbilityInterruptCallbackDelegate>) null : new GameFunction<ServerScriptMapper.AbilityInterruptCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__AbilityInterruptedCallbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GenericGameFunction<ServerScriptMapper.GameplayEventCallbackDelegate> _GameplayEventCallbackFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__GameplayEventCallbackFunctions));
        return pointer == System.IntPtr.Zero ? (GenericGameFunction<ServerScriptMapper.GameplayEventCallbackDelegate>) null : new GenericGameFunction<ServerScriptMapper.GameplayEventCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__GameplayEventCallbackFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper.ScriptableFunction<ServerScriptMapper.ScheduledFunctionDelegate> _ScheduledFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ScheduledFunctions));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper.ScriptableFunction<ServerScriptMapper.ScheduledFunctionDelegate>) null : new ServerScriptMapper.ScriptableFunction<ServerScriptMapper.ScheduledFunctionDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ScheduledFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper.ScriptableFunction<ServerScriptMapper.StatChangeCallbackDelegate> _StatChangeCallbackFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__StatChangeCallbackFunctions));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper.ScriptableFunction<ServerScriptMapper.StatChangeCallbackDelegate>) null : new ServerScriptMapper.ScriptableFunction<ServerScriptMapper.StatChangeCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__StatChangeCallbackFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper.ScriptableFunction<ServerScriptMapper.TriggerCallbackDelegate> _TriggerCallbackFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__TriggerCallbackFunctions));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper.ScriptableFunction<ServerScriptMapper.TriggerCallbackDelegate>) null : new ServerScriptMapper.ScriptableFunction<ServerScriptMapper.TriggerCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__TriggerCallbackFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper.ScriptableFunction<ServerScriptMapper.GlobalDeathDelegate> _GlobalDeathFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__GlobalDeathFunctions));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper.ScriptableFunction<ServerScriptMapper.GlobalDeathDelegate>) null : new ServerScriptMapper.ScriptableFunction<ServerScriptMapper.GlobalDeathDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__GlobalDeathFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnKillDelegate> _OnKillFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__OnKillFunctions));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnKillDelegate>) null : new ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnKillDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__OnKillFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnDeathDelegate> _OnDeathFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__OnDeathFunctions));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnDeathDelegate>) null : new ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnDeathDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__OnDeathFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnSpawnedDelegate> _OnSpawnedFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__OnSpawnedFunctions));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnSpawnedDelegate>) null : new ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnSpawnedDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__OnSpawnedFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper.ScriptableFunction<ServerScriptMapper.GenericEventDelegate> _GenericEventFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__GenericEventFunctions));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper.ScriptableFunction<ServerScriptMapper.GenericEventDelegate>) null : new ServerScriptMapper.ScriptableFunction<ServerScriptMapper.GenericEventDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__GenericEventFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnPlacementResultDelegate> _OnPlacementResultFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__OnPlacementResultFunctions));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnPlacementResultDelegate>) null : new ServerScriptMapper.ScriptableFunction<ServerScriptMapper.OnPlacementResultDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__OnPlacementResultFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerGameManager _ServerGameManager
    {
      get
      {
        return *(ServerGameManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ServerGameManager));
      }
      [param: In] set
      {
        *(ServerGameManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ServerGameManager)) = value;
      }
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DetectModificationLeaksSystem _DetectModificationLeaksSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__DetectModificationLeaksSystem));
        return pointer == System.IntPtr.Zero ? (DetectModificationLeaksSystem) null : new DetectModificationLeaksSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__DetectModificationLeaksSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionDetectionSystem_Base _CollisionDetectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__CollisionDetectionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionDetectionSystem_Base) null : new CollisionDetectionSystem_Base(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__CollisionDetectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
    {
      get
      {
        return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__TilePolygons));
      }
      [param: In] set
      {
        *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__TilePolygons)) = value;
      }
    }

    public unsafe NativeList<DistanceHit> _DistanceHits
    {
      get
      {
        return *(NativeList<DistanceHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__DistanceHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__DistanceHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DistanceHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<ColliderCastHit> _ColliderCastHits
    {
      get
      {
        return *(NativeList<ColliderCastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ColliderCastHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ColliderCastHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ColliderCastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<RaycastHit> _RayCastHits
    {
      get
      {
        return *(NativeList<RaycastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__RayCastHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__RayCastHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<RaycastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<HitResult> _HitResults
    {
      get
      {
        return *(NativeList<HitResult>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__HitResults));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__HitResults), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<HitResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<string> _Names
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__Names));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__Names), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<DayNightCycle> _DayNightCycleAccessor
    {
      get
      {
        return *(SingletonAccessor<DayNightCycle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__DayNightCycleAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__DayNightCycleAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<DayNightCycle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ConditionCheckerFactory _ConditionCheckerFactory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ConditionCheckerFactory));
        return pointer == System.IntPtr.Zero ? (ConditionCheckerFactory) null : new ConditionCheckerFactory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__ConditionCheckerFactory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameplayEventsSystem _GameplayEventsSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__GameplayEventsSystem));
        return pointer == System.IntPtr.Zero ? (GameplayEventsSystem) null : new GameplayEventsSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__GameplayEventsSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModCollectionSystem _SpellModCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__SpellModCollectionSystem));
        return pointer == System.IntPtr.Zero ? (SpellModCollectionSystem) null : new SpellModCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__SpellModCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, Il2CppSystem.Type> _HashedTypeToTypeLookup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__HashedTypeToTypeLookup));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, Il2CppSystem.Type>) null : new Dictionary<int, Il2CppSystem.Type>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__HashedTypeToTypeLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _TempEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__TempEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.NativeFieldInfoPtr__TempEntity)) = value;
      }
    }

    [Flags]
    public enum RequiredScriptComponents
    {
      None = 0,
      ScriptSpawn = 1,
      ScriptDestroy = 2,
      ScriptUpdate = 4,
      RunScriptOnCastStarted = 8,
      RunScriptOnCastUpdate = 16, // 0x00000010
      RunScriptOnPreCastFinished = 32, // 0x00000020
      RunScriptOnPreCastEnded = 64, // 0x00000040
      RunScriptOnPostCastFinished = 128, // 0x00000080
      RunScriptOnPostCastEnded = 256, // 0x00000100
      RunScriptOnCastEnded = 512, // 0x00000200
      RunScriptOnInterrupted = 1024, // 0x00000400
    }

    public class ScriptableFunction<T> : Il2CppSystem.Object where T : Il2CppSystem.Delegate
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__Functions;
      private static readonly System.IntPtr NativeFieldInfoPtr__FunctionsCache;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RegisterFunction_Public_Void_MethodInfo_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionHash_Public_Int32_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFunction_Public_Boolean_Int32_byref_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 777258, RefRangeEnd = 777267, XrefRangeStart = 777250, XrefRangeEnd = 777258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ScriptableFunction()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.ScriptableFunction<T>>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.ScriptableFunction<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 777288, RefRangeEnd = 777297, XrefRangeStart = 777267, XrefRangeEnd = 777288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void RegisterFunction(MethodInfo method)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.ScriptableFunction<T>.NativeMethodInfoPtr_RegisterFunction_Public_Void_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(19)]
      [CachedScanResults(RefRangeStart = 777301, RefRangeEnd = 777320, XrefRangeStart = 777297, XrefRangeEnd = 777301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int GetFunctionHash(T function)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
        System.IntPtr* numPtr2 = numPtr1;
        // ISSUE: variable of a reference type
        T& local1;
        if (!typeof (T).IsValueType)
        {
          // ISSUE: variable of a boxed type
          __Boxed<T> local2 = (object) function;
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        }
        else
          local1 = ref function;
        *numPtr2 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.ScriptableFunction<T>.NativeMethodInfoPtr_GetFunctionHash_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 777321, RefRangeEnd = 777330, XrefRangeStart = 777320, XrefRangeEnd = 777321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetFunction(int functionHash, out T function)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &functionHash;
        System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr zero;
        // ISSUE: variable of a reference type
        T& local1;
        if (!typeof (T).IsValueType)
        {
          zero = System.IntPtr.Zero;
          local1 = ref (*(T*) &zero);
        }
        else
          local1 = ref function;
        *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.ScriptableFunction<T>.NativeMethodInfoPtr_TryGetFunction_Public_Boolean_Int32_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        if (!typeof (T).IsValueType)
        {
          ref T local2 = ref function;
          System.IntPtr objectPointer = zero;
          // ISSUE: variable of the null type
          __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
          local2 = (T) valueGeneric;
        }
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 777331, RefRangeEnd = 777340, XrefRangeStart = 777330, XrefRangeEnd = 777331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Clear()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.ScriptableFunction<T>.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ScriptableFunction()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<ServerScriptMapper.ScriptableFunction<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, "ScriptableFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerScriptMapper.ScriptableFunction<T>>.NativeClassPtr);
        ServerScriptMapper.ScriptableFunction<T>.NativeFieldInfoPtr__Functions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper.ScriptableFunction<T>>.NativeClassPtr, nameof (_Functions));
        ServerScriptMapper.ScriptableFunction<T>.NativeFieldInfoPtr__FunctionsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScriptMapper.ScriptableFunction<T>>.NativeClassPtr, nameof (_FunctionsCache));
        ServerScriptMapper.ScriptableFunction<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.ScriptableFunction<T>>.NativeClassPtr, 100668872);
        ServerScriptMapper.ScriptableFunction<T>.NativeMethodInfoPtr_RegisterFunction_Public_Void_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.ScriptableFunction<T>>.NativeClassPtr, 100668873);
        ServerScriptMapper.ScriptableFunction<T>.NativeMethodInfoPtr_GetFunctionHash_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.ScriptableFunction<T>>.NativeClassPtr, 100668874);
        ServerScriptMapper.ScriptableFunction<T>.NativeMethodInfoPtr_TryGetFunction_Public_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.ScriptableFunction<T>>.NativeClassPtr, 100668875);
        ServerScriptMapper.ScriptableFunction<T>.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.ScriptableFunction<T>>.NativeClassPtr, 100668876);
      }

      public ScriptableFunction(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Dictionary<int, T> _Functions
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.ScriptableFunction<T>.NativeFieldInfoPtr__Functions));
          return pointer == System.IntPtr.Zero ? (Dictionary<int, T>) null : new Dictionary<int, T>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.ScriptableFunction<T>.NativeFieldInfoPtr__Functions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<T, int> _FunctionsCache
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.ScriptableFunction<T>.NativeFieldInfoPtr__FunctionsCache));
          return pointer == System.IntPtr.Zero ? (Dictionary<T, int>) null : new Dictionary<T, int>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerScriptMapper.ScriptableFunction<T>.NativeFieldInfoPtr__FunctionsCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class SpawnDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.SpawnDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.SpawnDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 691761, RefRangeEnd = 691772, XrefRangeStart = 691761, XrefRangeEnd = 691772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.SpawnDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777340, XrefRangeEnd = 777347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.SpawnDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.SpawnDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SpawnDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.SpawnDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (SpawnDelegate));
        ServerScriptMapper.SpawnDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.SpawnDelegate>.NativeClassPtr, 100668877);
        ServerScriptMapper.SpawnDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.SpawnDelegate>.NativeClassPtr, 100668878);
        ServerScriptMapper.SpawnDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.SpawnDelegate>.NativeClassPtr, 100668879);
        ServerScriptMapper.SpawnDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.SpawnDelegate>.NativeClassPtr, 100668880);
      }

      public SpawnDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class UpdateDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe UpdateDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.UpdateDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.UpdateDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 691761, RefRangeEnd = 691772, XrefRangeStart = 691761, XrefRangeEnd = 691772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.UpdateDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777347, XrefRangeEnd = 777354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.UpdateDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.UpdateDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.UpdateDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (UpdateDelegate));
        ServerScriptMapper.UpdateDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.UpdateDelegate>.NativeClassPtr, 100668881);
        ServerScriptMapper.UpdateDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.UpdateDelegate>.NativeClassPtr, 100668882);
        ServerScriptMapper.UpdateDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.UpdateDelegate>.NativeClassPtr, 100668883);
        ServerScriptMapper.UpdateDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.UpdateDelegate>.NativeClassPtr, 100668884);
      }

      public UpdateDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class DestroyDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DestroyDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.DestroyDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.DestroyDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 691761, RefRangeEnd = 691772, XrefRangeStart = 691761, XrefRangeEnd = 691772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.DestroyDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777354, XrefRangeEnd = 777361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.DestroyDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.DestroyDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DestroyDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.DestroyDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (DestroyDelegate));
        ServerScriptMapper.DestroyDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.DestroyDelegate>.NativeClassPtr, 100668885);
        ServerScriptMapper.DestroyDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.DestroyDelegate>.NativeClassPtr, 100668886);
        ServerScriptMapper.DestroyDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.DestroyDelegate>.NativeClassPtr, 100668887);
        ServerScriptMapper.DestroyDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.DestroyDelegate>.NativeClassPtr, 100668888);
      }

      public DestroyDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class OnTickDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OnTickDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.OnTickDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnTickDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 691761, RefRangeEnd = 691772, XrefRangeStart = 691761, XrefRangeEnd = 691772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnTickDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777361, XrefRangeEnd = 777368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnTickDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnTickDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OnTickDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.OnTickDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (OnTickDelegate));
        ServerScriptMapper.OnTickDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnTickDelegate>.NativeClassPtr, 100668889);
        ServerScriptMapper.OnTickDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnTickDelegate>.NativeClassPtr, 100668890);
        ServerScriptMapper.OnTickDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnTickDelegate>.NativeClassPtr, 100668891);
        ServerScriptMapper.OnTickDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnTickDelegate>.NativeClassPtr, 100668892);
      }

      public OnTickDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class MessageDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MessageDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.MessageDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.MessageDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 691761, RefRangeEnd = 691772, XrefRangeStart = 691761, XrefRangeEnd = 691772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.MessageDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777368, XrefRangeEnd = 777375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.MessageDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.MessageDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MessageDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.MessageDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (MessageDelegate));
        ServerScriptMapper.MessageDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.MessageDelegate>.NativeClassPtr, 100668893);
        ServerScriptMapper.MessageDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.MessageDelegate>.NativeClassPtr, 100668894);
        ServerScriptMapper.MessageDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.MessageDelegate>.NativeClassPtr, 100668895);
        ServerScriptMapper.MessageDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.MessageDelegate>.NativeClassPtr, 100668896);
      }

      public MessageDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class GameplayEventCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GameplayEventCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.GameplayEventCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GameplayEventCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 383532, RefRangeEnd = 383539, XrefRangeStart = 383532, XrefRangeEnd = 383539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GameplayEventCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777375, XrefRangeEnd = 777385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GameplayEventCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GameplayEventCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GameplayEventCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.GameplayEventCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (GameplayEventCallbackDelegate));
        ServerScriptMapper.GameplayEventCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GameplayEventCallbackDelegate>.NativeClassPtr, 100668897);
        ServerScriptMapper.GameplayEventCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GameplayEventCallbackDelegate>.NativeClassPtr, 100668898);
        ServerScriptMapper.GameplayEventCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GameplayEventCallbackDelegate>.NativeClassPtr, 100668899);
        ServerScriptMapper.GameplayEventCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GameplayEventCallbackDelegate>.NativeClassPtr, 100668900);
      }

      public GameplayEventCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class AbilityCastStartedCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AbilityCastStartedCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastStartedCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastStartedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 383532, RefRangeEnd = 383539, XrefRangeStart = 383532, XrefRangeEnd = 383539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastStartedData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastStartedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777385, XrefRangeEnd = 777395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastStartedData data,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastStartedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastStartedData data,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastStartedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AbilityCastStartedCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.AbilityCastStartedCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (AbilityCastStartedCallbackDelegate));
        ServerScriptMapper.AbilityCastStartedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastStartedCallbackDelegate>.NativeClassPtr, 100668901);
        ServerScriptMapper.AbilityCastStartedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastStartedCallbackDelegate>.NativeClassPtr, 100668902);
        ServerScriptMapper.AbilityCastStartedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastStartedCallbackDelegate>.NativeClassPtr, 100668903);
        ServerScriptMapper.AbilityCastStartedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastStartedCallbackDelegate>.NativeClassPtr, 100668904);
      }

      public AbilityCastStartedCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class AbilityCastUpdateCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AbilityCastUpdateCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastUpdateCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastUpdateCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 383532, RefRangeEnd = 383539, XrefRangeStart = 383532, XrefRangeEnd = 383539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastUpdateData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastUpdateCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777395, XrefRangeEnd = 777405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastUpdateData data,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastUpdateCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastUpdateData data,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastUpdateCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AbilityCastUpdateCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.AbilityCastUpdateCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (AbilityCastUpdateCallbackDelegate));
        ServerScriptMapper.AbilityCastUpdateCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastUpdateCallbackDelegate>.NativeClassPtr, 100668905);
        ServerScriptMapper.AbilityCastUpdateCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastUpdateCallbackDelegate>.NativeClassPtr, 100668906);
        ServerScriptMapper.AbilityCastUpdateCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastUpdateCallbackDelegate>.NativeClassPtr, 100668907);
        ServerScriptMapper.AbilityCastUpdateCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastUpdateCallbackDelegate>.NativeClassPtr, 100668908);
      }

      public AbilityCastUpdateCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class AbilityPreCastFinishedCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AbilityPreCastFinishedCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 777421, RefRangeEnd = 777426, XrefRangeStart = 777405, XrefRangeEnd = 777421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastFinishedData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777426, XrefRangeEnd = 777436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastFinishedData data,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastFinishedData data,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AbilityPreCastFinishedCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (AbilityPreCastFinishedCallbackDelegate));
        ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate>.NativeClassPtr, 100668909);
        ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate>.NativeClassPtr, 100668910);
        ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate>.NativeClassPtr, 100668911);
        ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastFinishedCallbackDelegate>.NativeClassPtr, 100668912);
      }

      public AbilityPreCastFinishedCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class AbilityPreCastEndedCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AbilityPreCastEndedCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastEndedCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPreCastEndedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 777421, RefRangeEnd = 777426, XrefRangeStart = 777421, XrefRangeEnd = 777426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPreCastEndedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777436, XrefRangeEnd = 777446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPreCastEndedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPreCastEndedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AbilityPreCastEndedCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastEndedCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (AbilityPreCastEndedCallbackDelegate));
        ServerScriptMapper.AbilityPreCastEndedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastEndedCallbackDelegate>.NativeClassPtr, 100668913);
        ServerScriptMapper.AbilityPreCastEndedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastEndedCallbackDelegate>.NativeClassPtr, 100668914);
        ServerScriptMapper.AbilityPreCastEndedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastEndedCallbackDelegate>.NativeClassPtr, 100668915);
        ServerScriptMapper.AbilityPreCastEndedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPreCastEndedCallbackDelegate>.NativeClassPtr, 100668916);
      }

      public AbilityPreCastEndedCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class AbilityPostCastFinishedCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AbilityPostCastFinishedCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 777421, RefRangeEnd = 777426, XrefRangeStart = 777421, XrefRangeEnd = 777426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastFinishedData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777446, XrefRangeEnd = 777456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastFinishedData data,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastFinishedData data,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AbilityPostCastFinishedCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (AbilityPostCastFinishedCallbackDelegate));
        ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate>.NativeClassPtr, 100668917);
        ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate>.NativeClassPtr, 100668918);
        ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate>.NativeClassPtr, 100668919);
        ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastFinishedCallbackDelegate>.NativeClassPtr, 100668920);
      }

      public AbilityPostCastFinishedCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class AbilityPostCastEndedCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AbilityPostCastEndedCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastEndedCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPostCastEndedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 777421, RefRangeEnd = 777426, XrefRangeStart = 777421, XrefRangeEnd = 777426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPostCastEndedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777456, XrefRangeEnd = 777466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPostCastEndedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityPostCastEndedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AbilityPostCastEndedCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastEndedCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (AbilityPostCastEndedCallbackDelegate));
        ServerScriptMapper.AbilityPostCastEndedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastEndedCallbackDelegate>.NativeClassPtr, 100668921);
        ServerScriptMapper.AbilityPostCastEndedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastEndedCallbackDelegate>.NativeClassPtr, 100668922);
        ServerScriptMapper.AbilityPostCastEndedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastEndedCallbackDelegate>.NativeClassPtr, 100668923);
        ServerScriptMapper.AbilityPostCastEndedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityPostCastEndedCallbackDelegate>.NativeClassPtr, 100668924);
      }

      public AbilityPostCastEndedCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class AbilityCastEndedCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AbilityCastEndedCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 777421, RefRangeEnd = 777426, XrefRangeStart = 777421, XrefRangeEnd = 777426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777466, XrefRangeEnd = 777476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AbilityCastEndedCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (AbilityCastEndedCallbackDelegate));
        ServerScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr, 100668925);
        ServerScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr, 100668926);
        ServerScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr, 100668927);
        ServerScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr, 100668928);
      }

      public AbilityCastEndedCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class AbilityInterruptCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityInterruptedData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityInterruptedData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityInterruptedData_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AbilityInterruptCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.AbilityInterruptCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityInterruptCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 383532, RefRangeEnd = 383539, XrefRangeStart = 383532, XrefRangeEnd = 383539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityInterruptedData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityInterruptCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityInterruptedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777476, XrefRangeEnd = 777486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityInterruptedData data,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityInterruptCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityInterruptedData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityInterruptedData data,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.AbilityInterruptCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityInterruptedData_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AbilityInterruptCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.AbilityInterruptCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (AbilityInterruptCallbackDelegate));
        ServerScriptMapper.AbilityInterruptCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityInterruptCallbackDelegate>.NativeClassPtr, 100668929);
        ServerScriptMapper.AbilityInterruptCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityInterruptedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityInterruptCallbackDelegate>.NativeClassPtr, 100668930);
        ServerScriptMapper.AbilityInterruptCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_AbilityInterruptedData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityInterruptCallbackDelegate>.NativeClassPtr, 100668931);
        ServerScriptMapper.AbilityInterruptCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityInterruptedData_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.AbilityInterruptCallbackDelegate>.NativeClassPtr, 100668932);
      }

      public AbilityInterruptCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class ScheduledFunctionDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ScheduledFunctionDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.ScheduledFunctionDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.ScheduledFunctionDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 691761, RefRangeEnd = 691772, XrefRangeStart = 691761, XrefRangeEnd = 691772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.ScheduledFunctionDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777486, XrefRangeEnd = 777493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.ScheduledFunctionDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.ScheduledFunctionDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ScheduledFunctionDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.ScheduledFunctionDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (ScheduledFunctionDelegate));
        ServerScriptMapper.ScheduledFunctionDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.ScheduledFunctionDelegate>.NativeClassPtr, 100668933);
        ServerScriptMapper.ScheduledFunctionDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.ScheduledFunctionDelegate>.NativeClassPtr, 100668934);
        ServerScriptMapper.ScheduledFunctionDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.ScheduledFunctionDelegate>.NativeClassPtr, 100668935);
        ServerScriptMapper.ScheduledFunctionDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.ScheduledFunctionDelegate>.NativeClassPtr, 100668936);
      }

      public ScheduledFunctionDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class StatChangeCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe StatChangeCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.StatChangeCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.StatChangeCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 383532, RefRangeEnd = 383539, XrefRangeStart = 383532, XrefRangeEnd = 383539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ref StatChangeEvent statChangeEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.StatChangeCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777493, XrefRangeEnd = 777503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ref StatChangeEvent statChangeEvent,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref statChangeEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.StatChangeCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777503, XrefRangeEnd = 777504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ref StatChangeEvent statChangeEvent,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref statChangeEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.StatChangeCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StatChangeCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.StatChangeCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (StatChangeCallbackDelegate));
        ServerScriptMapper.StatChangeCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.StatChangeCallbackDelegate>.NativeClassPtr, 100668937);
        ServerScriptMapper.StatChangeCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.StatChangeCallbackDelegate>.NativeClassPtr, 100668938);
        ServerScriptMapper.StatChangeCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.StatChangeCallbackDelegate>.NativeClassPtr, 100668939);
        ServerScriptMapper.StatChangeCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.StatChangeCallbackDelegate>.NativeClassPtr, 100668940);
      }

      public StatChangeCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class TriggerCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TriggerCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.TriggerCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.TriggerCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777504, XrefRangeEnd = 777522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        NativeArray<HitResult> hits)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.TriggerCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777522, XrefRangeEnd = 777532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        NativeArray<HitResult> hits,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.TriggerCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.TriggerCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TriggerCallbackDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.TriggerCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (TriggerCallbackDelegate));
        ServerScriptMapper.TriggerCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.TriggerCallbackDelegate>.NativeClassPtr, 100668941);
        ServerScriptMapper.TriggerCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.TriggerCallbackDelegate>.NativeClassPtr, 100668942);
        ServerScriptMapper.TriggerCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.TriggerCallbackDelegate>.NativeClassPtr, 100668943);
        ServerScriptMapper.TriggerCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.TriggerCallbackDelegate>.NativeClassPtr, 100668944);
      }

      public TriggerCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class GlobalDeathDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_DeathEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_NativeArray_1_DeathEvent_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GlobalDeathDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.GlobalDeathDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GlobalDeathDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        NativeArray<DeathEvent> deathEvents)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deathEvents;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GlobalDeathDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_DeathEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777532, XrefRangeEnd = 777542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        NativeArray<DeathEvent> deathEvents,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deathEvents;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GlobalDeathDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_NativeArray_1_DeathEvent_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GlobalDeathDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GlobalDeathDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.GlobalDeathDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (GlobalDeathDelegate));
        ServerScriptMapper.GlobalDeathDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GlobalDeathDelegate>.NativeClassPtr, 100668945);
        ServerScriptMapper.GlobalDeathDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GlobalDeathDelegate>.NativeClassPtr, 100668946);
        ServerScriptMapper.GlobalDeathDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_NativeArray_1_DeathEvent_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GlobalDeathDelegate>.NativeClassPtr, 100668947);
        ServerScriptMapper.GlobalDeathDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GlobalDeathDelegate>.NativeClassPtr, 100668948);
      }

      public GlobalDeathDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class OnKillDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_Entity_Entity_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_Entity_Entity_Entity_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OnKillDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.OnKillDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnKillDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777542, XrefRangeEnd = 777560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Entity killed,
        Entity killer,
        Entity source)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &killed;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &killer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnKillDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_Entity_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777560, XrefRangeEnd = 777574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Entity killed,
        Entity killer,
        Entity source,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &killed;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &killer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnKillDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_Entity_Entity_Entity_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnKillDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OnKillDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.OnKillDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (OnKillDelegate));
        ServerScriptMapper.OnKillDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnKillDelegate>.NativeClassPtr, 100668949);
        ServerScriptMapper.OnKillDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnKillDelegate>.NativeClassPtr, 100668950);
        ServerScriptMapper.OnKillDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_Entity_Entity_Entity_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnKillDelegate>.NativeClassPtr, 100668951);
        ServerScriptMapper.OnKillDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnKillDelegate>.NativeClassPtr, 100668952);
      }

      public OnKillDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class OnDeathDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OnDeathDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.OnDeathDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnDeathDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 691761, RefRangeEnd = 691772, XrefRangeStart = 691761, XrefRangeEnd = 691772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnDeathDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777574, XrefRangeEnd = 777581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnDeathDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnDeathDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OnDeathDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.OnDeathDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (OnDeathDelegate));
        ServerScriptMapper.OnDeathDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnDeathDelegate>.NativeClassPtr, 100668953);
        ServerScriptMapper.OnDeathDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnDeathDelegate>.NativeClassPtr, 100668954);
        ServerScriptMapper.OnDeathDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnDeathDelegate>.NativeClassPtr, 100668955);
        ServerScriptMapper.OnDeathDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnDeathDelegate>.NativeClassPtr, 100668956);
      }

      public OnDeathDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class OnSpawnedDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_Entity_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OnSpawnedDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.OnSpawnedDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnSpawnedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777581, XrefRangeEnd = 777597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Entity spawnedEntity)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnedEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnSpawnedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777597, XrefRangeEnd = 777607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Entity spawnedEntity,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnedEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnSpawnedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_Entity_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnSpawnedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OnSpawnedDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.OnSpawnedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (OnSpawnedDelegate));
        ServerScriptMapper.OnSpawnedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnSpawnedDelegate>.NativeClassPtr, 100668957);
        ServerScriptMapper.OnSpawnedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnSpawnedDelegate>.NativeClassPtr, 100668958);
        ServerScriptMapper.OnSpawnedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_Entity_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnSpawnedDelegate>.NativeClassPtr, 100668959);
        ServerScriptMapper.OnSpawnedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnSpawnedDelegate>.NativeClassPtr, 100668960);
      }

      public OnSpawnedDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class OnPlacementResultDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_PlacementResult_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OnPlacementResultDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.OnPlacementResultDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnPlacementResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777607, XrefRangeEnd = 777627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        PlacementResult placementResult)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &placementResult;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnPlacementResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_PlacementResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777627, XrefRangeEnd = 777637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        PlacementResult placementResult,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &placementResult;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnPlacementResultDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_PlacementResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.OnPlacementResultDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OnPlacementResultDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.OnPlacementResultDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (OnPlacementResultDelegate));
        ServerScriptMapper.OnPlacementResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnPlacementResultDelegate>.NativeClassPtr, 100668961);
        ServerScriptMapper.OnPlacementResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnPlacementResultDelegate>.NativeClassPtr, 100668962);
        ServerScriptMapper.OnPlacementResultDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_PlacementResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnPlacementResultDelegate>.NativeClassPtr, 100668963);
        ServerScriptMapper.OnPlacementResultDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.OnPlacementResultDelegate>.NativeClassPtr, 100668964);
      }

      public OnPlacementResultDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class GenericEventDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_Entity_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GenericEventDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScriptMapper.GenericEventDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GenericEventDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Entity eventEntity)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GenericEventDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777637, XrefRangeEnd = 777647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Entity eventEntity,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GenericEventDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_Entity_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerScriptMapper.GenericEventDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GenericEventDelegate()
      {
        Il2CppClassPointerStore<ServerScriptMapper.GenericEventDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr, nameof (GenericEventDelegate));
        ServerScriptMapper.GenericEventDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GenericEventDelegate>.NativeClassPtr, 100668965);
        ServerScriptMapper.GenericEventDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GenericEventDelegate>.NativeClassPtr, 100668966);
        ServerScriptMapper.GenericEventDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ServerGameManager_byref_SelfServer_Entity_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GenericEventDelegate>.NativeClassPtr, 100668967);
        ServerScriptMapper.GenericEventDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ServerGameManager_byref_SelfServer_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScriptMapper.GenericEventDelegate>.NativeClassPtr, 100668968);
      }

      public GenericEventDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerScriptMapper.NativeMethodInfoPtr_Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0, Il2CppClassPointerStore<ServerScriptMapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
