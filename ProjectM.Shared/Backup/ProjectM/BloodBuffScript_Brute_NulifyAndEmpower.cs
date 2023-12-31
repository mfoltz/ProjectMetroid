// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodBuffScript_Brute_NulifyAndEmpower
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuffScript_Brute_NulifyAndEmpower
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NulifyChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageReduction;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_EmpowerBuff;
    [FieldOffset(0)]
    public float NulifyChance;
    [FieldOffset(4)]
    public float DamageReduction;
    [FieldOffset(8)]
    public float RequiredBloodPercentage;
    [FieldOffset(12)]
    public PrefabGUID EmpowerBuff;

    static BloodBuffScript_Brute_NulifyAndEmpower()
    {
      Il2CppClassPointerStore<BloodBuffScript_Brute_NulifyAndEmpower>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodBuffScript_Brute_NulifyAndEmpower));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuffScript_Brute_NulifyAndEmpower>.NativeClassPtr);
      BloodBuffScript_Brute_NulifyAndEmpower.NativeFieldInfoPtr_NulifyChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Brute_NulifyAndEmpower>.NativeClassPtr, nameof (NulifyChance));
      BloodBuffScript_Brute_NulifyAndEmpower.NativeFieldInfoPtr_DamageReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Brute_NulifyAndEmpower>.NativeClassPtr, nameof (DamageReduction));
      BloodBuffScript_Brute_NulifyAndEmpower.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Brute_NulifyAndEmpower>.NativeClassPtr, nameof (RequiredBloodPercentage));
      BloodBuffScript_Brute_NulifyAndEmpower.NativeFieldInfoPtr_EmpowerBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Brute_NulifyAndEmpower>.NativeClassPtr, nameof (EmpowerBuff));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuffScript_Brute_NulifyAndEmpower>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
