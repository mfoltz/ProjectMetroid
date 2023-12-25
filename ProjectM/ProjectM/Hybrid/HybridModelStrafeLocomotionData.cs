// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelStrafeLocomotionData
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
  public struct HybridModelStrafeLocomotionData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastValidNormalizedVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmoothInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_SlowSmoothInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoZeroInstantInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovementKeyPressed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Turn180;
    [FieldOffset(0)]
    public float3 LastValidNormalizedVelocity;
    [FieldOffset(12)]
    public float2 SmoothInput;
    [FieldOffset(20)]
    public float2 SlowSmoothInput;
    [FieldOffset(28)]
    public float2 NoZeroInstantInput;
    [FieldOffset(36)]
    public bool MovementKeyPressed;
    [FieldOffset(37)]
    public bool Turn180;

    static HybridModelStrafeLocomotionData()
    {
      Il2CppClassPointerStore<HybridModelStrafeLocomotionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelStrafeLocomotionData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelStrafeLocomotionData>.NativeClassPtr);
      HybridModelStrafeLocomotionData.NativeFieldInfoPtr_LastValidNormalizedVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelStrafeLocomotionData>.NativeClassPtr, nameof (LastValidNormalizedVelocity));
      HybridModelStrafeLocomotionData.NativeFieldInfoPtr_SmoothInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelStrafeLocomotionData>.NativeClassPtr, nameof (SmoothInput));
      HybridModelStrafeLocomotionData.NativeFieldInfoPtr_SlowSmoothInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelStrafeLocomotionData>.NativeClassPtr, nameof (SlowSmoothInput));
      HybridModelStrafeLocomotionData.NativeFieldInfoPtr_NoZeroInstantInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelStrafeLocomotionData>.NativeClassPtr, nameof (NoZeroInstantInput));
      HybridModelStrafeLocomotionData.NativeFieldInfoPtr_MovementKeyPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelStrafeLocomotionData>.NativeClassPtr, nameof (MovementKeyPressed));
      HybridModelStrafeLocomotionData.NativeFieldInfoPtr_Turn180 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelStrafeLocomotionData>.NativeClassPtr, nameof (Turn180));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelStrafeLocomotionData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
