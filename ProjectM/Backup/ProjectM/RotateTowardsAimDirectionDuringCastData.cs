// Decompiled with JetBrains decompiler
// Type: ProjectM.RotateTowardsAimDirectionDuringCastData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RotateTowardsAimDirectionDuringCastData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDegrees;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDegrees;
    private static readonly System.IntPtr NativeFieldInfoPtr_ManualDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_Clockwise;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseManualDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExcludePostCastDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetRotationCanChangeDuringCast;
    [FieldOffset(0)]
    public float RotationAngle;
    [FieldOffset(4)]
    public float MinDegrees;
    [FieldOffset(8)]
    public float MaxDegrees;
    [FieldOffset(12)]
    public float ManualDuration;
    [FieldOffset(16)]
    public CurveReference Curve;
    [FieldOffset(24)]
    public RotateDirectionType Clockwise;
    [FieldOffset(28)]
    public bool UseManualDuration;
    [FieldOffset(29)]
    public bool ExcludePostCastDuration;
    [FieldOffset(30)]
    public bool TargetRotationCanChangeDuringCast;

    static RotateTowardsAimDirectionDuringCastData()
    {
      Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RotateTowardsAimDirectionDuringCastData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr);
      RotateTowardsAimDirectionDuringCastData.NativeFieldInfoPtr_RotationAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr, nameof (RotationAngle));
      RotateTowardsAimDirectionDuringCastData.NativeFieldInfoPtr_MinDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr, nameof (MinDegrees));
      RotateTowardsAimDirectionDuringCastData.NativeFieldInfoPtr_MaxDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr, nameof (MaxDegrees));
      RotateTowardsAimDirectionDuringCastData.NativeFieldInfoPtr_ManualDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr, nameof (ManualDuration));
      RotateTowardsAimDirectionDuringCastData.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr, nameof (Curve));
      RotateTowardsAimDirectionDuringCastData.NativeFieldInfoPtr_Clockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr, nameof (Clockwise));
      RotateTowardsAimDirectionDuringCastData.NativeFieldInfoPtr_UseManualDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr, nameof (UseManualDuration));
      RotateTowardsAimDirectionDuringCastData.NativeFieldInfoPtr_ExcludePostCastDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr, nameof (ExcludePostCastDuration));
      RotateTowardsAimDirectionDuringCastData.NativeFieldInfoPtr_TargetRotationCanChangeDuringCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr, nameof (TargetRotationCanChangeDuringCast));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
