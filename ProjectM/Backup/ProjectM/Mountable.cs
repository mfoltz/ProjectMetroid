// Decompiled with JetBrains decompiler
// Type: ProjectM.Mountable
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Mountable
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpeedRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_AccelerationRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeedRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MountBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasNearbyUsers;
    [FieldOffset(0)]
    public float2 MaxSpeedRange;
    [FieldOffset(8)]
    public float2 AccelerationRange;
    [FieldOffset(16)]
    public float2 RotationSpeedRange;
    [FieldOffset(24)]
    public float MaxSpeed;
    [FieldOffset(28)]
    public float Acceleration;
    [FieldOffset(32)]
    public float RotationSpeed;
    [FieldOffset(36)]
    public Entity Mounter;
    [FieldOffset(44)]
    public PrefabGUID MountBuff;
    [FieldOffset(48)]
    public bool HasNearbyUsers;

    static Mountable()
    {
      Il2CppClassPointerStore<Mountable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Mountable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mountable>.NativeClassPtr);
      Mountable.NativeFieldInfoPtr_MaxSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mountable>.NativeClassPtr, nameof (MaxSpeedRange));
      Mountable.NativeFieldInfoPtr_AccelerationRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mountable>.NativeClassPtr, nameof (AccelerationRange));
      Mountable.NativeFieldInfoPtr_RotationSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mountable>.NativeClassPtr, nameof (RotationSpeedRange));
      Mountable.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mountable>.NativeClassPtr, nameof (MaxSpeed));
      Mountable.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mountable>.NativeClassPtr, nameof (Acceleration));
      Mountable.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mountable>.NativeClassPtr, nameof (RotationSpeed));
      Mountable.NativeFieldInfoPtr_Mounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mountable>.NativeClassPtr, nameof (Mounter));
      Mountable.NativeFieldInfoPtr_MountBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mountable>.NativeClassPtr, nameof (MountBuff));
      Mountable.NativeFieldInfoPtr_HasNearbyUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mountable>.NativeClassPtr, nameof (HasNearbyUsers));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mountable>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
