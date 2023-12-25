// Decompiled with JetBrains decompiler
// Type: ProjectM.TravelToTarget
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TravelToTarget
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndPositionTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetStartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetType;
    private static readonly System.IntPtr NativeFieldInfoPtr_YOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelSpeedBasedOnDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinimumDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FetchLocationFirstFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseVisualOffset;
    [FieldOffset(0)]
    public quaternion StartRotation;
    [FieldOffset(16)]
    public quaternion TargetRotation;
    [FieldOffset(32)]
    public Nullable_Unboxed<float3> StartPosition;
    [FieldOffset(48)]
    public float3 EndPositionTarget;
    [FieldOffset(60)]
    public float3 Offset;
    [FieldOffset(72)]
    public float3 TargetStartPosition;
    [FieldOffset(84)]
    public CurveReference Curve;
    [FieldOffset(92)]
    public NetworkedEntity Target;
    [FieldOffset(104)]
    public TravelToTargetOffsetType OffsetType;
    [FieldOffset(108)]
    public float YOffset;
    [FieldOffset(112)]
    public float TravelSpeedBasedOnDistance;
    [FieldOffset(116)]
    public float MinimumDuration;
    [FieldOffset(120)]
    public float BuffLifetime;
    [FieldOffset(124)]
    public bool FetchLocationFirstFrame;
    [FieldOffset(125)]
    public bool UseVisualOffset;

    static TravelToTarget()
    {
      Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TravelToTarget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr);
      TravelToTarget.NativeFieldInfoPtr_StartRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (StartRotation));
      TravelToTarget.NativeFieldInfoPtr_TargetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (TargetRotation));
      TravelToTarget.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (StartPosition));
      TravelToTarget.NativeFieldInfoPtr_EndPositionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (EndPositionTarget));
      TravelToTarget.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (Offset));
      TravelToTarget.NativeFieldInfoPtr_TargetStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (TargetStartPosition));
      TravelToTarget.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (Curve));
      TravelToTarget.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (Target));
      TravelToTarget.NativeFieldInfoPtr_OffsetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (OffsetType));
      TravelToTarget.NativeFieldInfoPtr_YOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (YOffset));
      TravelToTarget.NativeFieldInfoPtr_TravelSpeedBasedOnDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (TravelSpeedBasedOnDistance));
      TravelToTarget.NativeFieldInfoPtr_MinimumDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (MinimumDuration));
      TravelToTarget.NativeFieldInfoPtr_BuffLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (BuffLifetime));
      TravelToTarget.NativeFieldInfoPtr_FetchLocationFirstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (FetchLocationFirstFrame));
      TravelToTarget.NativeFieldInfoPtr_UseVisualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, nameof (UseVisualOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelToTarget>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
