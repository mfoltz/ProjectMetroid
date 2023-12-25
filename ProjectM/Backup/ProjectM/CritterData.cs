// Decompiled with JetBrains decompiler
// Type: ProjectM.CritterData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CritterData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EscapePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_EscapeSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SteppedOnSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Lifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_EscapeSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_IdleAnimationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnAggroAnimationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_EscapeAnimationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnAggroDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_TurnToEscapeDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditiveTurnFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentAggroTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentAliveTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentUpAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_SteppedOnSequenceDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepCollisionSphereRadiusSq;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanBeSteppedOn;
    private static readonly System.IntPtr NativeFieldInfoPtr_EscapesByFlying;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsTame;
    [FieldOffset(0)]
    public float3 EscapePosition;
    [FieldOffset(12)]
    public SequenceGUID EscapeSequenceGuid;
    [FieldOffset(16)]
    public SequenceGUID SteppedOnSequenceGuid;
    [FieldOffset(20)]
    public float Lifetime;
    [FieldOffset(24)]
    public float EscapeSpeed;
    [FieldOffset(28)]
    public float RotationSpeed;
    [FieldOffset(32)]
    public float IdleAnimationSpeed;
    [FieldOffset(36)]
    public float OnAggroAnimationSpeed;
    [FieldOffset(40)]
    public float EscapeAnimationSpeed;
    [FieldOffset(44)]
    public float OnAggroDuration;
    [FieldOffset(48)]
    public float TurnToEscapeDuration;
    [FieldOffset(52)]
    public float AdditiveTurnFactor;
    [FieldOffset(56)]
    public float FadeOutTime;
    [FieldOffset(60)]
    public float CurrentAggroTime;
    [FieldOffset(64)]
    public float CurrentAliveTime;
    [FieldOffset(68)]
    public float CurrentUpAngle;
    [FieldOffset(72)]
    public float SteppedOnSequenceDuration;
    [FieldOffset(76)]
    public float StepCollisionSphereRadiusSq;
    [FieldOffset(80)]
    public CritterState State;
    [FieldOffset(84)]
    public bool CanBeSteppedOn;
    [FieldOffset(85)]
    public bool EscapesByFlying;
    [FieldOffset(86)]
    public bool IsTame;

    static CritterData()
    {
      Il2CppClassPointerStore<CritterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CritterData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterData>.NativeClassPtr);
      CritterData.NativeFieldInfoPtr_EscapePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (EscapePosition));
      CritterData.NativeFieldInfoPtr_EscapeSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (EscapeSequenceGuid));
      CritterData.NativeFieldInfoPtr_SteppedOnSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (SteppedOnSequenceGuid));
      CritterData.NativeFieldInfoPtr_Lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (Lifetime));
      CritterData.NativeFieldInfoPtr_EscapeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (EscapeSpeed));
      CritterData.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (RotationSpeed));
      CritterData.NativeFieldInfoPtr_IdleAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (IdleAnimationSpeed));
      CritterData.NativeFieldInfoPtr_OnAggroAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (OnAggroAnimationSpeed));
      CritterData.NativeFieldInfoPtr_EscapeAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (EscapeAnimationSpeed));
      CritterData.NativeFieldInfoPtr_OnAggroDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (OnAggroDuration));
      CritterData.NativeFieldInfoPtr_TurnToEscapeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (TurnToEscapeDuration));
      CritterData.NativeFieldInfoPtr_AdditiveTurnFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (AdditiveTurnFactor));
      CritterData.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (FadeOutTime));
      CritterData.NativeFieldInfoPtr_CurrentAggroTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (CurrentAggroTime));
      CritterData.NativeFieldInfoPtr_CurrentAliveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (CurrentAliveTime));
      CritterData.NativeFieldInfoPtr_CurrentUpAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (CurrentUpAngle));
      CritterData.NativeFieldInfoPtr_SteppedOnSequenceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (SteppedOnSequenceDuration));
      CritterData.NativeFieldInfoPtr_StepCollisionSphereRadiusSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (StepCollisionSphereRadiusSq));
      CritterData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (State));
      CritterData.NativeFieldInfoPtr_CanBeSteppedOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (CanBeSteppedOn));
      CritterData.NativeFieldInfoPtr_EscapesByFlying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (EscapesByFlying));
      CritterData.NativeFieldInfoPtr_IsTame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterData>.NativeClassPtr, nameof (IsTame));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
