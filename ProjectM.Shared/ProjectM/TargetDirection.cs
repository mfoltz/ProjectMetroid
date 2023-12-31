// Decompiled with JetBrains decompiler
// Type: ProjectM.TargetDirection
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
  public struct TargetDirection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ForcedDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCanRotate;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerControlsRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileAimType;
    [FieldOffset(0)]
    public ModifiableFloat3 ForcedDirection;
    [FieldOffset(16)]
    public float3 Direction;
    [FieldOffset(28)]
    public float3 AimDirection;
    [FieldOffset(40)]
    public float DefaultRotationSpeed;
    [FieldOffset(44)]
    public float RotationSpeed;
    [FieldOffset(48)]
    public ModifiableBool RotateTowardsMouse;
    [FieldOffset(52)]
    public ModifiableBool ForceRotateTowardsMovement;
    [FieldOffset(56)]
    public bool CurrentCanRotate;
    [FieldOffset(57)]
    public bool PlayerControlsRotation;
    [FieldOffset(58)]
    public AimDirectionType ProjectileAimType;

    static TargetDirection()
    {
      Il2CppClassPointerStore<TargetDirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TargetDirection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr);
      TargetDirection.NativeFieldInfoPtr_ForcedDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, nameof (ForcedDirection));
      TargetDirection.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, nameof (Direction));
      TargetDirection.NativeFieldInfoPtr_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, nameof (AimDirection));
      TargetDirection.NativeFieldInfoPtr_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, nameof (DefaultRotationSpeed));
      TargetDirection.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, nameof (RotationSpeed));
      TargetDirection.NativeFieldInfoPtr_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, nameof (RotateTowardsMouse));
      TargetDirection.NativeFieldInfoPtr_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, nameof (ForceRotateTowardsMovement));
      TargetDirection.NativeFieldInfoPtr_CurrentCanRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, nameof (CurrentCanRotate));
      TargetDirection.NativeFieldInfoPtr_PlayerControlsRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, nameof (PlayerControlsRotation));
      TargetDirection.NativeFieldInfoPtr_ProjectileAimType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, nameof (ProjectileAimType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetDirection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
