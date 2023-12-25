// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorNode_FlowNode
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequenceEditorNode_FlowNode : SequenceEditorNode
  {
    private static readonly IntPtr NativeFieldInfoPtr__SpeedMode;
    private static readonly IntPtr NativeFieldInfoPtr__SpeedParameter;
    private static readonly IntPtr NativeFieldInfoPtr__FlowType;
    private static readonly IntPtr NativeFieldInfoPtr__PlayMode;
    private static readonly IntPtr NativeFieldInfoPtr__Repeats;
    private static readonly IntPtr NativeFieldInfoPtr__RepeatsParameter;
    private static readonly IntPtr NativeFieldInfoPtr__Expanded;
    private static readonly IntPtr NativeFieldInfoPtr__Speed;
    private static readonly IntPtr NativeFieldInfoPtr__ChildNodes;
    private static readonly IntPtr NativeFieldInfoPtr__ConditionsMatch;
    private static readonly IntPtr NativeFieldInfoPtr__Conditions;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_HasChildren_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ChildNodes_Public_get_List_1_SequenceEditorNode_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_FlowType_Public_get_FlowTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_FlowType_Public_set_Void_FlowTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_PlayMode_Public_get_PlayModeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_PlayMode_Public_set_Void_PlayModeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Repeats_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Repeats_Public_set_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Speed_Public_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Speed_Public_set_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Expanded_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Expanded_Public_set_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_EvaluationMode_Public_get_ConditionsEvaluationMode_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Conditions_Public_get_List_1_ConditionItem_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_SpeedParameter_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_SpeedParameter_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_RepeatsParameter_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_RepeatsParameter_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_SpeedMode_Public_get_FlowNodeSpeedMode_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_SpeedMode_Public_set_Void_FlowNodeSpeedMode_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetSpeedInHiearchy_Public_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddChild_Public_Void_SequenceEditorNode_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsInfiniteDuration_Public_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddChildBefore_Public_Void_SequenceEditorNode_SequenceEditorNode_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddChildAfter_Public_Void_SequenceEditorNode_SequenceEditorNode_0;
    private static readonly IntPtr NativeMethodInfoPtr_InsertChild_Public_Void_Int32_SequenceEditorNode_0;
    private static readonly IntPtr NativeMethodInfoPtr_RemoveChildAt_Public_Boolean_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetChildIndex_Public_Int32_SequenceEditorNode_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetMaxChildIndex_Private_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetChildAtIndex_Public_SequenceEditorNode_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Public_Boolean_SequenceEditorNode_0;
    private static readonly IntPtr NativeMethodInfoPtr_ClearChildren_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_FirstChild_Public_SequenceEditorNode_0;
    private static readonly IntPtr NativeMethodInfoPtr_LastChild_Public_SequenceEditorNode_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsNodeInChildStructure_Public_Boolean_SequenceEditorNode_0;
    private static readonly IntPtr NativeMethodInfoPtr_ValidateVersion_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetChildNodes_Public_List_1_SequenceEditorNode_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public override unsafe string ExtendedName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093312, XrefRangeEnd = 1093320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public override unsafe string IconClass
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093320, XrefRangeEnd = 1093322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe int ChildCount
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1093323, RefRangeEnd = 1093324, XrefRangeStart = 1093322, XrefRangeEnd = 1093323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool HasChildren
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 1093325, RefRangeEnd = 1093328, XrefRangeStart = 1093324, XrefRangeEnd = 1093325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_HasChildren_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe List<SequenceEditorNode> ChildNodes
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_ChildNodes_Public_get_List_1_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<SequenceEditorNode>) null : new List<SequenceEditorNode>(pointer);
      }
    }

    public unsafe FlowTypeEnum FlowType
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 47614, RefRangeEnd = 47615, XrefRangeStart = 47614, XrefRangeEnd = 47615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_FlowType_Public_get_FlowTypeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(FlowTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_FlowType_Public_set_Void_FlowTypeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe PlayModeEnum PlayMode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_PlayMode_Public_get_PlayModeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PlayModeEnum*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_PlayMode_Public_set_Void_PlayModeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int Repeats
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_Repeats_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_Repeats_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Speed
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_Speed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_Speed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool Expanded
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_Expanded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_Expanded_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ConditionsEvaluationMode EvaluationMode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_EvaluationMode_Public_get_ConditionsEvaluationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ConditionsEvaluationMode*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe List<ConditionItem> Conditions
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_Conditions_Public_get_List_1_ConditionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<ConditionItem>) null : new List<ConditionItem>(pointer);
      }
    }

    public unsafe BlackboardParameterValue SpeedParameter
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_SpeedParameter_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093328, XrefRangeEnd = 1093329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_SpeedParameter_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue RepeatsParameter
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_RepeatsParameter_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093329, XrefRangeEnd = 1093330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_RepeatsParameter_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe FlowNodeSpeedMode SpeedMode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_SpeedMode_Public_get_FlowNodeSpeedMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(FlowNodeSpeedMode*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_SpeedMode_Public_set_Void_FlowNodeSpeedMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093330, XrefRangeEnd = 1093335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetSpeedInHiearchy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetSpeedInHiearchy_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093335, XrefRangeEnd = 1093371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe float GetDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093371, XrefRangeEnd = 1093385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FlowNode.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1093400, RefRangeEnd = 1093401, XrefRangeStart = 1093385, XrefRangeEnd = 1093400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddChild(SequenceEditorNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_AddChild_Public_Void_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093401, XrefRangeEnd = 1093421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool IsInfiniteDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FlowNode.NativeMethodInfoPtr_IsInfiniteDuration_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093421, XrefRangeEnd = 1093429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddChildBefore(SequenceEditorNode node, SequenceEditorNode referenceNode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) referenceNode);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_AddChildBefore_Public_Void_SequenceEditorNode_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093429, XrefRangeEnd = 1093437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddChildAfter(SequenceEditorNode node, SequenceEditorNode referenceNode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) referenceNode);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_AddChildAfter_Public_Void_SequenceEditorNode_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1093452, RefRangeEnd = 1093453, XrefRangeStart = 1093437, XrefRangeEnd = 1093452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InsertChild(int index, SequenceEditorNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &index;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_InsertChild_Public_Void_Int32_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093453, XrefRangeEnd = 1093457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool RemoveChildAt(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &index;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_RemoveChildAt_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093457, XrefRangeEnd = 1093461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetChildIndex(SequenceEditorNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetChildIndex_Public_Int32_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093461, XrefRangeEnd = 1093462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetMaxChildIndex()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetMaxChildIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1093470, RefRangeEnd = 1093472, XrefRangeStart = 1093462, XrefRangeEnd = 1093470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode GetChildAtIndex(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &index;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetChildAtIndex_Public_SequenceEditorNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (SequenceEditorNode) null : new SequenceEditorNode(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093472, XrefRangeEnd = 1093479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool RemoveChild(SequenceEditorNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_RemoveChild_Public_Boolean_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093479, XrefRangeEnd = 1093482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearChildren()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_ClearChildren_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1093485, RefRangeEnd = 1093486, XrefRangeStart = 1093482, XrefRangeEnd = 1093485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode FirstChild()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_FirstChild_Public_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (SequenceEditorNode) null : new SequenceEditorNode(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093486, XrefRangeEnd = 1093489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode LastChild()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_LastChild_Public_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (SequenceEditorNode) null : new SequenceEditorNode(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1093515, RefRangeEnd = 1093517, XrefRangeStart = 1093489, XrefRangeEnd = 1093515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsNodeInChildStructure(SequenceEditorNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_IsNodeInChildStructure_Public_Boolean_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093517, XrefRangeEnd = 1093535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void ValidateVersion()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FlowNode.NativeMethodInfoPtr_ValidateVersion_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093535, XrefRangeEnd = 1093547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<SequenceEditorNode> GetChildNodes(int startIndex, int endIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &startIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &endIndex;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetChildNodes_Public_List_1_SequenceEditorNode_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (List<SequenceEditorNode>) null : new List<SequenceEditorNode>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093547, XrefRangeEnd = 1093549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnVersionChanged(int previousVersion, int newVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &previousVersion;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &newVersion;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FlowNode.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093549, XrefRangeEnd = 1093553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode_FlowNode()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FlowNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorNode_FlowNode()
    {
      Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorNode_FlowNode));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr);
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__SpeedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_SpeedMode));
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__SpeedParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_SpeedParameter));
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__FlowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_FlowType));
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__PlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_PlayMode));
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Repeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_Repeats));
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__RepeatsParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_RepeatsParameter));
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Expanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_Expanded));
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_Speed));
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__ChildNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_ChildNodes));
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__ConditionsMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_ConditionsMatch));
      SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, nameof (_Conditions));
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686349);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686350);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686351);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686352);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_HasChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686353);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_ChildNodes_Public_get_List_1_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686354);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_FlowType_Public_get_FlowTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686355);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_FlowType_Public_set_Void_FlowTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686356);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_PlayMode_Public_get_PlayModeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686357);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_PlayMode_Public_set_Void_PlayModeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686358);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_Repeats_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686359);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_Repeats_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686360);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_Speed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686361);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_Speed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686362);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_Expanded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686363);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_Expanded_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686364);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_EvaluationMode_Public_get_ConditionsEvaluationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686365);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_Conditions_Public_get_List_1_ConditionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686366);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_SpeedParameter_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686367);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_SpeedParameter_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686368);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_RepeatsParameter_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686369);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_RepeatsParameter_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686370);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_get_SpeedMode_Public_get_FlowNodeSpeedMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686371);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_set_SpeedMode_Public_set_Void_FlowNodeSpeedMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686372);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetSpeedInHiearchy_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686373);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686374);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686375);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_AddChild_Public_Void_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686376);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_IsInfiniteDuration_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686377);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_AddChildBefore_Public_Void_SequenceEditorNode_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686378);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_AddChildAfter_Public_Void_SequenceEditorNode_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686379);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_InsertChild_Public_Void_Int32_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686380);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_RemoveChildAt_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686381);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetChildIndex_Public_Int32_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686382);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetMaxChildIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686383);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetChildAtIndex_Public_SequenceEditorNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686384);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_RemoveChild_Public_Boolean_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686385);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_ClearChildren_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686386);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_FirstChild_Public_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686387);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_LastChild_Public_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686388);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_IsNodeInChildStructure_Public_Boolean_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686389);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_ValidateVersion_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686390);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_GetChildNodes_Public_List_1_SequenceEditorNode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686391);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686392);
      SequenceEditorNode_FlowNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FlowNode>.NativeClassPtr, 100686393);
    }

    public SequenceEditorNode_FlowNode(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FlowNodeSpeedMode _SpeedMode
    {
      get
      {
        return *(FlowNodeSpeedMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__SpeedMode));
      }
      [param: In] set
      {
        *(FlowNodeSpeedMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__SpeedMode)) = value;
      }
    }

    public BlackboardParameterValue _SpeedParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__SpeedParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__SpeedParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe FlowTypeEnum _FlowType
    {
      get
      {
        return *(FlowTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__FlowType));
      }
      [param: In] set
      {
        *(FlowTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__FlowType)) = value;
      }
    }

    public unsafe PlayModeEnum _PlayMode
    {
      get
      {
        return *(PlayModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__PlayMode));
      }
      [param: In] set
      {
        *(PlayModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__PlayMode)) = value;
      }
    }

    public unsafe int _Repeats
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Repeats));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Repeats)) = value;
      }
    }

    public BlackboardParameterValue _RepeatsParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__RepeatsParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__RepeatsParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe bool _Expanded
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Expanded));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Expanded)) = value;
      }
    }

    public unsafe float _Speed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Speed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Speed)) = value;
      }
    }

    public unsafe List<SequenceEditorNode> _ChildNodes
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__ChildNodes));
        return pointer == IntPtr.Zero ? (List<SequenceEditorNode>) null : new List<SequenceEditorNode>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__ChildNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ConditionsEvaluationMode _ConditionsMatch
    {
      get
      {
        return *(ConditionsEvaluationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__ConditionsMatch));
      }
      [param: In] set
      {
        *(ConditionsEvaluationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__ConditionsMatch)) = value;
      }
    }

    public unsafe List<ConditionItem> _Conditions
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Conditions));
        return pointer == IntPtr.Zero ? (List<ConditionItem>) null : new List<ConditionItem>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FlowNode.NativeFieldInfoPtr__Conditions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
