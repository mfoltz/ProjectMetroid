// Decompiled with JetBrains decompiler
// Type: ProjectM.TopdownCamera
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TopdownCamera
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LookAtHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_LerpEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_LerpMousePan;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeedYaw_MinSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeedYaw_MaxSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeedPitch_MinSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeedPitch_MaxSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerRotationSpeedYaw_MinSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerRotationSpeedYaw_MaxSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerRotationSpeedPitch_MinSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerRotationSpeedPitch_MaxSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoomSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_CameraSensitivityCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotateBehaviour;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseAffectionCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxMouseOffsetDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalFloatiness;
    private static readonly System.IntPtr NativeFieldInfoPtr_LerpLambdas;
    private static readonly System.IntPtr NativeFieldInfoPtr_StandardZoomSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_StandardZoomDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildModeZoomSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildZoomEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildModeZoomDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_PitchStartZoomFraction;
    [FieldOffset(0)]
    public float LookAtHeight;
    [FieldOffset(4)]
    public bool LerpEnabled;
    [FieldOffset(5)]
    public bool LerpMousePan;
    [FieldOffset(8)]
    public float RotationSpeedYaw_MinSensitivity;
    [FieldOffset(12)]
    public float RotationSpeedYaw_MaxSensitivity;
    [FieldOffset(16)]
    public float RotationSpeedPitch_MinSensitivity;
    [FieldOffset(20)]
    public float RotationSpeedPitch_MaxSensitivity;
    [FieldOffset(24)]
    public float ControllerRotationSpeedYaw_MinSensitivity;
    [FieldOffset(28)]
    public float ControllerRotationSpeedYaw_MaxSensitivity;
    [FieldOffset(32)]
    public float ControllerRotationSpeedPitch_MinSensitivity;
    [FieldOffset(36)]
    public float ControllerRotationSpeedPitch_MaxSensitivity;
    [FieldOffset(40)]
    public float ZoomSpeed;
    [FieldOffset(44)]
    public CurveData CameraSensitivityCurve;
    [FieldOffset(1064)]
    public MousePanRotateBehaviour RotateBehaviour;
    [FieldOffset(1068)]
    public CurveData MouseAffectionCurve;
    [FieldOffset(2088)]
    public float MaxMouseOffsetDistance;
    [FieldOffset(2092)]
    public float HorizontalFloatiness;
    [FieldOffset(2096)]
    public TopdownCamera.LerpLambdaVars LerpLambdas;
    [FieldOffset(2112)]
    public ZoomSettings StandardZoomSettings;
    [FieldOffset(2128)]
    public float StandardZoomDistance;
    [FieldOffset(2132)]
    public ZoomSettings BuildModeZoomSettings;
    [FieldOffset(2148)]
    public bool BuildZoomEnabled;
    [FieldOffset(2152)]
    public float BuildModeZoomDistance;
    [FieldOffset(2156)]
    public float PitchStartZoomFraction;

    static TopdownCamera()
    {
      Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TopdownCamera));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr);
      TopdownCamera.NativeFieldInfoPtr_LookAtHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (LookAtHeight));
      TopdownCamera.NativeFieldInfoPtr_LerpEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (LerpEnabled));
      TopdownCamera.NativeFieldInfoPtr_LerpMousePan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (LerpMousePan));
      TopdownCamera.NativeFieldInfoPtr_RotationSpeedYaw_MinSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (RotationSpeedYaw_MinSensitivity));
      TopdownCamera.NativeFieldInfoPtr_RotationSpeedYaw_MaxSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (RotationSpeedYaw_MaxSensitivity));
      TopdownCamera.NativeFieldInfoPtr_RotationSpeedPitch_MinSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (RotationSpeedPitch_MinSensitivity));
      TopdownCamera.NativeFieldInfoPtr_RotationSpeedPitch_MaxSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (RotationSpeedPitch_MaxSensitivity));
      TopdownCamera.NativeFieldInfoPtr_ControllerRotationSpeedYaw_MinSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (ControllerRotationSpeedYaw_MinSensitivity));
      TopdownCamera.NativeFieldInfoPtr_ControllerRotationSpeedYaw_MaxSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (ControllerRotationSpeedYaw_MaxSensitivity));
      TopdownCamera.NativeFieldInfoPtr_ControllerRotationSpeedPitch_MinSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (ControllerRotationSpeedPitch_MinSensitivity));
      TopdownCamera.NativeFieldInfoPtr_ControllerRotationSpeedPitch_MaxSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (ControllerRotationSpeedPitch_MaxSensitivity));
      TopdownCamera.NativeFieldInfoPtr_ZoomSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (ZoomSpeed));
      TopdownCamera.NativeFieldInfoPtr_CameraSensitivityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (CameraSensitivityCurve));
      TopdownCamera.NativeFieldInfoPtr_RotateBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (RotateBehaviour));
      TopdownCamera.NativeFieldInfoPtr_MouseAffectionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (MouseAffectionCurve));
      TopdownCamera.NativeFieldInfoPtr_MaxMouseOffsetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (MaxMouseOffsetDistance));
      TopdownCamera.NativeFieldInfoPtr_HorizontalFloatiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (HorizontalFloatiness));
      TopdownCamera.NativeFieldInfoPtr_LerpLambdas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (LerpLambdas));
      TopdownCamera.NativeFieldInfoPtr_StandardZoomSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (StandardZoomSettings));
      TopdownCamera.NativeFieldInfoPtr_StandardZoomDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (StandardZoomDistance));
      TopdownCamera.NativeFieldInfoPtr_BuildModeZoomSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (BuildModeZoomSettings));
      TopdownCamera.NativeFieldInfoPtr_BuildZoomEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (BuildZoomEnabled));
      TopdownCamera.NativeFieldInfoPtr_BuildModeZoomDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (BuildModeZoomDistance));
      TopdownCamera.NativeFieldInfoPtr_PitchStartZoomFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (PitchStartZoomFraction));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LerpLambdaVars
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_LookAtPosLambda;
      private static readonly System.IntPtr NativeFieldInfoPtr_MousePanLambda;
      private static readonly System.IntPtr NativeFieldInfoPtr_ZoomLambda;
      private static readonly System.IntPtr NativeFieldInfoPtr_PitchLambda;
      [FieldOffset(0)]
      public float LookAtPosLambda;
      [FieldOffset(4)]
      public float MousePanLambda;
      [FieldOffset(8)]
      public float ZoomLambda;
      [FieldOffset(12)]
      public float PitchLambda;

      static LerpLambdaVars()
      {
        Il2CppClassPointerStore<TopdownCamera.LerpLambdaVars>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TopdownCamera>.NativeClassPtr, nameof (LerpLambdaVars));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TopdownCamera.LerpLambdaVars>.NativeClassPtr);
        TopdownCamera.LerpLambdaVars.NativeFieldInfoPtr_LookAtPosLambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera.LerpLambdaVars>.NativeClassPtr, nameof (LookAtPosLambda));
        TopdownCamera.LerpLambdaVars.NativeFieldInfoPtr_MousePanLambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera.LerpLambdaVars>.NativeClassPtr, nameof (MousePanLambda));
        TopdownCamera.LerpLambdaVars.NativeFieldInfoPtr_ZoomLambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera.LerpLambdaVars>.NativeClassPtr, nameof (ZoomLambda));
        TopdownCamera.LerpLambdaVars.NativeFieldInfoPtr_PitchLambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCamera.LerpLambdaVars>.NativeClassPtr, nameof (PitchLambda));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TopdownCamera.LerpLambdaVars>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
