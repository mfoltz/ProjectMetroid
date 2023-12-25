// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.FootstepEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FootstepEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SurfaceID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    [FieldOffset(0)]
    public float3 Position;
    [FieldOffset(12)]
    public Nullable_Unboxed<float> MaxDistance;
    [FieldOffset(20)]
    public Entity Entity;
    [FieldOffset(28)]
    public int SurfaceID;
    [FieldOffset(32)]
    public int Index;

    static FootstepEvent()
    {
      Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (FootstepEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr);
      FootstepEvent.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr, nameof (Position));
      FootstepEvent.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr, nameof (MaxDistance));
      FootstepEvent.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr, nameof (Entity));
      FootstepEvent.NativeFieldInfoPtr_SurfaceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr, nameof (SurfaceID));
      FootstepEvent.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr, nameof (Index));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
