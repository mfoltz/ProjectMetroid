// Decompiled with JetBrains decompiler
// Type: ProjectM.ApplyKnockbackOnGameplayEventAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ApplyKnockbackOnGameplayEventAuthoring : OnGameplayEventAuthoring
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomKnockbackBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackPowerAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationAngleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirectionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModelDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseMinMaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRangeToTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRangeToTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_FarRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeaderName_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<ProjectM.SpellModSettings> SpellModSettings
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007857, XrefRangeEnd = 1007868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<ProjectM.SpellModSettings>) null : new IEnumerable<ProjectM.SpellModSettings>(pointer);
      }
    }

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe GameplayEventTypeEnum GetGameplayEventType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007868, XrefRangeEnd = 1007908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007908, XrefRangeEnd = 1007912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007912, XrefRangeEnd = 1007914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetHeaderName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr_GetHeaderName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007914, XrefRangeEnd = 1007915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ApplyKnockbackOnGameplayEventAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ApplyKnockbackOnGameplayEventAuthoring()
    {
      Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ApplyKnockbackOnGameplayEventAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr);
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (Conditional));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_CustomKnockbackBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (CustomKnockbackBuff));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_KnockbackPowerAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (KnockbackPowerAsset));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (Duration));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (Range));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationAngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (RotationAngleOffset));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_DirectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (DirectionType));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_TargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (TargetType));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_ModelDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (ModelDirection));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_UseMinMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (UseMinMaxRange));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_MinRangeToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (MinRangeToTarget));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_MaxRangeToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (MaxRangeToTarget));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_CloseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (CloseRange));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_FarRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (FarRange));
      ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpellMods));
      ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, 100678247);
      ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, 100678248);
      ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, 100678249);
      ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, 100678250);
      ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr_GetHeaderName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, 100678251);
      ApplyKnockbackOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, 100678252);
    }

    public ApplyKnockbackOnGameplayEventAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent CustomKnockbackBuff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_CustomKnockbackBuff));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_CustomKnockbackBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe KnockbackPowerAsset KnockbackPowerAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_KnockbackPowerAsset));
        return pointer == System.IntPtr.Zero ? (KnockbackPowerAsset) null : new KnockbackPowerAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_KnockbackPowerAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe float Range
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_Range)) = value;
      }
    }

    public unsafe float RotationAngleOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationAngleOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationAngleOffset)) = value;
      }
    }

    public unsafe KnockbackDirectionType DirectionType
    {
      get
      {
        return *(KnockbackDirectionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_DirectionType));
      }
      [param: In] set
      {
        *(KnockbackDirectionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_DirectionType)) = value;
      }
    }

    public unsafe KnockbackTargetType TargetType
    {
      get
      {
        return *(KnockbackTargetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_TargetType));
      }
      [param: In] set
      {
        *(KnockbackTargetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_TargetType)) = value;
      }
    }

    public unsafe MovementCurveRotationMode ModelDirection
    {
      get
      {
        return *(MovementCurveRotationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_ModelDirection));
      }
      [param: In] set
      {
        *(MovementCurveRotationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_ModelDirection)) = value;
      }
    }

    public unsafe bool UseMinMaxRange
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_UseMinMaxRange));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_UseMinMaxRange)) = value;
      }
    }

    public unsafe float MinRangeToTarget
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_MinRangeToTarget));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_MinRangeToTarget)) = value;
      }
    }

    public unsafe float MaxRangeToTarget
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_MaxRangeToTarget));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_MaxRangeToTarget)) = value;
      }
    }

    public unsafe float CloseRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_CloseRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_CloseRange)) = value;
      }
    }

    public unsafe float FarRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_FarRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_FarRange)) = value;
      }
    }

    public ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods);
        return new ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
      private static readonly System.IntPtr NativeFieldInfoPtr_Range;
      private static readonly System.IntPtr NativeFieldInfoPtr_MinRangeToTarget;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxRangeToTarget;
      private static readonly System.IntPtr NativeFieldInfoPtr_CloseRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_FarRange;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr);
        ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (Duration));
        ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (Range));
        ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_MinRangeToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (MinRangeToTarget));
        ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_MaxRangeToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (MaxRangeToTarget));
        ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_CloseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (CloseRange));
        ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_FarRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (FarRange));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Duration
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Duration));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Duration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Range
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Range));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Range), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MinRangeToTarget
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_MinRangeToTarget));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_MinRangeToTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MaxRangeToTarget
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_MaxRangeToTarget));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_MaxRangeToTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> CloseRange
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_CloseRange));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_CloseRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> FarRange
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_FarRange));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyKnockbackOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_FarRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
