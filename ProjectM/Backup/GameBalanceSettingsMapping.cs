// Decompiled with JetBrains decompiler
// Type: GameBalanceSettingsMapping
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using ProjectM.UI;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class GameBalanceSettingsMapping : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Mappings;
  private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentSets;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResourceSets;
  private static readonly System.IntPtr NativeFieldInfoPtr_GameModeNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_DeathContainerNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeZoneNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_BloodFountainDestroyNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_SiegeWeaponHealthNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_CastleDestroyNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectionNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_SiegeWeaponHealth;
  private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDamageNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_RelicSpawnTypeNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_OffKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_EnabledKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_DisabledKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_GameSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_WorldSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_CastleSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_PlayerSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnitSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_VBloodUnitSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_CostSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInteractionSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_StartGearKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResearchPreUnlockedKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_JournalPreUnlockedKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_TradersKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_VBloodSpecific;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevel;
  private static readonly System.IntPtr NativeFieldInfoPtr_PreUnlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr_ShowKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_DayLength_Short;
  private static readonly System.IntPtr NativeFieldInfoPtr_DayLength_Medium;
  private static readonly System.IntPtr NativeFieldInfoPtr_DayLength_Long;
  private static readonly System.IntPtr NativeFieldInfoPtr_DayLength_VeryLong;
  private static readonly System.IntPtr NativeFieldInfoPtr_DygnLength_SwedishWinter;
  private static readonly System.IntPtr NativeFieldInfoPtr_DygnLength_Short;
  private static readonly System.IntPtr NativeFieldInfoPtr_DygnLength_Medium;
  private static readonly System.IntPtr NativeFieldInfoPtr_DygnLength_Long;
  private static readonly System.IntPtr NativeFieldInfoPtr_DygnLength_SwedishSummer;
  private static readonly System.IntPtr NativeFieldInfoPtr_BloodHuntsDataAuthoring;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResearchStations;
  private static readonly System.IntPtr NativeFieldInfoPtr_AchievementsCollection;
  private static readonly System.IntPtr NativeFieldInfoPtr_SettingPresets;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_String_byref_SettingMapping_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_GameModeType_byref_GameModeNameMapping_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_DeathContainerPermission_byref_DeathContainerNameMapping_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_CastleHeartDamageMode_byref_BloodFountainDestroyModeMapping_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_SiegeWeaponHealth_byref_SiegeWeaponHealthMapping_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_PvPProtectionMode_byref_PvPProtectionModeMapping_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_CastleDamageMode_byref_CastleDestroyModeMapping_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_PlayerDamageMode_byref_PlayerDamageModeMapping_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_GameTimeZone_byref_TimeZoneNameMapping_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_RelicSpawnType_byref_RelicTypeMapping_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 921668, RefRangeEnd = 921679, XrefRangeStart = 921661, XrefRangeEnd = 921668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSettingMapping(
    string identifier,
    out GameBalanceSettingsMapping.SettingMapping mapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_String_byref_SettingMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref GameBalanceSettingsMapping.SettingMapping local = ref mapping;
    System.IntPtr pointer = zero;
    GameBalanceSettingsMapping.SettingMapping settingMapping = pointer == System.IntPtr.Zero ? (GameBalanceSettingsMapping.SettingMapping) null : new GameBalanceSettingsMapping.SettingMapping(pointer);
    local = settingMapping;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921679, XrefRangeEnd = 921684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSettingMapping(
    GameModeType gameMode,
    out GameBalanceSettingsMapping.GameModeNameMapping mapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &gameMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_GameModeType_byref_GameModeNameMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921689, RefRangeEnd = 921690, XrefRangeStart = 921684, XrefRangeEnd = 921689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSettingMapping(
    DeathContainerPermission deathContainerPermission,
    out GameBalanceSettingsMapping.DeathContainerNameMapping mapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &deathContainerPermission;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_DeathContainerPermission_byref_DeathContainerNameMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 921695, RefRangeEnd = 921697, XrefRangeStart = 921690, XrefRangeEnd = 921695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSettingMapping(
    CastleHeartDamageMode castleHeartDamageMode,
    out GameBalanceSettingsMapping.BloodFountainDestroyModeMapping mapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &castleHeartDamageMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_CastleHeartDamageMode_byref_BloodFountainDestroyModeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921702, RefRangeEnd = 921703, XrefRangeStart = 921697, XrefRangeEnd = 921702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSettingMapping(
    ProjectM.SiegeWeaponHealth siegeWeaponHealth,
    out GameBalanceSettingsMapping.SiegeWeaponHealthMapping mapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &siegeWeaponHealth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_SiegeWeaponHealth_byref_SiegeWeaponHealthMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921708, RefRangeEnd = 921709, XrefRangeStart = 921703, XrefRangeEnd = 921708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSettingMapping(
    PvPProtectionMode PvPProtectionMode,
    out GameBalanceSettingsMapping.PvPProtectionModeMapping mapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &PvPProtectionMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_PvPProtectionMode_byref_PvPProtectionModeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921714, RefRangeEnd = 921715, XrefRangeStart = 921709, XrefRangeEnd = 921714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSettingMapping(
    CastleDamageMode castleDamageMode,
    out GameBalanceSettingsMapping.CastleDestroyModeMapping mapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &castleDamageMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_CastleDamageMode_byref_CastleDestroyModeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921720, RefRangeEnd = 921721, XrefRangeStart = 921715, XrefRangeEnd = 921720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSettingMapping(
    PlayerDamageMode castleDamageMode,
    out GameBalanceSettingsMapping.PlayerDamageModeMapping mapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &castleDamageMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_PlayerDamageMode_byref_PlayerDamageModeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921726, RefRangeEnd = 921727, XrefRangeStart = 921721, XrefRangeEnd = 921726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSettingMapping(
    GameTimeZone gameTimeZone,
    out GameBalanceSettingsMapping.TimeZoneNameMapping mapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &gameTimeZone;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_GameTimeZone_byref_TimeZoneNameMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921732, RefRangeEnd = 921733, XrefRangeStart = 921727, XrefRangeEnd = 921732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSettingMapping(
    RelicSpawnType relicSpawnType,
    out GameBalanceSettingsMapping.RelicTypeMapping mapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &relicSpawnType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_RelicSpawnType_byref_RelicTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameBalanceSettingsMapping()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameBalanceSettingsMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static GameBalanceSettingsMapping()
  {
    Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (GameBalanceSettingsMapping));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr);
    GameBalanceSettingsMapping.NativeFieldInfoPtr_Mappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (Mappings));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_EquipmentSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (EquipmentSets));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_ResourceSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (ResourceSets));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_GameModeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (GameModeNames));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DeathContainerNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DeathContainerNames));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_TimeZoneNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (TimeZoneNames));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_BloodFountainDestroyNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (BloodFountainDestroyNames));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_SiegeWeaponHealthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (SiegeWeaponHealthNames));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_CastleDestroyNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (CastleDestroyNames));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_PvPProtectionNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (PvPProtectionNames));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_SiegeWeaponHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (SiegeWeaponHealth));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_PlayerDamageNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (PlayerDamageNames));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_RelicSpawnTypeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (RelicSpawnTypeNames));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_OnKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (OnKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_OffKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (OffKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_EnabledKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (EnabledKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DisabledKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DisabledKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_GameSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (GameSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_WorldSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (WorldSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_ItemSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (ItemSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_CastleSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (CastleSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_TimeSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (TimeSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_PlayerSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (PlayerSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_UnitSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (UnitSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_VBloodUnitSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (VBloodUnitSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_EquipmentSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (EquipmentSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_CostSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (CostSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_PlayerInteractionSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (PlayerInteractionSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_ProgressionSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (ProgressionSettingsKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_StartGearKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (StartGearKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_ResearchPreUnlockedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (ResearchPreUnlockedKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_JournalPreUnlockedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (JournalPreUnlockedKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_TradersKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (TradersKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_VBloodSpecific = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (VBloodSpecific));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (UnitLevel));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_PreUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (PreUnlocked));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_ShowKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (ShowKey));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_Short = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DayLength_Short));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_Medium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DayLength_Medium));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_Long = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DayLength_Long));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_VeryLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DayLength_VeryLong));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_SwedishWinter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DygnLength_SwedishWinter));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_Short = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DygnLength_Short));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_Medium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DygnLength_Medium));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_Long = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DygnLength_Long));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_SwedishSummer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DygnLength_SwedishSummer));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_BloodHuntsDataAuthoring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (BloodHuntsDataAuthoring));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_ResearchStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (ResearchStations));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_AchievementsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (AchievementsCollection));
    GameBalanceSettingsMapping.NativeFieldInfoPtr_SettingPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (SettingPresets));
    GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_String_byref_SettingMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663699);
    GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_GameModeType_byref_GameModeNameMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663700);
    GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_DeathContainerPermission_byref_DeathContainerNameMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663701);
    GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_CastleHeartDamageMode_byref_BloodFountainDestroyModeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663702);
    GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_SiegeWeaponHealth_byref_SiegeWeaponHealthMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663703);
    GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_PvPProtectionMode_byref_PvPProtectionModeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663704);
    GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_CastleDamageMode_byref_CastleDestroyModeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663705);
    GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_PlayerDamageMode_byref_PlayerDamageModeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663706);
    GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_GameTimeZone_byref_TimeZoneNameMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663707);
    GameBalanceSettingsMapping.NativeMethodInfoPtr_TryGetSettingMapping_Public_Boolean_RelicSpawnType_byref_RelicTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663708);
    GameBalanceSettingsMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, 100663709);
  }

  public GameBalanceSettingsMapping(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<GameBalanceSettingsMapping.SettingMapping> Mappings
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_Mappings));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.SettingMapping>) null : new List<GameBalanceSettingsMapping.SettingMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_Mappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.ItemSetMapping> EquipmentSets
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_EquipmentSets));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.ItemSetMapping>) null : new List<GameBalanceSettingsMapping.ItemSetMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_EquipmentSets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.ItemSetMapping> ResourceSets
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ResourceSets));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.ItemSetMapping>) null : new List<GameBalanceSettingsMapping.ItemSetMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ResourceSets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.GameModeNameMapping> GameModeNames
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_GameModeNames));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.GameModeNameMapping>) null : new List<GameBalanceSettingsMapping.GameModeNameMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_GameModeNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.DeathContainerNameMapping> DeathContainerNames
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DeathContainerNames));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.DeathContainerNameMapping>) null : new List<GameBalanceSettingsMapping.DeathContainerNameMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DeathContainerNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.TimeZoneNameMapping> TimeZoneNames
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_TimeZoneNames));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.TimeZoneNameMapping>) null : new List<GameBalanceSettingsMapping.TimeZoneNameMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_TimeZoneNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping> BloodFountainDestroyNames
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_BloodFountainDestroyNames));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping>) null : new List<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_BloodFountainDestroyNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.SiegeWeaponHealthMapping> SiegeWeaponHealthNames
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_SiegeWeaponHealthNames));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.SiegeWeaponHealthMapping>) null : new List<GameBalanceSettingsMapping.SiegeWeaponHealthMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_SiegeWeaponHealthNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.CastleDestroyModeMapping> CastleDestroyNames
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_CastleDestroyNames));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.CastleDestroyModeMapping>) null : new List<GameBalanceSettingsMapping.CastleDestroyModeMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_CastleDestroyNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.PvPProtectionModeMapping> PvPProtectionNames
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_PvPProtectionNames));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.PvPProtectionModeMapping>) null : new List<GameBalanceSettingsMapping.PvPProtectionModeMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_PvPProtectionNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.SiegeWeaponHealthMapping> SiegeWeaponHealth
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_SiegeWeaponHealth));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.SiegeWeaponHealthMapping>) null : new List<GameBalanceSettingsMapping.SiegeWeaponHealthMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_SiegeWeaponHealth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.PlayerDamageModeMapping> PlayerDamageNames
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_PlayerDamageNames));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.PlayerDamageModeMapping>) null : new List<GameBalanceSettingsMapping.PlayerDamageModeMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_PlayerDamageNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.RelicTypeMapping> RelicSpawnTypeNames
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_RelicSpawnTypeNames));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.RelicTypeMapping>) null : new List<GameBalanceSettingsMapping.RelicTypeMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_RelicSpawnTypeNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationKey OnKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_OnKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_OnKey)) = value;
    }
  }

  public unsafe LocalizationKey OffKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_OffKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_OffKey)) = value;
    }
  }

  public unsafe LocalizationKey EnabledKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_EnabledKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_EnabledKey)) = value;
    }
  }

  public unsafe LocalizationKey DisabledKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DisabledKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DisabledKey)) = value;
    }
  }

  public unsafe LocalizationKey GameSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_GameSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_GameSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey WorldSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_WorldSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_WorldSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey ItemSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ItemSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ItemSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey CastleSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_CastleSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_CastleSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey TimeSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_TimeSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_TimeSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey PlayerSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_PlayerSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_PlayerSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey UnitSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_UnitSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_UnitSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey VBloodUnitSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_VBloodUnitSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_VBloodUnitSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey EquipmentSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_EquipmentSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_EquipmentSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey CostSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_CostSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_CostSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey PlayerInteractionSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_PlayerInteractionSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_PlayerInteractionSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey ProgressionSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ProgressionSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ProgressionSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey StartGearKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_StartGearKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_StartGearKey)) = value;
    }
  }

  public unsafe LocalizationKey ResearchPreUnlockedKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ResearchPreUnlockedKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ResearchPreUnlockedKey)) = value;
    }
  }

  public unsafe LocalizationKey JournalPreUnlockedKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_JournalPreUnlockedKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_JournalPreUnlockedKey)) = value;
    }
  }

  public unsafe LocalizationKey TradersKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_TradersKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_TradersKey)) = value;
    }
  }

  public unsafe LocalizationKey VBloodSpecific
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_VBloodSpecific));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_VBloodSpecific)) = value;
    }
  }

  public unsafe LocalizationKey UnitLevel
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_UnitLevel));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_UnitLevel)) = value;
    }
  }

  public unsafe LocalizationKey PreUnlocked
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_PreUnlocked));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_PreUnlocked)) = value;
    }
  }

  public unsafe LocalizationKey ShowKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ShowKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ShowKey)) = value;
    }
  }

  public unsafe LocalizationKey DayLength_Short
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_Short));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_Short)) = value;
    }
  }

  public unsafe LocalizationKey DayLength_Medium
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_Medium));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_Medium)) = value;
    }
  }

  public unsafe LocalizationKey DayLength_Long
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_Long));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_Long)) = value;
    }
  }

  public unsafe LocalizationKey DayLength_VeryLong
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_VeryLong));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DayLength_VeryLong)) = value;
    }
  }

  public unsafe LocalizationKey DygnLength_SwedishWinter
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_SwedishWinter));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_SwedishWinter)) = value;
    }
  }

  public unsafe LocalizationKey DygnLength_Short
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_Short));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_Short)) = value;
    }
  }

  public unsafe LocalizationKey DygnLength_Medium
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_Medium));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_Medium)) = value;
    }
  }

  public unsafe LocalizationKey DygnLength_Long
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_Long));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_Long)) = value;
    }
  }

  public unsafe LocalizationKey DygnLength_SwedishSummer
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_SwedishSummer));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_DygnLength_SwedishSummer)) = value;
    }
  }

  public unsafe BloodHuntsDataAuthoring BloodHuntsDataAuthoring
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_BloodHuntsDataAuthoring));
      return pointer == System.IntPtr.Zero ? (BloodHuntsDataAuthoring) null : new BloodHuntsDataAuthoring(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_BloodHuntsDataAuthoring), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.ResearchStationMapping> ResearchStations
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ResearchStations));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.ResearchStationMapping>) null : new List<GameBalanceSettingsMapping.ResearchStationMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_ResearchStations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AchievementsCollection AchievementsCollection
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_AchievementsCollection));
      return pointer == System.IntPtr.Zero ? (AchievementsCollection) null : new AchievementsCollection(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_AchievementsCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameBalanceSettingsMapping.SettingPreset> SettingPresets
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_SettingPresets));
      return pointer == System.IntPtr.Zero ? (List<GameBalanceSettingsMapping.SettingPreset>) null : new List<GameBalanceSettingsMapping.SettingPreset>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.NativeFieldInfoPtr_SettingPresets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class SettingMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Identifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tooltip;

    static SettingMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (SettingMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.SettingMapping.NativeFieldInfoPtr_Identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingMapping>.NativeClassPtr, nameof (Identifier));
      GameBalanceSettingsMapping.SettingMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingMapping>.NativeClassPtr, nameof (Name));
      GameBalanceSettingsMapping.SettingMapping.NativeFieldInfoPtr_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingMapping>.NativeClassPtr, nameof (Tooltip));
    }

    public SettingMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SettingMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingMapping>.NativeClassPtr, data));
    }

    public unsafe string Identifier
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingMapping.NativeFieldInfoPtr_Identifier)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingMapping.NativeFieldInfoPtr_Identifier), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingMapping.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingMapping.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe LocalizationKey Tooltip
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingMapping.NativeFieldInfoPtr_Tooltip));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingMapping.NativeFieldInfoPtr_Tooltip)) = value;
      }
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct GameModeNameMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public GameModeType GameMode;
    [FieldOffset(4)]
    public LocalizationKey Name;

    static GameModeNameMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.GameModeNameMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (GameModeNameMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.GameModeNameMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.GameModeNameMapping.NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.GameModeNameMapping>.NativeClassPtr, nameof (GameMode));
      GameBalanceSettingsMapping.GameModeNameMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.GameModeNameMapping>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.GameModeNameMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct DeathContainerNameMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Permission;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public DeathContainerPermission Permission;
    [FieldOffset(4)]
    public LocalizationKey Name;

    static DeathContainerNameMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.DeathContainerNameMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (DeathContainerNameMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.DeathContainerNameMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.DeathContainerNameMapping.NativeFieldInfoPtr_Permission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.DeathContainerNameMapping>.NativeClassPtr, nameof (Permission));
      GameBalanceSettingsMapping.DeathContainerNameMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.DeathContainerNameMapping>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.DeathContainerNameMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct TimeZoneNameMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeZone;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public GameTimeZone TimeZone;
    [FieldOffset(4)]
    public LocalizationKey Name;

    static TimeZoneNameMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.TimeZoneNameMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (TimeZoneNameMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.TimeZoneNameMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.TimeZoneNameMapping.NativeFieldInfoPtr_TimeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.TimeZoneNameMapping>.NativeClassPtr, nameof (TimeZone));
      GameBalanceSettingsMapping.TimeZoneNameMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.TimeZoneNameMapping>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.TimeZoneNameMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodFountainDestroyModeMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public CastleHeartDamageMode CastleHeartDamageMode;
    [FieldOffset(4)]
    public LocalizationKey Name;

    static BloodFountainDestroyModeMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (BloodFountainDestroyModeMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.BloodFountainDestroyModeMapping.NativeFieldInfoPtr_CastleHeartDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping>.NativeClassPtr, nameof (CastleHeartDamageMode));
      GameBalanceSettingsMapping.BloodFountainDestroyModeMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.BloodFountainDestroyModeMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleDestroyModeMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public CastleDamageMode CastleDamageMode;
    [FieldOffset(4)]
    public LocalizationKey Name;

    static CastleDestroyModeMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.CastleDestroyModeMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (CastleDestroyModeMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.CastleDestroyModeMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.CastleDestroyModeMapping.NativeFieldInfoPtr_CastleDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.CastleDestroyModeMapping>.NativeClassPtr, nameof (CastleDamageMode));
      GameBalanceSettingsMapping.CastleDestroyModeMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.CastleDestroyModeMapping>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.CastleDestroyModeMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct PvPProtectionModeMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectionMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public PvPProtectionMode PvPProtectionMode;
    [FieldOffset(4)]
    public LocalizationKey Name;

    static PvPProtectionModeMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.PvPProtectionModeMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (PvPProtectionModeMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.PvPProtectionModeMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.PvPProtectionModeMapping.NativeFieldInfoPtr_PvPProtectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.PvPProtectionModeMapping>.NativeClassPtr, nameof (PvPProtectionMode));
      GameBalanceSettingsMapping.PvPProtectionModeMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.PvPProtectionModeMapping>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.PvPProtectionModeMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct SiegeWeaponHealthMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegeWeaponHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public ProjectM.SiegeWeaponHealth SiegeWeaponHealth;
    [FieldOffset(4)]
    public LocalizationKey Name;

    static SiegeWeaponHealthMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.SiegeWeaponHealthMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (SiegeWeaponHealthMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.SiegeWeaponHealthMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.SiegeWeaponHealthMapping.NativeFieldInfoPtr_SiegeWeaponHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.SiegeWeaponHealthMapping>.NativeClassPtr, nameof (SiegeWeaponHealth));
      GameBalanceSettingsMapping.SiegeWeaponHealthMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.SiegeWeaponHealthMapping>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.SiegeWeaponHealthMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct PlayerDamageModeMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public PlayerDamageMode CastleDamageMode;
    [FieldOffset(4)]
    public LocalizationKey Name;

    static PlayerDamageModeMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.PlayerDamageModeMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (PlayerDamageModeMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.PlayerDamageModeMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.PlayerDamageModeMapping.NativeFieldInfoPtr_CastleDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.PlayerDamageModeMapping>.NativeClassPtr, nameof (CastleDamageMode));
      GameBalanceSettingsMapping.PlayerDamageModeMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.PlayerDamageModeMapping>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.PlayerDamageModeMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct RelicTypeMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RelicSpawnType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public RelicSpawnType RelicSpawnType;
    [FieldOffset(4)]
    public LocalizationKey Name;

    static RelicTypeMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.RelicTypeMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (RelicTypeMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.RelicTypeMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.RelicTypeMapping.NativeFieldInfoPtr_RelicSpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.RelicTypeMapping>.NativeClassPtr, nameof (RelicSpawnType));
      GameBalanceSettingsMapping.RelicTypeMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.RelicTypeMapping>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.RelicTypeMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  public sealed class ItemSetMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemSet;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;

    static ItemSetMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.ItemSetMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (ItemSetMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.ItemSetMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.ItemSetMapping.NativeFieldInfoPtr_ItemSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.ItemSetMapping>.NativeClassPtr, nameof (ItemSet));
      GameBalanceSettingsMapping.ItemSetMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.ItemSetMapping>.NativeClassPtr, nameof (Name));
    }

    public ItemSetMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ItemSetMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameBalanceSettingsMapping.ItemSetMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.ItemSetMapping>.NativeClassPtr, data));
    }

    public unsafe WeakAssetReference<ItemSetAsset> ItemSet
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.ItemSetMapping.NativeFieldInfoPtr_ItemSet));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemSetAsset>) null : new WeakAssetReference<ItemSetAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.ItemSetMapping.NativeFieldInfoPtr_ItemSet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.ItemSetMapping.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.ItemSetMapping.NativeFieldInfoPtr_Name)) = value;
      }
    }
  }

  [Serializable]
  public sealed class SettingPreset : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;

    static SettingPreset()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingPreset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (SettingPreset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingPreset>.NativeClassPtr);
      GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingPreset>.NativeClassPtr, nameof (Disabled));
      GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_TextAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingPreset>.NativeClassPtr, nameof (TextAsset));
      GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingPreset>.NativeClassPtr, nameof (Name));
      GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingPreset>.NativeClassPtr, nameof (Description));
    }

    public SettingPreset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SettingPreset()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingPreset>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.SettingPreset>.NativeClassPtr, data));
    }

    public unsafe bool Disabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_Disabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_Disabled)) = value;
      }
    }

    public unsafe TextAsset TextAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_TextAsset));
        return pointer == System.IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_TextAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe LocalizationKey Description
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_Description));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.SettingPreset.NativeFieldInfoPtr_Description)) = value;
      }
    }
  }

  [Serializable]
  public sealed class ResearchStationMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchStationPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;

    static ResearchStationMapping()
    {
      Il2CppClassPointerStore<GameBalanceSettingsMapping.ResearchStationMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBalanceSettingsMapping>.NativeClassPtr, nameof (ResearchStationMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBalanceSettingsMapping.ResearchStationMapping>.NativeClassPtr);
      GameBalanceSettingsMapping.ResearchStationMapping.NativeFieldInfoPtr_ResearchStationPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.ResearchStationMapping>.NativeClassPtr, nameof (ResearchStationPrefab));
      GameBalanceSettingsMapping.ResearchStationMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBalanceSettingsMapping.ResearchStationMapping>.NativeClassPtr, nameof (Name));
    }

    public ResearchStationMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ResearchStationMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameBalanceSettingsMapping.ResearchStationMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameBalanceSettingsMapping.ResearchStationMapping>.NativeClassPtr, data));
    }

    public unsafe WeakAssetReference<ResearchstationAuthoring> ResearchStationPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.ResearchStationMapping.NativeFieldInfoPtr_ResearchStationPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<ResearchstationAuthoring>) null : new WeakAssetReference<ResearchstationAuthoring>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.ResearchStationMapping.NativeFieldInfoPtr_ResearchStationPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.ResearchStationMapping.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBalanceSettingsMapping.ResearchStationMapping.NativeFieldInfoPtr_Name)) = value;
      }
    }
  }
}
