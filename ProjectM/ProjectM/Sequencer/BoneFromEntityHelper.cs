// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.BoneFromEntityHelper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Hybrid;
using Stunlock.Sequencer;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Sequencer
{
  public static class BoneFromEntityHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Function_Public_Static_Void_Blackboard_NativeList_1_BoneRequest_NativeList_1_LocalToWorld_ComponentDataFromEntity_1_LocalToWorld_Entity_HybridBoneEnum_Int32_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Int32_GraphPlaybackType_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1091495, RefRangeEnd = 1091497, XrefRangeStart = 1091438, XrefRangeEnd = 1091495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Function(
      Blackboard blackboard,
      NativeList<BoneRequest> boneRequests,
      NativeList<LocalToWorld> boneResults,
      ComponentDataFromEntity<LocalToWorld> getLocalToWorld,
      Entity entity,
      HybridBoneEnum bone,
      int requestParameterIndex,
      Nullable_Unboxed<int> outputPositionIndex,
      Nullable_Unboxed<int> outputRotationIndex,
      GraphPlaybackType playbackType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &blackboard;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &boneRequests;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &boneResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getLocalToWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &bone;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &requestParameterIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &outputPositionIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &outputRotationIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &playbackType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BoneFromEntityHelper.NativeMethodInfoPtr_Function_Public_Static_Void_Blackboard_NativeList_1_BoneRequest_NativeList_1_LocalToWorld_ComponentDataFromEntity_1_LocalToWorld_Entity_HybridBoneEnum_Int32_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Int32_GraphPlaybackType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BoneFromEntityHelper()
    {
      Il2CppClassPointerStore<BoneFromEntityHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (BoneFromEntityHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneFromEntityHelper>.NativeClassPtr);
      BoneFromEntityHelper.NativeMethodInfoPtr_Function_Public_Static_Void_Blackboard_NativeList_1_BoneRequest_NativeList_1_LocalToWorld_ComponentDataFromEntity_1_LocalToWorld_Entity_HybridBoneEnum_Int32_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Int32_GraphPlaybackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneFromEntityHelper>.NativeClassPtr, 100686046);
    }

    public BoneFromEntityHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
