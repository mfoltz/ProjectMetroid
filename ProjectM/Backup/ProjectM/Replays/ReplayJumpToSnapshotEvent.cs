// Decompiled with JetBrains decompiler
// Type: ProjectM.Replays.ReplayJumpToSnapshotEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Replays
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReplayJumpToSnapshotEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_Fraction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot;
    [FieldOffset(0)]
    public Nullable_Unboxed<double> Time;
    [FieldOffset(16)]
    public Nullable_Unboxed<float> Fraction;
    [FieldOffset(24)]
    public Nullable_Unboxed<int> Snapshot;

    static ReplayJumpToSnapshotEvent()
    {
      Il2CppClassPointerStore<ReplayJumpToSnapshotEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Replays", nameof (ReplayJumpToSnapshotEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayJumpToSnapshotEvent>.NativeClassPtr);
      ReplayJumpToSnapshotEvent.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayJumpToSnapshotEvent>.NativeClassPtr, nameof (Time));
      ReplayJumpToSnapshotEvent.NativeFieldInfoPtr_Fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayJumpToSnapshotEvent>.NativeClassPtr, nameof (Fraction));
      ReplayJumpToSnapshotEvent.NativeFieldInfoPtr_Snapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayJumpToSnapshotEvent>.NativeClassPtr, nameof (Snapshot));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplayJumpToSnapshotEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
