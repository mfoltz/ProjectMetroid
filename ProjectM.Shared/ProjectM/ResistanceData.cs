// Decompiled with JetBrains decompiler
// Type: ProjectM.ResistanceData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ResistanceData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SunResistance_IncreasedSunPiercingDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_GarlicResistance_DamageReductionPerRating;
    private static readonly System.IntPtr NativeFieldInfoPtr_GarlicResistance_IncreasedExposureFactorPerRating;
    private static readonly System.IntPtr NativeFieldInfoPtr_GarlicResistance_ReduceMaxStacksPerRating;
    private static readonly System.IntPtr NativeFieldInfoPtr_FireResistance_DamageReductionPerRating;
    private static readonly System.IntPtr NativeFieldInfoPtr_FireResistance_RedcuedIgiteChancePerRating;
    private static readonly System.IntPtr NativeFieldInfoPtr_SilverResistance_DamageReductionPerRating;
    private static readonly System.IntPtr NativeFieldInfoPtr_SilverResistance_CarryValueAbsorbedPerRating;
    private static readonly System.IntPtr NativeFieldInfoPtr_HolyResistance_DamageReductionPerRating;
    private static readonly System.IntPtr NativeFieldInfoPtr_HolyResistance_DamageAbsorbPerRating;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPResilience_DamageReductionPerRating;
    [FieldOffset(0)]
    public float SunResistance_IncreasedSunPiercingDuration;
    [FieldOffset(4)]
    public float GarlicResistance_DamageReductionPerRating;
    [FieldOffset(8)]
    public float GarlicResistance_IncreasedExposureFactorPerRating;
    [FieldOffset(12)]
    public float GarlicResistance_ReduceMaxStacksPerRating;
    [FieldOffset(16)]
    public float FireResistance_DamageReductionPerRating;
    [FieldOffset(20)]
    public float FireResistance_RedcuedIgiteChancePerRating;
    [FieldOffset(24)]
    public float SilverResistance_DamageReductionPerRating;
    [FieldOffset(28)]
    public float SilverResistance_CarryValueAbsorbedPerRating;
    [FieldOffset(32)]
    public float HolyResistance_DamageReductionPerRating;
    [FieldOffset(36)]
    public float HolyResistance_DamageAbsorbPerRating;
    [FieldOffset(40)]
    public float PvPResilience_DamageReductionPerRating;

    static ResistanceData()
    {
      Il2CppClassPointerStore<ResistanceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ResistanceData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr);
      ResistanceData.NativeFieldInfoPtr_SunResistance_IncreasedSunPiercingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (SunResistance_IncreasedSunPiercingDuration));
      ResistanceData.NativeFieldInfoPtr_GarlicResistance_DamageReductionPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (GarlicResistance_DamageReductionPerRating));
      ResistanceData.NativeFieldInfoPtr_GarlicResistance_IncreasedExposureFactorPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (GarlicResistance_IncreasedExposureFactorPerRating));
      ResistanceData.NativeFieldInfoPtr_GarlicResistance_ReduceMaxStacksPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (GarlicResistance_ReduceMaxStacksPerRating));
      ResistanceData.NativeFieldInfoPtr_FireResistance_DamageReductionPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (FireResistance_DamageReductionPerRating));
      ResistanceData.NativeFieldInfoPtr_FireResistance_RedcuedIgiteChancePerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (FireResistance_RedcuedIgiteChancePerRating));
      ResistanceData.NativeFieldInfoPtr_SilverResistance_DamageReductionPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (SilverResistance_DamageReductionPerRating));
      ResistanceData.NativeFieldInfoPtr_SilverResistance_CarryValueAbsorbedPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (SilverResistance_CarryValueAbsorbedPerRating));
      ResistanceData.NativeFieldInfoPtr_HolyResistance_DamageReductionPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (HolyResistance_DamageReductionPerRating));
      ResistanceData.NativeFieldInfoPtr_HolyResistance_DamageAbsorbPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (HolyResistance_DamageAbsorbPerRating));
      ResistanceData.NativeFieldInfoPtr_PvPResilience_DamageReductionPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, nameof (PvPResilience_DamageReductionPerRating));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResistanceData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
