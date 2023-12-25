// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.DealDamageSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Debugging;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class DealDamageSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerBalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__BlinkSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_16;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeFromEntity_Private_Static_DealDamageTargetTypeEnum_byref_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DealDamage_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEncounterPvP_Private_Static_Boolean_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldTakeDamage_Private_Static_Boolean_byref_SystemInput_Entity_Entity_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_byref_DealDamageResultEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDamage_Private_Static_Single_byref_SystemInput_byref_DealDamageEvent_Entity_byref_UnitStats_Single_Single_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_byref_EntityCategory_DealDamageRecorder_byref_Boolean_byref_UnitLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPvEDamageModifier_Private_Static_Single_byref_SystemInput_byref_DealDamageEvent_Entity_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_EntityCategory_byref_Boolean_byref_UnitLevel_EntityTypeModifiers_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUnitStats_Private_Static_Single_byref_SystemInput_DealDamageEvent_Entity_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_Equipment_UnitLevel_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435811, XrefRangeEnd = 1435839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DealDamageSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435839, XrefRangeEnd = 1435845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DealDamageSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435845, XrefRangeEnd = 1435853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DealDamageSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1435871, RefRangeEnd = 1435873, XrefRangeStart = 1435853, XrefRangeEnd = 1435871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DealDamageTargetTypeEnum GetTypeFromEntity(
      ref EntityManager entityManager,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageSystem.NativeMethodInfoPtr_GetTypeFromEntity_Private_Static_DealDamageTargetTypeEnum_byref_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DealDamageTargetTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1436068, RefRangeEnd = 1436069, XrefRangeStart = 1435873, XrefRangeEnd = 1436068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DealDamage()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DealDamageSystem.NativeMethodInfoPtr_DealDamage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe bool IsEncounterPvP(
      DealDamageTargetTypeEnum dealerType,
      DealDamageTargetTypeEnum targetType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dealerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageSystem.NativeMethodInfoPtr_IsEncounterPvP_Private_Static_Boolean_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1436098, RefRangeEnd = 1436099, XrefRangeStart = 1436069, XrefRangeEnd = 1436098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShouldTakeDamage(
      ref DealDamageSystem.SystemInput input,
      Entity target,
      Entity dealer,
      DealDamageTargetTypeEnum dealerType,
      DealDamageTargetTypeEnum targetType,
      out DealDamageResultEnum dealDamageResult)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dealer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dealerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &targetType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref dealDamageResult;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageSystem.NativeMethodInfoPtr_ShouldTakeDamage_Private_Static_Boolean_byref_SystemInput_Entity_Entity_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_byref_DealDamageResultEnum_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1436207, RefRangeEnd = 1436208, XrefRangeStart = 1436099, XrefRangeEnd = 1436207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetDamage(
      ref DealDamageSystem.SystemInput input,
      [In] ref DealDamageEvent dealDamage,
      Entity dealer,
      [In] ref UnitStats dealerUnitStats,
      float maxHealth,
      float currentHealth,
      DealDamageTargetTypeEnum dealerType,
      DealDamageTargetTypeEnum targetType,
      ref EntityCategory targetEntityCategory,
      DealDamageRecorder dealDamageRecorder,
      out bool resourceLevelSufficient,
      out UnitLevel unitLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dealDamage;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dealer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref dealerUnitStats;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxHealth;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &currentHealth;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &dealerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &targetType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetEntityCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &dealDamageRecorder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref resourceLevelSufficient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref unitLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageSystem.NativeMethodInfoPtr_GetDamage_Private_Static_Single_byref_SystemInput_byref_DealDamageEvent_Entity_byref_UnitStats_Single_Single_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_byref_EntityCategory_DealDamageRecorder_byref_Boolean_byref_UnitLevel_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1436235, RefRangeEnd = 1436236, XrefRangeStart = 1436208, XrefRangeEnd = 1436235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetPvEDamageModifier(
      ref DealDamageSystem.SystemInput input,
      [In] ref DealDamageEvent dealDamage,
      Entity dealer,
      DealDamageTargetTypeEnum dealerType,
      DealDamageTargetTypeEnum targetType,
      EntityCategory targetEntityCategory,
      out bool resourceLevelSufficient,
      out UnitLevel unitLevel,
      EntityTypeModifiers sourceModifiers)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dealDamage;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dealer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dealerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &targetType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntityCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref resourceLevelSufficient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref unitLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceModifiers;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageSystem.NativeMethodInfoPtr_GetPvEDamageModifier_Private_Static_Single_byref_SystemInput_byref_DealDamageEvent_Entity_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_EntityCategory_byref_Boolean_byref_UnitLevel_EntityTypeModifiers_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1436278, RefRangeEnd = 1436279, XrefRangeStart = 1436236, XrefRangeEnd = 1436278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetUnitStats(
      ref DealDamageSystem.SystemInput input,
      DealDamageEvent dealDamage,
      Entity dealer,
      DealDamageTargetTypeEnum dealerType,
      DealDamageTargetTypeEnum targetType,
      Equipment playerEquipment,
      UnitLevel targetUnitLevel,
      float damageModifier)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dealDamage;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dealer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dealerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &targetType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &playerEquipment;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &targetUnitLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &damageModifier;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageSystem.NativeMethodInfoPtr_GetUnitStats_Private_Static_Single_byref_SystemInput_DealDamageEvent_Entity_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_Equipment_UnitLevel_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DealDamageSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DealDamageSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1436279, XrefRangeEnd = 1436287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DealDamageSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DealDamageSystem()
    {
      Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (DealDamageSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr);
      DealDamageSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, nameof (_Query));
      DealDamageSystem.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, nameof (_ServerDebugSettings));
      DealDamageSystem.NativeFieldInfoPtr__ServerBalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, nameof (_ServerBalanceSettings));
      DealDamageSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      DealDamageSystem.NativeFieldInfoPtr__BlinkSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, nameof (_BlinkSystem));
      DealDamageSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_16));
      DealDamageSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671283);
      DealDamageSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671284);
      DealDamageSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671285);
      DealDamageSystem.NativeMethodInfoPtr_GetTypeFromEntity_Private_Static_DealDamageTargetTypeEnum_byref_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671286);
      DealDamageSystem.NativeMethodInfoPtr_DealDamage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671287);
      DealDamageSystem.NativeMethodInfoPtr_IsEncounterPvP_Private_Static_Boolean_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671288);
      DealDamageSystem.NativeMethodInfoPtr_ShouldTakeDamage_Private_Static_Boolean_byref_SystemInput_Entity_Entity_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_byref_DealDamageResultEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671289);
      DealDamageSystem.NativeMethodInfoPtr_GetDamage_Private_Static_Single_byref_SystemInput_byref_DealDamageEvent_Entity_byref_UnitStats_Single_Single_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_byref_EntityCategory_DealDamageRecorder_byref_Boolean_byref_UnitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671290);
      DealDamageSystem.NativeMethodInfoPtr_GetPvEDamageModifier_Private_Static_Single_byref_SystemInput_byref_DealDamageEvent_Entity_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_EntityCategory_byref_Boolean_byref_UnitLevel_EntityTypeModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671291);
      DealDamageSystem.NativeMethodInfoPtr_GetUnitStats_Private_Static_Single_byref_SystemInput_DealDamageEvent_Entity_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_Equipment_UnitLevel_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671292);
      DealDamageSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671293);
      DealDamageSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, 100671294);
    }

    public DealDamageSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerBalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__ServerBalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__ServerBalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlinkSystems_Server _BlinkSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__BlinkSystem));
        return pointer == System.IntPtr.Zero ? (BlinkSystems_Server) null : new BlinkSystems_Server(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__BlinkSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerTime_16
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_16));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_16)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SystemInput
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextEventPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectedOUT_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectedIN_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_PvECastleDamage_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_PvPCastleDamageOutsideTime_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlinksPerUser;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsVampirePvpDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastlePvpMode;
      [FieldOffset(0)]
      public EntityManager EntityManager;
      [FieldOffset(8)]
      public double ServerTime;
      [FieldOffset(16)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(32)]
      public Entity ScrollingCombatTextEventPrefab;
      [FieldOffset(40)]
      public PrefabGUID PvPProtectedOUT_Type;
      [FieldOffset(44)]
      public PrefabGUID PvPProtectedIN_Type;
      [FieldOffset(48)]
      public PrefabGUID PvECastleDamage_Type;
      [FieldOffset(52)]
      public PrefabGUID PvPCastleDamageOutsideTime_Type;
      [FieldOffset(56)]
      public NativeList<PerUserBlinkEvent> BlinksPerUser;
      [FieldOffset(72)]
      public bool IsVampirePvpDisabled;
      [FieldOffset(76)]
      public ServerGameBalanceSettings.CastlePvPEnabledType CastlePvpMode;

      static SystemInput()
      {
        Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealDamageSystem>.NativeClassPtr, nameof (SystemInput));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr);
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (EntityManager));
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (ServerTime));
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (CommandBuffer));
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_ScrollingCombatTextEventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (ScrollingCombatTextEventPrefab));
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_PvPProtectedOUT_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (PvPProtectedOUT_Type));
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_PvPProtectedIN_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (PvPProtectedIN_Type));
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_PvECastleDamage_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (PvECastleDamage_Type));
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_PvPCastleDamageOutsideTime_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (PvPCastleDamageOutsideTime_Type));
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_BlinksPerUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (BlinksPerUser));
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_IsVampirePvpDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (IsVampirePvpDisabled));
        DealDamageSystem.SystemInput.NativeFieldInfoPtr_CastlePvpMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, nameof (CastlePvpMode));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageSystem.SystemInput>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
