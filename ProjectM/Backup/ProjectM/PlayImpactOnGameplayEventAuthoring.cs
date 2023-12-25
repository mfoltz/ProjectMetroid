// Decompiled with JetBrains decompiler
// Type: ProjectM.PlayImpactOnGameplayEventAuthoring
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
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class PlayImpactOnGameplayEventAuthoring : OnGameplayEventAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly IntPtr NativeFieldInfoPtr_PrimarySequence;
    private static readonly IntPtr NativeFieldInfoPtr_ImpactMapping;
    private static readonly IntPtr NativeFieldInfoPtr_SequenceRotationSource;
    private static readonly IntPtr NativeFieldInfoPtr_SkipMaterialSequence;
    private static readonly IntPtr NativeFieldInfoPtr_Scale;
    private static readonly IntPtr NativeFieldInfoPtr_RandomRotationOffset;
    private static readonly IntPtr NativeFieldInfoPtr_RotationOffsetEuler;
    private static readonly IntPtr NativeFieldInfoPtr_RotationOffsetEulerMin;
    private static readonly IntPtr NativeFieldInfoPtr_RotationOffsetEulerMax;
    private static readonly IntPtr NativeFieldInfoPtr_SpellMods_PrimarySequence;
    private static readonly IntPtr NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(24)]
    [CachedScanResults(RefRangeStart = 42923, RefRangeEnd = 42947, XrefRangeStart = 42923, XrefRangeEnd = 42947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe GameplayEventTypeEnum GetGameplayEventType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayImpactOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe IEnumerable<ProjectM.SpellModSettings> SpellModSettings
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008228, XrefRangeEnd = 1008237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayImpactOnGameplayEventAuthoring.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IEnumerable<ProjectM.SpellModSettings>) null : new IEnumerable<ProjectM.SpellModSettings>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008237, XrefRangeEnd = 1008248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(PlayImpactOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008248, XrefRangeEnd = 1008249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayImpactOnGameplayEventAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayImpactOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayImpactOnGameplayEventAuthoring()
    {
      Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlayImpactOnGameplayEventAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr);
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (Conditional));
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_PrimarySequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (PrimarySequence));
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_ImpactMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (ImpactMapping));
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_SequenceRotationSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (SequenceRotationSource));
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_SkipMaterialSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (SkipMaterialSequence));
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (Scale));
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RandomRotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (RandomRotationOffset));
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationOffsetEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (RotationOffsetEuler));
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationOffsetEulerMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (RotationOffsetEulerMin));
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationOffsetEulerMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (RotationOffsetEulerMax));
      PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods_PrimarySequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpellMods_PrimarySequence));
      PlayImpactOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, 100678319);
      PlayImpactOnGameplayEventAuthoring.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, 100678320);
      PlayImpactOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, 100678321);
      PlayImpactOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayImpactOnGameplayEventAuthoring>.NativeClassPtr, 100678322);
    }

    public PlayImpactOnGameplayEventAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField PrimarySequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_PrimarySequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_PrimarySequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ImpactEffectsMappingAsset ImpactMapping
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_ImpactMapping));
        return pointer == IntPtr.Zero ? (ImpactEffectsMappingAsset) null : new ImpactEffectsMappingAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_ImpactMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlaySequenceOnGameplayEventTarget SequenceRotationSource
    {
      get
      {
        return *(PlaySequenceOnGameplayEventTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_SequenceRotationSource));
      }
      [param: In] set
      {
        *(PlaySequenceOnGameplayEventTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_SequenceRotationSource)) = value;
      }
    }

    public unsafe bool SkipMaterialSequence
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_SkipMaterialSequence));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_SkipMaterialSequence)) = value;
      }
    }

    public unsafe float Scale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_Scale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_Scale)) = value;
      }
    }

    public unsafe bool RandomRotationOffset
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RandomRotationOffset));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RandomRotationOffset)) = value;
      }
    }

    public unsafe Vector3 RotationOffsetEuler
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationOffsetEuler));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationOffsetEuler)) = value;
      }
    }

    public unsafe Vector3 RotationOffsetEulerMin
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationOffsetEulerMin));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationOffsetEulerMin)) = value;
      }
    }

    public unsafe Vector3 RotationOffsetEulerMax
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationOffsetEulerMax));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_RotationOffsetEulerMax)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<SpellModSequenceGuidSettings> SpellMods_PrimarySequence
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods_PrimarySequence));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<SpellModSequenceGuidSettings>) null : new Il2CppReferenceArray<SpellModSequenceGuidSettings>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayImpactOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods_PrimarySequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
