// Decompiled with JetBrains decompiler
// Type: ProjectM.Homing_LerpData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Homing_LerpData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedData;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationData;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapToTargetWhenFound;
    private static readonly System.IntPtr NativeFieldInfoPtr_LockProjectileHeight;
    [FieldOffset(0)]
    public Homing_SpeedLerpData SpeedData;
    [FieldOffset(16)]
    public Homing_RotationLerpData RotationData;
    [FieldOffset(32)]
    public bool SnapToTargetWhenFound;
    [FieldOffset(33)]
    public bool LockProjectileHeight;

    static Homing_LerpData()
    {
      Il2CppClassPointerStore<Homing_LerpData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Homing_LerpData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Homing_LerpData>.NativeClassPtr);
      Homing_LerpData.NativeFieldInfoPtr_SpeedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_LerpData>.NativeClassPtr, nameof (SpeedData));
      Homing_LerpData.NativeFieldInfoPtr_RotationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_LerpData>.NativeClassPtr, nameof (RotationData));
      Homing_LerpData.NativeFieldInfoPtr_SnapToTargetWhenFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_LerpData>.NativeClassPtr, nameof (SnapToTargetWhenFound));
      Homing_LerpData.NativeFieldInfoPtr_LockProjectileHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_LerpData>.NativeClassPtr, nameof (LockProjectileHeight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Homing_LerpData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
