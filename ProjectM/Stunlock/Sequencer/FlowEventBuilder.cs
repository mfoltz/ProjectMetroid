// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.FlowEventBuilder
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
namespace Stunlock.Sequencer
{
  public class FlowEventBuilder : SequencerEventBuilder
  {
    private static readonly IntPtr NativeFieldInfoPtr_FlowType;
    private static readonly IntPtr NativeFieldInfoPtr_PlayMode;
    private static readonly IntPtr NativeFieldInfoPtr_SpeedMode;
    private static readonly IntPtr NativeFieldInfoPtr_SpeedParameter;
    private static readonly IntPtr NativeFieldInfoPtr_RepeatsParameter;
    private static readonly IntPtr NativeFieldInfoPtr_ConditionsEvaluationMode;
    private static readonly IntPtr NativeFieldInfoPtr_Conditions;
    private static readonly IntPtr NativeFieldInfoPtr_ChildStartIndex;
    private static readonly IntPtr NativeFieldInfoPtr_ChildCount;
    private static readonly IntPtr NativeFieldInfoPtr_Speed;
    private static readonly IntPtr NativeFieldInfoPtr_Children;
    private static readonly IntPtr NativeMethodInfoPtr_ConvertNodeIndexes_Public_Void_byref_Int32_List_1_SequencerEventBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 923430, RefRangeEnd = 923432, XrefRangeStart = 923421, XrefRangeEnd = 923430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertNodeIndexes(ref int nodeIndex, List<SequencerEventBuilder> events)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref nodeIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) events);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FlowEventBuilder.NativeMethodInfoPtr_ConvertNodeIndexes_Public_Void_byref_Int32_List_1_SequencerEventBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923432, XrefRangeEnd = 923438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NodeTypeEnum GetNodeType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923438, XrefRangeEnd = 923447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetDebugName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 923489, RefRangeEnd = 923491, XrefRangeStart = 923447, XrefRangeEnd = 923489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FlowEventBuilder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FlowEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FlowEventBuilder()
    {
      Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (FlowEventBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr);
      FlowEventBuilder.NativeFieldInfoPtr_FlowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (FlowType));
      FlowEventBuilder.NativeFieldInfoPtr_PlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (PlayMode));
      FlowEventBuilder.NativeFieldInfoPtr_SpeedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (SpeedMode));
      FlowEventBuilder.NativeFieldInfoPtr_SpeedParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (SpeedParameter));
      FlowEventBuilder.NativeFieldInfoPtr_RepeatsParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (RepeatsParameter));
      FlowEventBuilder.NativeFieldInfoPtr_ConditionsEvaluationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (ConditionsEvaluationMode));
      FlowEventBuilder.NativeFieldInfoPtr_Conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (Conditions));
      FlowEventBuilder.NativeFieldInfoPtr_ChildStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (ChildStartIndex));
      FlowEventBuilder.NativeFieldInfoPtr_ChildCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (ChildCount));
      FlowEventBuilder.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (Speed));
      FlowEventBuilder.NativeFieldInfoPtr_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, nameof (Children));
      FlowEventBuilder.NativeMethodInfoPtr_ConvertNodeIndexes_Public_Void_byref_Int32_List_1_SequencerEventBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, 100663879);
      FlowEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, 100663880);
      FlowEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, 100663881);
      FlowEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, 100663882);
      FlowEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowEventBuilder>.NativeClassPtr, 100663883);
    }

    public FlowEventBuilder(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FlowTypeEnum FlowType
    {
      get
      {
        return *(FlowTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_FlowType));
      }
      [param: In] set
      {
        *(FlowTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_FlowType)) = value;
      }
    }

    public unsafe PlayModeEnum PlayMode
    {
      get
      {
        return *(PlayModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_PlayMode));
      }
      [param: In] set
      {
        *(PlayModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_PlayMode)) = value;
      }
    }

    public unsafe FlowNodeSpeedMode SpeedMode
    {
      get
      {
        return *(FlowNodeSpeedMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_SpeedMode));
      }
      [param: In] set
      {
        *(FlowNodeSpeedMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_SpeedMode)) = value;
      }
    }

    public BlackboardParameterBuilder SpeedParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_SpeedParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_SpeedParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder RepeatsParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_RepeatsParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_RepeatsParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe ConditionsEvaluationMode ConditionsEvaluationMode
    {
      get
      {
        return *(ConditionsEvaluationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_ConditionsEvaluationMode));
      }
      [param: In] set
      {
        *(ConditionsEvaluationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_ConditionsEvaluationMode)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<ConditionBuilder> Conditions
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_Conditions));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<ConditionBuilder>) null : new Il2CppReferenceArray<ConditionBuilder>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_Conditions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int ChildStartIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_ChildStartIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_ChildStartIndex)) = value;
      }
    }

    public unsafe int ChildCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_ChildCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_ChildCount)) = value;
      }
    }

    public unsafe float Speed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_Speed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_Speed)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<SequencerEventBuilder> Children
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_Children));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<SequencerEventBuilder>) null : new Il2CppReferenceArray<SequencerEventBuilder>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowEventBuilder.NativeFieldInfoPtr_Children), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
