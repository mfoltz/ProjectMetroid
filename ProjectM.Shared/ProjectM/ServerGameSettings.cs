// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerGameSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ServerGameSettings : SettingsBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegeWeaponHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectionMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeathContainerPermission;
    private static readonly System.IntPtr NativeFieldInfoPtr_RelicSpawnType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanLootEnemyContainers;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodBoundEquipment;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBoundItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowGlobalChat;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllWaypointsUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeCastleRaid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeCastleClaim;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeCastleDestroy;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactivityKillEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactivityKillTimeMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactivityKillTimeMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactivityKillSafeTimeAddition;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactivityKillTimerMaxItemLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableDisconnectedDeadEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableDisconnectedDeadTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisconnectedSunImmunityTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryStacksModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTableModifier_General;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTableModifier_Missions;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialYieldModifier_Global;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodEssenceYieldModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_JournalVBloodSourceUnitMaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPVampireRespawnModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleMinimumDistanceInFloors;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodDrainModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurabilityDrainModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_GarlicAreaStrengthModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_HolyAreaStrengthModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SilverStrengthModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SunDamageModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleDecayRateModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleBloodEssenceDrainModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleSiegeTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleUnderAttackTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRaidTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRaidProtectionTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleExposedFreeClaimTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnnounceSiegeWeaponSpawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowSiegeWeaponMapIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipeCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftRateModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefinementCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefinementRateModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchTimeModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleResourceModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantConvertRateModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Death_DurabilityFactorLoss;
    private static readonly System.IntPtr NativeFieldInfoPtr_Death_DurabilityLossFactorAsResources;
    private static readonly System.IntPtr NativeFieldInfoPtr_StarterEquipmentId;
    private static readonly System.IntPtr NativeFieldInfoPtr_StarterResourcesId;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodUnitSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedAchievements;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedResearchs;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameTimeModifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_VampireStatModifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStatModifiers_Global;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStatModifiers_VBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentStatModifiers_Global;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleStatModifiers_Global;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomizeVBloodAbilities;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomizeVBloodTechs;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomizeVBloodSpawnLocations;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInteractionSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_TraderModifiers;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Verbose_Public_Virtual_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToTemplateHash_Public_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToTemplateHash_Public_String_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToStruct_Public_ServerGameBalanceSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHardCore_Public_Boolean_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 757658, RefRangeEnd = 757664, XrefRangeStart = 757552, XrefRangeEnd = 757658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerGameSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 757770, RefRangeEnd = 757772, XrefRangeStart = 757664, XrefRangeEnd = 757770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerGameSettings(bool loadDefault)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &loadDefault;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameSettings.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public override unsafe bool Verbose
    {
      [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerGameSettings.NativeMethodInfoPtr_get_Verbose_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 757777, RefRangeEnd = 757781, XrefRangeStart = 757772, XrefRangeEnd = 757777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string ToTemplateHash()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerGameSettings.NativeMethodInfoPtr_ToTemplateHash_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757781, XrefRangeEnd = 757787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string ToTemplateHash(out string json)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerGameSettings.NativeMethodInfoPtr_ToTemplateHash_Public_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      json = IL2CPP.Il2CppStringToManaged(zero);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 757879, RefRangeEnd = 757885, XrefRangeStart = 757787, XrefRangeEnd = 757879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameSettings.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 758053, RefRangeEnd = 758059, XrefRangeStart = 757885, XrefRangeEnd = 758053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerGameBalanceSettings ToStruct()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameSettings.NativeMethodInfoPtr_ToStruct_Public_ServerGameBalanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerGameBalanceSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 758059, RefRangeEnd = 758061, XrefRangeStart = 758059, XrefRangeEnd = 758059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHardCore()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameSettings.NativeMethodInfoPtr_IsHardCore_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServerGameSettings()
    {
      Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServerGameSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr);
      ServerGameSettings.NativeFieldInfoPtr_DefaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (DefaultPath));
      ServerGameSettings.NativeFieldInfoPtr_LocalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (LocalPath));
      ServerGameSettings.NativeFieldInfoPtr_GameModeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (GameModeType));
      ServerGameSettings.NativeFieldInfoPtr_CastleDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleDamageMode));
      ServerGameSettings.NativeFieldInfoPtr_SiegeWeaponHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (SiegeWeaponHealth));
      ServerGameSettings.NativeFieldInfoPtr_PlayerDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (PlayerDamageMode));
      ServerGameSettings.NativeFieldInfoPtr_CastleHeartDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleHeartDamageMode));
      ServerGameSettings.NativeFieldInfoPtr_PvPProtectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (PvPProtectionMode));
      ServerGameSettings.NativeFieldInfoPtr_DeathContainerPermission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (DeathContainerPermission));
      ServerGameSettings.NativeFieldInfoPtr_RelicSpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (RelicSpawnType));
      ServerGameSettings.NativeFieldInfoPtr_CanLootEnemyContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CanLootEnemyContainers));
      ServerGameSettings.NativeFieldInfoPtr_BloodBoundEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (BloodBoundEquipment));
      ServerGameSettings.NativeFieldInfoPtr_TeleportBoundItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (TeleportBoundItems));
      ServerGameSettings.NativeFieldInfoPtr_AllowGlobalChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (AllowGlobalChat));
      ServerGameSettings.NativeFieldInfoPtr_AllWaypointsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (AllWaypointsUnlocked));
      ServerGameSettings.NativeFieldInfoPtr_FreeCastleRaid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (FreeCastleRaid));
      ServerGameSettings.NativeFieldInfoPtr_FreeCastleClaim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (FreeCastleClaim));
      ServerGameSettings.NativeFieldInfoPtr_FreeCastleDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (FreeCastleDestroy));
      ServerGameSettings.NativeFieldInfoPtr_InactivityKillEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (InactivityKillEnabled));
      ServerGameSettings.NativeFieldInfoPtr_InactivityKillTimeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (InactivityKillTimeMin));
      ServerGameSettings.NativeFieldInfoPtr_InactivityKillTimeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (InactivityKillTimeMax));
      ServerGameSettings.NativeFieldInfoPtr_InactivityKillSafeTimeAddition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (InactivityKillSafeTimeAddition));
      ServerGameSettings.NativeFieldInfoPtr_InactivityKillTimerMaxItemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (InactivityKillTimerMaxItemLevel));
      ServerGameSettings.NativeFieldInfoPtr_DisableDisconnectedDeadEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (DisableDisconnectedDeadEnabled));
      ServerGameSettings.NativeFieldInfoPtr_DisableDisconnectedDeadTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (DisableDisconnectedDeadTimer));
      ServerGameSettings.NativeFieldInfoPtr_DisconnectedSunImmunityTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (DisconnectedSunImmunityTime));
      ServerGameSettings.NativeFieldInfoPtr_InventoryStacksModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (InventoryStacksModifier));
      ServerGameSettings.NativeFieldInfoPtr_DropTableModifier_General = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (DropTableModifier_General));
      ServerGameSettings.NativeFieldInfoPtr_DropTableModifier_Missions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (DropTableModifier_Missions));
      ServerGameSettings.NativeFieldInfoPtr_MaterialYieldModifier_Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (MaterialYieldModifier_Global));
      ServerGameSettings.NativeFieldInfoPtr_BloodEssenceYieldModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (BloodEssenceYieldModifier));
      ServerGameSettings.NativeFieldInfoPtr_JournalVBloodSourceUnitMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (JournalVBloodSourceUnitMaxDistance));
      ServerGameSettings.NativeFieldInfoPtr_PvPVampireRespawnModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (PvPVampireRespawnModifier));
      ServerGameSettings.NativeFieldInfoPtr_CastleMinimumDistanceInFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleMinimumDistanceInFloors));
      ServerGameSettings.NativeFieldInfoPtr_ClanSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (ClanSize));
      ServerGameSettings.NativeFieldInfoPtr_BloodDrainModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (BloodDrainModifier));
      ServerGameSettings.NativeFieldInfoPtr_DurabilityDrainModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (DurabilityDrainModifier));
      ServerGameSettings.NativeFieldInfoPtr_GarlicAreaStrengthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (GarlicAreaStrengthModifier));
      ServerGameSettings.NativeFieldInfoPtr_HolyAreaStrengthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (HolyAreaStrengthModifier));
      ServerGameSettings.NativeFieldInfoPtr_SilverStrengthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (SilverStrengthModifier));
      ServerGameSettings.NativeFieldInfoPtr_SunDamageModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (SunDamageModifier));
      ServerGameSettings.NativeFieldInfoPtr_CastleDecayRateModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleDecayRateModifier));
      ServerGameSettings.NativeFieldInfoPtr_CastleBloodEssenceDrainModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleBloodEssenceDrainModifier));
      ServerGameSettings.NativeFieldInfoPtr_CastleSiegeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleSiegeTimer));
      ServerGameSettings.NativeFieldInfoPtr_CastleUnderAttackTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleUnderAttackTimer));
      ServerGameSettings.NativeFieldInfoPtr_CastleRaidTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleRaidTimer));
      ServerGameSettings.NativeFieldInfoPtr_CastleRaidProtectionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleRaidProtectionTime));
      ServerGameSettings.NativeFieldInfoPtr_CastleExposedFreeClaimTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleExposedFreeClaimTimer));
      ServerGameSettings.NativeFieldInfoPtr_AnnounceSiegeWeaponSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (AnnounceSiegeWeaponSpawn));
      ServerGameSettings.NativeFieldInfoPtr_ShowSiegeWeaponMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (ShowSiegeWeaponMapIcon));
      ServerGameSettings.NativeFieldInfoPtr_BuildCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (BuildCostModifier));
      ServerGameSettings.NativeFieldInfoPtr_RecipeCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (RecipeCostModifier));
      ServerGameSettings.NativeFieldInfoPtr_CraftRateModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CraftRateModifier));
      ServerGameSettings.NativeFieldInfoPtr_ResearchCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (ResearchCostModifier));
      ServerGameSettings.NativeFieldInfoPtr_RefinementCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (RefinementCostModifier));
      ServerGameSettings.NativeFieldInfoPtr_RefinementRateModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (RefinementRateModifier));
      ServerGameSettings.NativeFieldInfoPtr_ResearchTimeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (ResearchTimeModifier));
      ServerGameSettings.NativeFieldInfoPtr_DismantleResourceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (DismantleResourceModifier));
      ServerGameSettings.NativeFieldInfoPtr_ServantConvertRateModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (ServantConvertRateModifier));
      ServerGameSettings.NativeFieldInfoPtr_RepairCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (RepairCostModifier));
      ServerGameSettings.NativeFieldInfoPtr_Death_DurabilityFactorLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (Death_DurabilityFactorLoss));
      ServerGameSettings.NativeFieldInfoPtr_Death_DurabilityLossFactorAsResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (Death_DurabilityLossFactorAsResources));
      ServerGameSettings.NativeFieldInfoPtr_StarterEquipmentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (StarterEquipmentId));
      ServerGameSettings.NativeFieldInfoPtr_StarterResourcesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (StarterResourcesId));
      ServerGameSettings.NativeFieldInfoPtr_VBloodUnitSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (VBloodUnitSettings));
      ServerGameSettings.NativeFieldInfoPtr_UnlockedAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (UnlockedAchievements));
      ServerGameSettings.NativeFieldInfoPtr_UnlockedResearchs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (UnlockedResearchs));
      ServerGameSettings.NativeFieldInfoPtr_GameTimeModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (GameTimeModifiers));
      ServerGameSettings.NativeFieldInfoPtr_VampireStatModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (VampireStatModifiers));
      ServerGameSettings.NativeFieldInfoPtr_UnitStatModifiers_Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (UnitStatModifiers_Global));
      ServerGameSettings.NativeFieldInfoPtr_UnitStatModifiers_VBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (UnitStatModifiers_VBlood));
      ServerGameSettings.NativeFieldInfoPtr_EquipmentStatModifiers_Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (EquipmentStatModifiers_Global));
      ServerGameSettings.NativeFieldInfoPtr_CastleStatModifiers_Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (CastleStatModifiers_Global));
      ServerGameSettings.NativeFieldInfoPtr_RandomizeVBloodAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (RandomizeVBloodAbilities));
      ServerGameSettings.NativeFieldInfoPtr_RandomizeVBloodTechs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (RandomizeVBloodTechs));
      ServerGameSettings.NativeFieldInfoPtr_RandomizeVBloodSpawnLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (RandomizeVBloodSpawnLocations));
      ServerGameSettings.NativeFieldInfoPtr_PlayerInteractionSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (PlayerInteractionSettings));
      ServerGameSettings.NativeFieldInfoPtr_TraderModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, nameof (TraderModifiers));
      ServerGameSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, 100666897);
      ServerGameSettings.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, 100666898);
      ServerGameSettings.NativeMethodInfoPtr_get_Verbose_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, 100666899);
      ServerGameSettings.NativeMethodInfoPtr_ToTemplateHash_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, 100666900);
      ServerGameSettings.NativeMethodInfoPtr_ToTemplateHash_Public_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, 100666901);
      ServerGameSettings.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, 100666902);
      ServerGameSettings.NativeMethodInfoPtr_ToStruct_Public_ServerGameBalanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, 100666903);
      ServerGameSettings.NativeMethodInfoPtr_IsHardCore_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettings>.NativeClassPtr, 100666904);
    }

    public ServerGameSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DefaultPath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ServerGameSettings.NativeFieldInfoPtr_DefaultPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerGameSettings.NativeFieldInfoPtr_DefaultPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string LocalPath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ServerGameSettings.NativeFieldInfoPtr_LocalPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerGameSettings.NativeFieldInfoPtr_LocalPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GameModeType GameModeType
    {
      get
      {
        return *(GameModeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_GameModeType));
      }
      [param: In] set
      {
        *(GameModeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_GameModeType)) = value;
      }
    }

    public unsafe CastleDamageMode CastleDamageMode
    {
      get
      {
        return *(CastleDamageMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleDamageMode));
      }
      [param: In] set
      {
        *(CastleDamageMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleDamageMode)) = value;
      }
    }

    public unsafe SiegeWeaponHealth SiegeWeaponHealth
    {
      get
      {
        return *(SiegeWeaponHealth*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_SiegeWeaponHealth));
      }
      [param: In] set
      {
        *(SiegeWeaponHealth*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_SiegeWeaponHealth)) = value;
      }
    }

    public unsafe PlayerDamageMode PlayerDamageMode
    {
      get
      {
        return *(PlayerDamageMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_PlayerDamageMode));
      }
      [param: In] set
      {
        *(PlayerDamageMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_PlayerDamageMode)) = value;
      }
    }

    public unsafe CastleHeartDamageMode CastleHeartDamageMode
    {
      get
      {
        return *(CastleHeartDamageMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleHeartDamageMode));
      }
      [param: In] set
      {
        *(CastleHeartDamageMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleHeartDamageMode)) = value;
      }
    }

    public unsafe PvPProtectionMode PvPProtectionMode
    {
      get
      {
        return *(PvPProtectionMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_PvPProtectionMode));
      }
      [param: In] set
      {
        *(PvPProtectionMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_PvPProtectionMode)) = value;
      }
    }

    public unsafe DeathContainerPermission DeathContainerPermission
    {
      get
      {
        return *(DeathContainerPermission*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DeathContainerPermission));
      }
      [param: In] set
      {
        *(DeathContainerPermission*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DeathContainerPermission)) = value;
      }
    }

    public unsafe RelicSpawnType RelicSpawnType
    {
      get
      {
        return *(RelicSpawnType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RelicSpawnType));
      }
      [param: In] set
      {
        *(RelicSpawnType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RelicSpawnType)) = value;
      }
    }

    public unsafe bool CanLootEnemyContainers
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CanLootEnemyContainers));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CanLootEnemyContainers)) = value;
      }
    }

    public unsafe bool BloodBoundEquipment
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_BloodBoundEquipment));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_BloodBoundEquipment)) = value;
      }
    }

    public unsafe bool TeleportBoundItems
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_TeleportBoundItems));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_TeleportBoundItems)) = value;
      }
    }

    public unsafe bool AllowGlobalChat
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_AllowGlobalChat));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_AllowGlobalChat)) = value;
      }
    }

    public unsafe bool AllWaypointsUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_AllWaypointsUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_AllWaypointsUnlocked)) = value;
      }
    }

    public unsafe bool FreeCastleRaid
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_FreeCastleRaid));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_FreeCastleRaid)) = value;
      }
    }

    public unsafe bool FreeCastleClaim
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_FreeCastleClaim));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_FreeCastleClaim)) = value;
      }
    }

    public unsafe bool FreeCastleDestroy
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_FreeCastleDestroy));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_FreeCastleDestroy)) = value;
      }
    }

    public unsafe bool InactivityKillEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InactivityKillEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InactivityKillEnabled)) = value;
      }
    }

    public unsafe int InactivityKillTimeMin
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InactivityKillTimeMin));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InactivityKillTimeMin)) = value;
      }
    }

    public unsafe int InactivityKillTimeMax
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InactivityKillTimeMax));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InactivityKillTimeMax)) = value;
      }
    }

    public unsafe int InactivityKillSafeTimeAddition
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InactivityKillSafeTimeAddition));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InactivityKillSafeTimeAddition)) = value;
      }
    }

    public unsafe int InactivityKillTimerMaxItemLevel
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InactivityKillTimerMaxItemLevel));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InactivityKillTimerMaxItemLevel)) = value;
      }
    }

    public unsafe bool DisableDisconnectedDeadEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DisableDisconnectedDeadEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DisableDisconnectedDeadEnabled)) = value;
      }
    }

    public unsafe int DisableDisconnectedDeadTimer
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DisableDisconnectedDeadTimer));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DisableDisconnectedDeadTimer)) = value;
      }
    }

    public unsafe float DisconnectedSunImmunityTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DisconnectedSunImmunityTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DisconnectedSunImmunityTime)) = value;
      }
    }

    public unsafe float InventoryStacksModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InventoryStacksModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_InventoryStacksModifier)) = value;
      }
    }

    public unsafe float DropTableModifier_General
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DropTableModifier_General));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DropTableModifier_General)) = value;
      }
    }

    public unsafe float DropTableModifier_Missions
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DropTableModifier_Missions));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DropTableModifier_Missions)) = value;
      }
    }

    public unsafe float MaterialYieldModifier_Global
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_MaterialYieldModifier_Global));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_MaterialYieldModifier_Global)) = value;
      }
    }

    public unsafe float BloodEssenceYieldModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_BloodEssenceYieldModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_BloodEssenceYieldModifier)) = value;
      }
    }

    public unsafe float JournalVBloodSourceUnitMaxDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_JournalVBloodSourceUnitMaxDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_JournalVBloodSourceUnitMaxDistance)) = value;
      }
    }

    public unsafe float PvPVampireRespawnModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_PvPVampireRespawnModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_PvPVampireRespawnModifier)) = value;
      }
    }

    public unsafe byte CastleMinimumDistanceInFloors
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleMinimumDistanceInFloors));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleMinimumDistanceInFloors)) = value;
      }
    }

    public unsafe int ClanSize
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_ClanSize));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_ClanSize)) = value;
      }
    }

    public unsafe float BloodDrainModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_BloodDrainModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_BloodDrainModifier)) = value;
      }
    }

    public unsafe float DurabilityDrainModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DurabilityDrainModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DurabilityDrainModifier)) = value;
      }
    }

    public unsafe float GarlicAreaStrengthModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_GarlicAreaStrengthModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_GarlicAreaStrengthModifier)) = value;
      }
    }

    public unsafe float HolyAreaStrengthModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_HolyAreaStrengthModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_HolyAreaStrengthModifier)) = value;
      }
    }

    public unsafe float SilverStrengthModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_SilverStrengthModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_SilverStrengthModifier)) = value;
      }
    }

    public unsafe float SunDamageModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_SunDamageModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_SunDamageModifier)) = value;
      }
    }

    public unsafe float CastleDecayRateModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleDecayRateModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleDecayRateModifier)) = value;
      }
    }

    public unsafe float CastleBloodEssenceDrainModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleBloodEssenceDrainModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleBloodEssenceDrainModifier)) = value;
      }
    }

    public unsafe float CastleSiegeTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleSiegeTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleSiegeTimer)) = value;
      }
    }

    public unsafe float CastleUnderAttackTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleUnderAttackTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleUnderAttackTimer)) = value;
      }
    }

    public unsafe float CastleRaidTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleRaidTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleRaidTimer)) = value;
      }
    }

    public unsafe float CastleRaidProtectionTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleRaidProtectionTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleRaidProtectionTime)) = value;
      }
    }

    public unsafe float CastleExposedFreeClaimTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleExposedFreeClaimTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleExposedFreeClaimTimer)) = value;
      }
    }

    public unsafe bool AnnounceSiegeWeaponSpawn
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_AnnounceSiegeWeaponSpawn));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_AnnounceSiegeWeaponSpawn)) = value;
      }
    }

    public unsafe bool ShowSiegeWeaponMapIcon
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_ShowSiegeWeaponMapIcon));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_ShowSiegeWeaponMapIcon)) = value;
      }
    }

    public unsafe float BuildCostModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_BuildCostModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_BuildCostModifier)) = value;
      }
    }

    public unsafe float RecipeCostModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RecipeCostModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RecipeCostModifier)) = value;
      }
    }

    public unsafe float CraftRateModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CraftRateModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CraftRateModifier)) = value;
      }
    }

    public unsafe float ResearchCostModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_ResearchCostModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_ResearchCostModifier)) = value;
      }
    }

    public unsafe float RefinementCostModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RefinementCostModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RefinementCostModifier)) = value;
      }
    }

    public unsafe float RefinementRateModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RefinementRateModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RefinementRateModifier)) = value;
      }
    }

    public unsafe float ResearchTimeModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_ResearchTimeModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_ResearchTimeModifier)) = value;
      }
    }

    public unsafe float DismantleResourceModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DismantleResourceModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_DismantleResourceModifier)) = value;
      }
    }

    public unsafe float ServantConvertRateModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_ServantConvertRateModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_ServantConvertRateModifier)) = value;
      }
    }

    public unsafe float RepairCostModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RepairCostModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RepairCostModifier)) = value;
      }
    }

    public unsafe float Death_DurabilityFactorLoss
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_Death_DurabilityFactorLoss));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_Death_DurabilityFactorLoss)) = value;
      }
    }

    public unsafe float Death_DurabilityLossFactorAsResources
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_Death_DurabilityLossFactorAsResources));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_Death_DurabilityLossFactorAsResources)) = value;
      }
    }

    public unsafe int StarterEquipmentId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_StarterEquipmentId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_StarterEquipmentId)) = value;
      }
    }

    public unsafe int StarterResourcesId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_StarterResourcesId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_StarterResourcesId)) = value;
      }
    }

    public unsafe List<VBloodUnitSetting> VBloodUnitSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_VBloodUnitSettings));
        return pointer == System.IntPtr.Zero ? (List<VBloodUnitSetting>) null : new List<VBloodUnitSetting>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_VBloodUnitSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> UnlockedAchievements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_UnlockedAchievements));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_UnlockedAchievements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> UnlockedResearchs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_UnlockedResearchs));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_UnlockedResearchs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameTimeModifiers GameTimeModifiers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_GameTimeModifiers));
        return pointer == System.IntPtr.Zero ? (GameTimeModifiers) null : new GameTimeModifiers(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_GameTimeModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VampireStatModifiers VampireStatModifiers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_VampireStatModifiers));
        return pointer == System.IntPtr.Zero ? (VampireStatModifiers) null : new VampireStatModifiers(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_VampireStatModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitStatModifiers UnitStatModifiers_Global
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_UnitStatModifiers_Global));
        return pointer == System.IntPtr.Zero ? (UnitStatModifiers) null : new UnitStatModifiers(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_UnitStatModifiers_Global), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitStatModifiers UnitStatModifiers_VBlood
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_UnitStatModifiers_VBlood));
        return pointer == System.IntPtr.Zero ? (UnitStatModifiers) null : new UnitStatModifiers(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_UnitStatModifiers_VBlood), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EquipmentStatModifiers EquipmentStatModifiers_Global
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_EquipmentStatModifiers_Global));
        return pointer == System.IntPtr.Zero ? (EquipmentStatModifiers) null : new EquipmentStatModifiers(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_EquipmentStatModifiers_Global), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleStatModifiersEditor CastleStatModifiers_Global
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleStatModifiers_Global));
        return pointer == System.IntPtr.Zero ? (CastleStatModifiersEditor) null : new CastleStatModifiersEditor(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_CastleStatModifiers_Global), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool RandomizeVBloodAbilities
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RandomizeVBloodAbilities));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RandomizeVBloodAbilities)) = value;
      }
    }

    public unsafe bool RandomizeVBloodTechs
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RandomizeVBloodTechs));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RandomizeVBloodTechs)) = value;
      }
    }

    public unsafe bool RandomizeVBloodSpawnLocations
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RandomizeVBloodSpawnLocations));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_RandomizeVBloodSpawnLocations)) = value;
      }
    }

    public unsafe PlayerInteractionSettings PlayerInteractionSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_PlayerInteractionSettings));
        return pointer == System.IntPtr.Zero ? (PlayerInteractionSettings) null : new PlayerInteractionSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_PlayerInteractionSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TraderModifiers TraderModifiers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_TraderModifiers));
        return pointer == System.IntPtr.Zero ? (TraderModifiers) null : new TraderModifiers(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettings.NativeFieldInfoPtr_TraderModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
