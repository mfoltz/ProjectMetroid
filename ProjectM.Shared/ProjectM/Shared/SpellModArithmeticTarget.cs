// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModArithmeticTarget
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM.Shared
{
  public enum SpellModArithmeticTarget : ushort
  {
    DealDamageOnGameplayEvent_MainFactor = 0,
    DealDamageOnGameplayEvent_DamageModifierPerHit = 1,
    HealOnGameplayEvent_Health = 2,
    HealOnGameplayEvent_HealthPercent = 3,
    HealOnGameplayEvent_HealthPerSpellPower = 4,
    LifeLeechOnGameplayEvent_Factor = 5,
    ApplyKnockbackOnGameplayEvent_Range = 6,
    ApplyKnockbackOnGameplayEvent_Duration = 7,
    ApplyKnockbackOnGameplayEvent_CloseRange = 8,
    ApplyKnockbackOnGameplayEvent_FarRange = 9,
    ApplyKnockbackOnGameplayEvent_MaxRangeToTarget = 10, // 0x000A
    ApplyKnockbackOnGameplayEvent_MinRangeToTarget = 11, // 0x000B
    AmplifyBuff_Amplify = 12, // 0x000C
    LifeTime_Duration = 13, // 0x000D
    ModifyMovementSpeedBuff_MoveSpeed = 14, // 0x000E
    ModifyMovementSpeedBuff_MoveSpeedPerStack = 15, // 0x000F
    IterateThrough_Count = 16, // 0x0010
    Projectile_Speed = 17, // 0x0011
    Projectile_Range = 18, // 0x0012
    Absorb_AbsorbCap = 19, // 0x0013
    Absorb_AbsorbCapPerSpellPower = 20, // 0x0014
    Absorb_AbsorbCapPerMaxHealth = 21, // 0x0015
    Absorb_AbsorbModifier = 22, // 0x0016
    ModifyUnitStats_StaticValue = 23, // 0x0017
    ModifyUnitStats_ByStackValue = 24, // 0x0018
    ApplyBuff_OverrideDuration = 25, // 0x0019
    ApplyBuff_Stacks = 26, // 0x001A
    HitColliderCast_CircleRadius = 27, // 0x001B
    EmpowerBuff_Empower = 28, // 0x001C
    TargetAoE_MinRange = 29, // 0x001D
    TargetAoE_MaxRange = 30, // 0x001E
    TargetAoE_MinTime = 31, // 0x001F
    TargetAoE_MaxTime = 32, // 0x0020
    TravelBuff_MinRange = 33, // 0x0021
    TravelBuff_MaxRange = 34, // 0x0022
    TravelBuff_MinTime = 35, // 0x0023
    TravelBuff_MaxTime = 36, // 0x0024
    AdjustLifetime_LifeTimeAdjustment = 37, // 0x0025
    SpawnMinion_BonusHealthPerOwnerSpellPower = 38, // 0x0026
    SpawnMinion_BonusPhysicalPowerPerOwnerSpellPower = 39, // 0x0027
    SpawnMinion_BonusSpellPowerPerOwnerSpellPower = 40, // 0x0028
    ScriptBegin = 5000, // 0x1388
    BouncingProjectile_MaxBounces = 5001, // 0x1389
    BouncingProjectile_DamageModifierPerBounce = 5002, // 0x138A
    EmpowerDamageDealtByType_DamageFactor = 5003, // 0x138B
    EmpowerDamageDealtByType_DamageFactorPerStack = 5004, // 0x138C
    ModifyAbilityCooldown_MaxBounces = 5005, // 0x138D
    ModifyAbilityCooldownFactor_MaxBounces = 5006, // 0x138E
    AbilityProjectileFanOnGameplayEvent_Count = 5007, // 0x138F
    AbilityProjectileFanOnGameplayEvent_Angle = 5008, // 0x1390
    BranchOnRandomGameplayEvent_Chance = 5009, // 0x1391
    HomingSpell_Range = 5010, // 0x1392
    HomingSpell_Speed = 5011, // 0x1393
    EvenSpreadCluster_Count = 5012, // 0x1394
    HomingProjectileBoostOverLifetime_Damage = 5013, // 0x1395
    BouncingProjectile_HealingModifierPerBounce = 5014, // 0x1396
  }
}
