// Decompiled with JetBrains decompiler
// Type: ProjectM.Homing_RotationLerpData
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
  public struct Homing_RotationLerpData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndRotationSpeed;
    [FieldOffset(0)]
    public CurveReference RotationCurve;
    [FieldOffset(8)]
    public float StartRotationSpeed;
    [FieldOffset(12)]
    public float EndRotationSpeed;

    static Homing_RotationLerpData()
    {
      Il2CppClassPointerStore<Homing_RotationLerpData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Homing_RotationLerpData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Homing_RotationLerpData>.NativeClassPtr);
      Homing_RotationLerpData.NativeFieldInfoPtr_RotationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_RotationLerpData>.NativeClassPtr, nameof (RotationCurve));
      Homing_RotationLerpData.NativeFieldInfoPtr_StartRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_RotationLerpData>.NativeClassPtr, nameof (StartRotationSpeed));
      Homing_RotationLerpData.NativeFieldInfoPtr_EndRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_RotationLerpData>.NativeClassPtr, nameof (EndRotationSpeed));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Homing_RotationLerpData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
