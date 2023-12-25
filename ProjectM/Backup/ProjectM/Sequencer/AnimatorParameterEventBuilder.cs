﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AnimatorParameterEventBuilder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  public class AnimatorParameterEventBuilder : SequencerEventBuilder
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly IntPtr NativeFieldInfoPtr_ImportanceParameter;
    private static readonly IntPtr NativeFieldInfoPtr_ParameterFloat;
    private static readonly IntPtr NativeFieldInfoPtr_ParameterInt;
    private static readonly IntPtr NativeFieldInfoPtr_ParameterBool;
    private static readonly IntPtr NativeFieldInfoPtr_SetAnimationListeners;
    private static readonly IntPtr NativeFieldInfoPtr_RestoreOnFinish;
    private static readonly IntPtr NativeFieldInfoPtr_ParameterName;
    private static readonly IntPtr NativeFieldInfoPtr_ParameterType;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089854, XrefRangeEnd = 1089862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager entityManager,
      BlackboardBuilder blackboardBuilder,
      SequenceEditorObject sequenceEditorObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequenceEditorObject);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public override unsafe NodeTypeEnum GetNodeType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089862, XrefRangeEnd = 1089867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetDebugName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimatorParameterEventBuilder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimatorParameterEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AnimatorParameterEventBuilder()
    {
      Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AnimatorParameterEventBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr);
      AnimatorParameterEventBuilder.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, nameof (TargetParameter));
      AnimatorParameterEventBuilder.NativeFieldInfoPtr_ImportanceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, nameof (ImportanceParameter));
      AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, nameof (ParameterFloat));
      AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, nameof (ParameterInt));
      AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, nameof (ParameterBool));
      AnimatorParameterEventBuilder.NativeFieldInfoPtr_SetAnimationListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, nameof (SetAnimationListeners));
      AnimatorParameterEventBuilder.NativeFieldInfoPtr_RestoreOnFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, nameof (RestoreOnFinish));
      AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, nameof (ParameterName));
      AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, nameof (ParameterType));
      AnimatorParameterEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, 100685822);
      AnimatorParameterEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, 100685823);
      AnimatorParameterEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, 100685824);
      AnimatorParameterEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterEventBuilder>.NativeClassPtr, 100685825);
    }

    public AnimatorParameterEventBuilder(IntPtr pointer)
      : base(pointer)
    {
    }

    public BlackboardParameterBuilder TargetParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_TargetParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_TargetParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder ImportanceParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ImportanceParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ImportanceParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder ParameterFloat
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterFloat);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterFloat), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder ParameterInt
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterInt);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterInt), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder ParameterBool
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterBool);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterBool), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder SetAnimationListeners
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_SetAnimationListeners);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_SetAnimationListeners), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder RestoreOnFinish
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_RestoreOnFinish);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_RestoreOnFinish), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe string ParameterName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe AnimatorParameterTypeEnum ParameterType
    {
      get
      {
        return *(AnimatorParameterTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterType));
      }
      [param: In] set
      {
        *(AnimatorParameterTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterEventBuilder.NativeFieldInfoPtr_ParameterType)) = value;
      }
    }
  }
}
