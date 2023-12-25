// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnMinionOnGameplayEventAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class SpawnMinionOnGameplayEventAuthoring : OnGameplayEventAuthoring
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinionPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabPickMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Location;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventTargetAggroBoost;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistanceFromPreCombatPositionOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeInMinionCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanBeConsumed;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideBloodQualityCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_InheritOwnerFaction;
    private static readonly System.IntPtr NativeFieldInfoPtr_InheritOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceBadBloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_MasterDeathAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerMasterDeathActionOnDowned;
    private static readonly System.IntPtr NativeFieldInfoPtr_MasterDeathActionBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnBuffs;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatsOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicHealthScalingSettingsOverride;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertDynamicHealthScalingOverride_Private_DynamicallyWeakenAttackers_WeakAssetReference_1_PrefabGuidComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AuthorBlob_Private_BlobAssetReference_1_SpawnMinionOnGameplayEventBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(37)]
    [CachedScanResults(RefRangeStart = 36757, RefRangeEnd = 36794, XrefRangeStart = 36757, XrefRangeEnd = 36794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe GameplayEventTypeEnum GetGameplayEventType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnMinionOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008377, XrefRangeEnd = 1008394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 363406, RefRangeEnd = 363424, XrefRangeStart = 363406, XrefRangeEnd = 363424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DynamicallyWeakenAttackers ConvertDynamicHealthScalingOverride(
      WeakAssetReference<PrefabGuidComponent> minionReference)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) minionReference);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEventAuthoring.NativeMethodInfoPtr_ConvertDynamicHealthScalingOverride_Private_DynamicallyWeakenAttackers_WeakAssetReference_1_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicallyWeakenAttackers*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1008463, RefRangeEnd = 1008464, XrefRangeStart = 1008394, XrefRangeEnd = 1008463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlobAssetReference<SpawnMinionOnGameplayEventBlob> AuthorBlob()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEventAuthoring.NativeMethodInfoPtr_AuthorBlob_Private_BlobAssetReference_1_SpawnMinionOnGameplayEventBlob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<SpawnMinionOnGameplayEventBlob>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008464, XrefRangeEnd = 1008465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnMinionOnGameplayEventAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnMinionOnGameplayEventAuthoring()
    {
      Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnMinionOnGameplayEventAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr);
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (Conditional));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MinionPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (MinionPrefabs));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_PrefabPickMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (PrefabPickMode));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (Location));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (Rotation));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (MinDistance));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (MaxDistance));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (Count));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_EventTargetAggroBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (EventTargetAggroBoost));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MaxDistanceFromPreCombatPositionOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (MaxDistanceFromPreCombatPositionOverride));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_IncludeInMinionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (IncludeInMinionCount));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_CanBeConsumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (CanBeConsumed));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_OverrideBloodQualityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (OverrideBloodQualityCurve));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_InheritOwnerFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (InheritOwnerFaction));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_InheritOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (InheritOwner));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_ForceBadBloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (ForceBadBloodQuality));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MasterDeathAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (MasterDeathAction));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_TriggerMasterDeathActionOnDowned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (TriggerMasterDeathActionOnDowned));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MasterDeathActionBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (MasterDeathActionBuff));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_SpawnSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpawnSequence));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_SpawnBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpawnBuffs));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_StatsOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (StatsOverrides));
      SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_DynamicHealthScalingSettingsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (DynamicHealthScalingSettingsOverride));
      SpawnMinionOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, 100678343);
      SpawnMinionOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, 100678344);
      SpawnMinionOnGameplayEventAuthoring.NativeMethodInfoPtr_ConvertDynamicHealthScalingOverride_Private_DynamicallyWeakenAttackers_WeakAssetReference_1_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, 100678345);
      SpawnMinionOnGameplayEventAuthoring.NativeMethodInfoPtr_AuthorBlob_Private_BlobAssetReference_1_SpawnMinionOnGameplayEventBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, 100678346);
      SpawnMinionOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, 100678347);
    }

    public SpawnMinionOnGameplayEventAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<PrefabGuidComponent>> MinionPrefabs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MinionPrefabs));
        return pointer == System.IntPtr.Zero ? (List<WeakAssetReference<PrefabGuidComponent>>) null : new List<WeakAssetReference<PrefabGuidComponent>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MinionPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnMinionOnGameplayEventPrefabPickMode PrefabPickMode
    {
      get
      {
        return *(SpawnMinionOnGameplayEventPrefabPickMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_PrefabPickMode));
      }
      [param: In] set
      {
        *(SpawnMinionOnGameplayEventPrefabPickMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_PrefabPickMode)) = value;
      }
    }

    public unsafe SpawnMiniononGameplayEventLocation Location
    {
      get
      {
        return *(SpawnMiniononGameplayEventLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Location));
      }
      [param: In] set
      {
        *(SpawnMiniononGameplayEventLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Location)) = value;
      }
    }

    public unsafe SpawnMinionOnGameplayEventRotation Rotation
    {
      get
      {
        return *(SpawnMinionOnGameplayEventRotation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Rotation));
      }
      [param: In] set
      {
        *(SpawnMinionOnGameplayEventRotation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Rotation)) = value;
      }
    }

    public unsafe float MinDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MinDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MinDistance)) = value;
      }
    }

    public unsafe float MaxDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MaxDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MaxDistance)) = value;
      }
    }

    public unsafe int Count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_Count)) = value;
      }
    }

    public unsafe float EventTargetAggroBoost
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_EventTargetAggroBoost));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_EventTargetAggroBoost)) = value;
      }
    }

    public unsafe float MaxDistanceFromPreCombatPositionOverride
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MaxDistanceFromPreCombatPositionOverride));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MaxDistanceFromPreCombatPositionOverride)) = value;
      }
    }

    public unsafe bool IncludeInMinionCount
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_IncludeInMinionCount));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_IncludeInMinionCount)) = value;
      }
    }

    public unsafe bool CanBeConsumed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_CanBeConsumed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_CanBeConsumed)) = value;
      }
    }

    public unsafe CurveReference OverrideBloodQualityCurve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_OverrideBloodQualityCurve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_OverrideBloodQualityCurve)) = value;
      }
    }

    public unsafe bool InheritOwnerFaction
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_InheritOwnerFaction));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_InheritOwnerFaction)) = value;
      }
    }

    public unsafe bool InheritOwner
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_InheritOwner));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_InheritOwner)) = value;
      }
    }

    public unsafe bool ForceBadBloodQuality
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_ForceBadBloodQuality));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_ForceBadBloodQuality)) = value;
      }
    }

    public unsafe MinionMasterDeathAction MasterDeathAction
    {
      get
      {
        return *(MinionMasterDeathAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MasterDeathAction));
      }
      [param: In] set
      {
        *(MinionMasterDeathAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MasterDeathAction)) = value;
      }
    }

    public unsafe bool TriggerMasterDeathActionOnDowned
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_TriggerMasterDeathActionOnDowned));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_TriggerMasterDeathActionOnDowned)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> MasterDeathActionBuff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MasterDeathActionBuff));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_MasterDeathActionBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField SpawnSequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_SpawnSequence));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_SpawnSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor> SpawnBuffs
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_SpawnBuffs));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor>) null : new Il2CppReferenceArray<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_SpawnBuffs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor StatsOverrides
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_StatsOverrides));
        return pointer == System.IntPtr.Zero ? (SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor) null : new SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_StatsOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DynamicHealthScalingSettingsAsset DynamicHealthScalingSettingsOverride
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_DynamicHealthScalingSettingsOverride));
        return pointer == System.IntPtr.Zero ? (DynamicHealthScalingSettingsAsset) null : new DynamicHealthScalingSettingsAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.NativeFieldInfoPtr_DynamicHealthScalingSettingsOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class StatsOverrides_Editor : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_OverrideUnitLevelMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevelConstant;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverrideUnitPowerMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverrideHealth;
      private static readonly System.IntPtr NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverridePhysicalPower;
      private static readonly System.IntPtr NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverrideSpellPower;
      private static readonly System.IntPtr NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToRuntimeFormat_Public_SpawnMinionOnGameplayEventStatsOverrides_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1008376, RefRangeEnd = 1008377, XrefRangeStart = 1008376, XrefRangeEnd = 1008376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnMinionOnGameplayEventStatsOverrides ToRuntimeFormat()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeMethodInfoPtr_ToRuntimeFormat_Public_SpawnMinionOnGameplayEventStatsOverrides_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SpawnMinionOnGameplayEventStatsOverrides*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe StatsOverrides_Editor()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StatsOverrides_Editor()
      {
        Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (StatsOverrides_Editor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr);
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideUnitLevelMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (OverrideUnitLevelMode));
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_UnitLevelConstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (UnitLevelConstant));
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideUnitPowerMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (OverrideUnitPowerMode));
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (OverrideHealth));
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (BonusHealthPerOwnerSpellPower));
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverridePhysicalPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (OverridePhysicalPower));
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (BonusPhysicalPowerPerOwnerSpellPower));
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (OverrideSpellPower));
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (BonusSpellPowerPerOwnerSpellPower));
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (SpellMods));
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeMethodInfoPtr_ToRuntimeFormat_Public_SpawnMinionOnGameplayEventStatsOverrides_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, 100678348);
        SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, 100678349);
      }

      public StatsOverrides_Editor(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SpawnMinionOnGameplayEventOverrideUnitLevelMode OverrideUnitLevelMode
      {
        get
        {
          return *(SpawnMinionOnGameplayEventOverrideUnitLevelMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideUnitLevelMode));
        }
        [param: In] set
        {
          *(SpawnMinionOnGameplayEventOverrideUnitLevelMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideUnitLevelMode)) = value;
        }
      }

      public unsafe int UnitLevelConstant
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_UnitLevelConstant));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_UnitLevelConstant)) = value;
        }
      }

      public unsafe SpawnMinionOnGameplayEventOverrideUnitPowerMode OverrideUnitPowerMode
      {
        get
        {
          return *(SpawnMinionOnGameplayEventOverrideUnitPowerMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideUnitPowerMode));
        }
        [param: In] set
        {
          *(SpawnMinionOnGameplayEventOverrideUnitPowerMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideUnitPowerMode)) = value;
        }
      }

      public unsafe bool OverrideHealth
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideHealth));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideHealth)) = value;
        }
      }

      public unsafe float BonusHealthPerOwnerSpellPower
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower)) = value;
        }
      }

      public unsafe bool OverridePhysicalPower
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverridePhysicalPower));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverridePhysicalPower)) = value;
        }
      }

      public unsafe float BonusPhysicalPowerPerOwnerSpellPower
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower)) = value;
        }
      }

      public unsafe bool OverrideSpellPower
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideSpellPower));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_OverrideSpellPower)) = value;
        }
      }

      public unsafe float BonusSpellPowerPerOwnerSpellPower
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower)) = value;
        }
      }

      public SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring SpellMods
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_SpellMods);
          return new SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      [Serializable]
      public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower;
        private static readonly System.IntPtr NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower;
        private static readonly System.IntPtr NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower;

        static SpellModsAuthoring()
        {
          Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor>.NativeClassPtr, nameof (SpellModsAuthoring));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring>.NativeClassPtr);
          SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring.NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring>.NativeClassPtr, nameof (BonusHealthPerOwnerSpellPower));
          SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring.NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring>.NativeClassPtr, nameof (BonusPhysicalPowerPerOwnerSpellPower));
          SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring.NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring>.NativeClassPtr, nameof (BonusSpellPowerPerOwnerSpellPower));
        }

        public SpellModsAuthoring(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public SpellModsAuthoring()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring>.NativeClassPtr, data));
        }

        public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> BonusHealthPerOwnerSpellPower
        {
          get
          {
            System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring.NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower));
            return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring.NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> BonusPhysicalPowerPerOwnerSpellPower
        {
          get
          {
            System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring.NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower));
            return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring.NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> BonusSpellPowerPerOwnerSpellPower
        {
          get
          {
            System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring.NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower));
            return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.StatsOverrides_Editor.SpellModsAuthoring.NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }
      }
    }

    [Serializable]
    public class SpawnBuffElement_Editor : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Buff;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffTarget;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellTarget;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnBuffElement_Editor()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SpawnBuffElement_Editor()
      {
        Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpawnBuffElement_Editor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor>.NativeClassPtr);
        SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor>.NativeClassPtr, nameof (Buff));
        SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_BuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor>.NativeClassPtr, nameof (BuffTarget));
        SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor>.NativeClassPtr, nameof (SpellTarget));
        SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor>.NativeClassPtr, 100678350);
      }

      public SpawnBuffElement_Editor(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<PrefabGuidComponent> Buff
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_Buff));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_Buff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SpawnMinionOnGameplayEventWho BuffTarget
      {
        get
        {
          return *(SpawnMinionOnGameplayEventWho*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_BuffTarget));
        }
        [param: In] set
        {
          *(SpawnMinionOnGameplayEventWho*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_BuffTarget)) = value;
        }
      }

      public unsafe SpawnMinionOnGameplayEventWho SpellTarget
      {
        get
        {
          return *(SpawnMinionOnGameplayEventWho*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_SpellTarget));
        }
        [param: In] set
        {
          *(SpawnMinionOnGameplayEventWho*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_SpellTarget)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.SpawnMinionOnGameplayEventAuthoring/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__28_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__28_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AuthorBlob_b__28_0_Internal_Boolean_SpawnBuffElement_Editor_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AuthorBlob_b__28_1_Internal_Boolean_WeakAssetReference_1_PrefabGuidComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEventAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _AuthorBlob_b__28_0(
        SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEventAuthoring.__c.NativeMethodInfoPtr__AuthorBlob_b__28_0_Internal_Boolean_SpawnBuffElement_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe bool _AuthorBlob_b__28_1(WeakAssetReference<PrefabGuidComponent> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEventAuthoring.__c.NativeMethodInfoPtr__AuthorBlob_b__28_1_Internal_Boolean_WeakAssetReference_1_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.__c>.NativeClassPtr);
        SpawnMinionOnGameplayEventAuthoring.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.__c>.NativeClassPtr, "<>9");
        SpawnMinionOnGameplayEventAuthoring.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.__c>.NativeClassPtr, "<>9__28_0");
        SpawnMinionOnGameplayEventAuthoring.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.__c>.NativeClassPtr, "<>9__28_1");
        SpawnMinionOnGameplayEventAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.__c>.NativeClassPtr, 100678352);
        SpawnMinionOnGameplayEventAuthoring.__c.NativeMethodInfoPtr__AuthorBlob_b__28_0_Internal_Boolean_SpawnBuffElement_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.__c>.NativeClassPtr, 100678353);
        SpawnMinionOnGameplayEventAuthoring.__c.NativeMethodInfoPtr__AuthorBlob_b__28_1_Internal_Boolean_WeakAssetReference_1_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEventAuthoring.__c>.NativeClassPtr, 100678354);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe SpawnMinionOnGameplayEventAuthoring.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnMinionOnGameplayEventAuthoring.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (SpawnMinionOnGameplayEventAuthoring.__c) null : new SpawnMinionOnGameplayEventAuthoring.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnMinionOnGameplayEventAuthoring.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor, bool> __9__28_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnMinionOnGameplayEventAuthoring.__c.NativeFieldInfoPtr___9__28_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor, bool>) null : new Il2CppSystem.Func<SpawnMinionOnGameplayEventAuthoring.SpawnBuffElement_Editor, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnMinionOnGameplayEventAuthoring.__c.NativeFieldInfoPtr___9__28_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<WeakAssetReference<PrefabGuidComponent>, bool> __9__28_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnMinionOnGameplayEventAuthoring.__c.NativeFieldInfoPtr___9__28_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<WeakAssetReference<PrefabGuidComponent>, bool>) null : new Il2CppSystem.Func<WeakAssetReference<PrefabGuidComponent>, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnMinionOnGameplayEventAuthoring.__c.NativeFieldInfoPtr___9__28_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
