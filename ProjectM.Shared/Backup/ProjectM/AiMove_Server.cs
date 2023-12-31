// Decompiled with JetBrains decompiler
// Type: ProjectM.AiMove_Server
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AiMove_Server
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextCircleDirectionChangeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleCurveInRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleCurveOutOfRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalDistanceInner;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalDistanceOuter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleChangeDirectionFrequencyMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleChangeDirectionFrequencyMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargettingMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovePattern;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceLookAtTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_SeekOutwards;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleClockwise;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreezeRotationWhenStationary;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSeekingGoalPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyChangeCircleDirectionOnCast;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCircleDirectionAndDistance_Public_Void_Double_byref_Random_0;
    [FieldOffset(0)]
    public float2 TargetPosition;
    [FieldOffset(8)]
    public double NextCircleDirectionChangeTime;
    [FieldOffset(16)]
    public Entity TargetEntity_Ability;
    [FieldOffset(24)]
    public Entity TargetEntity_Movement;
    [FieldOffset(32)]
    public CurveReference CircleCurveInRange;
    [FieldOffset(40)]
    public CurveReference CircleCurveOutOfRange;
    [FieldOffset(48)]
    public float MinDistance;
    [FieldOffset(52)]
    public float GoalDistanceInner;
    [FieldOffset(56)]
    public float GoalDistanceOuter;
    [FieldOffset(60)]
    public float MaxDistance;
    [FieldOffset(64)]
    public float CircleChangeDirectionFrequencyMin;
    [FieldOffset(68)]
    public float CircleChangeDirectionFrequencyMax;
    [FieldOffset(72)]
    public AiTargettingMode TargettingMode;
    [FieldOffset(73)]
    public AiMovePattern MovePattern;
    [FieldOffset(74)]
    public AiForceLookAtTarget ForceLookAtTarget;
    [FieldOffset(75)]
    public bool SeekOutwards;
    [FieldOffset(76)]
    public bool CircleClockwise;
    [FieldOffset(77)]
    public bool FreezeRotationWhenStationary;
    [FieldOffset(78)]
    public bool IsSeekingGoalPosition;
    [FieldOffset(79)]
    public bool OnlyChangeCircleDirectionOnCast;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 763475, RefRangeEnd = 763479, XrefRangeStart = 763475, XrefRangeEnd = 763475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateCircleDirectionAndDistance(double elapsedTime, ref Unity.Mathematics.Random random)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &elapsedTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMove_Server.NativeMethodInfoPtr_UpdateCircleDirectionAndDistance_Public_Void_Double_byref_Random_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AiMove_Server()
    {
      Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AiMove_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr);
      AiMove_Server.NativeFieldInfoPtr_TargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (TargetPosition));
      AiMove_Server.NativeFieldInfoPtr_NextCircleDirectionChangeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (NextCircleDirectionChangeTime));
      AiMove_Server.NativeFieldInfoPtr_TargetEntity_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (TargetEntity_Ability));
      AiMove_Server.NativeFieldInfoPtr_TargetEntity_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (TargetEntity_Movement));
      AiMove_Server.NativeFieldInfoPtr_CircleCurveInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (CircleCurveInRange));
      AiMove_Server.NativeFieldInfoPtr_CircleCurveOutOfRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (CircleCurveOutOfRange));
      AiMove_Server.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (MinDistance));
      AiMove_Server.NativeFieldInfoPtr_GoalDistanceInner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (GoalDistanceInner));
      AiMove_Server.NativeFieldInfoPtr_GoalDistanceOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (GoalDistanceOuter));
      AiMove_Server.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (MaxDistance));
      AiMove_Server.NativeFieldInfoPtr_CircleChangeDirectionFrequencyMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (CircleChangeDirectionFrequencyMin));
      AiMove_Server.NativeFieldInfoPtr_CircleChangeDirectionFrequencyMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (CircleChangeDirectionFrequencyMax));
      AiMove_Server.NativeFieldInfoPtr_TargettingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (TargettingMode));
      AiMove_Server.NativeFieldInfoPtr_MovePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (MovePattern));
      AiMove_Server.NativeFieldInfoPtr_ForceLookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (ForceLookAtTarget));
      AiMove_Server.NativeFieldInfoPtr_SeekOutwards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (SeekOutwards));
      AiMove_Server.NativeFieldInfoPtr_CircleClockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (CircleClockwise));
      AiMove_Server.NativeFieldInfoPtr_FreezeRotationWhenStationary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (FreezeRotationWhenStationary));
      AiMove_Server.NativeFieldInfoPtr_IsSeekingGoalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (IsSeekingGoalPosition));
      AiMove_Server.NativeFieldInfoPtr_OnlyChangeCircleDirectionOnCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, nameof (OnlyChangeCircleDirectionOnCast));
      AiMove_Server.NativeMethodInfoPtr_UpdateCircleDirectionAndDistance_Public_Void_Double_byref_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, 100667449);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMove_Server>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
