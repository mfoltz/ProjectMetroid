// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceGraphNode_EulerToQuaternion
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

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SequenceGraphNode_EulerToQuaternion : SequenceGraphNode
  {
    private static readonly IntPtr NativeFieldInfoPtr__AngleType;
    private static readonly IntPtr NativeMethodInfoPtr_get_AngleType_Public_get_AngleType_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_AngleType_Public_set_Void_AngleType_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0;

    public unsafe AngleType AngleType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_get_AngleType_Public_get_AngleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AngleType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_set_AngleType_Public_set_Void_AngleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public override unsafe GraphFunction NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GraphFunction*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096412, XrefRangeEnd = 1096421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode_EulerToQuaternion()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096421, XrefRangeEnd = 1096429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode_EulerToQuaternion(Vector2 position)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &position;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096429, XrefRangeEnd = 1096432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<BlackboardRegisterType> ValidSocketInTypes(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &index;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<BlackboardRegisterType>) null : new Il2CppStructArray<BlackboardRegisterType>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096432, XrefRangeEnd = 1096439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<string> local = ref changedSockets;
      IntPtr pointer = zero;
      List<> list = pointer == IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<string>) list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096439, XrefRangeEnd = 1096464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<string> local = ref changedSockets;
      IntPtr pointer = zero;
      List<> list = pointer == IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<string>) list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static SequenceGraphNode_EulerToQuaternion()
    {
      Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceGraphNode_EulerToQuaternion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr);
      SequenceGraphNode_EulerToQuaternion.NativeFieldInfoPtr__AngleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr, nameof (_AngleType));
      SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_get_AngleType_Public_get_AngleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr, 100686932);
      SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_set_AngleType_Public_set_Void_AngleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr, 100686933);
      SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr, 100686934);
      SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr, 100686935);
      SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr, 100686936);
      SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr, 100686937);
      SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr, 100686938);
      SequenceGraphNode_EulerToQuaternion.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_EulerToQuaternion>.NativeClassPtr, 100686939);
    }

    public SequenceGraphNode_EulerToQuaternion(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AngleType _AngleType
    {
      get
      {
        return *(AngleType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode_EulerToQuaternion.NativeFieldInfoPtr__AngleType));
      }
      [param: In] set
      {
        *(AngleType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode_EulerToQuaternion.NativeFieldInfoPtr__AngleType)) = value;
      }
    }
  }
}
