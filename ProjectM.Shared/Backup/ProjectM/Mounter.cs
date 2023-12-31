// Decompiled with JetBrains decompiler
// Type: ProjectM.Mounter
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Mounter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MountEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsGalopping;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanDestroyOnCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Deceleration;
    private static readonly System.IntPtr NativeFieldInfoPtr_WalkMaxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_GallopMaxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpeedReverse;
    private static readonly System.IntPtr NativeFieldInfoPtr_DegallopSpeedThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyOnCollisionSpeedThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_TurnRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAimAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_JumpFromCliffsMaxDot;
    private static readonly System.IntPtr NativeFieldInfoPtr_JumpFromCliffsMinVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_TurnRatePerSpeedCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrictionCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_GallopMaxSpeedMultiplier;
    [FieldOffset(0)]
    public Entity MountEntity;
    [FieldOffset(8)]
    public bool IsGalopping;
    [FieldOffset(9)]
    public bool CanDestroyOnCollision;
    [FieldOffset(12)]
    public ModifiableFloat Acceleration;
    [FieldOffset(20)]
    public float Deceleration;
    [FieldOffset(24)]
    public float WalkMaxSpeed;
    [FieldOffset(28)]
    public ModifiableFloat GallopMaxSpeed;
    [FieldOffset(36)]
    public float MaxSpeedReverse;
    [FieldOffset(40)]
    public float DegallopSpeedThreshold;
    [FieldOffset(44)]
    public float DestroyOnCollisionSpeedThreshold;
    [FieldOffset(48)]
    public ModifiableFloat TurnRate;
    [FieldOffset(56)]
    public float MaxAimAngle;
    [FieldOffset(60)]
    public float JumpFromCliffsMaxDot;
    [FieldOffset(64)]
    public float JumpFromCliffsMinVelocity;
    [FieldOffset(68)]
    public CurveReference TurnRatePerSpeedCurve;
    [FieldOffset(76)]
    public CurveReference FrictionCurve;
    [FieldOffset(84)]
    public ModifiableFloat GallopMaxSpeedMultiplier;

    static Mounter()
    {
      Il2CppClassPointerStore<Mounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Mounter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mounter>.NativeClassPtr);
      Mounter.NativeFieldInfoPtr_MountEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (MountEntity));
      Mounter.NativeFieldInfoPtr_IsGalopping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (IsGalopping));
      Mounter.NativeFieldInfoPtr_CanDestroyOnCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (CanDestroyOnCollision));
      Mounter.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (Acceleration));
      Mounter.NativeFieldInfoPtr_Deceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (Deceleration));
      Mounter.NativeFieldInfoPtr_WalkMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (WalkMaxSpeed));
      Mounter.NativeFieldInfoPtr_GallopMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (GallopMaxSpeed));
      Mounter.NativeFieldInfoPtr_MaxSpeedReverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (MaxSpeedReverse));
      Mounter.NativeFieldInfoPtr_DegallopSpeedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (DegallopSpeedThreshold));
      Mounter.NativeFieldInfoPtr_DestroyOnCollisionSpeedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (DestroyOnCollisionSpeedThreshold));
      Mounter.NativeFieldInfoPtr_TurnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (TurnRate));
      Mounter.NativeFieldInfoPtr_MaxAimAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (MaxAimAngle));
      Mounter.NativeFieldInfoPtr_JumpFromCliffsMaxDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (JumpFromCliffsMaxDot));
      Mounter.NativeFieldInfoPtr_JumpFromCliffsMinVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (JumpFromCliffsMinVelocity));
      Mounter.NativeFieldInfoPtr_TurnRatePerSpeedCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (TurnRatePerSpeedCurve));
      Mounter.NativeFieldInfoPtr_FrictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (FrictionCurve));
      Mounter.NativeFieldInfoPtr_GallopMaxSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mounter>.NativeClassPtr, nameof (GallopMaxSpeedMultiplier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mounter>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
