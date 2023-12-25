// Decompiled with JetBrains decompiler
// Type: ProjectM.DebugEventsSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Shared;
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
namespace ProjectM
{
  public class DebugEventsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__Rand;
    private static readonly System.IntPtr NativeFieldInfoPtr__MovementSpeedModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ALL_FILTER;
    private static readonly System.IntPtr NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CompleteJournal_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CompleteJournal_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ResetCooldowns_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ResetCooldowns_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ResetCooldowns_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ResetCooldowns_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ResetCooldowns_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ResetCooldowns_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CrashEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnDebugEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnDebugEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnCharmeableDebugEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnCharmeableDebugEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GiveEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GiveEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GiveEvent_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateJewelEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateJewelEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GenerateJewelEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GenerateJewelEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GenerateLegendaryWeaponEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GenerateLegendaryWeaponEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GenerateJewelAtUnitLevelEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GenerateJewelAtUnitLevelEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CustomizationEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CustomizationEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RandomizeCustomizationEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RandomizeCustomizationEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RandomizeCustomizationEvent2_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RandomizeCustomizationEvent2_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ChangeHealthEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ChangeHealthEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ConsumeBloodEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ConsumeBloodEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ChangeBloodEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ChangeBloodEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ChangeVBloodEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ChangeVBloodEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_3;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_SyncedServerDebugSettings_4;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_SyncedServerDebugSettings_5;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_UnitTeam_6;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_7;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompleteAllAchievementsEvent_Private_Void_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompleteAllAchievements_Private_Void_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAllVBloods_Private_Void_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAllResearch_Private_Void_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnsureVBloodAbilitiesConverted_Private_Static_Void_SystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlockVBloodFeatures_Public_Static_Void_SystemBase_BuffSpawnerSystemData_FromCharacter_VBloodFeatureType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ControlUnit_Private_Void_FromCharacter_ControlDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RenameUser_Private_Void_FromCharacter_RenameUserDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetControlMoveSpeed_Private_Void_FromCharacter_SetControlMoveSpeedDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlockRegion_Private_Void_Entity_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RespawnAi_Private_Void_Entity_RespawnAiDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetServerLogs_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JumpToNextBloodMoon_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompleteJournal_Private_Void_EntityCommandBuffer_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetCooldowns_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OverrideVampireAttackPower_Private_Void_FromCharacter_OverrideVampireAttackPowerDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDebugSetting_Private_Void_Int32_byref_SetDebugSettingEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LatencyEvent_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CrashEvent_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrackVBloodDebugEvent_Private_Void_Int32_byref_TrackVBloodDebugEvent_EntityCommandBuffer_EntityCommandBuffer_byref_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnDebugEvent_Private_Entity_Int32_byref_SpawnDebugEvent_EntityCommandBuffer_byref_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnCharmeableDebugEvent_Private_Void_Int32_byref_SpawnCharmeableDebugEvent_EntityCommandBuffer_byref_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyDebugEvent_Private_Void_Int32_byref_DestroyDebugEvent_EntityCommandBuffer_byref_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GiveEvent_Private_Void_Int32_byref_GiveDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateJewelEvent_Private_Void_Int32_byref_CreateJewelDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateJewelEvent_Private_Void_Int32_byref_GenerateJewelDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateLegendaryWeaponEvent_Private_Void_Int32_byref_GenerateLegendaryWeaponDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateJewelAtUnitLevelEvent_Private_Void_Int32_byref_GenerateJewelAtUnitLevelDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddJewelItem_Private_Boolean_PrefabGUID_Int32_Entity_NativeHashMap_2_PrefabGUID_ItemData_byref_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupJewelEntity_Private_Void_Entity_Single_PrefabGUID_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CustomizationEvent_Private_Void_Int32_byref_CustomizationDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeCustomizationEvent_Private_Void_Int32_byref_RandomizeCustomizationDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeCustomizationEvent2_Private_Void_Int32_byref_RandomizeCustomization2DebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHealthEvent_Private_Void_Int32_byref_ChangeHealthDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeBloodEvent_Private_Void_Int32_byref_ConsumeBloodDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBloodEvent_Private_Void_Int32_byref_ChangeBloodDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeVBloodEvent_Private_Void_Int32_byref_ChangeVBloodDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastAbilityServerDebugEvent_Private_Void_Int32_byref_CastAbilityServerDebugEvent_byref_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetUserContentDebugEvent_Private_Void_Int32_byref_SetUserContentDebugEvent_byref_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMovementSpeed_Private_Void_Entity_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuff_Private_Void_FromCharacter_ApplyBuffDebugEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Boolean_NetworkId_byref_Entity_byref___c__DisplayClass16_0_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCompleteJournal_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForResetCooldowns_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForResetCooldowns_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForResetCooldowns_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawnDebugEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawnCharmeableDebugEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGiveEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateJewelEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGenerateJewelEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGenerateLegendaryWeaponEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGenerateJewelAtUnitLevelEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCustomizationEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRandomizeCustomizationEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRandomizeCustomizationEvent2_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForChangeHealthEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForConsumeBloodEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForChangeBloodEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForChangeVBloodEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_6;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_7;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_8;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_9;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389429, XrefRangeEnd = 1389450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugEventsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389450, XrefRangeEnd = 1389455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugEventsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389455, XrefRangeEnd = 1389891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugEventsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389891, XrefRangeEnd = 1389894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CompleteAllAchievementsEvent(FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_CompleteAllAchievementsEvent_Private_Void_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1389955, RefRangeEnd = 1389957, XrefRangeStart = 1389894, XrefRangeEnd = 1389955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CompleteAllAchievements(FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_CompleteAllAchievements_Private_Void_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1390015, RefRangeEnd = 1390017, XrefRangeStart = 1389957, XrefRangeEnd = 1390015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlockAllVBloods(FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_UnlockAllVBloods_Private_Void_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1390084, RefRangeEnd = 1390086, XrefRangeStart = 1390017, XrefRangeEnd = 1390084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlockAllResearch(FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_UnlockAllResearch_Private_Void_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void EnsureVBloodAbilitiesConverted(SystemBase system)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_EnsureVBloodAbilitiesConverted_Private_Static_Void_SystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1390298, RefRangeEnd = 1390301, XrefRangeStart = 1390086, XrefRangeEnd = 1390298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UnlockVBloodFeatures(
      SystemBase system,
      BuffUtility.BuffSpawnerSystemData buffSpawnerData,
      FromCharacter fromCharacter,
      DebugEventsSystem.VBloodFeatureType featureType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffSpawnerData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &featureType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_UnlockVBloodFeatures_Public_Static_Void_SystemBase_BuffSpawnerSystemData_FromCharacter_VBloodFeatureType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390334, RefRangeEnd = 1390335, XrefRangeStart = 1390301, XrefRangeEnd = 1390334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ControlUnit(FromCharacter fromCharacter, ControlDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_ControlUnit_Private_Void_FromCharacter_ControlDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390413, RefRangeEnd = 1390414, XrefRangeStart = 1390335, XrefRangeEnd = 1390413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RenameUser(FromCharacter fromCharacter, RenameUserDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_RenameUser_Private_Void_FromCharacter_RenameUserDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390469, RefRangeEnd = 1390470, XrefRangeStart = 1390414, XrefRangeEnd = 1390469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetControlMoveSpeed(
      FromCharacter fromCharacter,
      SetControlMoveSpeedDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_SetControlMoveSpeed_Private_Void_FromCharacter_SetControlMoveSpeedDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390498, RefRangeEnd = 1390499, XrefRangeStart = 1390470, XrefRangeEnd = 1390498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlockRegion(Entity userEntity, float3 position)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_UnlockRegion_Private_Void_Entity_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390509, RefRangeEnd = 1390510, XrefRangeStart = 1390499, XrefRangeEnd = 1390509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RespawnAi(Entity fromCharacter, RespawnAiDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_RespawnAi_Private_Void_Entity_RespawnAiDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390514, RefRangeEnd = 1390515, XrefRangeStart = 1390510, XrefRangeEnd = 1390514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetServerLogs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_ResetServerLogs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390557, RefRangeEnd = 1390558, XrefRangeStart = 1390515, XrefRangeEnd = 1390557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JumpToNextBloodMoon()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_JumpToNextBloodMoon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390571, RefRangeEnd = 1390572, XrefRangeStart = 1390558, XrefRangeEnd = 1390571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CompleteJournal(
      EntityCommandBuffer spawnCommandBuffer,
      FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_CompleteJournal_Private_Void_EntityCommandBuffer_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390611, RefRangeEnd = 1390612, XrefRangeStart = 1390572, XrefRangeEnd = 1390611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetCooldowns()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_ResetCooldowns_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390634, RefRangeEnd = 1390635, XrefRangeStart = 1390612, XrefRangeEnd = 1390634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OverrideVampireAttackPower(
      FromCharacter fromCharacter,
      OverrideVampireAttackPowerDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_OverrideVampireAttackPower_Private_Void_FromCharacter_OverrideVampireAttackPowerDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390646, RefRangeEnd = 1390647, XrefRangeStart = 1390635, XrefRangeEnd = 1390646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDebugSetting(int fromUserIndex, ref SetDebugSettingEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_SetDebugSetting_Private_Void_Int32_byref_SetDebugSettingEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390662, RefRangeEnd = 1390663, XrefRangeStart = 1390647, XrefRangeEnd = 1390662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LatencyEvent(int fromUserIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_LatencyEvent_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390678, RefRangeEnd = 1390679, XrefRangeStart = 1390663, XrefRangeEnd = 1390678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CrashEvent(int fromUserIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_CrashEvent_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390693, RefRangeEnd = 1390694, XrefRangeStart = 1390679, XrefRangeEnd = 1390693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TrackVBloodDebugEvent(
      int fromUserIndex,
      ref ProjectM.Network.TrackVBloodDebugEvent clientEvent,
      EntityCommandBuffer spawnCommandBuffer,
      EntityCommandBuffer destroyCommandBuffer,
      [In] ref FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_TrackVBloodDebugEvent_Private_Void_Int32_byref_TrackVBloodDebugEvent_EntityCommandBuffer_EntityCommandBuffer_byref_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1390791, RefRangeEnd = 1390793, XrefRangeStart = 1390694, XrefRangeEnd = 1390791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity SpawnDebugEvent(
      int fromUserIndex,
      ref ProjectM.Network.SpawnDebugEvent clientEvent,
      EntityCommandBuffer spawnCommandBuffer,
      [In] ref FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_SpawnDebugEvent_Private_Entity_Int32_byref_SpawnDebugEvent_EntityCommandBuffer_byref_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390821, RefRangeEnd = 1390822, XrefRangeStart = 1390793, XrefRangeEnd = 1390821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SpawnCharmeableDebugEvent(
      int fromUserIndex,
      ref ProjectM.Network.SpawnCharmeableDebugEvent clientEvent,
      EntityCommandBuffer spawnCommandBuffer,
      [In] ref FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_SpawnCharmeableDebugEvent_Private_Void_Int32_byref_SpawnCharmeableDebugEvent_EntityCommandBuffer_byref_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1390944, RefRangeEnd = 1390945, XrefRangeStart = 1390822, XrefRangeEnd = 1390944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyDebugEvent(
      int fromUserIndex,
      ref ProjectM.Network.DestroyDebugEvent clientEvent,
      EntityCommandBuffer spawnCommandBuffer,
      [In] ref FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_DestroyDebugEvent_Private_Void_Int32_byref_DestroyDebugEvent_EntityCommandBuffer_byref_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391021, RefRangeEnd = 1391022, XrefRangeStart = 1390945, XrefRangeEnd = 1391021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GiveEvent(int fromUserIndex, ref GiveDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_GiveEvent_Private_Void_Int32_byref_GiveDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391065, RefRangeEnd = 1391066, XrefRangeStart = 1391022, XrefRangeEnd = 1391065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateJewelEvent(int fromUserIndex, ref CreateJewelDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_CreateJewelEvent_Private_Void_Int32_byref_CreateJewelDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391094, RefRangeEnd = 1391095, XrefRangeStart = 1391066, XrefRangeEnd = 1391094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GenerateJewelEvent(
      int fromUserIndex,
      ref GenerateJewelDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_GenerateJewelEvent_Private_Void_Int32_byref_GenerateJewelDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391137, RefRangeEnd = 1391138, XrefRangeStart = 1391095, XrefRangeEnd = 1391137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GenerateLegendaryWeaponEvent(
      int fromUserIndex,
      ref GenerateLegendaryWeaponDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_GenerateLegendaryWeaponEvent_Private_Void_Int32_byref_GenerateLegendaryWeaponDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391166, RefRangeEnd = 1391167, XrefRangeStart = 1391138, XrefRangeEnd = 1391166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GenerateJewelAtUnitLevelEvent(
      int fromUserIndex,
      ref GenerateJewelAtUnitLevelDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_GenerateJewelAtUnitLevelEvent_Private_Void_Int32_byref_GenerateJewelAtUnitLevelDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391186, RefRangeEnd = 1391187, XrefRangeStart = 1391167, XrefRangeEnd = 1391186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryAddJewelItem(
      PrefabGUID abilityPrefabGuid,
      int jewelTier,
      Entity localCharacter,
      NativeHashMap<PrefabGUID, ItemData> itemLookup,
      out PrefabGUID jewelPrefab,
      out Entity jewelItemEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &abilityPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &jewelTier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelItemEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_TryAddJewelItem_Private_Boolean_PrefabGUID_Int32_Entity_NativeHashMap_2_PrefabGUID_ItemData_byref_PrefabGUID_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391187, XrefRangeEnd = 1391205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupJewelEntity(
      Entity jewelEntity,
      float power,
      PrefabGUID spellModGuid,
      PrefabGUID abilityPrefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &jewelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &power;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spellModGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityPrefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_SetupJewelEntity_Private_Void_Entity_Single_PrefabGUID_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391228, RefRangeEnd = 1391229, XrefRangeStart = 1391205, XrefRangeEnd = 1391228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CustomizationEvent(
      int fromUserIndex,
      ref CustomizationDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_CustomizationEvent_Private_Void_Int32_byref_CustomizationDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391248, RefRangeEnd = 1391249, XrefRangeStart = 1391229, XrefRangeEnd = 1391248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RandomizeCustomizationEvent(
      int fromUserIndex,
      ref RandomizeCustomizationDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_RandomizeCustomizationEvent_Private_Void_Int32_byref_RandomizeCustomizationDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391268, RefRangeEnd = 1391269, XrefRangeStart = 1391249, XrefRangeEnd = 1391268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RandomizeCustomizationEvent2(
      int fromUserIndex,
      ref RandomizeCustomization2DebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_RandomizeCustomizationEvent2_Private_Void_Int32_byref_RandomizeCustomization2DebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391279, RefRangeEnd = 1391280, XrefRangeStart = 1391269, XrefRangeEnd = 1391279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ChangeHealthEvent(int fromUserIndex, ref ChangeHealthDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_ChangeHealthEvent_Private_Void_Int32_byref_ChangeHealthDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391304, RefRangeEnd = 1391305, XrefRangeStart = 1391280, XrefRangeEnd = 1391304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConsumeBloodEvent(int fromUserIndex, ref ConsumeBloodDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_ConsumeBloodEvent_Private_Void_Int32_byref_ConsumeBloodDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391315, RefRangeEnd = 1391316, XrefRangeStart = 1391305, XrefRangeEnd = 1391315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ChangeBloodEvent(int fromUserIndex, ref ChangeBloodDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_ChangeBloodEvent_Private_Void_Int32_byref_ChangeBloodDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391334, RefRangeEnd = 1391335, XrefRangeStart = 1391316, XrefRangeEnd = 1391334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ChangeVBloodEvent(int fromUserIndex, ref ChangeVBloodDebugEvent clientEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_ChangeVBloodEvent_Private_Void_Int32_byref_ChangeVBloodDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391409, RefRangeEnd = 1391410, XrefRangeStart = 1391335, XrefRangeEnd = 1391409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CastAbilityServerDebugEvent(
      int fromUserIndex,
      ref ProjectM.Network.CastAbilityServerDebugEvent clientEvent,
      [In] ref FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_CastAbilityServerDebugEvent_Private_Void_Int32_byref_CastAbilityServerDebugEvent_byref_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391417, RefRangeEnd = 1391418, XrefRangeStart = 1391410, XrefRangeEnd = 1391417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetUserContentDebugEvent(
      int fromUserIndex,
      ref ProjectM.Network.SetUserContentDebugEvent clientEvent,
      [In] ref FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &fromUserIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_SetUserContentDebugEvent_Private_Void_Int32_byref_SetUserContentDebugEvent_byref_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391445, RefRangeEnd = 1391446, XrefRangeStart = 1391418, XrefRangeEnd = 1391445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetMovementSpeed(Entity entity, FromCharacter from)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_SetMovementSpeed_Private_Void_Entity_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1391458, RefRangeEnd = 1391459, XrefRangeStart = 1391446, XrefRangeEnd = 1391458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyBuff(FromCharacter from, ApplyBuffDebugEvent applyBuffDebugEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &applyBuffDebugEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_ApplyBuff_Private_Void_FromCharacter_ApplyBuffDebugEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugEventsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391459, XrefRangeEnd = 1391466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Method_Private_Boolean_NetworkId_byref_Entity_byref___c__DisplayClass16_0_PDM_0(
      NetworkId entity,
      out Entity result,
      ref DebugEventsSystem.__c__DisplayClass16_0 _param3)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param3);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Private_Boolean_NetworkId_byref_Entity_byref___c__DisplayClass16_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391466, XrefRangeEnd = 1392084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugEventsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392084, XrefRangeEnd = 1392100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392100, XrefRangeEnd = 1392116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392116, XrefRangeEnd = 1392132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392132, XrefRangeEnd = 1392151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCompleteJournal_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCompleteJournal_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392151, XrefRangeEnd = 1392167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForResetCooldowns_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForResetCooldowns_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392167, XrefRangeEnd = 1392186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForResetCooldowns_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForResetCooldowns_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392186, XrefRangeEnd = 1392202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForResetCooldowns_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForResetCooldowns_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392202, XrefRangeEnd = 1392221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawnDebugEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnDebugEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392221, XrefRangeEnd = 1392240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawnCharmeableDebugEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnCharmeableDebugEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392240, XrefRangeEnd = 1392259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGiveEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForGiveEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392259, XrefRangeEnd = 1392278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateJewelEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateJewelEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392278, XrefRangeEnd = 1392297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGenerateJewelEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForGenerateJewelEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392297, XrefRangeEnd = 1392316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGenerateLegendaryWeaponEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForGenerateLegendaryWeaponEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392316, XrefRangeEnd = 1392335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGenerateJewelAtUnitLevelEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForGenerateJewelAtUnitLevelEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392335, XrefRangeEnd = 1392354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCustomizationEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCustomizationEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392354, XrefRangeEnd = 1392373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRandomizeCustomizationEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForRandomizeCustomizationEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392373, XrefRangeEnd = 1392392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRandomizeCustomizationEvent2_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForRandomizeCustomizationEvent2_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392392, XrefRangeEnd = 1392411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForChangeHealthEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForChangeHealthEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392411, XrefRangeEnd = 1392430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForConsumeBloodEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForConsumeBloodEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392430, XrefRangeEnd = 1392449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForChangeBloodEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForChangeBloodEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392449, XrefRangeEnd = 1392468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForChangeVBloodEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForChangeVBloodEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1392472, RefRangeEnd = 1392473, XrefRangeStart = 1392468, XrefRangeEnd = 1392472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1392477, RefRangeEnd = 1392478, XrefRangeStart = 1392473, XrefRangeEnd = 1392477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1392482, RefRangeEnd = 1392483, XrefRangeStart = 1392478, XrefRangeEnd = 1392482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1392487, RefRangeEnd = 1392488, XrefRangeStart = 1392483, XrefRangeEnd = 1392487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1392492, RefRangeEnd = 1392493, XrefRangeStart = 1392488, XrefRangeEnd = 1392492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1392497, RefRangeEnd = 1392498, XrefRangeStart = 1392493, XrefRangeEnd = 1392497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1392502, RefRangeEnd = 1392503, XrefRangeStart = 1392498, XrefRangeEnd = 1392502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1392507, RefRangeEnd = 1392508, XrefRangeStart = 1392503, XrefRangeEnd = 1392507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_7()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1392512, RefRangeEnd = 1392513, XrefRangeStart = 1392508, XrefRangeEnd = 1392512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_8()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_8, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1392517, RefRangeEnd = 1392518, XrefRangeStart = 1392513, XrefRangeEnd = 1392517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_9()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_9, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugEventsSystem()
    {
      Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (DebugEventsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr);
      DebugEventsSystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (_WorldFrame));
      DebugEventsSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (_Query));
      DebugEventsSystem.NativeFieldInfoPtr__Rand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (_Rand));
      DebugEventsSystem.NativeFieldInfoPtr__MovementSpeedModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (_MovementSpeedModificationId));
      DebugEventsSystem.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      DebugEventsSystem.NativeFieldInfoPtr_ALL_FILTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (ALL_FILTER));
      DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>JumpToNextBloodMoon_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>JumpToNextBloodMoon_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>JumpToNextBloodMoon_LambdaJob1_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>JumpToNextBloodMoon_LambdaJob1_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>JumpToNextBloodMoon_LambdaJob2_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>JumpToNextBloodMoon_LambdaJob2_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___CompleteJournal_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>CompleteJournal_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___CompleteJournal_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>CompleteJournal_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ResetCooldowns_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ResetCooldowns_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ResetCooldowns_LambdaJob1_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ResetCooldowns_LambdaJob1_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ResetCooldowns_LambdaJob2_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ResetCooldowns_LambdaJob2_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___CrashEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>CrashEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___SpawnDebugEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>SpawnDebugEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___SpawnDebugEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>SpawnDebugEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___SpawnCharmeableDebugEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>SpawnCharmeableDebugEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___SpawnCharmeableDebugEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>SpawnCharmeableDebugEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___GiveEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>GiveEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___GiveEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>GiveEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___GiveEvent_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>GiveEvent_LambdaJob1_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___CreateJewelEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>CreateJewelEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___CreateJewelEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>CreateJewelEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>GenerateJewelEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>GenerateJewelEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___GenerateLegendaryWeaponEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>GenerateLegendaryWeaponEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___GenerateLegendaryWeaponEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>GenerateLegendaryWeaponEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelAtUnitLevelEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>GenerateJewelAtUnitLevelEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelAtUnitLevelEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>GenerateJewelAtUnitLevelEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___CustomizationEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>CustomizationEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___CustomizationEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>CustomizationEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>RandomizeCustomizationEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>RandomizeCustomizationEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent2_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>RandomizeCustomizationEvent2_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent2_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>RandomizeCustomizationEvent2_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___ChangeHealthEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ChangeHealthEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___ChangeHealthEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ChangeHealthEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___ConsumeBloodEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ConsumeBloodEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___ConsumeBloodEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ConsumeBloodEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___ChangeBloodEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ChangeBloodEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___ChangeBloodEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ChangeBloodEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr___ChangeVBloodEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ChangeVBloodEvent_LambdaJob0_entityQuery");
      DebugEventsSystem.NativeFieldInfoPtr___ChangeVBloodEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>ChangeVBloodEvent_LambdaJob0_profilerMarker");
      DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_DayNightCycle_3));
      DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_SyncedServerDebugSettings_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_SyncedServerDebugSettings_4));
      DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_SyncedServerDebugSettings_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_SyncedServerDebugSettings_5));
      DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_UnitTeam_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_UnitTeam_6));
      DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_7));
      DebugEventsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666187);
      DebugEventsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666188);
      DebugEventsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666189);
      DebugEventsSystem.NativeMethodInfoPtr_CompleteAllAchievementsEvent_Private_Void_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666190);
      DebugEventsSystem.NativeMethodInfoPtr_CompleteAllAchievements_Private_Void_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666191);
      DebugEventsSystem.NativeMethodInfoPtr_UnlockAllVBloods_Private_Void_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666192);
      DebugEventsSystem.NativeMethodInfoPtr_UnlockAllResearch_Private_Void_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666193);
      DebugEventsSystem.NativeMethodInfoPtr_EnsureVBloodAbilitiesConverted_Private_Static_Void_SystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666194);
      DebugEventsSystem.NativeMethodInfoPtr_UnlockVBloodFeatures_Public_Static_Void_SystemBase_BuffSpawnerSystemData_FromCharacter_VBloodFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666195);
      DebugEventsSystem.NativeMethodInfoPtr_ControlUnit_Private_Void_FromCharacter_ControlDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666196);
      DebugEventsSystem.NativeMethodInfoPtr_RenameUser_Private_Void_FromCharacter_RenameUserDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666197);
      DebugEventsSystem.NativeMethodInfoPtr_SetControlMoveSpeed_Private_Void_FromCharacter_SetControlMoveSpeedDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666198);
      DebugEventsSystem.NativeMethodInfoPtr_UnlockRegion_Private_Void_Entity_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666199);
      DebugEventsSystem.NativeMethodInfoPtr_RespawnAi_Private_Void_Entity_RespawnAiDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666200);
      DebugEventsSystem.NativeMethodInfoPtr_ResetServerLogs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666201);
      DebugEventsSystem.NativeMethodInfoPtr_JumpToNextBloodMoon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666202);
      DebugEventsSystem.NativeMethodInfoPtr_CompleteJournal_Private_Void_EntityCommandBuffer_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666203);
      DebugEventsSystem.NativeMethodInfoPtr_ResetCooldowns_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666204);
      DebugEventsSystem.NativeMethodInfoPtr_OverrideVampireAttackPower_Private_Void_FromCharacter_OverrideVampireAttackPowerDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666205);
      DebugEventsSystem.NativeMethodInfoPtr_SetDebugSetting_Private_Void_Int32_byref_SetDebugSettingEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666206);
      DebugEventsSystem.NativeMethodInfoPtr_LatencyEvent_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666207);
      DebugEventsSystem.NativeMethodInfoPtr_CrashEvent_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666208);
      DebugEventsSystem.NativeMethodInfoPtr_TrackVBloodDebugEvent_Private_Void_Int32_byref_TrackVBloodDebugEvent_EntityCommandBuffer_EntityCommandBuffer_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666209);
      DebugEventsSystem.NativeMethodInfoPtr_SpawnDebugEvent_Private_Entity_Int32_byref_SpawnDebugEvent_EntityCommandBuffer_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666210);
      DebugEventsSystem.NativeMethodInfoPtr_SpawnCharmeableDebugEvent_Private_Void_Int32_byref_SpawnCharmeableDebugEvent_EntityCommandBuffer_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666211);
      DebugEventsSystem.NativeMethodInfoPtr_DestroyDebugEvent_Private_Void_Int32_byref_DestroyDebugEvent_EntityCommandBuffer_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666212);
      DebugEventsSystem.NativeMethodInfoPtr_GiveEvent_Private_Void_Int32_byref_GiveDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666213);
      DebugEventsSystem.NativeMethodInfoPtr_CreateJewelEvent_Private_Void_Int32_byref_CreateJewelDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666214);
      DebugEventsSystem.NativeMethodInfoPtr_GenerateJewelEvent_Private_Void_Int32_byref_GenerateJewelDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666215);
      DebugEventsSystem.NativeMethodInfoPtr_GenerateLegendaryWeaponEvent_Private_Void_Int32_byref_GenerateLegendaryWeaponDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666216);
      DebugEventsSystem.NativeMethodInfoPtr_GenerateJewelAtUnitLevelEvent_Private_Void_Int32_byref_GenerateJewelAtUnitLevelDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666217);
      DebugEventsSystem.NativeMethodInfoPtr_TryAddJewelItem_Private_Boolean_PrefabGUID_Int32_Entity_NativeHashMap_2_PrefabGUID_ItemData_byref_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666218);
      DebugEventsSystem.NativeMethodInfoPtr_SetupJewelEntity_Private_Void_Entity_Single_PrefabGUID_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666219);
      DebugEventsSystem.NativeMethodInfoPtr_CustomizationEvent_Private_Void_Int32_byref_CustomizationDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666220);
      DebugEventsSystem.NativeMethodInfoPtr_RandomizeCustomizationEvent_Private_Void_Int32_byref_RandomizeCustomizationDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666221);
      DebugEventsSystem.NativeMethodInfoPtr_RandomizeCustomizationEvent2_Private_Void_Int32_byref_RandomizeCustomization2DebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666222);
      DebugEventsSystem.NativeMethodInfoPtr_ChangeHealthEvent_Private_Void_Int32_byref_ChangeHealthDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666223);
      DebugEventsSystem.NativeMethodInfoPtr_ConsumeBloodEvent_Private_Void_Int32_byref_ConsumeBloodDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666224);
      DebugEventsSystem.NativeMethodInfoPtr_ChangeBloodEvent_Private_Void_Int32_byref_ChangeBloodDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666225);
      DebugEventsSystem.NativeMethodInfoPtr_ChangeVBloodEvent_Private_Void_Int32_byref_ChangeVBloodDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666226);
      DebugEventsSystem.NativeMethodInfoPtr_CastAbilityServerDebugEvent_Private_Void_Int32_byref_CastAbilityServerDebugEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666227);
      DebugEventsSystem.NativeMethodInfoPtr_SetUserContentDebugEvent_Private_Void_Int32_byref_SetUserContentDebugEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666228);
      DebugEventsSystem.NativeMethodInfoPtr_SetMovementSpeed_Private_Void_Entity_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666229);
      DebugEventsSystem.NativeMethodInfoPtr_ApplyBuff_Private_Void_FromCharacter_ApplyBuffDebugEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666230);
      DebugEventsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666231);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Private_Boolean_NetworkId_byref_Entity_byref___c__DisplayClass16_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666233);
      DebugEventsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666234);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666235);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666236);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForJumpToNextBloodMoon_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666237);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCompleteJournal_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666238);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForResetCooldowns_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666239);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForResetCooldowns_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666240);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForResetCooldowns_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666241);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnDebugEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666242);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnCharmeableDebugEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666243);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForGiveEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666244);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateJewelEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666245);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForGenerateJewelEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666246);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForGenerateLegendaryWeaponEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666247);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForGenerateJewelAtUnitLevelEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666248);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCustomizationEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666249);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForRandomizeCustomizationEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666250);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForRandomizeCustomizationEvent2_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666251);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForChangeHealthEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666252);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForConsumeBloodEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666253);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForChangeBloodEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666254);
      DebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForChangeVBloodEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666255);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666256);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666257);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666258);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666259);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666260);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666261);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666262);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666263);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_8 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666264);
      DebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_9 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, 100666265);
    }

    public DebugEventsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe Unity.Mathematics.Random _Rand
    {
      get
      {
        return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__Rand));
      }
      [param: In] set
      {
        *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__Rand)) = value;
      }
    }

    public unsafe ModificationId _MovementSpeedModificationId
    {
      get
      {
        return *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__MovementSpeedModificationId));
      }
      [param: In] set
      {
        *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__MovementSpeedModificationId)) = value;
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe CollisionFilter ALL_FILTER
    {
      get
      {
        CollisionFilter allFilter;
        IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.NativeFieldInfoPtr_ALL_FILTER, (void*) &allFilter);
        return allFilter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.NativeFieldInfoPtr_ALL_FILTER, (void*) &value);
      }
    }

    public unsafe EntityQuery __JumpToNextBloodMoon_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __JumpToNextBloodMoon_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __JumpToNextBloodMoon_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __JumpToNextBloodMoon_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __JumpToNextBloodMoon_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __JumpToNextBloodMoon_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___JumpToNextBloodMoon_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __CompleteJournal_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CompleteJournal_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CompleteJournal_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CompleteJournal_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CompleteJournal_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CompleteJournal_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ResetCooldowns_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ResetCooldowns_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ResetCooldowns_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ResetCooldowns_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ResetCooldowns_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ResetCooldowns_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ResetCooldowns_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __CrashEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CrashEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CrashEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SpawnDebugEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___SpawnDebugEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___SpawnDebugEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnDebugEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___SpawnDebugEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___SpawnDebugEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SpawnCharmeableDebugEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___SpawnCharmeableDebugEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___SpawnCharmeableDebugEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnCharmeableDebugEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___SpawnCharmeableDebugEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___SpawnCharmeableDebugEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GiveEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GiveEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GiveEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GiveEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GiveEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GiveEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __GiveEvent_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GiveEvent_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GiveEvent_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __CreateJewelEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CreateJewelEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CreateJewelEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateJewelEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CreateJewelEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CreateJewelEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GenerateJewelEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GenerateJewelEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GenerateLegendaryWeaponEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateLegendaryWeaponEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateLegendaryWeaponEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GenerateLegendaryWeaponEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateLegendaryWeaponEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateLegendaryWeaponEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GenerateJewelAtUnitLevelEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelAtUnitLevelEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelAtUnitLevelEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GenerateJewelAtUnitLevelEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelAtUnitLevelEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___GenerateJewelAtUnitLevelEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __CustomizationEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CustomizationEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CustomizationEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CustomizationEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CustomizationEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___CustomizationEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RandomizeCustomizationEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RandomizeCustomizationEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RandomizeCustomizationEvent2_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent2_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent2_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RandomizeCustomizationEvent2_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent2_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___RandomizeCustomizationEvent2_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ChangeHealthEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeHealthEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeHealthEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ChangeHealthEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeHealthEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeHealthEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ConsumeBloodEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ConsumeBloodEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ConsumeBloodEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ConsumeBloodEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ConsumeBloodEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ConsumeBloodEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ChangeBloodEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeBloodEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeBloodEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ChangeBloodEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeBloodEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeBloodEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ChangeVBloodEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeVBloodEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeVBloodEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ChangeVBloodEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeVBloodEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr___ChangeVBloodEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_DayNightCycle_3
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_3));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_3)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_SyncedServerDebugSettings_4
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_SyncedServerDebugSettings_4));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_SyncedServerDebugSettings_4)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_SyncedServerDebugSettings_5
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_SyncedServerDebugSettings_5));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_SyncedServerDebugSettings_5)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_UnitTeam_6
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_UnitTeam_6));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_UnitTeam_6)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_7
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_7));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_7)) = value;
      }
    }

    public enum VBloodFeatureType
    {
      Ability,
      Passive,
      Shapeshift,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Debug_ApplyBuffDelayed
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Creator;
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
      [FieldOffset(0)]
      public Entity Creator;
      [FieldOffset(8)]
      public Entity Prefab;

      static Debug_ApplyBuffDelayed()
      {
        Il2CppClassPointerStore<DebugEventsSystem.Debug_ApplyBuffDelayed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, nameof (Debug_ApplyBuffDelayed));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.Debug_ApplyBuffDelayed>.NativeClassPtr);
        DebugEventsSystem.Debug_ApplyBuffDelayed.NativeFieldInfoPtr_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.Debug_ApplyBuffDelayed>.NativeClassPtr, nameof (Creator));
        DebugEventsSystem.Debug_ApplyBuffDelayed.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.Debug_ApplyBuffDelayed>.NativeClassPtr, nameof (Prefab));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.Debug_ApplyBuffDelayed>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass16_0")]
    public sealed class __c__DisplayClass16_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

      static __c__DisplayClass16_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass16_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass16_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_networkIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (networkIdMap));
        DebugEventsSystem.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
      }

      public __c__DisplayClass16_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass16_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass16_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass16_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_networkIdMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_networkIdMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass21_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass21_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_addTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_newServerTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__JumpToNextBloodMoon_b__0_Internal_Void_byref_DayNightCycle_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__JumpToNextBloodMoon_b__1_Internal_Void_byref_ServerTime_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__JumpToNextBloodMoon_b__2_Internal_Void_byref_DayNightCycle_0;
      [FieldOffset(0)]
      public float addTime;
      [FieldOffset(8)]
      public double newServerTime;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass21_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _JumpToNextBloodMoon_b__0(ref DayNightCycle cycle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref cycle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__JumpToNextBloodMoon_b__0_Internal_Void_byref_DayNightCycle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _JumpToNextBloodMoon_b__1(ref ServerTime serverTime)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref serverTime;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__JumpToNextBloodMoon_b__1_Internal_Void_byref_ServerTime_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _JumpToNextBloodMoon_b__2(ref DayNightCycle cycle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref cycle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__JumpToNextBloodMoon_b__2_Internal_Void_byref_DayNightCycle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass21_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass21_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass21_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_addTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass21_0>.NativeClassPtr, nameof (addTime));
        DebugEventsSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_newServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass21_0>.NativeClassPtr, nameof (newServerTime));
        DebugEventsSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass21_0>.NativeClassPtr, 100666266);
        DebugEventsSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__JumpToNextBloodMoon_b__0_Internal_Void_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass21_0>.NativeClassPtr, 100666267);
        DebugEventsSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__JumpToNextBloodMoon_b__1_Internal_Void_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass21_0>.NativeClassPtr, 100666268);
        DebugEventsSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__JumpToNextBloodMoon_b__2_Internal_Void_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass21_0>.NativeClassPtr, 100666269);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass21_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass22_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass22_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_fromCharacter;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CompleteJournal_b__0_Internal_Void_byref_PrefabGUID_0;
      [FieldOffset(0)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(16)]
      public FromCharacter fromCharacter;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass22_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _CompleteJournal_b__0([In] ref PrefabGUID prefabGUID)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__CompleteJournal_b__0_Internal_Void_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass22_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass22_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass22_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        DebugEventsSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (fromCharacter));
        DebugEventsSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass22_0>.NativeClassPtr, 100666270);
        DebugEventsSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__CompleteJournal_b__0_Internal_Void_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass22_0>.NativeClassPtr, 100666271);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass22_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__23_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__23_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__23_2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ResetCooldowns_b__23_0_Internal_Void_byref_AbilityCooldownState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ResetCooldowns_b__23_1_Internal_Void_byref_AbilityChargesState_byref_AbilityChargesData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ResetCooldowns_b__23_2_Internal_Void_byref_Energy_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ResetCooldowns_b__23_0(ref AbilityCooldownState cooldown)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref cooldown;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c.NativeMethodInfoPtr__ResetCooldowns_b__23_0_Internal_Void_byref_AbilityCooldownState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ResetCooldowns_b__23_1(
        ref AbilityChargesState chargesState,
        [In] ref AbilityChargesData chargesData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chargesState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref chargesData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c.NativeMethodInfoPtr__ResetCooldowns_b__23_1_Internal_Void_byref_AbilityChargesState_byref_AbilityChargesData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ResetCooldowns_b__23_2(ref Energy energy)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref energy;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c.NativeMethodInfoPtr__ResetCooldowns_b__23_2_Internal_Void_byref_Energy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr);
        DebugEventsSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr, "<>9");
        DebugEventsSystem.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr, "<>9__23_0");
        DebugEventsSystem.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr, "<>9__23_1");
        DebugEventsSystem.__c.NativeFieldInfoPtr___9__23_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr, "<>9__23_2");
        DebugEventsSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr, 100666273);
        DebugEventsSystem.__c.NativeMethodInfoPtr__ResetCooldowns_b__23_0_Internal_Void_byref_AbilityCooldownState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr, 100666274);
        DebugEventsSystem.__c.NativeMethodInfoPtr__ResetCooldowns_b__23_1_Internal_Void_byref_AbilityChargesState_byref_AbilityChargesData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr, 100666275);
        DebugEventsSystem.__c.NativeMethodInfoPtr__ResetCooldowns_b__23_2_Internal_Void_byref_Energy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c>.NativeClassPtr, 100666276);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe DebugEventsSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem.__c) null : new DebugEventsSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe R<AbilityCooldownState> __9__23_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c.NativeFieldInfoPtr___9__23_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (R<AbilityCooldownState>) null : new R<AbilityCooldownState>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c.NativeFieldInfoPtr___9__23_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe RI<AbilityChargesState, AbilityChargesData> __9__23_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c.NativeFieldInfoPtr___9__23_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RI<AbilityChargesState, AbilityChargesData>) null : new RI<AbilityChargesState, AbilityChargesData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c.NativeFieldInfoPtr___9__23_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe R<Energy> __9__23_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c.NativeFieldInfoPtr___9__23_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (R<Energy>) null : new R<Energy>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c.NativeFieldInfoPtr___9__23_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass27_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass27_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CrashEvent_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public EntityManager entityManager;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass27_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _CrashEvent_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass27_0.NativeMethodInfoPtr__CrashEvent_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass27_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass27_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass27_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (entityManager));
        DebugEventsSystem.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass27_0>.NativeClassPtr, 100666277);
        DebugEventsSystem.__c__DisplayClass27_0.NativeMethodInfoPtr__CrashEvent_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass27_0>.NativeClassPtr, 100666278);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass27_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass29_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass29_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_teamEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SpawnDebugEvent_b__0_Internal_Void_Entity_byref_User_byref_TeamReference_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity teamEntity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass29_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SpawnDebugEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref TeamReference teamReference)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref teamReference;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__SpawnDebugEvent_b__0_Internal_Void_Entity_byref_User_byref_TeamReference_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass29_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass29_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass29_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_teamEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (teamEntity));
        DebugEventsSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass29_0>.NativeClassPtr, 100666279);
        DebugEventsSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__SpawnDebugEvent_b__0_Internal_Void_Entity_byref_User_byref_TeamReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass29_0>.NativeClassPtr, 100666280);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass29_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass31_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass31_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_characterEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SpawnCharmeableDebugEvent_b__0_Internal_Void_byref_User_byref_Controller_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity characterEntity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass31_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SpawnCharmeableDebugEvent_b__0([In] ref User user, [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__SpawnCharmeableDebugEvent_b__0_Internal_Void_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass31_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass31_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass31_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass31_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_characterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass31_0>.NativeClassPtr, nameof (characterEntity));
        DebugEventsSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass31_0>.NativeClassPtr, 100666281);
        DebugEventsSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__SpawnCharmeableDebugEvent_b__0_Internal_Void_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass31_0>.NativeClassPtr, 100666282);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass31_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass34_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass34_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_controllerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_userContentFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropTableDataHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_recipeHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuid;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GiveEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity controllerEntity;
      [FieldOffset(12)]
      public UserContentFlags userContentFlags;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public NativeHashMap<PrefabGUID, DropTableData> dropTableDataHashLookupMap;
      [FieldOffset(40)]
      public NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap;
      [FieldOffset(56)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(104)]
      public PrefabGUID prefabGuid;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass34_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GiveEvent_b__0(Entity entity, [In] ref User user, [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass34_0.NativeMethodInfoPtr__GiveEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass34_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass34_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_controllerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, nameof (controllerEntity));
        DebugEventsSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_userContentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, nameof (userContentFlags));
        DebugEventsSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, nameof (entityManager));
        DebugEventsSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_dropTableDataHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, nameof (dropTableDataHashLookupMap));
        DebugEventsSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_recipeHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, nameof (recipeHashLookupMap));
        DebugEventsSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, nameof (prefabLookupMap));
        DebugEventsSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, nameof (prefabGuid));
        DebugEventsSystem.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, 100666283);
        DebugEventsSystem.__c__DisplayClass34_0.NativeMethodInfoPtr__GiveEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, 100666284);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass34_1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass34_1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_legendaryWeapons;
      private static readonly System.IntPtr NativeFieldInfoPtr_giveable;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass34_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GiveEvent_b__1_Internal_Void_0;
      [FieldOffset(0)]
      public NativeArray<PrefabGUID> legendaryWeapons;
      [FieldOffset(16)]
      public bool giveable;
      [FieldOffset(24)]
      public DebugEventsSystem.__c__DisplayClass34_0 field_Public___c__DisplayClass34_0_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass34_1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass34_1.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GiveEvent_b__1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass34_1.NativeMethodInfoPtr__GiveEvent_b__1_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass34_1()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass34_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_1>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass34_1.NativeFieldInfoPtr_legendaryWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_1>.NativeClassPtr, nameof (legendaryWeapons));
        DebugEventsSystem.__c__DisplayClass34_1.NativeFieldInfoPtr_giveable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_1>.NativeClassPtr, nameof (giveable));
        DebugEventsSystem.__c__DisplayClass34_1.NativeFieldInfoPtr_field_Public___c__DisplayClass34_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_1>.NativeClassPtr, "CS$<>8__locals1");
        DebugEventsSystem.__c__DisplayClass34_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_1>.NativeClassPtr, 100666285);
        DebugEventsSystem.__c__DisplayClass34_1.NativeMethodInfoPtr__GiveEvent_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_1>.NativeClassPtr, 100666286);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass34_1>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass35_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass35_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_controlledEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CreateJewelEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity controlledEntity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass35_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _CreateJewelEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass35_0.NativeMethodInfoPtr__CreateJewelEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass35_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass35_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass35_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass35_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_controlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass35_0>.NativeClassPtr, nameof (controlledEntity));
        DebugEventsSystem.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass35_0>.NativeClassPtr, 100666287);
        DebugEventsSystem.__c__DisplayClass35_0.NativeMethodInfoPtr__CreateJewelEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass35_0>.NativeClassPtr, 100666288);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass35_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass36_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass36_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_controlledEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GenerateJewelEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity controlledEntity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass36_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GenerateJewelEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass36_0.NativeMethodInfoPtr__GenerateJewelEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass36_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass36_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass36_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass36_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass36_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass36_0.NativeFieldInfoPtr_controlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass36_0>.NativeClassPtr, nameof (controlledEntity));
        DebugEventsSystem.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass36_0>.NativeClassPtr, 100666289);
        DebugEventsSystem.__c__DisplayClass36_0.NativeMethodInfoPtr__GenerateJewelEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass36_0>.NativeClassPtr, 100666290);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass36_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass37_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass37_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_controlledEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GenerateLegendaryWeaponEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity controlledEntity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass37_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GenerateLegendaryWeaponEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GenerateLegendaryWeaponEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass37_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass37_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass37_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass37_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass37_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass37_0.NativeFieldInfoPtr_controlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass37_0>.NativeClassPtr, nameof (controlledEntity));
        DebugEventsSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass37_0>.NativeClassPtr, 100666291);
        DebugEventsSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GenerateLegendaryWeaponEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass37_0>.NativeClassPtr, 100666292);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass37_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass38_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass38_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_controlledEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GenerateJewelAtUnitLevelEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity controlledEntity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass38_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GenerateJewelAtUnitLevelEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__GenerateJewelAtUnitLevelEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass38_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass38_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass38_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass38_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_controlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass38_0>.NativeClassPtr, nameof (controlledEntity));
        DebugEventsSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass38_0>.NativeClassPtr, 100666293);
        DebugEventsSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__GenerateJewelAtUnitLevelEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass38_0>.NativeClassPtr, 100666294);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass38_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass41_0")]
    public sealed class __c__DisplayClass41_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_category;
      private static readonly System.IntPtr NativeFieldInfoPtr_index;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CustomizationEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass41_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _CustomizationEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__CustomizationEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass41_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass41_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr, nameof (category));
        DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr, nameof (index));
        DebugEventsSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr, 100666295);
        DebugEventsSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__CustomizationEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr, 100666296);
      }

      public __c__DisplayClass41_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass41_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass41_0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CustomizationCategoryEnum category
      {
        get
        {
          return *(CustomizationCategoryEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_category));
        }
        [param: In] set
        {
          *(CustomizationCategoryEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_category)) = value;
        }
      }

      public unsafe byte index
      {
        get
        {
          return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_index));
        }
        [param: In] set
        {
          *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_index)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass42_0")]
    public sealed class __c__DisplayClass42_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_options;
      private static readonly System.IntPtr NativeFieldInfoPtr_settings;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RandomizeCustomizationEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass42_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RandomizeCustomizationEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass42_0.NativeMethodInfoPtr__RandomizeCustomizationEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass42_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass42_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr, nameof (options));
        DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr, nameof (settings));
        DebugEventsSystem.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr, 100666297);
        DebugEventsSystem.__c__DisplayClass42_0.NativeMethodInfoPtr__RandomizeCustomizationEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr, 100666298);
      }

      public __c__DisplayClass42_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass42_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass42_0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe RandomizeCustomizationDebugEvent.RandomizeOptions options
      {
        get
        {
          return *(RandomizeCustomizationDebugEvent.RandomizeOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr_options));
        }
        [param: In] set
        {
          *(RandomizeCustomizationDebugEvent.RandomizeOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr_options)) = value;
        }
      }

      public unsafe CharacterCustomizationSettingsComponent settings
      {
        get
        {
          return *(CharacterCustomizationSettingsComponent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr_settings));
        }
        [param: In] set
        {
          *(CharacterCustomizationSettingsComponent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass42_0.NativeFieldInfoPtr_settings)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass43_0")]
    public sealed class __c__DisplayClass43_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_opt;
      private static readonly System.IntPtr NativeFieldInfoPtr_settings;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RandomizeCustomizationEvent2_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass43_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RandomizeCustomizationEvent2_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__RandomizeCustomizationEvent2_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass43_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass43_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_opt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr, nameof (opt));
        DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr, nameof (settings));
        DebugEventsSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr, 100666299);
        DebugEventsSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__RandomizeCustomizationEvent2_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr, 100666300);
      }

      public __c__DisplayClass43_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass43_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass43_0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe RandomizeCustomization2DebugEvent.RndOpt opt
      {
        get
        {
          return *(RandomizeCustomization2DebugEvent.RndOpt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_opt));
        }
        [param: In] set
        {
          *(RandomizeCustomization2DebugEvent.RndOpt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_opt)) = value;
        }
      }

      public unsafe CharacterCustomizationSettingsComponent settings
      {
        get
        {
          return *(CharacterCustomizationSettingsComponent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_settings));
        }
        [param: In] set
        {
          *(CharacterCustomizationSettingsComponent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_settings)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass44_0")]
    public sealed class __c__DisplayClass44_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_amount;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ChangeHealthEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass44_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass44_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ChangeHealthEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass44_0.NativeMethodInfoPtr__ChangeHealthEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass44_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass44_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass44_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass44_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass44_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass44_0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass44_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass44_0>.NativeClassPtr, nameof (amount));
        DebugEventsSystem.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass44_0>.NativeClassPtr, 100666301);
        DebugEventsSystem.__c__DisplayClass44_0.NativeMethodInfoPtr__ChangeHealthEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass44_0>.NativeClassPtr, 100666302);
      }

      public __c__DisplayClass44_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass44_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass44_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass44_0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass44_0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass44_0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass44_0.NativeFieldInfoPtr_amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass44_0.NativeFieldInfoPtr_amount)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass45_0")]
    public sealed class __c__DisplayClass45_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_amount;
      private static readonly System.IntPtr NativeFieldInfoPtr_quality;
      private static readonly System.IntPtr NativeFieldInfoPtr_bloodConsumeSource;
      private static readonly System.IntPtr NativeFieldInfoPtr_source;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ConsumeBloodEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass45_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ConsumeBloodEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass45_0.NativeMethodInfoPtr__ConsumeBloodEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass45_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass45_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr, nameof (amount));
        DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr, nameof (quality));
        DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_bloodConsumeSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr, nameof (bloodConsumeSource));
        DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr, nameof (source));
        DebugEventsSystem.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr, 100666303);
        DebugEventsSystem.__c__DisplayClass45_0.NativeMethodInfoPtr__ConsumeBloodEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr, 100666304);
      }

      public __c__DisplayClass45_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass45_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass45_0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_amount)) = value;
        }
      }

      public unsafe float quality
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_quality));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_quality)) = value;
        }
      }

      public unsafe BloodConsumeSource bloodConsumeSource
      {
        get
        {
          return *(BloodConsumeSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_bloodConsumeSource));
        }
        [param: In] set
        {
          *(BloodConsumeSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_bloodConsumeSource)) = value;
        }
      }

      public unsafe PrefabGUID source
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_source));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass45_0.NativeFieldInfoPtr_source)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass46_0")]
    public sealed class __c__DisplayClass46_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_amount;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ChangeBloodEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass46_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass46_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ChangeBloodEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass46_0.NativeMethodInfoPtr__ChangeBloodEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass46_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass46_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass46_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass46_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass46_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass46_0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass46_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass46_0>.NativeClassPtr, nameof (amount));
        DebugEventsSystem.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass46_0>.NativeClassPtr, 100666305);
        DebugEventsSystem.__c__DisplayClass46_0.NativeMethodInfoPtr__ChangeBloodEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass46_0>.NativeClassPtr, 100666306);
      }

      public __c__DisplayClass46_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass46_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass46_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass46_0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass46_0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass46_0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass46_0.NativeFieldInfoPtr_amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass46_0.NativeFieldInfoPtr_amount)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/<>c__DisplayClass47_0")]
    public sealed class __c__DisplayClass47_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_source;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ChangeVBloodEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass47_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass47_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ChangeVBloodEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__ChangeVBloodEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass47_0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass47_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass47_0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass47_0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass47_0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass47_0>.NativeClassPtr, nameof (source));
        DebugEventsSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass47_0>.NativeClassPtr, 100666307);
        DebugEventsSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__ChangeVBloodEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass47_0>.NativeClassPtr, 100666308);
      }

      public __c__DisplayClass47_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass47_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass47_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass47_0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabGUID source
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_source));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_source)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_JumpToNextBloodMoon_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_addTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float addTime;
      [FieldOffset(8)]
      public DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387522, XrefRangeEnd = 1387527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref DayNightCycle cycle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref cycle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(24)]
      [CachedScanResults(RefRangeStart = 979865, RefRangeEnd = 979889, XrefRangeStart = 979865, XrefRangeEnd = 979889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(21)]
      [CachedScanResults(RefRangeStart = 979889, RefRangeEnd = 979910, XrefRangeStart = 979889, XrefRangeEnd = 979910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387527, XrefRangeEnd = 1387529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387534, RefRangeEnd = 1387535, XrefRangeStart = 1387529, XrefRangeEnd = 1387534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387537, RefRangeEnd = 1387538, XrefRangeStart = 1387535, XrefRangeEnd = 1387537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387538, XrefRangeEnd = 1387542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387542, XrefRangeEnd = 1387548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_JumpToNextBloodMoon_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeFieldInfoPtr_addTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, nameof (addTime));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, 100666309);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, 100666310);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, 100666311);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, 100666312);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, 100666313);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, 100666314);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, 100666315);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, 100666316);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_cycle;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<DayNightCycle> forParameter_cycle;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387442, RefRangeEnd = 1387443, XrefRangeStart = 1387439, XrefRangeEnd = 1387442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387446, RefRangeEnd = 1387447, XrefRangeStart = 1387443, XrefRangeEnd = 1387446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_cycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_cycle));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666317);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666318);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_cycle;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<DayNightCycle>.Runtime runtime_cycle;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_cycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_cycle));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob0/ProjectM.RunWithoutJobSystem_0000071D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000071D$PostfixBurstDelegate");
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666319);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666320);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666321);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666322);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob0/ProjectM.RunWithoutJobSystem_0000071D$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387447, XrefRangeEnd = 1387461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387461, XrefRangeEnd = 1387479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387479, XrefRangeEnd = 1387494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387521, RefRangeEnd = 1387522, XrefRangeStart = 1387494, XrefRangeEnd = 1387521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000071D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666323);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666324);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666325);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666326);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666328);
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
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_JumpToNextBloodMoon_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_addTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_newServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServerTime_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float addTime;
      [FieldOffset(8)]
      public double newServerTime;
      [FieldOffset(16)]
      public DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387631, RefRangeEnd = 1387632, XrefRangeStart = 1387631, XrefRangeEnd = 1387631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref ServerTime serverTime)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref serverTime;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServerTime_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387632, RefRangeEnd = 1387633, XrefRangeStart = 1387632, XrefRangeEnd = 1387632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387633, RefRangeEnd = 1387634, XrefRangeStart = 1387633, XrefRangeEnd = 1387633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387634, XrefRangeEnd = 1387636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387641, RefRangeEnd = 1387642, XrefRangeStart = 1387636, XrefRangeEnd = 1387641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387644, RefRangeEnd = 1387645, XrefRangeStart = 1387642, XrefRangeEnd = 1387644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387645, XrefRangeEnd = 1387649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387649, XrefRangeEnd = 1387655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_JumpToNextBloodMoon_LambdaJob1()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeFieldInfoPtr_addTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, nameof (addTime));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeFieldInfoPtr_newServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, nameof (newServerTime));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, 100666329);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, 100666330);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, 100666331);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, 100666332);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, 100666333);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, 100666334);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, 100666335);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, 100666336);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_serverTime;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<ServerTime> forParameter_serverTime;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387551, RefRangeEnd = 1387552, XrefRangeStart = 1387548, XrefRangeEnd = 1387551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387555, RefRangeEnd = 1387556, XrefRangeStart = 1387552, XrefRangeEnd = 1387555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_serverTime));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100666337);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100666338);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_serverTime;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<ServerTime>.Runtime runtime_serverTime;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_serverTime));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob1/ProjectM.RunWithoutJobSystem_00000726$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000726$PostfixBurstDelegate");
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666339);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666340);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666341);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666342);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob1/ProjectM.RunWithoutJobSystem_00000726$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387556, XrefRangeEnd = 1387570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387570, XrefRangeEnd = 1387588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387588, XrefRangeEnd = 1387603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387630, RefRangeEnd = 1387631, XrefRangeStart = 1387603, XrefRangeEnd = 1387630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000726$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666343);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666344);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666345);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666346);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666348);
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
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_JumpToNextBloodMoon_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_newServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public double newServerTime;
      [FieldOffset(8)]
      public DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387738, XrefRangeEnd = 1387742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref DayNightCycle cycle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref cycle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 937891, RefRangeEnd = 937897, XrefRangeStart = 937891, XrefRangeEnd = 937897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1298125, RefRangeEnd = 1298129, XrefRangeStart = 1298125, XrefRangeEnd = 1298129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387742, XrefRangeEnd = 1387744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387749, RefRangeEnd = 1387750, XrefRangeStart = 1387744, XrefRangeEnd = 1387749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387752, RefRangeEnd = 1387753, XrefRangeStart = 1387750, XrefRangeEnd = 1387752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387753, XrefRangeEnd = 1387757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387757, XrefRangeEnd = 1387763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_JumpToNextBloodMoon_LambdaJob2()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeFieldInfoPtr_newServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, nameof (newServerTime));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, 100666349);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, 100666350);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, 100666351);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, 100666352);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, 100666353);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, 100666354);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, 100666355);
        DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, 100666356);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_cycle;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<DayNightCycle> forParameter_cycle;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387658, RefRangeEnd = 1387659, XrefRangeStart = 1387655, XrefRangeEnd = 1387658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387662, RefRangeEnd = 1387663, XrefRangeStart = 1387659, XrefRangeEnd = 1387662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_cycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_cycle));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100666357);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100666358);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_cycle;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<DayNightCycle>.Runtime runtime_cycle;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_cycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_cycle));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob2/ProjectM.RunWithoutJobSystem_0000072F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_0000072F$PostfixBurstDelegate");
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666359);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666360);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666361);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666362);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_JumpToNextBloodMoon_LambdaJob2/ProjectM.RunWithoutJobSystem_0000072F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387663, XrefRangeEnd = 1387677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387677, XrefRangeEnd = 1387695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387695, XrefRangeEnd = 1387710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387737, RefRangeEnd = 1387738, XrefRangeStart = 1387710, XrefRangeEnd = 1387737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_0000072F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666363);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666364);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666365);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666366);
          DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666368);
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
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_JumpToNextBloodMoon_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_CompleteJournal_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CompleteJournal_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_fromCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(16)]
      public FromCharacter fromCharacter;
      [FieldOffset(32)]
      public DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387775, RefRangeEnd = 1387776, XrefRangeStart = 1387771, XrefRangeEnd = 1387775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref PrefabGUID prefabGUID)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 752109, RefRangeEnd = 752124, XrefRangeStart = 752109, XrefRangeEnd = 752124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387776, XrefRangeEnd = 1387778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387783, RefRangeEnd = 1387784, XrefRangeStart = 1387778, XrefRangeEnd = 1387783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387786, RefRangeEnd = 1387787, XrefRangeStart = 1387784, XrefRangeEnd = 1387786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387787, XrefRangeEnd = 1387793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CompleteJournal_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_CompleteJournal_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, nameof (spawnCommandBuffer));
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeFieldInfoPtr_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, nameof (fromCharacter));
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, 100666369);
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, 100666370);
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, 100666371);
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, 100666372);
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, 100666373);
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, 100666374);
        DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, 100666375);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387766, RefRangeEnd = 1387767, XrefRangeStart = 1387763, XrefRangeEnd = 1387766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387770, RefRangeEnd = 1387771, XrefRangeStart = 1387767, XrefRangeEnd = 1387770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666376);
          DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666377);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CompleteJournal_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ResetCooldowns_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ResetCooldowns_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCooldownState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(32)]
      public unsafe DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387876, RefRangeEnd = 1387877, XrefRangeStart = 1387876, XrefRangeEnd = 1387876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref AbilityCooldownState cooldown)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref cooldown;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCooldownState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387877, XrefRangeEnd = 1387879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387884, RefRangeEnd = 1387885, XrefRangeStart = 1387879, XrefRangeEnd = 1387884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387886, RefRangeEnd = 1387887, XrefRangeStart = 1387885, XrefRangeEnd = 1387886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387887, XrefRangeEnd = 1387891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387891, XrefRangeEnd = 1387897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ResetCooldowns_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_ResetCooldowns_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCooldownState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, 100666378);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, 100666379);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, 100666380);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, 100666381);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, 100666382);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, 100666383);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_cooldown;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityCooldownState> forParameter_cooldown;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387796, RefRangeEnd = 1387797, XrefRangeStart = 1387793, XrefRangeEnd = 1387796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387800, RefRangeEnd = 1387801, XrefRangeStart = 1387797, XrefRangeEnd = 1387800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_cooldown));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666384);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666385);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_cooldown;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityCooldownState>.Runtime runtime_cooldown;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_cooldown));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ResetCooldowns_LambdaJob0/ProjectM.RunWithoutJobSystem_0000073F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000073F$PostfixBurstDelegate");
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666386);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666387);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666388);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666389);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ResetCooldowns_LambdaJob0/ProjectM.RunWithoutJobSystem_0000073F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387801, XrefRangeEnd = 1387815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387815, XrefRangeEnd = 1387833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387833, XrefRangeEnd = 1387848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387875, RefRangeEnd = 1387876, XrefRangeStart = 1387848, XrefRangeEnd = 1387875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000073F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666390);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666391);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666392);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666393);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666395);
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
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ResetCooldowns_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ResetCooldowns_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityChargesState_byref_AbilityChargesData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387986, RefRangeEnd = 1387987, XrefRangeStart = 1387986, XrefRangeEnd = 1387986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref AbilityChargesState chargesState,
        [In] ref AbilityChargesData chargesData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chargesState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref chargesData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityChargesState_byref_AbilityChargesData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387987, XrefRangeEnd = 1387989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387997, RefRangeEnd = 1387998, XrefRangeStart = 1387989, XrefRangeEnd = 1387997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1387999, RefRangeEnd = 1388000, XrefRangeStart = 1387998, XrefRangeEnd = 1387999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388000, XrefRangeEnd = 1388004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388004, XrefRangeEnd = 1388010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ResetCooldowns_LambdaJob1()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_ResetCooldowns_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityChargesState_byref_AbilityChargesData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, 100666396);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, 100666397);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, 100666398);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, 100666399);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, 100666400);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, 100666401);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_chargesState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_chargesData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityChargesState> forParameter_chargesState;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<AbilityChargesData> forParameter_chargesData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387903, RefRangeEnd = 1387904, XrefRangeStart = 1387897, XrefRangeEnd = 1387903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387910, RefRangeEnd = 1387911, XrefRangeStart = 1387904, XrefRangeEnd = 1387910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_chargesState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_chargesState));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_chargesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_chargesData));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100666402);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100666403);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_chargesState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_chargesData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityChargesState>.Runtime runtime_chargesState;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AbilityChargesData>.Runtime runtime_chargesData;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_chargesState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_chargesState));
            DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_chargesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_chargesData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ResetCooldowns_LambdaJob1/ProjectM.RunWithoutJobSystem_00000746$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000746$PostfixBurstDelegate");
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666404);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666405);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666406);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666407);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ResetCooldowns_LambdaJob1/ProjectM.RunWithoutJobSystem_00000746$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387911, XrefRangeEnd = 1387925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387925, XrefRangeEnd = 1387943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387943, XrefRangeEnd = 1387958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1387985, RefRangeEnd = 1387986, XrefRangeStart = 1387958, XrefRangeEnd = 1387985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000746$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666408);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666409);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666410);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666411);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666413);
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
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ResetCooldowns_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ResetCooldowns_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Energy_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(32)]
      public unsafe DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388094, RefRangeEnd = 1388095, XrefRangeStart = 1388093, XrefRangeEnd = 1388094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref Energy energy)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref energy;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Energy_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388095, XrefRangeEnd = 1388097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388102, RefRangeEnd = 1388103, XrefRangeStart = 1388097, XrefRangeEnd = 1388102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388104, RefRangeEnd = 1388105, XrefRangeStart = 1388103, XrefRangeEnd = 1388104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388105, XrefRangeEnd = 1388109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388109, XrefRangeEnd = 1388115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ResetCooldowns_LambdaJob2()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_ResetCooldowns_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Energy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, 100666414);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, 100666415);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, 100666416);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, 100666417);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, 100666418);
        DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, 100666419);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_energy;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Energy> forParameter_energy;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388013, RefRangeEnd = 1388014, XrefRangeStart = 1388010, XrefRangeEnd = 1388013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388017, RefRangeEnd = 1388018, XrefRangeStart = 1388014, XrefRangeEnd = 1388017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_energy));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100666420);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100666421);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_energy;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Energy>.Runtime runtime_energy;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_energy));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ResetCooldowns_LambdaJob2/ProjectM.RunWithoutJobSystem_0000074D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_0000074D$PostfixBurstDelegate");
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666422);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666423);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666424);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666425);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ResetCooldowns_LambdaJob2/ProjectM.RunWithoutJobSystem_0000074D$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388018, XrefRangeEnd = 1388032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388032, XrefRangeEnd = 1388050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388050, XrefRangeEnd = 1388065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388092, RefRangeEnd = 1388093, XrefRangeStart = 1388065, XrefRangeEnd = 1388092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_0000074D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666426);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666427);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666428);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666429);
          DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666431);
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
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ResetCooldowns_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_CrashEvent_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CrashEvent_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public EntityManager entityManager;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388190, XrefRangeEnd = 1388193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 927059, RefRangeEnd = 927105, XrefRangeStart = 927059, XrefRangeEnd = 927105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass27_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(47)]
      [CachedScanResults(RefRangeStart = 927105, RefRangeEnd = 927152, XrefRangeStart = 927105, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass27_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388194, RefRangeEnd = 1388195, XrefRangeStart = 1388193, XrefRangeEnd = 1388194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388196, RefRangeEnd = 1388197, XrefRangeStart = 1388195, XrefRangeEnd = 1388196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass27_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass27_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388197, XrefRangeEnd = 1388201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388250, RefRangeEnd = 1388251, XrefRangeStart = 1388201, XrefRangeEnd = 1388250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CrashEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_CrashEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, 100666432);
        DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, 100666433);
        DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, 100666434);
        DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, 100666435);
        DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, 100666436);
        DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, 100666437);
        DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, 100666438);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_CrashEvent_LambdaJob0/ProjectM.RunWithoutJobSystem_00000755$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000755$PostfixBurstDelegate");
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666439);
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666440);
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666441);
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666442);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_CrashEvent_LambdaJob0/ProjectM.RunWithoutJobSystem_00000755$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388115, XrefRangeEnd = 1388129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388129, XrefRangeEnd = 1388147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388147, XrefRangeEnd = 1388162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388189, RefRangeEnd = 1388190, XrefRangeStart = 1388162, XrefRangeEnd = 1388189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000755$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666443);
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666444);
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666445);
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666446);
          DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666448);
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
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_CrashEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_SpawnDebugEvent_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SpawnDebugEvent_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_teamEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_TeamReference_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity teamEntity;
      [FieldOffset(16)]
      public DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388342, RefRangeEnd = 1388343, XrefRangeStart = 1388342, XrefRangeEnd = 1388342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref TeamReference teamReference)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref teamReference;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_TeamReference_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1192585, RefRangeEnd = 1192592, XrefRangeStart = 1192585, XrefRangeEnd = 1192592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1192592, RefRangeEnd = 1192603, XrefRangeStart = 1192592, XrefRangeEnd = 1192603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388343, XrefRangeEnd = 1388345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388354, RefRangeEnd = 1388355, XrefRangeStart = 1388345, XrefRangeEnd = 1388354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388357, RefRangeEnd = 1388358, XrefRangeStart = 1388355, XrefRangeEnd = 1388357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388358, XrefRangeEnd = 1388362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388362, XrefRangeEnd = 1388368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnDebugEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_SpawnDebugEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeFieldInfoPtr_teamEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, nameof (teamEntity));
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_TeamReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, 100666449);
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, 100666450);
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, 100666451);
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, 100666452);
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, 100666453);
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, 100666454);
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, 100666455);
        DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, 100666456);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_teamReference;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<TeamReference> forParameter_teamReference;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388258, RefRangeEnd = 1388259, XrefRangeStart = 1388251, XrefRangeEnd = 1388258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388266, RefRangeEnd = 1388267, XrefRangeStart = 1388259, XrefRangeEnd = 1388266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_teamReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_teamReference));
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666457);
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666458);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_teamReference;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_user;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<TeamReference>.Runtime runtime_teamReference;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_teamReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_teamReference));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_SpawnDebugEvent_LambdaJob0/ProjectM.RunWithoutJobSystem_0000075C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000075C$PostfixBurstDelegate");
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666459);
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666460);
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666461);
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666462);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_SpawnDebugEvent_LambdaJob0/ProjectM.RunWithoutJobSystem_0000075C$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388267, XrefRangeEnd = 1388281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388281, XrefRangeEnd = 1388299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388299, XrefRangeEnd = 1388314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388341, RefRangeEnd = 1388342, XrefRangeStart = 1388314, XrefRangeEnd = 1388341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000075C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666463);
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666464);
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666465);
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666466);
          DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666468);
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
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_SpawnDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_characterEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity characterEntity;
      [FieldOffset(16)]
      public DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388457, RefRangeEnd = 1388458, XrefRangeStart = 1388457, XrefRangeEnd = 1388457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref User user, [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1192585, RefRangeEnd = 1192592, XrefRangeStart = 1192585, XrefRangeEnd = 1192592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass31_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1192592, RefRangeEnd = 1192603, XrefRangeStart = 1192592, XrefRangeEnd = 1192603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass31_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388458, XrefRangeEnd = 1388460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388468, RefRangeEnd = 1388469, XrefRangeStart = 1388460, XrefRangeEnd = 1388468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388471, RefRangeEnd = 1388472, XrefRangeStart = 1388469, XrefRangeEnd = 1388471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass31_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass31_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388472, XrefRangeEnd = 1388476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388476, XrefRangeEnd = 1388482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeFieldInfoPtr_characterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, nameof (characterEntity));
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, 100666469);
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, 100666470);
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, 100666471);
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, 100666472);
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, 100666473);
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, 100666474);
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, 100666475);
        DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, 100666476);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388374, RefRangeEnd = 1388375, XrefRangeStart = 1388368, XrefRangeEnd = 1388374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388381, RefRangeEnd = 1388382, XrefRangeStart = 1388375, XrefRangeEnd = 1388381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666477);
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666478);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_user;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Controller>.Runtime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0/ProjectM.RunWithoutJobSystem_00000765$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000765$PostfixBurstDelegate");
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666479);
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666480);
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666481);
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666482);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0/ProjectM.RunWithoutJobSystem_00000765$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388382, XrefRangeEnd = 1388396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388396, XrefRangeEnd = 1388414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388414, XrefRangeEnd = 1388429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388456, RefRangeEnd = 1388457, XrefRangeStart = 1388429, XrefRangeEnd = 1388456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000765$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666483);
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666484);
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666485);
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666486);
          DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666488);
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
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_SpawnCharmeableDebugEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_GiveEvent_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GiveEvent_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_controllerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_userContentFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass34_0_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity controllerEntity;
      [FieldOffset(12)]
      public UserContentFlags userContentFlags;
      [FieldOffset(16)]
      public DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass34_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388498, RefRangeEnd = 1388499, XrefRangeStart = 1388498, XrefRangeEnd = 1388498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass34_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388499, XrefRangeEnd = 1388512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388518, RefRangeEnd = 1388519, XrefRangeStart = 1388512, XrefRangeEnd = 1388518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388519, RefRangeEnd = 1388520, XrefRangeStart = 1388519, XrefRangeEnd = 1388519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass34_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass34_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GiveEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_GiveEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeFieldInfoPtr_controllerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, nameof (controllerEntity));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeFieldInfoPtr_userContentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, nameof (userContentFlags));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, 100666489);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, 100666490);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, 100666491);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, 100666493);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, 100666494);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass34_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, 100666495);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388482, XrefRangeEnd = 1388489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388497, RefRangeEnd = 1388498, XrefRangeStart = 1388489, XrefRangeEnd = 1388497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666496);
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666497);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_GiveEvent_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GiveEvent_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_userContentFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropTableDataHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_recipeHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_legendaryWeapons;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_giveable;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass34_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public UserContentFlags userContentFlags;
      [FieldOffset(16)]
      public NativeHashMap<PrefabGUID, DropTableData> dropTableDataHashLookupMap;
      [FieldOffset(32)]
      public NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap;
      [FieldOffset(48)]
      public NativeArray<PrefabGUID> legendaryWeapons;
      [FieldOffset(64)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(112)]
      public PrefabGUID prefabGuid;
      [FieldOffset(116)]
      public bool giveable;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388595, XrefRangeEnd = 1388602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388602, RefRangeEnd = 1388603, XrefRangeStart = 1388602, XrefRangeEnd = 1388602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass34_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388603, RefRangeEnd = 1388604, XrefRangeStart = 1388603, XrefRangeEnd = 1388603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass34_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388605, RefRangeEnd = 1388606, XrefRangeStart = 1388604, XrefRangeEnd = 1388605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388607, RefRangeEnd = 1388608, XrefRangeStart = 1388606, XrefRangeEnd = 1388607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass34_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass34_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388608, XrefRangeEnd = 1388612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388913, RefRangeEnd = 1388914, XrefRangeStart = 1388612, XrefRangeEnd = 1388913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GiveEvent_LambdaJob1()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_GiveEvent_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, nameof (entityManager));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_userContentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, nameof (userContentFlags));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_dropTableDataHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, nameof (dropTableDataHashLookupMap));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_recipeHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, nameof (recipeHashLookupMap));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_legendaryWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, nameof (legendaryWeapons));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, nameof (prefabLookupMap));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, nameof (prefabGuid));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_giveable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, nameof (giveable));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, 100666498);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, 100666499);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass34_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, 100666500);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, 100666501);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass34_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, 100666502);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, 100666503);
        DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, 100666504);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_GiveEvent_LambdaJob1/ProjectM.RunWithoutJobSystem_00000776$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000776$PostfixBurstDelegate");
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666505);
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666506);
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666507);
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666508);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_GiveEvent_LambdaJob1/ProjectM.RunWithoutJobSystem_00000776$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388520, XrefRangeEnd = 1388534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388534, XrefRangeEnd = 1388552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388552, XrefRangeEnd = 1388567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388594, RefRangeEnd = 1388595, XrefRangeStart = 1388567, XrefRangeEnd = 1388594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000776$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666509);
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666510);
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666511);
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666512);
          DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666514);
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
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_GiveEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_CreateJewelEvent_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateJewelEvent_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_controlledEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass35_0_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity controlledEntity;
      [FieldOffset(16)]
      public DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1192585, RefRangeEnd = 1192592, XrefRangeStart = 1192585, XrefRangeEnd = 1192592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass35_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1192592, RefRangeEnd = 1192603, XrefRangeStart = 1192592, XrefRangeEnd = 1192603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass35_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388930, XrefRangeEnd = 1388943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388949, RefRangeEnd = 1388950, XrefRangeStart = 1388943, XrefRangeEnd = 1388949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1388950, RefRangeEnd = 1388954, XrefRangeStart = 1388950, XrefRangeEnd = 1388950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass35_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass35_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateJewelEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_CreateJewelEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeFieldInfoPtr_controlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (controlledEntity));
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, 100666515);
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, 100666516);
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, 100666517);
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, 100666519);
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, 100666520);
        DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, 100666521);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388914, XrefRangeEnd = 1388921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388929, RefRangeEnd = 1388930, XrefRangeStart = 1388921, XrefRangeEnd = 1388929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666522);
          DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666523);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CreateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_GenerateJewelEvent_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GenerateJewelEvent_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_controlledEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass36_0_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity controlledEntity;
      [FieldOffset(16)]
      public DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1192585, RefRangeEnd = 1192592, XrefRangeStart = 1192585, XrefRangeEnd = 1192592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass36_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1192592, RefRangeEnd = 1192603, XrefRangeStart = 1192592, XrefRangeEnd = 1192603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass36_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388970, XrefRangeEnd = 1388983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1388989, RefRangeEnd = 1388990, XrefRangeStart = 1388983, XrefRangeEnd = 1388989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1388950, RefRangeEnd = 1388954, XrefRangeStart = 1388950, XrefRangeEnd = 1388954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass36_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass36_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GenerateJewelEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_GenerateJewelEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeFieldInfoPtr_controlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (controlledEntity));
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, 100666524);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, 100666525);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, 100666526);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, 100666528);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, 100666529);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass36_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, 100666530);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388954, XrefRangeEnd = 1388961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1388969, RefRangeEnd = 1388970, XrefRangeStart = 1388961, XrefRangeEnd = 1388969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666531);
          DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666532);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_controlledEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass37_0_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity controlledEntity;
      [FieldOffset(16)]
      public DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1192585, RefRangeEnd = 1192592, XrefRangeStart = 1192585, XrefRangeEnd = 1192592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass37_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1192592, RefRangeEnd = 1192603, XrefRangeStart = 1192592, XrefRangeEnd = 1192603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass37_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389006, XrefRangeEnd = 1389019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389025, RefRangeEnd = 1389026, XrefRangeStart = 1389019, XrefRangeEnd = 1389025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1388950, RefRangeEnd = 1388954, XrefRangeStart = 1388950, XrefRangeEnd = 1388954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass37_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass37_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeFieldInfoPtr_controlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, nameof (controlledEntity));
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, 100666533);
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, 100666534);
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, 100666535);
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, 100666537);
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, 100666538);
        DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass37_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, 100666539);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388990, XrefRangeEnd = 1388997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1389005, RefRangeEnd = 1389006, XrefRangeStart = 1388997, XrefRangeEnd = 1389005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666540);
          DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666541);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateLegendaryWeaponEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_controlledEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass38_0_0;
      [FieldOffset(0)]
      public int fromUserIndex;
      [FieldOffset(4)]
      public Entity controlledEntity;
      [FieldOffset(16)]
      public DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1192585, RefRangeEnd = 1192592, XrefRangeStart = 1192585, XrefRangeEnd = 1192592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass38_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1192592, RefRangeEnd = 1192603, XrefRangeStart = 1192592, XrefRangeEnd = 1192603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass38_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389042, XrefRangeEnd = 1389055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389061, RefRangeEnd = 1389062, XrefRangeStart = 1389055, XrefRangeEnd = 1389061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1388950, RefRangeEnd = 1388954, XrefRangeStart = 1388950, XrefRangeEnd = 1388954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass38_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass38_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeFieldInfoPtr_controlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, nameof (controlledEntity));
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, 100666542);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, 100666543);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, 100666544);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, 100666546);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, 100666547);
        DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass38_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, 100666548);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389026, XrefRangeEnd = 1389033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1389041, RefRangeEnd = 1389042, XrefRangeStart = 1389033, XrefRangeEnd = 1389041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666549);
          DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666550);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_GenerateJewelAtUnitLevelEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_CustomizationEvent_LambdaJob0")]
    public sealed class __c__DisplayClass_CustomizationEvent_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_category;
      private static readonly System.IntPtr NativeFieldInfoPtr_index;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass41_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389093, RefRangeEnd = 1389094, XrefRangeStart = 1389078, XrefRangeEnd = 1389093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389094, XrefRangeEnd = 1389095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass41_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389096, RefRangeEnd = 1389097, XrefRangeStart = 1389095, XrefRangeEnd = 1389096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass41_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389097, XrefRangeEnd = 1389111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389117, RefRangeEnd = 1389118, XrefRangeStart = 1389111, XrefRangeEnd = 1389117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389119, RefRangeEnd = 1389120, XrefRangeStart = 1389118, XrefRangeEnd = 1389119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass41_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass41_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CustomizationEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_CustomizationEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (category));
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (index));
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, 100666551);
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, 100666552);
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, 100666553);
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, 100666555);
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, 100666556);
        DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, 100666557);
      }

      public __c__DisplayClass_CustomizationEvent_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_CustomizationEvent_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CustomizationCategoryEnum category
      {
        get
        {
          return *(CustomizationCategoryEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr_category));
        }
        [param: In] set
        {
          *(CustomizationCategoryEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr_category)) = value;
        }
      }

      public unsafe byte index
      {
        get
        {
          return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr_index));
        }
        [param: In] set
        {
          *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr_index)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389062, XrefRangeEnd = 1389069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1389077, RefRangeEnd = 1389078, XrefRangeStart = 1389069, XrefRangeEnd = 1389077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666558);
          DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666559);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_CustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0")]
    public sealed class __c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_options;
      private static readonly System.IntPtr NativeFieldInfoPtr_settings;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass42_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass42_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass42_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389151, RefRangeEnd = 1389152, XrefRangeStart = 1389136, XrefRangeEnd = 1389151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389152, XrefRangeEnd = 1389153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass42_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass42_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389154, RefRangeEnd = 1389155, XrefRangeStart = 1389153, XrefRangeEnd = 1389154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass42_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass42_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389155, XrefRangeEnd = 1389169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389175, RefRangeEnd = 1389176, XrefRangeStart = 1389169, XrefRangeEnd = 1389175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389177, RefRangeEnd = 1389178, XrefRangeStart = 1389176, XrefRangeEnd = 1389177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass42_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass42_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (options));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (settings));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, 100666560);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass42_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, 100666561);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass42_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, 100666562);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, 100666564);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, 100666565);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass42_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, 100666566);
      }

      public __c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe RandomizeCustomizationDebugEvent.RandomizeOptions options
      {
        get
        {
          return *(RandomizeCustomizationDebugEvent.RandomizeOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr_options));
        }
        [param: In] set
        {
          *(RandomizeCustomizationDebugEvent.RandomizeOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr_options)) = value;
        }
      }

      public unsafe CharacterCustomizationSettingsComponent settings
      {
        get
        {
          return *(CharacterCustomizationSettingsComponent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr_settings));
        }
        [param: In] set
        {
          *(CharacterCustomizationSettingsComponent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr_settings)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389120, XrefRangeEnd = 1389127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1389135, RefRangeEnd = 1389136, XrefRangeStart = 1389127, XrefRangeEnd = 1389135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666567);
          DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666568);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0")]
    public sealed class __c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_opt;
      private static readonly System.IntPtr NativeFieldInfoPtr_settings;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass43_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389210, RefRangeEnd = 1389211, XrefRangeStart = 1389194, XrefRangeEnd = 1389210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389211, XrefRangeEnd = 1389212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass43_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389213, RefRangeEnd = 1389214, XrefRangeStart = 1389212, XrefRangeEnd = 1389213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass43_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389214, XrefRangeEnd = 1389228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389234, RefRangeEnd = 1389235, XrefRangeStart = 1389228, XrefRangeEnd = 1389234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389236, RefRangeEnd = 1389237, XrefRangeStart = 1389235, XrefRangeEnd = 1389236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass43_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass43_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr_opt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, nameof (opt));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, nameof (settings));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, 100666569);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, 100666570);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, 100666571);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, 100666573);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, 100666574);
        DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, 100666575);
      }

      public __c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe RandomizeCustomization2DebugEvent.RndOpt opt
      {
        get
        {
          return *(RandomizeCustomization2DebugEvent.RndOpt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr_opt));
        }
        [param: In] set
        {
          *(RandomizeCustomization2DebugEvent.RndOpt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr_opt)) = value;
        }
      }

      public unsafe CharacterCustomizationSettingsComponent settings
      {
        get
        {
          return *(CharacterCustomizationSettingsComponent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr_settings));
        }
        [param: In] set
        {
          *(CharacterCustomizationSettingsComponent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr_settings)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389178, XrefRangeEnd = 1389185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1389193, RefRangeEnd = 1389194, XrefRangeStart = 1389185, XrefRangeEnd = 1389193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666576);
          DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666577);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_RandomizeCustomizationEvent2_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ChangeHealthEvent_LambdaJob0")]
    public sealed class __c__DisplayClass_ChangeHealthEvent_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_amount;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass44_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass44_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass44_0_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389253, XrefRangeEnd = 1389256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389256, XrefRangeEnd = 1389257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass44_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass44_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1389258, RefRangeEnd = 1389261, XrefRangeStart = 1389257, XrefRangeEnd = 1389258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass44_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass44_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389261, XrefRangeEnd = 1389277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389283, RefRangeEnd = 1389284, XrefRangeStart = 1389277, XrefRangeEnd = 1389283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1389285, RefRangeEnd = 1389288, XrefRangeStart = 1389284, XrefRangeEnd = 1389285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass44_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass44_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ChangeHealthEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_ChangeHealthEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, nameof (amount));
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, 100666578);
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass44_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, 100666579);
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass44_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, 100666580);
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, 100666582);
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, 100666583);
        DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass44_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, 100666584);
      }

      public __c__DisplayClass_ChangeHealthEvent_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_ChangeHealthEvent_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr_amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr_amount)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389237, XrefRangeEnd = 1389244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1389252, RefRangeEnd = 1389253, XrefRangeStart = 1389244, XrefRangeEnd = 1389252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666585);
          DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666586);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeHealthEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ConsumeBloodEvent_LambdaJob0")]
    public sealed class __c__DisplayClass_ConsumeBloodEvent_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_amount;
      private static readonly System.IntPtr NativeFieldInfoPtr_quality;
      private static readonly System.IntPtr NativeFieldInfoPtr_bloodConsumeSource;
      private static readonly System.IntPtr NativeFieldInfoPtr_source;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass45_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389311, RefRangeEnd = 1389312, XrefRangeStart = 1389304, XrefRangeEnd = 1389311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389312, XrefRangeEnd = 1389313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass45_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389314, RefRangeEnd = 1389315, XrefRangeStart = 1389313, XrefRangeEnd = 1389314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass45_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389315, XrefRangeEnd = 1389329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389335, RefRangeEnd = 1389336, XrefRangeStart = 1389329, XrefRangeEnd = 1389335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389337, RefRangeEnd = 1389338, XrefRangeStart = 1389336, XrefRangeEnd = 1389337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass45_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass45_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ConsumeBloodEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_ConsumeBloodEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (amount));
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (quality));
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_bloodConsumeSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (bloodConsumeSource));
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (source));
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, 100666587);
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, 100666588);
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass45_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, 100666589);
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, 100666591);
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, 100666592);
        DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass45_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, 100666593);
      }

      public __c__DisplayClass_ConsumeBloodEvent_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_ConsumeBloodEvent_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_amount)) = value;
        }
      }

      public unsafe float quality
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_quality));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_quality)) = value;
        }
      }

      public unsafe BloodConsumeSource bloodConsumeSource
      {
        get
        {
          return *(BloodConsumeSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_bloodConsumeSource));
        }
        [param: In] set
        {
          *(BloodConsumeSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_bloodConsumeSource)) = value;
        }
      }

      public unsafe PrefabGUID source
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_source));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr_source)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389288, XrefRangeEnd = 1389295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1389303, RefRangeEnd = 1389304, XrefRangeStart = 1389295, XrefRangeEnd = 1389303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666594);
          DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666595);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ConsumeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ChangeBloodEvent_LambdaJob0")]
    public sealed class __c__DisplayClass_ChangeBloodEvent_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_amount;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass46_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass46_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass46_0_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389354, XrefRangeEnd = 1389357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass46_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass46_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1389258, RefRangeEnd = 1389261, XrefRangeStart = 1389258, XrefRangeEnd = 1389261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass46_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass46_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389357, XrefRangeEnd = 1389373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389379, RefRangeEnd = 1389380, XrefRangeStart = 1389373, XrefRangeEnd = 1389379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1389285, RefRangeEnd = 1389288, XrefRangeStart = 1389285, XrefRangeEnd = 1389288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass46_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass46_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ChangeBloodEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_ChangeBloodEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (amount));
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, 100666596);
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass46_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, 100666597);
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass46_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, 100666598);
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, 100666600);
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, 100666601);
        DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass46_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, 100666602);
      }

      public __c__DisplayClass_ChangeBloodEvent_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_ChangeBloodEvent_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr_amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr_amount)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389338, XrefRangeEnd = 1389345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1389353, RefRangeEnd = 1389354, XrefRangeStart = 1389345, XrefRangeEnd = 1389353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666603);
          DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666604);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DebugEventsSystem/ProjectM.<>c__DisplayClass_ChangeVBloodEvent_LambdaJob0")]
    public sealed class __c__DisplayClass_ChangeVBloodEvent_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_source;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass47_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389407, RefRangeEnd = 1389408, XrefRangeStart = 1389396, XrefRangeEnd = 1389407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass47_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1389258, RefRangeEnd = 1389261, XrefRangeStart = 1389258, XrefRangeEnd = 1389261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DebugEventsSystem.__c__DisplayClass47_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389408, XrefRangeEnd = 1389422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1389428, RefRangeEnd = 1389429, XrefRangeStart = 1389422, XrefRangeEnd = 1389428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1389285, RefRangeEnd = 1389288, XrefRangeStart = 1389285, XrefRangeEnd = 1389288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DebugEventsSystem componentSystem,
        ref DebugEventsSystem.__c__DisplayClass47_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass47_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ChangeVBloodEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_ChangeVBloodEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr);
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, nameof (fromUserIndex));
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, "<>4__this");
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, nameof (source));
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, 100666605);
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, 100666606);
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, 100666607);
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, 100666609);
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, 100666610);
        DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, 100666611);
      }

      public __c__DisplayClass_ChangeVBloodEvent_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_ChangeVBloodEvent_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe int fromUserIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr_fromUserIndex)) = value;
        }
      }

      public unsafe DebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DebugEventsSystem) null : new DebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabGUID source
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr_source));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr_source)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389380, XrefRangeEnd = 1389387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1389395, RefRangeEnd = 1389396, XrefRangeStart = 1389387, XrefRangeEnd = 1389395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666612);
          DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666613);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Controller>.StructuralChangeRuntime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventsSystem.__c__DisplayClass_ChangeVBloodEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
