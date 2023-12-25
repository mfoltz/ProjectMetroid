// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.StatChangeSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class StatChangeSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__ScriptMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr__StatChangeMutationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DamageTakenEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MergedChanges;
    private static readonly System.IntPtr NativeFieldInfoPtr__MergedChangeEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerBalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr___MergeStatChanges_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyStatChanges_Private_Void_NativeArray_1_Entity_NativeArray_1_StatChangeEvent_EntityCommandBuffer_Double_byref_ServerGameBalanceSettings_byref_SyncedServerDebugSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MergeStatChanges_Private_Static_Void_NativeArray_1_Entity_NativeArray_1_StatChangeEvent_NativeList_1_Entity_NativeList_1_StatChangeEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBloodChangeToEntity_Private_Void_Entity_StatChangeEvent_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEnergyChangeToEntity_Private_Void_Entity_StatChangeEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyHealthChangeToEntity_Private_Void_Entity_StatChangeEvent_EntityCommandBuffer_Double_byref_ServerGameBalanceSettings_byref_SyncedServerDebugSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPvPReductionFactor_Private_Single_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCrowdednessWeakenFactor_Private_Single_byref_SyncedServerDebugSettings_Entity_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalWeakenFactor_Private_Single_DynamicallyWeakenAttackers_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FetchResourceYieldFactor_Private_Void_StatChangeEvent_byref_UnitStats_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDamageTakenEvent_Private_Void_byref_StatChangeEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCastleAttacked_Public_Static_Void_EntityManager_Entity_Double_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnnounceCastleAttack_Public_Static_Void_EntityManager_Entity_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464847, XrefRangeEnd = 1464890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatChangeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464890, XrefRangeEnd = 1464907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatChangeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464907, XrefRangeEnd = 1464985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatChangeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1465029, RefRangeEnd = 1465030, XrefRangeStart = 1464985, XrefRangeEnd = 1465029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyStatChanges(
      NativeArray<Entity> statChangeEntities,
      NativeArray<StatChangeEvent> statChanges,
      EntityCommandBuffer commandBuffer,
      double currentTime,
      [In] ref ServerGameBalanceSettings serverGameBalanceSettings,
      [In] ref SyncedServerDebugSettings syncedServerDebugSettings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &statChangeEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statChanges;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &currentTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverGameBalanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref syncedServerDebugSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_ApplyStatChanges_Private_Void_NativeArray_1_Entity_NativeArray_1_StatChangeEvent_EntityCommandBuffer_Double_byref_ServerGameBalanceSettings_byref_SyncedServerDebugSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1465047, RefRangeEnd = 1465048, XrefRangeStart = 1465030, XrefRangeEnd = 1465047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void MergeStatChanges(
      NativeArray<Entity> statChangeEntities,
      NativeArray<StatChangeEvent> statChanges,
      NativeList<Entity> mergedChangeEntities,
      NativeList<StatChangeEvent> mergedChanges)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &statChangeEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statChanges;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mergedChangeEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mergedChanges;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_MergeStatChanges_Private_Static_Void_NativeArray_1_Entity_NativeArray_1_StatChangeEvent_NativeList_1_Entity_NativeList_1_StatChangeEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1465165, RefRangeEnd = 1465166, XrefRangeStart = 1465048, XrefRangeEnd = 1465165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyBloodChangeToEntity(
      Entity statChangeEntity,
      StatChangeEvent statChange,
      EntityCommandBuffer commandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &statChangeEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statChange;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_ApplyBloodChangeToEntity_Private_Void_Entity_StatChangeEvent_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1465200, RefRangeEnd = 1465201, XrefRangeStart = 1465166, XrefRangeEnd = 1465200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyEnergyChangeToEntity(
      Entity statChangeEntity,
      StatChangeEvent statChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &statChangeEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statChange;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_ApplyEnergyChangeToEntity_Private_Void_Entity_StatChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1465305, RefRangeEnd = 1465306, XrefRangeStart = 1465201, XrefRangeEnd = 1465305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyHealthChangeToEntity(
      Entity statChangeEntity,
      StatChangeEvent statChange,
      EntityCommandBuffer commandBuffer,
      double currentTime,
      [In] ref ServerGameBalanceSettings serverGameBalanceSettings,
      [In] ref SyncedServerDebugSettings syncedServerDebugSettings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &statChangeEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statChange;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &currentTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverGameBalanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref syncedServerDebugSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_ApplyHealthChangeToEntity_Private_Void_Entity_StatChangeEvent_EntityCommandBuffer_Double_byref_ServerGameBalanceSettings_byref_SyncedServerDebugSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1465306, XrefRangeEnd = 1465343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetPvPReductionFactor(
      EntityManager entityManager,
      Entity dealer,
      Entity target)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dealer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_GetPvPReductionFactor_Private_Single_EntityManager_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1465343, XrefRangeEnd = 1465353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetCrowdednessWeakenFactor(
      [In] ref SyncedServerDebugSettings syncedServerDebugSettings,
      Entity source,
      Entity targetEntity,
      float change)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref syncedServerDebugSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &change;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_GetCrowdednessWeakenFactor_Private_Single_byref_SyncedServerDebugSettings_Entity_Entity_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1465353, XrefRangeEnd = 1465355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetFinalWeakenFactor(DynamicallyWeakenAttackers target, float nearbyPlayers)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nearbyPlayers;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_GetFinalWeakenFactor_Private_Single_DynamicallyWeakenAttackers_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FetchResourceYieldFactor(
      StatChangeEvent statChange,
      ref UnitStats unitStats,
      ref float resourceFactorMaterial)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &statChange;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref unitStats;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref resourceFactorMaterial;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_FetchResourceYieldFactor_Private_Void_StatChangeEvent_byref_UnitStats_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1465355, XrefRangeEnd = 1465376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateDamageTakenEvent([In] ref StatChangeEvent statChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref statChange;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_CreateDamageTakenEvent_Private_Void_byref_StatChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1465388, RefRangeEnd = 1465389, XrefRangeStart = 1465376, XrefRangeEnd = 1465388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetCastleAttacked(
      EntityManager entityManager,
      Entity structure,
      double serverTime,
      float castleUnderAttackTimer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &structure;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &castleUnderAttackTimer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_SetCastleAttacked_Public_Static_Void_EntityManager_Entity_Double_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1465425, RefRangeEnd = 1465426, XrefRangeStart = 1465389, XrefRangeEnd = 1465425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AnnounceCastleAttack(
      EntityManager entityManager,
      Entity structure,
      double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &structure;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_AnnounceCastleAttack_Public_Static_Void_EntityManager_Entity_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatChangeSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1465426, XrefRangeEnd = 1465443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatChangeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1465447, RefRangeEnd = 1465448, XrefRangeStart = 1465443, XrefRangeEnd = 1465447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StatChangeSystem()
    {
      Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (StatChangeSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr);
      StatChangeSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, nameof (_Query));
      StatChangeSystem.NativeFieldInfoPtr__ScriptMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, nameof (_ScriptMapper));
      StatChangeSystem.NativeFieldInfoPtr__StatChangeMutationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, nameof (_StatChangeMutationSystem));
      StatChangeSystem.NativeFieldInfoPtr__DamageTakenEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, nameof (_DamageTakenEventQuery));
      StatChangeSystem.NativeFieldInfoPtr__MergedChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, nameof (_MergedChanges));
      StatChangeSystem.NativeFieldInfoPtr__MergedChangeEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, nameof (_MergedChangeEntities));
      StatChangeSystem.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, nameof (_ServerTimeAccessor));
      StatChangeSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, nameof (_SyncedServerDebugSettingsAccessor));
      StatChangeSystem.NativeFieldInfoPtr__ServerBalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, nameof (_ServerBalanceSettings));
      StatChangeSystem.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      StatChangeSystem.NativeFieldInfoPtr___MergeStatChanges_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, "<>MergeStatChanges_profilerMarker");
      StatChangeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674038);
      StatChangeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674039);
      StatChangeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674040);
      StatChangeSystem.NativeMethodInfoPtr_ApplyStatChanges_Private_Void_NativeArray_1_Entity_NativeArray_1_StatChangeEvent_EntityCommandBuffer_Double_byref_ServerGameBalanceSettings_byref_SyncedServerDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674041);
      StatChangeSystem.NativeMethodInfoPtr_MergeStatChanges_Private_Static_Void_NativeArray_1_Entity_NativeArray_1_StatChangeEvent_NativeList_1_Entity_NativeList_1_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674042);
      StatChangeSystem.NativeMethodInfoPtr_ApplyBloodChangeToEntity_Private_Void_Entity_StatChangeEvent_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674043);
      StatChangeSystem.NativeMethodInfoPtr_ApplyEnergyChangeToEntity_Private_Void_Entity_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674044);
      StatChangeSystem.NativeMethodInfoPtr_ApplyHealthChangeToEntity_Private_Void_Entity_StatChangeEvent_EntityCommandBuffer_Double_byref_ServerGameBalanceSettings_byref_SyncedServerDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674045);
      StatChangeSystem.NativeMethodInfoPtr_GetPvPReductionFactor_Private_Single_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674046);
      StatChangeSystem.NativeMethodInfoPtr_GetCrowdednessWeakenFactor_Private_Single_byref_SyncedServerDebugSettings_Entity_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674047);
      StatChangeSystem.NativeMethodInfoPtr_GetFinalWeakenFactor_Private_Single_DynamicallyWeakenAttackers_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674048);
      StatChangeSystem.NativeMethodInfoPtr_FetchResourceYieldFactor_Private_Void_StatChangeEvent_byref_UnitStats_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674049);
      StatChangeSystem.NativeMethodInfoPtr_CreateDamageTakenEvent_Private_Void_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674050);
      StatChangeSystem.NativeMethodInfoPtr_SetCastleAttacked_Public_Static_Void_EntityManager_Entity_Double_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674051);
      StatChangeSystem.NativeMethodInfoPtr_AnnounceCastleAttack_Public_Static_Void_EntityManager_Entity_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674052);
      StatChangeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674053);
      StatChangeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674054);
      StatChangeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, 100674055);
    }

    public StatChangeSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe ServerScriptMapper _ScriptMapper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__ScriptMapper));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper) null : new ServerScriptMapper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__ScriptMapper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatChangeMutationSystem _StatChangeMutationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__StatChangeMutationSystem));
        return pointer == System.IntPtr.Zero ? (StatChangeMutationSystem) null : new StatChangeMutationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__StatChangeMutationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _DamageTakenEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__DamageTakenEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__DamageTakenEventQuery)) = value;
      }
    }

    public unsafe NativeList<StatChangeEvent> _MergedChanges
    {
      get
      {
        return *(NativeList<StatChangeEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__MergedChanges));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__MergedChanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<StatChangeEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _MergedChangeEntities
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__MergedChangeEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__MergedChangeEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _SyncedServerDebugSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerBalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__ServerBalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__ServerBalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProfilerMarker __MergeStatChanges_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr___MergeStatChanges_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatChangeSystem.NativeFieldInfoPtr___MergeStatChanges_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeSystem/<>c__DisplayClass13_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass13_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_statChangeEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_statChanges;
      private static readonly System.IntPtr NativeFieldInfoPtr_mergedChangeEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_mergedChanges;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ApplyStatChanges_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public NativeArray<Entity> statChangeEntities;
      [FieldOffset(16)]
      public NativeArray<StatChangeEvent> statChanges;
      [FieldOffset(32)]
      public NativeList<Entity> mergedChangeEntities;
      [FieldOffset(48)]
      public NativeList<StatChangeEvent> mergedChanges;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass13_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ApplyStatChanges_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ApplyStatChanges_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass13_0()
      {
        Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, "<>c__DisplayClass13_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass13_0>.NativeClassPtr);
        StatChangeSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_statChangeEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (statChangeEntities));
        StatChangeSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_statChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (statChanges));
        StatChangeSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_mergedChangeEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (mergedChangeEntities));
        StatChangeSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_mergedChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (mergedChanges));
        StatChangeSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass13_0>.NativeClassPtr, 100674056);
        StatChangeSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ApplyStatChanges_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass13_0>.NativeClassPtr, 100674057);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass13_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_MergeStatChanges")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_MergeStatChanges
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_statChangeEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_statChanges;
      private static readonly System.IntPtr NativeFieldInfoPtr_mergedChangeEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_mergedChanges;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeSystem_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeArray<Entity> statChangeEntities;
      [FieldOffset(16)]
      public NativeArray<StatChangeEvent> statChanges;
      [FieldOffset(32)]
      public NativeList<Entity> mergedChangeEntities;
      [FieldOffset(48)]
      public NativeList<StatChangeEvent> mergedChanges;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1464510, RefRangeEnd = 1464511, XrefRangeStart = 1464509, XrefRangeEnd = 1464510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1464511, RefRangeEnd = 1464512, XrefRangeStart = 1464511, XrefRangeEnd = 1464511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StatChangeSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1464512, RefRangeEnd = 1464513, XrefRangeStart = 1464512, XrefRangeEnd = 1464512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StatChangeSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1464514, RefRangeEnd = 1464515, XrefRangeStart = 1464513, XrefRangeEnd = 1464514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1464516, RefRangeEnd = 1464517, XrefRangeStart = 1464515, XrefRangeEnd = 1464516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StatChangeSystem componentSystem,
        ref StatChangeSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeSystem_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464517, XrefRangeEnd = 1464521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1464846, RefRangeEnd = 1464847, XrefRangeStart = 1464521, XrefRangeEnd = 1464846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_MergeStatChanges()
      {
        Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeSystem>.NativeClassPtr, "<>c__DisplayClass_MergeStatChanges");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr);
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeFieldInfoPtr_statChangeEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, nameof (statChangeEntities));
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeFieldInfoPtr_statChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, nameof (statChanges));
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeFieldInfoPtr_mergedChangeEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, nameof (mergedChangeEntities));
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeFieldInfoPtr_mergedChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, nameof (mergedChanges));
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, 100674058);
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, 100674059);
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, 100674060);
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, 100674061);
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StatChangeSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, 100674062);
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, 100674063);
        StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, 100674064);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StatChangeSystem.__c__DisplayClass_MergeStatChanges.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_MergeStatChanges/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001997$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, "RunWithoutJobSystem_00001997$PostfixBurstDelegate");
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100674065);
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100674066);
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100674067);
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100674068);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.StatChangeSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_MergeStatChanges/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001997$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464434, XrefRangeEnd = 1464448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464448, XrefRangeEnd = 1464466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1464466, XrefRangeEnd = 1464481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1464508, RefRangeEnd = 1464509, XrefRangeStart = 1464481, XrefRangeEnd = 1464508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges>.NativeClassPtr, "RunWithoutJobSystem_00001997$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674069);
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674070);
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674071);
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674072);
          StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674074);
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
            IL2CPP.il2cpp_field_static_get_value(StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StatChangeSystem.__c__DisplayClass_MergeStatChanges.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
