// Decompiled with JetBrains decompiler
// Type: ProjectM.Replays.ReplayCreateSnapshotEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Replays
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReplayCreateSnapshotEvent
  {
    static ReplayCreateSnapshotEvent()
    {
      Il2CppClassPointerStore<ReplayCreateSnapshotEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Replays", nameof (ReplayCreateSnapshotEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayCreateSnapshotEvent>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplayCreateSnapshotEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
