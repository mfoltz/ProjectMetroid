// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.HandleGameplayEventsBase
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Debugging;
using ProjectM.Scripting;
using ProjectM.Shared;
using ProjectM.Tiles;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class HandleGameplayEventsBase : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrierSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ScriptMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr__VBloodSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__BlinkSystems_Server;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedTeamsChecked;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr__OutOfCombatStringHash;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConditionCheckerFactory;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__MinionComponentsToRemove;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameplayEventsSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__JewelSpawnSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModTierCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveOnHitTrigger_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveOnHitTrigger_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_KnockbackAssetsSingleton_18;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_19;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_20;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAfterUpdate_Protected_Virtual_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleGameplayEvent_Private_Static_Void_byref_BufferFromEntity_1_GameplayEventListeners_byref_GameplayEvent_byref_BufferFromEntity_1_GameplayEventIdMapping_byref_NativeList_1_Int32_byref_GameplayDebugRecorder_byref_Double_byref_NativeList_1_GameplayEventScriptTrigger_byref_GameplayEventInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DealDamageGameplayEvents_Private_Static_Void_byref_GameplayEventInput_DynamicBuffer_1_GameplayEventIdMapping_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleLifeLeech_Private_Static_Void_GameplayEventInput_DynamicBuffer_1_GameplayEventIdMapping_GameplayEvent_EntityOwner_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunScriptOnGameplayEventMethod_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_NativeList_1_GameplayEventScriptTrigger_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeGameplayEvents_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMinionPrefabIndexArray_Private_Static_NativeArray_1_Int32_byref_GameplayEventInput_byref_SpawnMinionOnGameplayEvent_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnMinionOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnMinion_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_SpawnMinionOnGameplayEvent_byref_Entity_byref_MinionConfig_byref_MinionOwnerConfig_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetKnockbackPowerValues_Private_Static_KnockbackPowerValues_byref_KnockbackPower_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipmentOrUnitLevel_Private_Static_Boolean_byref_EntityManager_byref_Entity_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrientation_Private_Static_Boolean_float3_float3_Boolean_byref_quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyKnockbackOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateAggroOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAggroTarget_Private_Static_Entity_AggroGameplayEventWho_byref_EntityManager_byref_GameplayEvent_byref_EntityOwner_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BranchOnGameplayEvents_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IterateGameplayEvents_Private_Static_Void_byref_GameplayEventInput_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DropFromTablesOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TransformBuffTargetOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_EntityOwner_byref_GameplayEvent_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBloodOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_EntityOwner_byref_GameplayEvent_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnPrefabOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBuffOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayImpactOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAbilityOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGameplayEventListener_Public_Static_Boolean_byref_EntityManager_byref_GameplayEvent_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySetGameplayEventListener_Public_Static_Boolean_byref_EntityManager_byref_GameplayEvent_Int32_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayBlinkSequenceOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuffOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_GameplayEventRecorder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMinionMaster_Private_Static_Entity_byref_GameplayEvent_byref_GameplayEventInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSpellTarget_Private_Static_Entity_byref_GameplayEvent_byref_GameplayEventInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryApplyBuff_Private_Static_Boolean_byref_GameplayEventInput_byref_GameplayEvent_byref_ApplyBuffOnGameplayEvent_EntityOwner_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyArithmeticValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyPrefabGUIDValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifySequenceGUIDValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HealOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequenceOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeEnergyOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ForceCastOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdjustLifetimeOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdjustCurrentCooldownOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdjustCurrentChargesOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StopSpellMovementOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearAggroOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemoveOnHitTrigger_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;

    public virtual unsafe bool IsAfterUpdate
    {
      [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleGameplayEventsBase.NativeMethodInfoPtr_get_IsAfterUpdate_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443704, XrefRangeEnd = 1443819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleGameplayEventsBase.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443819, XrefRangeEnd = 1443835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleGameplayEventsBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443835, XrefRangeEnd = 1444009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleGameplayEventsBase.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444094, RefRangeEnd = 1444095, XrefRangeStart = 1444009, XrefRangeEnd = 1444094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void HandleGameplayEvent(
      [In] ref BufferFromEntity<GameplayEventListeners> getGameplayEventListeners,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref BufferFromEntity<GameplayEventIdMapping> getEventIdMappings,
      [In] ref NativeList<int> ignoredEventTypes,
      ref GameplayDebugRecorder gameplayDebugRecorder,
      [In] ref double serverTime,
      [In] ref NativeList<GameplayEventScriptTrigger> gameplayEventScriptTriggers,
      ref HandleGameplayEventsBase.GameplayEventInput gameplayEventInput)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref getGameplayEventListeners;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref getEventIdMappings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ignoredEventTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayDebugRecorder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEventScriptTriggers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEventInput;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_HandleGameplayEvent_Private_Static_Void_byref_BufferFromEntity_1_GameplayEventListeners_byref_GameplayEvent_byref_BufferFromEntity_1_GameplayEventIdMapping_byref_NativeList_1_Int32_byref_GameplayDebugRecorder_byref_Double_byref_NativeList_1_GameplayEventScriptTrigger_byref_GameplayEventInput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444120, RefRangeEnd = 1444121, XrefRangeStart = 1444095, XrefRangeEnd = 1444120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DealDamageGameplayEvents(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      DynamicBuffer<GameplayEventIdMapping> gameplayEventIdMappings,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEventIdMappings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_DealDamageGameplayEvents_Private_Static_Void_byref_GameplayEventInput_DynamicBuffer_1_GameplayEventIdMapping_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444168, RefRangeEnd = 1444169, XrefRangeStart = 1444121, XrefRangeEnd = 1444168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void HandleLifeLeech(
      HandleGameplayEventsBase.GameplayEventInput input,
      DynamicBuffer<GameplayEventIdMapping> gameplayEventIdMappings,
      GameplayEvent gameplayEvent,
      EntityOwner entityOwner,
      Entity changeEventEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEventIdMappings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &changeEventEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_HandleLifeLeech_Private_Static_Void_GameplayEventInput_DynamicBuffer_1_GameplayEventIdMapping_GameplayEvent_EntityOwner_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444175, RefRangeEnd = 1444176, XrefRangeStart = 1444169, XrefRangeEnd = 1444175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunScriptOnGameplayEventMethod(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref NativeList<GameplayEventScriptTrigger> gameplayEventScriptTriggers,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEventScriptTriggers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_RunScriptOnGameplayEventMethod_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_NativeList_1_GameplayEventScriptTrigger_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444198, RefRangeEnd = 1444199, XrefRangeStart = 1444176, XrefRangeEnd = 1444198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ConsumeGameplayEvents(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_ConsumeGameplayEvents_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444211, RefRangeEnd = 1444212, XrefRangeStart = 1444199, XrefRangeEnd = 1444211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeArray<int> GetMinionPrefabIndexArray(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref ProjectM.SpawnMinionOnGameplayEvent spawnMinion,
      int prefabCount,
      int minionCount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnMinion;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &minionCount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_GetMinionPrefabIndexArray_Private_Static_NativeArray_1_Int32_byref_GameplayEventInput_byref_SpawnMinionOnGameplayEvent_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<int>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444274, RefRangeEnd = 1444275, XrefRangeStart = 1444212, XrefRangeEnd = 1444274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SpawnMinionOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_SpawnMinionOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444425, RefRangeEnd = 1444426, XrefRangeStart = 1444275, XrefRangeEnd = 1444425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SpawnMinion(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref ProjectM.SpawnMinionOnGameplayEvent spawnEvent,
      [In] ref Entity minionPrefab,
      [In] ref HandleGameplayEventsBase.MinionConfig minionConfig,
      [In] ref HandleGameplayEventsBase.MinionOwnerConfig ownerConfig)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref minionPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref minionConfig;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref ownerConfig;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_SpawnMinion_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_SpawnMinionOnGameplayEvent_byref_Entity_byref_MinionConfig_byref_MinionOwnerConfig_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe HandleGameplayEventsBase.KnockbackPowerValues GetKnockbackPowerValues(
      [In] ref KnockbackPower knockbackPower,
      int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref knockbackPower;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_GetKnockbackPowerValues_Private_Static_KnockbackPowerValues_byref_KnockbackPower_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(HandleGameplayEventsBase.KnockbackPowerValues*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1444436, RefRangeEnd = 1444438, XrefRangeStart = 1444426, XrefRangeEnd = 1444436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetEquipmentOrUnitLevel(
      ref EntityManager entityManager,
      [In] ref Entity entity,
      out float level)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref level;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_GetEquipmentOrUnitLevel_Private_Static_Boolean_byref_EntityManager_byref_Entity_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1444438, XrefRangeEnd = 1444447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetOrientation(
      float3 origin,
      float3 target,
      bool inverse,
      out quaternion rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &origin;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inverse;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_GetOrientation_Private_Static_Boolean_float3_float3_Boolean_byref_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444516, RefRangeEnd = 1444517, XrefRangeStart = 1444447, XrefRangeEnd = 1444516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ApplyKnockbackOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_ApplyKnockbackOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444538, RefRangeEnd = 1444539, XrefRangeStart = 1444517, XrefRangeEnd = 1444538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GenerateAggroOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_GenerateAggroOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1444545, RefRangeEnd = 1444548, XrefRangeStart = 1444539, XrefRangeEnd = 1444545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetAggroTarget(
      AggroGameplayEventWho target,
      [In] ref EntityManager entityManager,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_GetAggroTarget_Private_Static_Entity_AggroGameplayEventWho_byref_EntityManager_byref_GameplayEvent_byref_EntityOwner_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444556, RefRangeEnd = 1444557, XrefRangeStart = 1444548, XrefRangeEnd = 1444556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void BranchOnGameplayEvents(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_BranchOnGameplayEvents_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444579, RefRangeEnd = 1444580, XrefRangeStart = 1444557, XrefRangeEnd = 1444579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void IterateGameplayEvents(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_IterateGameplayEvents_Private_Static_Void_byref_GameplayEventInput_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444593, RefRangeEnd = 1444594, XrefRangeStart = 1444580, XrefRangeEnd = 1444593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DropFromTablesOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_DropFromTablesOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444724, RefRangeEnd = 1444725, XrefRangeStart = 1444594, XrefRangeEnd = 1444724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TransformBuffTargetOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref EntityOwner entityOwner,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_TransformBuffTargetOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_EntityOwner_byref_GameplayEvent_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444751, RefRangeEnd = 1444752, XrefRangeStart = 1444725, XrefRangeEnd = 1444751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ChangeBloodOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref EntityOwner entityOwner,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_ChangeBloodOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_EntityOwner_byref_GameplayEvent_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444832, RefRangeEnd = 1444833, XrefRangeStart = 1444752, XrefRangeEnd = 1444832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SpawnPrefabOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_SpawnPrefabOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444878, RefRangeEnd = 1444879, XrefRangeStart = 1444833, XrefRangeEnd = 1444878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveBuffOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_RemoveBuffOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1444960, RefRangeEnd = 1444961, XrefRangeStart = 1444879, XrefRangeEnd = 1444960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PlayImpactOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_PlayImpactOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445011, RefRangeEnd = 1445012, XrefRangeStart = 1444961, XrefRangeEnd = 1445011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ChangeAbilityOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_ChangeAbilityOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445021, RefRangeEnd = 1445022, XrefRangeStart = 1445012, XrefRangeEnd = 1445021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetGameplayEventListener<T>(
      ref EntityManager entityManager,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex,
      out T eventListener)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref eventListener;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.MethodInfoStoreGeneric_TryGetGameplayEventListener_Public_Static_Boolean_byref_EntityManager_byref_GameplayEvent_Int32_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref eventListener;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445031, RefRangeEnd = 1445032, XrefRangeStart = 1445022, XrefRangeEnd = 1445031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TrySetGameplayEventListener<T>(
      ref EntityManager entityManager,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex,
      T eventListener)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) eventListener;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref eventListener;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.MethodInfoStoreGeneric_TrySetGameplayEventListener_Public_Static_Boolean_byref_EntityManager_byref_GameplayEvent_Int32_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445041, RefRangeEnd = 1445042, XrefRangeStart = 1445032, XrefRangeEnd = 1445041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PlayBlinkSequenceOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_PlayBlinkSequenceOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445078, RefRangeEnd = 1445079, XrefRangeStart = 1445042, XrefRangeEnd = 1445078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_DestroyOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445097, RefRangeEnd = 1445098, XrefRangeStart = 1445079, XrefRangeEnd = 1445097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ApplyBuffOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex,
      GameplayEventRecorder eventRecorder)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &eventRecorder;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_ApplyBuffOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_GameplayEventRecorder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1445134, RefRangeEnd = 1445136, XrefRangeStart = 1445098, XrefRangeEnd = 1445134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetMinionMaster(
      [In] ref GameplayEvent gameplayEvent,
      [In] ref HandleGameplayEventsBase.GameplayEventInput input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_GetMinionMaster_Private_Static_Entity_byref_GameplayEvent_byref_GameplayEventInput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1445141, RefRangeEnd = 1445143, XrefRangeStart = 1445136, XrefRangeEnd = 1445141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetSpellTarget(
      [In] ref GameplayEvent gameplayEvent,
      [In] ref HandleGameplayEventsBase.GameplayEventInput input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_GetSpellTarget_Private_Static_Entity_byref_GameplayEvent_byref_GameplayEventInput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1445206, RefRangeEnd = 1445210, XrefRangeStart = 1445143, XrefRangeEnd = 1445206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryApplyBuff(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref ProjectM.ApplyBuffOnGameplayEvent evt,
      EntityOwner entityOwner,
      PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_TryApplyBuff_Private_Static_Boolean_byref_GameplayEventInput_byref_GameplayEvent_byref_ApplyBuffOnGameplayEvent_EntityOwner_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445240, RefRangeEnd = 1445241, XrefRangeStart = 1445210, XrefRangeEnd = 1445240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ModifyArithmeticValue<T>(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      GameplayEventTypeEnum gameplayEventType,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex,
      ref T arithmeticValue)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
      numPtr1[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEventType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arithmeticValue);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.MethodInfoStoreGeneric_ModifyArithmeticValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref T local = ref arithmeticValue;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
      local = (T) valueGeneric;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445270, RefRangeEnd = 1445271, XrefRangeStart = 1445241, XrefRangeEnd = 1445270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ModifyPrefabGUIDValue<T>(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      GameplayEventTypeEnum gameplayEventType,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex,
      ref T prefabGuidValue)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
      numPtr1[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEventType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabGuidValue);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.MethodInfoStoreGeneric_ModifyPrefabGUIDValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref T local = ref prefabGuidValue;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
      local = (T) valueGeneric;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1445271, XrefRangeEnd = 1445292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ModifySequenceGUIDValue<T>(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      GameplayEventTypeEnum gameplayEventType,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex,
      ref T prefabGuidValue)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
      numPtr1[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEventType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabGuidValue);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.MethodInfoStoreGeneric_ModifySequenceGUIDValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref T local = ref prefabGuidValue;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
      local = (T) valueGeneric;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445313, RefRangeEnd = 1445314, XrefRangeStart = 1445292, XrefRangeEnd = 1445313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void HealOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner owner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_HealOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445356, RefRangeEnd = 1445357, XrefRangeStart = 1445314, XrefRangeEnd = 1445356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PlaySequenceOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner owner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_PlaySequenceOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445365, RefRangeEnd = 1445366, XrefRangeStart = 1445357, XrefRangeEnd = 1445365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ChangeEnergyOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_ChangeEnergyOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445390, RefRangeEnd = 1445391, XrefRangeStart = 1445366, XrefRangeEnd = 1445390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ForceCastOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner owner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_ForceCastOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445402, RefRangeEnd = 1445403, XrefRangeStart = 1445391, XrefRangeEnd = 1445402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AdjustLifetimeOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_AdjustLifetimeOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445417, RefRangeEnd = 1445418, XrefRangeStart = 1445403, XrefRangeEnd = 1445417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AdjustCurrentCooldownOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_AdjustCurrentCooldownOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445435, RefRangeEnd = 1445436, XrefRangeStart = 1445418, XrefRangeEnd = 1445435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AdjustCurrentChargesOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_AdjustCurrentChargesOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445451, RefRangeEnd = 1445452, XrefRangeStart = 1445436, XrefRangeEnd = 1445451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void StopSpellMovementOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_StopSpellMovementOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445468, RefRangeEnd = 1445469, XrefRangeStart = 1445452, XrefRangeEnd = 1445468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearAggroOnGameplayEvent(
      ref HandleGameplayEventsBase.GameplayEventInput input,
      [In] ref GameplayEvent gameplayEvent,
      [In] ref EntityOwner entityOwner,
      int eventIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_ClearAggroOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HandleGameplayEventsBase()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1445602, RefRangeEnd = 1445604, XrefRangeStart = 1445469, XrefRangeEnd = 1445602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleGameplayEventsBase.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1445604, XrefRangeEnd = 1445623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1445623, XrefRangeEnd = 1445639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1445639, XrefRangeEnd = 1445655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemoveOnHitTrigger_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr___GetEntityQuery_ForRemoveOnHitTrigger_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445659, RefRangeEnd = 1445660, XrefRangeStart = 1445655, XrefRangeEnd = 1445659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445664, RefRangeEnd = 1445665, XrefRangeStart = 1445660, XrefRangeEnd = 1445664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445669, RefRangeEnd = 1445670, XrefRangeStart = 1445665, XrefRangeEnd = 1445669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1445674, RefRangeEnd = 1445675, XrefRangeStart = 1445670, XrefRangeEnd = 1445674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HandleGameplayEventsBase()
    {
      Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (HandleGameplayEventsBase));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr);
      HandleGameplayEventsBase.NativeFieldInfoPtr__SpawnBarrierSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_SpawnBarrierSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr__ScriptMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_ScriptMapper));
      HandleGameplayEventsBase.NativeFieldInfoPtr__VBloodSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_VBloodSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr__BlinkSystems_Server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_BlinkSystems_Server));
      HandleGameplayEventsBase.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_GameDataSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr__CachedTeamsChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_CachedTeamsChecked));
      HandleGameplayEventsBase.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_ServerDebugSettings));
      HandleGameplayEventsBase.NativeFieldInfoPtr__BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_BalanceSettings));
      HandleGameplayEventsBase.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_ServerTime));
      HandleGameplayEventsBase.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_WorldFrame));
      HandleGameplayEventsBase.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_TileWorldSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_TilePolygons));
      HandleGameplayEventsBase.NativeFieldInfoPtr__OutOfCombatStringHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_OutOfCombatStringHash));
      HandleGameplayEventsBase.NativeFieldInfoPtr__ConditionCheckerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_ConditionCheckerFactory));
      HandleGameplayEventsBase.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      HandleGameplayEventsBase.NativeFieldInfoPtr__MinionComponentsToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_MinionComponentsToRemove));
      HandleGameplayEventsBase.NativeFieldInfoPtr__GameplayEventsSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_GameplayEventsSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr__CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_CurveCollectionSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr__SpellModCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_SpellModCollectionSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr__JewelSpawnSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_JewelSpawnSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr__SpellModTierCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_SpellModTierCollectionSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_CollisionSystem));
      HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>OnUpdate_LambdaJob2_profilerMarker");
      HandleGameplayEventsBase.NativeFieldInfoPtr___RemoveOnHitTrigger_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>RemoveOnHitTrigger_entityQuery");
      HandleGameplayEventsBase.NativeFieldInfoPtr___RemoveOnHitTrigger_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>RemoveOnHitTrigger_profilerMarker");
      HandleGameplayEventsBase.NativeFieldInfoPtr__SingletonEntityQuery_KnockbackAssetsSingleton_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_SingletonEntityQuery_KnockbackAssetsSingleton_18));
      HandleGameplayEventsBase.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerGameBalanceSettings_19));
      HandleGameplayEventsBase.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (_SingletonEntityQuery_RelicDropped_20));
      HandleGameplayEventsBase.NativeMethodInfoPtr_get_IsAfterUpdate_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672052);
      HandleGameplayEventsBase.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672053);
      HandleGameplayEventsBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672054);
      HandleGameplayEventsBase.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672055);
      HandleGameplayEventsBase.NativeMethodInfoPtr_HandleGameplayEvent_Private_Static_Void_byref_BufferFromEntity_1_GameplayEventListeners_byref_GameplayEvent_byref_BufferFromEntity_1_GameplayEventIdMapping_byref_NativeList_1_Int32_byref_GameplayDebugRecorder_byref_Double_byref_NativeList_1_GameplayEventScriptTrigger_byref_GameplayEventInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672056);
      HandleGameplayEventsBase.NativeMethodInfoPtr_DealDamageGameplayEvents_Private_Static_Void_byref_GameplayEventInput_DynamicBuffer_1_GameplayEventIdMapping_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672057);
      HandleGameplayEventsBase.NativeMethodInfoPtr_HandleLifeLeech_Private_Static_Void_GameplayEventInput_DynamicBuffer_1_GameplayEventIdMapping_GameplayEvent_EntityOwner_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672058);
      HandleGameplayEventsBase.NativeMethodInfoPtr_RunScriptOnGameplayEventMethod_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_NativeList_1_GameplayEventScriptTrigger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672059);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ConsumeGameplayEvents_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672060);
      HandleGameplayEventsBase.NativeMethodInfoPtr_GetMinionPrefabIndexArray_Private_Static_NativeArray_1_Int32_byref_GameplayEventInput_byref_SpawnMinionOnGameplayEvent_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672061);
      HandleGameplayEventsBase.NativeMethodInfoPtr_SpawnMinionOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672062);
      HandleGameplayEventsBase.NativeMethodInfoPtr_SpawnMinion_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_SpawnMinionOnGameplayEvent_byref_Entity_byref_MinionConfig_byref_MinionOwnerConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672063);
      HandleGameplayEventsBase.NativeMethodInfoPtr_GetKnockbackPowerValues_Private_Static_KnockbackPowerValues_byref_KnockbackPower_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672064);
      HandleGameplayEventsBase.NativeMethodInfoPtr_GetEquipmentOrUnitLevel_Private_Static_Boolean_byref_EntityManager_byref_Entity_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672065);
      HandleGameplayEventsBase.NativeMethodInfoPtr_GetOrientation_Private_Static_Boolean_float3_float3_Boolean_byref_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672066);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ApplyKnockbackOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672067);
      HandleGameplayEventsBase.NativeMethodInfoPtr_GenerateAggroOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672068);
      HandleGameplayEventsBase.NativeMethodInfoPtr_GetAggroTarget_Private_Static_Entity_AggroGameplayEventWho_byref_EntityManager_byref_GameplayEvent_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672069);
      HandleGameplayEventsBase.NativeMethodInfoPtr_BranchOnGameplayEvents_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672070);
      HandleGameplayEventsBase.NativeMethodInfoPtr_IterateGameplayEvents_Private_Static_Void_byref_GameplayEventInput_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672071);
      HandleGameplayEventsBase.NativeMethodInfoPtr_DropFromTablesOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672072);
      HandleGameplayEventsBase.NativeMethodInfoPtr_TransformBuffTargetOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_EntityOwner_byref_GameplayEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672073);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ChangeBloodOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_EntityOwner_byref_GameplayEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672074);
      HandleGameplayEventsBase.NativeMethodInfoPtr_SpawnPrefabOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672075);
      HandleGameplayEventsBase.NativeMethodInfoPtr_RemoveBuffOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672076);
      HandleGameplayEventsBase.NativeMethodInfoPtr_PlayImpactOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672077);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ChangeAbilityOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672078);
      HandleGameplayEventsBase.NativeMethodInfoPtr_TryGetGameplayEventListener_Public_Static_Boolean_byref_EntityManager_byref_GameplayEvent_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672079);
      HandleGameplayEventsBase.NativeMethodInfoPtr_TrySetGameplayEventListener_Public_Static_Boolean_byref_EntityManager_byref_GameplayEvent_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672080);
      HandleGameplayEventsBase.NativeMethodInfoPtr_PlayBlinkSequenceOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672081);
      HandleGameplayEventsBase.NativeMethodInfoPtr_DestroyOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672082);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ApplyBuffOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_GameplayEventRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672083);
      HandleGameplayEventsBase.NativeMethodInfoPtr_GetMinionMaster_Private_Static_Entity_byref_GameplayEvent_byref_GameplayEventInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672084);
      HandleGameplayEventsBase.NativeMethodInfoPtr_GetSpellTarget_Private_Static_Entity_byref_GameplayEvent_byref_GameplayEventInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672085);
      HandleGameplayEventsBase.NativeMethodInfoPtr_TryApplyBuff_Private_Static_Boolean_byref_GameplayEventInput_byref_GameplayEvent_byref_ApplyBuffOnGameplayEvent_EntityOwner_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672086);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ModifyArithmeticValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672087);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ModifyPrefabGUIDValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672088);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ModifySequenceGUIDValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672089);
      HandleGameplayEventsBase.NativeMethodInfoPtr_HealOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672090);
      HandleGameplayEventsBase.NativeMethodInfoPtr_PlaySequenceOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672091);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ChangeEnergyOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672092);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ForceCastOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672093);
      HandleGameplayEventsBase.NativeMethodInfoPtr_AdjustLifetimeOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672094);
      HandleGameplayEventsBase.NativeMethodInfoPtr_AdjustCurrentCooldownOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672095);
      HandleGameplayEventsBase.NativeMethodInfoPtr_AdjustCurrentChargesOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672096);
      HandleGameplayEventsBase.NativeMethodInfoPtr_StopSpellMovementOnGameplayEvent_Private_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672097);
      HandleGameplayEventsBase.NativeMethodInfoPtr_ClearAggroOnGameplayEvent_Public_Static_Void_byref_GameplayEventInput_byref_GameplayEvent_byref_EntityOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672098);
      HandleGameplayEventsBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672099);
      HandleGameplayEventsBase.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672100);
      HandleGameplayEventsBase.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672101);
      HandleGameplayEventsBase.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672102);
      HandleGameplayEventsBase.NativeMethodInfoPtr___GetEntityQuery_ForRemoveOnHitTrigger_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672103);
      HandleGameplayEventsBase.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672104);
      HandleGameplayEventsBase.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672105);
      HandleGameplayEventsBase.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672106);
      HandleGameplayEventsBase.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, 100672107);
    }

    public HandleGameplayEventsBase(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnBarrier _SpawnBarrierSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SpawnBarrierSystem));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SpawnBarrierSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper _ScriptMapper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__ScriptMapper));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper) null : new ServerScriptMapper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__ScriptMapper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VBloodSystem _VBloodSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__VBloodSystem));
        return pointer == System.IntPtr.Zero ? (VBloodSystem) null : new VBloodSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__VBloodSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlinkSystems_Server _BlinkSystems_Server
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__BlinkSystems_Server));
        return pointer == System.IntPtr.Zero ? (BlinkSystems_Server) null : new BlinkSystems_Server(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__BlinkSystems_Server), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<Entity> _CachedTeamsChecked
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__CachedTeamsChecked));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__CachedTeamsChecked), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _BalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__BalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__BalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
    {
      get
      {
        return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__TilePolygons));
      }
      [param: In] set
      {
        *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__TilePolygons)) = value;
      }
    }

    public unsafe int _OutOfCombatStringHash
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__OutOfCombatStringHash));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__OutOfCombatStringHash)) = value;
      }
    }

    public unsafe ConditionCheckerFactory _ConditionCheckerFactory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__ConditionCheckerFactory));
        return pointer == System.IntPtr.Zero ? (ConditionCheckerFactory) null : new ConditionCheckerFactory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__ConditionCheckerFactory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ComponentTypes _MinionComponentsToRemove
    {
      get
      {
        return *(ComponentTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__MinionComponentsToRemove));
      }
      [param: In] set
      {
        *(ComponentTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__MinionComponentsToRemove)) = value;
      }
    }

    public unsafe GameplayEventsSystem _GameplayEventsSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__GameplayEventsSystem));
        return pointer == System.IntPtr.Zero ? (GameplayEventsSystem) null : new GameplayEventsSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__GameplayEventsSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModCollectionSystem _SpellModCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SpellModCollectionSystem));
        return pointer == System.IntPtr.Zero ? (SpellModCollectionSystem) null : new SpellModCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SpellModCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JewelSpawnSystem _JewelSpawnSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__JewelSpawnSystem));
        return pointer == System.IntPtr.Zero ? (JewelSpawnSystem) null : new JewelSpawnSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__JewelSpawnSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModTierCollectionSystem _SpellModTierCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SpellModTierCollectionSystem));
        return pointer == System.IntPtr.Zero ? (SpellModTierCollectionSystem) null : new SpellModTierCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SpellModTierCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RemoveOnHitTrigger_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___RemoveOnHitTrigger_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___RemoveOnHitTrigger_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemoveOnHitTrigger_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___RemoveOnHitTrigger_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr___RemoveOnHitTrigger_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_KnockbackAssetsSingleton_18
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SingletonEntityQuery_KnockbackAssetsSingleton_18));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SingletonEntityQuery_KnockbackAssetsSingleton_18)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerGameBalanceSettings_19
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_19));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_19)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_RelicDropped_20
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_20));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleGameplayEventsBase.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_20)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InstantiateAbilityForCharacter
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Character;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupGuid;
      [FieldOffset(0)]
      public Entity Character;
      [FieldOffset(8)]
      public PrefabGUID AbilityGroupGuid;

      static InstantiateAbilityForCharacter()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.InstantiateAbilityForCharacter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (InstantiateAbilityForCharacter));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.InstantiateAbilityForCharacter>.NativeClassPtr);
        HandleGameplayEventsBase.InstantiateAbilityForCharacter.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.InstantiateAbilityForCharacter>.NativeClassPtr, nameof (Character));
        HandleGameplayEventsBase.InstantiateAbilityForCharacter.NativeFieldInfoPtr_AbilityGroupGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.InstantiateAbilityForCharacter>.NativeClassPtr, nameof (AbilityGroupGuid));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.InstantiateAbilityForCharacter>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MinionConfig
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HasBloodConsumeSource;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasHealthConstants;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasAttach;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasUnitLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasUnitStats;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasFactionReference;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_FactionReference;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemoveComponents;
      private static readonly System.IntPtr NativeFieldInfoPtr_DynamicallyWeakenAttackersOverride;
      [FieldOffset(0)]
      public bool HasBloodConsumeSource;
      [FieldOffset(1)]
      public bool HasHealthConstants;
      [FieldOffset(2)]
      public bool HasAttach;
      [FieldOffset(3)]
      public bool HasUnitLevel;
      [FieldOffset(4)]
      public bool HasUnitStats;
      [FieldOffset(5)]
      public bool HasFactionReference;
      [FieldOffset(8)]
      public float3 StartPosition;
      [FieldOffset(20)]
      public FactionReference FactionReference;
      [FieldOffset(28)]
      public ComponentTypes RemoveComponents;
      [FieldOffset(100)]
      public DynamicallyWeakenAttackers DynamicallyWeakenAttackersOverride;

      static MinionConfig()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (MinionConfig));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr);
        HandleGameplayEventsBase.MinionConfig.NativeFieldInfoPtr_HasBloodConsumeSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, nameof (HasBloodConsumeSource));
        HandleGameplayEventsBase.MinionConfig.NativeFieldInfoPtr_HasHealthConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, nameof (HasHealthConstants));
        HandleGameplayEventsBase.MinionConfig.NativeFieldInfoPtr_HasAttach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, nameof (HasAttach));
        HandleGameplayEventsBase.MinionConfig.NativeFieldInfoPtr_HasUnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, nameof (HasUnitLevel));
        HandleGameplayEventsBase.MinionConfig.NativeFieldInfoPtr_HasUnitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, nameof (HasUnitStats));
        HandleGameplayEventsBase.MinionConfig.NativeFieldInfoPtr_HasFactionReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, nameof (HasFactionReference));
        HandleGameplayEventsBase.MinionConfig.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, nameof (StartPosition));
        HandleGameplayEventsBase.MinionConfig.NativeFieldInfoPtr_FactionReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, nameof (FactionReference));
        HandleGameplayEventsBase.MinionConfig.NativeFieldInfoPtr_RemoveComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, nameof (RemoveComponents));
        HandleGameplayEventsBase.MinionConfig.NativeFieldInfoPtr_DynamicallyWeakenAttackersOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, nameof (DynamicallyWeakenAttackersOverride));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionConfig>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MinionOwnerConfig
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HasEquipment;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasUnitLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasUnitStats;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasFactionReference;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Equipment;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats;
      private static readonly System.IntPtr NativeFieldInfoPtr_FactionReference;
      [FieldOffset(0)]
      public bool HasEquipment;
      [FieldOffset(1)]
      public bool HasUnitLevel;
      [FieldOffset(2)]
      public bool HasUnitStats;
      [FieldOffset(3)]
      public bool HasFactionReference;
      [FieldOffset(4)]
      public Entity Entity;
      [FieldOffset(12)]
      public Equipment Equipment;
      [FieldOffset(240)]
      public UnitLevel UnitLevel;
      [FieldOffset(244)]
      public UnitStats UnitStats;
      [FieldOffset(424)]
      public FactionReference FactionReference;

      static MinionOwnerConfig()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (MinionOwnerConfig));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr);
        HandleGameplayEventsBase.MinionOwnerConfig.NativeFieldInfoPtr_HasEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr, nameof (HasEquipment));
        HandleGameplayEventsBase.MinionOwnerConfig.NativeFieldInfoPtr_HasUnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr, nameof (HasUnitLevel));
        HandleGameplayEventsBase.MinionOwnerConfig.NativeFieldInfoPtr_HasUnitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr, nameof (HasUnitStats));
        HandleGameplayEventsBase.MinionOwnerConfig.NativeFieldInfoPtr_HasFactionReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr, nameof (HasFactionReference));
        HandleGameplayEventsBase.MinionOwnerConfig.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr, nameof (Entity));
        HandleGameplayEventsBase.MinionOwnerConfig.NativeFieldInfoPtr_Equipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr, nameof (Equipment));
        HandleGameplayEventsBase.MinionOwnerConfig.NativeFieldInfoPtr_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr, nameof (UnitLevel));
        HandleGameplayEventsBase.MinionOwnerConfig.NativeFieldInfoPtr_UnitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr, nameof (UnitStats));
        HandleGameplayEventsBase.MinionOwnerConfig.NativeFieldInfoPtr_FactionReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr, nameof (FactionReference));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.MinionOwnerConfig>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct KnockbackPowerValues
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DistanceFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_DurationFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_StunMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_WeaponLevelModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_UseWeaponLevel;
      [FieldOffset(0)]
      public float DistanceFactor;
      [FieldOffset(4)]
      public float DurationFactor;
      [FieldOffset(8)]
      public KnockbackStunMode StunMode;
      [FieldOffset(9)]
      public sbyte WeaponLevelModifier;
      [FieldOffset(10)]
      public bool UseWeaponLevel;

      static KnockbackPowerValues()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.KnockbackPowerValues>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (KnockbackPowerValues));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.KnockbackPowerValues>.NativeClassPtr);
        HandleGameplayEventsBase.KnockbackPowerValues.NativeFieldInfoPtr_DistanceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.KnockbackPowerValues>.NativeClassPtr, nameof (DistanceFactor));
        HandleGameplayEventsBase.KnockbackPowerValues.NativeFieldInfoPtr_DurationFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.KnockbackPowerValues>.NativeClassPtr, nameof (DurationFactor));
        HandleGameplayEventsBase.KnockbackPowerValues.NativeFieldInfoPtr_StunMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.KnockbackPowerValues>.NativeClassPtr, nameof (StunMode));
        HandleGameplayEventsBase.KnockbackPowerValues.NativeFieldInfoPtr_WeaponLevelModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.KnockbackPowerValues>.NativeClassPtr, nameof (WeaponLevelModifier));
        HandleGameplayEventsBase.KnockbackPowerValues.NativeFieldInfoPtr_UseWeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.KnockbackPowerValues>.NativeClassPtr, nameof (UseWeaponLevel));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.KnockbackPowerValues>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GameplayEventInput
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffSpawner;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedSequence;
      private static readonly System.IntPtr NativeFieldInfoPtr_HitEffectsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutOfCombatStringHash;
      private static readonly System.IntPtr NativeFieldInfoPtr_IncreasedHealthRegenOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_InstantiateAbilities;
      private static readonly System.IntPtr NativeFieldInfoPtr_Random;
      private static readonly System.IntPtr NativeFieldInfoPtr_VBloodEventList;
      private static readonly System.IntPtr NativeFieldInfoPtr_GlobalBlinkEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_CreateDropTableItems;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameServerSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_RelicsDroppedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackAssets;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_MinionComponentsToRemove;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurveCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellModCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_ConditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      [FieldOffset(0)]
      public EntityManager EntityManager;
      [FieldOffset(8)]
      public EntityCommandBuffer SpawnCommandBuffer;
      [FieldOffset(24)]
      public EntityCommandBuffer HealthCommandBuffer;
      [FieldOffset(40)]
      public PrefabLookupMap PrefabLookupMap;
      [FieldOffset(88)]
      public BuffUtility.BuffSpawner BuffSpawner;
      [FieldOffset(216)]
      public Entity NetworkedSequence;
      [FieldOffset(224)]
      public bool HitEffectsDisabled;
      [FieldOffset(228)]
      public int OutOfCombatStringHash;
      [FieldOffset(232)]
      public NativeHashMap<Entity, float> IncreasedHealthRegenOwners;
      [FieldOffset(248)]
      public EntityCommandBuffer EntityCommandBuffer;
      [FieldOffset(264)]
      public NativeList<HandleGameplayEventsBase.InstantiateAbilityForCharacter> InstantiateAbilities;
      [FieldOffset(280)]
      public Unity.Mathematics.Random Random;
      [FieldOffset(288)]
      public NativeList<VBloodConsumed> VBloodEventList;
      [FieldOffset(304)]
      public NativeList<GlobalBlinkEvent> GlobalBlinkEvents;
      [FieldOffset(320)]
      public CreateDropTableItemsJob CreateDropTableItems;
      [FieldOffset(624)]
      public ServerGameBalanceSettings GameServerSettings;
      [FieldOffset(2024)]
      public DynamicBuffer<RelicDropped> RelicsDroppedBuffer;
      [FieldOffset(2040)]
      public double ServerTime;
      [FieldOffset(2048)]
      public KnockbackAssetsSingleton KnockbackAssets;
      [FieldOffset(2056)]
      public TileMapCollisionMath.MapData MapData;
      [FieldOffset(2160)]
      public ComponentTypes MinionComponentsToRemove;
      [FieldOffset(2232)]
      public NativeList<GameplayEvent> GameplayEvents;
      [FieldOffset(2248)]
      public CurveCollection CurveCollection;
      [FieldOffset(2264)]
      public SpellModCollection<BlobAssetReference<SpellModBlob>> SpellModCollection;
      [FieldOffset(2280)]
      public ConditionChecker ConditionChecker;
      [FieldOffset(4480)]
      public CollisionWorld CollisionWorld;
      [FieldOffset(4824)]
      public TileWorld TileWorld;

      static GameplayEventInput()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, nameof (GameplayEventInput));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr);
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (EntityManager));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_SpawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (SpawnCommandBuffer));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_HealthCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (HealthCommandBuffer));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (PrefabLookupMap));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_BuffSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (BuffSpawner));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_NetworkedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (NetworkedSequence));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_HitEffectsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (HitEffectsDisabled));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_OutOfCombatStringHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (OutOfCombatStringHash));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_IncreasedHealthRegenOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (IncreasedHealthRegenOwners));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_EntityCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (EntityCommandBuffer));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_InstantiateAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (InstantiateAbilities));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (Random));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_VBloodEventList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (VBloodEventList));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_GlobalBlinkEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (GlobalBlinkEvents));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_CreateDropTableItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (CreateDropTableItems));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_GameServerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (GameServerSettings));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_RelicsDroppedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (RelicsDroppedBuffer));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (ServerTime));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_KnockbackAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (KnockbackAssets));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_MapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (MapData));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_MinionComponentsToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (MinionComponentsToRemove));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_GameplayEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (GameplayEvents));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (CurveCollection));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_SpellModCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (SpellModCollection));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_ConditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (ConditionChecker));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (CollisionWorld));
        HandleGameplayEventsBase.GameplayEventInput.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, nameof (TileWorld));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.GameplayEventInput>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/<>c__DisplayClass28_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass28_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_increasedHealthRegenOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_getGameplayEventListeners;
      private static readonly System.IntPtr NativeFieldInfoPtr_getEventIdMappings;
      private static readonly System.IntPtr NativeFieldInfoPtr_ignoredEventTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayDebugRecorder;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayEventScriptTriggers;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayEventInput;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_BloodBuffScript_Brute_HealthRegenBonus_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashMap<Entity, float> increasedHealthRegenOwners;
      [FieldOffset(24)]
      public NativeList<GameplayEvent> gameplayEvents;
      [FieldOffset(40)]
      public BufferFromEntity<GameplayEventListeners> getGameplayEventListeners;
      [FieldOffset(80)]
      public BufferFromEntity<GameplayEventIdMapping> getEventIdMappings;
      [FieldOffset(120)]
      public NativeList<int> ignoredEventTypes;
      [FieldOffset(136)]
      public GameplayDebugRecorder gameplayDebugRecorder;
      [FieldOffset(176)]
      public double serverTime;
      [FieldOffset(184)]
      public NativeList<GameplayEventScriptTrigger> gameplayEventScriptTriggers;
      [FieldOffset(200)]
      public HandleGameplayEventsBase.GameplayEventInput gameplayEventInput;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass28_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        [In] ref BloodBuffScript_Brute_HealthRegenBonus healthRegenerationIncrease,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref healthRegenerationIncrease;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass28_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_BloodBuffScript_Brute_HealthRegenBonus_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass28_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass28_0()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>c__DisplayClass28_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr);
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, nameof (entityManager));
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeFieldInfoPtr_increasedHealthRegenOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, nameof (increasedHealthRegenOwners));
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeFieldInfoPtr_gameplayEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, nameof (gameplayEvents));
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeFieldInfoPtr_getGameplayEventListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, nameof (getGameplayEventListeners));
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeFieldInfoPtr_getEventIdMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, nameof (getEventIdMappings));
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeFieldInfoPtr_ignoredEventTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, nameof (ignoredEventTypes));
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeFieldInfoPtr_gameplayDebugRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, nameof (gameplayDebugRecorder));
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, nameof (serverTime));
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeFieldInfoPtr_gameplayEventScriptTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, nameof (gameplayEventScriptTriggers));
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeFieldInfoPtr_gameplayEventInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, nameof (gameplayEventInput));
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, 100672108);
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_BloodBuffScript_Brute_HealthRegenBonus_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, 100672109);
        HandleGameplayEventsBase.__c__DisplayClass28_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, 100672110);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass28_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__28_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__28_3;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__28_1_Internal_Void_byref_MinionMaster_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__28_3_Internal_Void_Entity_byref_DynamicBuffer_1_HitTrigger_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleGameplayEventsBase.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__28_1(ref MinionMaster minionMaster)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref minionMaster;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c.NativeMethodInfoPtr__OnUpdate_b__28_1_Internal_Void_byref_MinionMaster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__28_3(Entity entity, ref DynamicBuffer<HitTrigger> hitTriggers)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitTriggers;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c.NativeMethodInfoPtr__OnUpdate_b__28_3_Internal_Void_Entity_byref_DynamicBuffer_1_HitTrigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.__c>.NativeClassPtr);
        HandleGameplayEventsBase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c>.NativeClassPtr, "<>9");
        HandleGameplayEventsBase.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c>.NativeClassPtr, "<>9__28_1");
        HandleGameplayEventsBase.__c.NativeFieldInfoPtr___9__28_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c>.NativeClassPtr, "<>9__28_3");
        HandleGameplayEventsBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c>.NativeClassPtr, 100672112);
        HandleGameplayEventsBase.__c.NativeMethodInfoPtr__OnUpdate_b__28_1_Internal_Void_byref_MinionMaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c>.NativeClassPtr, 100672113);
        HandleGameplayEventsBase.__c.NativeMethodInfoPtr__OnUpdate_b__28_3_Internal_Void_Entity_byref_DynamicBuffer_1_HitTrigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c>.NativeClassPtr, 100672114);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe HandleGameplayEventsBase.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (HandleGameplayEventsBase.__c) null : new HandleGameplayEventsBase.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe R<MinionMaster> __9__28_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c.NativeFieldInfoPtr___9__28_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (R<MinionMaster>) null : new R<MinionMaster>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c.NativeFieldInfoPtr___9__28_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe VR<Entity, DynamicBuffer<HitTrigger>> __9__28_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c.NativeFieldInfoPtr___9__28_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VR<Entity, DynamicBuffer<HitTrigger>>) null : new VR<Entity, DynamicBuffer<HitTrigger>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c.NativeFieldInfoPtr___9__28_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_increasedHealthRegenOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_Brute_HealthRegenBonus_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_byref___c__DisplayClass28_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashMap<Entity, float> increasedHealthRegenOwners;
      [FieldOffset(24)]
      public HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443226, XrefRangeEnd = 1443232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref BloodBuffScript_Brute_HealthRegenBonus healthRegenerationIncrease,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref healthRegenerationIncrease;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_Brute_HealthRegenBonus_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 980573, RefRangeEnd = 980586, XrefRangeStart = 980573, XrefRangeEnd = 980586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HandleGameplayEventsBase.__c__DisplayClass28_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 980586, RefRangeEnd = 980599, XrefRangeStart = 980586, XrefRangeEnd = 980599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HandleGameplayEventsBase.__c__DisplayClass28_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443232, XrefRangeEnd = 1443234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443242, RefRangeEnd = 1443243, XrefRangeStart = 1443234, XrefRangeEnd = 1443242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443245, RefRangeEnd = 1443246, XrefRangeStart = 1443243, XrefRangeEnd = 1443245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HandleGameplayEventsBase componentSystem,
        ref HandleGameplayEventsBase.__c__DisplayClass28_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_byref___c__DisplayClass28_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443246, XrefRangeEnd = 1443250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443250, XrefRangeEnd = 1443256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_increasedHealthRegenOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (increasedHealthRegenOwners));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_Brute_HealthRegenBonus_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672115);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672116);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672117);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672118);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672119);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_byref___c__DisplayClass28_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672120);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672121);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672122);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_healthRegenerationIncrease;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<BloodBuffScript_Brute_HealthRegenBonus> forParameter_healthRegenerationIncrease;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1443143, RefRangeEnd = 1443144, XrefRangeStart = 1443137, XrefRangeEnd = 1443143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(HandleGameplayEventsBase componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1443150, RefRangeEnd = 1443151, XrefRangeStart = 1443144, XrefRangeEnd = 1443150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_healthRegenerationIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_healthRegenerationIncrease));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100672123);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100672124);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_healthRegenerationIncrease;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<BloodBuffScript_Brute_HealthRegenBonus>.Runtime runtime_healthRegenerationIncrease;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_healthRegenerationIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_healthRegenerationIncrease));
            HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000153A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000153A$PostfixBurstDelegate");
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672125);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672126);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672127);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672128);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000153A$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443151, XrefRangeEnd = 1443165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443165, XrefRangeEnd = 1443183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443183, XrefRangeEnd = 1443198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1443225, RefRangeEnd = 1443226, XrefRangeStart = 1443198, XrefRangeEnd = 1443225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000153A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672129);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672130);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672131);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672132);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672134);
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
            IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_MinionMaster_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(32)]
      public unsafe HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443339, RefRangeEnd = 1443340, XrefRangeStart = 1443339, XrefRangeEnd = 1443339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref MinionMaster minionMaster)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref minionMaster;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_MinionMaster_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443340, XrefRangeEnd = 1443342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443347, RefRangeEnd = 1443348, XrefRangeStart = 1443342, XrefRangeEnd = 1443347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443349, RefRangeEnd = 1443350, XrefRangeStart = 1443348, XrefRangeEnd = 1443349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(HandleGameplayEventsBase componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443350, XrefRangeEnd = 1443354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443354, XrefRangeEnd = 1443360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_MinionMaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100672135);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100672136);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100672137);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100672138);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100672139);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100672140);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_minionMaster;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<MinionMaster> forParameter_minionMaster;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1443259, RefRangeEnd = 1443260, XrefRangeStart = 1443256, XrefRangeEnd = 1443259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(HandleGameplayEventsBase componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1443263, RefRangeEnd = 1443264, XrefRangeStart = 1443260, XrefRangeEnd = 1443263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_minionMaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_minionMaster));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100672141);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100672142);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_minionMaster;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<MinionMaster>.Runtime runtime_minionMaster;

          static Runtimes()
          {
            Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_minionMaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_minionMaster));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001541$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00001541$PostfixBurstDelegate");
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672143);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672144);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672145);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672146);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001541$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443264, XrefRangeEnd = 1443278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443278, XrefRangeEnd = 1443296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443296, XrefRangeEnd = 1443311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1443338, RefRangeEnd = 1443339, XrefRangeStart = 1443311, XrefRangeEnd = 1443338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00001541$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672147);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672148);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672149);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672150);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672152);
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
            IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_getGameplayEventListeners;
      private static readonly System.IntPtr NativeFieldInfoPtr_getEventIdMappings;
      private static readonly System.IntPtr NativeFieldInfoPtr_ignoredEventTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayDebugRecorder;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayEventScriptTriggers;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayEventInput;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_byref___c__DisplayClass28_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeList<GameplayEvent> gameplayEvents;
      [FieldOffset(16)]
      public BufferFromEntity<GameplayEventListeners> getGameplayEventListeners;
      [FieldOffset(56)]
      public BufferFromEntity<GameplayEventIdMapping> getEventIdMappings;
      [FieldOffset(96)]
      public NativeList<int> ignoredEventTypes;
      [FieldOffset(112)]
      public GameplayDebugRecorder gameplayDebugRecorder;
      [FieldOffset(152)]
      public double serverTime;
      [FieldOffset(160)]
      public NativeList<GameplayEventScriptTrigger> gameplayEventScriptTriggers;
      [FieldOffset(176)]
      public HandleGameplayEventsBase.GameplayEventInput gameplayEventInput;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443435, XrefRangeEnd = 1443479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443482, RefRangeEnd = 1443483, XrefRangeStart = 1443479, XrefRangeEnd = 1443482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HandleGameplayEventsBase.__c__DisplayClass28_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443486, RefRangeEnd = 1443487, XrefRangeStart = 1443483, XrefRangeEnd = 1443486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HandleGameplayEventsBase.__c__DisplayClass28_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443488, RefRangeEnd = 1443489, XrefRangeStart = 1443487, XrefRangeEnd = 1443488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443490, RefRangeEnd = 1443491, XrefRangeStart = 1443489, XrefRangeEnd = 1443490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HandleGameplayEventsBase componentSystem,
        ref HandleGameplayEventsBase.__c__DisplayClass28_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_byref___c__DisplayClass28_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443491, XrefRangeEnd = 1443495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443586, RefRangeEnd = 1443587, XrefRangeStart = 1443495, XrefRangeEnd = 1443586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob2()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_gameplayEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (gameplayEvents));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_getGameplayEventListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (getGameplayEventListeners));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_getEventIdMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (getEventIdMappings));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_ignoredEventTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (ignoredEventTypes));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_gameplayDebugRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (gameplayDebugRecorder));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (serverTime));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_gameplayEventScriptTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (gameplayEventScriptTriggers));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_gameplayEventInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (gameplayEventInput));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100672153);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100672154);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass28_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100672155);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100672156);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_byref___c__DisplayClass28_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100672157);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100672158);
        HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100672159);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001549$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00001549$PostfixBurstDelegate");
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672160);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672161);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672162);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672163);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001549$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443360, XrefRangeEnd = 1443374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443374, XrefRangeEnd = 1443392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443392, XrefRangeEnd = 1443407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1443434, RefRangeEnd = 1443435, XrefRangeStart = 1443407, XrefRangeEnd = 1443434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00001549$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672164);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672165);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672166);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672167);
          HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672169);
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
            IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_RemoveOnHitTrigger")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RemoveOnHitTrigger
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_HitTrigger_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443672, XrefRangeEnd = 1443683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<HitTrigger> hitTriggers)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitTriggers;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_HitTrigger_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443683, XrefRangeEnd = 1443685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443691, RefRangeEnd = 1443692, XrefRangeStart = 1443685, XrefRangeEnd = 1443691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443693, RefRangeEnd = 1443694, XrefRangeStart = 1443692, XrefRangeEnd = 1443693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(HandleGameplayEventsBase componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443694, XrefRangeEnd = 1443698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443698, XrefRangeEnd = 1443704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemoveOnHitTrigger()
      {
        Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr, "<>c__DisplayClass_RemoveOnHitTrigger");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr);
        HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, nameof (_runtimes));
        HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_HitTrigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, 100672170);
        HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, 100672171);
        HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, 100672172);
        HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, 100672173);
        HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, 100672174);
        HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, 100672175);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hitTriggers;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<HitTrigger> forParameter_hitTriggers;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1443591, RefRangeEnd = 1443592, XrefRangeStart = 1443587, XrefRangeEnd = 1443591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(HandleGameplayEventsBase componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1443596, RefRangeEnd = 1443597, XrefRangeStart = 1443592, XrefRangeEnd = 1443596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hitTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hitTriggers));
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleGameplayEventsBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders>.NativeClassPtr, 100672176);
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders>.NativeClassPtr, 100672177);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hitTriggers;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<HitTrigger>.Runtime runtime_hitTriggers;

          static Runtimes()
          {
            Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hitTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hitTriggers));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_RemoveOnHitTrigger/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000154E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, "RunWithoutJobSystem_0000154E$PostfixBurstDelegate");
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672178);
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672179);
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672180);
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672181);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.HandleGameplayEventsBase/ProjectM.Gameplay.Systems.<>c__DisplayClass_RemoveOnHitTrigger/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000154E$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443597, XrefRangeEnd = 1443611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443611, XrefRangeEnd = 1443629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443629, XrefRangeEnd = 1443644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1443671, RefRangeEnd = 1443672, XrefRangeStart = 1443644, XrefRangeEnd = 1443671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger>.NativeClassPtr, "RunWithoutJobSystem_0000154E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672182);
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672183);
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672184);
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672185);
          HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672187);
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
            IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleGameplayEventsBase.__c__DisplayClass_RemoveOnHitTrigger.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_TryGetGameplayEventListener_Public_Static_Boolean_byref_EntityManager_byref_GameplayEvent_Int32_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HandleGameplayEventsBase.NativeMethodInfoPtr_TryGetGameplayEventListener_Public_Static_Boolean_byref_EntityManager_byref_GameplayEvent_Int32_byref_T_0, Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TrySetGameplayEventListener_Public_Static_Boolean_byref_EntityManager_byref_GameplayEvent_Int32_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HandleGameplayEventsBase.NativeMethodInfoPtr_TrySetGameplayEventListener_Public_Static_Boolean_byref_EntityManager_byref_GameplayEvent_Int32_T_0, Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ModifyArithmeticValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HandleGameplayEventsBase.NativeMethodInfoPtr_ModifyArithmeticValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0, Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ModifyPrefabGUIDValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HandleGameplayEventsBase.NativeMethodInfoPtr_ModifyPrefabGUIDValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0, Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ModifySequenceGUIDValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HandleGameplayEventsBase.NativeMethodInfoPtr_ModifySequenceGUIDValue_Private_Static_Void_byref_GameplayEventInput_GameplayEventTypeEnum_byref_GameplayEvent_byref_EntityOwner_Int32_byref_T_0, Il2CppClassPointerStore<HandleGameplayEventsBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
