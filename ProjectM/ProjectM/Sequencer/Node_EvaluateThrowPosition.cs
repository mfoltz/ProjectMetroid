// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Node_EvaluateThrowPosition
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  public class Node_EvaluateThrowPosition : GraphNodeBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__InputTName;
    private static readonly IntPtr NativeFieldInfoPtr__InputStartPosName;
    private static readonly IntPtr NativeFieldInfoPtr__InputEndPosName;
    private static readonly IntPtr NativeFieldInfoPtr__InputHeightName;
    private static readonly IntPtr NativeFieldInfoPtr__OutputPositionName;
    private static readonly IntPtr NativeFieldInfoPtr__OutputRotationName;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0;
    private static readonly IntPtr NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0;
    private static readonly IntPtr NativeMethodInfoPtr_SamplePosition_Private_Static_float3_Single_float3_float3_Single_Single_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091667, XrefRangeEnd = 1091674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Node_EvaluateThrowPosition(
      string inputT,
      string inputStartPos,
      string inputEndPos,
      string inputHeight,
      string outputPosition,
      string outputRotation)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(inputT);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(inputStartPos);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(inputEndPos);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(inputHeight);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outputPosition);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outputRotation);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_EvaluateThrowPosition.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091674, XrefRangeEnd = 1091680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool IsNodeValid(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_EvaluateThrowPosition.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091680, XrefRangeEnd = 1091694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      BlackboardBuilder blackboardBuilder,
      ref GraphWriter graphWriter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref graphWriter;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_EvaluateThrowPosition.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1091728, RefRangeEnd = 1091729, XrefRangeStart = 1091694, XrefRangeEnd = 1091728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Function(ref GraphReader graphReader, [In] ref Blackboard blackboard)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref graphReader;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref blackboard;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_EvaluateThrowPosition.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091729, XrefRangeEnd = 1091733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 SamplePosition(
      float t,
      float3 startPosition,
      float3 endPosition,
      float targetHeightAtMiddle,
      float linearHeightMultiplier)
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &t;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &startPosition;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &endPosition;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &targetHeightAtMiddle;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &linearHeightMultiplier;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Node_EvaluateThrowPosition.NativeMethodInfoPtr_SamplePosition_Private_Static_float3_Single_float3_float3_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Node_EvaluateThrowPosition()
    {
      Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Node_EvaluateThrowPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr);
      Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputTName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, nameof (_InputTName));
      Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputStartPosName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, nameof (_InputStartPosName));
      Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputEndPosName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, nameof (_InputEndPosName));
      Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputHeightName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, nameof (_InputHeightName));
      Node_EvaluateThrowPosition.NativeFieldInfoPtr__OutputPositionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, nameof (_OutputPositionName));
      Node_EvaluateThrowPosition.NativeFieldInfoPtr__OutputRotationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, nameof (_OutputRotationName));
      Node_EvaluateThrowPosition.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, 100686079);
      Node_EvaluateThrowPosition.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, 100686080);
      Node_EvaluateThrowPosition.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, 100686081);
      Node_EvaluateThrowPosition.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, 100686082);
      Node_EvaluateThrowPosition.NativeMethodInfoPtr_SamplePosition_Private_Static_float3_Single_float3_float3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_EvaluateThrowPosition>.NativeClassPtr, 100686083);
    }

    public Node_EvaluateThrowPosition(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _InputTName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputTName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputTName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _InputStartPosName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputStartPosName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputStartPosName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _InputEndPosName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputEndPosName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputEndPosName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _InputHeightName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputHeightName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__InputHeightName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _OutputPositionName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__OutputPositionName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__OutputPositionName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _OutputRotationName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__OutputRotationName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_EvaluateThrowPosition.NativeFieldInfoPtr__OutputRotationName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
