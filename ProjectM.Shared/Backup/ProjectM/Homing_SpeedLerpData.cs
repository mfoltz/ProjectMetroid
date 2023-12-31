// Decompiled with JetBrains decompiler
// Type: ProjectM.Homing_SpeedLerpData
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
  public struct Homing_SpeedLerpData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndSpeed;
    [FieldOffset(0)]
    public CurveReference SpeedCurve;
    [FieldOffset(8)]
    public float StartSpeed;
    [FieldOffset(12)]
    public float EndSpeed;

    static Homing_SpeedLerpData()
    {
      Il2CppClassPointerStore<Homing_SpeedLerpData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Homing_SpeedLerpData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Homing_SpeedLerpData>.NativeClassPtr);
      Homing_SpeedLerpData.NativeFieldInfoPtr_SpeedCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_SpeedLerpData>.NativeClassPtr, nameof (SpeedCurve));
      Homing_SpeedLerpData.NativeFieldInfoPtr_StartSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_SpeedLerpData>.NativeClassPtr, nameof (StartSpeed));
      Homing_SpeedLerpData.NativeFieldInfoPtr_EndSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_SpeedLerpData>.NativeClassPtr, nameof (EndSpeed));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Homing_SpeedLerpData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
