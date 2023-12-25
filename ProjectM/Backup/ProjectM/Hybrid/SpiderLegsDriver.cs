// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.SpiderLegsDriver
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpiderLegsDriver
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LegDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyTiltDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyProxyPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyBobVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyBobPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultAreaRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyBobHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyBobStrenght;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyBobDampening;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepHeightCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepSpeedCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayFootstepAudio;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasLegMoving;
    [FieldOffset(0)]
    public float3 LegDirection;
    [FieldOffset(12)]
    public float3 BodyTiltDirection;
    [FieldOffset(24)]
    public float3 BodyProxyPosition;
    [FieldOffset(36)]
    public float3 BodyBobVelocity;
    [FieldOffset(48)]
    public float3 BodyBobPosition;
    [FieldOffset(60)]
    public float StepHeight;
    [FieldOffset(64)]
    public float StepSpeed;
    [FieldOffset(68)]
    public float SuspensionSpeed;
    [FieldOffset(72)]
    public float DefaultAreaRadius;
    [FieldOffset(76)]
    public float BodyBobHeight;
    [FieldOffset(80)]
    public float BodyBobStrenght;
    [FieldOffset(84)]
    public float BodyBobDampening;
    [FieldOffset(88)]
    public CurveReference StepHeightCurve;
    [FieldOffset(96)]
    public CurveReference StepSpeedCurve;
    [FieldOffset(104)]
    public CurveReference SuspensionCurve;
    [FieldOffset(112)]
    public bool PlayFootstepAudio;
    [FieldOffset(113)]
    public bool HasLegMoving;

    static SpiderLegsDriver()
    {
      Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (SpiderLegsDriver));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr);
      SpiderLegsDriver.NativeFieldInfoPtr_LegDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (LegDirection));
      SpiderLegsDriver.NativeFieldInfoPtr_BodyTiltDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (BodyTiltDirection));
      SpiderLegsDriver.NativeFieldInfoPtr_BodyProxyPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (BodyProxyPosition));
      SpiderLegsDriver.NativeFieldInfoPtr_BodyBobVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (BodyBobVelocity));
      SpiderLegsDriver.NativeFieldInfoPtr_BodyBobPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (BodyBobPosition));
      SpiderLegsDriver.NativeFieldInfoPtr_StepHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (StepHeight));
      SpiderLegsDriver.NativeFieldInfoPtr_StepSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (StepSpeed));
      SpiderLegsDriver.NativeFieldInfoPtr_SuspensionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (SuspensionSpeed));
      SpiderLegsDriver.NativeFieldInfoPtr_DefaultAreaRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (DefaultAreaRadius));
      SpiderLegsDriver.NativeFieldInfoPtr_BodyBobHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (BodyBobHeight));
      SpiderLegsDriver.NativeFieldInfoPtr_BodyBobStrenght = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (BodyBobStrenght));
      SpiderLegsDriver.NativeFieldInfoPtr_BodyBobDampening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (BodyBobDampening));
      SpiderLegsDriver.NativeFieldInfoPtr_StepHeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (StepHeightCurve));
      SpiderLegsDriver.NativeFieldInfoPtr_StepSpeedCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (StepSpeedCurve));
      SpiderLegsDriver.NativeFieldInfoPtr_SuspensionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (SuspensionCurve));
      SpiderLegsDriver.NativeFieldInfoPtr_PlayFootstepAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (PlayFootstepAudio));
      SpiderLegsDriver.NativeFieldInfoPtr_HasLegMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, nameof (HasLegMoving));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpiderLegsDriver>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
