﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Node_IntToFloat
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class Node_IntToFloat : GraphNodeBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__InputName;
    private static readonly IntPtr NativeFieldInfoPtr__OutputName;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0;
    private static readonly IntPtr NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0;

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 35163, RefRangeEnd = 35175, XrefRangeStart = 35163, XrefRangeEnd = 35175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Node_IntToFloat(string input, string output)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Node_IntToFloat>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(output);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_IntToFloat.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_IntToFloat.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091247, XrefRangeEnd = 1091253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      BlackboardBuilder blackboardBuilder,
      ref GraphWriter graphWriter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref graphWriter;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_IntToFloat.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1091260, RefRangeEnd = 1091261, XrefRangeStart = 1091253, XrefRangeEnd = 1091260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Function(ref GraphReader graphReader, [In] ref Blackboard blackboard)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref graphReader;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref blackboard;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_IntToFloat.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Node_IntToFloat()
    {
      Il2CppClassPointerStore<Node_IntToFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Node_IntToFloat));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Node_IntToFloat>.NativeClassPtr);
      Node_IntToFloat.NativeFieldInfoPtr__InputName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_IntToFloat>.NativeClassPtr, nameof (_InputName));
      Node_IntToFloat.NativeFieldInfoPtr__OutputName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_IntToFloat>.NativeClassPtr, nameof (_OutputName));
      Node_IntToFloat.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_IntToFloat>.NativeClassPtr, 100686026);
      Node_IntToFloat.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_IntToFloat>.NativeClassPtr, 100686027);
      Node_IntToFloat.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_IntToFloat>.NativeClassPtr, 100686028);
      Node_IntToFloat.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_IntToFloat>.NativeClassPtr, 100686029);
    }

    public Node_IntToFloat(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _InputName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_IntToFloat.NativeFieldInfoPtr__InputName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_IntToFloat.NativeFieldInfoPtr__InputName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _OutputName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_IntToFloat.NativeFieldInfoPtr__OutputName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_IntToFloat.NativeFieldInfoPtr__OutputName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
