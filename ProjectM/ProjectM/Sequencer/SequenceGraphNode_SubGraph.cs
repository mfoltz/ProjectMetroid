// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceGraphNode_SubGraph
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
  public class SequenceGraphNode_SubGraph : SequenceGraphNode
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GraphData;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GraphData_Public_get_SequenceGraphData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_GraphData_Public_set_Void_SequenceGraphData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TopbarClass_Public_Virtual_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOverriddenInSocketName_Public_Virtual_String_GraphNodeInSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOverriddenOutSocketName_Public_Virtual_String_GraphNodeOutSocket_0;

    public unsafe SequenceGraphData GraphData
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 22398, RefRangeEnd = 22405, XrefRangeStart = 22398, XrefRangeEnd = 22405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_SubGraph.NativeMethodInfoPtr_get_GraphData_Public_get_SequenceGraphData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SequenceGraphData) null : new SequenceGraphData(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097462, XrefRangeEnd = 1097500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_SubGraph.NativeMethodInfoPtr_set_GraphData_Public_set_Void_SequenceGraphData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public override unsafe GraphFunction NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_SubGraph.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GraphFunction*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public override unsafe string TopbarClass
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097500, XrefRangeEnd = 1097502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_SubGraph.NativeMethodInfoPtr_get_TopbarClass_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public override unsafe string DisplayName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097502, XrefRangeEnd = 1097510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_SubGraph.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097510, XrefRangeEnd = 1097516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode_SubGraph()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_SubGraph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097516, XrefRangeEnd = 1097521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode_SubGraph(Vector2 position)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_SubGraph.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097521, XrefRangeEnd = 1097526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<BlackboardRegisterType> ValidSocketInTypes(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_SubGraph.NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<BlackboardRegisterType>) null : new Il2CppStructArray<BlackboardRegisterType>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097526, XrefRangeEnd = 1097533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool CalculateInSocketTypes(
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_SubGraph.NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<string> local = ref changedSockets;
      System.IntPtr pointer = zero;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<string>) list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097533, XrefRangeEnd = 1097551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool CalculateOutSocketTypes(
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_SubGraph.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<string> local = ref changedSockets;
      System.IntPtr pointer = zero;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<string>) list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097551, XrefRangeEnd = 1097569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetOverriddenInSocketName(GraphNodeInSocket inSocket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inSocket);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_SubGraph.NativeMethodInfoPtr_GetOverriddenInSocketName_Public_Virtual_String_GraphNodeInSocket_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097569, XrefRangeEnd = 1097588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetOverriddenOutSocketName(GraphNodeOutSocket outSocket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outSocket);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_SubGraph.NativeMethodInfoPtr_GetOverriddenOutSocketName_Public_Virtual_String_GraphNodeOutSocket_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static SequenceGraphNode_SubGraph()
    {
      Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceGraphNode_SubGraph));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr);
      SequenceGraphNode_SubGraph.NativeFieldInfoPtr__GraphData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, nameof (_GraphData));
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr_get_GraphData_Public_get_SequenceGraphData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687076);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr_set_GraphData_Public_set_Void_SequenceGraphData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687077);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687078);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr_get_TopbarClass_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687079);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687080);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687081);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687082);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687083);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr_CalculateInSocketTypes_Protected_Virtual_Boolean_BlackboardRegisterType_Int32_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687084);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687085);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr_GetOverriddenInSocketName_Public_Virtual_String_GraphNodeInSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687086);
      SequenceGraphNode_SubGraph.NativeMethodInfoPtr_GetOverriddenOutSocketName_Public_Virtual_String_GraphNodeOutSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, 100687087);
    }

    public SequenceGraphNode_SubGraph(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceGraphData _GraphData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode_SubGraph.NativeFieldInfoPtr__GraphData));
        return pointer == System.IntPtr.Zero ? (SequenceGraphData) null : new SequenceGraphData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode_SubGraph.NativeFieldInfoPtr__GraphData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.SequenceGraphNode_SubGraph/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__set_GraphData_b__3_0_Internal_BlackboardRegisterType_GraphNodeOutSocket_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphNode_SubGraph.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_SubGraph.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe BlackboardRegisterType _set_GraphData_b__3_0(GraphNodeOutSocket a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_SubGraph.__c.NativeMethodInfoPtr__set_GraphData_b__3_0_Internal_BlackboardRegisterType_GraphNodeOutSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BlackboardRegisterType*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<SequenceGraphNode_SubGraph.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceGraphNode_SubGraph>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGraphNode_SubGraph.__c>.NativeClassPtr);
        SequenceGraphNode_SubGraph.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphNode_SubGraph.__c>.NativeClassPtr, "<>9");
        SequenceGraphNode_SubGraph.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphNode_SubGraph.__c>.NativeClassPtr, "<>9__3_0");
        SequenceGraphNode_SubGraph.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph.__c>.NativeClassPtr, 100687089);
        SequenceGraphNode_SubGraph.__c.NativeMethodInfoPtr__set_GraphData_b__3_0_Internal_BlackboardRegisterType_GraphNodeOutSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_SubGraph.__c>.NativeClassPtr, 100687090);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe SequenceGraphNode_SubGraph.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SequenceGraphNode_SubGraph.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (SequenceGraphNode_SubGraph.__c) null : new SequenceGraphNode_SubGraph.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SequenceGraphNode_SubGraph.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GraphNodeOutSocket, BlackboardRegisterType> __9__3_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SequenceGraphNode_SubGraph.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GraphNodeOutSocket, BlackboardRegisterType>) null : new Il2CppSystem.Func<GraphNodeOutSocket, BlackboardRegisterType>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SequenceGraphNode_SubGraph.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
