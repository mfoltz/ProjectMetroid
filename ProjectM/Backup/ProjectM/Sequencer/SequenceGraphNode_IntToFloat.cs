﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceGraphNode_IntToFloat
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
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SequenceGraphNode_IntToFloat : SequenceGraphNode
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0;

    public override unsafe GraphFunction NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_IntToFloat.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GraphFunction*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096563, XrefRangeEnd = 1096572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode_IntToFloat()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphNode_IntToFloat>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_IntToFloat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096572, XrefRangeEnd = 1096580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode_IntToFloat(Vector2 position)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphNode_IntToFloat>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &position;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_IntToFloat.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096580, XrefRangeEnd = 1096583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<BlackboardRegisterType> ValidSocketInTypes(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &index;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_IntToFloat.NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<BlackboardRegisterType>) null : new Il2CppStructArray<BlackboardRegisterType>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096583, XrefRangeEnd = 1096590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool CalculateInSocketTypes(
      BlackboardRegisterType newSocketType,
      int index,
      out List<string> changedSockets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[3];
      numPtr1[0] = (IntPtr) &newSocketType;
      *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(2) * sizeof (IntPtr));
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr2 = &zero;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      IntPtr exc;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_IntToFloat.NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<string> local = ref changedSockets;
      IntPtr pointer = zero;
      List<> list = pointer == IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<string>) list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096590, XrefRangeEnd = 1096605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool CalculateOutSocketTypes(
      Il2CppStructArray<BlackboardRegisterType> socketTypes,
      out List<string> changedSockets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) socketTypes);
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr2 = &zero;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      IntPtr exc;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_IntToFloat.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<string> local = ref changedSockets;
      IntPtr pointer = zero;
      List<> list = pointer == IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<string>) list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static SequenceGraphNode_IntToFloat()
    {
      Il2CppClassPointerStore<SequenceGraphNode_IntToFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceGraphNode_IntToFloat));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGraphNode_IntToFloat>.NativeClassPtr);
      SequenceGraphNode_IntToFloat.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_IntToFloat>.NativeClassPtr, 100686953);
      SequenceGraphNode_IntToFloat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_IntToFloat>.NativeClassPtr, 100686954);
      SequenceGraphNode_IntToFloat.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_IntToFloat>.NativeClassPtr, 100686955);
      SequenceGraphNode_IntToFloat.NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_IntToFloat>.NativeClassPtr, 100686956);
      SequenceGraphNode_IntToFloat.NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_IntToFloat>.NativeClassPtr, 100686957);
      SequenceGraphNode_IntToFloat.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_IntToFloat>.NativeClassPtr, 100686958);
    }

    public SequenceGraphNode_IntToFloat(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
