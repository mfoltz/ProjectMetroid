// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Node_BoneFromEntity
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Hybrid;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Sequencer
{
  public class Node_BoneFromEntity : GraphNodeBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__InputName;
    private static readonly IntPtr NativeFieldInfoPtr__OutputPositionName;
    private static readonly IntPtr NativeFieldInfoPtr__OutputRotationName;
    private static readonly IntPtr NativeFieldInfoPtr__RequestIndexName;
    private static readonly IntPtr NativeFieldInfoPtr__Bone;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_HybridBoneEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0;
    private static readonly IntPtr NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_NativeList_1_BoneRequest_NativeList_1_LocalToWorld_ComponentDataFromEntity_1_LocalToWorld_GraphPlaybackType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091343, XrefRangeEnd = 1091348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Node_BoneFromEntity(
      string input,
      string outputPosition,
      string outputRotation,
      string requestIndex,
      HybridBoneEnum bone)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outputPosition);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outputRotation);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(requestIndex);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &bone;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_BoneFromEntity.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_HybridBoneEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_BoneFromEntity.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091348, XrefRangeEnd = 1091364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      BlackboardBuilder blackboardBuilder,
      ref GraphWriter graphWriter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref graphWriter;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Node_BoneFromEntity.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1091387, RefRangeEnd = 1091388, XrefRangeStart = 1091364, XrefRangeEnd = 1091387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Function(
      ref GraphReader graphReader,
      [In] ref Blackboard blackboard,
      NativeList<BoneRequest> boneRequests,
      NativeList<LocalToWorld> boneResults,
      ComponentDataFromEntity<LocalToWorld> getLocalToWorld,
      GraphPlaybackType playbackType)
    {
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = (IntPtr) ref graphReader;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref blackboard;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &boneRequests;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &boneResults;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &getLocalToWorld;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &playbackType;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Node_BoneFromEntity.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_NativeList_1_BoneRequest_NativeList_1_LocalToWorld_ComponentDataFromEntity_1_LocalToWorld_GraphPlaybackType_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Node_BoneFromEntity()
    {
      Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Node_BoneFromEntity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr);
      Node_BoneFromEntity.NativeFieldInfoPtr__InputName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr, nameof (_InputName));
      Node_BoneFromEntity.NativeFieldInfoPtr__OutputPositionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr, nameof (_OutputPositionName));
      Node_BoneFromEntity.NativeFieldInfoPtr__OutputRotationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr, nameof (_OutputRotationName));
      Node_BoneFromEntity.NativeFieldInfoPtr__RequestIndexName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr, nameof (_RequestIndexName));
      Node_BoneFromEntity.NativeFieldInfoPtr__Bone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr, nameof (_Bone));
      Node_BoneFromEntity.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_HybridBoneEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr, 100686038);
      Node_BoneFromEntity.NativeMethodInfoPtr_IsNodeValid_Public_Virtual_Boolean_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr, 100686039);
      Node_BoneFromEntity.NativeMethodInfoPtr_Convert_Public_Virtual_Void_BlackboardBuilder_byref_GraphWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr, 100686040);
      Node_BoneFromEntity.NativeMethodInfoPtr_Function_Public_Static_Void_byref_GraphReader_byref_Blackboard_NativeList_1_BoneRequest_NativeList_1_LocalToWorld_ComponentDataFromEntity_1_LocalToWorld_GraphPlaybackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node_BoneFromEntity>.NativeClassPtr, 100686041);
    }

    public Node_BoneFromEntity(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _InputName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_BoneFromEntity.NativeFieldInfoPtr__InputName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_BoneFromEntity.NativeFieldInfoPtr__InputName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _OutputPositionName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_BoneFromEntity.NativeFieldInfoPtr__OutputPositionName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_BoneFromEntity.NativeFieldInfoPtr__OutputPositionName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _OutputRotationName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_BoneFromEntity.NativeFieldInfoPtr__OutputRotationName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_BoneFromEntity.NativeFieldInfoPtr__OutputRotationName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _RequestIndexName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_BoneFromEntity.NativeFieldInfoPtr__RequestIndexName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Node_BoneFromEntity.NativeFieldInfoPtr__RequestIndexName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe HybridBoneEnum _Bone
    {
      get
      {
        return *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_BoneFromEntity.NativeFieldInfoPtr__Bone));
      }
      [param: In] set
      {
        *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Node_BoneFromEntity.NativeFieldInfoPtr__Bone)) = value;
      }
    }
  }
}
