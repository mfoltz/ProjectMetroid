// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionChecker
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.CastleBuilding;
using ProjectM.Debugging;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConditionChecker
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_Random;
    private static readonly System.IntPtr NativeFieldInfoPtr_Recorder;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_EntityManager_byref_SyncedServerDebugSettings_byref_ServerGameBalanceSettings_byref_Double_byref_DayNightCycle_byref_GameplayDebugRecorder_byref_Random_byref_CollisionWorld_byref_NativeHashMap_2_PrefabGUID_ItemData_byref_TileWorld_byref_TilePolygons_byref_MapZoneCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckConditionGroup_Public_Boolean_byref_ConditionEntities_BlobAssetReference_1_ConditionBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckCondition_Public_Boolean_byref_ConditionEntities_byref_ConditionElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasComponent_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponent_Private_Boolean_Entity_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Private_Boolean_Entity_byref_T1_byref_T2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Private_Boolean_Entity_byref_T1_byref_T2_byref_T3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBufferReadOnly_Private_Boolean_Entity_byref_DynamicBuffer_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Health_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HealthFactor_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Energy_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnergyFactor_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Blood_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BloodFactor_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWounded_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFeedWounded_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWounded_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCasting_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Resistance_Fire_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Resistance_Garlic_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Resistance_Holy_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Resistance_Silver_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Age_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AgeBiggerThanLifetime_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BloodConsumeQuality_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnitType_Private_Boolean_byref_ConditionEntities_byref_TargetEntityCategoryCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnitHealthType_Private_Boolean_byref_ConditionEntities_byref_TargetUnitHealthTypeCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MaterialCategory_Private_Boolean_byref_ConditionEntities_byref_TargetEntityCategoryCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MainCategory_Private_Boolean_byref_ConditionEntities_byref_TargetEntityCategoryCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuff_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuffWithAge_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuffOwnedByOwner_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuffOwnedByNonOwner_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAlly_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEnemy_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInAggroList_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerCharacter_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAlive_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoorCanBeClosed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanBeCharmed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsOverloaded_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInsideOwnerCombatArea_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsOwner_Private_Boolean_byref_ConditionEntities_byref_BoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasProgression_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWaypointUnlocked_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsUserOwner_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUserOwner_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasRespawnPointOwner_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItems_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabIntCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasEquippedWeaponOfType_Private_Boolean_byref_ConditionEntities_byref_TargetWeaponTypeCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasAnyEquippedItem_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DistanceBetweenTargetAndSelf_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsMounted_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsDay_Private_Boolean_byref_ConditionEntities_byref_BoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPrefab_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TimeSinceAbilityCasted_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabTimeCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LastAbilityCasted_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabTimeInvertCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MinionCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FollowerCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSelf_Private_Boolean_byref_ConditionEntities_byref_BoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFlying_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInUnitTeam_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsConfuseDummy_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsServant_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsVBlood_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanRepair_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DayTimeSpanActive_Private_Boolean_byref_DayTimeSpanCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsShapeShifted_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AbilityCastCount_Total_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabCountCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AbilityCastCount_InARow_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabCountCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DamageTakenSince_Private_Boolean_byref_ConditionEntities_byref_DamageTakenSinceCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TimeInCurrentState_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlockFeed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBlockFeedBuff_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanBeConsumed_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAiResourceNode_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AggroListCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuffStackCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WeaponLevel_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InventoryItemCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasTeleportBoundItem_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuffResistances_Private_Boolean_byref_ConditionEntities_byref_TargetBuffCategoryCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OwnerBoundToTarget_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PvPEnabled_Private_Boolean_byref_BoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PvEEnabled_Private_Boolean_byref_BoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanLootEnemyContainersEnabled_Private_Boolean_byref_BoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanInteractWithEnemyCastleHeart_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasMaxMinions_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RandomValueBetween0And1_Private_Boolean_byref_FloatCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanLand_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckLandingTerritory_Private_Boolean_byref_float3_byref_Team_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuffModificationActive_Private_Boolean_byref_ConditionEntities_byref_TargetBuffModificationCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAiPointOfInterestOfType_Private_Boolean_byref_ConditionEntities_byref_TargetAiPointOfInterestTypeCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasSpellMod_Private_Boolean_byref_ConditionEntities_byref_TargetSpellModTypeCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsTeleporterGroupLinked_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCastleBreached_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCastleAttacked_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInNeutralTeam_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCastleRaided_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCastleHeartFromBuilding_Private_Boolean_Entity_byref_CastleHeart_0;
    [FieldOffset(0)]
    public readonly EntityManager EntityManager;
    [FieldOffset(8)]
    public readonly SyncedServerDebugSettings DebugSettings;
    [FieldOffset(48)]
    public readonly ServerGameBalanceSettings BalanceSettings;
    [FieldOffset(1448)]
    public readonly double ServerTime;
    [FieldOffset(1456)]
    public readonly DayNightCycle DayNightCycle;
    [FieldOffset(1592)]
    public readonly NativeHashMap<PrefabGUID, ItemData> ItemLookupMap;
    [FieldOffset(1608)]
    public readonly MapZoneCollection MapZoneCollection;
    [FieldOffset(1704)]
    public readonly TileWorld TileWorld;
    [FieldOffset(1728)]
    public readonly TileMapCollisionMath.TilePolygons TilePolygons;
    [FieldOffset(1808)]
    public CollisionWorld CollisionWorld;
    [FieldOffset(2152)]
    public Unity.Mathematics.Random Random;
    [FieldOffset(2160)]
    public GameplayDebugRecorder Recorder;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800818, RefRangeEnd = 800819, XrefRangeStart = 800817, XrefRangeEnd = 800818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionChecker(
      [In] ref EntityManager entityManager,
      [In] ref SyncedServerDebugSettings debugSettings,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref double serverTime,
      [In] ref DayNightCycle dayNightCycle,
      [In] ref GameplayDebugRecorder recorder,
      [In] ref Unity.Mathematics.Random random,
      [In] ref CollisionWorld collisionWorld,
      [In] ref NativeHashMap<PrefabGUID, ItemData> itemLookupMap,
      [In] ref TileWorld tileWorld,
      [In] ref TileMapCollisionMath.TilePolygons tilePolygons,
      [In] ref MapZoneCollection mapZoneCollection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref debugSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref dayNightCycle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref recorder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref tilePolygons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneCollection;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr__ctor_Public_Void_byref_EntityManager_byref_SyncedServerDebugSettings_byref_ServerGameBalanceSettings_byref_Double_byref_DayNightCycle_byref_GameplayDebugRecorder_byref_Random_byref_CollisionWorld_byref_NativeHashMap_2_PrefabGUID_ItemData_byref_TileWorld_byref_TilePolygons_byref_MapZoneCollection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(45)]
    [CachedScanResults(RefRangeStart = 800835, RefRangeEnd = 800880, XrefRangeStart = 800819, XrefRangeEnd = 800835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckConditionGroup(
      [In] ref ConditionEntities entities,
      BlobAssetReference<ConditionBlob> conditionBlob)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &conditionBlob;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_CheckConditionGroup_Public_Boolean_byref_ConditionEntities_BlobAssetReference_1_ConditionBlob_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800931, RefRangeEnd = 800932, XrefRangeStart = 800880, XrefRangeEnd = 800931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckCondition(
      [In] ref ConditionEntities entities,
      [In] ref ConditionElement condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_CheckCondition_Public_Boolean_byref_ConditionEntities_byref_ConditionElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800934, RefRangeEnd = 800935, XrefRangeStart = 800932, XrefRangeEnd = 800934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasComponent<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.MethodInfoStoreGeneric_HasComponent_Private_Boolean_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800937, RefRangeEnd = 800938, XrefRangeStart = 800935, XrefRangeEnd = 800937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetComponent<T>(Entity entity, out T component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
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
        local1 = ref component;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.MethodInfoStoreGeneric_TryGetComponent_Private_Boolean_Entity_byref_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref component;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800943, RefRangeEnd = 800944, XrefRangeStart = 800938, XrefRangeEnd = 800943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetComponents<T1, T2>(
      Entity entity,
      out T1 component1,
      out T2 component2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      T1& local1;
      if (!typeof (T1).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(T1*) &zero1);
      }
      else
        local1 = ref component1;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero2;
      // ISSUE: variable of a reference type
      T2& local2;
      if (!typeof (T2).IsValueType)
      {
        zero2 = System.IntPtr.Zero;
        local2 = ref (*(T2*) &zero2);
      }
      else
        local2 = ref component2;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr exc;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.MethodInfoStoreGeneric_TryGetComponents_Private_Boolean_Entity_byref_T1_byref_T2_0<T1, T2>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T1).IsValueType)
      {
        ref T1 local3 = ref component1;
        System.IntPtr objectPointer = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T1>(objectPointer, false, false);
        local3 = (T1) valueGeneric;
      }
      if (!typeof (T2).IsValueType)
      {
        ref T2 local4 = ref component2;
        System.IntPtr objectPointer = zero2;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T2>(objectPointer, false, false);
        local4 = (T2) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    public unsafe bool TryGetComponents<T1, T2, T3>(
      Entity entity,
      out T1 component1,
      out T2 component2,
      out T3 component3)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      T1& local1;
      if (!typeof (T1).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(T1*) &zero1);
      }
      else
        local1 = ref component1;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero2;
      // ISSUE: variable of a reference type
      T2& local2;
      if (!typeof (T2).IsValueType)
      {
        zero2 = System.IntPtr.Zero;
        local2 = ref (*(T2*) &zero2);
      }
      else
        local2 = ref component2;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr num3 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero3;
      // ISSUE: variable of a reference type
      T3& local3;
      if (!typeof (T3).IsValueType)
      {
        zero3 = System.IntPtr.Zero;
        local3 = ref (*(T3*) &zero3);
      }
      else
        local3 = ref component3;
      *(System.IntPtr*) num3 = (System.IntPtr) ref local3;
      System.IntPtr exc;
      System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.MethodInfoStoreGeneric_TryGetComponents_Private_Boolean_Entity_byref_T1_byref_T2_byref_T3_0<T1, T2, T3>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T1).IsValueType)
      {
        ref T1 local4 = ref component1;
        System.IntPtr objectPointer = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T1>(objectPointer, false, false);
        local4 = (T1) valueGeneric;
      }
      if (!typeof (T2).IsValueType)
      {
        ref T2 local5 = ref component2;
        System.IntPtr objectPointer = zero2;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T2>(objectPointer, false, false);
        local5 = (T2) valueGeneric;
      }
      if (!typeof (T3).IsValueType)
      {
        ref T3 local6 = ref component3;
        System.IntPtr objectPointer = zero3;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T3>(objectPointer, false, false);
        local6 = (T3) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 800946, RefRangeEnd = 800948, XrefRangeStart = 800944, XrefRangeEnd = 800946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBufferReadOnly<T>(Entity entity, out DynamicBuffer<T> buffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.MethodInfoStoreGeneric_TryGetBufferReadOnly_Private_Boolean_Entity_byref_DynamicBuffer_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800957, RefRangeEnd = 800958, XrefRangeStart = 800948, XrefRangeEnd = 800957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Health([In] ref ConditionEntities entities, [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_Health_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800968, RefRangeEnd = 800969, XrefRangeStart = 800958, XrefRangeEnd = 800968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HealthFactor(
      [In] ref ConditionEntities entities,
      [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HealthFactor_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800978, RefRangeEnd = 800979, XrefRangeStart = 800969, XrefRangeEnd = 800978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Energy([In] ref ConditionEntities entities, [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_Energy_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800989, RefRangeEnd = 800990, XrefRangeStart = 800979, XrefRangeEnd = 800989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool EnergyFactor(
      [In] ref ConditionEntities entities,
      [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_EnergyFactor_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801000, RefRangeEnd = 801001, XrefRangeStart = 800990, XrefRangeEnd = 801000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Blood([In] ref ConditionEntities entities, [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_Blood_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801011, RefRangeEnd = 801012, XrefRangeStart = 801001, XrefRangeEnd = 801011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool BloodFactor(
      [In] ref ConditionEntities entities,
      [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_BloodFactor_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801018, RefRangeEnd = 801019, XrefRangeStart = 801012, XrefRangeEnd = 801018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsWounded([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsWounded_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801025, RefRangeEnd = 801026, XrefRangeStart = 801019, XrefRangeEnd = 801025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsFeedWounded(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsFeedWounded_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 801031, RefRangeEnd = 801033, XrefRangeStart = 801026, XrefRangeEnd = 801031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsWounded(Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &target;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsWounded_Private_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801043, RefRangeEnd = 801044, XrefRangeStart = 801033, XrefRangeEnd = 801043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsCasting([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsCasting_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801056, RefRangeEnd = 801057, XrefRangeStart = 801044, XrefRangeEnd = 801056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Resistance_Fire(
      [In] ref ConditionEntities entities,
      [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_Resistance_Fire_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801069, RefRangeEnd = 801070, XrefRangeStart = 801057, XrefRangeEnd = 801069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Resistance_Garlic(
      [In] ref ConditionEntities entities,
      [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_Resistance_Garlic_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801082, RefRangeEnd = 801083, XrefRangeStart = 801070, XrefRangeEnd = 801082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Resistance_Holy(
      [In] ref ConditionEntities entities,
      [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_Resistance_Holy_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801095, RefRangeEnd = 801096, XrefRangeStart = 801083, XrefRangeEnd = 801095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Resistance_Silver(
      [In] ref ConditionEntities entities,
      [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_Resistance_Silver_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801105, RefRangeEnd = 801106, XrefRangeStart = 801096, XrefRangeEnd = 801105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Age([In] ref ConditionEntities entities, [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_Age_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801106, XrefRangeEnd = 801118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AgeBiggerThanLifetime(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_AgeBiggerThanLifetime_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801127, RefRangeEnd = 801128, XrefRangeStart = 801118, XrefRangeEnd = 801127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool BloodConsumeQuality(
      [In] ref ConditionEntities entities,
      [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_BloodConsumeQuality_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801137, RefRangeEnd = 801138, XrefRangeStart = 801128, XrefRangeEnd = 801137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool UnitType(
      [In] ref ConditionEntities entities,
      [In] ref TargetEntityCategoryCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_UnitType_Private_Boolean_byref_ConditionEntities_byref_TargetEntityCategoryCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801138, XrefRangeEnd = 801147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool UnitHealthType(
      [In] ref ConditionEntities entities,
      [In] ref TargetUnitHealthTypeCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_UnitHealthType_Private_Boolean_byref_ConditionEntities_byref_TargetUnitHealthTypeCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801156, RefRangeEnd = 801157, XrefRangeStart = 801147, XrefRangeEnd = 801156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool MaterialCategory(
      [In] ref ConditionEntities entities,
      [In] ref TargetEntityCategoryCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_MaterialCategory_Private_Boolean_byref_ConditionEntities_byref_TargetEntityCategoryCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801165, RefRangeEnd = 801166, XrefRangeStart = 801157, XrefRangeEnd = 801165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool MainCategory(
      [In] ref ConditionEntities entities,
      [In] ref TargetEntityCategoryCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_MainCategory_Private_Boolean_byref_ConditionEntities_byref_TargetEntityCategoryCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801193, RefRangeEnd = 801194, XrefRangeStart = 801166, XrefRangeEnd = 801193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasBuff([In] ref ConditionEntities entities, [In] ref TargetPrefabCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasBuff_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801194, XrefRangeEnd = 801226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasBuffWithAge(
      [In] ref ConditionEntities entities,
      [In] ref TargetPrefabFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasBuffWithAge_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801226, XrefRangeEnd = 801257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasBuffOwnedByOwner(
      [In] ref ConditionEntities entities,
      [In] ref TargetPrefabCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasBuffOwnedByOwner_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801288, RefRangeEnd = 801289, XrefRangeStart = 801257, XrefRangeEnd = 801288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasBuffOwnedByNonOwner(
      [In] ref ConditionEntities entities,
      [In] ref TargetPrefabCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasBuffOwnedByNonOwner_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801300, RefRangeEnd = 801301, XrefRangeStart = 801289, XrefRangeEnd = 801300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAlly([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsAlly_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801330, RefRangeEnd = 801331, XrefRangeStart = 801301, XrefRangeEnd = 801330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEnemy([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsEnemy_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801348, RefRangeEnd = 801349, XrefRangeStart = 801331, XrefRangeEnd = 801348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInAggroList(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsInAggroList_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801360, RefRangeEnd = 801361, XrefRangeStart = 801349, XrefRangeEnd = 801360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsPlayerCharacter(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsPlayerCharacter_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801373, RefRangeEnd = 801374, XrefRangeStart = 801361, XrefRangeEnd = 801373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAlive([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsAlive_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801382, RefRangeEnd = 801383, XrefRangeStart = 801374, XrefRangeEnd = 801382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool DoorCanBeClosed(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_DoorCanBeClosed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801391, RefRangeEnd = 801392, XrefRangeStart = 801383, XrefRangeEnd = 801391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanBeCharmed(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_CanBeCharmed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801392, XrefRangeEnd = 801400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsOverloaded(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsOverloaded_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801400, XrefRangeEnd = 801413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInsideOwnerCombatArea(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsInsideOwnerCombatArea_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801418, RefRangeEnd = 801419, XrefRangeStart = 801413, XrefRangeEnd = 801418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsOwner([In] ref ConditionEntities entities, [In] ref BoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsOwner_Private_Boolean_byref_ConditionEntities_byref_BoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801454, RefRangeEnd = 801455, XrefRangeStart = 801419, XrefRangeEnd = 801454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasProgression(
      [In] ref ConditionEntities entities,
      [In] ref TargetPrefabCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasProgression_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801464, RefRangeEnd = 801465, XrefRangeStart = 801455, XrefRangeEnd = 801464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsWaypointUnlocked(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsWaypointUnlocked_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801478, RefRangeEnd = 801479, XrefRangeStart = 801465, XrefRangeEnd = 801478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsUserOwner(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsUserOwner_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801490, RefRangeEnd = 801491, XrefRangeStart = 801479, XrefRangeEnd = 801490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasUserOwner(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasUserOwner_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801499, RefRangeEnd = 801500, XrefRangeStart = 801491, XrefRangeEnd = 801499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasRespawnPointOwner(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasRespawnPointOwner_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801525, RefRangeEnd = 801526, XrefRangeStart = 801500, XrefRangeEnd = 801525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasItems(
      [In] ref ConditionEntities entities,
      [In] ref TargetPrefabIntCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasItems_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabIntCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801542, RefRangeEnd = 801543, XrefRangeStart = 801526, XrefRangeEnd = 801542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasEquippedWeaponOfType(
      [In] ref ConditionEntities entities,
      [In] ref TargetWeaponTypeCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasEquippedWeaponOfType_Private_Boolean_byref_ConditionEntities_byref_TargetWeaponTypeCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801543, XrefRangeEnd = 801554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasAnyEquippedItem(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasAnyEquippedItem_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801566, RefRangeEnd = 801567, XrefRangeStart = 801554, XrefRangeEnd = 801566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool DistanceBetweenTargetAndSelf(
      [In] ref ConditionEntities entities,
      [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_DistanceBetweenTargetAndSelf_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801596, RefRangeEnd = 801597, XrefRangeStart = 801567, XrefRangeEnd = 801596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsMounted([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsMounted_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801602, RefRangeEnd = 801603, XrefRangeStart = 801597, XrefRangeEnd = 801602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsDay([In] ref ConditionEntities entities, [In] ref BoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsDay_Private_Boolean_byref_ConditionEntities_byref_BoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801612, RefRangeEnd = 801613, XrefRangeStart = 801603, XrefRangeEnd = 801612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsPrefab([In] ref ConditionEntities entities, [In] ref TargetPrefabCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsPrefab_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801643, RefRangeEnd = 801644, XrefRangeStart = 801613, XrefRangeEnd = 801643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TimeSinceAbilityCasted(
      [In] ref ConditionEntities entities,
      [In] ref AbilityTargetPrefabTimeCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_TimeSinceAbilityCasted_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabTimeCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801675, RefRangeEnd = 801676, XrefRangeStart = 801644, XrefRangeEnd = 801675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool LastAbilityCasted(
      [In] ref ConditionEntities entities,
      [In] ref AbilityTargetPrefabTimeInvertCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_LastAbilityCasted_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabTimeInvertCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801683, RefRangeEnd = 801684, XrefRangeStart = 801676, XrefRangeEnd = 801683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool MinionCount([In] ref ConditionEntities entities, [In] ref TargetIntCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_MinionCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801684, XrefRangeEnd = 801697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool FollowerCount(
      [In] ref ConditionEntities entities,
      [In] ref TargetIntCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_FollowerCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801702, RefRangeEnd = 801703, XrefRangeStart = 801697, XrefRangeEnd = 801702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSelf([In] ref ConditionEntities entities, [In] ref BoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsSelf_Private_Boolean_byref_ConditionEntities_byref_BoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801703, XrefRangeEnd = 801712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsFlying([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsFlying_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801712, XrefRangeEnd = 801720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsFed([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsFed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801720, XrefRangeEnd = 801728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInUnitTeam(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsInUnitTeam_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801728, XrefRangeEnd = 801736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsConfuseDummy(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsConfuseDummy_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801736, XrefRangeEnd = 801744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsServant([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsServant_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801744, XrefRangeEnd = 801752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsVBlood([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsVBlood_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801752, XrefRangeEnd = 801760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanRepair([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_CanRepair_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801765, RefRangeEnd = 801766, XrefRangeStart = 801760, XrefRangeEnd = 801765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool DayTimeSpanActive([In] ref DayTimeSpanCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_DayTimeSpanActive_Private_Boolean_byref_DayTimeSpanCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801778, RefRangeEnd = 801779, XrefRangeStart = 801766, XrefRangeEnd = 801778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsShapeShifted(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsShapeShifted_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801798, RefRangeEnd = 801799, XrefRangeStart = 801779, XrefRangeEnd = 801798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AbilityCastCount_Total(
      [In] ref ConditionEntities entities,
      [In] ref AbilityTargetPrefabCountCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_AbilityCastCount_Total_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabCountCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801818, RefRangeEnd = 801819, XrefRangeStart = 801799, XrefRangeEnd = 801818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AbilityCastCount_InARow(
      [In] ref ConditionEntities entities,
      [In] ref AbilityTargetPrefabCountCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_AbilityCastCount_InARow_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabCountCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801839, RefRangeEnd = 801840, XrefRangeStart = 801819, XrefRangeEnd = 801839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool DamageTakenSince(
      [In] ref ConditionEntities entities,
      [In] ref DamageTakenSinceCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_DamageTakenSince_Private_Boolean_byref_ConditionEntities_byref_DamageTakenSinceCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801850, RefRangeEnd = 801851, XrefRangeStart = 801840, XrefRangeEnd = 801850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TimeInCurrentState(
      [In] ref ConditionEntities entities,
      [In] ref TargetFloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_TimeInCurrentState_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801858, RefRangeEnd = 801859, XrefRangeStart = 801851, XrefRangeEnd = 801858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool BlockFeed([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_BlockFeed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801873, RefRangeEnd = 801874, XrefRangeStart = 801859, XrefRangeEnd = 801873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasBlockFeedBuff(Entity conditionalTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &conditionalTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasBlockFeedBuff_Private_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801877, RefRangeEnd = 801878, XrefRangeStart = 801874, XrefRangeEnd = 801877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanBeConsumed(Entity conditionalTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &conditionalTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_CanBeConsumed_Private_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 801886, RefRangeEnd = 801887, XrefRangeStart = 801878, XrefRangeEnd = 801886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAiResourceNode(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsAiResourceNode_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801887, XrefRangeEnd = 801900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AggroListCount(
      [In] ref ConditionEntities entities,
      [In] ref TargetIntCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_AggroListCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801900, XrefRangeEnd = 801908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool BuffStackCount(
      [In] ref ConditionEntities entities,
      [In] ref TargetIntCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_BuffStackCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801908, XrefRangeEnd = 801918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool WeaponLevel([In] ref ConditionEntities entities, [In] ref TargetIntCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_WeaponLevel_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801918, XrefRangeEnd = 801942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool InventoryItemCount(
      [In] ref ConditionEntities entities,
      [In] ref TargetIntCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_InventoryItemCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801942, XrefRangeEnd = 801948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasTeleportBoundItem(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasTeleportBoundItem_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801948, XrefRangeEnd = 801981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasBuffResistances(
      [In] ref ConditionEntities entities,
      [In] ref TargetBuffCategoryCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasBuffResistances_Private_Boolean_byref_ConditionEntities_byref_TargetBuffCategoryCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801981, XrefRangeEnd = 801993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool OwnerBoundToTarget(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_OwnerBoundToTarget_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801993, XrefRangeEnd = 801997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool PvPEnabled([In] ref BoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_PvPEnabled_Private_Boolean_byref_BoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801997, XrefRangeEnd = 802001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool PvEEnabled([In] ref BoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_PvEEnabled_Private_Boolean_byref_BoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802001, XrefRangeEnd = 802005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanLootEnemyContainersEnabled([In] ref BoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_CanLootEnemyContainersEnabled_Private_Boolean_byref_BoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802005, XrefRangeEnd = 802013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanInteractWithEnemyCastleHeart(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_CanInteractWithEnemyCastleHeart_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802013, XrefRangeEnd = 802021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasMaxMinions(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasMaxMinions_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802021, XrefRangeEnd = 802026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool RandomValueBetween0And1([In] ref FloatCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_RandomValueBetween0And1_Private_Boolean_byref_FloatCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802026, XrefRangeEnd = 802052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanLand([In] ref ConditionEntities entities, [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_CanLand_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 802097, RefRangeEnd = 802098, XrefRangeStart = 802052, XrefRangeEnd = 802097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckLandingTerritory([In] ref float3 position, [In] ref Team targetTeam)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetTeam;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_CheckLandingTerritory_Private_Boolean_byref_float3_byref_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802098, XrefRangeEnd = 802106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool BuffModificationActive(
      [In] ref ConditionEntities entities,
      [In] ref TargetBuffModificationCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_BuffModificationActive_Private_Boolean_byref_ConditionEntities_byref_TargetBuffModificationCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802106, XrefRangeEnd = 802114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAiPointOfInterestOfType(
      [In] ref ConditionEntities entities,
      [In] ref TargetAiPointOfInterestTypeCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsAiPointOfInterestOfType_Private_Boolean_byref_ConditionEntities_byref_TargetAiPointOfInterestTypeCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802114, XrefRangeEnd = 802120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasSpellMod(
      [In] ref ConditionEntities entities,
      [In] ref TargetSpellModTypeCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_HasSpellMod_Private_Boolean_byref_ConditionEntities_byref_TargetSpellModTypeCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802120, XrefRangeEnd = 802136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsTeleporterGroupLinked(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsTeleporterGroupLinked_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802136, XrefRangeEnd = 802142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsCastleBreached(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsCastleBreached_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802142, XrefRangeEnd = 802148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsCastleAttacked(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsCastleAttacked_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802148, XrefRangeEnd = 802156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInNeutralTeam(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsInNeutralTeam_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802156, XrefRangeEnd = 802162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsCastleRaided(
      [In] ref ConditionEntities entities,
      [In] ref TargetBoolCondition condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_IsCastleRaided_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 802169, RefRangeEnd = 802172, XrefRangeStart = 802162, XrefRangeEnd = 802169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetCastleHeartFromBuilding(Entity entity, out CastleHeart castleHeart)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeart;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionChecker.NativeMethodInfoPtr_TryGetCastleHeartFromBuilding_Private_Boolean_Entity_byref_CastleHeart_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ConditionChecker()
    {
      Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionChecker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr);
      ConditionChecker.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (EntityManager));
      ConditionChecker.NativeFieldInfoPtr_DebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (DebugSettings));
      ConditionChecker.NativeFieldInfoPtr_BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (BalanceSettings));
      ConditionChecker.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (ServerTime));
      ConditionChecker.NativeFieldInfoPtr_DayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (DayNightCycle));
      ConditionChecker.NativeFieldInfoPtr_ItemLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (ItemLookupMap));
      ConditionChecker.NativeFieldInfoPtr_MapZoneCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (MapZoneCollection));
      ConditionChecker.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (TileWorld));
      ConditionChecker.NativeFieldInfoPtr_TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (TilePolygons));
      ConditionChecker.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (CollisionWorld));
      ConditionChecker.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (Random));
      ConditionChecker.NativeFieldInfoPtr_Recorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, nameof (Recorder));
      ConditionChecker.NativeMethodInfoPtr__ctor_Public_Void_byref_EntityManager_byref_SyncedServerDebugSettings_byref_ServerGameBalanceSettings_byref_Double_byref_DayNightCycle_byref_GameplayDebugRecorder_byref_Random_byref_CollisionWorld_byref_NativeHashMap_2_PrefabGUID_ItemData_byref_TileWorld_byref_TilePolygons_byref_MapZoneCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670632);
      ConditionChecker.NativeMethodInfoPtr_CheckConditionGroup_Public_Boolean_byref_ConditionEntities_BlobAssetReference_1_ConditionBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670633);
      ConditionChecker.NativeMethodInfoPtr_CheckCondition_Public_Boolean_byref_ConditionEntities_byref_ConditionElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670634);
      ConditionChecker.NativeMethodInfoPtr_HasComponent_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670635);
      ConditionChecker.NativeMethodInfoPtr_TryGetComponent_Private_Boolean_Entity_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670636);
      ConditionChecker.NativeMethodInfoPtr_TryGetComponents_Private_Boolean_Entity_byref_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670637);
      ConditionChecker.NativeMethodInfoPtr_TryGetComponents_Private_Boolean_Entity_byref_T1_byref_T2_byref_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670638);
      ConditionChecker.NativeMethodInfoPtr_TryGetBufferReadOnly_Private_Boolean_Entity_byref_DynamicBuffer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670639);
      ConditionChecker.NativeMethodInfoPtr_Health_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670640);
      ConditionChecker.NativeMethodInfoPtr_HealthFactor_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670641);
      ConditionChecker.NativeMethodInfoPtr_Energy_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670642);
      ConditionChecker.NativeMethodInfoPtr_EnergyFactor_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670643);
      ConditionChecker.NativeMethodInfoPtr_Blood_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670644);
      ConditionChecker.NativeMethodInfoPtr_BloodFactor_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670645);
      ConditionChecker.NativeMethodInfoPtr_IsWounded_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670646);
      ConditionChecker.NativeMethodInfoPtr_IsFeedWounded_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670647);
      ConditionChecker.NativeMethodInfoPtr_IsWounded_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670648);
      ConditionChecker.NativeMethodInfoPtr_IsCasting_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670649);
      ConditionChecker.NativeMethodInfoPtr_Resistance_Fire_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670650);
      ConditionChecker.NativeMethodInfoPtr_Resistance_Garlic_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670651);
      ConditionChecker.NativeMethodInfoPtr_Resistance_Holy_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670652);
      ConditionChecker.NativeMethodInfoPtr_Resistance_Silver_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670653);
      ConditionChecker.NativeMethodInfoPtr_Age_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670654);
      ConditionChecker.NativeMethodInfoPtr_AgeBiggerThanLifetime_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670655);
      ConditionChecker.NativeMethodInfoPtr_BloodConsumeQuality_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670656);
      ConditionChecker.NativeMethodInfoPtr_UnitType_Private_Boolean_byref_ConditionEntities_byref_TargetEntityCategoryCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670657);
      ConditionChecker.NativeMethodInfoPtr_UnitHealthType_Private_Boolean_byref_ConditionEntities_byref_TargetUnitHealthTypeCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670658);
      ConditionChecker.NativeMethodInfoPtr_MaterialCategory_Private_Boolean_byref_ConditionEntities_byref_TargetEntityCategoryCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670659);
      ConditionChecker.NativeMethodInfoPtr_MainCategory_Private_Boolean_byref_ConditionEntities_byref_TargetEntityCategoryCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670660);
      ConditionChecker.NativeMethodInfoPtr_HasBuff_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670661);
      ConditionChecker.NativeMethodInfoPtr_HasBuffWithAge_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670662);
      ConditionChecker.NativeMethodInfoPtr_HasBuffOwnedByOwner_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670663);
      ConditionChecker.NativeMethodInfoPtr_HasBuffOwnedByNonOwner_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670664);
      ConditionChecker.NativeMethodInfoPtr_IsAlly_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670665);
      ConditionChecker.NativeMethodInfoPtr_IsEnemy_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670666);
      ConditionChecker.NativeMethodInfoPtr_IsInAggroList_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670667);
      ConditionChecker.NativeMethodInfoPtr_IsPlayerCharacter_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670668);
      ConditionChecker.NativeMethodInfoPtr_IsAlive_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670669);
      ConditionChecker.NativeMethodInfoPtr_DoorCanBeClosed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670670);
      ConditionChecker.NativeMethodInfoPtr_CanBeCharmed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670671);
      ConditionChecker.NativeMethodInfoPtr_IsOverloaded_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670672);
      ConditionChecker.NativeMethodInfoPtr_IsInsideOwnerCombatArea_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670673);
      ConditionChecker.NativeMethodInfoPtr_IsOwner_Private_Boolean_byref_ConditionEntities_byref_BoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670674);
      ConditionChecker.NativeMethodInfoPtr_HasProgression_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670675);
      ConditionChecker.NativeMethodInfoPtr_IsWaypointUnlocked_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670676);
      ConditionChecker.NativeMethodInfoPtr_IsUserOwner_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670677);
      ConditionChecker.NativeMethodInfoPtr_HasUserOwner_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670678);
      ConditionChecker.NativeMethodInfoPtr_HasRespawnPointOwner_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670679);
      ConditionChecker.NativeMethodInfoPtr_HasItems_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabIntCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670680);
      ConditionChecker.NativeMethodInfoPtr_HasEquippedWeaponOfType_Private_Boolean_byref_ConditionEntities_byref_TargetWeaponTypeCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670681);
      ConditionChecker.NativeMethodInfoPtr_HasAnyEquippedItem_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670682);
      ConditionChecker.NativeMethodInfoPtr_DistanceBetweenTargetAndSelf_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670683);
      ConditionChecker.NativeMethodInfoPtr_IsMounted_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670684);
      ConditionChecker.NativeMethodInfoPtr_IsDay_Private_Boolean_byref_ConditionEntities_byref_BoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670685);
      ConditionChecker.NativeMethodInfoPtr_IsPrefab_Private_Boolean_byref_ConditionEntities_byref_TargetPrefabCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670686);
      ConditionChecker.NativeMethodInfoPtr_TimeSinceAbilityCasted_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabTimeCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670687);
      ConditionChecker.NativeMethodInfoPtr_LastAbilityCasted_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabTimeInvertCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670688);
      ConditionChecker.NativeMethodInfoPtr_MinionCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670689);
      ConditionChecker.NativeMethodInfoPtr_FollowerCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670690);
      ConditionChecker.NativeMethodInfoPtr_IsSelf_Private_Boolean_byref_ConditionEntities_byref_BoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670691);
      ConditionChecker.NativeMethodInfoPtr_IsFlying_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670692);
      ConditionChecker.NativeMethodInfoPtr_IsFed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670693);
      ConditionChecker.NativeMethodInfoPtr_IsInUnitTeam_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670694);
      ConditionChecker.NativeMethodInfoPtr_IsConfuseDummy_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670695);
      ConditionChecker.NativeMethodInfoPtr_IsServant_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670696);
      ConditionChecker.NativeMethodInfoPtr_IsVBlood_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670697);
      ConditionChecker.NativeMethodInfoPtr_CanRepair_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670698);
      ConditionChecker.NativeMethodInfoPtr_DayTimeSpanActive_Private_Boolean_byref_DayTimeSpanCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670699);
      ConditionChecker.NativeMethodInfoPtr_IsShapeShifted_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670700);
      ConditionChecker.NativeMethodInfoPtr_AbilityCastCount_Total_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabCountCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670701);
      ConditionChecker.NativeMethodInfoPtr_AbilityCastCount_InARow_Private_Boolean_byref_ConditionEntities_byref_AbilityTargetPrefabCountCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670702);
      ConditionChecker.NativeMethodInfoPtr_DamageTakenSince_Private_Boolean_byref_ConditionEntities_byref_DamageTakenSinceCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670703);
      ConditionChecker.NativeMethodInfoPtr_TimeInCurrentState_Private_Boolean_byref_ConditionEntities_byref_TargetFloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670704);
      ConditionChecker.NativeMethodInfoPtr_BlockFeed_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670705);
      ConditionChecker.NativeMethodInfoPtr_HasBlockFeedBuff_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670706);
      ConditionChecker.NativeMethodInfoPtr_CanBeConsumed_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670707);
      ConditionChecker.NativeMethodInfoPtr_IsAiResourceNode_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670708);
      ConditionChecker.NativeMethodInfoPtr_AggroListCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670709);
      ConditionChecker.NativeMethodInfoPtr_BuffStackCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670710);
      ConditionChecker.NativeMethodInfoPtr_WeaponLevel_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670711);
      ConditionChecker.NativeMethodInfoPtr_InventoryItemCount_Private_Boolean_byref_ConditionEntities_byref_TargetIntCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670712);
      ConditionChecker.NativeMethodInfoPtr_HasTeleportBoundItem_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670713);
      ConditionChecker.NativeMethodInfoPtr_HasBuffResistances_Private_Boolean_byref_ConditionEntities_byref_TargetBuffCategoryCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670714);
      ConditionChecker.NativeMethodInfoPtr_OwnerBoundToTarget_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670715);
      ConditionChecker.NativeMethodInfoPtr_PvPEnabled_Private_Boolean_byref_BoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670716);
      ConditionChecker.NativeMethodInfoPtr_PvEEnabled_Private_Boolean_byref_BoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670717);
      ConditionChecker.NativeMethodInfoPtr_CanLootEnemyContainersEnabled_Private_Boolean_byref_BoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670718);
      ConditionChecker.NativeMethodInfoPtr_CanInteractWithEnemyCastleHeart_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670719);
      ConditionChecker.NativeMethodInfoPtr_HasMaxMinions_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670720);
      ConditionChecker.NativeMethodInfoPtr_RandomValueBetween0And1_Private_Boolean_byref_FloatCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670721);
      ConditionChecker.NativeMethodInfoPtr_CanLand_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670722);
      ConditionChecker.NativeMethodInfoPtr_CheckLandingTerritory_Private_Boolean_byref_float3_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670723);
      ConditionChecker.NativeMethodInfoPtr_BuffModificationActive_Private_Boolean_byref_ConditionEntities_byref_TargetBuffModificationCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670724);
      ConditionChecker.NativeMethodInfoPtr_IsAiPointOfInterestOfType_Private_Boolean_byref_ConditionEntities_byref_TargetAiPointOfInterestTypeCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670725);
      ConditionChecker.NativeMethodInfoPtr_HasSpellMod_Private_Boolean_byref_ConditionEntities_byref_TargetSpellModTypeCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670726);
      ConditionChecker.NativeMethodInfoPtr_IsTeleporterGroupLinked_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670727);
      ConditionChecker.NativeMethodInfoPtr_IsCastleBreached_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670728);
      ConditionChecker.NativeMethodInfoPtr_IsCastleAttacked_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670729);
      ConditionChecker.NativeMethodInfoPtr_IsInNeutralTeam_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670730);
      ConditionChecker.NativeMethodInfoPtr_IsCastleRaided_Private_Boolean_byref_ConditionEntities_byref_TargetBoolCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670731);
      ConditionChecker.NativeMethodInfoPtr_TryGetCastleHeartFromBuilding_Private_Boolean_Entity_byref_CastleHeart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, 100670732);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr, (System.IntPtr) ref this));
    }

    private sealed class MethodInfoStoreGeneric_HasComponent_Private_Boolean_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConditionChecker.NativeMethodInfoPtr_HasComponent_Private_Boolean_Entity_0, Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponent_Private_Boolean_Entity_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConditionChecker.NativeMethodInfoPtr_TryGetComponent_Private_Boolean_Entity_byref_T_0, Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Private_Boolean_Entity_byref_T1_byref_T2_0<T1, T2>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConditionChecker.NativeMethodInfoPtr_TryGetComponents_Private_Boolean_Entity_byref_T1_byref_T2_0, Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Private_Boolean_Entity_byref_T1_byref_T2_byref_T3_0<T1, T2, T3>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConditionChecker.NativeMethodInfoPtr_TryGetComponents_Private_Boolean_Entity_byref_T1_byref_T2_byref_T3_0, Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetBufferReadOnly_Private_Boolean_Entity_byref_DynamicBuffer_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConditionChecker.NativeMethodInfoPtr_TryGetBufferReadOnly_Private_Boolean_Entity_byref_DynamicBuffer_1_T_0, Il2CppClassPointerStore<ConditionChecker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
