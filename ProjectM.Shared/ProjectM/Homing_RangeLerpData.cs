// Decompiled with JetBrains decompiler
// Type: ProjectM.Homing_RangeLerpData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Homing_RangeLerpData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaitDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetHitTriggersOnChangeHomingMode;
    [FieldOffset(0)]
    public CurveReference Curve;
    [FieldOffset(8)]
    public float Range;
    [FieldOffset(12)]
    public float Speed;
    [FieldOffset(16)]
    public float3 StartPosition;
    [FieldOffset(28)]
    public float3 EndPosition;
    [FieldOffset(40)]
    public float WaitDuration;
    [FieldOffset(44)]
    public bool ResetHitTriggersOnChangeHomingMode;

    static Homing_RangeLerpData()
    {
      Il2CppClassPointerStore<Homing_RangeLerpData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Homing_RangeLerpData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Homing_RangeLerpData>.NativeClassPtr);
      Homing_RangeLerpData.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_RangeLerpData>.NativeClassPtr, nameof (Curve));
      Homing_RangeLerpData.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_RangeLerpData>.NativeClassPtr, nameof (Range));
      Homing_RangeLerpData.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_RangeLerpData>.NativeClassPtr, nameof (Speed));
      Homing_RangeLerpData.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_RangeLerpData>.NativeClassPtr, nameof (StartPosition));
      Homing_RangeLerpData.NativeFieldInfoPtr_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_RangeLerpData>.NativeClassPtr, nameof (EndPosition));
      Homing_RangeLerpData.NativeFieldInfoPtr_WaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_RangeLerpData>.NativeClassPtr, nameof (WaitDuration));
      Homing_RangeLerpData.NativeFieldInfoPtr_ResetHitTriggersOnChangeHomingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_RangeLerpData>.NativeClassPtr, nameof (ResetHitTriggersOnChangeHomingMode));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Homing_RangeLerpData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
