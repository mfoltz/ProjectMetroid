// Decompiled with JetBrains decompiler
// Type: ProjectM.TryCastResult
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

#nullable disable
namespace ProjectM
{
  public enum TryCastResult
  {
    Success,
    AbilityOnCooldown,
    AbilityGroupOnCooldown,
    AbilityGroupNotEnoughCharges,
    OnGlobalCooldown,
    AlreadyCasting,
    DoesNotHaveAbilityState,
    NotEnoughEnergy,
    InvalidTarget,
    PriorityTooLow,
    AbilityImpaired,
    Conditional,
    AbilityNotOnBar,
  }
}
