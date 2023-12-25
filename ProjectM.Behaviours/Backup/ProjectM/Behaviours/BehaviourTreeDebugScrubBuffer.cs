// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeDebugScrubBuffer
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeDebugScrubBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExecutedNodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExecutionResult;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardSnapshotStartIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUsed_Public_get_Boolean_0;
    [FieldOffset(0)]
    public BehaviourSnapshotType SnapshotType;
    [FieldOffset(4)]
    public int SnapshotId;
    [FieldOffset(8)]
    public int ServerFrame;
    [FieldOffset(12)]
    public ushort ExecutedNodeIndex;
    [FieldOffset(16)]
    public Nullable_Unboxed<BehaviourTreeResult> ExecutionResult;
    [FieldOffset(24)]
    public int BlackboardSnapshotStartIndex;

    public unsafe bool IsUsed
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 548028, RefRangeEnd = 548035, XrefRangeStart = 548028, XrefRangeEnd = 548035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeDebugScrubBuffer.NativeMethodInfoPtr_get_IsUsed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static BehaviourTreeDebugScrubBuffer()
    {
      Il2CppClassPointerStore<BehaviourTreeDebugScrubBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeDebugScrubBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeDebugScrubBuffer>.NativeClassPtr);
      BehaviourTreeDebugScrubBuffer.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugScrubBuffer>.NativeClassPtr, nameof (SnapshotType));
      BehaviourTreeDebugScrubBuffer.NativeFieldInfoPtr_SnapshotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugScrubBuffer>.NativeClassPtr, nameof (SnapshotId));
      BehaviourTreeDebugScrubBuffer.NativeFieldInfoPtr_ServerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugScrubBuffer>.NativeClassPtr, nameof (ServerFrame));
      BehaviourTreeDebugScrubBuffer.NativeFieldInfoPtr_ExecutedNodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugScrubBuffer>.NativeClassPtr, nameof (ExecutedNodeIndex));
      BehaviourTreeDebugScrubBuffer.NativeFieldInfoPtr_ExecutionResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugScrubBuffer>.NativeClassPtr, nameof (ExecutionResult));
      BehaviourTreeDebugScrubBuffer.NativeFieldInfoPtr_BlackboardSnapshotStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugScrubBuffer>.NativeClassPtr, nameof (BlackboardSnapshotStartIndex));
      BehaviourTreeDebugScrubBuffer.NativeMethodInfoPtr_get_IsUsed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeDebugScrubBuffer>.NativeClassPtr, 100665277);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeDebugScrubBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
