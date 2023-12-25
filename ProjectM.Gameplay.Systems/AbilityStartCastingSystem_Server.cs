// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityStartCastingSystem_Server
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Physics;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class AbilityStartCastingSystem_Server : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityGroupComboActiveToAdd;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentCastsSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProgressionDependencySystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__CheckerFactory;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQueries;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr__DamageTakenEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConsumablesToRemove;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInterrupt_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_EntityInput_byref_BuffableFlagState_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCasts_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartNewCasts_Private_Static_Boolean_Entity_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_EntityInput_byref_UnitStats_byref_BuffableFlagState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GotSpellBlocked_Private_Static_Boolean_Entity_byref_Input_byref_AbilityBar_Server_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Interrupt_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Casted_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GiveGlobalCooldown_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GiveCooldown_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCooldownModifier_Private_Static_Single_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCombo_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCharges_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEnergyDrain_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDurability_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnPrefabOnCast_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GiveProgressionOnCast_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeItemOnCast_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370787, XrefRangeEnd = 1370847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStartCastingSystem_Server.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370847, XrefRangeEnd = 1370866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStartCastingSystem_Server.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370866, XrefRangeEnd = 1370967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStartCastingSystem_Server.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1371217, RefRangeEnd = 1371218, XrefRangeStart = 1370967, XrefRangeEnd = 1371217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateInterrupt(
      Entity character,
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      ref AbilityBar_Server abilityBarServer,
      [In] ref EntityInput entityInput,
      [In] ref BuffableFlagState buffableFlagState,
      [In] ref DynamicBuffer<AbilityGroupSlotBuffer> abilityGroupSlots,
      bool isDead)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupSlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &isDead;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateInterrupt_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_EntityInput_byref_BuffableFlagState_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1371227, RefRangeEnd = 1371228, XrefRangeStart = 1371218, XrefRangeEnd = 1371227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateCasts(
      Entity character,
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      ref AbilityBar_Server abilityBarServer,
      [In] ref DynamicBuffer<AbilityGroupSlotBuffer> abilityGroupSlots)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupSlots;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateCasts_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1371509, RefRangeEnd = 1371510, XrefRangeStart = 1371228, XrefRangeEnd = 1371509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool StartNewCasts(
      Entity character,
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      ref AbilityBar_Server abilityBarServer,
      [In] ref DynamicBuffer<AbilityGroupSlotBuffer> abilityGroupSlots,
      [In] ref EntityInput entityInput,
      [In] ref UnitStats unitStats,
      [In] ref BuffableFlagState buffableFlagState)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupSlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref unitStats;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_StartNewCasts_Private_Static_Boolean_Entity_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_EntityInput_byref_UnitStats_byref_BuffableFlagState_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1371531, RefRangeEnd = 1371533, XrefRangeStart = 1371510, XrefRangeEnd = 1371531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GotSpellBlocked(
      Entity character,
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Server abilityBarServer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarServer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_GotSpellBlocked_Private_Static_Boolean_Entity_byref_Input_byref_AbilityBar_Server_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1371550, RefRangeEnd = 1371560, XrefRangeStart = 1371533, XrefRangeEnd = 1371550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Interrupt(
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      ref AbilityBar_Server abilityBarServer,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_Interrupt_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1371605, RefRangeEnd = 1371606, XrefRangeStart = 1371560, XrefRangeEnd = 1371605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Casted(
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      [In] ref DynamicBuffer<AbilityGroupSlotBuffer> abilityGroupSlots,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupSlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_Casted_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1371614, RefRangeEnd = 1371616, XrefRangeStart = 1371606, XrefRangeEnd = 1371614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GiveGlobalCooldown(
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_GiveGlobalCooldown_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1371682, RefRangeEnd = 1371683, XrefRangeStart = 1371616, XrefRangeEnd = 1371682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GiveCooldown(
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      [In] ref DynamicBuffer<AbilityGroupSlotBuffer> abilityGroupSlots,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupSlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_GiveCooldown_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1371689, RefRangeEnd = 1371692, XrefRangeStart = 1371683, XrefRangeEnd = 1371689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetCooldownModifier(
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      [In] ref DynamicBuffer<AbilityGroupSlotBuffer> abilityGroupSlots,
      Entity castGroup,
      bool ignoreCooldownModifier)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupSlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &castGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreCooldownModifier;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_GetCooldownModifier_Private_Static_Single_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371692, XrefRangeEnd = 1371698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateCombo(
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateCombo_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371698, XrefRangeEnd = 1371709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateCharges(
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      [In] ref DynamicBuffer<AbilityGroupSlotBuffer> abilityGroupSlots)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroupSlots;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateCharges_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371709, XrefRangeEnd = 1371718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateEnergyDrain(
      Entity character,
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateEnergyDrain_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1371744, RefRangeEnd = 1371745, XrefRangeStart = 1371718, XrefRangeEnd = 1371744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateDurability(
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateDurability_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1371849, RefRangeEnd = 1371850, XrefRangeStart = 1371745, XrefRangeEnd = 1371849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SpawnPrefabOnCast(
      Entity character,
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_SpawnPrefabOnCast_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1371892, RefRangeEnd = 1371893, XrefRangeStart = 1371850, XrefRangeEnd = 1371892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GiveProgressionOnCast(
      Entity character,
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      ref bool shouldConsumeItem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref shouldConsumeItem;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_GiveProgressionOnCast_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371893, XrefRangeEnd = 1371907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ConsumeItemOnCast(
      Entity character,
      ref AbilityStartCastingSystem_Server.Input input,
      ref AbilityBar_Shared abilityBarShared,
      ref bool shouldConsumeItem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref shouldConsumeItem;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_ConsumeItemOnCast_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityStartCastingSystem_Server()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371907, XrefRangeEnd = 1371925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStartCastingSystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1371956, RefRangeEnd = 1371957, XrefRangeStart = 1371925, XrefRangeEnd = 1371956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1371961, RefRangeEnd = 1371962, XrefRangeStart = 1371957, XrefRangeEnd = 1371961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityStartCastingSystem_Server()
    {
      Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityStartCastingSystem_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr);
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__AbilityGroupComboActiveToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_AbilityGroupComboActiveToAdd));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__CurrentCastsSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_CurrentCastsSystem));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_GameDataSystem));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ProgressionDependencySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_ProgressionDependencySystem));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_CollisionSystem));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__CheckerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_CheckerFactory));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_ServerTimeAccessor));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_ServerDebugSettings));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_WorldFrame));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__EventQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_EventQueries));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__EventPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_EventPrefabs));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__DamageTakenEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_DamageTakenEventQuery));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ConsumablesToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (_ConsumablesToRemove));
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      AbilityStartCastingSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664349);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664350);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664351);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateInterrupt_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_EntityInput_byref_BuffableFlagState_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664352);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateCasts_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664353);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_StartNewCasts_Private_Static_Boolean_Entity_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_EntityInput_byref_UnitStats_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664354);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_GotSpellBlocked_Private_Static_Boolean_Entity_byref_Input_byref_AbilityBar_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664355);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_Interrupt_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_AbilityBar_Server_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664356);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_Casted_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664357);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_GiveGlobalCooldown_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664358);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_GiveCooldown_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664359);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_GetCooldownModifier_Private_Static_Single_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664360);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateCombo_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664361);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateCharges_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664362);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateEnergyDrain_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664363);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_UpdateDurability_Private_Static_Void_byref_Input_byref_AbilityBar_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664364);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_SpawnPrefabOnCast_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664365);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_GiveProgressionOnCast_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664366);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_ConsumeItemOnCast_Private_Static_Void_Entity_byref_Input_byref_AbilityBar_Shared_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664367);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664368);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664369);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664370);
      AbilityStartCastingSystem_Server.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, 100664371);
    }

    public AbilityStartCastingSystem_Server(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<Entity> _AbilityGroupComboActiveToAdd
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__AbilityGroupComboActiveToAdd));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__AbilityGroupComboActiveToAdd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CurrentCastsSystem _CurrentCastsSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__CurrentCastsSystem));
        return pointer == System.IntPtr.Zero ? (CurrentCastsSystem) null : new CurrentCastsSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__CurrentCastsSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ProgressionDependencySystem));
        return pointer == System.IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ProgressionDependencySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ConditionCheckerFactory _CheckerFactory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__CheckerFactory));
        return pointer == System.IntPtr.Zero ? (ConditionCheckerFactory) null : new ConditionCheckerFactory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__CheckerFactory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EventQueries _EventQueries
    {
      get
      {
        return *(EventQueries*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__EventQueries));
      }
      [param: In] set
      {
        *(EventQueries*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__EventQueries)) = value;
      }
    }

    public unsafe EventPrefabs _EventPrefabs
    {
      get
      {
        return *(EventPrefabs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__EventPrefabs));
      }
      [param: In] set
      {
        *(EventPrefabs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__EventPrefabs)) = value;
      }
    }

    public unsafe EntityQuery _DamageTakenEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__DamageTakenEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__DamageTakenEventQuery)) = value;
      }
    }

    public unsafe NativeList<AbilityStartCastingSystem_Server.ConsumableToRemove> _ConsumablesToRemove
    {
      get
      {
        return *(NativeList<AbilityStartCastingSystem_Server.ConsumableToRemove>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ConsumablesToRemove));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr__ConsumablesToRemove), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<AbilityStartCastingSystem_Server.ConsumableToRemove>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStartCastingSystem_Server.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ConsumableToRemove
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Character;
      private static readonly System.IntPtr NativeFieldInfoPtr_ConsumableItem;
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntity;
      [FieldOffset(0)]
      public Entity Character;
      [FieldOffset(8)]
      public PrefabGUID ConsumableItem;
      [FieldOffset(12)]
      public ItemType ItemType;
      [FieldOffset(16)]
      public Entity ItemEntity;

      static ConsumableToRemove()
      {
        Il2CppClassPointerStore<AbilityStartCastingSystem_Server.ConsumableToRemove>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (ConsumableToRemove));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.ConsumableToRemove>.NativeClassPtr);
        AbilityStartCastingSystem_Server.ConsumableToRemove.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.ConsumableToRemove>.NativeClassPtr, nameof (Character));
        AbilityStartCastingSystem_Server.ConsumableToRemove.NativeFieldInfoPtr_ConsumableItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.ConsumableToRemove>.NativeClassPtr, nameof (ConsumableItem));
        AbilityStartCastingSystem_Server.ConsumableToRemove.NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.ConsumableToRemove>.NativeClassPtr, nameof (ItemType));
        AbilityStartCastingSystem_Server.ConsumableToRemove.NativeFieldInfoPtr_ItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.ConsumableToRemove>.NativeClassPtr, nameof (ItemEntity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.ConsumableToRemove>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Input
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGetters;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_EventPrefabs;
      private static readonly System.IntPtr NativeFieldInfoPtr_DebugData;
      private static readonly System.IntPtr NativeFieldInfoPtr_DisableCooldowns;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupComboActiveToAdd;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageTakeEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffSpawner;
      private static readonly System.IntPtr NativeFieldInfoPtr_SctPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_AlreadyLearnedTextKey;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionJobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_ConsumablesToRemove;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCasts;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedSequencePrefabEntity;
      [FieldOffset(0)]
      public int CurrentFrame;
      [FieldOffset(8)]
      public AbilityGetters AbilityGetters;
      [FieldOffset(2880)]
      public double ServerTime;
      [FieldOffset(2888)]
      public PrefabLookupMap PrefabLookupMap;
      [FieldOffset(2936)]
      public CollisionWorld CollisionWorld;
      [FieldOffset(3280)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(3296)]
      public EventPrefabs EventPrefabs;
      [FieldOffset(3352)]
      public DebugData DebugData;
      [FieldOffset(3360)]
      public bool DisableCooldowns;
      [FieldOffset(3368)]
      public NativeList<Entity> AbilityGroupComboActiveToAdd;
      [FieldOffset(3384)]
      public EntityManager EntityManager;
      [FieldOffset(3392)]
      public NativeArray<DamageTakenEvent> DamageTakeEvents;
      [FieldOffset(3408)]
      public BuffUtility.BuffSpawner BuffSpawner;
      [FieldOffset(3536)]
      public Entity SctPrefab;
      [FieldOffset(3544)]
      public AssetGuid AlreadyLearnedTextKey;
      [FieldOffset(3560)]
      public ProgressionUtility.UpdateUnlockedJobData ProgressionJobData;
      [FieldOffset(4280)]
      public NativeList<AbilityStartCastingSystem_Server.ConsumableToRemove> ConsumablesToRemove;
      [FieldOffset(4296)]
      public NativeList<AbilityIsCastingState> CurrentCasts;
      [FieldOffset(4312)]
      public Entity NetworkedSequencePrefabEntity;

      static Input()
      {
        Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, nameof (Input));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr);
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (CurrentFrame));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_AbilityGetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (AbilityGetters));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (ServerTime));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (PrefabLookupMap));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (CollisionWorld));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (CommandBuffer));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_EventPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (EventPrefabs));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_DebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (DebugData));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_DisableCooldowns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (DisableCooldowns));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_AbilityGroupComboActiveToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (AbilityGroupComboActiveToAdd));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (EntityManager));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_DamageTakeEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (DamageTakeEvents));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_BuffSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (BuffSpawner));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_SctPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (SctPrefab));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_AlreadyLearnedTextKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (AlreadyLearnedTextKey));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_ProgressionJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (ProgressionJobData));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_ConsumablesToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (ConsumablesToRemove));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_CurrentCasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (CurrentCasts));
        AbilityStartCastingSystem_Server.Input.NativeFieldInfoPtr_NetworkedSequencePrefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, nameof (NetworkedSequencePrefabEntity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.Input>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AbilityStartCastingSystem_Server/<>c__DisplayClass19_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass19_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_input;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_EntityInput_byref_UnitStats_byref_BuffableFlagState_0;
      [FieldOffset(0)]
      public AbilityStartCastingSystem_Server.Input input;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass19_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity character,
        ref AbilityBar_Shared abilityBarShared,
        ref AbilityBar_Server abilityBarServer,
        [In] ref DynamicBuffer<AbilityGroupSlotBuffer> abilityGroups,
        [In] ref EntityInput entityInput,
        [In] ref UnitStats unitStats,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &character;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroups;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref unitStats;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass19_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_EntityInput_byref_UnitStats_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass19_0()
      {
        Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, "<>c__DisplayClass19_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass19_0>.NativeClassPtr);
        AbilityStartCastingSystem_Server.__c__DisplayClass19_0.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass19_0>.NativeClassPtr, nameof (input));
        AbilityStartCastingSystem_Server.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass19_0>.NativeClassPtr, 100664372);
        AbilityStartCastingSystem_Server.__c__DisplayClass19_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_EntityInput_byref_UnitStats_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass19_0>.NativeClassPtr, 100664373);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass19_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AbilityStartCastingSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_input;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_EntityInput_byref_UnitStats_byref_BuffableFlagState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStartCastingSystem_Server_byref___c__DisplayClass19_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public AbilityStartCastingSystem_Server.Input input;
      [FieldOffset(4320)]
      public AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(4528)]
      public unsafe AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370736, XrefRangeEnd = 1370742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity character,
        ref AbilityBar_Shared abilityBarShared,
        ref AbilityBar_Server abilityBarServer,
        [In] ref DynamicBuffer<AbilityGroupSlotBuffer> abilityGroups,
        [In] ref EntityInput entityInput,
        [In] ref UnitStats unitStats,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &character;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBarServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityGroups;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref unitStats;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_EntityInput_byref_UnitStats_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1370745, RefRangeEnd = 1370746, XrefRangeStart = 1370742, XrefRangeEnd = 1370745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityStartCastingSystem_Server.__c__DisplayClass19_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1370749, RefRangeEnd = 1370750, XrefRangeStart = 1370746, XrefRangeEnd = 1370749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityStartCastingSystem_Server.__c__DisplayClass19_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370750, XrefRangeEnd = 1370752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1370773, RefRangeEnd = 1370774, XrefRangeStart = 1370752, XrefRangeEnd = 1370773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1370776, RefRangeEnd = 1370777, XrefRangeStart = 1370774, XrefRangeEnd = 1370776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityStartCastingSystem_Server componentSystem,
        ref AbilityStartCastingSystem_Server.__c__DisplayClass19_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStartCastingSystem_Server_byref___c__DisplayClass19_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370777, XrefRangeEnd = 1370781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370781, XrefRangeEnd = 1370787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStartCastingSystem_Server>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (input));
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityBar_Shared_byref_AbilityBar_Server_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_byref_EntityInput_byref_UnitStats_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664374);
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664375);
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664376);
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664377);
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664378);
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStartCastingSystem_Server_byref___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664379);
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664380);
        AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664381);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_character;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_abilityBarShared;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_abilityBarServer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_abilityGroups;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityInput;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_unitStats;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffableFlagState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStartCastingSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_character;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AbilityBar_Shared> forParameter_abilityBarShared;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<AbilityBar_Server> forParameter_abilityBarServer;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_DynamicBuffer<AbilityGroupSlotBuffer> forParameter_abilityGroups;
        [FieldOffset(112)]
        public LambdaParameterValueProvider_IComponentData<EntityInput> forParameter_entityInput;
        [FieldOffset(144)]
        public LambdaParameterValueProvider_IComponentData<UnitStats> forParameter_unitStats;
        [FieldOffset(176)]
        public LambdaParameterValueProvider_IComponentData<BuffableFlagState> forParameter_buffableFlagState;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1370640, RefRangeEnd = 1370641, XrefRangeStart = 1370621, XrefRangeEnd = 1370640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AbilityStartCastingSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStartCastingSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1370660, RefRangeEnd = 1370661, XrefRangeStart = 1370641, XrefRangeEnd = 1370660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_character));
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_abilityBarShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_abilityBarShared));
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_abilityBarServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_abilityBarServer));
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_abilityGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_abilityGroups));
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityInput));
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_unitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_unitStats));
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffableFlagState));
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStartCastingSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664382);
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664383);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_character;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_abilityBarShared;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_abilityBarServer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_abilityGroups;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityInput;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_unitStats;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffableFlagState;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_character;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AbilityBar_Shared>.Runtime runtime_abilityBarShared;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<AbilityBar_Server>.Runtime runtime_abilityBarServer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_DynamicBuffer<AbilityGroupSlotBuffer>.Runtime runtime_abilityGroups;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_IComponentData<EntityInput>.Runtime runtime_entityInput;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_IComponentData<UnitStats>.Runtime runtime_unitStats;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<BuffableFlagState>.Runtime runtime_buffableFlagState;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_character));
            AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_abilityBarShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_abilityBarShared));
            AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_abilityBarServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_abilityBarServer));
            AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_abilityGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_abilityGroups));
            AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityInput));
            AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_unitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_unitStats));
            AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffableFlagState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityStartCastingSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_0000028B$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000028B$PostfixBurstDelegate");
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664384);
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664385);
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664386);
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664387);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityStartCastingSystem_Server/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_0000028B$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370661, XrefRangeEnd = 1370675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370675, XrefRangeEnd = 1370693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370693, XrefRangeEnd = 1370708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1370735, RefRangeEnd = 1370736, XrefRangeStart = 1370708, XrefRangeEnd = 1370735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000028B$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664388);
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664389);
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664390);
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664391);
          AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664393);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityStartCastingSystem_Server.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
