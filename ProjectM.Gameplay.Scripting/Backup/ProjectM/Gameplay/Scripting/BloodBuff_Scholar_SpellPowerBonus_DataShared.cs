// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellPowerBonus_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Scholar_SpellPowerBonus_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinSpellPowerIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpellPowerIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellPowerIncreaseModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinSpellPowerIncrease;
    [FieldOffset(4)]
    public float MaxSpellPowerIncrease;
    [FieldOffset(8)]
    public ModificationId SpellPowerIncreaseModificationId;
    [FieldOffset(12)]
    public float RequiredBloodPercentage;

    static BloodBuff_Scholar_SpellPowerBonus_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Scholar_SpellPowerBonus_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Scholar_SpellPowerBonus_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Scholar_SpellPowerBonus_DataShared>.NativeClassPtr);
      BloodBuff_Scholar_SpellPowerBonus_DataShared.NativeFieldInfoPtr_MinSpellPowerIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellPowerBonus_DataShared>.NativeClassPtr, nameof (MinSpellPowerIncrease));
      BloodBuff_Scholar_SpellPowerBonus_DataShared.NativeFieldInfoPtr_MaxSpellPowerIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellPowerBonus_DataShared>.NativeClassPtr, nameof (MaxSpellPowerIncrease));
      BloodBuff_Scholar_SpellPowerBonus_DataShared.NativeFieldInfoPtr_SpellPowerIncreaseModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellPowerBonus_DataShared>.NativeClassPtr, nameof (SpellPowerIncreaseModificationId));
      BloodBuff_Scholar_SpellPowerBonus_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellPowerBonus_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Scholar_SpellPowerBonus_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
