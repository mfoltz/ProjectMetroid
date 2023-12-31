// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitStats
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitStats
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PRIMARY_ATTACK_SPEED_COOLDOWN_MODIFIER;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PRIMARY_ATTACK_SPEED;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PRIMARY_COOLDOWN_MODIFIER;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalCriticalStrikeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalCriticalStrikeDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellCriticalStrikeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellCriticalStrikeDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourcePower;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegePower;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceYieldModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReducedResourceDurabilityLoss;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_SunResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FireResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_HolyResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_SilverResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_GarlicResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_PassiveHealthRegen;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryAttackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPResilience;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtected;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthRecovery;
    private static readonly System.IntPtr NativeMethodInfoPtr_Default_Public_Static_UnitStats_0;
    [FieldOffset(0)]
    public ModifiableFloat PhysicalCriticalStrikeChance;
    [FieldOffset(8)]
    public ModifiableFloat PhysicalCriticalStrikeDamage;
    [FieldOffset(16)]
    public ModifiableFloat SpellCriticalStrikeChance;
    [FieldOffset(24)]
    public ModifiableFloat SpellCriticalStrikeDamage;
    [FieldOffset(32)]
    public ModifiableFloat PhysicalPower;
    [FieldOffset(40)]
    public ModifiableFloat SpellPower;
    [FieldOffset(48)]
    public ModifiableFloat ResourcePower;
    [FieldOffset(56)]
    public ModifiableFloat SiegePower;
    [FieldOffset(64)]
    public ModifiableFloat ResourceYieldModifier;
    [FieldOffset(72)]
    public ModifiableFloat ReducedResourceDurabilityLoss;
    [FieldOffset(80)]
    public ModifiableFloat PhysicalResistance;
    [FieldOffset(88)]
    public ModifiableFloat SpellResistance;
    [FieldOffset(96)]
    public ModifiableInt SunResistance;
    [FieldOffset(104)]
    public ModifiableInt FireResistance;
    [FieldOffset(112)]
    public ModifiableInt HolyResistance;
    [FieldOffset(120)]
    public ModifiableInt SilverResistance;
    [FieldOffset(128)]
    public ModifiableInt GarlicResistance;
    [FieldOffset(136)]
    public ModifiableFloat PassiveHealthRegen;
    [FieldOffset(144)]
    public ModifiableFloat AttackSpeed;
    [FieldOffset(152)]
    public ModifiableFloat PrimaryAttackSpeed;
    [FieldOffset(160)]
    public ModifiableInt PvPResilience;
    [FieldOffset(168)]
    public ModifiableBool PvPProtected;
    [FieldOffset(172)]
    public ModifiableFloat HealthRecovery;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 762883, RefRangeEnd = 762884, XrefRangeStart = 762860, XrefRangeEnd = 762883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe UnitStats Default()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitStats.NativeMethodInfoPtr_Default_Public_Static_UnitStats_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UnitStats*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UnitStats()
    {
      Il2CppClassPointerStore<UnitStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitStats));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitStats>.NativeClassPtr);
      UnitStats.NativeFieldInfoPtr_PRIMARY_ATTACK_SPEED_COOLDOWN_MODIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (PRIMARY_ATTACK_SPEED_COOLDOWN_MODIFIER));
      UnitStats.NativeFieldInfoPtr_MAX_PRIMARY_ATTACK_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (MAX_PRIMARY_ATTACK_SPEED));
      UnitStats.NativeFieldInfoPtr_MAX_PRIMARY_COOLDOWN_MODIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (MAX_PRIMARY_COOLDOWN_MODIFIER));
      UnitStats.NativeFieldInfoPtr_PhysicalCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (PhysicalCriticalStrikeChance));
      UnitStats.NativeFieldInfoPtr_PhysicalCriticalStrikeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (PhysicalCriticalStrikeDamage));
      UnitStats.NativeFieldInfoPtr_SpellCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (SpellCriticalStrikeChance));
      UnitStats.NativeFieldInfoPtr_SpellCriticalStrikeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (SpellCriticalStrikeDamage));
      UnitStats.NativeFieldInfoPtr_PhysicalPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (PhysicalPower));
      UnitStats.NativeFieldInfoPtr_SpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (SpellPower));
      UnitStats.NativeFieldInfoPtr_ResourcePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (ResourcePower));
      UnitStats.NativeFieldInfoPtr_SiegePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (SiegePower));
      UnitStats.NativeFieldInfoPtr_ResourceYieldModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (ResourceYieldModifier));
      UnitStats.NativeFieldInfoPtr_ReducedResourceDurabilityLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (ReducedResourceDurabilityLoss));
      UnitStats.NativeFieldInfoPtr_PhysicalResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (PhysicalResistance));
      UnitStats.NativeFieldInfoPtr_SpellResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (SpellResistance));
      UnitStats.NativeFieldInfoPtr_SunResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (SunResistance));
      UnitStats.NativeFieldInfoPtr_FireResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (FireResistance));
      UnitStats.NativeFieldInfoPtr_HolyResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (HolyResistance));
      UnitStats.NativeFieldInfoPtr_SilverResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (SilverResistance));
      UnitStats.NativeFieldInfoPtr_GarlicResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (GarlicResistance));
      UnitStats.NativeFieldInfoPtr_PassiveHealthRegen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (PassiveHealthRegen));
      UnitStats.NativeFieldInfoPtr_AttackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (AttackSpeed));
      UnitStats.NativeFieldInfoPtr_PrimaryAttackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (PrimaryAttackSpeed));
      UnitStats.NativeFieldInfoPtr_PvPResilience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (PvPResilience));
      UnitStats.NativeFieldInfoPtr_PvPProtected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (PvPProtected));
      UnitStats.NativeFieldInfoPtr_HealthRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, nameof (HealthRecovery));
      UnitStats.NativeMethodInfoPtr_Default_Public_Static_UnitStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, 100667401);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitStats>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe float PRIMARY_ATTACK_SPEED_COOLDOWN_MODIFIER
    {
      get
      {
        float cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(UnitStats.NativeFieldInfoPtr_PRIMARY_ATTACK_SPEED_COOLDOWN_MODIFIER, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnitStats.NativeFieldInfoPtr_PRIMARY_ATTACK_SPEED_COOLDOWN_MODIFIER, (void*) &value);
      }
    }

    public static unsafe float MAX_PRIMARY_ATTACK_SPEED
    {
      get
      {
        float primaryAttackSpeed;
        IL2CPP.il2cpp_field_static_get_value(UnitStats.NativeFieldInfoPtr_MAX_PRIMARY_ATTACK_SPEED, (void*) &primaryAttackSpeed);
        return primaryAttackSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnitStats.NativeFieldInfoPtr_MAX_PRIMARY_ATTACK_SPEED, (void*) &value);
      }
    }

    public static unsafe float MAX_PRIMARY_COOLDOWN_MODIFIER
    {
      get
      {
        float cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(UnitStats.NativeFieldInfoPtr_MAX_PRIMARY_COOLDOWN_MODIFIER, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnitStats.NativeFieldInfoPtr_MAX_PRIMARY_COOLDOWN_MODIFIER, (void*) &value);
      }
    }
  }
}
