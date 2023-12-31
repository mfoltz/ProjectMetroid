// Decompiled with JetBrains decompiler
// Type: ProjectM.PathWaypointNodeWait
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PathWaypointNodeWait
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WaitTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaitRotation;
    [FieldOffset(0)]
    public float WaitTime;
    [FieldOffset(4)]
    public Nullable_Unboxed<quaternion> WaitRotation;

    static PathWaypointNodeWait()
    {
      Il2CppClassPointerStore<PathWaypointNodeWait>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PathWaypointNodeWait));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathWaypointNodeWait>.NativeClassPtr);
      PathWaypointNodeWait.NativeFieldInfoPtr_WaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathWaypointNodeWait>.NativeClassPtr, nameof (WaitTime));
      PathWaypointNodeWait.NativeFieldInfoPtr_WaitRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathWaypointNodeWait>.NativeClassPtr, nameof (WaitRotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PathWaypointNodeWait>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
