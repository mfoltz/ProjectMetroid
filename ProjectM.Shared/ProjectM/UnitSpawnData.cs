// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitSpawnData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitSpawnData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthSettingsPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellPowerSettingsPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalPowerSettingsPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegePowerSettingsPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Misery;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideMaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalPowerFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverridePhysicalPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellPowerFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideSpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegePowerFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideSiegePower;
    [FieldOffset(0)]
    public PrefabGUID HealthSettingsPrefabGuid;
    [FieldOffset(4)]
    public PrefabGUID SpellPowerSettingsPrefabGuid;
    [FieldOffset(8)]
    public PrefabGUID PhysicalPowerSettingsPrefabGuid;
    [FieldOffset(12)]
    public PrefabGUID SiegePowerSettingsPrefabGuid;
    [FieldOffset(16)]
    public float MaxHealthFactor;
    [FieldOffset(20)]
    public float HealthFactor;
    [FieldOffset(24)]
    public float Misery;
    [FieldOffset(28)]
    public float BloodQuality;
    [FieldOffset(32)]
    public float OverrideMaxHealth;
    [FieldOffset(36)]
    public float PhysicalPowerFactor;
    [FieldOffset(40)]
    public float OverridePhysicalPower;
    [FieldOffset(44)]
    public float SpellPowerFactor;
    [FieldOffset(48)]
    public float OverrideSpellPower;
    [FieldOffset(52)]
    public float SiegePowerFactor;
    [FieldOffset(56)]
    public float OverrideSiegePower;

    static UnitSpawnData()
    {
      Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitSpawnData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr);
      UnitSpawnData.NativeFieldInfoPtr_HealthSettingsPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (HealthSettingsPrefabGuid));
      UnitSpawnData.NativeFieldInfoPtr_SpellPowerSettingsPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (SpellPowerSettingsPrefabGuid));
      UnitSpawnData.NativeFieldInfoPtr_PhysicalPowerSettingsPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (PhysicalPowerSettingsPrefabGuid));
      UnitSpawnData.NativeFieldInfoPtr_SiegePowerSettingsPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (SiegePowerSettingsPrefabGuid));
      UnitSpawnData.NativeFieldInfoPtr_MaxHealthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (MaxHealthFactor));
      UnitSpawnData.NativeFieldInfoPtr_HealthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (HealthFactor));
      UnitSpawnData.NativeFieldInfoPtr_Misery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (Misery));
      UnitSpawnData.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (BloodQuality));
      UnitSpawnData.NativeFieldInfoPtr_OverrideMaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (OverrideMaxHealth));
      UnitSpawnData.NativeFieldInfoPtr_PhysicalPowerFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (PhysicalPowerFactor));
      UnitSpawnData.NativeFieldInfoPtr_OverridePhysicalPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (OverridePhysicalPower));
      UnitSpawnData.NativeFieldInfoPtr_SpellPowerFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (SpellPowerFactor));
      UnitSpawnData.NativeFieldInfoPtr_OverrideSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (OverrideSpellPower));
      UnitSpawnData.NativeFieldInfoPtr_SiegePowerFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (SiegePowerFactor));
      UnitSpawnData.NativeFieldInfoPtr_OverrideSiegePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, nameof (OverrideSiegePower));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitSpawnData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
