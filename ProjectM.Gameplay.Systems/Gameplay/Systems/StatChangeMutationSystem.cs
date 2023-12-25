// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.StatChangeMutationSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Scripting;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class StatChangeMutationSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ScriptMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerGameBalanceSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ListenersToCall;
    private static readonly System.IntPtr NativeFieldInfoPtr__ListenerMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__Random;
    private static readonly System.IntPtr NativeFieldInfoPtr__StatChangeEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__WeakenBuffAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__EmpowerBuffAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__FortifyBuffAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__BlockHealBuffAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__AmplifyBuffAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbsorbBuffAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__RegisterListenerQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnregisterListenerQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NullifyDamageQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__FirstStrikeQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__IncreaseMountAttackQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindListeners_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CallScriptCallbacks_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CallScriptCallbacks_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyNullifyDamageJob_0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyNullifyDamageJob_0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyNullifyDamageJob_1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyNullifyDamageJob_1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyWeakenJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyWeakenJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyFortifyJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyFortifyJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyServerSettingDamageRecieveOnPlayers_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyServerSettingDamageRecieveOnPlayers_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyAbsorbJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyAbsorbJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyAmplifyJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyAmplifyJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyBlockHealJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyBlockHealJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyCriticalStrikeJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyCriticalStrikeJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyEmpowerJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyEmpowerJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyFirstStrikeJob_0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyFirstStrikeJob_0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyFirstStrikeJob_1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyFirstStrikeJob_1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyInvulnerableJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ApplyInvulnerableJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_28;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallScriptCallbacks_Internal_Void_EntityCommandBuffer_NativeArray_1_StatChangeEvent_NativeArray_1_Entity_StatChangeListenerLocation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterOrUnregisterListeners_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckIncoming_Private_Static_Void_byref_ListenerCommonInput_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckOutgoing_Private_Static_Void_byref_ListenerCommonInput_Entity_Entity_Entity_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyNullifyDamage_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyWeaken_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyFortify_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyServerSettingDamageRecieveOnPlayers_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAbsorbBuffConsumed_Private_Static_Boolean_byref_AbsorbBuff_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAbsorb_Private_Void_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAmplify_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBlockHeal_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyCriticalStrike_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEmpower_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyFirstStrikeDamage_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyIncreaseMountAttack_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyInvulnerable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ApplyInvulnerable_b__44_0_Private_Void_byref_StatChangeEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCallScriptCallbacks_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyNullifyDamageJob_0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyNullifyDamageJob_1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyWeakenJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyFortifyJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyServerSettingDamageRecieveOnPlayers_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyAbsorbJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyAmplifyJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyBlockHealJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyCriticalStrikeJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyEmpowerJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyFirstStrikeJob_0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyFirstStrikeJob_1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyIncreaseMountAttackJob_0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyIncreaseMountAttackJob_1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForApplyInvulnerableJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
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
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_10;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_11;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_12;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_13;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_14;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_15;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462956, XrefRangeEnd = 1463031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatChangeMutationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1463031, XrefRangeEnd = 1463042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatChangeMutationSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1463042, XrefRangeEnd = 1463061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatChangeMutationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1463112, RefRangeEnd = 1463115, XrefRangeStart = 1463061, XrefRangeEnd = 1463112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallScriptCallbacks(
      EntityCommandBuffer commandBuffer,
      NativeArray<StatChangeEvent> statChanges,
      NativeArray<Entity> statChangeEntities,
      StatChangeListenerLocation location)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statChanges;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &statChangeEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &location;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_CallScriptCallbacks_Internal_Void_EntityCommandBuffer_NativeArray_1_StatChangeEvent_NativeArray_1_Entity_StatChangeListenerLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463163, RefRangeEnd = 1463164, XrefRangeStart = 1463115, XrefRangeEnd = 1463163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterOrUnregisterListeners()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_RegisterOrUnregisterListeners_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463193, RefRangeEnd = 1463194, XrefRangeStart = 1463164, XrefRangeEnd = 1463193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckIncoming(
      ref StatChangeMutationSystem.ListenerCommonInput input,
      Entity changeEntity,
      Entity statChangeEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &changeEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &statChangeEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_CheckIncoming_Private_Static_Void_byref_ListenerCommonInput_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1463230, RefRangeEnd = 1463232, XrefRangeStart = 1463194, XrefRangeEnd = 1463230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckOutgoing(
      ref StatChangeMutationSystem.ListenerCommonInput input,
      Entity changeSource,
      Entity changeEntity,
      Entity statChangeEntity,
      NativeList<Entity> listenersCalled)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &changeSource;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &changeEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &statChangeEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &listenersCalled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_CheckOutgoing_Private_Static_Void_byref_ListenerCommonInput_Entity_Entity_Entity_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463272, RefRangeEnd = 1463273, XrefRangeStart = 1463232, XrefRangeEnd = 1463272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyNullifyDamage()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyNullifyDamage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463291, RefRangeEnd = 1463292, XrefRangeStart = 1463273, XrefRangeEnd = 1463291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyWeaken()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyWeaken_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463309, RefRangeEnd = 1463310, XrefRangeStart = 1463292, XrefRangeEnd = 1463309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyFortify()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyFortify_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463327, RefRangeEnd = 1463328, XrefRangeStart = 1463310, XrefRangeEnd = 1463327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyServerSettingDamageRecieveOnPlayers()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyServerSettingDamageRecieveOnPlayers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1463328, RefRangeEnd = 1463330, XrefRangeStart = 1463328, XrefRangeEnd = 1463328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAbsorbBuffConsumed([In] ref AbsorbBuff buff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref buff;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_IsAbsorbBuffConsumed_Private_Static_Boolean_byref_AbsorbBuff_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463393, RefRangeEnd = 1463394, XrefRangeStart = 1463330, XrefRangeEnd = 1463393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyAbsorb(EntityCommandBuffer commandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyAbsorb_Private_Void_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463411, RefRangeEnd = 1463412, XrefRangeStart = 1463394, XrefRangeEnd = 1463411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyAmplify()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyAmplify_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463429, RefRangeEnd = 1463430, XrefRangeStart = 1463412, XrefRangeEnd = 1463429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyBlockHeal()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyBlockHeal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463445, RefRangeEnd = 1463446, XrefRangeStart = 1463430, XrefRangeEnd = 1463445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyCriticalStrike()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyCriticalStrike_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463464, RefRangeEnd = 1463465, XrefRangeStart = 1463446, XrefRangeEnd = 1463464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyEmpower()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyEmpower_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463501, RefRangeEnd = 1463502, XrefRangeStart = 1463465, XrefRangeEnd = 1463501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyFirstStrikeDamage()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyFirstStrikeDamage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463542, RefRangeEnd = 1463543, XrefRangeStart = 1463502, XrefRangeEnd = 1463542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyIncreaseMountAttack()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyIncreaseMountAttack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1463556, RefRangeEnd = 1463557, XrefRangeStart = 1463543, XrefRangeEnd = 1463556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyInvulnerable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_ApplyInvulnerable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatChangeMutationSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _ApplyInvulnerable_b__44_0(ref StatChangeEvent statChangeEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref statChangeEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr__ApplyInvulnerable_b__44_0_Private_Void_byref_StatChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1463557, XrefRangeEnd = 1464086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatChangeMutationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464086, XrefRangeEnd = 1464105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCallScriptCallbacks_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForCallScriptCallbacks_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464105, XrefRangeEnd = 1464124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyNullifyDamageJob_0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyNullifyDamageJob_0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464124, XrefRangeEnd = 1464140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyNullifyDamageJob_1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyNullifyDamageJob_1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464140, XrefRangeEnd = 1464156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyWeakenJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyWeakenJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464156, XrefRangeEnd = 1464172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyFortifyJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyFortifyJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464172, XrefRangeEnd = 1464188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyServerSettingDamageRecieveOnPlayers_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyServerSettingDamageRecieveOnPlayers_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464188, XrefRangeEnd = 1464204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyAbsorbJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyAbsorbJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464204, XrefRangeEnd = 1464220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyAmplifyJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyAmplifyJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464220, XrefRangeEnd = 1464236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyBlockHealJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyBlockHealJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464236, XrefRangeEnd = 1464252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyCriticalStrikeJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyCriticalStrikeJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464252, XrefRangeEnd = 1464268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyEmpowerJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyEmpowerJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464268, XrefRangeEnd = 1464287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyFirstStrikeJob_0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyFirstStrikeJob_0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464287, XrefRangeEnd = 1464303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyFirstStrikeJob_1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyFirstStrikeJob_1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464303, XrefRangeEnd = 1464322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyIncreaseMountAttackJob_0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyIncreaseMountAttackJob_0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464322, XrefRangeEnd = 1464338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyIncreaseMountAttackJob_1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyIncreaseMountAttackJob_1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464338, XrefRangeEnd = 1464354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForApplyInvulnerableJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyInvulnerableJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464358, RefRangeEnd = 1464359, XrefRangeStart = 1464354, XrefRangeEnd = 1464358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464363, RefRangeEnd = 1464364, XrefRangeStart = 1464359, XrefRangeEnd = 1464363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464368, RefRangeEnd = 1464369, XrefRangeStart = 1464364, XrefRangeEnd = 1464368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464373, RefRangeEnd = 1464374, XrefRangeStart = 1464369, XrefRangeEnd = 1464373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464378, RefRangeEnd = 1464379, XrefRangeStart = 1464374, XrefRangeEnd = 1464378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464383, RefRangeEnd = 1464384, XrefRangeStart = 1464379, XrefRangeEnd = 1464383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464388, RefRangeEnd = 1464389, XrefRangeStart = 1464384, XrefRangeEnd = 1464388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464393, RefRangeEnd = 1464394, XrefRangeStart = 1464389, XrefRangeEnd = 1464393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_7()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464398, RefRangeEnd = 1464399, XrefRangeStart = 1464394, XrefRangeEnd = 1464398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_8()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_8, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464403, RefRangeEnd = 1464404, XrefRangeStart = 1464399, XrefRangeEnd = 1464403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_9()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_9, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464408, RefRangeEnd = 1464409, XrefRangeStart = 1464404, XrefRangeEnd = 1464408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_10()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_10, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464413, RefRangeEnd = 1464414, XrefRangeStart = 1464409, XrefRangeEnd = 1464413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_11()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_11, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464418, RefRangeEnd = 1464419, XrefRangeStart = 1464414, XrefRangeEnd = 1464418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_12()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_12, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464423, RefRangeEnd = 1464424, XrefRangeStart = 1464419, XrefRangeEnd = 1464423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_13()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_13, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464428, RefRangeEnd = 1464429, XrefRangeStart = 1464424, XrefRangeEnd = 1464428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_14()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_14, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1464433, RefRangeEnd = 1464434, XrefRangeStart = 1464429, XrefRangeEnd = 1464433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_15()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_15, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StatChangeMutationSystem()
    {
      Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (StatChangeMutationSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr);
      StatChangeMutationSystem.NativeFieldInfoPtr__ScriptMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_ScriptMapper));
      StatChangeMutationSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      StatChangeMutationSystem.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_DestroyBarrier));
      StatChangeMutationSystem.NativeFieldInfoPtr__ServerGameBalanceSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_ServerGameBalanceSettingsAccessor));
      StatChangeMutationSystem.NativeFieldInfoPtr__ListenersToCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_ListenersToCall));
      StatChangeMutationSystem.NativeFieldInfoPtr__ListenerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_ListenerMap));
      StatChangeMutationSystem.NativeFieldInfoPtr__Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_Random));
      StatChangeMutationSystem.NativeFieldInfoPtr__StatChangeEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_StatChangeEventQuery));
      StatChangeMutationSystem.NativeFieldInfoPtr__WeakenBuffAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_WeakenBuffAccessor));
      StatChangeMutationSystem.NativeFieldInfoPtr__EmpowerBuffAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_EmpowerBuffAccessor));
      StatChangeMutationSystem.NativeFieldInfoPtr__FortifyBuffAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_FortifyBuffAccessor));
      StatChangeMutationSystem.NativeFieldInfoPtr__BlockHealBuffAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_BlockHealBuffAccessor));
      StatChangeMutationSystem.NativeFieldInfoPtr__AmplifyBuffAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_AmplifyBuffAccessor));
      StatChangeMutationSystem.NativeFieldInfoPtr__AbsorbBuffAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_AbsorbBuffAccessor));
      StatChangeMutationSystem.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      StatChangeMutationSystem.NativeFieldInfoPtr__RegisterListenerQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_RegisterListenerQuery));
      StatChangeMutationSystem.NativeFieldInfoPtr__UnregisterListenerQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_UnregisterListenerQuery));
      StatChangeMutationSystem.NativeFieldInfoPtr__NullifyDamageQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_NullifyDamageQuery));
      StatChangeMutationSystem.NativeFieldInfoPtr__FirstStrikeQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_FirstStrikeQuery));
      StatChangeMutationSystem.NativeFieldInfoPtr__IncreaseMountAttackQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_IncreaseMountAttackQuery));
      StatChangeMutationSystem.NativeFieldInfoPtr___FindListeners_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>FindListeners_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___CallScriptCallbacks_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>CallScriptCallbacks_LambdaJob1_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___CallScriptCallbacks_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>CallScriptCallbacks_LambdaJob1_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyNullifyDamageJob_0_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyNullifyDamageJob_0_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyNullifyDamageJob_1_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyNullifyDamageJob_1_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyWeakenJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyWeakenJob_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyWeakenJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyWeakenJob_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFortifyJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyFortifyJob_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFortifyJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyFortifyJob_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyServerSettingDamageRecieveOnPlayers_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyServerSettingDamageRecieveOnPlayers_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyServerSettingDamageRecieveOnPlayers_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyServerSettingDamageRecieveOnPlayers_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAbsorbJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyAbsorbJob_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAbsorbJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyAbsorbJob_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAmplifyJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyAmplifyJob_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAmplifyJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyAmplifyJob_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyBlockHealJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyBlockHealJob_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyBlockHealJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyBlockHealJob_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyCriticalStrikeJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyCriticalStrikeJob_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyCriticalStrikeJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyCriticalStrikeJob_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyEmpowerJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyEmpowerJob_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyEmpowerJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyEmpowerJob_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyFirstStrikeJob_0_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyFirstStrikeJob_0_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyFirstStrikeJob_1_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyFirstStrikeJob_1_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyIncreaseMountAttackJob_0_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyIncreaseMountAttackJob_0_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyIncreaseMountAttackJob_1_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyIncreaseMountAttackJob_1_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyInvulnerableJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyInvulnerableJob_entityQuery");
      StatChangeMutationSystem.NativeFieldInfoPtr___ApplyInvulnerableJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>ApplyInvulnerableJob_profilerMarker");
      StatChangeMutationSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_DayNightCycle_28));
      StatChangeMutationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673628);
      StatChangeMutationSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673629);
      StatChangeMutationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673630);
      StatChangeMutationSystem.NativeMethodInfoPtr_CallScriptCallbacks_Internal_Void_EntityCommandBuffer_NativeArray_1_StatChangeEvent_NativeArray_1_Entity_StatChangeListenerLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673631);
      StatChangeMutationSystem.NativeMethodInfoPtr_RegisterOrUnregisterListeners_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673632);
      StatChangeMutationSystem.NativeMethodInfoPtr_CheckIncoming_Private_Static_Void_byref_ListenerCommonInput_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673633);
      StatChangeMutationSystem.NativeMethodInfoPtr_CheckOutgoing_Private_Static_Void_byref_ListenerCommonInput_Entity_Entity_Entity_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673634);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyNullifyDamage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673635);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyWeaken_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673636);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyFortify_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673637);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyServerSettingDamageRecieveOnPlayers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673638);
      StatChangeMutationSystem.NativeMethodInfoPtr_IsAbsorbBuffConsumed_Private_Static_Boolean_byref_AbsorbBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673639);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyAbsorb_Private_Void_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673640);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyAmplify_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673641);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyBlockHeal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673642);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyCriticalStrike_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673643);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyEmpower_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673644);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyFirstStrikeDamage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673645);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyIncreaseMountAttack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673646);
      StatChangeMutationSystem.NativeMethodInfoPtr_ApplyInvulnerable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673647);
      StatChangeMutationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673648);
      StatChangeMutationSystem.NativeMethodInfoPtr__ApplyInvulnerable_b__44_0_Private_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673649);
      StatChangeMutationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673650);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForCallScriptCallbacks_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673651);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyNullifyDamageJob_0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673652);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyNullifyDamageJob_1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673653);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyWeakenJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673654);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyFortifyJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673655);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyServerSettingDamageRecieveOnPlayers_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673656);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyAbsorbJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673657);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyAmplifyJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673658);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyBlockHealJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673659);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyCriticalStrikeJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673660);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyEmpowerJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673661);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyFirstStrikeJob_0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673662);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyFirstStrikeJob_1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673663);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyIncreaseMountAttackJob_0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673664);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyIncreaseMountAttackJob_1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673665);
      StatChangeMutationSystem.NativeMethodInfoPtr___GetEntityQuery_ForApplyInvulnerableJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673666);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673667);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673668);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673669);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673670);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673671);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673672);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673673);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673674);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_8 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673675);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_9 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673676);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_10 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673677);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_11 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673678);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_12 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673679);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_13 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673680);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_14 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673681);
      StatChangeMutationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_15 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, 100673682);
    }

    public StatChangeMutationSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ServerScriptMapper _ScriptMapper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__ScriptMapper));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper) null : new ServerScriptMapper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__ScriptMapper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DestroyBarrier _DestroyBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == System.IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerGameBalanceSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__ServerGameBalanceSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__ServerGameBalanceSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<StatChangeMutationSystem.CallStatChangeListener> _ListenersToCall
    {
      get
      {
        return *(NativeList<StatChangeMutationSystem.CallStatChangeListener>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__ListenersToCall));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__ListenersToCall), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<StatChangeMutationSystem.CallStatChangeListener>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeMultiHashMap<Entity, Entity> _ListenerMap
    {
      get
      {
        return *(NativeMultiHashMap<Entity, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__ListenerMap));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__ListenerMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMultiHashMap<Entity, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Unity.Mathematics.Random _Random
    {
      get
      {
        return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__Random));
      }
      [param: In] set
      {
        *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__Random)) = value;
      }
    }

    public unsafe EntityQuery _StatChangeEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__StatChangeEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__StatChangeEventQuery)) = value;
      }
    }

    public unsafe StatChangeMutationSystem.BuffAccessor<WeakenBuff> _WeakenBuffAccessor
    {
      get
      {
        return *(StatChangeMutationSystem.BuffAccessor<WeakenBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__WeakenBuffAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__WeakenBuffAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<WeakenBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe StatChangeMutationSystem.BuffAccessor<EmpowerBuff> _EmpowerBuffAccessor
    {
      get
      {
        return *(StatChangeMutationSystem.BuffAccessor<EmpowerBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__EmpowerBuffAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__EmpowerBuffAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<EmpowerBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe StatChangeMutationSystem.BuffAccessor<FortifyBuff> _FortifyBuffAccessor
    {
      get
      {
        return *(StatChangeMutationSystem.BuffAccessor<FortifyBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__FortifyBuffAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__FortifyBuffAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<FortifyBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe StatChangeMutationSystem.BuffAccessor<BlockHealBuff> _BlockHealBuffAccessor
    {
      get
      {
        return *(StatChangeMutationSystem.BuffAccessor<BlockHealBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__BlockHealBuffAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__BlockHealBuffAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<BlockHealBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe StatChangeMutationSystem.BuffAccessor<AmplifyBuff> _AmplifyBuffAccessor
    {
      get
      {
        return *(StatChangeMutationSystem.BuffAccessor<AmplifyBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__AmplifyBuffAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__AmplifyBuffAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<AmplifyBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe StatChangeMutationSystem.BuffAccessor<AbsorbBuff> _AbsorbBuffAccessor
    {
      get
      {
        return *(StatChangeMutationSystem.BuffAccessor<AbsorbBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__AbsorbBuffAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__AbsorbBuffAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<AbsorbBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _RegisterListenerQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__RegisterListenerQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__RegisterListenerQuery)) = value;
      }
    }

    public unsafe EntityQuery _UnregisterListenerQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__UnregisterListenerQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__UnregisterListenerQuery)) = value;
      }
    }

    public unsafe EntityQuery _NullifyDamageQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__NullifyDamageQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__NullifyDamageQuery)) = value;
      }
    }

    public unsafe EntityQuery _FirstStrikeQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__FirstStrikeQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__FirstStrikeQuery)) = value;
      }
    }

    public unsafe EntityQuery _IncreaseMountAttackQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__IncreaseMountAttackQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__IncreaseMountAttackQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FindListeners_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___FindListeners_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___FindListeners_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __CallScriptCallbacks_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___CallScriptCallbacks_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___CallScriptCallbacks_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CallScriptCallbacks_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___CallScriptCallbacks_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___CallScriptCallbacks_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyNullifyDamageJob_0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyNullifyDamageJob_0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyNullifyDamageJob_1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyNullifyDamageJob_1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyNullifyDamageJob_1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyWeakenJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyWeakenJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyWeakenJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyWeakenJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyWeakenJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyWeakenJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyFortifyJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFortifyJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFortifyJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyFortifyJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFortifyJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFortifyJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyServerSettingDamageRecieveOnPlayers_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyServerSettingDamageRecieveOnPlayers_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyServerSettingDamageRecieveOnPlayers_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyServerSettingDamageRecieveOnPlayers_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyServerSettingDamageRecieveOnPlayers_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyServerSettingDamageRecieveOnPlayers_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyAbsorbJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAbsorbJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAbsorbJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyAbsorbJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAbsorbJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAbsorbJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyAmplifyJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAmplifyJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAmplifyJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyAmplifyJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAmplifyJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyAmplifyJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyBlockHealJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyBlockHealJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyBlockHealJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyBlockHealJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyBlockHealJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyBlockHealJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyCriticalStrikeJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyCriticalStrikeJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyCriticalStrikeJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyCriticalStrikeJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyCriticalStrikeJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyCriticalStrikeJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyEmpowerJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyEmpowerJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyEmpowerJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyEmpowerJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyEmpowerJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyEmpowerJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyFirstStrikeJob_0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyFirstStrikeJob_0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyFirstStrikeJob_1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyFirstStrikeJob_1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyFirstStrikeJob_1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyIncreaseMountAttackJob_0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyIncreaseMountAttackJob_0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyIncreaseMountAttackJob_1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyIncreaseMountAttackJob_1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyIncreaseMountAttackJob_1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ApplyInvulnerableJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyInvulnerableJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyInvulnerableJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ApplyInvulnerableJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyInvulnerableJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr___ApplyInvulnerableJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_DayNightCycle_28
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_28));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_28)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ListenerCommonInput
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_ListenerMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_ListenersToCall;
      private static readonly System.IntPtr NativeFieldInfoPtr_Location;
      [FieldOffset(0)]
      public EntityManager EntityManager;
      [FieldOffset(8)]
      public NativeMultiHashMap<Entity, Entity> ListenerMap;
      [FieldOffset(24)]
      public NativeList<StatChangeMutationSystem.CallStatChangeListener> ListenersToCall;
      [FieldOffset(40)]
      public StatChangeListenerLocation Location;

      static ListenerCommonInput()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.ListenerCommonInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (ListenerCommonInput));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.ListenerCommonInput>.NativeClassPtr);
        StatChangeMutationSystem.ListenerCommonInput.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.ListenerCommonInput>.NativeClassPtr, nameof (EntityManager));
        StatChangeMutationSystem.ListenerCommonInput.NativeFieldInfoPtr_ListenerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.ListenerCommonInput>.NativeClassPtr, nameof (ListenerMap));
        StatChangeMutationSystem.ListenerCommonInput.NativeFieldInfoPtr_ListenersToCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.ListenerCommonInput>.NativeClassPtr, nameof (ListenersToCall));
        StatChangeMutationSystem.ListenerCommonInput.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.ListenerCommonInput>.NativeClassPtr, nameof (Location));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.ListenerCommonInput>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RegisteredListener
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
      [FieldOffset(0)]
      public Entity TargetEntity;

      static RegisteredListener()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.RegisteredListener>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (RegisteredListener));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.RegisteredListener>.NativeClassPtr);
        StatChangeMutationSystem.RegisteredListener.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.RegisteredListener>.NativeClassPtr, nameof (TargetEntity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.RegisteredListener>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CallStatChangeListener
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CallerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_FunctionHash;
      private static readonly System.IntPtr NativeFieldInfoPtr_StatChangeEntity;
      [FieldOffset(0)]
      public Entity CallerEntity;
      [FieldOffset(8)]
      public int FunctionHash;
      [FieldOffset(12)]
      public Entity StatChangeEntity;

      static CallStatChangeListener()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.CallStatChangeListener>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (CallStatChangeListener));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.CallStatChangeListener>.NativeClassPtr);
        StatChangeMutationSystem.CallStatChangeListener.NativeFieldInfoPtr_CallerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.CallStatChangeListener>.NativeClassPtr, nameof (CallerEntity));
        StatChangeMutationSystem.CallStatChangeListener.NativeFieldInfoPtr_FunctionHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.CallStatChangeListener>.NativeClassPtr, nameof (FunctionHash));
        StatChangeMutationSystem.CallStatChangeListener.NativeFieldInfoPtr_StatChangeEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.CallStatChangeListener>.NativeClassPtr, nameof (StatChangeEntity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.CallStatChangeListener>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public struct BuffAccessor<T>
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__Query;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StatChangeMutationSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponentArrays_Internal_Boolean_byref_NativeArray_1_Buff_byref_NativeArray_1_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetChunkArray_Internal_Boolean_byref_NativeArray_1_ArchetypeChunk_0;
      public EntityQuery _Query;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1460984, RefRangeEnd = 1460985, XrefRangeStart = 1460975, XrefRangeEnd = 1460984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BuffAccessor(StatChangeMutationSystem system)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.BuffAccessor<T>.NativeMethodInfoPtr__ctor_Internal_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1460985, XrefRangeEnd = 1460992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetComponentArrays(
        out NativeArray<Buff> buffArray,
        out NativeArray<T> tArray)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref buffArray;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tArray;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.BuffAccessor<T>.NativeMethodInfoPtr_TryGetComponentArrays_Internal_Boolean_byref_NativeArray_1_Buff_byref_NativeArray_1_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1460994, RefRangeEnd = 1460995, XrefRangeStart = 1460992, XrefRangeEnd = 1460994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetChunkArray(out NativeArray<ArchetypeChunk> result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref result;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.BuffAccessor<T>.NativeMethodInfoPtr_TryGetChunkArray_Internal_Boolean_byref_NativeArray_1_ArchetypeChunk_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static BuffAccessor()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "BuffAccessor`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<T>>.NativeClassPtr);
        StatChangeMutationSystem.BuffAccessor<T>.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<T>>.NativeClassPtr, nameof (_Query));
        StatChangeMutationSystem.BuffAccessor<T>.NativeMethodInfoPtr__ctor_Internal_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<T>>.NativeClassPtr, 100673683);
        StatChangeMutationSystem.BuffAccessor<T>.NativeMethodInfoPtr_TryGetComponentArrays_Internal_Boolean_byref_NativeArray_1_Buff_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<T>>.NativeClassPtr, 100673684);
        StatChangeMutationSystem.BuffAccessor<T>.NativeMethodInfoPtr_TryGetChunkArray_Internal_Boolean_byref_NativeArray_1_ArchetypeChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<T>>.NativeClassPtr, 100673685);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.BuffAccessor<T>>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AbsorbSctData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StatChangeEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_StatChangeSourceEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Value;
      [FieldOffset(0)]
      public Entity StatChangeEntity;
      [FieldOffset(8)]
      public Entity StatChangeSourceEntity;
      [FieldOffset(16)]
      public float Value;

      static AbsorbSctData()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.AbsorbSctData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, nameof (AbsorbSctData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.AbsorbSctData>.NativeClassPtr);
        StatChangeMutationSystem.AbsorbSctData.NativeFieldInfoPtr_StatChangeEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.AbsorbSctData>.NativeClassPtr, nameof (StatChangeEntity));
        StatChangeMutationSystem.AbsorbSctData.NativeFieldInfoPtr_StatChangeSourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.AbsorbSctData>.NativeClassPtr, nameof (StatChangeSourceEntity));
        StatChangeMutationSystem.AbsorbSctData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.AbsorbSctData>.NativeClassPtr, nameof (Value));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.AbsorbSctData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass24_0")]
    public sealed class __c__DisplayClass24_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_statChanges;
      private static readonly System.IntPtr NativeFieldInfoPtr_statChangeEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_input;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CallScriptCallbacks_b__0_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CallScriptCallbacks_b__1_Internal_Void_Entity_byref_StatChangeEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass24_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _CallScriptCallbacks_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__CallScriptCallbacks_b__0_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _CallScriptCallbacks_b__1(
        Entity entity,
        ref StatChangeEvent statChangeEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__CallScriptCallbacks_b__1_Internal_Void_Entity_byref_StatChangeEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass24_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass24_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_statChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (statChanges));
        StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_statChangeEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (statChangeEntities));
        StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (input));
        StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
        StatChangeMutationSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr, 100673686);
        StatChangeMutationSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__CallScriptCallbacks_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr, 100673687);
        StatChangeMutationSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__CallScriptCallbacks_b__1_Internal_Void_Entity_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr, 100673688);
      }

      public __c__DisplayClass24_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass24_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass24_0>.NativeClassPtr, data));
      }

      public unsafe NativeArray<StatChangeEvent> statChanges
      {
        get
        {
          return *(NativeArray<StatChangeEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_statChanges));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_statChanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<StatChangeEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<Entity> statChangeEntities
      {
        get
        {
          return *(NativeArray<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_statChangeEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_statChangeEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe StatChangeMutationSystem.ListenerCommonInput input
      {
        get
        {
          return *(StatChangeMutationSystem.ListenerCommonInput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_input));
        }
        [param: In] set
        {
          *(StatChangeMutationSystem.ListenerCommonInput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_input)) = value;
        }
      }

      public unsafe StatChangeMutationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StatChangeMutationSystem) null : new StatChangeMutationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass29_0")]
    public sealed class __c__DisplayClass29_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_nullifyAndEmpowerOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffSpawner;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyNullifyDamage_b__0_Internal_Void_byref_BloodBuffScript_Brute_NulifyAndEmpower_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyNullifyDamage_b__1_Internal_Void_byref_StatChangeEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass29_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyNullifyDamage_b__0(
        [In] ref BloodBuffScript_Brute_NulifyAndEmpower mountDamageIncreaseBuff,
        [In] ref EntityOwner entityOwner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref mountDamageIncreaseBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ApplyNullifyDamage_b__0_Internal_Void_byref_BloodBuffScript_Brute_NulifyAndEmpower_byref_EntityOwner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyNullifyDamage_b__1(ref StatChangeEvent statChangeEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ApplyNullifyDamage_b__1_Internal_Void_byref_StatChangeEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass29_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass29_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_nullifyAndEmpowerOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (nullifyAndEmpowerOwners));
        StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (random));
        StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
        StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (prefabLookupMap));
        StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_buffSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (buffSpawner));
        StatChangeMutationSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr, 100673689);
        StatChangeMutationSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ApplyNullifyDamage_b__0_Internal_Void_byref_BloodBuffScript_Brute_NulifyAndEmpower_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr, 100673690);
        StatChangeMutationSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ApplyNullifyDamage_b__1_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr, 100673691);
      }

      public __c__DisplayClass29_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass29_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass29_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<Entity, BloodBuffScript_Brute_NulifyAndEmpower> nullifyAndEmpowerOwners
      {
        get
        {
          return *(NativeHashMap<Entity, BloodBuffScript_Brute_NulifyAndEmpower>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_nullifyAndEmpowerOwners));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_nullifyAndEmpowerOwners), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<Entity, BloodBuffScript_Brute_NulifyAndEmpower>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Unity.Mathematics.Random random
      {
        get
        {
          return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_random));
        }
        [param: In] set
        {
          *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_random)) = value;
        }
      }

      public unsafe StatChangeMutationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StatChangeMutationSystem) null : new StatChangeMutationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe BuffUtility.BuffSpawner buffSpawner
      {
        get
        {
          return *(BuffUtility.BuffSpawner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_buffSpawner));
        }
        [param: In] set
        {
          *(BuffUtility.BuffSpawner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_buffSpawner)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass30_0")]
    public sealed class __c__DisplayClass30_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_weakenBuffs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyWeaken_b__0_Internal_Void_byref_StatChangeEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass30_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass30_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyWeaken_b__0(ref StatChangeEvent statChangeEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass30_0.NativeMethodInfoPtr__ApplyWeaken_b__0_Internal_Void_byref_StatChangeEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass30_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass30_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass30_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
        StatChangeMutationSystem.__c__DisplayClass30_0.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass30_0>.NativeClassPtr, nameof (buffs));
        StatChangeMutationSystem.__c__DisplayClass30_0.NativeFieldInfoPtr_weakenBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass30_0>.NativeClassPtr, nameof (weakenBuffs));
        StatChangeMutationSystem.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass30_0>.NativeClassPtr, 100673692);
        StatChangeMutationSystem.__c__DisplayClass30_0.NativeMethodInfoPtr__ApplyWeaken_b__0_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass30_0>.NativeClassPtr, 100673693);
      }

      public __c__DisplayClass30_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass30_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass30_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass30_0>.NativeClassPtr, data));
      }

      public unsafe StatChangeMutationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StatChangeMutationSystem) null : new StatChangeMutationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeArray<Buff> buffs
      {
        get
        {
          return *(NativeArray<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass30_0.NativeFieldInfoPtr_buffs));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass30_0.NativeFieldInfoPtr_buffs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<WeakenBuff> weakenBuffs
      {
        get
        {
          return *(NativeArray<WeakenBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass30_0.NativeFieldInfoPtr_weakenBuffs));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass30_0.NativeFieldInfoPtr_weakenBuffs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<WeakenBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass31_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass31_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_fortifyBuffs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyFortify_b__0_Internal_Void_byref_StatChangeEvent_0;
      [FieldOffset(0)]
      public NativeArray<Buff> buffs;
      [FieldOffset(16)]
      public NativeArray<FortifyBuff> fortifyBuffs;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass31_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyFortify_b__0(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ApplyFortify_b__0_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass31_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass31_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass31_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass31_0>.NativeClassPtr, nameof (buffs));
        StatChangeMutationSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_fortifyBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass31_0>.NativeClassPtr, nameof (fortifyBuffs));
        StatChangeMutationSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass31_0>.NativeClassPtr, 100673694);
        StatChangeMutationSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ApplyFortify_b__0_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass31_0>.NativeClassPtr, 100673695);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass31_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass32_0")]
    public sealed class __c__DisplayClass32_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_damageReceivedModifier;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyServerSettingDamageRecieveOnPlayers_b__0_Internal_Void_byref_StatChangeEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass32_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass32_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyServerSettingDamageRecieveOnPlayers_b__0(
        ref StatChangeEvent statChangeEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass32_0.NativeMethodInfoPtr__ApplyServerSettingDamageRecieveOnPlayers_b__0_Internal_Void_byref_StatChangeEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass32_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass32_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass32_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
        StatChangeMutationSystem.__c__DisplayClass32_0.NativeFieldInfoPtr_damageReceivedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass32_0>.NativeClassPtr, nameof (damageReceivedModifier));
        StatChangeMutationSystem.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass32_0>.NativeClassPtr, 100673696);
        StatChangeMutationSystem.__c__DisplayClass32_0.NativeMethodInfoPtr__ApplyServerSettingDamageRecieveOnPlayers_b__0_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass32_0>.NativeClassPtr, 100673697);
      }

      public __c__DisplayClass32_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass32_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass32_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass32_0>.NativeClassPtr, data));
      }

      public unsafe StatChangeMutationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StatChangeMutationSystem) null : new StatChangeMutationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe half damageReceivedModifier
      {
        get
        {
          return *(half*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass32_0.NativeFieldInfoPtr_damageReceivedModifier));
        }
        [param: In] set
        {
          *(half*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass32_0.NativeFieldInfoPtr_damageReceivedModifier)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass35_0")]
    public sealed class __c__DisplayClass35_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buffChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffType;
      private static readonly System.IntPtr NativeFieldInfoPtr_absorbBuffType;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_sctsToShow;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyAbsorb_b__0_Internal_Void_byref_StatChangeEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass35_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyAbsorb_b__0(ref StatChangeEvent statChangeEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass35_0.NativeMethodInfoPtr__ApplyAbsorb_b__0_Internal_Void_byref_StatChangeEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass35_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass35_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_buffChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, nameof (buffChunks));
        StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_entityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, nameof (entityType));
        StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_buffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, nameof (buffType));
        StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_absorbBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, nameof (absorbBuffType));
        StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, nameof (commandBuffer));
        StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
        StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_sctsToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, nameof (sctsToShow));
        StatChangeMutationSystem.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, 100673698);
        StatChangeMutationSystem.__c__DisplayClass35_0.NativeMethodInfoPtr__ApplyAbsorb_b__0_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, 100673699);
      }

      public __c__DisplayClass35_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass35_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass35_0>.NativeClassPtr, data));
      }

      public unsafe NativeArray<ArchetypeChunk> buffChunks
      {
        get
        {
          return *(NativeArray<ArchetypeChunk>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_buffChunks));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_buffChunks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ArchetypeChunk>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityTypeHandle entityType
      {
        get
        {
          return *(EntityTypeHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_entityType));
        }
        [param: In] set
        {
          *(EntityTypeHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_entityType)) = value;
        }
      }

      public unsafe ComponentTypeHandle<Buff> buffType
      {
        get
        {
          return *(ComponentTypeHandle<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_buffType));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_buffType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentTypeHandle<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentTypeHandle<AbsorbBuff> absorbBuffType
      {
        get
        {
          return *(ComponentTypeHandle<AbsorbBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_absorbBuffType));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_absorbBuffType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentTypeHandle<AbsorbBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe StatChangeMutationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StatChangeMutationSystem) null : new StatChangeMutationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeList<StatChangeMutationSystem.AbsorbSctData> sctsToShow
      {
        get
        {
          return *(NativeList<StatChangeMutationSystem.AbsorbSctData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_sctsToShow));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass35_0.NativeFieldInfoPtr_sctsToShow), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<StatChangeMutationSystem.AbsorbSctData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass36_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass36_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_amplifyBuffs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyAmplify_b__0_Internal_Void_byref_StatChangeEvent_0;
      [FieldOffset(0)]
      public NativeArray<Buff> buffs;
      [FieldOffset(16)]
      public NativeArray<AmplifyBuff> amplifyBuffs;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass36_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyAmplify_b__0(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass36_0.NativeMethodInfoPtr__ApplyAmplify_b__0_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass36_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass36_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass36_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass36_0.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass36_0>.NativeClassPtr, nameof (buffs));
        StatChangeMutationSystem.__c__DisplayClass36_0.NativeFieldInfoPtr_amplifyBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass36_0>.NativeClassPtr, nameof (amplifyBuffs));
        StatChangeMutationSystem.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass36_0>.NativeClassPtr, 100673700);
        StatChangeMutationSystem.__c__DisplayClass36_0.NativeMethodInfoPtr__ApplyAmplify_b__0_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass36_0>.NativeClassPtr, 100673701);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass36_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass37_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass37_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_blockHealBuffs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyBlockHeal_b__0_Internal_Void_byref_StatChangeEvent_0;
      [FieldOffset(0)]
      public NativeArray<Buff> buffs;
      [FieldOffset(16)]
      public NativeArray<BlockHealBuff> blockHealBuffs;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass37_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyBlockHeal_b__0(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__ApplyBlockHeal_b__0_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass37_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass37_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass37_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass37_0.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass37_0>.NativeClassPtr, nameof (buffs));
        StatChangeMutationSystem.__c__DisplayClass37_0.NativeFieldInfoPtr_blockHealBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass37_0>.NativeClassPtr, nameof (blockHealBuffs));
        StatChangeMutationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100673702);
        StatChangeMutationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__ApplyBlockHeal_b__0_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100673703);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass37_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass38_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass38_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyCriticalStrike_b__0_Internal_Void_byref_StatChangeEvent_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public Unity.Mathematics.Random random;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass38_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyCriticalStrike_b__0(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__ApplyCriticalStrike_b__0_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass38_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass38_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass38_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass38_0>.NativeClassPtr, nameof (entityManager));
        StatChangeMutationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass38_0>.NativeClassPtr, nameof (random));
        StatChangeMutationSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass38_0>.NativeClassPtr, 100673704);
        StatChangeMutationSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__ApplyCriticalStrike_b__0_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass38_0>.NativeClassPtr, 100673705);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass38_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass39_0")]
    public sealed class __c__DisplayClass39_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_empowerBuffs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyEmpower_b__0_Internal_Void_byref_StatChangeEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass39_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass39_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyEmpower_b__0(ref StatChangeEvent statChangeEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__ApplyEmpower_b__0_Internal_Void_byref_StatChangeEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass39_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass39_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass39_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
        StatChangeMutationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass39_0>.NativeClassPtr, nameof (buffs));
        StatChangeMutationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_empowerBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass39_0>.NativeClassPtr, nameof (empowerBuffs));
        StatChangeMutationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass39_0>.NativeClassPtr, 100673706);
        StatChangeMutationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__ApplyEmpower_b__0_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass39_0>.NativeClassPtr, 100673707);
      }

      public __c__DisplayClass39_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass39_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass39_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass39_0>.NativeClassPtr, data));
      }

      public unsafe StatChangeMutationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StatChangeMutationSystem) null : new StatChangeMutationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeArray<Buff> buffs
      {
        get
        {
          return *(NativeArray<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_buffs));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_buffs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<EmpowerBuff> empowerBuffs
      {
        get
        {
          return *(NativeArray<EmpowerBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_empowerBuffs));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_empowerBuffs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<EmpowerBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass41_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass41_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_firstStrikeOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyFirstStrikeDamage_b__0_Internal_Void_byref_BloodBuffScript_FirstStrike_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyFirstStrikeDamage_b__1_Internal_Void_byref_StatChangeEvent_0;
      [FieldOffset(0)]
      public NativeHashMap<Entity, float> firstStrikeOwners;
      [FieldOffset(16)]
      public EntityManager entityManager;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass41_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyFirstStrikeDamage_b__0(
        [In] ref BloodBuffScript_FirstStrike firstStrike,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref firstStrike;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ApplyFirstStrikeDamage_b__0_Internal_Void_byref_BloodBuffScript_FirstStrike_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyFirstStrikeDamage_b__1(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ApplyFirstStrikeDamage_b__1_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass41_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass41_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass41_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_firstStrikeOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass41_0>.NativeClassPtr, nameof (firstStrikeOwners));
        StatChangeMutationSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass41_0>.NativeClassPtr, nameof (entityManager));
        StatChangeMutationSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass41_0>.NativeClassPtr, 100673708);
        StatChangeMutationSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ApplyFirstStrikeDamage_b__0_Internal_Void_byref_BloodBuffScript_FirstStrike_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass41_0>.NativeClassPtr, 100673709);
        StatChangeMutationSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ApplyFirstStrikeDamage_b__1_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass41_0>.NativeClassPtr, 100673710);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass41_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/<>c__DisplayClass43_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass43_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayNight;
      private static readonly System.IntPtr NativeFieldInfoPtr_mountIncreasedDamageOwners;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyIncreaseMountAttack_b__0_Internal_Void_byref_BloodBuffScript_Rogue_MountDamageBonus_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyIncreaseMountAttack_b__1_Internal_Void_byref_StatChangeEvent_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public DayNightCycle dayNight;
      [FieldOffset(144)]
      public NativeHashMap<Entity, float> mountIncreasedDamageOwners;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass43_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyIncreaseMountAttack_b__0(
        [In] ref BloodBuffScript_Rogue_MountDamageBonus mountDamageIncreaseBuff,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref mountDamageIncreaseBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__ApplyIncreaseMountAttack_b__0_Internal_Void_byref_BloodBuffScript_Rogue_MountDamageBonus_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyIncreaseMountAttack_b__1(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__ApplyIncreaseMountAttack_b__1_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass43_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass43_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass43_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass43_0>.NativeClassPtr, nameof (entityManager));
        StatChangeMutationSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_dayNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass43_0>.NativeClassPtr, nameof (dayNight));
        StatChangeMutationSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_mountIncreasedDamageOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass43_0>.NativeClassPtr, nameof (mountIncreasedDamageOwners));
        StatChangeMutationSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass43_0>.NativeClassPtr, 100673711);
        StatChangeMutationSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__ApplyIncreaseMountAttack_b__0_Internal_Void_byref_BloodBuffScript_Rogue_MountDamageBonus_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass43_0>.NativeClassPtr, 100673712);
        StatChangeMutationSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__ApplyIncreaseMountAttack_b__1_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass43_0>.NativeClassPtr, 100673713);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass43_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_FindListeners")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FindListeners
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_statChanges;
      private static readonly System.IntPtr NativeFieldInfoPtr_statChangeEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_input;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeArray<StatChangeEvent> statChanges;
      [FieldOffset(16)]
      public NativeArray<Entity> statChangeEntities;
      [FieldOffset(32)]
      public StatChangeMutationSystem.ListenerCommonInput input;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461070, XrefRangeEnd = 1461088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461088, RefRangeEnd = 1461089, XrefRangeStart = 1461088, XrefRangeEnd = 1461088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461089, RefRangeEnd = 1461090, XrefRangeStart = 1461089, XrefRangeEnd = 1461089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461091, RefRangeEnd = 1461092, XrefRangeStart = 1461090, XrefRangeEnd = 1461091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461093, RefRangeEnd = 1461094, XrefRangeStart = 1461092, XrefRangeEnd = 1461093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461094, XrefRangeEnd = 1461098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461111, RefRangeEnd = 1461112, XrefRangeStart = 1461098, XrefRangeEnd = 1461111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindListeners()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_FindListeners");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeFieldInfoPtr_statChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, nameof (statChanges));
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeFieldInfoPtr_statChangeEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, nameof (statChangeEntities));
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, nameof (input));
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, 100673714);
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, 100673715);
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, 100673716);
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, 100673717);
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, 100673718);
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, 100673719);
        StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, 100673720);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_FindListeners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_FindListeners/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000018F0$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, "RunWithoutJobSystem_000018F0$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100673721);
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100673722);
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100673723);
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100673724);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_FindListeners/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000018F0$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1460995, XrefRangeEnd = 1461009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461009, XrefRangeEnd = 1461027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461027, XrefRangeEnd = 1461042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461069, RefRangeEnd = 1461070, XrefRangeStart = 1461042, XrefRangeEnd = 1461069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners>.NativeClassPtr, "RunWithoutJobSystem_000018F0$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673725);
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673726);
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673727);
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673728);
          StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673730);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_FindListeners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_CallScriptCallbacks_LambdaJob1")]
    public sealed class __c__DisplayClass_CallScriptCallbacks_LambdaJob1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461138, RefRangeEnd = 1461139, XrefRangeStart = 1461122, XrefRangeEnd = 1461138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ref StatChangeEvent statChangeEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StatChangeEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461140, RefRangeEnd = 1461141, XrefRangeStart = 1461139, XrefRangeEnd = 1461140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass24_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461142, RefRangeEnd = 1461143, XrefRangeStart = 1461141, XrefRangeEnd = 1461142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass24_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461143, XrefRangeEnd = 1461145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461151, RefRangeEnd = 1461152, XrefRangeStart = 1461145, XrefRangeEnd = 1461151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461154, RefRangeEnd = 1461155, XrefRangeStart = 1461152, XrefRangeEnd = 1461154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass24_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass24_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461155, XrefRangeEnd = 1461161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CallScriptCallbacks_LambdaJob1()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_CallScriptCallbacks_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, "<>4__this");
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, 100673731);
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, 100673732);
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, 100673733);
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, 100673734);
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, 100673735);
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, 100673736);
        StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, 100673737);
      }

      public __c__DisplayClass_CallScriptCallbacks_LambdaJob1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_CallScriptCallbacks_LambdaJob1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, data));
      }

      public unsafe StatChangeMutationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StatChangeMutationSystem) null : new StatChangeMutationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461116, RefRangeEnd = 1461117, XrefRangeStart = 1461112, XrefRangeEnd = 1461116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461121, RefRangeEnd = 1461122, XrefRangeStart = 1461117, XrefRangeEnd = 1461121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100673738);
          StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100673739);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_CallScriptCallbacks_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyNullifyDamageJob_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyNullifyDamageJob_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_nullifyAndEmpowerOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_Brute_NulifyAndEmpower_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<Entity, BloodBuffScript_Brute_NulifyAndEmpower> nullifyAndEmpowerOwners;
      [FieldOffset(16)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461250, XrefRangeEnd = 1461253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref BloodBuffScript_Brute_NulifyAndEmpower mountDamageIncreaseBuff,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref mountDamageIncreaseBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_Brute_NulifyAndEmpower_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461253, XrefRangeEnd = 1461255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461263, RefRangeEnd = 1461264, XrefRangeStart = 1461255, XrefRangeEnd = 1461263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461266, RefRangeEnd = 1461267, XrefRangeStart = 1461264, XrefRangeEnd = 1461266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461267, XrefRangeEnd = 1461271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461271, XrefRangeEnd = 1461277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyNullifyDamageJob_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyNullifyDamageJob_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeFieldInfoPtr_nullifyAndEmpowerOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, nameof (nullifyAndEmpowerOwners));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_Brute_NulifyAndEmpower_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, 100673740);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, 100673741);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, 100673742);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, 100673743);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, 100673744);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, 100673745);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, 100673746);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, 100673747);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mountDamageIncreaseBuff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<BloodBuffScript_Brute_NulifyAndEmpower> forParameter_mountDamageIncreaseBuff;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461167, RefRangeEnd = 1461168, XrefRangeStart = 1461161, XrefRangeEnd = 1461167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461174, RefRangeEnd = 1461175, XrefRangeStart = 1461168, XrefRangeEnd = 1461174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mountDamageIncreaseBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mountDamageIncreaseBuff));
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders>.NativeClassPtr, 100673748);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders>.NativeClassPtr, 100673749);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mountDamageIncreaseBuff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<BloodBuffScript_Brute_NulifyAndEmpower>.Runtime runtime_mountDamageIncreaseBuff;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mountDamageIncreaseBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mountDamageIncreaseBuff));
            StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyNullifyDamageJob_0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001900$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, "RunWithoutJobSystem_00001900$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673750);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673751);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673752);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673753);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyNullifyDamageJob_0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001900$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461175, XrefRangeEnd = 1461189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461189, XrefRangeEnd = 1461207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461207, XrefRangeEnd = 1461222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461249, RefRangeEnd = 1461250, XrefRangeStart = 1461222, XrefRangeEnd = 1461249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0>.NativeClassPtr, "RunWithoutJobSystem_00001900$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673754);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673755);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673756);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673757);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673759);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyNullifyDamageJob_1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyNullifyDamageJob_1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_nullifyAndEmpowerOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffSpawner;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Blood_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<Entity, BloodBuffScript_Brute_NulifyAndEmpower> nullifyAndEmpowerOwners;
      [FieldOffset(16)]
      public Unity.Mathematics.Random random;
      [FieldOffset(24)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(72)]
      public BuffUtility.BuffSpawner buffSpawner;
      [FieldOffset(200)]
      public ComponentDataFromEntity<Blood> _ComponentDataFromEntity_Blood_0;
      [FieldOffset(232)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(264)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461360, XrefRangeEnd = 1461383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461383, RefRangeEnd = 1461384, XrefRangeStart = 1461383, XrefRangeEnd = 1461383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461384, RefRangeEnd = 1461385, XrefRangeStart = 1461384, XrefRangeEnd = 1461384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461385, XrefRangeEnd = 1461387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461392, RefRangeEnd = 1461393, XrefRangeStart = 1461387, XrefRangeEnd = 1461392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461398, RefRangeEnd = 1461399, XrefRangeStart = 1461393, XrefRangeEnd = 1461398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461399, XrefRangeEnd = 1461403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461403, XrefRangeEnd = 1461409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyNullifyDamageJob_1()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyNullifyDamageJob_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr_nullifyAndEmpowerOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, nameof (nullifyAndEmpowerOwners));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, nameof (random));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, nameof (prefabLookupMap));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr_buffSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, nameof (buffSpawner));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr__ComponentDataFromEntity_Blood_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, nameof (_ComponentDataFromEntity_Blood_0));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, 100673760);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, 100673761);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, 100673762);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, 100673763);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, 100673764);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, 100673765);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, 100673766);
        StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, 100673767);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461280, RefRangeEnd = 1461281, XrefRangeStart = 1461277, XrefRangeEnd = 1461280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461284, RefRangeEnd = 1461285, XrefRangeStart = 1461281, XrefRangeEnd = 1461284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders>.NativeClassPtr, 100673768);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders>.NativeClassPtr, 100673769);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyNullifyDamageJob_1/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001909$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, "RunWithoutJobSystem_00001909$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673770);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673771);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673772);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673773);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyNullifyDamageJob_1/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001909$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461285, XrefRangeEnd = 1461299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461299, XrefRangeEnd = 1461317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461317, XrefRangeEnd = 1461332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461359, RefRangeEnd = 1461360, XrefRangeStart = 1461332, XrefRangeEnd = 1461359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1>.NativeClassPtr, "RunWithoutJobSystem_00001909$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673774);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673775);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673776);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673777);
          StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673779);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyNullifyDamageJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyWeakenJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyWeakenJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_weakenBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass30_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<Buff> buffs;
      [FieldOffset(16)]
      public NativeArray<WeakenBuff> weakenBuffs;
      [FieldOffset(32)]
      public ComponentDataFromEntity<EntityOwner> _ComponentDataFromEntity_EntityOwner_0;
      [FieldOffset(64)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461492, XrefRangeEnd = 1461507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 755494, RefRangeEnd = 755501, XrefRangeStart = 755494, XrefRangeEnd = 755501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass30_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 755501, RefRangeEnd = 755508, XrefRangeStart = 755501, XrefRangeEnd = 755508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass30_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461507, XrefRangeEnd = 1461509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461514, RefRangeEnd = 1461515, XrefRangeStart = 1461509, XrefRangeEnd = 1461514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461520, RefRangeEnd = 1461521, XrefRangeStart = 1461515, XrefRangeEnd = 1461520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass30_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass30_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461521, XrefRangeEnd = 1461525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461525, XrefRangeEnd = 1461531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyWeakenJob()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyWeakenJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, nameof (buffs));
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr_weakenBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, nameof (weakenBuffs));
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityOwner_0));
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, 100673780);
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, 100673781);
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, 100673782);
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, 100673783);
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, 100673784);
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, 100673785);
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, 100673786);
        StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, 100673787);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461412, RefRangeEnd = 1461413, XrefRangeStart = 1461409, XrefRangeEnd = 1461412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461416, RefRangeEnd = 1461417, XrefRangeStart = 1461413, XrefRangeEnd = 1461416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders>.NativeClassPtr, 100673788);
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders>.NativeClassPtr, 100673789);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyWeakenJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001912$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, "RunWithoutJobSystem_00001912$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673790);
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673791);
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673792);
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673793);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyWeakenJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001912$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461417, XrefRangeEnd = 1461431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461431, XrefRangeEnd = 1461449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461449, XrefRangeEnd = 1461464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461491, RefRangeEnd = 1461492, XrefRangeStart = 1461464, XrefRangeEnd = 1461491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob>.NativeClassPtr, "RunWithoutJobSystem_00001912$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673794);
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673795);
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673796);
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673797);
          StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673799);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyWeakenJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyFortifyJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyFortifyJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_fortifyBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<Buff> buffs;
      [FieldOffset(16)]
      public NativeArray<FortifyBuff> fortifyBuffs;
      [FieldOffset(32)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461614, XrefRangeEnd = 1461621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 752109, RefRangeEnd = 752124, XrefRangeStart = 752109, XrefRangeEnd = 752124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass31_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass31_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461621, XrefRangeEnd = 1461623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461628, RefRangeEnd = 1461629, XrefRangeStart = 1461623, XrefRangeEnd = 1461628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461631, RefRangeEnd = 1461632, XrefRangeStart = 1461629, XrefRangeEnd = 1461631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass31_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass31_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461632, XrefRangeEnd = 1461636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461636, XrefRangeEnd = 1461642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyFortifyJob()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyFortifyJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, nameof (buffs));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeFieldInfoPtr_fortifyBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, nameof (fortifyBuffs));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, 100673800);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, 100673801);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, 100673802);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, 100673803);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, 100673804);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, 100673805);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, 100673806);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, 100673807);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461534, RefRangeEnd = 1461535, XrefRangeStart = 1461531, XrefRangeEnd = 1461534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461538, RefRangeEnd = 1461539, XrefRangeStart = 1461535, XrefRangeEnd = 1461538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders>.NativeClassPtr, 100673808);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders>.NativeClassPtr, 100673809);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyFortifyJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000191B$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, "RunWithoutJobSystem_0000191B$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673810);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673811);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673812);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673813);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyFortifyJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000191B$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461539, XrefRangeEnd = 1461553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461553, XrefRangeEnd = 1461571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461571, XrefRangeEnd = 1461586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461613, RefRangeEnd = 1461614, XrefRangeStart = 1461586, XrefRangeEnd = 1461613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob>.NativeClassPtr, "RunWithoutJobSystem_0000191B$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673814);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673815);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673816);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673817);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673819);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFortifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_damageReceivedModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PlayerCharacter_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass32_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass32_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass32_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public half damageReceivedModifier;
      [FieldOffset(8)]
      public ComponentDataFromEntity<PlayerCharacter> _ComponentDataFromEntity_PlayerCharacter_0;
      [FieldOffset(40)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461725, XrefRangeEnd = 1461728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461728, RefRangeEnd = 1461729, XrefRangeStart = 1461728, XrefRangeEnd = 1461728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass32_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass32_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461729, RefRangeEnd = 1461730, XrefRangeStart = 1461729, XrefRangeEnd = 1461729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass32_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass32_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461730, XrefRangeEnd = 1461732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461737, RefRangeEnd = 1461738, XrefRangeStart = 1461732, XrefRangeEnd = 1461737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461743, RefRangeEnd = 1461744, XrefRangeStart = 1461738, XrefRangeEnd = 1461743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass32_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass32_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461744, XrefRangeEnd = 1461748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461748, XrefRangeEnd = 1461754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeFieldInfoPtr_damageReceivedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, nameof (damageReceivedModifier));
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeFieldInfoPtr__ComponentDataFromEntity_PlayerCharacter_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, nameof (_ComponentDataFromEntity_PlayerCharacter_0));
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, 100673820);
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass32_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, 100673821);
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass32_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, 100673822);
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, 100673823);
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, 100673824);
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass32_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, 100673825);
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, 100673826);
        StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, 100673827);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461645, RefRangeEnd = 1461646, XrefRangeStart = 1461642, XrefRangeEnd = 1461645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461649, RefRangeEnd = 1461650, XrefRangeStart = 1461646, XrefRangeEnd = 1461649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders>.NativeClassPtr, 100673828);
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders>.NativeClassPtr, 100673829);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001924$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, "RunWithoutJobSystem_00001924$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673830);
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673831);
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673832);
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673833);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001924$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461650, XrefRangeEnd = 1461664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461664, XrefRangeEnd = 1461682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461682, XrefRangeEnd = 1461697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461724, RefRangeEnd = 1461725, XrefRangeStart = 1461697, XrefRangeEnd = 1461724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers>.NativeClassPtr, "RunWithoutJobSystem_00001924$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673834);
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673835);
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673836);
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673837);
          StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673839);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyServerSettingDamageRecieveOnPlayers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyAbsorbJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyAbsorbJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buffChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffType;
      private static readonly System.IntPtr NativeFieldInfoPtr_absorbBuffType;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_sctsToShow;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass35_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<ArchetypeChunk> buffChunks;
      [FieldOffset(16)]
      public EntityTypeHandle entityType;
      [FieldOffset(24)]
      public ComponentTypeHandle<Buff> buffType;
      [FieldOffset(56)]
      public ComponentTypeHandle<AbsorbBuff> absorbBuffType;
      [FieldOffset(88)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(104)]
      public NativeList<StatChangeMutationSystem.AbsorbSctData> sctsToShow;
      [FieldOffset(120)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(152)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(184)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461837, XrefRangeEnd = 1461872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461872, RefRangeEnd = 1461873, XrefRangeStart = 1461872, XrefRangeEnd = 1461872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass35_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461873, RefRangeEnd = 1461874, XrefRangeStart = 1461873, XrefRangeEnd = 1461873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass35_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461874, XrefRangeEnd = 1461876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461881, RefRangeEnd = 1461882, XrefRangeStart = 1461876, XrefRangeEnd = 1461881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461887, RefRangeEnd = 1461888, XrefRangeStart = 1461882, XrefRangeEnd = 1461887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass35_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass35_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461888, XrefRangeEnd = 1461892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461892, XrefRangeEnd = 1461898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyAbsorbJob()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyAbsorbJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_buffChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (buffChunks));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_entityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (entityType));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_buffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (buffType));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_absorbBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (absorbBuffType));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (commandBuffer));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_sctsToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (sctsToShow));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, 100673840);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, 100673841);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, 100673842);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, 100673843);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, 100673844);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, 100673845);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, 100673846);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, 100673847);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461757, RefRangeEnd = 1461758, XrefRangeStart = 1461754, XrefRangeEnd = 1461757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461761, RefRangeEnd = 1461762, XrefRangeStart = 1461758, XrefRangeEnd = 1461761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders>.NativeClassPtr, 100673848);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders>.NativeClassPtr, 100673849);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyAbsorbJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000192D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, "RunWithoutJobSystem_0000192D$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673850);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673851);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673852);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673853);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyAbsorbJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000192D$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461762, XrefRangeEnd = 1461776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461776, XrefRangeEnd = 1461794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461794, XrefRangeEnd = 1461809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461836, RefRangeEnd = 1461837, XrefRangeStart = 1461809, XrefRangeEnd = 1461836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob>.NativeClassPtr, "RunWithoutJobSystem_0000192D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673854);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673855);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673856);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673857);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673859);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAbsorbJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyAmplifyJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyAmplifyJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_amplifyBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass36_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<Buff> buffs;
      [FieldOffset(16)]
      public NativeArray<AmplifyBuff> amplifyBuffs;
      [FieldOffset(32)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461981, XrefRangeEnd = 1461989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 752109, RefRangeEnd = 752124, XrefRangeStart = 752109, XrefRangeEnd = 752124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass36_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass36_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461989, XrefRangeEnd = 1461991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461996, RefRangeEnd = 1461997, XrefRangeStart = 1461991, XrefRangeEnd = 1461996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1461999, RefRangeEnd = 1462000, XrefRangeStart = 1461997, XrefRangeEnd = 1461999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass36_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass36_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462000, XrefRangeEnd = 1462004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462004, XrefRangeEnd = 1462010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyAmplifyJob()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyAmplifyJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, nameof (buffs));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeFieldInfoPtr_amplifyBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, nameof (amplifyBuffs));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, 100673860);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, 100673861);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass36_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, 100673862);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, 100673863);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, 100673864);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass36_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, 100673865);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, 100673866);
        StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, 100673867);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461901, RefRangeEnd = 1461902, XrefRangeStart = 1461898, XrefRangeEnd = 1461901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461905, RefRangeEnd = 1461906, XrefRangeStart = 1461902, XrefRangeEnd = 1461905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders>.NativeClassPtr, 100673868);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders>.NativeClassPtr, 100673869);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyAmplifyJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001936$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, "RunWithoutJobSystem_00001936$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673870);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673871);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673872);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673873);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyAmplifyJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001936$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461906, XrefRangeEnd = 1461920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461920, XrefRangeEnd = 1461938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1461938, XrefRangeEnd = 1461953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1461980, RefRangeEnd = 1461981, XrefRangeStart = 1461953, XrefRangeEnd = 1461980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob>.NativeClassPtr, "RunWithoutJobSystem_00001936$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673874);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673875);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673876);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673877);
          StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673879);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyAmplifyJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyBlockHealJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyBlockHealJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_blockHealBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass37_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<Buff> buffs;
      [FieldOffset(16)]
      public NativeArray<BlockHealBuff> blockHealBuffs;
      [FieldOffset(32)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462093, XrefRangeEnd = 1462101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 752109, RefRangeEnd = 752124, XrefRangeStart = 752109, XrefRangeEnd = 752124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass37_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass37_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462101, XrefRangeEnd = 1462103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462108, RefRangeEnd = 1462109, XrefRangeStart = 1462103, XrefRangeEnd = 1462108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462111, RefRangeEnd = 1462112, XrefRangeStart = 1462109, XrefRangeEnd = 1462111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass37_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass37_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462112, XrefRangeEnd = 1462116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462116, XrefRangeEnd = 1462122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyBlockHealJob()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyBlockHealJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, nameof (buffs));
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeFieldInfoPtr_blockHealBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, nameof (blockHealBuffs));
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, 100673880);
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, 100673881);
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass37_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, 100673882);
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, 100673883);
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, 100673884);
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass37_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, 100673885);
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, 100673886);
        StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, 100673887);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462013, RefRangeEnd = 1462014, XrefRangeStart = 1462010, XrefRangeEnd = 1462013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462017, RefRangeEnd = 1462018, XrefRangeStart = 1462014, XrefRangeEnd = 1462017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders>.NativeClassPtr, 100673888);
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders>.NativeClassPtr, 100673889);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyBlockHealJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000193F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, "RunWithoutJobSystem_0000193F$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673890);
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673891);
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673892);
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673893);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyBlockHealJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000193F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462018, XrefRangeEnd = 1462032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462032, XrefRangeEnd = 1462050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462050, XrefRangeEnd = 1462065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462092, RefRangeEnd = 1462093, XrefRangeStart = 1462065, XrefRangeEnd = 1462092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob>.NativeClassPtr, "RunWithoutJobSystem_0000193F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673894);
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673895);
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673896);
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673897);
          StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673899);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyBlockHealJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyCriticalStrikeJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyCriticalStrikeJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass38_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public Unity.Mathematics.Random random;
      [FieldOffset(16)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462205, XrefRangeEnd = 1462225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1012957, RefRangeEnd = 1012962, XrefRangeStart = 1012957, XrefRangeEnd = 1012962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass38_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1012962, RefRangeEnd = 1012967, XrefRangeStart = 1012962, XrefRangeEnd = 1012967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass38_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462225, XrefRangeEnd = 1462227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462232, RefRangeEnd = 1462233, XrefRangeStart = 1462227, XrefRangeEnd = 1462232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462235, RefRangeEnd = 1462236, XrefRangeStart = 1462233, XrefRangeEnd = 1462235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass38_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass38_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462236, XrefRangeEnd = 1462240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462240, XrefRangeEnd = 1462246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyCriticalStrikeJob()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyCriticalStrikeJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, nameof (entityManager));
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, nameof (random));
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, 100673900);
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, 100673901);
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass38_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, 100673902);
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, 100673903);
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, 100673904);
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass38_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, 100673905);
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, 100673906);
        StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, 100673907);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462125, RefRangeEnd = 1462126, XrefRangeStart = 1462122, XrefRangeEnd = 1462125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462129, RefRangeEnd = 1462130, XrefRangeStart = 1462126, XrefRangeEnd = 1462129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders>.NativeClassPtr, 100673908);
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders>.NativeClassPtr, 100673909);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyCriticalStrikeJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001948$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, "RunWithoutJobSystem_00001948$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673910);
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673911);
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673912);
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673913);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyCriticalStrikeJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001948$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462130, XrefRangeEnd = 1462144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462144, XrefRangeEnd = 1462162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462162, XrefRangeEnd = 1462177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462204, RefRangeEnd = 1462205, XrefRangeStart = 1462177, XrefRangeEnd = 1462204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob>.NativeClassPtr, "RunWithoutJobSystem_00001948$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673914);
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673915);
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673916);
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673917);
          StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673919);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyCriticalStrikeJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyEmpowerJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyEmpowerJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_empowerBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass39_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass39_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass39_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<Buff> buffs;
      [FieldOffset(16)]
      public NativeArray<EmpowerBuff> empowerBuffs;
      [FieldOffset(32)]
      public ComponentDataFromEntity<EntityOwner> _ComponentDataFromEntity_EntityOwner_0;
      [FieldOffset(64)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462329, XrefRangeEnd = 1462342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 755494, RefRangeEnd = 755501, XrefRangeStart = 755494, XrefRangeEnd = 755501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass39_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass39_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 755501, RefRangeEnd = 755508, XrefRangeStart = 755501, XrefRangeEnd = 755508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass39_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass39_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462342, XrefRangeEnd = 1462344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462349, RefRangeEnd = 1462350, XrefRangeStart = 1462344, XrefRangeEnd = 1462349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462355, RefRangeEnd = 1462356, XrefRangeStart = 1462350, XrefRangeEnd = 1462355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass39_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass39_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462356, XrefRangeEnd = 1462360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462360, XrefRangeEnd = 1462366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyEmpowerJob()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyEmpowerJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, nameof (buffs));
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr_empowerBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, nameof (empowerBuffs));
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityOwner_0));
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, 100673920);
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass39_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, 100673921);
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass39_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, 100673922);
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, 100673923);
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, 100673924);
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass39_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, 100673925);
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, 100673926);
        StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, 100673927);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462249, RefRangeEnd = 1462250, XrefRangeStart = 1462246, XrefRangeEnd = 1462249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462253, RefRangeEnd = 1462254, XrefRangeStart = 1462250, XrefRangeEnd = 1462253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders>.NativeClassPtr, 100673928);
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders>.NativeClassPtr, 100673929);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyEmpowerJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001951$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, "RunWithoutJobSystem_00001951$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673930);
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673931);
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673932);
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673933);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyEmpowerJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001951$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462254, XrefRangeEnd = 1462268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462268, XrefRangeEnd = 1462286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462286, XrefRangeEnd = 1462301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462328, RefRangeEnd = 1462329, XrefRangeStart = 1462301, XrefRangeEnd = 1462328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob>.NativeClassPtr, "RunWithoutJobSystem_00001951$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673934);
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673935);
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673936);
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673937);
          StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673939);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyEmpowerJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyFirstStrikeJob_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyFirstStrikeJob_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_firstStrikeOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_FirstStrike_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<Entity, float> firstStrikeOwners;
      [FieldOffset(16)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462455, XrefRangeEnd = 1462458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref BloodBuffScript_FirstStrike firstStrike,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref firstStrike;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_FirstStrike_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass41_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass41_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462458, XrefRangeEnd = 1462460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462468, RefRangeEnd = 1462469, XrefRangeStart = 1462460, XrefRangeEnd = 1462468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462471, RefRangeEnd = 1462472, XrefRangeStart = 1462469, XrefRangeEnd = 1462471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass41_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass41_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462472, XrefRangeEnd = 1462476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462476, XrefRangeEnd = 1462482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyFirstStrikeJob_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyFirstStrikeJob_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeFieldInfoPtr_firstStrikeOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, nameof (firstStrikeOwners));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_FirstStrike_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, 100673940);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, 100673941);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, 100673942);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, 100673943);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, 100673944);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, 100673945);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, 100673946);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, 100673947);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_firstStrike;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<BloodBuffScript_FirstStrike> forParameter_firstStrike;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462372, RefRangeEnd = 1462373, XrefRangeStart = 1462366, XrefRangeEnd = 1462372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462379, RefRangeEnd = 1462380, XrefRangeStart = 1462373, XrefRangeEnd = 1462379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_firstStrike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_firstStrike));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders>.NativeClassPtr, 100673948);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders>.NativeClassPtr, 100673949);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_firstStrike;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<BloodBuffScript_FirstStrike>.Runtime runtime_firstStrike;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_firstStrike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_firstStrike));
            StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyFirstStrikeJob_0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000195A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, "RunWithoutJobSystem_0000195A$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673950);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673951);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673952);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673953);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyFirstStrikeJob_0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000195A$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462380, XrefRangeEnd = 1462394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462394, XrefRangeEnd = 1462412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462412, XrefRangeEnd = 1462427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462454, RefRangeEnd = 1462455, XrefRangeStart = 1462427, XrefRangeEnd = 1462454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0>.NativeClassPtr, "RunWithoutJobSystem_0000195A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673954);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673955);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673956);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673957);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673959);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyFirstStrikeJob_1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyFirstStrikeJob_1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_firstStrikeOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashMap<Entity, float> firstStrikeOwners;
      [FieldOffset(24)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462565, XrefRangeEnd = 1462578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 736558, RefRangeEnd = 736560, XrefRangeStart = 736558, XrefRangeEnd = 736560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass41_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 736560, RefRangeEnd = 736562, XrefRangeStart = 736560, XrefRangeEnd = 736562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass41_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462578, XrefRangeEnd = 1462580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462585, RefRangeEnd = 1462586, XrefRangeStart = 1462580, XrefRangeEnd = 1462585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462588, RefRangeEnd = 1462589, XrefRangeStart = 1462586, XrefRangeEnd = 1462588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass41_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass41_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462589, XrefRangeEnd = 1462593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462593, XrefRangeEnd = 1462599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyFirstStrikeJob_1()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyFirstStrikeJob_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, nameof (entityManager));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeFieldInfoPtr_firstStrikeOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, nameof (firstStrikeOwners));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, 100673960);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, 100673961);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, 100673962);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, 100673963);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, 100673964);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, 100673965);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, 100673966);
        StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, 100673967);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462485, RefRangeEnd = 1462486, XrefRangeStart = 1462482, XrefRangeEnd = 1462485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462489, RefRangeEnd = 1462490, XrefRangeStart = 1462486, XrefRangeEnd = 1462489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders>.NativeClassPtr, 100673968);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders>.NativeClassPtr, 100673969);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyFirstStrikeJob_1/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001963$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, "RunWithoutJobSystem_00001963$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673970);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673971);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673972);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673973);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyFirstStrikeJob_1/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001963$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462490, XrefRangeEnd = 1462504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462504, XrefRangeEnd = 1462522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462522, XrefRangeEnd = 1462537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462564, RefRangeEnd = 1462565, XrefRangeStart = 1462537, XrefRangeEnd = 1462564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1>.NativeClassPtr, "RunWithoutJobSystem_00001963$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673974);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673975);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673976);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673977);
          StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673979);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyFirstStrikeJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyIncreaseMountAttackJob_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyIncreaseMountAttackJob_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayNight;
      private static readonly System.IntPtr NativeFieldInfoPtr_mountIncreasedDamageOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_Rogue_MountDamageBonus_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass43_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public DayNightCycle dayNight;
      [FieldOffset(144)]
      public NativeHashMap<Entity, float> mountIncreasedDamageOwners;
      [FieldOffset(160)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(224)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462688, XrefRangeEnd = 1462696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref BloodBuffScript_Rogue_MountDamageBonus mountDamageIncreaseBuff,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref mountDamageIncreaseBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_Rogue_MountDamageBonus_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462696, RefRangeEnd = 1462697, XrefRangeStart = 1462696, XrefRangeEnd = 1462696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass43_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462697, RefRangeEnd = 1462698, XrefRangeStart = 1462697, XrefRangeEnd = 1462697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass43_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462698, XrefRangeEnd = 1462700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462708, RefRangeEnd = 1462709, XrefRangeStart = 1462700, XrefRangeEnd = 1462708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462711, RefRangeEnd = 1462712, XrefRangeStart = 1462709, XrefRangeEnd = 1462711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass43_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass43_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462712, XrefRangeEnd = 1462716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462716, XrefRangeEnd = 1462722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyIncreaseMountAttackJob_0()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyIncreaseMountAttackJob_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, nameof (entityManager));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr_dayNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, nameof (dayNight));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr_mountIncreasedDamageOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, nameof (mountIncreasedDamageOwners));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BloodBuffScript_Rogue_MountDamageBonus_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, 100673980);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, 100673981);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, 100673982);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, 100673983);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, 100673984);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, 100673985);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, 100673986);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, 100673987);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mountDamageIncreaseBuff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<BloodBuffScript_Rogue_MountDamageBonus> forParameter_mountDamageIncreaseBuff;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462605, RefRangeEnd = 1462606, XrefRangeStart = 1462599, XrefRangeEnd = 1462605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462612, RefRangeEnd = 1462613, XrefRangeStart = 1462606, XrefRangeEnd = 1462612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mountDamageIncreaseBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mountDamageIncreaseBuff));
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders>.NativeClassPtr, 100673988);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders>.NativeClassPtr, 100673989);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mountDamageIncreaseBuff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<BloodBuffScript_Rogue_MountDamageBonus>.Runtime runtime_mountDamageIncreaseBuff;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mountDamageIncreaseBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mountDamageIncreaseBuff));
            StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyIncreaseMountAttackJob_0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000196C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, "RunWithoutJobSystem_0000196C$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673990);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673991);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673992);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673993);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyIncreaseMountAttackJob_0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000196C$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462613, XrefRangeEnd = 1462627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462627, XrefRangeEnd = 1462645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462645, XrefRangeEnd = 1462660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462687, RefRangeEnd = 1462688, XrefRangeStart = 1462660, XrefRangeEnd = 1462687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0>.NativeClassPtr, "RunWithoutJobSystem_0000196C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673994);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673995);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673996);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673997);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673999);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyIncreaseMountAttackJob_1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyIncreaseMountAttackJob_1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_mountIncreasedDamageOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass43_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashMap<Entity, float> mountIncreasedDamageOwners;
      [FieldOffset(24)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462805, XrefRangeEnd = 1462819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462819, RefRangeEnd = 1462820, XrefRangeStart = 1462819, XrefRangeEnd = 1462819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass43_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462820, RefRangeEnd = 1462821, XrefRangeStart = 1462820, XrefRangeEnd = 1462820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeMutationSystem.__c__DisplayClass43_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462821, XrefRangeEnd = 1462823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462828, RefRangeEnd = 1462829, XrefRangeStart = 1462823, XrefRangeEnd = 1462828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462831, RefRangeEnd = 1462832, XrefRangeStart = 1462829, XrefRangeEnd = 1462831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeMutationSystem componentSystem,
        ref StatChangeMutationSystem.__c__DisplayClass43_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass43_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462832, XrefRangeEnd = 1462836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462836, XrefRangeEnd = 1462842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyIncreaseMountAttackJob_1()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyIncreaseMountAttackJob_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, nameof (entityManager));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeFieldInfoPtr_mountIncreasedDamageOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, nameof (mountIncreasedDamageOwners));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, 100674000);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, 100674001);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, 100674002);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, 100674003);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, 100674004);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_byref___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, 100674005);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, 100674006);
        StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, 100674007);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462725, RefRangeEnd = 1462726, XrefRangeStart = 1462722, XrefRangeEnd = 1462725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462729, RefRangeEnd = 1462730, XrefRangeStart = 1462726, XrefRangeEnd = 1462729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders>.NativeClassPtr, 100674008);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders>.NativeClassPtr, 100674009);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyIncreaseMountAttackJob_1/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001975$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, "RunWithoutJobSystem_00001975$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674010);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674011);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674012);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674013);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyIncreaseMountAttackJob_1/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001975$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462730, XrefRangeEnd = 1462744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462744, XrefRangeEnd = 1462762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462762, XrefRangeEnd = 1462777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462804, RefRangeEnd = 1462805, XrefRangeStart = 1462777, XrefRangeEnd = 1462804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1>.NativeClassPtr, "RunWithoutJobSystem_00001975$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674014);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674015);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674016);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674017);
          StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674019);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyIncreaseMountAttackJob_1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyInvulnerableJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ApplyInvulnerableJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<BuffableFlagState> _ComponentDataFromEntity_BuffableFlagState_0;
      [FieldOffset(32)]
      public StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462925, XrefRangeEnd = 1462933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_byref_StatChangeEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462933, XrefRangeEnd = 1462935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462940, RefRangeEnd = 1462941, XrefRangeStart = 1462935, XrefRangeEnd = 1462940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1462945, RefRangeEnd = 1462946, XrefRangeStart = 1462941, XrefRangeEnd = 1462945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462946, XrefRangeEnd = 1462950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462950, XrefRangeEnd = 1462956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ApplyInvulnerableJob()
      {
        Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem>.NativeClassPtr, "<>c__DisplayClass_ApplyInvulnerableJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr);
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_BuffableFlagState_0));
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, nameof (_runtimes));
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, 100674020);
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, 100674021);
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, 100674022);
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, 100674023);
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, 100674024);
        StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, 100674025);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statChangeEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatChangeEvent> forParameter_statChangeEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462845, RefRangeEnd = 1462846, XrefRangeStart = 1462842, XrefRangeEnd = 1462845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StatChangeMutationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462849, RefRangeEnd = 1462850, XrefRangeStart = 1462846, XrefRangeEnd = 1462849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statChangeEvent));
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeMutationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders>.NativeClassPtr, 100674026);
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders>.NativeClassPtr, 100674027);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statChangeEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StatChangeEvent>.Runtime runtime_statChangeEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statChangeEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyInvulnerableJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000197C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, "RunWithoutJobSystem_0000197C$PostfixBurstDelegate");
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674028);
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674029);
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674030);
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674031);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeMutationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ApplyInvulnerableJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_0000197C$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462850, XrefRangeEnd = 1462864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462864, XrefRangeEnd = 1462882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1462882, XrefRangeEnd = 1462897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1462924, RefRangeEnd = 1462925, XrefRangeStart = 1462897, XrefRangeEnd = 1462924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob>.NativeClassPtr, "RunWithoutJobSystem_0000197C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674032);
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674033);
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674034);
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674035);
          StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674037);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeMutationSystem.__c__DisplayClass_ApplyInvulnerableJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
