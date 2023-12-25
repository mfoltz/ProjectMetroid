// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DamageReduction_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Warrior_DamageReduction_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDamageReduction;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDamageReduction;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalDamageReductionModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellDamageReductionModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinDamageReduction;
    [FieldOffset(4)]
    public float MaxDamageReduction;
    [FieldOffset(8)]
    public ModificationId PhysicalDamageReductionModificationId;
    [FieldOffset(12)]
    public ModificationId SpellDamageReductionModificationId;
    [FieldOffset(16)]
    public float RequiredBloodPercentage;

    static BloodBuff_Warrior_DamageReduction_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Warrior_DamageReduction_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Warrior_DamageReduction_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Warrior_DamageReduction_DataShared>.NativeClassPtr);
      BloodBuff_Warrior_DamageReduction_DataShared.NativeFieldInfoPtr_MinDamageReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_DamageReduction_DataShared>.NativeClassPtr, nameof (MinDamageReduction));
      BloodBuff_Warrior_DamageReduction_DataShared.NativeFieldInfoPtr_MaxDamageReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_DamageReduction_DataShared>.NativeClassPtr, nameof (MaxDamageReduction));
      BloodBuff_Warrior_DamageReduction_DataShared.NativeFieldInfoPtr_PhysicalDamageReductionModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_DamageReduction_DataShared>.NativeClassPtr, nameof (PhysicalDamageReductionModificationId));
      BloodBuff_Warrior_DamageReduction_DataShared.NativeFieldInfoPtr_SpellDamageReductionModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_DamageReduction_DataShared>.NativeClassPtr, nameof (SpellDamageReductionModificationId));
      BloodBuff_Warrior_DamageReduction_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_DamageReduction_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Warrior_DamageReduction_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
