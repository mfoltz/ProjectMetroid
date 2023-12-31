// Decompiled with JetBrains decompiler
// Type: ProjectM.MovePatrolState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MovePatrolState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaypointProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmoothPointDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaitTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaitDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaitRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_Flip;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalReached;
    [FieldOffset(0)]
    public float3 FromPosition;
    [FieldOffset(12)]
    public float3 ToPosition;
    [FieldOffset(24)]
    public float3 TargetPosition;
    [FieldOffset(36)]
    public float WaypointProgress;
    [FieldOffset(40)]
    public PatrolType Type;
    [FieldOffset(44)]
    public float Speed;
    [FieldOffset(48)]
    public float RotationSpeed;
    [FieldOffset(52)]
    public float SmoothPointDistance;
    [FieldOffset(56)]
    public float WaitTime;
    [FieldOffset(60)]
    public float WaitDuration;
    [FieldOffset(64)]
    public Nullable_Unboxed<quaternion> WaitRotation;
    [FieldOffset(84)]
    public PatrolStatus Status;
    [FieldOffset(88)]
    public bool Flip;
    [FieldOffset(89)]
    public bool GoalReached;

    static MovePatrolState()
    {
      Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MovePatrolState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr);
      MovePatrolState.NativeFieldInfoPtr_FromPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (FromPosition));
      MovePatrolState.NativeFieldInfoPtr_ToPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (ToPosition));
      MovePatrolState.NativeFieldInfoPtr_TargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (TargetPosition));
      MovePatrolState.NativeFieldInfoPtr_WaypointProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (WaypointProgress));
      MovePatrolState.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (Type));
      MovePatrolState.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (Speed));
      MovePatrolState.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (RotationSpeed));
      MovePatrolState.NativeFieldInfoPtr_SmoothPointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (SmoothPointDistance));
      MovePatrolState.NativeFieldInfoPtr_WaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (WaitTime));
      MovePatrolState.NativeFieldInfoPtr_WaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (WaitDuration));
      MovePatrolState.NativeFieldInfoPtr_WaitRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (WaitRotation));
      MovePatrolState.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (Status));
      MovePatrolState.NativeFieldInfoPtr_Flip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (Flip));
      MovePatrolState.NativeFieldInfoPtr_GoalReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, nameof (GoalReached));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MovePatrolState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
