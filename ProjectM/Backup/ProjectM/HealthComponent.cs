// Decompiled with JetBrains decompiler
// Type: ProjectM.HealthComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class HealthComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_UnitBaseStatsType;
    private static readonly IntPtr NativeFieldInfoPtr_UnitStatsAssetSettings;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideMaxHealth;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideMaxHealthFactor;
    private static readonly IntPtr NativeFieldInfoPtr_DynamicHealthScalingSettings;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideDynamicHealthScalingMultiplier;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideMultiplierReductionFactorPerCrowdedness;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyOnDeath;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyAfterDuration;
    private static readonly IntPtr NativeFieldInfoPtr_LowHealthFactor;
    private static readonly IntPtr NativeFieldInfoPtr_LowHealthSequence;
    private static readonly IntPtr NativeFieldInfoPtr_DisableDamageSCT;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_RunTest_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010508, XrefRangeEnd = 1010533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HealthComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010533, XrefRangeEnd = 1010552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunTest(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HealthComponent.NativeMethodInfoPtr_RunTest_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010552, XrefRangeEnd = 1010562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HealthComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HealthComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HealthComponent()
    {
      Il2CppClassPointerStore<HealthComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HealthComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr);
      HealthComponent.NativeFieldInfoPtr_UnitBaseStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (UnitBaseStatsType));
      HealthComponent.NativeFieldInfoPtr_UnitStatsAssetSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (UnitStatsAssetSettings));
      HealthComponent.NativeFieldInfoPtr_OverrideMaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (OverrideMaxHealth));
      HealthComponent.NativeFieldInfoPtr_OverrideMaxHealthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (OverrideMaxHealthFactor));
      HealthComponent.NativeFieldInfoPtr_DynamicHealthScalingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (DynamicHealthScalingSettings));
      HealthComponent.NativeFieldInfoPtr_OverrideDynamicHealthScalingMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (OverrideDynamicHealthScalingMultiplier));
      HealthComponent.NativeFieldInfoPtr_OverrideMultiplierReductionFactorPerCrowdedness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (OverrideMultiplierReductionFactorPerCrowdedness));
      HealthComponent.NativeFieldInfoPtr_DestroyOnDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (DestroyOnDeath));
      HealthComponent.NativeFieldInfoPtr_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (DestroyAfterDuration));
      HealthComponent.NativeFieldInfoPtr_LowHealthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (LowHealthFactor));
      HealthComponent.NativeFieldInfoPtr_LowHealthSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (LowHealthSequence));
      HealthComponent.NativeFieldInfoPtr_DisableDamageSCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, nameof (DisableDamageSCT));
      HealthComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, 100678580);
      HealthComponent.NativeMethodInfoPtr_RunTest_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, 100678581);
      HealthComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthComponent>.NativeClassPtr, 100678582);
    }

    public HealthComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnitBaseStatsType UnitBaseStatsType
    {
      get
      {
        return *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_UnitBaseStatsType));
      }
      [param: In] set
      {
        *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_UnitBaseStatsType)) = value;
      }
    }

    public unsafe Unit_StatsSettings_Asset UnitStatsAssetSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_UnitStatsAssetSettings));
        return pointer == IntPtr.Zero ? (Unit_StatsSettings_Asset) null : new Unit_StatsSettings_Asset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_UnitStatsAssetSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float OverrideMaxHealth
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_OverrideMaxHealth));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_OverrideMaxHealth)) = value;
      }
    }

    public unsafe float OverrideMaxHealthFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_OverrideMaxHealthFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_OverrideMaxHealthFactor)) = value;
      }
    }

    public unsafe DynamicHealthScalingSettingsAsset DynamicHealthScalingSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_DynamicHealthScalingSettings));
        return pointer == IntPtr.Zero ? (DynamicHealthScalingSettingsAsset) null : new DynamicHealthScalingSettingsAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_DynamicHealthScalingSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float OverrideDynamicHealthScalingMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_OverrideDynamicHealthScalingMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_OverrideDynamicHealthScalingMultiplier)) = value;
      }
    }

    public unsafe float OverrideMultiplierReductionFactorPerCrowdedness
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_OverrideMultiplierReductionFactorPerCrowdedness));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_OverrideMultiplierReductionFactorPerCrowdedness)) = value;
      }
    }

    public unsafe bool DestroyOnDeath
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_DestroyOnDeath));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_DestroyOnDeath)) = value;
      }
    }

    public unsafe float DestroyAfterDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_DestroyAfterDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_DestroyAfterDuration)) = value;
      }
    }

    public unsafe float LowHealthFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_LowHealthFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_LowHealthFactor)) = value;
      }
    }

    public unsafe SequenceField LowHealthSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_LowHealthSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_LowHealthSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool DisableDamageSCT
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_DisableDamageSCT));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HealthComponent.NativeFieldInfoPtr_DisableDamageSCT)) = value;
      }
    }
  }
}
