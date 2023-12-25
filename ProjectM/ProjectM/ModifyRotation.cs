// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyRotation
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifyRotation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousTargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveTimeline;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirectionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseZeroAsDefaultForCurveRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapToDirection;
    [FieldOffset(0)]
    public Nullable_Unboxed<Vector3> PreviousTargetDirection;
    [FieldOffset(16)]
    public Nullable_Unboxed<Vector3> OffsetRotation;
    [FieldOffset(32)]
    public MinMaxValue ActiveTimeline;
    [FieldOffset(40)]
    public float Value;
    [FieldOffset(44)]
    public CurveReference Curve;
    [FieldOffset(52)]
    public RotationModificationType Type;
    [FieldOffset(56)]
    public TargetDirectionType TargetDirectionType;
    [FieldOffset(60)]
    public bool UseZeroAsDefaultForCurveRotation;
    [FieldOffset(61)]
    public bool SnapToDirection;

    static ModifyRotation()
    {
      Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyRotation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr);
      ModifyRotation.NativeFieldInfoPtr_PreviousTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr, nameof (PreviousTargetDirection));
      ModifyRotation.NativeFieldInfoPtr_OffsetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr, nameof (OffsetRotation));
      ModifyRotation.NativeFieldInfoPtr_ActiveTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr, nameof (ActiveTimeline));
      ModifyRotation.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr, nameof (Value));
      ModifyRotation.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr, nameof (Curve));
      ModifyRotation.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr, nameof (Type));
      ModifyRotation.NativeFieldInfoPtr_TargetDirectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr, nameof (TargetDirectionType));
      ModifyRotation.NativeFieldInfoPtr_UseZeroAsDefaultForCurveRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr, nameof (UseZeroAsDefaultForCurveRotation));
      ModifyRotation.NativeFieldInfoPtr_SnapToDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr, nameof (SnapToDirection));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyRotation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
