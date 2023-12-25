// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.Particle
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation.Trails
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Particle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeCreated;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color;
    private static readonly System.IntPtr NativeFieldInfoPtr_Size;
    [FieldOffset(0)]
    public Vector3 StartPosition;
    [FieldOffset(12)]
    public float TimeCreated;
    [FieldOffset(16)]
    public Vector3 Position;
    [FieldOffset(28)]
    public Quaternion Rotation;
    [FieldOffset(44)]
    public Color32 Color;
    [FieldOffset(48)]
    public float Size;

    static Particle()
    {
      Il2CppClassPointerStore<Particle>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (Particle));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Particle>.NativeClassPtr);
      Particle.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, nameof (StartPosition));
      Particle.NativeFieldInfoPtr_TimeCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, nameof (TimeCreated));
      Particle.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, nameof (Position));
      Particle.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, nameof (Rotation));
      Particle.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, nameof (Color));
      Particle.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, nameof (Size));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Particle>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
