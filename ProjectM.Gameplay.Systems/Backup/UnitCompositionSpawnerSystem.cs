// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitCompositionSpawnerSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class UnitCompositionSpawnerSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DayNightCycle;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlacementSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplaceAIQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ResetSpawnersIfOutsideTimeSpan_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ResetSpawnersIfOutsideTimeSpan_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ResetOncePatrolIfEveryoneDead_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ResetOncePatrolIfEveryoneDead_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RealizeForceDespawn_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RealizeForceDespawn_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DetachUnits_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DetachUnits_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ReplaceEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ReplaceEvents_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemapAndTriggerRespawnForMissingUnits_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemapAndTriggerRespawnForMissingUnits_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnUnits_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnUnits_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetWasDisabled_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetWasDisabled_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFollowerModifications_Public_Static_Void_EntityManager_byref_UnitCompositionActiveUnit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TriggerAllUnitsInactive_Private_Static_Void_EntityManager_EntityCommandBuffer_Entity_byref_UnitCompositionSpawner_byref_Random_DayNightCycle_PrefabLookupMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckUnitInactive_Private_Static_Void_EntityManager_byref_UnitCompositionActiveUnit_Boolean_UnitCompositionSpawner_DayNightCycle_byref_Random_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomSpawnDelay_Private_Static_Single_byref_Random_byref_DayNightCycle_byref_UnitCompositionSpawner_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySpawnUnit_Private_Static_Boolean_Entity_float3_quaternion_Boolean_EntityInput_EntityCommandBuffer_Entity_byref_JobData_EntityManager_SpawnBuffKind_Double_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForResetSpawnersIfOutsideTimeSpan_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForResetOncePatrolIfEveryoneDead_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRealizeForceDespawn_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDetachUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForReplaceEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemapAndTriggerRespawnForMissingUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawnUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetWasDisabled_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_6;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_7;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405247, XrefRangeEnd = 1405285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitCompositionSpawnerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405285, XrefRangeEnd = 1405291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitCompositionSpawnerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405291, XrefRangeEnd = 1405458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitCompositionSpawnerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1405480, RefRangeEnd = 1405485, XrefRangeStart = 1405458, XrefRangeEnd = 1405480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveFollowerModifications(
      EntityManager entityManager,
      ref UnitCompositionActiveUnit activeUnit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnit;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_RemoveFollowerModifications_Public_Static_Void_EntityManager_byref_UnitCompositionActiveUnit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1405501, RefRangeEnd = 1405503, XrefRangeStart = 1405485, XrefRangeEnd = 1405501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TriggerAllUnitsInactive(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      Entity entity,
      ref UnitCompositionSpawner compositionSpawner,
      ref Unity.Mathematics.Random random,
      DayNightCycle dayNightCycle,
      PrefabLookupMap prefabLookupMap)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dayNightCycle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_TriggerAllUnitsInactive_Private_Static_Void_EntityManager_EntityCommandBuffer_Entity_byref_UnitCompositionSpawner_byref_Random_DayNightCycle_PrefabLookupMap_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1405544, RefRangeEnd = 1405546, XrefRangeStart = 1405503, XrefRangeEnd = 1405544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckUnitInactive(
      EntityManager entityManager,
      ref UnitCompositionActiveUnit activeUnit,
      bool detachEventFound,
      UnitCompositionSpawner compositionSpawner,
      DayNightCycle dayNightCycle,
      ref Unity.Mathematics.Random random,
      ref bool allInactive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &detachEventFound;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &compositionSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dayNightCycle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref allInactive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_CheckUnitInactive_Private_Static_Void_EntityManager_byref_UnitCompositionActiveUnit_Boolean_UnitCompositionSpawner_DayNightCycle_byref_Random_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405551, RefRangeEnd = 1405552, XrefRangeStart = 1405546, XrefRangeEnd = 1405551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetRandomSpawnDelay(
      ref Unity.Mathematics.Random random,
      ref DayNightCycle dayNightCycle,
      [In] ref UnitCompositionSpawner compositionSpawn)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dayNightCycle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawn;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_GetRandomSpawnDelay_Private_Static_Single_byref_Random_byref_DayNightCycle_byref_UnitCompositionSpawner_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1405597, RefRangeEnd = 1405599, XrefRangeStart = 1405552, XrefRangeEnd = 1405597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TrySpawnUnit(
      Entity unitPrefab,
      float3 newPosition,
      quaternion newRotation,
      bool guard,
      EntityInput entityInput,
      EntityCommandBuffer spawnCommandBuffer,
      Entity spawner,
      ref GetPlacementResult.JobData getPlacementJobParams,
      EntityManager entityManager,
      SpawnBuffKind spawnBuffKind,
      double spawnTime,
      out Entity newEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) &unitPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &guard;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &entityInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &spawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref getPlacementJobParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnBuffKind;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref newEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_TrySpawnUnit_Private_Static_Boolean_Entity_float3_quaternion_Boolean_EntityInput_EntityCommandBuffer_Entity_byref_JobData_EntityManager_SpawnBuffKind_Double_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitCompositionSpawnerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405599, XrefRangeEnd = 1405744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitCompositionSpawnerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405766, RefRangeEnd = 1405767, XrefRangeStart = 1405744, XrefRangeEnd = 1405766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForResetSpawnersIfOutsideTimeSpan_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForResetSpawnersIfOutsideTimeSpan_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405789, RefRangeEnd = 1405790, XrefRangeStart = 1405767, XrefRangeEnd = 1405789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForResetOncePatrolIfEveryoneDead_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForResetOncePatrolIfEveryoneDead_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405812, RefRangeEnd = 1405813, XrefRangeStart = 1405790, XrefRangeEnd = 1405812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRealizeForceDespawn_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForRealizeForceDespawn_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405838, RefRangeEnd = 1405839, XrefRangeStart = 1405813, XrefRangeEnd = 1405838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDetachUnits_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForDetachUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405861, RefRangeEnd = 1405862, XrefRangeStart = 1405839, XrefRangeEnd = 1405861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForReplaceEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForReplaceEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405887, RefRangeEnd = 1405888, XrefRangeStart = 1405862, XrefRangeEnd = 1405887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemapAndTriggerRespawnForMissingUnits_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForRemapAndTriggerRespawnForMissingUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405922, RefRangeEnd = 1405923, XrefRangeStart = 1405888, XrefRangeEnd = 1405922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawnUnits_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405923, XrefRangeEnd = 1405939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetWasDisabled_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetWasDisabled_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405943, RefRangeEnd = 1405944, XrefRangeStart = 1405939, XrefRangeEnd = 1405943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405948, RefRangeEnd = 1405949, XrefRangeStart = 1405944, XrefRangeEnd = 1405948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405953, RefRangeEnd = 1405954, XrefRangeStart = 1405949, XrefRangeEnd = 1405953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405958, RefRangeEnd = 1405959, XrefRangeStart = 1405954, XrefRangeEnd = 1405958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405963, RefRangeEnd = 1405964, XrefRangeStart = 1405959, XrefRangeEnd = 1405963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405968, RefRangeEnd = 1405969, XrefRangeStart = 1405964, XrefRangeEnd = 1405968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405973, RefRangeEnd = 1405974, XrefRangeStart = 1405969, XrefRangeEnd = 1405973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1405978, RefRangeEnd = 1405979, XrefRangeStart = 1405974, XrefRangeEnd = 1405978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_7()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitCompositionSpawnerSystem()
    {
      Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (UnitCompositionSpawnerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr);
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr__PlayerQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, nameof (_PlayerQuery));
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr__DayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, nameof (_DayNightCycle));
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr__PlacementSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, nameof (_PlacementSystemData));
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr__ReplaceAIQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, nameof (_ReplaceAIQuery));
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetSpawnersIfOutsideTimeSpan_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>ResetSpawnersIfOutsideTimeSpan_entityQuery");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetSpawnersIfOutsideTimeSpan_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>ResetSpawnersIfOutsideTimeSpan_profilerMarker");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetOncePatrolIfEveryoneDead_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>ResetOncePatrolIfEveryoneDead_entityQuery");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetOncePatrolIfEveryoneDead_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>ResetOncePatrolIfEveryoneDead_profilerMarker");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RealizeForceDespawn_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>RealizeForceDespawn_entityQuery");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RealizeForceDespawn_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>RealizeForceDespawn_profilerMarker");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___DetachUnits_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>DetachUnits_entityQuery");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___DetachUnits_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>DetachUnits_profilerMarker");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ReplaceEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>ReplaceEvents_entityQuery");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ReplaceEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>ReplaceEvents_profilerMarker");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RemapAndTriggerRespawnForMissingUnits_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>RemapAndTriggerRespawnForMissingUnits_entityQuery");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RemapAndTriggerRespawnForMissingUnits_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>RemapAndTriggerRespawnForMissingUnits_profilerMarker");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SpawnUnits_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>SpawnUnits_entityQuery");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SpawnUnits_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>SpawnUnits_profilerMarker");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SetWasDisabled_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>SetWasDisabled_entityQuery");
      UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SetWasDisabled_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>SetWasDisabled_profilerMarker");
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667969);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667970);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667971);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_RemoveFollowerModifications_Public_Static_Void_EntityManager_byref_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667972);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_TriggerAllUnitsInactive_Private_Static_Void_EntityManager_EntityCommandBuffer_Entity_byref_UnitCompositionSpawner_byref_Random_DayNightCycle_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667973);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_CheckUnitInactive_Private_Static_Void_EntityManager_byref_UnitCompositionActiveUnit_Boolean_UnitCompositionSpawner_DayNightCycle_byref_Random_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667974);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_GetRandomSpawnDelay_Private_Static_Single_byref_Random_byref_DayNightCycle_byref_UnitCompositionSpawner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667975);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_TrySpawnUnit_Private_Static_Boolean_Entity_float3_quaternion_Boolean_EntityInput_EntityCommandBuffer_Entity_byref_JobData_EntityManager_SpawnBuffKind_Double_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667976);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667977);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667978);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForResetSpawnersIfOutsideTimeSpan_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667979);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForResetOncePatrolIfEveryoneDead_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667980);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForRealizeForceDespawn_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667981);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForDetachUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667982);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForReplaceEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667983);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForRemapAndTriggerRespawnForMissingUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667984);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667985);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetWasDisabled_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667986);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667987);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667988);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667989);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667990);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667991);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667992);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667993);
      UnitCompositionSpawnerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, 100667994);
    }

    public UnitCompositionSpawnerSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _PlayerQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__PlayerQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__PlayerQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<DayNightCycle> _DayNightCycle
    {
      get
      {
        return *(SingletonAccessor<DayNightCycle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__DayNightCycle));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__DayNightCycle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<DayNightCycle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public GetPlacementResult.SystemData _PlacementSystemData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__PlacementSystemData);
        return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__PlacementSystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _ReplaceAIQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__ReplaceAIQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr__ReplaceAIQuery)) = value;
      }
    }

    public unsafe EntityQuery __ResetSpawnersIfOutsideTimeSpan_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetSpawnersIfOutsideTimeSpan_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetSpawnersIfOutsideTimeSpan_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ResetSpawnersIfOutsideTimeSpan_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetSpawnersIfOutsideTimeSpan_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetSpawnersIfOutsideTimeSpan_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ResetOncePatrolIfEveryoneDead_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetOncePatrolIfEveryoneDead_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetOncePatrolIfEveryoneDead_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ResetOncePatrolIfEveryoneDead_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetOncePatrolIfEveryoneDead_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ResetOncePatrolIfEveryoneDead_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RealizeForceDespawn_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RealizeForceDespawn_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RealizeForceDespawn_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RealizeForceDespawn_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RealizeForceDespawn_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RealizeForceDespawn_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __DetachUnits_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___DetachUnits_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___DetachUnits_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DetachUnits_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___DetachUnits_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___DetachUnits_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ReplaceEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ReplaceEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ReplaceEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ReplaceEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ReplaceEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___ReplaceEvents_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RemapAndTriggerRespawnForMissingUnits_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RemapAndTriggerRespawnForMissingUnits_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RemapAndTriggerRespawnForMissingUnits_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemapAndTriggerRespawnForMissingUnits_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RemapAndTriggerRespawnForMissingUnits_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___RemapAndTriggerRespawnForMissingUnits_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SpawnUnits_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SpawnUnits_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SpawnUnits_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnUnits_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SpawnUnits_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SpawnUnits_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SetWasDisabled_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SetWasDisabled_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SetWasDisabled_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetWasDisabled_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SetWasDisabled_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.NativeFieldInfoPtr___SetWasDisabled_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/<>c__DisplayClass9_0")]
    public sealed class __c__DisplayClass9_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayNightCycle;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerTranslations;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_UnitCompositionSpawner_byref_MovePatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        ref UnitCompositionSpawner compositionSpawner,
        ref MovePatrolState movePatrolState,
        [In] ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref movePatrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_UnitCompositionSpawner_byref_MovePatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (prefabLookupMap));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_dayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (dayNightCycle));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (commandBuffer));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (random));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
        UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_playerTranslations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (playerTranslations));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, 100667995);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_UnitCompositionSpawner_byref_MovePatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, 100667996);
      }

      public __c__DisplayClass9_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass9_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, data));
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe DayNightCycle dayNightCycle
      {
        get
        {
          return *(DayNightCycle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_dayNightCycle));
        }
        [param: In] set
        {
          *(DayNightCycle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_dayNightCycle)) = value;
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe Unity.Mathematics.Random random
      {
        get
        {
          return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_random));
        }
        [param: In] set
        {
          *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_random)) = value;
        }
      }

      public unsafe UnitCompositionSpawnerSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (UnitCompositionSpawnerSystem) null : new UnitCompositionSpawnerSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeArray<LocalToWorld> playerTranslations
      {
        get
        {
          return *(NativeArray<LocalToWorld>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_playerTranslations));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_playerTranslations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<LocalToWorld>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/<>c__DisplayClass9_1")]
    public sealed class __c__DisplayClass9_1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffSpawner;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_byref_MovePatrolState_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits,
        ref UnitCompositionSpawner compositionSpawner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits,
        ref UnitCompositionSpawner compositionSpawner,
        ref MovePatrolState movePatrolState)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref activeUnits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref movePatrolState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_byref_MovePatrolState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_1()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass9_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr, nameof (entityManager));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeFieldInfoPtr_buffSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr, nameof (buffSpawner));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr, "CS$<>8__locals1");
        UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr, 100667997);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr, 100667998);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_byref_MovePatrolState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr, 100667999);
      }

      public __c__DisplayClass9_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass9_1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_1>.NativeClassPtr, data));
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe BuffUtility.BuffSpawner buffSpawner
      {
        get
        {
          return *(BuffUtility.BuffSpawner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeFieldInfoPtr_buffSpawner));
        }
        [param: In] set
        {
          *(BuffUtility.BuffSpawner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeFieldInfoPtr_buffSpawner)) = value;
        }
      }

      public UnitCompositionSpawnerSystem.__c__DisplayClass9_0 field_Public___c__DisplayClass9_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0);
          return new UnitCompositionSpawnerSystem.__c__DisplayClass9_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/<>c__DisplayClass9_2")]
    public sealed class __c__DisplayClass9_2 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_detachEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_replaceEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_placementJobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_UnitCompositionGroupEntry_byref_DynamicBuffer_1_UnitCompositionGroupUnitEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_UnitCompositionSpawner_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_2()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        Entity entity,
        ref UnitCompositionSpawner compositionSpawner,
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__5(
        Entity entity,
        ref UnitCompositionSpawner compositionSpawner,
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__6(
        Entity entity,
        ref UnitCompositionSpawner compositionSpawner,
        ref DynamicBuffer<FormationOffsetBuffer> offsets,
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits,
        [In] ref DynamicBuffer<UnitCompositionGroupEntry> compositionGroups,
        [In] ref DynamicBuffer<UnitCompositionGroupUnitEntry> compositionUnits)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref offsets;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionGroups;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_UnitCompositionGroupEntry_byref_DynamicBuffer_1_UnitCompositionGroupUnitEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__7(
        Entity entity,
        ref UnitCompositionSpawner compositionSpawner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_UnitCompositionSpawner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_2()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass9_2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_detachEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, nameof (detachEvents));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, nameof (entityManager));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_replaceEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, nameof (replaceEvents));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, nameof (spawnCommandBuffer));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_placementJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, nameof (placementJobData));
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, "CS$<>8__locals2");
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, 100668000);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, 100668001);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, 100668002);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, 100668003);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_UnitCompositionGroupEntry_byref_DynamicBuffer_1_UnitCompositionGroupUnitEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, 100668004);
        UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_UnitCompositionSpawner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, 100668005);
      }

      public __c__DisplayClass9_2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass9_2()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_2>.NativeClassPtr, data));
      }

      public unsafe NativeArray<DetachEntityFromSpawnerEvent> detachEvents
      {
        get
        {
          return *(NativeArray<DetachEntityFromSpawnerEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_detachEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_detachEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<DetachEntityFromSpawnerEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe NativeArray<ReplaceAIEvent> replaceEvents
      {
        get
        {
          return *(NativeArray<ReplaceAIEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_replaceEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_replaceEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ReplaceAIEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe GetPlacementResult.JobData placementJobData
      {
        get
        {
          return *(GetPlacementResult.JobData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_placementJobData));
        }
        [param: In] set
        {
          *(GetPlacementResult.JobData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_placementJobData)) = value;
        }
      }

      public UnitCompositionSpawnerSystem.__c__DisplayClass9_0 field_Public___c__DisplayClass9_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0);
          return new UnitCompositionSpawnerSystem.__c__DisplayClass9_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionSpawnerSystem.__c__DisplayClass9_2.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass9_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_ResetSpawnersIfOutsideTimeSpan")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ResetSpawnersIfOutsideTimeSpan
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayNightCycle;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(48)]
      public EntityManager entityManager;
      [FieldOffset(56)]
      public DayNightCycle dayNightCycle;
      [FieldOffset(192)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(208)]
      public Unity.Mathematics.Random random;
      [FieldOffset(216)]
      public UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(296)]
      public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404000, XrefRangeEnd = 1404054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits,
        ref UnitCompositionSpawner compositionSpawner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404054, RefRangeEnd = 1404055, XrefRangeStart = 1404054, XrefRangeEnd = 1404054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404055, RefRangeEnd = 1404056, XrefRangeStart = 1404055, XrefRangeEnd = 1404055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404056, XrefRangeEnd = 1404058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404067, RefRangeEnd = 1404068, XrefRangeStart = 1404058, XrefRangeEnd = 1404067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404070, RefRangeEnd = 1404071, XrefRangeStart = 1404068, XrefRangeEnd = 1404070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UnitCompositionSpawnerSystem componentSystem,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404071, XrefRangeEnd = 1404075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404075, XrefRangeEnd = 1404081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ResetSpawnersIfOutsideTimeSpan()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_ResetSpawnersIfOutsideTimeSpan");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, nameof (prefabLookupMap));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, nameof (entityManager));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_dayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, nameof (dayNightCycle));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, nameof (commandBuffer));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, nameof (random));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, nameof (_runtimes));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, 100668006);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, 100668007);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, 100668008);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, 100668009);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, 100668010);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, 100668011);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, 100668012);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, 100668013);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_compositionSpawner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner> forParameter_compositionSpawner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1403916, RefRangeEnd = 1403917, XrefRangeStart = 1403909, XrefRangeEnd = 1403916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UnitCompositionSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1403924, RefRangeEnd = 1403925, XrefRangeStart = 1403917, XrefRangeEnd = 1403924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_compositionSpawner));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders>.NativeClassPtr, 100668014);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders>.NativeClassPtr, 100668015);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_compositionSpawner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner>.Runtime runtime_compositionSpawner;

          static Runtimes()
          {
            Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
            UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_compositionSpawner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_ResetSpawnersIfOutsideTimeSpan/ProjectM.RunWithoutJobSystem_00000B2C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, "RunWithoutJobSystem_00000B2C$PostfixBurstDelegate");
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668016);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668017);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668018);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668019);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_ResetSpawnersIfOutsideTimeSpan/ProjectM.RunWithoutJobSystem_00000B2C$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1403925, XrefRangeEnd = 1403939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1403939, XrefRangeEnd = 1403957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1403957, XrefRangeEnd = 1403972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1403999, RefRangeEnd = 1404000, XrefRangeStart = 1403972, XrefRangeEnd = 1403999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan>.NativeClassPtr, "RunWithoutJobSystem_00000B2C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668020);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668021);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668022);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668023);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668025);
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
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetSpawnersIfOutsideTimeSpan.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_ResetOncePatrolIfEveryoneDead")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ResetOncePatrolIfEveryoneDead
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_UnitCompositionSpawner_byref_MovePatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_0;
      [FieldOffset(32)]
      public UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(136)]
      public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404176, XrefRangeEnd = 1404189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref UnitCompositionSpawner compositionSpawner,
        ref MovePatrolState movePatrolState,
        [In] ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref movePatrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_UnitCompositionSpawner_byref_MovePatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404189, XrefRangeEnd = 1404191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404202, RefRangeEnd = 1404203, XrefRangeStart = 1404191, XrefRangeEnd = 1404202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404207, RefRangeEnd = 1404208, XrefRangeStart = 1404203, XrefRangeEnd = 1404207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UnitCompositionSpawnerSystem componentSystem,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404208, XrefRangeEnd = 1404212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404212, XrefRangeEnd = 1404218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ResetOncePatrolIfEveryoneDead()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_ResetOncePatrolIfEveryoneDead");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_0));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, nameof (_runtimes));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_UnitCompositionSpawner_byref_MovePatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, 100668026);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, 100668027);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, 100668028);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, 100668029);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, 100668030);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, 100668031);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, 100668032);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, 100668033);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_compositionSpawner;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_movePatrolState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner> forParameter_compositionSpawner;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<MovePatrolState> forParameter_movePatrolState;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404090, RefRangeEnd = 1404091, XrefRangeStart = 1404081, XrefRangeEnd = 1404090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UnitCompositionSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404100, RefRangeEnd = 1404101, XrefRangeStart = 1404091, XrefRangeEnd = 1404100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_compositionSpawner));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_movePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_movePatrolState));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders>.NativeClassPtr, 100668034);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders>.NativeClassPtr, 100668035);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_compositionSpawner;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_movePatrolState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner>.Runtime runtime_compositionSpawner;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<MovePatrolState>.Runtime runtime_movePatrolState;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;

          static Runtimes()
          {
            Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_compositionSpawner));
            UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_movePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_movePatrolState));
            UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_ResetOncePatrolIfEveryoneDead/ProjectM.RunWithoutJobSystem_00000B35$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, "RunWithoutJobSystem_00000B35$PostfixBurstDelegate");
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668036);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668037);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668038);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668039);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_ResetOncePatrolIfEveryoneDead/ProjectM.RunWithoutJobSystem_00000B35$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404101, XrefRangeEnd = 1404115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404115, XrefRangeEnd = 1404133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404133, XrefRangeEnd = 1404148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404175, RefRangeEnd = 1404176, XrefRangeStart = 1404148, XrefRangeEnd = 1404175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead>.NativeClassPtr, "RunWithoutJobSystem_00000B35$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668040);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668041);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668042);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668043);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668045);
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
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ResetOncePatrolIfEveryoneDead.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_RealizeForceDespawn")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RealizeForceDespawn
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffSpawner;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayNightCycle;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_byref_MovePatrolState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(48)]
      public EntityManager entityManager;
      [FieldOffset(56)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(72)]
      public BuffUtility.BuffSpawner buffSpawner;
      [FieldOffset(200)]
      public Unity.Mathematics.Random random;
      [FieldOffset(208)]
      public DayNightCycle dayNightCycle;
      [FieldOffset(344)]
      public UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(448)]
      public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404313, XrefRangeEnd = 1404353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits,
        ref UnitCompositionSpawner compositionSpawner,
        ref MovePatrolState movePatrolState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref activeUnits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref movePatrolState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_byref_MovePatrolState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404353, RefRangeEnd = 1404354, XrefRangeStart = 1404353, XrefRangeEnd = 1404353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404354, RefRangeEnd = 1404355, XrefRangeStart = 1404354, XrefRangeEnd = 1404354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404355, XrefRangeEnd = 1404357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404368, RefRangeEnd = 1404369, XrefRangeStart = 1404357, XrefRangeEnd = 1404368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404371, RefRangeEnd = 1404372, XrefRangeStart = 1404369, XrefRangeEnd = 1404371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UnitCompositionSpawnerSystem componentSystem,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404372, XrefRangeEnd = 1404376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404376, XrefRangeEnd = 1404382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RealizeForceDespawn()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_RealizeForceDespawn");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (prefabLookupMap));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (entityManager));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (commandBuffer));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_buffSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (buffSpawner));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (random));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_dayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (dayNightCycle));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (_runtimes));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_UnitCompositionSpawner_byref_MovePatrolState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, 100668046);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, 100668047);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, 100668048);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, 100668049);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, 100668050);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, 100668051);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, 100668052);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, 100668053);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_compositionSpawner;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_movePatrolState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner> forParameter_compositionSpawner;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<MovePatrolState> forParameter_movePatrolState;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404227, RefRangeEnd = 1404228, XrefRangeStart = 1404218, XrefRangeEnd = 1404227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UnitCompositionSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404237, RefRangeEnd = 1404238, XrefRangeStart = 1404228, XrefRangeEnd = 1404237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_compositionSpawner));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_movePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_movePatrolState));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders>.NativeClassPtr, 100668054);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders>.NativeClassPtr, 100668055);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_compositionSpawner;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_movePatrolState;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner>.Runtime runtime_compositionSpawner;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<MovePatrolState>.Runtime runtime_movePatrolState;

          static Runtimes()
          {
            Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
            UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_compositionSpawner));
            UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_movePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_movePatrolState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_RealizeForceDespawn/ProjectM.RunWithoutJobSystem_00000B3E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, "RunWithoutJobSystem_00000B3E$PostfixBurstDelegate");
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668056);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668057);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668058);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668059);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_RealizeForceDespawn/ProjectM.RunWithoutJobSystem_00000B3E$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404238, XrefRangeEnd = 1404252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404252, XrefRangeEnd = 1404270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404270, XrefRangeEnd = 1404285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404312, RefRangeEnd = 1404313, XrefRangeStart = 1404285, XrefRangeEnd = 1404312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn>.NativeClassPtr, "RunWithoutJobSystem_00000B3E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668060);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668061);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668062);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668063);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668065);
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
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RealizeForceDespawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_DetachUnits")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DetachUnits
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_detachEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayNightCycle;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<DetachEntityFromSpawnerEvent> detachEvents;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public DayNightCycle dayNightCycle;
      [FieldOffset(160)]
      public Unity.Mathematics.Random random;
      [FieldOffset(168)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(184)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(232)]
      public UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(312)]
      public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404473, XrefRangeEnd = 1404493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref UnitCompositionSpawner compositionSpawner,
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404493, RefRangeEnd = 1404494, XrefRangeStart = 1404493, XrefRangeEnd = 1404493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404494, RefRangeEnd = 1404495, XrefRangeStart = 1404494, XrefRangeEnd = 1404494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404495, XrefRangeEnd = 1404497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404506, RefRangeEnd = 1404507, XrefRangeStart = 1404497, XrefRangeEnd = 1404506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404509, RefRangeEnd = 1404510, XrefRangeStart = 1404507, XrefRangeEnd = 1404509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UnitCompositionSpawnerSystem componentSystem,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404510, XrefRangeEnd = 1404514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404514, XrefRangeEnd = 1404520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DetachUnits()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_DetachUnits");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_detachEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (detachEvents));
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (entityManager));
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_dayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (dayNightCycle));
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (random));
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (commandBuffer));
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (prefabLookupMap));
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (_runtimes));
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, 100668066);
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, 100668067);
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, 100668068);
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, 100668069);
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, 100668070);
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, 100668071);
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, 100668072);
        UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, 100668073);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_compositionSpawner;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner> forParameter_compositionSpawner;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404389, RefRangeEnd = 1404390, XrefRangeStart = 1404382, XrefRangeEnd = 1404389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UnitCompositionSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404397, RefRangeEnd = 1404398, XrefRangeStart = 1404390, XrefRangeEnd = 1404397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_compositionSpawner));
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders>.NativeClassPtr, 100668074);
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders>.NativeClassPtr, 100668075);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_compositionSpawner;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner>.Runtime runtime_compositionSpawner;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;

          static Runtimes()
          {
            Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_compositionSpawner));
            UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_DetachUnits/ProjectM.RunWithoutJobSystem_00000B47$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, "RunWithoutJobSystem_00000B47$PostfixBurstDelegate");
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668076);
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668077);
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668078);
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668079);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_DetachUnits/ProjectM.RunWithoutJobSystem_00000B47$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404398, XrefRangeEnd = 1404412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404412, XrefRangeEnd = 1404430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404430, XrefRangeEnd = 1404445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404472, RefRangeEnd = 1404473, XrefRangeStart = 1404445, XrefRangeEnd = 1404472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits>.NativeClassPtr, "RunWithoutJobSystem_00000B47$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668080);
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668081);
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668082);
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668083);
          UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668085);
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
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_DetachUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_ReplaceEvents")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ReplaceEvents
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_replaceEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<ReplaceAIEvent> replaceEvents;
      [FieldOffset(16)]
      public UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404603, XrefRangeEnd = 1404616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 999309, RefRangeEnd = 999314, XrefRangeStart = 999309, XrefRangeEnd = 999314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 999314, RefRangeEnd = 999318, XrefRangeStart = 999314, XrefRangeEnd = 999318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404616, XrefRangeEnd = 1404618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404623, RefRangeEnd = 1404624, XrefRangeStart = 1404618, XrefRangeEnd = 1404623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404626, RefRangeEnd = 1404627, XrefRangeStart = 1404624, XrefRangeEnd = 1404626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UnitCompositionSpawnerSystem componentSystem,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404627, XrefRangeEnd = 1404631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404631, XrefRangeEnd = 1404637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ReplaceEvents()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_ReplaceEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeFieldInfoPtr_replaceEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, nameof (replaceEvents));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, nameof (_runtimes));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, 100668086);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, 100668087);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, 100668088);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, 100668089);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, 100668090);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, 100668091);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, 100668092);
        UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, 100668093);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404523, RefRangeEnd = 1404524, XrefRangeStart = 1404520, XrefRangeEnd = 1404523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UnitCompositionSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404527, RefRangeEnd = 1404528, XrefRangeStart = 1404524, XrefRangeEnd = 1404527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders>.NativeClassPtr, 100668094);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders>.NativeClassPtr, 100668095);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;

          static Runtimes()
          {
            Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_ReplaceEvents/ProjectM.RunWithoutJobSystem_00000B50$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, "RunWithoutJobSystem_00000B50$PostfixBurstDelegate");
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668096);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668097);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668098);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668099);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_ReplaceEvents/ProjectM.RunWithoutJobSystem_00000B50$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404528, XrefRangeEnd = 1404542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404542, XrefRangeEnd = 1404560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404560, XrefRangeEnd = 1404575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404602, RefRangeEnd = 1404603, XrefRangeStart = 1404575, XrefRangeEnd = 1404602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents>.NativeClassPtr, "RunWithoutJobSystem_00000B50$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668100);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668101);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668102);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668103);
          UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668105);
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
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_ReplaceEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_RemapAndTriggerRespawnForMissingUnits")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RemapAndTriggerRespawnForMissingUnits
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayNightCycle;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public DayNightCycle dayNightCycle;
      [FieldOffset(144)]
      public Unity.Mathematics.Random random;
      [FieldOffset(152)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(168)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(216)]
      public UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(296)]
      public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404728, XrefRangeEnd = 1404746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref UnitCompositionSpawner compositionSpawner,
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404746, RefRangeEnd = 1404747, XrefRangeStart = 1404746, XrefRangeEnd = 1404746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404747, RefRangeEnd = 1404748, XrefRangeStart = 1404747, XrefRangeEnd = 1404747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404748, XrefRangeEnd = 1404750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404759, RefRangeEnd = 1404760, XrefRangeStart = 1404750, XrefRangeEnd = 1404759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1404762, RefRangeEnd = 1404763, XrefRangeStart = 1404760, XrefRangeEnd = 1404762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UnitCompositionSpawnerSystem componentSystem,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404763, XrefRangeEnd = 1404767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404767, XrefRangeEnd = 1404773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemapAndTriggerRespawnForMissingUnits()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_RemapAndTriggerRespawnForMissingUnits");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, nameof (entityManager));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_dayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, nameof (dayNightCycle));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, nameof (random));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, nameof (commandBuffer));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, nameof (prefabLookupMap));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, nameof (_runtimes));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, 100668106);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, 100668107);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, 100668108);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, 100668109);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, 100668110);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, 100668111);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, 100668112);
        UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, 100668113);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_compositionSpawner;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner> forParameter_compositionSpawner;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404644, RefRangeEnd = 1404645, XrefRangeStart = 1404637, XrefRangeEnd = 1404644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UnitCompositionSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404652, RefRangeEnd = 1404653, XrefRangeStart = 1404645, XrefRangeEnd = 1404652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_compositionSpawner));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders>.NativeClassPtr, 100668114);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders>.NativeClassPtr, 100668115);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_compositionSpawner;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner>.Runtime runtime_compositionSpawner;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;

          static Runtimes()
          {
            Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_compositionSpawner));
            UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_RemapAndTriggerRespawnForMissingUnits/ProjectM.RunWithoutJobSystem_00000B59$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, "RunWithoutJobSystem_00000B59$PostfixBurstDelegate");
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668116);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668117);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668118);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668119);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_RemapAndTriggerRespawnForMissingUnits/ProjectM.RunWithoutJobSystem_00000B59$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404653, XrefRangeEnd = 1404667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404667, XrefRangeEnd = 1404685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404685, XrefRangeEnd = 1404700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404727, RefRangeEnd = 1404728, XrefRangeStart = 1404700, XrefRangeEnd = 1404727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits>.NativeClassPtr, "RunWithoutJobSystem_00000B59$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668120);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668121);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668122);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668123);
          UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668125);
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
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_RemapAndTriggerRespawnForMissingUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_SpawnUnits")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SpawnUnits
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerTranslations;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayNightCycle;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_placementJobData;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_UnitCompositionGroupEntry_byref_DynamicBuffer_1_UnitCompositionGroupUnitEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeArray<LocalToWorld> playerTranslations;
      [FieldOffset(24)]
      public DayNightCycle dayNightCycle;
      [FieldOffset(160)]
      public Unity.Mathematics.Random random;
      [FieldOffset(168)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(184)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(232)]
      public GetPlacementResult.JobData placementJobData;
      [FieldOffset(3936)]
      public ComponentDataFromEntity<EntityInput> _ComponentDataFromEntity_EntityInput_0;
      [FieldOffset(3968)]
      public UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(4168)]
      public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404882, XrefRangeEnd = 1405094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref UnitCompositionSpawner compositionSpawner,
        ref DynamicBuffer<FormationOffsetBuffer> offsets,
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits,
        [In] ref DynamicBuffer<UnitCompositionGroupEntry> compositionGroups,
        [In] ref DynamicBuffer<UnitCompositionGroupUnitEntry> compositionUnits)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref offsets;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionGroups;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_UnitCompositionGroupEntry_byref_DynamicBuffer_1_UnitCompositionGroupUnitEntry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1405095, RefRangeEnd = 1405096, XrefRangeStart = 1405094, XrefRangeEnd = 1405095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1405097, RefRangeEnd = 1405098, XrefRangeStart = 1405096, XrefRangeEnd = 1405097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405098, XrefRangeEnd = 1405100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1405118, RefRangeEnd = 1405119, XrefRangeStart = 1405100, XrefRangeEnd = 1405118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1405124, RefRangeEnd = 1405125, XrefRangeStart = 1405119, XrefRangeEnd = 1405124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UnitCompositionSpawnerSystem componentSystem,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405125, XrefRangeEnd = 1405129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405129, XrefRangeEnd = 1405135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnUnits()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_SpawnUnits");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (entityManager));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_playerTranslations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (playerTranslations));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_dayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (dayNightCycle));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (random));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (spawnCommandBuffer));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (prefabLookupMap));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_placementJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (placementJobData));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityInput_0));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (_runtimes));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_UnitCompositionGroupEntry_byref_DynamicBuffer_1_UnitCompositionGroupUnitEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, 100668126);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, 100668127);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, 100668128);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, 100668129);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, 100668130);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, 100668131);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, 100668132);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, 100668133);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_compositionSpawner;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_offsets;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_compositionGroups;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_compositionUnits;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner> forParameter_compositionSpawner;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<FormationOffsetBuffer> forParameter_offsets;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;
        [FieldOffset(120)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionGroupEntry> forParameter_compositionGroups;
        [FieldOffset(160)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionGroupUnitEntry> forParameter_compositionUnits;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404789, RefRangeEnd = 1404790, XrefRangeStart = 1404773, XrefRangeEnd = 1404789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UnitCompositionSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404806, RefRangeEnd = 1404807, XrefRangeStart = 1404790, XrefRangeEnd = 1404806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_compositionSpawner));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_offsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_offsets));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_compositionGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_compositionGroups));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_compositionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_compositionUnits));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr, 100668134);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr, 100668135);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_compositionSpawner;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_offsets;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_compositionGroups;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_compositionUnits;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner>.Runtime runtime_compositionSpawner;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<FormationOffsetBuffer>.Runtime runtime_offsets;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionGroupEntry>.Runtime runtime_compositionGroups;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionGroupUnitEntry>.Runtime runtime_compositionUnits;

          static Runtimes()
          {
            Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_compositionSpawner));
            UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_offsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_offsets));
            UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
            UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_compositionGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_compositionGroups));
            UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_compositionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_compositionUnits));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_SpawnUnits/ProjectM.RunWithoutJobSystem_00000B62$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, "RunWithoutJobSystem_00000B62$PostfixBurstDelegate");
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668136);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668137);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668138);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668139);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_SpawnUnits/ProjectM.RunWithoutJobSystem_00000B62$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404807, XrefRangeEnd = 1404821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404821, XrefRangeEnd = 1404839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404839, XrefRangeEnd = 1404854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1404881, RefRangeEnd = 1404882, XrefRangeStart = 1404854, XrefRangeEnd = 1404881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits>.NativeClassPtr, "RunWithoutJobSystem_00000B62$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668140);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668141);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668142);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668143);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668145);
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
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SpawnUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_SetWasDisabled")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetWasDisabled
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405220, XrefRangeEnd = 1405223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref UnitCompositionSpawner compositionSpawner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1405223, RefRangeEnd = 1405224, XrefRangeStart = 1405223, XrefRangeEnd = 1405223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1405224, RefRangeEnd = 1405225, XrefRangeStart = 1405224, XrefRangeEnd = 1405224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405225, XrefRangeEnd = 1405227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1405233, RefRangeEnd = 1405234, XrefRangeStart = 1405227, XrefRangeEnd = 1405233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1405236, RefRangeEnd = 1405237, XrefRangeStart = 1405234, XrefRangeEnd = 1405236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UnitCompositionSpawnerSystem componentSystem,
        ref UnitCompositionSpawnerSystem.__c__DisplayClass9_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405237, XrefRangeEnd = 1405241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405241, XrefRangeEnd = 1405247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetWasDisabled()
      {
        Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem>.NativeClassPtr, "<>c__DisplayClass_SetWasDisabled");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, nameof (entityManager));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, nameof (_runtimes));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, 100668146);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, 100668147);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, 100668148);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, 100668149);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, 100668150);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_byref___c__DisplayClass9_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, 100668151);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, 100668152);
        UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, 100668153);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_compositionSpawner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner> forParameter_compositionSpawner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1405139, RefRangeEnd = 1405140, XrefRangeStart = 1405135, XrefRangeEnd = 1405139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UnitCompositionSpawnerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1405144, RefRangeEnd = 1405145, XrefRangeStart = 1405140, XrefRangeEnd = 1405144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_compositionSpawner));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitCompositionSpawnerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders>.NativeClassPtr, 100668154);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders>.NativeClassPtr, 100668155);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_compositionSpawner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner>.Runtime runtime_compositionSpawner;

          static Runtimes()
          {
            Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_compositionSpawner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_SetWasDisabled/ProjectM.RunWithoutJobSystem_00000B6B$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, "RunWithoutJobSystem_00000B6B$PostfixBurstDelegate");
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668156);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668157);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668158);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668159);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UnitCompositionSpawnerSystem/ProjectM.<>c__DisplayClass_SetWasDisabled/ProjectM.RunWithoutJobSystem_00000B6B$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405145, XrefRangeEnd = 1405159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405159, XrefRangeEnd = 1405177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405177, XrefRangeEnd = 1405192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1405219, RefRangeEnd = 1405220, XrefRangeStart = 1405192, XrefRangeEnd = 1405219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled>.NativeClassPtr, "RunWithoutJobSystem_00000B6B$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668160);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668161);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668162);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668163);
          UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668165);
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
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UnitCompositionSpawnerSystem.__c__DisplayClass_SetWasDisabled.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
