// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeDebugScrubData
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeDebugScrubData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotIdTracker;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardSize;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnapshotIndexForId_Public_Int32_Int32_0;
    [FieldOffset(0)]
    public int SnapshotIdTracker;
    [FieldOffset(4)]
    public int SnapshotCount;
    [FieldOffset(8)]
    public int BlackboardSize;

    [CallerCount(0)]
    public unsafe int GetSnapshotIndexForId(int snapshotId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &snapshotId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeDebugScrubData.NativeMethodInfoPtr_GetSnapshotIndexForId_Public_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BehaviourTreeDebugScrubData()
    {
      Il2CppClassPointerStore<BehaviourTreeDebugScrubData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeDebugScrubData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeDebugScrubData>.NativeClassPtr);
      BehaviourTreeDebugScrubData.NativeFieldInfoPtr_SnapshotIdTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugScrubData>.NativeClassPtr, nameof (SnapshotIdTracker));
      BehaviourTreeDebugScrubData.NativeFieldInfoPtr_SnapshotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugScrubData>.NativeClassPtr, nameof (SnapshotCount));
      BehaviourTreeDebugScrubData.NativeFieldInfoPtr_BlackboardSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugScrubData>.NativeClassPtr, nameof (BlackboardSize));
      BehaviourTreeDebugScrubData.NativeMethodInfoPtr_GetSnapshotIndexForId_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeDebugScrubData>.NativeClassPtr, 100665276);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeDebugScrubData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
