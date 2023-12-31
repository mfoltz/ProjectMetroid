// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodBuffScript_Brute_HealthRegenBonus
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuffScript_Brute_HealthRegenBonus
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinHealthRegenIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthRegenIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinHealthRegenIncrease;
    [FieldOffset(4)]
    public float MaxHealthRegenIncrease;
    [FieldOffset(8)]
    public float RequiredBloodPercentage;

    static BloodBuffScript_Brute_HealthRegenBonus()
    {
      Il2CppClassPointerStore<BloodBuffScript_Brute_HealthRegenBonus>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodBuffScript_Brute_HealthRegenBonus));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuffScript_Brute_HealthRegenBonus>.NativeClassPtr);
      BloodBuffScript_Brute_HealthRegenBonus.NativeFieldInfoPtr_MinHealthRegenIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Brute_HealthRegenBonus>.NativeClassPtr, nameof (MinHealthRegenIncrease));
      BloodBuffScript_Brute_HealthRegenBonus.NativeFieldInfoPtr_MaxHealthRegenIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Brute_HealthRegenBonus>.NativeClassPtr, nameof (MaxHealthRegenIncrease));
      BloodBuffScript_Brute_HealthRegenBonus.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Brute_HealthRegenBonus>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuffScript_Brute_HealthRegenBonus>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
