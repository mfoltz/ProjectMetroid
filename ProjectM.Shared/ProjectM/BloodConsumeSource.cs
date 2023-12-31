// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodConsumeSource
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodConsumeSource
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitBloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideBloodCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceBadBloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQualityBuffRequirement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanBeConsumed;
    [FieldOffset(0)]
    public float BloodQuality;
    [FieldOffset(4)]
    public PrefabGUID UnitBloodType;
    [FieldOffset(8)]
    public CurveReference OverrideBloodCurve;
    [FieldOffset(16)]
    public bool ForceBadBloodQuality;
    [FieldOffset(20)]
    public int BloodQualityBuffRequirement;
    [FieldOffset(24)]
    public bool CanBeConsumed;

    static BloodConsumeSource()
    {
      Il2CppClassPointerStore<BloodConsumeSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodConsumeSource));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodConsumeSource>.NativeClassPtr);
      BloodConsumeSource.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSource>.NativeClassPtr, nameof (BloodQuality));
      BloodConsumeSource.NativeFieldInfoPtr_UnitBloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSource>.NativeClassPtr, nameof (UnitBloodType));
      BloodConsumeSource.NativeFieldInfoPtr_OverrideBloodCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSource>.NativeClassPtr, nameof (OverrideBloodCurve));
      BloodConsumeSource.NativeFieldInfoPtr_ForceBadBloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSource>.NativeClassPtr, nameof (ForceBadBloodQuality));
      BloodConsumeSource.NativeFieldInfoPtr_BloodQualityBuffRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSource>.NativeClassPtr, nameof (BloodQualityBuffRequirement));
      BloodConsumeSource.NativeFieldInfoPtr_CanBeConsumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodConsumeSource>.NativeClassPtr, nameof (CanBeConsumed));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodConsumeSource>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
