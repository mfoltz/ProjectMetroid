// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelLocomotionData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridModelLocomotionData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_Velocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditiveTurn;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalScaleZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditiveTurnSupport;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsInCombat;
    [FieldOffset(0)]
    public Vector3 Position;
    [FieldOffset(12)]
    public Vector3 AimDirection;
    [FieldOffset(24)]
    public float Velocity;
    [FieldOffset(28)]
    public float MoveVelocity;
    [FieldOffset(32)]
    public float AdditiveTurn;
    [FieldOffset(36)]
    public float LocalScaleZ;
    [FieldOffset(40)]
    public bool AdditiveTurnSupport;
    [FieldOffset(41)]
    public bool IsInCombat;

    static HybridModelLocomotionData()
    {
      Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelLocomotionData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr);
      HybridModelLocomotionData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr, nameof (Position));
      HybridModelLocomotionData.NativeFieldInfoPtr_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr, nameof (AimDirection));
      HybridModelLocomotionData.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr, nameof (Velocity));
      HybridModelLocomotionData.NativeFieldInfoPtr_MoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr, nameof (MoveVelocity));
      HybridModelLocomotionData.NativeFieldInfoPtr_AdditiveTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr, nameof (AdditiveTurn));
      HybridModelLocomotionData.NativeFieldInfoPtr_LocalScaleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr, nameof (LocalScaleZ));
      HybridModelLocomotionData.NativeFieldInfoPtr_AdditiveTurnSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr, nameof (AdditiveTurnSupport));
      HybridModelLocomotionData.NativeFieldInfoPtr_IsInCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr, nameof (IsInCombat));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelLocomotionData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
