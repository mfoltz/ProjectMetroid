// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodBuffScript_Rogue_MountDamageBonus
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuffScript_Rogue_MountDamageBonus
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinMountDamageIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxMountDamageIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinMountDamageIncrease;
    [FieldOffset(4)]
    public float MaxMountDamageIncrease;
    [FieldOffset(8)]
    public float RequiredBloodPercentage;

    static BloodBuffScript_Rogue_MountDamageBonus()
    {
      Il2CppClassPointerStore<BloodBuffScript_Rogue_MountDamageBonus>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodBuffScript_Rogue_MountDamageBonus));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuffScript_Rogue_MountDamageBonus>.NativeClassPtr);
      BloodBuffScript_Rogue_MountDamageBonus.NativeFieldInfoPtr_MinMountDamageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Rogue_MountDamageBonus>.NativeClassPtr, nameof (MinMountDamageIncrease));
      BloodBuffScript_Rogue_MountDamageBonus.NativeFieldInfoPtr_MaxMountDamageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Rogue_MountDamageBonus>.NativeClassPtr, nameof (MaxMountDamageIncrease));
      BloodBuffScript_Rogue_MountDamageBonus.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Rogue_MountDamageBonus>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuffScript_Rogue_MountDamageBonus>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
