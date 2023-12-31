// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitStatType
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM
{
  public enum UnitStatType : byte
  {
    PhysicalPower = 0,
    ResourcePower = 1,
    SiegePower = 2,
    ResourceYield = 3,
    MaxHealth = 4,
    MovementSpeed = 5,
    CooldownModifier = 7,
    PhysicalResistance = 8,
    FireResistance = 9,
    HolyResistance = 10, // 0x0A
    SilverResistance = 11, // 0x0B
    SunChargeTime = 12, // 0x0C
    EnergyGain = 17, // 0x11
    MaxEnergy = 18, // 0x12
    SunResistance = 19, // 0x13
    GarlicResistance = 20, // 0x14
    Vision = 22, // 0x16
    SpellResistance = 23, // 0x17
    Radial_SpellResistance = 24, // 0x18
    SpellPower = 25, // 0x19
    PassiveHealthRegen = 26, // 0x1A
    PhysicalLifeLeech = 27, // 0x1B
    SpellLifeLeech = 28, // 0x1C
    PhysicalCriticalStrikeChance = 29, // 0x1D
    PhysicalCriticalStrikeDamage = 30, // 0x1E
    SpellCriticalStrikeChance = 31, // 0x1F
    SpellCriticalStrikeDamage = 32, // 0x20
    AttackSpeed = 33, // 0x21
    DamageVsUndeads = 38, // 0x26
    DamageVsHumans = 39, // 0x27
    DamageVsDemons = 40, // 0x28
    DamageVsMechanical = 41, // 0x29
    DamageVsBeasts = 42, // 0x2A
    DamageVsCastleObjects = 43, // 0x2B
    DamageVsPlayerVampires = 44, // 0x2C
    ResistVsUndeads = 45, // 0x2D
    ResistVsHumans = 46, // 0x2E
    ResistVsDemons = 47, // 0x2F
    ResistVsMechanical = 48, // 0x30
    ResistVsBeasts = 49, // 0x31
    ResistVsCastleObjects = 50, // 0x32
    ResistVsPlayerVampires = 51, // 0x33
    DamageVsWood = 52, // 0x34
    DamageVsMineral = 53, // 0x35
    DamageVsVegetation = 54, // 0x36
    DamageVsLightArmor = 55, // 0x37
    DamageVsHeavyArmor = 56, // 0x38
    DamageVsMagic = 57, // 0x39
    ReducedResourceDurabilityLoss = 58, // 0x3A
    PrimaryAttackSpeed = 59, // 0x3B
    ImmuneToHazards = 60, // 0x3C
    PrimaryLifeLeech = 61, // 0x3D
    HealthRecovery = 62, // 0x3E
    PrimaryCooldownModifier = 63, // 0x3F
    FallGravity = 64, // 0x40
    PvPResilience = 65, // 0x41
    BloodDrain = 66, // 0x42
    BonusPhysicalPower = 67, // 0x43
    BonusSpellPower = 68, // 0x44
  }
}
