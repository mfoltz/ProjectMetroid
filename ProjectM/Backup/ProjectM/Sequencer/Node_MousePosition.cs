﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Node_MousePosition
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
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  public class Node_MousePosition : GraphNodeBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__OutputName;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0;
    private static readonly IntPtr NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_float3_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Node_MousePosition(string output)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Node_MousePosition>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(output);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_MousePosition.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool IsNodeValid(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_MousePosition.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090095, XrefRangeEnd = 1090099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      BlackboardBuilder blackboardBuilder,
      ref GraphWriter graphWriter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref graphWriter;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_MousePosition.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090099, XrefRangeEnd = 1090103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Function(
      ref GraphReader graphReader,
      [In] ref Blackboard blackboard,
      Entity localCharacterEntity)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) ref graphReader;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref blackboard;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &localCharacterEntity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_MousePosition.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1090107, RefRangeEnd = 1090108, XrefRangeStart = 1090103, XrefRangeEnd = 1090107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Function(
      ref GraphReader graphReader,
      [In] ref Blackboard blackboard,
      float3 mousePosition)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) ref graphReader;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref blackboard;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &mousePosition;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_MousePosition.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_float3_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Node_MousePosition()
    {
      Il2CppClassPointerStore<Node_MousePosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Node_MousePosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Node_MousePosition>.NativeClassPtr);
      Node_MousePosition.NativeFieldInfoPtr__OutputName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_MousePosition>.NativeClassPtr, nameof (_OutputName));
      Node_MousePosition.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_MousePosition>.NativeClassPtr, 100685889);
      Node_MousePosition.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_MousePosition>.NativeClassPtr, 100685890);
      Node_MousePosition.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_MousePosition>.NativeClassPtr, 100685891);
      Node_MousePosition.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_MousePosition>.NativeClassPtr, 100685892);
      Node_MousePosition.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_MousePosition>.NativeClassPtr, 100685893);
    }

    public Node_MousePosition(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _OutputName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_MousePosition.NativeFieldInfoPtr__OutputName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_MousePosition.NativeFieldInfoPtr__OutputName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
