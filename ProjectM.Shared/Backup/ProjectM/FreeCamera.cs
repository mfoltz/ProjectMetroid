// Decompiled with JetBrains decompiler
// Type: ProjectM.FreeCamera
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
  public struct FreeCamera
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LerpEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseRotationSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedChangeSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedCrawlMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedBoostMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusCustomTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_LerpLambdas;
    [FieldOffset(0)]
    public bool LerpEnabled;
    [FieldOffset(4)]
    public float MouseRotationSensitivity;
    [FieldOffset(8)]
    public float SpeedChangeSensitivity;
    [FieldOffset(12)]
    public float SpeedCrawlMultiplier;
    [FieldOffset(16)]
    public float SpeedBoostMultiplier;
    [FieldOffset(20)]
    public Entity BonusCustomTargetEntity;
    [FieldOffset(28)]
    public FreeCamera.LerpLambdaVars LerpLambdas;

    static FreeCamera()
    {
      Il2CppClassPointerStore<FreeCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FreeCamera));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr);
      FreeCamera.NativeFieldInfoPtr_LerpEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, nameof (LerpEnabled));
      FreeCamera.NativeFieldInfoPtr_MouseRotationSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, nameof (MouseRotationSensitivity));
      FreeCamera.NativeFieldInfoPtr_SpeedChangeSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, nameof (SpeedChangeSensitivity));
      FreeCamera.NativeFieldInfoPtr_SpeedCrawlMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, nameof (SpeedCrawlMultiplier));
      FreeCamera.NativeFieldInfoPtr_SpeedBoostMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, nameof (SpeedBoostMultiplier));
      FreeCamera.NativeFieldInfoPtr_BonusCustomTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, nameof (BonusCustomTargetEntity));
      FreeCamera.NativeFieldInfoPtr_LerpLambdas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, nameof (LerpLambdas));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LerpLambdaVars
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RotationLambda;
      private static readonly System.IntPtr NativeFieldInfoPtr_PositionLambda;
      [FieldOffset(0)]
      public float RotationLambda;
      [FieldOffset(4)]
      public float PositionLambda;

      static LerpLambdaVars()
      {
        Il2CppClassPointerStore<FreeCamera.LerpLambdaVars>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, nameof (LerpLambdaVars));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeCamera.LerpLambdaVars>.NativeClassPtr);
        FreeCamera.LerpLambdaVars.NativeFieldInfoPtr_RotationLambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera.LerpLambdaVars>.NativeClassPtr, nameof (RotationLambda));
        FreeCamera.LerpLambdaVars.NativeFieldInfoPtr_PositionLambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera.LerpLambdaVars>.NativeClassPtr, nameof (PositionLambda));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FreeCamera.LerpLambdaVars>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
