// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Node_Split
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
  public class Node_Split : GraphNodeBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__InputGuid;
    private static readonly IntPtr NativeFieldInfoPtr__Output1Guid;
    private static readonly IntPtr NativeFieldInfoPtr__Output2Guid;
    private static readonly IntPtr NativeFieldInfoPtr__Output3Guid;
    private static readonly IntPtr NativeFieldInfoPtr__Output4Guid;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0;
    private static readonly IntPtr NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090648, XrefRangeEnd = 1090654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Node_Split(
      string output1,
      string output2,
      string output3,
      string output4,
      string input)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Node_Split>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(output1);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(output2);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(output3);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(output4);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_Split.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090654, XrefRangeEnd = 1090655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool IsNodeValid(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_Split.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090655, XrefRangeEnd = 1090678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      BlackboardBuilder blackboardBuilder,
      ref GraphWriter graphWriter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref graphWriter;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_Split.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1090782, RefRangeEnd = 1090783, XrefRangeStart = 1090678, XrefRangeEnd = 1090782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Function(ref GraphReader graphReader, [In] ref Blackboard blackboard)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref graphReader;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref blackboard;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_Split.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Node_Split()
    {
      Il2CppClassPointerStore<Node_Split>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Node_Split));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Node_Split>.NativeClassPtr);
      Node_Split.NativeFieldInfoPtr__InputGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Split>.NativeClassPtr, nameof (_InputGuid));
      Node_Split.NativeFieldInfoPtr__Output1Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Split>.NativeClassPtr, nameof (_Output1Guid));
      Node_Split.NativeFieldInfoPtr__Output2Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Split>.NativeClassPtr, nameof (_Output2Guid));
      Node_Split.NativeFieldInfoPtr__Output3Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Split>.NativeClassPtr, nameof (_Output3Guid));
      Node_Split.NativeFieldInfoPtr__Output4Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_Split>.NativeClassPtr, nameof (_Output4Guid));
      Node_Split.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_Split>.NativeClassPtr, 100685946);
      Node_Split.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_Split>.NativeClassPtr, 100685947);
      Node_Split.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_Split>.NativeClassPtr, 100685948);
      Node_Split.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_Split>.NativeClassPtr, 100685949);
    }

    public Node_Split(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _InputGuid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Split.NativeFieldInfoPtr__InputGuid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Split.NativeFieldInfoPtr__InputGuid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Output1Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Split.NativeFieldInfoPtr__Output1Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Split.NativeFieldInfoPtr__Output1Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Output2Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Split.NativeFieldInfoPtr__Output2Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Split.NativeFieldInfoPtr__Output2Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Output3Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Split.NativeFieldInfoPtr__Output3Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Split.NativeFieldInfoPtr__Output3Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Output4Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_Split.NativeFieldInfoPtr__Output4Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_Split.NativeFieldInfoPtr__Output4Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
