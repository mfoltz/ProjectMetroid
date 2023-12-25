// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnMinionOnGameplayEventStatsOverrides
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnMinionOnGameplayEventStatsOverrides
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevelOverrideMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevelConstant;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitPowerOverrideMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower;
    [FieldOffset(0)]
    public SpawnMinionOnGameplayEventOverrideUnitLevelMode UnitLevelOverrideMode;
    [FieldOffset(4)]
    public int UnitLevelConstant;
    [FieldOffset(8)]
    public SpawnMinionOnGameplayEventOverrideUnitPowerMode UnitPowerOverrideMode;
    [FieldOffset(12)]
    public float BonusHealthPerOwnerSpellPower;
    [FieldOffset(16)]
    public float BonusPhysicalPowerPerOwnerSpellPower;
    [FieldOffset(20)]
    public float BonusSpellPowerPerOwnerSpellPower;

    static SpawnMinionOnGameplayEventStatsOverrides()
    {
      Il2CppClassPointerStore<SpawnMinionOnGameplayEventStatsOverrides>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnMinionOnGameplayEventStatsOverrides));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMinionOnGameplayEventStatsOverrides>.NativeClassPtr);
      SpawnMinionOnGameplayEventStatsOverrides.NativeFieldInfoPtr_UnitLevelOverrideMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventStatsOverrides>.NativeClassPtr, nameof (UnitLevelOverrideMode));
      SpawnMinionOnGameplayEventStatsOverrides.NativeFieldInfoPtr_UnitLevelConstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventStatsOverrides>.NativeClassPtr, nameof (UnitLevelConstant));
      SpawnMinionOnGameplayEventStatsOverrides.NativeFieldInfoPtr_UnitPowerOverrideMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventStatsOverrides>.NativeClassPtr, nameof (UnitPowerOverrideMode));
      SpawnMinionOnGameplayEventStatsOverrides.NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventStatsOverrides>.NativeClassPtr, nameof (BonusHealthPerOwnerSpellPower));
      SpawnMinionOnGameplayEventStatsOverrides.NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventStatsOverrides>.NativeClassPtr, nameof (BonusPhysicalPowerPerOwnerSpellPower));
      SpawnMinionOnGameplayEventStatsOverrides.NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEventStatsOverrides>.NativeClassPtr, nameof (BonusSpellPowerPerOwnerSpellPower));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnMinionOnGameplayEventStatsOverrides>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
