// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Buff_Reduce_Cooldown_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Buff_Reduce_Cooldown_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Spell_CooldownReduction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Spell_CooldownReductionPerStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weapon_CooldownReduction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weapon_CooldownReductionPerStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_Travel_CooldownReduction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Travel_CooldownReductionPerStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellCooldownModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelCooldownModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponCooldownModificationId;
    [FieldOffset(0)]
    public float Spell_CooldownReduction;
    [FieldOffset(4)]
    public float Spell_CooldownReductionPerStack;
    [FieldOffset(8)]
    public float Weapon_CooldownReduction;
    [FieldOffset(12)]
    public float Weapon_CooldownReductionPerStack;
    [FieldOffset(16)]
    public float Travel_CooldownReduction;
    [FieldOffset(20)]
    public float Travel_CooldownReductionPerStack;
    [FieldOffset(24)]
    public ModificationId SpellCooldownModificationId;
    [FieldOffset(28)]
    public ModificationId TravelCooldownModificationId;
    [FieldOffset(32)]
    public ModificationId WeaponCooldownModificationId;

    static Buff_Reduce_Cooldown_DataShared()
    {
      Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Buff_Reduce_Cooldown_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr);
      Buff_Reduce_Cooldown_DataShared.NativeFieldInfoPtr_Spell_CooldownReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr, nameof (Spell_CooldownReduction));
      Buff_Reduce_Cooldown_DataShared.NativeFieldInfoPtr_Spell_CooldownReductionPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr, nameof (Spell_CooldownReductionPerStack));
      Buff_Reduce_Cooldown_DataShared.NativeFieldInfoPtr_Weapon_CooldownReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr, nameof (Weapon_CooldownReduction));
      Buff_Reduce_Cooldown_DataShared.NativeFieldInfoPtr_Weapon_CooldownReductionPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr, nameof (Weapon_CooldownReductionPerStack));
      Buff_Reduce_Cooldown_DataShared.NativeFieldInfoPtr_Travel_CooldownReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr, nameof (Travel_CooldownReduction));
      Buff_Reduce_Cooldown_DataShared.NativeFieldInfoPtr_Travel_CooldownReductionPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr, nameof (Travel_CooldownReductionPerStack));
      Buff_Reduce_Cooldown_DataShared.NativeFieldInfoPtr_SpellCooldownModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr, nameof (SpellCooldownModificationId));
      Buff_Reduce_Cooldown_DataShared.NativeFieldInfoPtr_TravelCooldownModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr, nameof (TravelCooldownModificationId));
      Buff_Reduce_Cooldown_DataShared.NativeFieldInfoPtr_WeaponCooldownModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr, nameof (WeaponCooldownModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buff_Reduce_Cooldown_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
