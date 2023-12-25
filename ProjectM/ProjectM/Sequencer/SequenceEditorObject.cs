// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorObject
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequenceEditorObject : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__RootNode;
    private static readonly System.IntPtr NativeFieldInfoPtr__Blackboard;
    private static readonly System.IntPtr NativeFieldInfoPtr__AnimationCollectionGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr__HashVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedNodes;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HashVersion_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSetupGraphs_Public_List_1_SequenceEditorNode_Graph_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExposedNodes_Public_List_1_SequenceEditorNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNodes_Public_List_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetNodes_Private_Void_SequenceEditorNode_List_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetExposedNodes_Private_Void_SequenceEditorNode_List_1_SequenceEditorNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExposedBlackboardParameters_Public_List_1_BlackboardParameter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RootNode_Public_get_SequenceEditorNode_FlowNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Blackboard_Public_get_List_1_BlackboardParameter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AnimationCollectionGuid_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AnimationCollectionGuid_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Guid_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetRootNode_Public_Void_SequenceEditorNode_FlowNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SortBlackboardParameters_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddBlackboardParameter_Public_Void_BlackboardParameter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlackboardParameterExists_Public_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlackboardParameterWithNameExists_Public_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlackboardParameterSort_Private_Int32_BlackboardParameter_BlackboardParameter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DelBlackboardParameter_Public_Void_BlackboardParameter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DelBlackboardParameter_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNode_Public_Boolean_SequenceEditorNode_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindNextNode_Public_SequenceEditorNode_SequenceEditorNode_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDeepestChild_Private_SequenceEditorNode_SequenceEditorNode_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetParentNextSibling_Private_SequenceEditorNode_SequenceEditorNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanMoveNode_Public_Boolean_SequenceEditorNode_SequenceEditorNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaceNode_Public_Void_SequenceEditorNode_SequenceEditorNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNodeByGuid_Public_Boolean_String_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBlackboardParameter_Public_Boolean_String_byref_BlackboardParameter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindNodeByGuid_Private_SequenceEditorNode_SequenceEditorNode_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateVersion_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindUniqueBlackboardParameterName_Public_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindUniqueBlackboardParameterName2_Private_String_String_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Sequencer_ISequenceEditorObject_get_name_Private_Virtual_Final_New_String_0;

    public unsafe int HashVersion
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_get_HashVersion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094299, XrefRangeEnd = 1094307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorObject()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094307, XrefRangeEnd = 1094338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<SequenceEditorNode_Graph> GetSetupGraphs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_GetSetupGraphs_Public_List_1_SequenceEditorNode_Graph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<SequenceEditorNode_Graph>) null : new List<SequenceEditorNode_Graph>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1094345, RefRangeEnd = 1094346, XrefRangeStart = 1094338, XrefRangeEnd = 1094345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<SequenceEditorNode> GetExposedNodes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_GetExposedNodes_Public_List_1_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<SequenceEditorNode>) null : new List<SequenceEditorNode>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094346, XrefRangeEnd = 1094348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<T> GetNodes<T>() where T : SequenceEditorNode
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.MethodInfoStoreGeneric_GetNodes_Public_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<T>) null : new List<T>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094348, XrefRangeEnd = 1094371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InternalGetNodes<T>(SequenceEditorNode node, List<T> nodes) where T : SequenceEditorNode
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nodes);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.MethodInfoStoreGeneric_InternalGetNodes_Private_Void_SequenceEditorNode_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1094391, RefRangeEnd = 1094393, XrefRangeStart = 1094371, XrefRangeEnd = 1094391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InternalGetExposedNodes(
      SequenceEditorNode node,
      List<SequenceEditorNode> exposedNodes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exposedNodes);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_InternalGetExposedNodes_Private_Void_SequenceEditorNode_List_1_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1094416, RefRangeEnd = 1094417, XrefRangeStart = 1094393, XrefRangeEnd = 1094416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<BlackboardParameter> GetExposedBlackboardParameters()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_GetExposedBlackboardParameters_Public_List_1_BlackboardParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<BlackboardParameter>) null : new List<BlackboardParameter>(pointer);
    }

    public unsafe SequenceEditorNode_FlowNode RootNode
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_get_RootNode_Public_get_SequenceEditorNode_FlowNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SequenceEditorNode_FlowNode) null : new SequenceEditorNode_FlowNode(pointer);
      }
    }

    public unsafe List<BlackboardParameter> Blackboard
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_get_Blackboard_Public_get_List_1_BlackboardParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<BlackboardParameter>) null : new List<BlackboardParameter>(pointer);
      }
    }

    public unsafe string AnimationCollectionGuid
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_get_AnimationCollectionGuid_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_set_AnimationCollectionGuid_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int GuidHash
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 64928, RefRangeEnd = 64933, XrefRangeStart = 64928, XrefRangeEnd = 64933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe string Guid
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_get_Guid_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094417, XrefRangeEnd = 1094428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetRootNode(SequenceEditorNode_FlowNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_SetRootNode_Public_Void_SequenceEditorNode_FlowNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094428, XrefRangeEnd = 1094440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SortBlackboardParameters()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_SortBlackboardParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094440, XrefRangeEnd = 1094468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddBlackboardParameter(BlackboardParameter parameter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parameter);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_AddBlackboardParameter_Public_Void_BlackboardParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1094486, RefRangeEnd = 1094490, XrefRangeStart = 1094468, XrefRangeEnd = 1094486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool BlackboardParameterExists(string guid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(guid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_BlackboardParameterExists_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1094507, RefRangeEnd = 1094510, XrefRangeStart = 1094490, XrefRangeEnd = 1094507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool BlackboardParameterWithNameExists(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_BlackboardParameterWithNameExists_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094510, XrefRangeEnd = 1094520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int BlackboardParameterSort(BlackboardParameter x, BlackboardParameter y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_BlackboardParameterSort_Private_Int32_BlackboardParameter_BlackboardParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094520, XrefRangeEnd = 1094538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DelBlackboardParameter(BlackboardParameter parameter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parameter);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_DelBlackboardParameter_Public_Void_BlackboardParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094538, XrefRangeEnd = 1094542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DelBlackboardParameter(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_DelBlackboardParameter_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094542, XrefRangeEnd = 1094565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool MoveNode(SequenceEditorNode node, int direction)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_MoveNode_Public_Boolean_SequenceEditorNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094565, XrefRangeEnd = 1094593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode FindNextNode(SequenceEditorNode currentNode, int direction)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentNode);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_FindNextNode_Public_SequenceEditorNode_SequenceEditorNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SequenceEditorNode) null : new SequenceEditorNode(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1094600, RefRangeEnd = 1094602, XrefRangeStart = 1094593, XrefRangeEnd = 1094600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode GetDeepestChild(SequenceEditorNode node, bool onlyOpen)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyOpen;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_GetDeepestChild_Private_SequenceEditorNode_SequenceEditorNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SequenceEditorNode) null : new SequenceEditorNode(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1094615, RefRangeEnd = 1094617, XrefRangeStart = 1094602, XrefRangeEnd = 1094615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode GetParentNextSibling(SequenceEditorNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_GetParentNextSibling_Private_SequenceEditorNode_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SequenceEditorNode) null : new SequenceEditorNode(pointer);
    }

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanMoveNode(
      SequenceEditorNode nodeToMove,
      SequenceEditorNode destinationNode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nodeToMove);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) destinationNode);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_CanMoveNode_Public_Boolean_SequenceEditorNode_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094617, XrefRangeEnd = 1094627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlaceNode(SequenceEditorNode nodeToPlace, SequenceEditorNode destinationNode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nodeToPlace);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) destinationNode);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_PlaceNode_Public_Void_SequenceEditorNode_SequenceEditorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094627, XrefRangeEnd = 1094649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetNodeByGuid<T>(string guid, out T node) where T : SequenceEditorNode
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(guid);
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref node;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.MethodInfoStoreGeneric_TryGetNodeByGuid_Public_Boolean_String_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref node;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1094670, RefRangeEnd = 1094676, XrefRangeStart = 1094649, XrefRangeEnd = 1094670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBlackboardParameter(string guid, out BlackboardParameter outParameter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(guid);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_TryGetBlackboardParameter_Public_Boolean_String_byref_BlackboardParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref BlackboardParameter local = ref outParameter;
      System.IntPtr pointer = zero;
      BlackboardParameter blackboardParameter = pointer == System.IntPtr.Zero ? (BlackboardParameter) null : new BlackboardParameter(pointer);
      local = blackboardParameter;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1094725, RefRangeEnd = 1094727, XrefRangeStart = 1094676, XrefRangeEnd = 1094725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode FindNodeByGuid(SequenceEditorNode node, string guid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(guid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_FindNodeByGuid_Private_SequenceEditorNode_SequenceEditorNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SequenceEditorNode) null : new SequenceEditorNode(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 486465, RefRangeEnd = 486466, XrefRangeStart = 486465, XrefRangeEnd = 486466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ValidateVersion()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_ValidateVersion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 486465, RefRangeEnd = 486466, XrefRangeStart = 486465, XrefRangeEnd = 486466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnBeforeSerialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnAfterDeserialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094727, XrefRangeEnd = 1094728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string FindUniqueBlackboardParameterName(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_FindUniqueBlackboardParameterName_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1094750, RefRangeEnd = 1094752, XrefRangeStart = 1094728, XrefRangeEnd = 1094750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string FindUniqueBlackboardParameterName2(
      string originalName,
      string tryName,
      int level)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(originalName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(tryName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &level;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_FindUniqueBlackboardParameterName2_Private_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094752, XrefRangeEnd = 1094753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public virtual unsafe string ProjectM_Sequencer_ISequenceEditorObject_get_name()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorObject.NativeMethodInfoPtr_ProjectM_Sequencer_ISequenceEditorObject_get_name_Private_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static SequenceEditorObject()
    {
      Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorObject));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr);
      SequenceEditorObject.NativeFieldInfoPtr__RootNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, nameof (_RootNode));
      SequenceEditorObject.NativeFieldInfoPtr__Blackboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, nameof (_Blackboard));
      SequenceEditorObject.NativeFieldInfoPtr__AnimationCollectionGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, nameof (_AnimationCollectionGuid));
      SequenceEditorObject.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, nameof (_Guid));
      SequenceEditorObject.NativeFieldInfoPtr__HashVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, nameof (_HashVersion));
      SequenceEditorObject.NativeFieldInfoPtr__CachedNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, nameof (_CachedNodes));
      SequenceEditorObject.NativeMethodInfoPtr_get_HashVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686753);
      SequenceEditorObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686754);
      SequenceEditorObject.NativeMethodInfoPtr_GetSetupGraphs_Public_List_1_SequenceEditorNode_Graph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686755);
      SequenceEditorObject.NativeMethodInfoPtr_GetExposedNodes_Public_List_1_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686756);
      SequenceEditorObject.NativeMethodInfoPtr_GetNodes_Public_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686757);
      SequenceEditorObject.NativeMethodInfoPtr_InternalGetNodes_Private_Void_SequenceEditorNode_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686758);
      SequenceEditorObject.NativeMethodInfoPtr_InternalGetExposedNodes_Private_Void_SequenceEditorNode_List_1_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686759);
      SequenceEditorObject.NativeMethodInfoPtr_GetExposedBlackboardParameters_Public_List_1_BlackboardParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686760);
      SequenceEditorObject.NativeMethodInfoPtr_get_RootNode_Public_get_SequenceEditorNode_FlowNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686761);
      SequenceEditorObject.NativeMethodInfoPtr_get_Blackboard_Public_get_List_1_BlackboardParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686762);
      SequenceEditorObject.NativeMethodInfoPtr_get_AnimationCollectionGuid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686763);
      SequenceEditorObject.NativeMethodInfoPtr_set_AnimationCollectionGuid_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686764);
      SequenceEditorObject.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686765);
      SequenceEditorObject.NativeMethodInfoPtr_get_Guid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686766);
      SequenceEditorObject.NativeMethodInfoPtr_SetRootNode_Public_Void_SequenceEditorNode_FlowNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686767);
      SequenceEditorObject.NativeMethodInfoPtr_SortBlackboardParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686768);
      SequenceEditorObject.NativeMethodInfoPtr_AddBlackboardParameter_Public_Void_BlackboardParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686769);
      SequenceEditorObject.NativeMethodInfoPtr_BlackboardParameterExists_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686770);
      SequenceEditorObject.NativeMethodInfoPtr_BlackboardParameterWithNameExists_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686771);
      SequenceEditorObject.NativeMethodInfoPtr_BlackboardParameterSort_Private_Int32_BlackboardParameter_BlackboardParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686772);
      SequenceEditorObject.NativeMethodInfoPtr_DelBlackboardParameter_Public_Void_BlackboardParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686773);
      SequenceEditorObject.NativeMethodInfoPtr_DelBlackboardParameter_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686774);
      SequenceEditorObject.NativeMethodInfoPtr_MoveNode_Public_Boolean_SequenceEditorNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686775);
      SequenceEditorObject.NativeMethodInfoPtr_FindNextNode_Public_SequenceEditorNode_SequenceEditorNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686776);
      SequenceEditorObject.NativeMethodInfoPtr_GetDeepestChild_Private_SequenceEditorNode_SequenceEditorNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686777);
      SequenceEditorObject.NativeMethodInfoPtr_GetParentNextSibling_Private_SequenceEditorNode_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686778);
      SequenceEditorObject.NativeMethodInfoPtr_CanMoveNode_Public_Boolean_SequenceEditorNode_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686779);
      SequenceEditorObject.NativeMethodInfoPtr_PlaceNode_Public_Void_SequenceEditorNode_SequenceEditorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686780);
      SequenceEditorObject.NativeMethodInfoPtr_TryGetNodeByGuid_Public_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686781);
      SequenceEditorObject.NativeMethodInfoPtr_TryGetBlackboardParameter_Public_Boolean_String_byref_BlackboardParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686782);
      SequenceEditorObject.NativeMethodInfoPtr_FindNodeByGuid_Private_SequenceEditorNode_SequenceEditorNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686783);
      SequenceEditorObject.NativeMethodInfoPtr_ValidateVersion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686784);
      SequenceEditorObject.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686785);
      SequenceEditorObject.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686786);
      SequenceEditorObject.NativeMethodInfoPtr_FindUniqueBlackboardParameterName_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686787);
      SequenceEditorObject.NativeMethodInfoPtr_FindUniqueBlackboardParameterName2_Private_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686788);
      SequenceEditorObject.NativeMethodInfoPtr_ProjectM_Sequencer_ISequenceEditorObject_get_name_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr, 100686789);
    }

    public SequenceEditorObject(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceEditorNode_FlowNode _RootNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__RootNode));
        return pointer == System.IntPtr.Zero ? (SequenceEditorNode_FlowNode) null : new SequenceEditorNode_FlowNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__RootNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BlackboardParameter> _Blackboard
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__Blackboard));
        return pointer == System.IntPtr.Zero ? (List<BlackboardParameter>) null : new List<BlackboardParameter>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__Blackboard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _AnimationCollectionGuid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__AnimationCollectionGuid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__AnimationCollectionGuid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int _HashVersion
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__HashVersion));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__HashVersion)) = value;
      }
    }

    public unsafe Dictionary<string, SequenceEditorNode> _CachedNodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__CachedNodes));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, SequenceEditorNode>) null : new Dictionary<string, SequenceEditorNode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorObject.NativeFieldInfoPtr__CachedNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_GetNodes_Public_List_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceEditorObject.NativeMethodInfoPtr_GetNodes_Public_List_1_T_0, Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_InternalGetNodes_Private_Void_SequenceEditorNode_List_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceEditorObject.NativeMethodInfoPtr_InternalGetNodes_Private_Void_SequenceEditorNode_List_1_T_0, Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetNodeByGuid_Public_Boolean_String_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceEditorObject.NativeMethodInfoPtr_TryGetNodeByGuid_Public_Boolean_String_byref_T_0, Il2CppClassPointerStore<SequenceEditorObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
