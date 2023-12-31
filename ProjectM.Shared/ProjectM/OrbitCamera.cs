// Decompiled with JetBrains decompiler
// Type: ProjectM.OrbitCamera
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
  public struct OrbitCamera
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LerpEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinPitch;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPitch;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinZoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxZoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoomSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverTheShoulderSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnchorHeightSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoRotationSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseRotationSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusCustomTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_LerpLambdas;
    [FieldOffset(0)]
    public bool LerpEnabled;
    [FieldOffset(4)]
    public float MinPitch;
    [FieldOffset(8)]
    public float MaxPitch;
    [FieldOffset(12)]
    public float MinZoom;
    [FieldOffset(16)]
    public float MaxZoom;
    [FieldOffset(20)]
    public float ZoomSpeed;
    [FieldOffset(24)]
    public float OverTheShoulderSensitivity;
    [FieldOffset(28)]
    public float AnchorHeightSensitivity;
    [FieldOffset(32)]
    public float AutoRotationSensitivity;
    [FieldOffset(36)]
    public float MouseRotationSensitivity;
    [FieldOffset(40)]
    public Entity BonusCustomTargetEntity;
    [FieldOffset(48)]
    public OrbitCamera.LerpLambdaVars LerpLambdas;

    static OrbitCamera()
    {
      Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (OrbitCamera));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr);
      OrbitCamera.NativeFieldInfoPtr_LerpEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (LerpEnabled));
      OrbitCamera.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (MinPitch));
      OrbitCamera.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (MaxPitch));
      OrbitCamera.NativeFieldInfoPtr_MinZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (MinZoom));
      OrbitCamera.NativeFieldInfoPtr_MaxZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (MaxZoom));
      OrbitCamera.NativeFieldInfoPtr_ZoomSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (ZoomSpeed));
      OrbitCamera.NativeFieldInfoPtr_OverTheShoulderSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (OverTheShoulderSensitivity));
      OrbitCamera.NativeFieldInfoPtr_AnchorHeightSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (AnchorHeightSensitivity));
      OrbitCamera.NativeFieldInfoPtr_AutoRotationSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (AutoRotationSensitivity));
      OrbitCamera.NativeFieldInfoPtr_MouseRotationSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (MouseRotationSensitivity));
      OrbitCamera.NativeFieldInfoPtr_BonusCustomTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (BonusCustomTargetEntity));
      OrbitCamera.NativeFieldInfoPtr_LerpLambdas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (LerpLambdas));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LerpLambdaVars
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_OrbitDistanceLambda;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnchorPositionLambda;
      private static readonly System.IntPtr NativeFieldInfoPtr_OrbitEulerLambda;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnchorRotationLerpFactor;
      [FieldOffset(0)]
      public float OrbitDistanceLambda;
      [FieldOffset(4)]
      public float AnchorPositionLambda;
      [FieldOffset(8)]
      public float OrbitEulerLambda;
      [FieldOffset(12)]
      public float AnchorRotationLerpFactor;

      static LerpLambdaVars()
      {
        Il2CppClassPointerStore<OrbitCamera.LerpLambdaVars>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, nameof (LerpLambdaVars));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitCamera.LerpLambdaVars>.NativeClassPtr);
        OrbitCamera.LerpLambdaVars.NativeFieldInfoPtr_OrbitDistanceLambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera.LerpLambdaVars>.NativeClassPtr, nameof (OrbitDistanceLambda));
        OrbitCamera.LerpLambdaVars.NativeFieldInfoPtr_AnchorPositionLambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera.LerpLambdaVars>.NativeClassPtr, nameof (AnchorPositionLambda));
        OrbitCamera.LerpLambdaVars.NativeFieldInfoPtr_OrbitEulerLambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera.LerpLambdaVars>.NativeClassPtr, nameof (OrbitEulerLambda));
        OrbitCamera.LerpLambdaVars.NativeFieldInfoPtr_AnchorRotationLerpFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera.LerpLambdaVars>.NativeClassPtr, nameof (AnchorRotationLerpFactor));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OrbitCamera.LerpLambdaVars>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
