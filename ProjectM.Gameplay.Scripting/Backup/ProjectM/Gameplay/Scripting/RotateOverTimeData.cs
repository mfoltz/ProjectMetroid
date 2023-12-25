// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.RotateOverTimeData
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RotateOverTimeData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomDuration;
    [FieldOffset(0)]
    public quaternion InitialRotation;
    [FieldOffset(16)]
    public float RotationAngle;
    [FieldOffset(20)]
    public float CustomDuration;
    [FieldOffset(24)]
    public RotationTarget RotationTarget;
    [FieldOffset(28)]
    public RotationType RotationType;
    [FieldOffset(32)]
    public CurveReference RotationCurve;
    [FieldOffset(40)]
    public bool UseCustomDuration;

    static RotateOverTimeData()
    {
      Il2CppClassPointerStore<RotateOverTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (RotateOverTimeData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateOverTimeData>.NativeClassPtr);
      RotateOverTimeData.NativeFieldInfoPtr_InitialRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateOverTimeData>.NativeClassPtr, nameof (InitialRotation));
      RotateOverTimeData.NativeFieldInfoPtr_RotationAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateOverTimeData>.NativeClassPtr, nameof (RotationAngle));
      RotateOverTimeData.NativeFieldInfoPtr_CustomDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateOverTimeData>.NativeClassPtr, nameof (CustomDuration));
      RotateOverTimeData.NativeFieldInfoPtr_RotationTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateOverTimeData>.NativeClassPtr, nameof (RotationTarget));
      RotateOverTimeData.NativeFieldInfoPtr_RotationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateOverTimeData>.NativeClassPtr, nameof (RotationType));
      RotateOverTimeData.NativeFieldInfoPtr_RotationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateOverTimeData>.NativeClassPtr, nameof (RotationCurve));
      RotateOverTimeData.NativeFieldInfoPtr_UseCustomDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateOverTimeData>.NativeClassPtr, nameof (UseCustomDuration));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RotateOverTimeData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
