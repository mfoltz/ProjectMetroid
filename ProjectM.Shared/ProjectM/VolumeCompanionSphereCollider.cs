// Decompiled with JetBrains decompiler
// Type: ProjectM.VolumeCompanionSphereCollider
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VolumeCompanionSphereCollider
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Center;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    [FieldOffset(0)]
    public float3 Center;
    [FieldOffset(12)]
    public float Radius;

    static VolumeCompanionSphereCollider()
    {
      Il2CppClassPointerStore<VolumeCompanionSphereCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (VolumeCompanionSphereCollider));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeCompanionSphereCollider>.NativeClassPtr);
      VolumeCompanionSphereCollider.NativeFieldInfoPtr_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeCompanionSphereCollider>.NativeClassPtr, nameof (Center));
      VolumeCompanionSphereCollider.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeCompanionSphereCollider>.NativeClassPtr, nameof (Radius));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumeCompanionSphereCollider>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
