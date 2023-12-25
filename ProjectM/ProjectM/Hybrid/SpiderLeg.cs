// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.SpiderLeg
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
  public struct SpiderLeg
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldGoalPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Velocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepLerp;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionLerp;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_IKPositionWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsMoving;
    [FieldOffset(0)]
    public float3 GoalPosition;
    [FieldOffset(12)]
    public float3 OldGoalPosition;
    [FieldOffset(24)]
    public float3 CurrentPosition;
    [FieldOffset(36)]
    public float3 LastPosition;
    [FieldOffset(48)]
    public float3 DefaultPosition;
    [FieldOffset(60)]
    public float3 Velocity;
    [FieldOffset(72)]
    public float3 StepDirection;
    [FieldOffset(84)]
    public float StepLerp;
    [FieldOffset(88)]
    public float SuspensionLerp;
    [FieldOffset(92)]
    public float SuspensionScale;
    [FieldOffset(96)]
    public float IKPositionWeight;
    [FieldOffset(100)]
    public bool IsMoving;

    static SpiderLeg()
    {
      Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (SpiderLeg));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr);
      SpiderLeg.NativeFieldInfoPtr_GoalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (GoalPosition));
      SpiderLeg.NativeFieldInfoPtr_OldGoalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (OldGoalPosition));
      SpiderLeg.NativeFieldInfoPtr_CurrentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (CurrentPosition));
      SpiderLeg.NativeFieldInfoPtr_LastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (LastPosition));
      SpiderLeg.NativeFieldInfoPtr_DefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (DefaultPosition));
      SpiderLeg.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (Velocity));
      SpiderLeg.NativeFieldInfoPtr_StepDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (StepDirection));
      SpiderLeg.NativeFieldInfoPtr_StepLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (StepLerp));
      SpiderLeg.NativeFieldInfoPtr_SuspensionLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (SuspensionLerp));
      SpiderLeg.NativeFieldInfoPtr_SuspensionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (SuspensionScale));
      SpiderLeg.NativeFieldInfoPtr_IKPositionWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (IKPositionWeight));
      SpiderLeg.NativeFieldInfoPtr_IsMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, nameof (IsMoving));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpiderLeg>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
