// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.ParticleCreationData
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
  public struct ParticleCreationData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeCreated;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    [FieldOffset(0)]
    public float TimeCreated;
    [FieldOffset(4)]
    public Vector3 StartPosition;
    [FieldOffset(16)]
    public Quaternion Rotation;

    static ParticleCreationData()
    {
      Il2CppClassPointerStore<ParticleCreationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (ParticleCreationData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleCreationData>.NativeClassPtr);
      ParticleCreationData.NativeFieldInfoPtr_TimeCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCreationData>.NativeClassPtr, nameof (TimeCreated));
      ParticleCreationData.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCreationData>.NativeClassPtr, nameof (StartPosition));
      ParticleCreationData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCreationData>.NativeClassPtr, nameof (Rotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleCreationData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
