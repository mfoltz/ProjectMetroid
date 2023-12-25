// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellLevelBonus_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Scholar_SpellLevelBonus_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinSpellLevelIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpellLevelIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellLevelIncreaseModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinSpellLevelIncrease;
    [FieldOffset(4)]
    public float MaxSpellLevelIncrease;
    [FieldOffset(8)]
    public ModificationId SpellLevelIncreaseModificationId;
    [FieldOffset(12)]
    public float RequiredBloodPercentage;

    static BloodBuff_Scholar_SpellLevelBonus_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Scholar_SpellLevelBonus_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Scholar_SpellLevelBonus_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Scholar_SpellLevelBonus_DataShared>.NativeClassPtr);
      BloodBuff_Scholar_SpellLevelBonus_DataShared.NativeFieldInfoPtr_MinSpellLevelIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellLevelBonus_DataShared>.NativeClassPtr, nameof (MinSpellLevelIncrease));
      BloodBuff_Scholar_SpellLevelBonus_DataShared.NativeFieldInfoPtr_MaxSpellLevelIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellLevelBonus_DataShared>.NativeClassPtr, nameof (MaxSpellLevelIncrease));
      BloodBuff_Scholar_SpellLevelBonus_DataShared.NativeFieldInfoPtr_SpellLevelIncreaseModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellLevelBonus_DataShared>.NativeClassPtr, nameof (SpellLevelIncreaseModificationId));
      BloodBuff_Scholar_SpellLevelBonus_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellLevelBonus_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Scholar_SpellLevelBonus_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
