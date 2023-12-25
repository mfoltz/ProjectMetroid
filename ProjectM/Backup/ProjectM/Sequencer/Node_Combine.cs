// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Node_Combine
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
  public class Node_Combine : GraphNodeBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__Output1Guid;
    private static readonly IntPtr NativeFieldInfoPtr__Output2Guid;
    private static readonly IntPtr NativeFieldInfoPtr__Output3Guid;
    private static readonly IntPtr NativeFieldInfoPtr__Input1Guid;
    private static readonly IntPtr NativeFieldInfoPtr__Input2Guid;
    private static readonly IntPtr NativeFieldInfoPtr__Input3Guid;
    private static readonly IntPtr NativeFieldInfoPtr__Input4Guid;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0;
    private static readonly IntPtr NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090783, XrefRangeEnd = 1090791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Node_Combine(
      string output1,
      string output2,
      string output3,
      string input1,
      string input2,
      string input3,
      string input4)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[7];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(output1);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(output2);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(output3);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input1);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input2);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input3);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input4);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_Combine.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090791, XrefRangeEnd = 1090797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool IsNodeValid(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_Combine.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090797, XrefRangeEnd = 1090822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      BlackboardBuilder blackboardBuilder,
      ref GraphWriter graphWriter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref graphWriter;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_Combine.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1090899, RefRangeEnd = 1090900, XrefRangeStart = 1090822, XrefRangeEnd = 1090899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Function(ref GraphReader graphReader, [In] ref Blackboard blackboard)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref graphReader;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref blackboard;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_Combine.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Node_Combine()
    {
      Il2CppClassPointerStore<Node_Combine>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Node_Combine));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr);
      Node_Combine.NativeFieldInfoPtr__Output1Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, nameof (_Output1Guid));
      Node_Combine.NativeFieldInfoPtr__Output2Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, nameof (_Output2Guid));
      Node_Combine.NativeFieldInfoPtr__Output3Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, nameof (_Output3Guid));
      Node_Combine.NativeFieldInfoPtr__Input1Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, nameof (_Input1Guid));
      Node_Combine.NativeFieldInfoPtr__Input2Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, nameof (_Input2Guid));
      Node_Combine.NativeFieldInfoPtr__Input3Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, nameof (_Input3Guid));
      Node_Combine.NativeFieldInfoPtr__Input4Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, nameof (_Input4Guid));
      Node_Combine.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, 100685950);
      Node_Combine.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, 100685951);
      Node_Combine.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, 100685952);
      Node_Combine.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_Combine>.NativeClassPtr, 100685953);
    }

    public Node_Combine(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Output1Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Output1Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Output1Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Output2Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Output2Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Output2Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Output3Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Output3Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Output3Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Input1Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Input1Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Input1Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Input2Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Input2Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Input2Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Input3Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Input3Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Input3Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Input4Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Input4Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Combine.NativeFieldInfoPtr__Input4Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
