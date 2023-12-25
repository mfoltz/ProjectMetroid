// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Scholar_SpellCritChanceBonus_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Scholar_SpellCritChanceBonus_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinSpellCriticalStrikeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpellCriticalStrikeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellCriticalStrikeChanceModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinSpellCriticalStrikeChance;
    [FieldOffset(4)]
    public float MaxSpellCriticalStrikeChance;
    [FieldOffset(8)]
    public ModificationId SpellCriticalStrikeChanceModificationId;
    [FieldOffset(12)]
    public float RequiredBloodPercentage;

    static BloodBuff_Scholar_SpellCritChanceBonus_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Scholar_SpellCritChanceBonus_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Scholar_SpellCritChanceBonus_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Scholar_SpellCritChanceBonus_DataShared>.NativeClassPtr);
      BloodBuff_Scholar_SpellCritChanceBonus_DataShared.NativeFieldInfoPtr_MinSpellCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellCritChanceBonus_DataShared>.NativeClassPtr, nameof (MinSpellCriticalStrikeChance));
      BloodBuff_Scholar_SpellCritChanceBonus_DataShared.NativeFieldInfoPtr_MaxSpellCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellCritChanceBonus_DataShared>.NativeClassPtr, nameof (MaxSpellCriticalStrikeChance));
      BloodBuff_Scholar_SpellCritChanceBonus_DataShared.NativeFieldInfoPtr_SpellCriticalStrikeChanceModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellCritChanceBonus_DataShared>.NativeClassPtr, nameof (SpellCriticalStrikeChanceModificationId));
      BloodBuff_Scholar_SpellCritChanceBonus_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Scholar_SpellCritChanceBonus_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Scholar_SpellCritChanceBonus_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
