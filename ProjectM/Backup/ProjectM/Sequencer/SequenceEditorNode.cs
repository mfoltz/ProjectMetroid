// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorNode
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UIElements;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SequenceEditorNode : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Version;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsExposed;
    private static readonly System.IntPtr NativeFieldInfoPtr__ExposeIdentifier;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentVersion_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr__Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr__Name;
    private static readonly System.IntPtr NativeFieldInfoPtr__Enabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsInfinite;
    private static readonly System.IntPtr NativeFieldInfoPtr__Sequence;
    private static readonly System.IntPtr NativeFieldInfoPtr__VisualElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDoRedraw;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInfinite_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExposed_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Guid_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Parent_Public_get_SequenceEditorNode_FlowNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Parent_Public_set_Void_SequenceEditorNode_FlowNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ExposeIdentifier_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ExposeIdentifier_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RawExposeIdentifier_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Sequence_Public_get_SequenceEditorObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Sequence_Public_set_Void_SequenceEditorObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VisualElement_Public_get_VisualElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VisualElement_Public_set_Void_VisualElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_OnDoRedraw_Public_add_Void_VoidDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnDoRedraw_Public_rem_Void_VoidDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IconClass_Public_Virtual_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UseParallelParentDuration_Public_Virtual_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsUsingParallelParentDuration_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnDoRedraw_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewGuid_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Public_Abstract_Virtual_New_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInfiniteDuration_Public_Virtual_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_New_NodeStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviewDuration_Public_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasParent_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EnabledInTree_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Level_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLevel_Private_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromHierarchy_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_New_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateVersion_Public_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSelfOrDecendantOf_Public_Boolean_SequenceEditorNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsDecendantOf_Public_Boolean_SequenceEditorNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__IsDecendantOf_Private_Boolean_SequenceEditorNode_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPathString_Public_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetPathString_Private_Void_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public virtual unsafe int CurrentVersion
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 35564, RefRangeEnd = 35585, XrefRangeStart = 35564, XrefRangeEnd = 35585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsInfinite
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_IsInfinite_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsExposed
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_IsExposed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe string Guid
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_Guid_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe SequenceEditorNode_FlowNode Parent
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 22398, RefRangeEnd = 22405, XrefRangeStart = 22398, XrefRangeEnd = 22405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_Parent_Public_get_SequenceEditorNode_FlowNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SequenceEditorNode_FlowNode) null : new SequenceEditorNode_FlowNode(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23675, RefRangeEnd = 23677, XrefRangeStart = 23675, XrefRangeEnd = 23677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_set_Parent_Public_set_Void_SequenceEditorNode_FlowNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string Name
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22405, RefRangeEnd = 22406, XrefRangeStart = 22405, XrefRangeEnd = 22406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23672, RefRangeEnd = 23674, XrefRangeStart = 23672, XrefRangeEnd = 23674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string ExposeIdentifier
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094167, XrefRangeEnd = 1094168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_ExposeIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_set_ExposeIdentifier_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string RawExposeIdentifier
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_RawExposeIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe bool Enabled
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 29048, RefRangeEnd = 29051, XrefRangeStart = 29048, XrefRangeEnd = 29051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe SequenceEditorObject Sequence
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22805, RefRangeEnd = 22806, XrefRangeStart = 22805, XrefRangeEnd = 22806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_Sequence_Public_get_SequenceEditorObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SequenceEditorObject) null : new SequenceEditorObject(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_set_Sequence_Public_set_Void_SequenceEditorObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe VisualElement VisualElement
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_VisualElement_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (VisualElement) null : new VisualElement(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_set_VisualElement_Public_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094168, XrefRangeEnd = 1094172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void add_OnDoRedraw(SequenceEditorNode.VoidDelegate value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_add_OnDoRedraw_Public_add_Void_VoidDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094172, XrefRangeEnd = 1094176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void remove_OnDoRedraw(SequenceEditorNode.VoidDelegate value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_remove_OnDoRedraw_Public_rem_Void_VoidDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe string ExtendedName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094176, XrefRangeEnd = 1094178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public virtual unsafe string IconClass
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094178, XrefRangeEnd = 1094180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode.NativeMethodInfoPtr_get_IconClass_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public virtual unsafe bool UseParallelParentDuration
    {
      [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode.NativeMethodInfoPtr_get_UseParallelParentDuration_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public unsafe bool IsUsingParallelParentDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_IsUsingParallelParentDuration_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094180, XrefRangeEnd = 1094190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Create(string name = null, bool enabled = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &enabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_Create_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094190, XrefRangeEnd = 1094191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InvokeOnDoRedraw()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_InvokeOnDoRedraw_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094191, XrefRangeEnd = 1094197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateNewGuid()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_CreateNewGuid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe float GetDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode.NativeMethodInfoPtr_GetDuration_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool IsInfiniteDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode.NativeMethodInfoPtr_IsInfiniteDuration_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe NodeStatus GetNodeStatus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_New_NodeStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094197, XrefRangeEnd = 1094198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetPreviewDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_GetPreviewDuration_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode.NativeMethodInfoPtr_OnCreate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe bool HasParent
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094198, XrefRangeEnd = 1094202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_HasParent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool EnabledInTree
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094202, XrefRangeEnd = 1094203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_EnabledInTree_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int Level
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094203, XrefRangeEnd = 1094204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_get_Level_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1094209, RefRangeEnd = 1094211, XrefRangeStart = 1094204, XrefRangeEnd = 1094209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetLevel(int level = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &level;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_GetLevel_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094211, XrefRangeEnd = 1094215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool RemoveFromHierarchy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_RemoveFromHierarchy_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnVersionChanged(int previousVersion, int newVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &previousVersion;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newVersion;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094215, XrefRangeEnd = 1094219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ValidateVersion()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode.NativeMethodInfoPtr_ValidateVersion_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094219, XrefRangeEnd = 1094223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSelfOrDecendantOf(SequenceEditorNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_IsSelfOrDecendantOf_Public_Boolean_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094223, XrefRangeEnd = 1094228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsDecendantOf(SequenceEditorNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_IsDecendantOf_Public_Boolean_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1094232, RefRangeEnd = 1094233, XrefRangeStart = 1094228, XrefRangeEnd = 1094232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _IsDecendantOf(SequenceEditorNode node, int level = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &level;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr__IsDecendantOf_Private_Boolean_SequenceEditorNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094233, XrefRangeEnd = 1094243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetPathString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_GetPathString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1094255, RefRangeEnd = 1094256, XrefRangeStart = 1094243, XrefRangeEnd = 1094255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InternalGetPathString(List<string> path)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) path);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr_InternalGetPathString_Private_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorNode()
    {
      Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorNode));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr);
      SequenceEditorNode.NativeFieldInfoPtr__Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (_Version));
      SequenceEditorNode.NativeFieldInfoPtr__IsExposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (_IsExposed));
      SequenceEditorNode.NativeFieldInfoPtr__ExposeIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (_ExposeIdentifier));
      SequenceEditorNode.NativeFieldInfoPtr__CurrentVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, "<CurrentVersion>k__BackingField");
      SequenceEditorNode.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (_Guid));
      SequenceEditorNode.NativeFieldInfoPtr__Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (_Parent));
      SequenceEditorNode.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (_Name));
      SequenceEditorNode.NativeFieldInfoPtr__Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (_Enabled));
      SequenceEditorNode.NativeFieldInfoPtr__IsInfinite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (_IsInfinite));
      SequenceEditorNode.NativeFieldInfoPtr__Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (_Sequence));
      SequenceEditorNode.NativeFieldInfoPtr__VisualElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (_VisualElement));
      SequenceEditorNode.NativeFieldInfoPtr_OnDoRedraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (OnDoRedraw));
      SequenceEditorNode.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686689);
      SequenceEditorNode.NativeMethodInfoPtr_get_IsInfinite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686690);
      SequenceEditorNode.NativeMethodInfoPtr_get_IsExposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686691);
      SequenceEditorNode.NativeMethodInfoPtr_get_Guid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686692);
      SequenceEditorNode.NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686693);
      SequenceEditorNode.NativeMethodInfoPtr_get_Parent_Public_get_SequenceEditorNode_FlowNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686694);
      SequenceEditorNode.NativeMethodInfoPtr_set_Parent_Public_set_Void_SequenceEditorNode_FlowNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686695);
      SequenceEditorNode.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686696);
      SequenceEditorNode.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686697);
      SequenceEditorNode.NativeMethodInfoPtr_get_ExposeIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686698);
      SequenceEditorNode.NativeMethodInfoPtr_set_ExposeIdentifier_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686699);
      SequenceEditorNode.NativeMethodInfoPtr_get_RawExposeIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686700);
      SequenceEditorNode.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686701);
      SequenceEditorNode.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686702);
      SequenceEditorNode.NativeMethodInfoPtr_get_Sequence_Public_get_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686703);
      SequenceEditorNode.NativeMethodInfoPtr_set_Sequence_Public_set_Void_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686704);
      SequenceEditorNode.NativeMethodInfoPtr_get_VisualElement_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686705);
      SequenceEditorNode.NativeMethodInfoPtr_set_VisualElement_Public_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686706);
      SequenceEditorNode.NativeMethodInfoPtr_add_OnDoRedraw_Public_add_Void_VoidDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686707);
      SequenceEditorNode.NativeMethodInfoPtr_remove_OnDoRedraw_Public_rem_Void_VoidDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686708);
      SequenceEditorNode.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686709);
      SequenceEditorNode.NativeMethodInfoPtr_get_IconClass_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686710);
      SequenceEditorNode.NativeMethodInfoPtr_get_UseParallelParentDuration_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686711);
      SequenceEditorNode.NativeMethodInfoPtr_IsUsingParallelParentDuration_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686712);
      SequenceEditorNode.NativeMethodInfoPtr_Create_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686713);
      SequenceEditorNode.NativeMethodInfoPtr_InvokeOnDoRedraw_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686714);
      SequenceEditorNode.NativeMethodInfoPtr_CreateNewGuid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686715);
      SequenceEditorNode.NativeMethodInfoPtr_GetDuration_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686716);
      SequenceEditorNode.NativeMethodInfoPtr_IsInfiniteDuration_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686717);
      SequenceEditorNode.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_New_NodeStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686718);
      SequenceEditorNode.NativeMethodInfoPtr_GetPreviewDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686719);
      SequenceEditorNode.NativeMethodInfoPtr_OnCreate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686720);
      SequenceEditorNode.NativeMethodInfoPtr_get_HasParent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686721);
      SequenceEditorNode.NativeMethodInfoPtr_get_EnabledInTree_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686722);
      SequenceEditorNode.NativeMethodInfoPtr_get_Level_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686723);
      SequenceEditorNode.NativeMethodInfoPtr_GetLevel_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686724);
      SequenceEditorNode.NativeMethodInfoPtr_RemoveFromHierarchy_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686725);
      SequenceEditorNode.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686726);
      SequenceEditorNode.NativeMethodInfoPtr_ValidateVersion_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686727);
      SequenceEditorNode.NativeMethodInfoPtr_IsSelfOrDecendantOf_Public_Boolean_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686728);
      SequenceEditorNode.NativeMethodInfoPtr_IsDecendantOf_Public_Boolean_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686729);
      SequenceEditorNode.NativeMethodInfoPtr__IsDecendantOf_Private_Boolean_SequenceEditorNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686730);
      SequenceEditorNode.NativeMethodInfoPtr_GetPathString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686731);
      SequenceEditorNode.NativeMethodInfoPtr_InternalGetPathString_Private_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686732);
      SequenceEditorNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, 100686733);
    }

    public SequenceEditorNode(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int _Version
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Version));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Version)) = value;
      }
    }

    public unsafe bool _IsExposed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__IsExposed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__IsExposed)) = value;
      }
    }

    public unsafe string _ExposeIdentifier
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__ExposeIdentifier)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__ExposeIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int _CurrentVersion_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__CurrentVersion_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__CurrentVersion_k__BackingField)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe SequenceEditorNode_FlowNode _Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Parent));
        return pointer == System.IntPtr.Zero ? (SequenceEditorNode_FlowNode) null : new SequenceEditorNode_FlowNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _Enabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Enabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Enabled)) = value;
      }
    }

    public unsafe bool _IsInfinite
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__IsInfinite));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__IsInfinite)) = value;
      }
    }

    public unsafe SequenceEditorObject _Sequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Sequence));
        return pointer == System.IntPtr.Zero ? (SequenceEditorObject) null : new SequenceEditorObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__Sequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VisualElement _VisualElement
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__VisualElement));
        return pointer == System.IntPtr.Zero ? (VisualElement) null : new VisualElement(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr__VisualElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceEditorNode.VoidDelegate OnDoRedraw
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr_OnDoRedraw));
        return pointer == System.IntPtr.Zero ? (SequenceEditorNode.VoidDelegate) null : new SequenceEditorNode.VoidDelegate(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode.NativeFieldInfoPtr_OnDoRedraw), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class VoidDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe VoidDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode.VoidDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.VoidDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 276826, RefRangeEnd = 276931, XrefRangeStart = 276826, XrefRangeEnd = 276931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.VoidDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.VoidDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode.VoidDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static VoidDelegate()
      {
        Il2CppClassPointerStore<SequenceEditorNode.VoidDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceEditorNode>.NativeClassPtr, nameof (VoidDelegate));
        SequenceEditorNode.VoidDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode.VoidDelegate>.NativeClassPtr, 100686734);
        SequenceEditorNode.VoidDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode.VoidDelegate>.NativeClassPtr, 100686735);
        SequenceEditorNode.VoidDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode.VoidDelegate>.NativeClassPtr, 100686736);
        SequenceEditorNode.VoidDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode.VoidDelegate>.NativeClassPtr, 100686737);
      }

      public VoidDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator SequenceEditorNode.VoidDelegate([In] System.Action obj0)
      {
        return DelegateSupport.ConvertDelegate<SequenceEditorNode.VoidDelegate>((System.Delegate) obj0);
      }

      public static SequenceEditorNode.VoidDelegate operator +(
        [In] SequenceEditorNode.VoidDelegate obj0,
        [In] SequenceEditorNode.VoidDelegate obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<SequenceEditorNode.VoidDelegate>();
      }

      public static SequenceEditorNode.VoidDelegate operator -(
        [In] SequenceEditorNode.VoidDelegate obj0,
        [In] SequenceEditorNode.VoidDelegate obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (SequenceEditorNode.VoidDelegate) @delegate : @delegate.Cast<SequenceEditorNode.VoidDelegate>();
      }
    }
  }
}
