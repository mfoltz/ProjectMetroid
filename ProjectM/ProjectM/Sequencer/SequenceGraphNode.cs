// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceGraphNode
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UIElements;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SequenceGraphNode : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr__Position;
    private static readonly System.IntPtr NativeFieldInfoPtr__InSockets;
    private static readonly System.IntPtr NativeFieldInfoPtr__OutSockets;
    private static readonly System.IntPtr NativeFieldInfoPtr__SetInitialDefaults;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Guid_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_GraphFunction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TopbarClass_Public_Virtual_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InSockets_Public_get_List_1_GraphNodeInSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OutSockets_Public_get_List_1_GraphNodeOutSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitSockets_Protected_Void_Il2CppStructArray_1_BlackboardRegisterType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultValueByType_Protected_Virtual_New_SocketDefaultValue_Int32_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCustomContent_Public_Virtual_New_Boolean_byref_VisualElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidSocketInTypes_Public_Abstract_Virtual_New_Il2CppStructArray_1_BlackboardRegisterType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidSocketInTypesAsList_Public_List_1_BlackboardRegisterType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidSocketType_Public_Boolean_Int32_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanChangeSocketInTypes_Public_Boolean_Int32_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSocketType_Public_Virtual_New_Boolean_IGraphNodeSocket_BlackboardRegisterType_Int32_Action_1_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_New_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Void_Il2CppStructArray_1_BlackboardRegisterType_Action_1_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_New_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOverriddenInSocketName_Public_Virtual_New_String_GraphNodeInSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOverriddenOutSocketName_Public_Virtual_New_String_GraphNodeOutSocket_0;

    public unsafe string Guid
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr_get_Guid_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe Vector2 Position
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe GraphFunction NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_GraphFunction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GraphFunction*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe string DisplayName
    {
      [CallerCount(16), CachedScanResults(RefRangeStart = 1095403, RefRangeEnd = 1095419, XrefRangeStart = 1095397, XrefRangeEnd = 1095403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public virtual unsafe string TopbarClass
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095419, XrefRangeEnd = 1095421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_get_TopbarClass_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe List<GraphNodeInSocket> InSockets
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr_get_InSockets_Public_get_List_1_GraphNodeInSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<GraphNodeInSocket>) null : new List<GraphNodeInSocket>(pointer);
      }
    }

    public unsafe List<GraphNodeOutSocket> OutSockets
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr_get_OutSockets_Public_get_List_1_GraphNodeOutSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<GraphNodeOutSocket>) null : new List<GraphNodeOutSocket>(pointer);
      }
    }

    [CallerCount(100)]
    [CachedScanResults(RefRangeStart = 1095428, RefRangeEnd = 1095528, XrefRangeStart = 1095421, XrefRangeEnd = 1095428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode(Vector2 position)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(101)]
    [CachedScanResults(RefRangeStart = 1095558, RefRangeEnd = 1095659, XrefRangeStart = 1095528, XrefRangeEnd = 1095558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitSockets(Il2CppStructArray<BlackboardRegisterType> inTypes, int outSize)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inTypes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outSize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr_InitSockets_Protected_Void_Il2CppStructArray_1_BlackboardRegisterType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095659, XrefRangeEnd = 1095660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe SocketDefaultValue GetDefaultValueByType(
      int index,
      BlackboardRegisterType socketType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &socketType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_GetDefaultValueByType_Protected_Virtual_New_SocketDefaultValue_Int32_BlackboardRegisterType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SocketDefaultValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095660, XrefRangeEnd = 1095661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool TryGetCustomContent(out VisualElement element)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_TryGetCustomContent_Public_Virtual_New_Boolean_byref_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref VisualElement local = ref element;
      System.IntPtr pointer = zero;
      VisualElement visualElement = pointer == System.IntPtr.Zero ? (VisualElement) null : new VisualElement(pointer);
      local = visualElement;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe Il2CppStructArray<BlackboardRegisterType> ValidSocketInTypes(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_ValidSocketInTypes_Public_Abstract_Virtual_New_Il2CppStructArray_1_BlackboardRegisterType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<BlackboardRegisterType>) null : new Il2CppStructArray<BlackboardRegisterType>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095661, XrefRangeEnd = 1095687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<BlackboardRegisterType> ValidSocketInTypesAsList(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr_ValidSocketInTypesAsList_Public_List_1_BlackboardRegisterType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<BlackboardRegisterType>) null : new List<BlackboardRegisterType>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095687, XrefRangeEnd = 1095690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidSocketType(int index, BlackboardRegisterType socketType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &socketType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr_IsValidSocketType_Public_Boolean_Int32_BlackboardRegisterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095690, XrefRangeEnd = 1095693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanChangeSocketInTypes(int index, BlackboardRegisterType socketType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &socketType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr_CanChangeSocketInTypes_Public_Boolean_Int32_BlackboardRegisterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095693, XrefRangeEnd = 1095711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool SetSocketType(
      IGraphNodeSocket socket,
      BlackboardRegisterType newSocketType,
      int index,
      Il2CppSystem.Action<List<string>> onChanges = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) socket);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newSocketType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onChanges);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_SetSocketType_Public_Virtual_New_Boolean_IGraphNodeSocket_BlackboardRegisterType_Int32_Action_1_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095711, XrefRangeEnd = 1095727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool CalculateInSocketTypes(
      BlackboardRegisterType newSocketType,
      int index,
      out List<string> changedSockets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &newSocketType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_New_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<string> local = ref changedSockets;
      System.IntPtr pointer = zero;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<string>) list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095727, XrefRangeEnd = 1095730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CalculateOutSocketTypes(
      Il2CppStructArray<BlackboardRegisterType> socketTypes,
      Il2CppSystem.Action<List<string>> onChanges = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) socketTypes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onChanges);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Void_Il2CppStructArray_1_BlackboardRegisterType_Action_1_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1095755, RefRangeEnd = 1095757, XrefRangeStart = 1095730, XrefRangeEnd = 1095755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool CalculateOutSocketTypes(
      Il2CppStructArray<BlackboardRegisterType> socketTypes,
      out List<string> changedSockets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) socketTypes);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_New_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<string> local = ref changedSockets;
      System.IntPtr pointer = zero;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<string>) list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095757, XrefRangeEnd = 1095759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe string GetOverriddenInSocketName(GraphNodeInSocket outSocket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outSocket);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_GetOverriddenInSocketName_Public_Virtual_New_String_GraphNodeInSocket_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095759, XrefRangeEnd = 1095761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe string GetOverriddenOutSocketName(GraphNodeOutSocket outSocket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outSocket);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode.NativeMethodInfoPtr_GetOverriddenOutSocketName_Public_Virtual_New_String_GraphNodeOutSocket_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static SequenceGraphNode()
    {
      Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceGraphNode));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr);
      SequenceGraphNode.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, nameof (_Guid));
      SequenceGraphNode.NativeFieldInfoPtr__Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, nameof (_Position));
      SequenceGraphNode.NativeFieldInfoPtr__InSockets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, nameof (_InSockets));
      SequenceGraphNode.NativeFieldInfoPtr__OutSockets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, nameof (_OutSockets));
      SequenceGraphNode.NativeFieldInfoPtr__SetInitialDefaults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, nameof (_SetInitialDefaults));
      SequenceGraphNode.NativeMethodInfoPtr_get_Guid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686823);
      SequenceGraphNode.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686824);
      SequenceGraphNode.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686825);
      SequenceGraphNode.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_GraphFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686826);
      SequenceGraphNode.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686827);
      SequenceGraphNode.NativeMethodInfoPtr_get_TopbarClass_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686828);
      SequenceGraphNode.NativeMethodInfoPtr_get_InSockets_Public_get_List_1_GraphNodeInSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686829);
      SequenceGraphNode.NativeMethodInfoPtr_get_OutSockets_Public_get_List_1_GraphNodeOutSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686830);
      SequenceGraphNode.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686831);
      SequenceGraphNode.NativeMethodInfoPtr_InitSockets_Protected_Void_Il2CppStructArray_1_BlackboardRegisterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686832);
      SequenceGraphNode.NativeMethodInfoPtr_GetDefaultValueByType_Protected_Virtual_New_SocketDefaultValue_Int32_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686833);
      SequenceGraphNode.NativeMethodInfoPtr_TryGetCustomContent_Public_Virtual_New_Boolean_byref_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686834);
      SequenceGraphNode.NativeMethodInfoPtr_ValidSocketInTypes_Public_Abstract_Virtual_New_Il2CppStructArray_1_BlackboardRegisterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686835);
      SequenceGraphNode.NativeMethodInfoPtr_ValidSocketInTypesAsList_Public_List_1_BlackboardRegisterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686836);
      SequenceGraphNode.NativeMethodInfoPtr_IsValidSocketType_Public_Boolean_Int32_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686837);
      SequenceGraphNode.NativeMethodInfoPtr_CanChangeSocketInTypes_Public_Boolean_Int32_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686838);
      SequenceGraphNode.NativeMethodInfoPtr_SetSocketType_Public_Virtual_New_Boolean_IGraphNodeSocket_BlackboardRegisterType_Int32_Action_1_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686839);
      SequenceGraphNode.NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_New_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686840);
      SequenceGraphNode.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Void_Il2CppStructArray_1_BlackboardRegisterType_Action_1_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686841);
      SequenceGraphNode.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_New_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686842);
      SequenceGraphNode.NativeMethodInfoPtr_GetOverriddenInSocketName_Public_Virtual_New_String_GraphNodeInSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686843);
      SequenceGraphNode.NativeMethodInfoPtr_GetOverriddenOutSocketName_Public_Virtual_New_String_GraphNodeOutSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode>.NativeClassPtr, 100686844);
    }

    public SequenceGraphNode(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Vector2 _Position
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode.NativeFieldInfoPtr__Position));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode.NativeFieldInfoPtr__Position)) = value;
      }
    }

    public unsafe List<GraphNodeInSocket> _InSockets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode.NativeFieldInfoPtr__InSockets));
        return pointer == System.IntPtr.Zero ? (List<GraphNodeInSocket>) null : new List<GraphNodeInSocket>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode.NativeFieldInfoPtr__InSockets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<GraphNodeOutSocket> _OutSockets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode.NativeFieldInfoPtr__OutSockets));
        return pointer == System.IntPtr.Zero ? (List<GraphNodeOutSocket>) null : new List<GraphNodeOutSocket>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode.NativeFieldInfoPtr__OutSockets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _SetInitialDefaults
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode.NativeFieldInfoPtr__SetInitialDefaults));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode.NativeFieldInfoPtr__SetInitialDefaults)) = value;
      }
    }
  }
}
