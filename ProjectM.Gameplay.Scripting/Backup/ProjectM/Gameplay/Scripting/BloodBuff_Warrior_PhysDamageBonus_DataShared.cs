// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Warrior_PhysDamageBonus_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Warrior_PhysDamageBonus_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinPhysDamageIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPhysDamageIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysDamageIncreaseModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinPhysDamageIncrease;
    [FieldOffset(4)]
    public float MaxPhysDamageIncrease;
    [FieldOffset(8)]
    public ModificationId PhysDamageIncreaseModificationId;
    [FieldOffset(12)]
    public float RequiredBloodPercentage;

    static BloodBuff_Warrior_PhysDamageBonus_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Warrior_PhysDamageBonus_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Warrior_PhysDamageBonus_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Warrior_PhysDamageBonus_DataShared>.NativeClassPtr);
      BloodBuff_Warrior_PhysDamageBonus_DataShared.NativeFieldInfoPtr_MinPhysDamageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_PhysDamageBonus_DataShared>.NativeClassPtr, nameof (MinPhysDamageIncrease));
      BloodBuff_Warrior_PhysDamageBonus_DataShared.NativeFieldInfoPtr_MaxPhysDamageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_PhysDamageBonus_DataShared>.NativeClassPtr, nameof (MaxPhysDamageIncrease));
      BloodBuff_Warrior_PhysDamageBonus_DataShared.NativeFieldInfoPtr_PhysDamageIncreaseModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_PhysDamageBonus_DataShared>.NativeClassPtr, nameof (PhysDamageIncreaseModificationId));
      BloodBuff_Warrior_PhysDamageBonus_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_PhysDamageBonus_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Warrior_PhysDamageBonus_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
