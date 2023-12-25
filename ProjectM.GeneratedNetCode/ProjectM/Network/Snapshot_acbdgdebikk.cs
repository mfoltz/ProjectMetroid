// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acbdgdebikk
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_acbdgdebikk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_CastAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_CastAbilityPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_CastGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_CastGroupPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_CastStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_CastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_CooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_GlobalCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_InterruptTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_LimitAbilityPriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_PostCastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_PrimaryCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_ServerCastCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_ServerInterruptCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_SpellCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_TravelCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_Shared_WeaponCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagHolder_BagInstance0Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagHolder_BagInstance0InventoryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagHolder_BagInstance1Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagHolder_BagInstance1InventoryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagHolder_BagInstance2Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagHolder_BagInstance2InventoryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagHolder_BagInstance3Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagHolder_BagInstance3InventoryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagHolder_BagSlots;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blood_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blood_MaxBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blood_Quality;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blood_ShowBloodHUD;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blood_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanFly_FlyingHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanFly_HeightAboveObstacle;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterVoiceActivity_IsSpeaking;
    private static readonly System.IntPtr NativeFieldInfoPtr_CombatMusicListener_Shared_PlayOutro;
    private static readonly System.IntPtr NativeFieldInfoPtr_CombatMusicListener_Shared_UnitPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationFeatures_AccessoriesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationFeatures_EyeColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationFeatures_FaceIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationFeatures_FeaturesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationFeatures_GenderIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationFeatures_HairColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationFeatures_HairStyleIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationFeatures_SkintoneIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeathRagdollForce_Force;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_RadiusVariation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Energy_GainPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_Energy_MaxEnergy;
    private static readonly System.IntPtr NativeFieldInfoPtr_Energy_RegainEnergyChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Energy_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorChestSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorChestSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorFootgearSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorFootgearSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorGlovesSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorGlovesSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorHeadgearSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorHeadgearSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorLegsSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorLegsSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ArmorLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_CloakSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_CloakSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ClothChestSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ClothChestSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ClothLegsSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_ClothLegsSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_GrimoireSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_GrimoireSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_SpellLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_WeaponLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_WeaponSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equipment_WeaponSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FallToHeight_Gravity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Height_ServerHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybridModelSeed_Seed;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSpellControlled_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeLeech_AffectRecovery;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeLeech_PhysicalLifeLeechFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeLeech_PrimaryLeechFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeLeech_SpellLifeLeechFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mounter_Acceleration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mounter_GallopMaxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mounter_GallopMaxSpeedMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mounter_TurnRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Movement_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_LastClientCommandTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerMoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_Simulate;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCharacter_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCharacter_SmartClanName;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnCharacter_IsReadyToRespawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnCharacter_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stealthable_IsStealthed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stealthable_ModelInvisible;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stealthable_StealthBushId;
    private static readonly System.IntPtr NativeFieldInfoPtr_TakeDamageInSun_SunDamageDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelToTargetRadius_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_AttackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_FireResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_GarlicResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_HealthRecovery;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_HolyResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_PassiveHealthRegen;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_PhysicalCriticalStrikeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_PhysicalCriticalStrikeDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_PhysicalPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_PhysicalResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_PrimaryAttackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_PvPProtected;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_PvPResilience;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_ReducedResourceDurabilityLoss;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_ResourcePower;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_ResourceYieldModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_SiegePower;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_SilverResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_SpellCriticalStrikeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_SpellCriticalStrikeDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_SpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_SpellResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats_SunResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Vision_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BagHolder_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BagHolder_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Blood_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Blood_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CanFly_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CanFly_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CharacterVoiceActivity_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CharacterVoiceActivity_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CombatMusicListener_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CombatMusicListener_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CustomizationFeatures_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CustomizationFeatures_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Energy_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Energy_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Equipment_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Equipment_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Height_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Height_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeLeech_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeLeech_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Mounter_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Mounter_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Movement_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Movement_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_PlayerCharacter_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_PlayerCharacter_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_RespawnCharacter_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_RespawnCharacter_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Stealthable_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Stealthable_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TakeDamageInSun_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TakeDamageInSun_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TravelToTargetRadius_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TravelToTargetRadius_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UnitStats_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UnitStats_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Vision_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Vision_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BagHolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Blood;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CanFly;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CharacterVoiceActivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Energy;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_FallToHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeLeech;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Mounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Stealthable;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TakeDamageInSun;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TravelToTargetRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Vision;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_FollowerBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InventoryInstanceElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance0Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance0InventoryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance1Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance1InventoryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance2Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance2InventoryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance3Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance3InventoryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagSlots;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Blood_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Blood_MaxBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Blood_Quality;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Blood_ShowBloodHUD;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Blood_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CanFly_FlyingHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CanFly_HeightAboveObstacle;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CharacterVoiceActivity_IsSpeaking;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared_PlayOutro;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared_UnitPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_AccessoriesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_EyeColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_FaceIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_FeaturesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_GenderIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_HairColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_HairStyleIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_SkintoneIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Energy_GainPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Energy_MaxEnergy;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Energy_RegainEnergyChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Energy_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorChestSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorChestSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorFootgearSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorFootgearSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorGlovesSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorGlovesSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorHeadgearSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorHeadgearSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLegsSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLegsSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_CloakSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_CloakSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothChestSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothChestSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothLegsSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothLegsSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_GrimoireSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_GrimoireSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_SpellLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponSlotEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_FallToHeight_Gravity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_AffectRecovery;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_PhysicalLifeLeechFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_PrimaryLeechFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_SpellLifeLeechFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Mounter_Acceleration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Mounter_GallopMaxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Mounter_GallopMaxSpeedMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Mounter_TurnRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter_SmartClanName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter_IsReadyToRespawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Stealthable_IsStealthed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Stealthable_ModelInvisible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Stealthable_StealthBushId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TakeDamageInSun_SunDamageDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TravelToTargetRadius_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_AttackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_FireResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_GarlicResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_HealthRecovery;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_HolyResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PassiveHealthRegen;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalCriticalStrikeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalCriticalStrikeDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PrimaryAttackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PvPProtected;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PvPResilience;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ReducedResourceDurabilityLoss;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ResourcePower;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ResourceYieldModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SiegePower;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SilverResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellCriticalStrikeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellCriticalStrikeDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SunResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Vision_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BagHolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BagHolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Blood;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Blood;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CanFly;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CanFly;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CharacterVoiceActivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CharacterVoiceActivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CombatMusicListener_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CombatMusicListener_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CustomizationFeatures;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CustomizationFeatures;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Energy;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Energy;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Equipment;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Equipment;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_FallToHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_FallToHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeLeech;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeLeech;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Mounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Mounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_PlayerCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_PlayerCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_RespawnCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_RespawnCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Stealthable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Stealthable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TakeDamageInSun;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TakeDamageInSun;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TravelToTargetRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TravelToTargetRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_UnitStats;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_UnitStats;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Vision;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Vision;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BagHolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Blood;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CanFly;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CharacterVoiceActivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CombatMusicListener_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CustomizationFeatures;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Energy;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Equipment;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_FallToHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeLeech;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Mounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_PlayerCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_RespawnCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Stealthable;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TakeDamageInSun;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TravelToTargetRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_UnitStats;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Vision;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_FollowerBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InventoryInstanceElement;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_FollowerBuffer_byref_BufferFromEntity_1_Snapshot_InventoryInstanceElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_FollowerBuffer_DynamicBuffer_1_Snapshot_InventoryInstanceElement_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public NetworkId AbilityBar_Shared_CastAbility;
    [FieldOffset(16)]
    public PrefabGUID AbilityBar_Shared_CastAbilityPrefabGuid;
    [FieldOffset(20)]
    public NetworkId AbilityBar_Shared_CastGroup;
    [FieldOffset(28)]
    public PrefabGUID AbilityBar_Shared_CastGroupPrefabGuid;
    [FieldOffset(32)]
    public double AbilityBar_Shared_CastStartTime;
    [FieldOffset(40)]
    public float AbilityBar_Shared_CastTime;
    [FieldOffset(44)]
    public ModifiableFloat AbilityBar_Shared_CooldownModifier;
    [FieldOffset(52)]
    public float AbilityBar_Shared_GlobalCooldown;
    [FieldOffset(56)]
    public InterruptTypes AbilityBar_Shared_InterruptTypes;
    [FieldOffset(60)]
    public ModifiableInt AbilityBar_Shared_LimitAbilityPriority;
    [FieldOffset(68)]
    public float AbilityBar_Shared_PostCastTime;
    [FieldOffset(72)]
    public ModifiableFloat AbilityBar_Shared_PrimaryCooldownModifier;
    [FieldOffset(80)]
    public int AbilityBar_Shared_ServerCastCounter;
    [FieldOffset(84)]
    public int AbilityBar_Shared_ServerInterruptCounter;
    [FieldOffset(88)]
    public ModifiableFloat AbilityBar_Shared_SpellCooldownModifier;
    [FieldOffset(96)]
    public ModifiableFloat AbilityBar_Shared_TravelCooldownModifier;
    [FieldOffset(104)]
    public ModifiableFloat AbilityBar_Shared_WeaponCooldownModifier;
    [FieldOffset(112)]
    public NetworkId BagHolder_BagInstance0Entity;
    [FieldOffset(120)]
    public int BagHolder_BagInstance0InventoryIndex;
    [FieldOffset(124)]
    public NetworkId BagHolder_BagInstance1Entity;
    [FieldOffset(132)]
    public int BagHolder_BagInstance1InventoryIndex;
    [FieldOffset(136)]
    public NetworkId BagHolder_BagInstance2Entity;
    [FieldOffset(144)]
    public int BagHolder_BagInstance2InventoryIndex;
    [FieldOffset(148)]
    public NetworkId BagHolder_BagInstance3Entity;
    [FieldOffset(156)]
    public int BagHolder_BagInstance3InventoryIndex;
    [FieldOffset(160)]
    public int BagHolder_BagSlots;
    [FieldOffset(164)]
    public PrefabGUID Blood_BloodType;
    [FieldOffset(168)]
    public ModifiableFloat Blood_MaxBlood;
    [FieldOffset(176)]
    public float Blood_Quality;
    [FieldOffset(180)]
    public ModifiableBool Blood_ShowBloodHUD;
    [FieldOffset(184)]
    public float Blood_Value;
    [FieldOffset(188)]
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(204)]
    public ModifiableFloat CanFly_FlyingHeight;
    [FieldOffset(212)]
    public ModifiableFloat CanFly_HeightAboveObstacle;
    [FieldOffset(220)]
    public bool CharacterVoiceActivity_IsSpeaking;
    [FieldOffset(221)]
    public bool CombatMusicListener_Shared_PlayOutro;
    [FieldOffset(222)]
    public PrefabGUID CombatMusicListener_Shared_UnitPrefabGuid;
    [FieldOffset(226)]
    public byte CustomizationFeatures_AccessoriesIndex;
    [FieldOffset(227)]
    public byte CustomizationFeatures_EyeColorIndex;
    [FieldOffset(228)]
    public byte CustomizationFeatures_FaceIndex;
    [FieldOffset(229)]
    public byte CustomizationFeatures_FeaturesIndex;
    [FieldOffset(230)]
    public byte CustomizationFeatures_GenderIndex;
    [FieldOffset(231)]
    public byte CustomizationFeatures_HairColorIndex;
    [FieldOffset(232)]
    public byte CustomizationFeatures_HairStyleIndex;
    [FieldOffset(233)]
    public byte CustomizationFeatures_SkintoneIndex;
    [FieldOffset(234)]
    public float3 DeathRagdollForce_Force;
    [FieldOffset(246)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_HardnessThreshold;
    [FieldOffset(254)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_PushStrengthMax;
    [FieldOffset(262)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_PushStrengthMin;
    [FieldOffset(270)]
    public ModifiableFloat DynamicCollision_AgainstUnits_HardnessThreshold;
    [FieldOffset(278)]
    public ModifiableFloat DynamicCollision_AgainstUnits_PushStrengthMax;
    [FieldOffset(286)]
    public ModifiableFloat DynamicCollision_AgainstUnits_PushStrengthMin;
    [FieldOffset(294)]
    public float DynamicCollision_AgainstUnits_RadiusVariation;
    [FieldOffset(298)]
    public ModifiableFloat Energy_GainPerSecond;
    [FieldOffset(306)]
    public ModifiableFloat Energy_MaxEnergy;
    [FieldOffset(314)]
    public ModifiableFloat Energy_RegainEnergyChance;
    [FieldOffset(322)]
    public float Energy_Value;
    [FieldOffset(326)]
    public NetworkId Equipment_ArmorChestSlotEntity;
    [FieldOffset(334)]
    public PrefabGUID Equipment_ArmorChestSlotId;
    [FieldOffset(338)]
    public NetworkId Equipment_ArmorFootgearSlotEntity;
    [FieldOffset(346)]
    public PrefabGUID Equipment_ArmorFootgearSlotId;
    [FieldOffset(350)]
    public NetworkId Equipment_ArmorGlovesSlotEntity;
    [FieldOffset(358)]
    public PrefabGUID Equipment_ArmorGlovesSlotId;
    [FieldOffset(362)]
    public NetworkId Equipment_ArmorHeadgearSlotEntity;
    [FieldOffset(370)]
    public PrefabGUID Equipment_ArmorHeadgearSlotId;
    [FieldOffset(374)]
    public NetworkId Equipment_ArmorLegsSlotEntity;
    [FieldOffset(382)]
    public PrefabGUID Equipment_ArmorLegsSlotId;
    [FieldOffset(386)]
    public ModifiableFloat Equipment_ArmorLevel;
    [FieldOffset(394)]
    public NetworkId Equipment_CloakSlotEntity;
    [FieldOffset(402)]
    public PrefabGUID Equipment_CloakSlotId;
    [FieldOffset(406)]
    public NetworkId Equipment_ClothChestSlotEntity;
    [FieldOffset(414)]
    public PrefabGUID Equipment_ClothChestSlotId;
    [FieldOffset(418)]
    public NetworkId Equipment_ClothLegsSlotEntity;
    [FieldOffset(426)]
    public PrefabGUID Equipment_ClothLegsSlotId;
    [FieldOffset(430)]
    public NetworkId Equipment_GrimoireSlotEntity;
    [FieldOffset(438)]
    public PrefabGUID Equipment_GrimoireSlotId;
    [FieldOffset(442)]
    public ModifiableFloat Equipment_SpellLevel;
    [FieldOffset(450)]
    public ModifiableFloat Equipment_WeaponLevel;
    [FieldOffset(458)]
    public NetworkId Equipment_WeaponSlotEntity;
    [FieldOffset(466)]
    public PrefabGUID Equipment_WeaponSlotId;
    [FieldOffset(470)]
    public ModifiableFloat FallToHeight_Gravity;
    [FieldOffset(478)]
    public bool Health_IsDead;
    [FieldOffset(479)]
    public ModifiableFloat Health_MaxHealth;
    [FieldOffset(487)]
    public float Health_MaxRecoveryHealth;
    [FieldOffset(491)]
    public double Health_TimeOfDeath;
    [FieldOffset(499)]
    public float Health_Value;
    [FieldOffset(503)]
    public byte Height_ServerHeightLevel;
    [FieldOffset(504)]
    public ushort HybridModelSeed_Seed;
    [FieldOffset(506)]
    public bool InteractedUpon_Interacting;
    [FieldOffset(507)]
    public ModifiableBool IsSpellControlled_Value;
    [FieldOffset(511)]
    public bool LifeLeech_AffectRecovery;
    [FieldOffset(512)]
    public ModifiableFloat LifeLeech_PhysicalLifeLeechFactor;
    [FieldOffset(520)]
    public ModifiableFloat LifeLeech_PrimaryLeechFactor;
    [FieldOffset(528)]
    public ModifiableFloat LifeLeech_SpellLifeLeechFactor;
    [FieldOffset(536)]
    public ModifiableFloat Mounter_Acceleration;
    [FieldOffset(544)]
    public ModifiableFloat Mounter_GallopMaxSpeed;
    [FieldOffset(552)]
    public ModifiableFloat Mounter_GallopMaxSpeedMultiplier;
    [FieldOffset(560)]
    public ModifiableFloat Mounter_TurnRate;
    [FieldOffset(568)]
    public ModifiableFloat Movement_Speed;
    [FieldOffset(576)]
    public double NetworkInterpolated_Shared_LastClientCommandTime;
    [FieldOffset(584)]
    public float2 NetworkInterpolated_Shared_Movement;
    [FieldOffset(592)]
    public float NetworkInterpolated_Shared_ServerMoveVelocity;
    [FieldOffset(596)]
    public float2 NetworkInterpolated_Shared_ServerPosition;
    [FieldOffset(604)]
    public quaternion NetworkInterpolated_Shared_ServerRotation;
    [FieldOffset(620)]
    public float2 NetworkInterpolated_Shared_ServerVelocity;
    [FieldOffset(628)]
    public bool NetworkInterpolated_Shared_Simulate;
    [FieldOffset(629)]
    public FixedString64 PlayerCharacter_Name;
    [FieldOffset(693)]
    public FixedString32 PlayerCharacter_SmartClanName;
    [FieldOffset(725)]
    public bool RespawnCharacter_IsReadyToRespawn;
    [FieldOffset(726)]
    public long RespawnCharacter_TimeOfDeath;
    [FieldOffset(734)]
    public ModifiableBool Stealthable_IsStealthed;
    [FieldOffset(738)]
    public ModifiableBool Stealthable_ModelInvisible;
    [FieldOffset(742)]
    public ModifiableInt Stealthable_StealthBushId;
    [FieldOffset(750)]
    public bool TakeDamageInSun_SunDamageDisabled;
    [FieldOffset(751)]
    public float3 TargetDirection_AimDirection;
    [FieldOffset(763)]
    public float TargetDirection_DefaultRotationSpeed;
    [FieldOffset(767)]
    public float3 TargetDirection_Direction;
    [FieldOffset(779)]
    public ModifiableBool TargetDirection_ForceRotateTowardsMovement;
    [FieldOffset(783)]
    public ModifiableBool TargetDirection_RotateTowardsMouse;
    [FieldOffset(787)]
    public int Team_FactionIndex;
    [FieldOffset(791)]
    public int Team_Value;
    [FieldOffset(795)]
    public TileType TileModel_DisabledTileTypes;
    [FieldOffset(796)]
    public float TravelToTargetRadius_Radius;
    [FieldOffset(800)]
    public ModifiableFloat UnitStats_AttackSpeed;
    [FieldOffset(808)]
    public ModifiableInt UnitStats_FireResistance;
    [FieldOffset(816)]
    public ModifiableInt UnitStats_GarlicResistance;
    [FieldOffset(824)]
    public ModifiableFloat UnitStats_HealthRecovery;
    [FieldOffset(832)]
    public ModifiableInt UnitStats_HolyResistance;
    [FieldOffset(840)]
    public ModifiableFloat UnitStats_PassiveHealthRegen;
    [FieldOffset(848)]
    public ModifiableFloat UnitStats_PhysicalCriticalStrikeChance;
    [FieldOffset(856)]
    public ModifiableFloat UnitStats_PhysicalCriticalStrikeDamage;
    [FieldOffset(864)]
    public ModifiableFloat UnitStats_PhysicalPower;
    [FieldOffset(872)]
    public ModifiableFloat UnitStats_PhysicalResistance;
    [FieldOffset(880)]
    public ModifiableFloat UnitStats_PrimaryAttackSpeed;
    [FieldOffset(888)]
    public ModifiableBool UnitStats_PvPProtected;
    [FieldOffset(892)]
    public ModifiableInt UnitStats_PvPResilience;
    [FieldOffset(900)]
    public ModifiableFloat UnitStats_ReducedResourceDurabilityLoss;
    [FieldOffset(908)]
    public ModifiableFloat UnitStats_ResourcePower;
    [FieldOffset(916)]
    public ModifiableFloat UnitStats_ResourceYieldModifier;
    [FieldOffset(924)]
    public ModifiableFloat UnitStats_SiegePower;
    [FieldOffset(932)]
    public ModifiableInt UnitStats_SilverResistance;
    [FieldOffset(940)]
    public ModifiableFloat UnitStats_SpellCriticalStrikeChance;
    [FieldOffset(948)]
    public ModifiableFloat UnitStats_SpellCriticalStrikeDamage;
    [FieldOffset(956)]
    public ModifiableFloat UnitStats_SpellPower;
    [FieldOffset(964)]
    public ModifiableFloat UnitStats_SpellResistance;
    [FieldOffset(972)]
    public ModifiableInt UnitStats_SunResistance;
    [FieldOffset(980)]
    public ModifiableFloat Vision_Range;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1521441, XrefRangeEnd = 1522310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_FollowerBuffer> get_buffer_FollowerBuffer,
      ref BufferFromEntity<Snapshot_InventoryInstanceElement> get_buffer_InventoryInstanceElement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_FollowerBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_InventoryInstanceElement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acbdgdebikk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_FollowerBuffer_byref_BufferFromEntity_1_Snapshot_InventoryInstanceElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1522831, RefRangeEnd = 1522832, XrefRangeStart = 1522310, XrefRangeEnd = 1522831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_FollowerBuffer> buffer_FollowerBuffer,
      DynamicBuffer<Snapshot_InventoryInstanceElement> buffer_InventoryInstanceElement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_FollowerBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_InventoryInstanceElement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acbdgdebikk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_FollowerBuffer_DynamicBuffer_1_Snapshot_InventoryInstanceElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acbdgdebikk()
    {
      Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acbdgdebikk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr);
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_CastAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_CastAbility));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_CastAbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_CastAbilityPrefabGuid));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_CastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_CastGroup));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_CastGroupPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_CastGroupPrefabGuid));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_CastStartTime));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_CastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_CastTime));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_CooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_CooldownModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_GlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_GlobalCooldown));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_InterruptTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_InterruptTypes));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_LimitAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_LimitAbilityPriority));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_PostCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_PostCastTime));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_PrimaryCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_PrimaryCooldownModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_ServerCastCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_ServerCastCounter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_ServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_ServerInterruptCounter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_SpellCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_SpellCooldownModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_TravelCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_TravelCooldownModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_AbilityBar_Shared_WeaponCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (AbilityBar_Shared_WeaponCooldownModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_BagHolder_BagInstance0Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (BagHolder_BagInstance0Entity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_BagHolder_BagInstance0InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (BagHolder_BagInstance0InventoryIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_BagHolder_BagInstance1Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (BagHolder_BagInstance1Entity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_BagHolder_BagInstance1InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (BagHolder_BagInstance1InventoryIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_BagHolder_BagInstance2Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (BagHolder_BagInstance2Entity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_BagHolder_BagInstance2InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (BagHolder_BagInstance2InventoryIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_BagHolder_BagInstance3Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (BagHolder_BagInstance3Entity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_BagHolder_BagInstance3InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (BagHolder_BagInstance3InventoryIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_BagHolder_BagSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (BagHolder_BagSlots));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Blood_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Blood_BloodType));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Blood_MaxBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Blood_MaxBlood));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Blood_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Blood_Quality));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Blood_ShowBloodHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Blood_ShowBloodHUD));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Blood_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Blood_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CanFly_FlyingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CanFly_FlyingHeight));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CanFly_HeightAboveObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CanFly_HeightAboveObstacle));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CharacterVoiceActivity_IsSpeaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CharacterVoiceActivity_IsSpeaking));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CombatMusicListener_Shared_PlayOutro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CombatMusicListener_Shared_PlayOutro));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CombatMusicListener_Shared_UnitPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CombatMusicListener_Shared_UnitPrefabGuid));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CustomizationFeatures_AccessoriesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CustomizationFeatures_AccessoriesIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CustomizationFeatures_EyeColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CustomizationFeatures_EyeColorIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CustomizationFeatures_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CustomizationFeatures_FaceIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CustomizationFeatures_FeaturesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CustomizationFeatures_FeaturesIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CustomizationFeatures_GenderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CustomizationFeatures_GenderIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CustomizationFeatures_HairColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CustomizationFeatures_HairColorIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CustomizationFeatures_HairStyleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CustomizationFeatures_HairStyleIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CustomizationFeatures_SkintoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CustomizationFeatures_SkintoneIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_DeathRagdollForce_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (DeathRagdollForce_Force));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_HardnessThreshold));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_PushStrengthMax));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_PushStrengthMin));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_HardnessThreshold));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_PushStrengthMax));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_PushStrengthMin));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_RadiusVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_RadiusVariation));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Energy_GainPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Energy_GainPerSecond));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Energy_MaxEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Energy_MaxEnergy));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Energy_RegainEnergyChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Energy_RegainEnergyChance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Energy_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Energy_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorChestSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorChestSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorChestSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorChestSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorFootgearSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorFootgearSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorFootgearSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorFootgearSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorGlovesSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorGlovesSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorGlovesSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorGlovesSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorHeadgearSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorHeadgearSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorHeadgearSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorHeadgearSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorLegsSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorLegsSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorLegsSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorLegsSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ArmorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ArmorLevel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_CloakSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_CloakSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_CloakSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_CloakSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ClothChestSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ClothChestSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ClothChestSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ClothChestSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ClothLegsSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ClothLegsSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_ClothLegsSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_ClothLegsSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_GrimoireSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_GrimoireSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_GrimoireSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_GrimoireSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_SpellLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_SpellLevel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_WeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_WeaponLevel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_WeaponSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_WeaponSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Equipment_WeaponSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Equipment_WeaponSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FallToHeight_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FallToHeight_Gravity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Health_IsDead));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Health_MaxHealth));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Health_MaxRecoveryHealth));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Health_TimeOfDeath));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Health_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Height_ServerHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Height_ServerHeightLevel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_HybridModelSeed_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (HybridModelSeed_Seed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (InteractedUpon_Interacting));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_IsSpellControlled_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (IsSpellControlled_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_LifeLeech_AffectRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (LifeLeech_AffectRecovery));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_LifeLeech_PhysicalLifeLeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (LifeLeech_PhysicalLifeLeechFactor));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_LifeLeech_PrimaryLeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (LifeLeech_PrimaryLeechFactor));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_LifeLeech_SpellLifeLeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (LifeLeech_SpellLifeLeechFactor));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Mounter_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Mounter_Acceleration));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Mounter_GallopMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Mounter_GallopMaxSpeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Mounter_GallopMaxSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Mounter_GallopMaxSpeedMultiplier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Mounter_TurnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Mounter_TurnRate));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Movement_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Movement_Speed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_NetworkInterpolated_Shared_LastClientCommandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (NetworkInterpolated_Shared_LastClientCommandTime));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_NetworkInterpolated_Shared_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (NetworkInterpolated_Shared_Movement));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerMoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerMoveVelocity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerPosition));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerRotation));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerVelocity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_NetworkInterpolated_Shared_Simulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (NetworkInterpolated_Shared_Simulate));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_PlayerCharacter_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (PlayerCharacter_Name));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_PlayerCharacter_SmartClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (PlayerCharacter_SmartClanName));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_RespawnCharacter_IsReadyToRespawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (RespawnCharacter_IsReadyToRespawn));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_RespawnCharacter_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (RespawnCharacter_TimeOfDeath));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Stealthable_IsStealthed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Stealthable_IsStealthed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Stealthable_ModelInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Stealthable_ModelInvisible));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Stealthable_StealthBushId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Stealthable_StealthBushId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_TakeDamageInSun_SunDamageDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (TakeDamageInSun_SunDamageDisabled));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_TargetDirection_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (TargetDirection_AimDirection));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_TargetDirection_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (TargetDirection_DefaultRotationSpeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_TargetDirection_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (TargetDirection_Direction));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_TargetDirection_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (TargetDirection_ForceRotateTowardsMovement));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_TargetDirection_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (TargetDirection_RotateTowardsMouse));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Team_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_TravelToTargetRadius_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (TravelToTargetRadius_Radius));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_AttackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_AttackSpeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_FireResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_FireResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_GarlicResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_GarlicResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_HealthRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_HealthRecovery));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_HolyResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_HolyResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_PassiveHealthRegen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_PassiveHealthRegen));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_PhysicalCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_PhysicalCriticalStrikeChance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_PhysicalCriticalStrikeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_PhysicalCriticalStrikeDamage));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_PhysicalPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_PhysicalPower));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_PhysicalResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_PhysicalResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_PrimaryAttackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_PrimaryAttackSpeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_PvPProtected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_PvPProtected));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_PvPResilience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_PvPResilience));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_ReducedResourceDurabilityLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_ReducedResourceDurabilityLoss));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_ResourcePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_ResourcePower));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_ResourceYieldModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_ResourceYieldModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_SiegePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_SiegePower));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_SilverResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_SilverResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_SpellCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_SpellCriticalStrikeChance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_SpellCriticalStrikeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_SpellCriticalStrikeDamage));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_SpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_SpellPower));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_SpellResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_SpellResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_UnitStats_SunResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (UnitStats_SunResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_Vision_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (Vision_Range));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_AbilityBar_Shared_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_AbilityBar_Shared_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BagHolder_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_BagHolder_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BagHolder_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_BagHolder_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Blood_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Blood_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Blood_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Blood_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CanFly_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_CanFly_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CanFly_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_CanFly_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CharacterVoiceActivity_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_CharacterVoiceActivity_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CharacterVoiceActivity_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_CharacterVoiceActivity_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CombatMusicListener_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_CombatMusicListener_Shared_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CombatMusicListener_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_CombatMusicListener_Shared_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CustomizationFeatures_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_CustomizationFeatures_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CustomizationFeatures_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_CustomizationFeatures_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_DeathRagdollForce_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_DeathRagdollForce_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_DynamicCollision_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_DynamicCollision_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Energy_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Energy_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Energy_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Energy_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Equipment_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Equipment_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Equipment_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Equipment_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_FallToHeight_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_FallToHeight_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Health_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Health_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Health_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Health_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Height_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Height_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Height_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Height_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_HybridModelSeed_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_HybridModelSeed_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_IsSpellControlled_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_IsSpellControlled_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_LifeLeech_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_LifeLeech_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_LifeLeech_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_LifeLeech_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Mounter_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Mounter_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Mounter_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Mounter_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Movement_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Movement_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Movement_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Movement_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_NetworkInterpolated_Shared_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_NetworkInterpolated_Shared_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_PlayerCharacter_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_PlayerCharacter_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_PlayerCharacter_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_PlayerCharacter_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_RespawnCharacter_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_RespawnCharacter_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_RespawnCharacter_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_RespawnCharacter_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Stealthable_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Stealthable_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TakeDamageInSun_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_TakeDamageInSun_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TakeDamageInSun_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_TakeDamageInSun_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_TargetDirection_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_TargetDirection_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TravelToTargetRadius_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_TravelToTargetRadius_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TravelToTargetRadius_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_TravelToTargetRadius_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_UnitStats_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_UnitStats_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_UnitStats_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_UnitStats_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Vision_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Vision_Start));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Vision_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedFields_Vision_Count));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BagHolder));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Blood));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CanFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CanFly));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CharacterVoiceActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CharacterVoiceActivity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CombatMusicListener_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CustomizationFeatures));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_DeathRagdollForce));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Energy));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_FallToHeight));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Health));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Height));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_HybridModelSeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_IsSpellControlled));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_LifeLeech));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Mounter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Movement));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_PlayerCharacter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_RespawnCharacter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Stealthable));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TakeDamageInSun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TakeDamageInSun));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TravelToTargetRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TravelToTargetRadius));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Vision));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_FollowerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_FollowerBuffer));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_InventoryInstanceElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_InventoryInstanceElement));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastAbility));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastGroup));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastStartTime));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastTime));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CooldownModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_GlobalCooldown));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_InterruptTypes));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_PostCastTime));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_ServerCastCounter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance0Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BagHolder_BagInstance0Entity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance0InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BagHolder_BagInstance0InventoryIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance1Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BagHolder_BagInstance1Entity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance1InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BagHolder_BagInstance1InventoryIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance2Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BagHolder_BagInstance2Entity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance2InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BagHolder_BagInstance2InventoryIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance3Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BagHolder_BagInstance3Entity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance3InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BagHolder_BagInstance3InventoryIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BagHolder_BagSlots));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Blood_BloodType));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_MaxBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Blood_MaxBlood));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Blood_Quality));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_ShowBloodHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Blood_ShowBloodHUD));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Blood_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CanFly_FlyingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CanFly_FlyingHeight));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CanFly_HeightAboveObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CanFly_HeightAboveObstacle));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CharacterVoiceActivity_IsSpeaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CharacterVoiceActivity_IsSpeaking));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared_PlayOutro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CombatMusicListener_Shared_PlayOutro));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared_UnitPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CombatMusicListener_Shared_UnitPrefabGuid));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_AccessoriesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CustomizationFeatures_AccessoriesIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_EyeColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CustomizationFeatures_EyeColorIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CustomizationFeatures_FaceIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_FeaturesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CustomizationFeatures_FeaturesIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_GenderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CustomizationFeatures_GenderIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_HairColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CustomizationFeatures_HairColorIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_HairStyleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CustomizationFeatures_HairStyleIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_SkintoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_CustomizationFeatures_SkintoneIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_DeathRagdollForce_Force));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_GainPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Energy_GainPerSecond));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_MaxEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Energy_MaxEnergy));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_RegainEnergyChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Energy_RegainEnergyChance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Energy_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorChestSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorChestSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorChestSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorChestSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorFootgearSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorFootgearSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorFootgearSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorFootgearSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorGlovesSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorGlovesSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorGlovesSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorGlovesSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorHeadgearSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorHeadgearSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorHeadgearSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorHeadgearSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLegsSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorLegsSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLegsSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorLegsSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ArmorLevel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_CloakSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_CloakSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_CloakSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_CloakSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothChestSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ClothChestSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothChestSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ClothChestSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothLegsSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ClothLegsSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothLegsSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_ClothLegsSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_GrimoireSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_GrimoireSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_GrimoireSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_GrimoireSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_SpellLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_SpellLevel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_WeaponLevel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_WeaponSlotEntity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Equipment_WeaponSlotId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_FallToHeight_Gravity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Health_IsDead));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxHealth));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxRecoveryHealth));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Health_TimeOfDeath));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Health_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Height_ServerHeightLevel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_HybridModelSeed_Seed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon_Interacting));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_IsSpellControlled_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_AffectRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_LifeLeech_AffectRecovery));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_PhysicalLifeLeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_LifeLeech_PhysicalLifeLeechFactor));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_PrimaryLeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_LifeLeech_PrimaryLeechFactor));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_SpellLifeLeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_LifeLeech_SpellLifeLeechFactor));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Mounter_Acceleration));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_GallopMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Mounter_GallopMaxSpeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_GallopMaxSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Mounter_GallopMaxSpeedMultiplier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_TurnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Mounter_TurnRate));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Movement_Speed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_Movement));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_Simulate));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_PlayerCharacter_Name));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter_SmartClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_PlayerCharacter_SmartClanName));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter_IsReadyToRespawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_RespawnCharacter_IsReadyToRespawn));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_RespawnCharacter_TimeOfDeath));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_IsStealthed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Stealthable_IsStealthed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_ModelInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Stealthable_ModelInvisible));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_StealthBushId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Stealthable_StealthBushId));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TakeDamageInSun_SunDamageDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TakeDamageInSun_SunDamageDisabled));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_AimDirection));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_DefaultRotationSpeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_Direction));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_RotateTowardsMouse));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TravelToTargetRadius_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_TravelToTargetRadius_Radius));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_AttackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_AttackSpeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_FireResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_FireResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_GarlicResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_GarlicResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_HealthRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_HealthRecovery));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_HolyResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_HolyResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PassiveHealthRegen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_PassiveHealthRegen));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_PhysicalCriticalStrikeChance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalCriticalStrikeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_PhysicalCriticalStrikeDamage));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_PhysicalPower));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_PhysicalResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PrimaryAttackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_PrimaryAttackSpeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PvPProtected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_PvPProtected));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PvPResilience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_PvPResilience));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ReducedResourceDurabilityLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_ReducedResourceDurabilityLoss));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ResourcePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_ResourcePower));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ResourceYieldModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_ResourceYieldModifier));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SiegePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_SiegePower));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SilverResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_SilverResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_SpellCriticalStrikeChance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellCriticalStrikeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_SpellCriticalStrikeDamage));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_SpellPower));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_SpellResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SunResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_UnitStats_SunResistance));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Vision_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (FrameChangedIndex_Vision_Range));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityBar_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_AbilityBar_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_BagHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_BagHolder));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_BagHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_BagHolder));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Blood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_Blood));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Blood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_Blood));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CanFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_CanFly));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CanFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_CanFly));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CharacterVoiceActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_CharacterVoiceActivity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CharacterVoiceActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_CharacterVoiceActivity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CombatMusicListener_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_CombatMusicListener_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CombatMusicListener_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_CombatMusicListener_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CustomizationFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_CustomizationFeatures));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CustomizationFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_CustomizationFeatures));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_DeathRagdollForce));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_DeathRagdollForce));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_DynamicCollision));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_DynamicCollision));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_Energy));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_Energy));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Equipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_Equipment));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Equipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_Equipment));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_FallToHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_FallToHeight));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_FallToHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_FallToHeight));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_Health));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_Health));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_Height));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_Height));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_HybridModelSeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_HybridModelSeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_InteractedUpon));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_InteractedUpon));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_IsSpellControlled));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_IsSpellControlled));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_LifeLeech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeLeech));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_LifeLeech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_LifeLeech));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Mounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_Mounter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Mounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_Mounter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_Movement));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_Movement));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_NetworkInterpolated_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_NetworkInterpolated_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_PlayerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_PlayerCharacter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_PlayerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_PlayerCharacter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_RespawnCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_RespawnCharacter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_RespawnCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_RespawnCharacter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Stealthable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_Stealthable));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Stealthable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_Stealthable));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TakeDamageInSun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_TakeDamageInSun));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TakeDamageInSun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_TakeDamageInSun));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_TargetDirection));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_TargetDirection));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TravelToTargetRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_TravelToTargetRadius));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TravelToTargetRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_TravelToTargetRadius));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_UnitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_UnitStats));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_UnitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_UnitStats));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataStartOffset_Vision));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (ComponentDataSize_Vision));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_AbilityBar_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_BagHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_BagHolder));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Blood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_Blood));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CanFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_CanFly));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CharacterVoiceActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_CharacterVoiceActivity));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CombatMusicListener_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_CombatMusicListener_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CustomizationFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_CustomizationFeatures));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_DeathRagdollForce));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_DynamicCollision));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_Energy));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Equipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_Equipment));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_FallToHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_FallToHeight));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_Health));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_Height));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_HybridModelSeed));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_InteractedUpon));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_IsSpellControlled));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_LifeLeech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_LifeLeech));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Mounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_Mounter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_Movement));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_NetworkInterpolated_Shared));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_PlayerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_PlayerCharacter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_RespawnCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_RespawnCharacter));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Stealthable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_Stealthable));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TakeDamageInSun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_TakeDamageInSun));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_TargetDirection));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TravelToTargetRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_TravelToTargetRadius));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_UnitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_UnitStats));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_Vision));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_FollowerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_FollowerBuffer));
      Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_InventoryInstanceElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, nameof (CompBit_InventoryInstanceElement));
      Snapshot_acbdgdebikk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_FollowerBuffer_byref_BufferFromEntity_1_Snapshot_InventoryInstanceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, 100664124);
      Snapshot_acbdgdebikk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_FollowerBuffer_DynamicBuffer_1_Snapshot_InventoryInstanceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, 100664125);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acbdgdebikk>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityBar_Shared_Start
    {
      get
      {
        int abilityBarSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start, (void*) &abilityBarSharedStart);
        return abilityBarSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityBar_Shared_Count
    {
      get
      {
        int abilityBarSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count, (void*) &abilityBarSharedCount);
        return abilityBarSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BagHolder_Start
    {
      get
      {
        int fieldsBagHolderStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BagHolder_Start, (void*) &fieldsBagHolderStart);
        return fieldsBagHolderStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BagHolder_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BagHolder_Count
    {
      get
      {
        int fieldsBagHolderCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BagHolder_Count, (void*) &fieldsBagHolderCount);
        return fieldsBagHolderCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BagHolder_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Blood_Start
    {
      get
      {
        int fieldsBloodStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Blood_Start, (void*) &fieldsBloodStart);
        return fieldsBloodStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Blood_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Blood_Count
    {
      get
      {
        int fieldsBloodCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Blood_Count, (void*) &fieldsBloodCount);
        return fieldsBloodCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Blood_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CanFly_Start
    {
      get
      {
        int fieldsCanFlyStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CanFly_Start, (void*) &fieldsCanFlyStart);
        return fieldsCanFlyStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CanFly_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CanFly_Count
    {
      get
      {
        int fieldsCanFlyCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CanFly_Count, (void*) &fieldsCanFlyCount);
        return fieldsCanFlyCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CanFly_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CharacterVoiceActivity_Start
    {
      get
      {
        int voiceActivityStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CharacterVoiceActivity_Start, (void*) &voiceActivityStart);
        return voiceActivityStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CharacterVoiceActivity_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CharacterVoiceActivity_Count
    {
      get
      {
        int voiceActivityCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CharacterVoiceActivity_Count, (void*) &voiceActivityCount);
        return voiceActivityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CharacterVoiceActivity_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CombatMusicListener_Shared_Start
    {
      get
      {
        int listenerSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CombatMusicListener_Shared_Start, (void*) &listenerSharedStart);
        return listenerSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CombatMusicListener_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CombatMusicListener_Shared_Count
    {
      get
      {
        int listenerSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CombatMusicListener_Shared_Count, (void*) &listenerSharedCount);
        return listenerSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CombatMusicListener_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CustomizationFeatures_Start
    {
      get
      {
        int customizationFeaturesStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CustomizationFeatures_Start, (void*) &customizationFeaturesStart);
        return customizationFeaturesStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CustomizationFeatures_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CustomizationFeatures_Count
    {
      get
      {
        int customizationFeaturesCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CustomizationFeatures_Count, (void*) &customizationFeaturesCount);
        return customizationFeaturesCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_CustomizationFeatures_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DeathRagdollForce_Start
    {
      get
      {
        int ragdollForceStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start, (void*) &ragdollForceStart);
        return ragdollForceStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DeathRagdollForce_Count
    {
      get
      {
        int ragdollForceCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count, (void*) &ragdollForceCount);
        return ragdollForceCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DynamicCollision_Start
    {
      get
      {
        int dynamicCollisionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start, (void*) &dynamicCollisionStart);
        return dynamicCollisionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DynamicCollision_Count
    {
      get
      {
        int dynamicCollisionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count, (void*) &dynamicCollisionCount);
        return dynamicCollisionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Energy_Start
    {
      get
      {
        int fieldsEnergyStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Energy_Start, (void*) &fieldsEnergyStart);
        return fieldsEnergyStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Energy_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Energy_Count
    {
      get
      {
        int fieldsEnergyCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Energy_Count, (void*) &fieldsEnergyCount);
        return fieldsEnergyCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Energy_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Equipment_Start
    {
      get
      {
        int fieldsEquipmentStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Equipment_Start, (void*) &fieldsEquipmentStart);
        return fieldsEquipmentStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Equipment_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Equipment_Count
    {
      get
      {
        int fieldsEquipmentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Equipment_Count, (void*) &fieldsEquipmentCount);
        return fieldsEquipmentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Equipment_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_FallToHeight_Start
    {
      get
      {
        int fallToHeightStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Start, (void*) &fallToHeightStart);
        return fallToHeightStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_FallToHeight_Count
    {
      get
      {
        int fallToHeightCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Count, (void*) &fallToHeightCount);
        return fallToHeightCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Start
    {
      get
      {
        int fieldsHealthStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &fieldsHealthStart);
        return fieldsHealthStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Count
    {
      get
      {
        int fieldsHealthCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &fieldsHealthCount);
        return fieldsHealthCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Height_Start
    {
      get
      {
        int fieldsHeightStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Height_Start, (void*) &fieldsHeightStart);
        return fieldsHeightStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Height_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Height_Count
    {
      get
      {
        int fieldsHeightCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Height_Count, (void*) &fieldsHeightCount);
        return fieldsHeightCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Height_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_HybridModelSeed_Start
    {
      get
      {
        int hybridModelSeedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start, (void*) &hybridModelSeedStart);
        return hybridModelSeedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_HybridModelSeed_Count
    {
      get
      {
        int hybridModelSeedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count, (void*) &hybridModelSeedCount);
        return hybridModelSeedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Start
    {
      get
      {
        int interactedUponStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &interactedUponStart);
        return interactedUponStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Count
    {
      get
      {
        int interactedUponCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &interactedUponCount);
        return interactedUponCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_IsSpellControlled_Start
    {
      get
      {
        int spellControlledStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start, (void*) &spellControlledStart);
        return spellControlledStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_IsSpellControlled_Count
    {
      get
      {
        int spellControlledCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count, (void*) &spellControlledCount);
        return spellControlledCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeLeech_Start
    {
      get
      {
        int fieldsLifeLeechStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_LifeLeech_Start, (void*) &fieldsLifeLeechStart);
        return fieldsLifeLeechStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_LifeLeech_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeLeech_Count
    {
      get
      {
        int fieldsLifeLeechCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_LifeLeech_Count, (void*) &fieldsLifeLeechCount);
        return fieldsLifeLeechCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_LifeLeech_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Mounter_Start
    {
      get
      {
        int fieldsMounterStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Mounter_Start, (void*) &fieldsMounterStart);
        return fieldsMounterStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Mounter_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Mounter_Count
    {
      get
      {
        int fieldsMounterCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Mounter_Count, (void*) &fieldsMounterCount);
        return fieldsMounterCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Mounter_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Movement_Start
    {
      get
      {
        int fieldsMovementStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Movement_Start, (void*) &fieldsMovementStart);
        return fieldsMovementStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Movement_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Movement_Count
    {
      get
      {
        int fieldsMovementCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Movement_Count, (void*) &fieldsMovementCount);
        return fieldsMovementCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Movement_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_NetworkInterpolated_Shared_Start
    {
      get
      {
        int interpolatedSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start, (void*) &interpolatedSharedStart);
        return interpolatedSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_NetworkInterpolated_Shared_Count
    {
      get
      {
        int interpolatedSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count, (void*) &interpolatedSharedCount);
        return interpolatedSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlayerCharacter_Start
    {
      get
      {
        int playerCharacterStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_PlayerCharacter_Start, (void*) &playerCharacterStart);
        return playerCharacterStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_PlayerCharacter_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlayerCharacter_Count
    {
      get
      {
        int playerCharacterCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_PlayerCharacter_Count, (void*) &playerCharacterCount);
        return playerCharacterCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_PlayerCharacter_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_RespawnCharacter_Start
    {
      get
      {
        int respawnCharacterStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_RespawnCharacter_Start, (void*) &respawnCharacterStart);
        return respawnCharacterStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_RespawnCharacter_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_RespawnCharacter_Count
    {
      get
      {
        int respawnCharacterCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_RespawnCharacter_Count, (void*) &respawnCharacterCount);
        return respawnCharacterCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_RespawnCharacter_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Stealthable_Start
    {
      get
      {
        int stealthableStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Start, (void*) &stealthableStart);
        return stealthableStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Stealthable_Count
    {
      get
      {
        int stealthableCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Count, (void*) &stealthableCount);
        return stealthableCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TakeDamageInSun_Start
    {
      get
      {
        int damageInSunStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TakeDamageInSun_Start, (void*) &damageInSunStart);
        return damageInSunStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TakeDamageInSun_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TakeDamageInSun_Count
    {
      get
      {
        int damageInSunCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TakeDamageInSun_Count, (void*) &damageInSunCount);
        return damageInSunCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TakeDamageInSun_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TargetDirection_Start
    {
      get
      {
        int targetDirectionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start, (void*) &targetDirectionStart);
        return targetDirectionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TargetDirection_Count
    {
      get
      {
        int targetDirectionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count, (void*) &targetDirectionCount);
        return targetDirectionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TravelToTargetRadius_Start
    {
      get
      {
        int targetRadiusStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TravelToTargetRadius_Start, (void*) &targetRadiusStart);
        return targetRadiusStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TravelToTargetRadius_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TravelToTargetRadius_Count
    {
      get
      {
        int targetRadiusCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TravelToTargetRadius_Count, (void*) &targetRadiusCount);
        return targetRadiusCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_TravelToTargetRadius_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UnitStats_Start
    {
      get
      {
        int fieldsUnitStatsStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_UnitStats_Start, (void*) &fieldsUnitStatsStart);
        return fieldsUnitStatsStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_UnitStats_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UnitStats_Count
    {
      get
      {
        int fieldsUnitStatsCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_UnitStats_Count, (void*) &fieldsUnitStatsCount);
        return fieldsUnitStatsCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_UnitStats_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Vision_Start
    {
      get
      {
        int fieldsVisionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Vision_Start, (void*) &fieldsVisionStart);
        return fieldsVisionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Vision_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Vision_Count
    {
      get
      {
        int fieldsVisionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Vision_Count, (void*) &fieldsVisionCount);
        return fieldsVisionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedFields_Vision_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BagHolder
    {
      get
      {
        int changedIndexBagHolder;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder, (void*) &changedIndexBagHolder);
        return changedIndexBagHolder;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Blood
    {
      get
      {
        int changedIndexBlood;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood, (void*) &changedIndexBlood);
        return changedIndexBlood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CanFly
    {
      get
      {
        int changedIndexCanFly;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CanFly, (void*) &changedIndexCanFly);
        return changedIndexCanFly;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CanFly, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CharacterVoiceActivity
    {
      get
      {
        int characterVoiceActivity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CharacterVoiceActivity, (void*) &characterVoiceActivity);
        return characterVoiceActivity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CharacterVoiceActivity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CombatMusicListener_Shared
    {
      get
      {
        int musicListenerShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared, (void*) &musicListenerShared);
        return musicListenerShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CustomizationFeatures
    {
      get
      {
        int customizationFeatures;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures, (void*) &customizationFeatures);
        return customizationFeatures;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DeathRagdollForce
    {
      get
      {
        int deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Energy
    {
      get
      {
        int changedIndexEnergy;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy, (void*) &changedIndexEnergy);
        return changedIndexEnergy;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment
    {
      get
      {
        int changedIndexEquipment;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment, (void*) &changedIndexEquipment);
        return changedIndexEquipment;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_FallToHeight
    {
      get
      {
        int indexFallToHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight, (void*) &indexFallToHeight);
        return indexFallToHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health
    {
      get
      {
        int changedIndexHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &changedIndexHealth);
        return changedIndexHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Height
    {
      get
      {
        int changedIndexHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Height, (void*) &changedIndexHeight);
        return changedIndexHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_HybridModelSeed
    {
      get
      {
        int indexHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed, (void*) &indexHybridModelSeed);
        return indexHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon
    {
      get
      {
        int indexInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &indexInteractedUpon);
        return indexInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeLeech
    {
      get
      {
        int changedIndexLifeLeech;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech, (void*) &changedIndexLifeLeech);
        return changedIndexLifeLeech;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Mounter
    {
      get
      {
        int changedIndexMounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter, (void*) &changedIndexMounter);
        return changedIndexMounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Movement
    {
      get
      {
        int changedIndexMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Movement, (void*) &changedIndexMovement);
        return changedIndexMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Movement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlayerCharacter
    {
      get
      {
        int indexPlayerCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter, (void*) &indexPlayerCharacter);
        return indexPlayerCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RespawnCharacter
    {
      get
      {
        int respawnCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter, (void*) &respawnCharacter);
        return respawnCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Stealthable
    {
      get
      {
        int indexStealthable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable, (void*) &indexStealthable);
        return indexStealthable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TakeDamageInSun
    {
      get
      {
        int indexTakeDamageInSun;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TakeDamageInSun, (void*) &indexTakeDamageInSun);
        return indexTakeDamageInSun;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TakeDamageInSun, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection
    {
      get
      {
        int indexTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection, (void*) &indexTargetDirection);
        return indexTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TravelToTargetRadius
    {
      get
      {
        int travelToTargetRadius;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TravelToTargetRadius, (void*) &travelToTargetRadius);
        return travelToTargetRadius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TravelToTargetRadius, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats
    {
      get
      {
        int changedIndexUnitStats;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats, (void*) &changedIndexUnitStats);
        return changedIndexUnitStats;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Vision
    {
      get
      {
        int changedIndexVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Vision, (void*) &changedIndexVision);
        return changedIndexVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Vision, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_FollowerBuffer
    {
      get
      {
        int indexFollowerBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_FollowerBuffer, (void*) &indexFollowerBuffer);
        return indexFollowerBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_FollowerBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InventoryInstanceElement
    {
      get
      {
        int inventoryInstanceElement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_InventoryInstanceElement, (void*) &inventoryInstanceElement);
        return inventoryInstanceElement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_InventoryInstanceElement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastAbility
    {
      get
      {
        int sharedCastAbility;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility, (void*) &sharedCastAbility);
        return sharedCastAbility;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid
    {
      get
      {
        int abilityPrefabGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid, (void*) &abilityPrefabGuid);
        return abilityPrefabGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastGroup
    {
      get
      {
        int barSharedCastGroup;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup, (void*) &barSharedCastGroup);
        return barSharedCastGroup;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid
    {
      get
      {
        int castGroupPrefabGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid, (void*) &castGroupPrefabGuid);
        return castGroupPrefabGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastStartTime
    {
      get
      {
        int sharedCastStartTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime, (void*) &sharedCastStartTime);
        return sharedCastStartTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastTime
    {
      get
      {
        int barSharedCastTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime, (void*) &barSharedCastTime);
        return barSharedCastTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_GlobalCooldown
    {
      get
      {
        int sharedGlobalCooldown;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown, (void*) &sharedGlobalCooldown);
        return sharedGlobalCooldown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_InterruptTypes
    {
      get
      {
        int sharedInterruptTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes, (void*) &sharedInterruptTypes);
        return sharedInterruptTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority
    {
      get
      {
        int limitAbilityPriority;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority, (void*) &limitAbilityPriority);
        return limitAbilityPriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_PostCastTime
    {
      get
      {
        int sharedPostCastTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime, (void*) &sharedPostCastTime);
        return sharedPostCastTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_ServerCastCounter
    {
      get
      {
        int serverCastCounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter, (void*) &serverCastCounter);
        return serverCastCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter
    {
      get
      {
        int interruptCounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter, (void*) &interruptCounter);
        return interruptCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BagHolder_BagInstance0Entity
    {
      get
      {
        int bagInstance0Entity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance0Entity, (void*) &bagInstance0Entity);
        return bagInstance0Entity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance0Entity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BagHolder_BagInstance0InventoryIndex
    {
      get
      {
        int instance0InventoryIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance0InventoryIndex, (void*) &instance0InventoryIndex);
        return instance0InventoryIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance0InventoryIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BagHolder_BagInstance1Entity
    {
      get
      {
        int bagInstance1Entity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance1Entity, (void*) &bagInstance1Entity);
        return bagInstance1Entity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance1Entity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BagHolder_BagInstance1InventoryIndex
    {
      get
      {
        int instance1InventoryIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance1InventoryIndex, (void*) &instance1InventoryIndex);
        return instance1InventoryIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance1InventoryIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BagHolder_BagInstance2Entity
    {
      get
      {
        int bagInstance2Entity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance2Entity, (void*) &bagInstance2Entity);
        return bagInstance2Entity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance2Entity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BagHolder_BagInstance2InventoryIndex
    {
      get
      {
        int instance2InventoryIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance2InventoryIndex, (void*) &instance2InventoryIndex);
        return instance2InventoryIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance2InventoryIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BagHolder_BagInstance3Entity
    {
      get
      {
        int bagInstance3Entity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance3Entity, (void*) &bagInstance3Entity);
        return bagInstance3Entity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance3Entity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BagHolder_BagInstance3InventoryIndex
    {
      get
      {
        int instance3InventoryIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance3InventoryIndex, (void*) &instance3InventoryIndex);
        return instance3InventoryIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagInstance3InventoryIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BagHolder_BagSlots
    {
      get
      {
        int bagHolderBagSlots;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagSlots, (void*) &bagHolderBagSlots);
        return bagHolderBagSlots;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BagHolder_BagSlots, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Blood_BloodType
    {
      get
      {
        int indexBloodBloodType;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_BloodType, (void*) &indexBloodBloodType);
        return indexBloodBloodType;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_BloodType, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Blood_MaxBlood
    {
      get
      {
        int indexBloodMaxBlood;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_MaxBlood, (void*) &indexBloodMaxBlood);
        return indexBloodMaxBlood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_MaxBlood, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Blood_Quality
    {
      get
      {
        int indexBloodQuality;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_Quality, (void*) &indexBloodQuality);
        return indexBloodQuality;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_Quality, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Blood_ShowBloodHUD
    {
      get
      {
        int bloodShowBloodHud;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_ShowBloodHUD, (void*) &bloodShowBloodHud);
        return bloodShowBloodHud;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_ShowBloodHUD, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Blood_Value
    {
      get
      {
        int changedIndexBloodValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_Value, (void*) &changedIndexBloodValue);
        return changedIndexBloodValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Blood_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CanFly_FlyingHeight
    {
      get
      {
        int canFlyFlyingHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CanFly_FlyingHeight, (void*) &canFlyFlyingHeight);
        return canFlyFlyingHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CanFly_FlyingHeight, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CanFly_HeightAboveObstacle
    {
      get
      {
        int heightAboveObstacle;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CanFly_HeightAboveObstacle, (void*) &heightAboveObstacle);
        return heightAboveObstacle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CanFly_HeightAboveObstacle, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CharacterVoiceActivity_IsSpeaking
    {
      get
      {
        int activityIsSpeaking;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CharacterVoiceActivity_IsSpeaking, (void*) &activityIsSpeaking);
        return activityIsSpeaking;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CharacterVoiceActivity_IsSpeaking, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CombatMusicListener_Shared_PlayOutro
    {
      get
      {
        int listenerSharedPlayOutro;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared_PlayOutro, (void*) &listenerSharedPlayOutro);
        return listenerSharedPlayOutro;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared_PlayOutro, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CombatMusicListener_Shared_UnitPrefabGuid
    {
      get
      {
        int sharedUnitPrefabGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared_UnitPrefabGuid, (void*) &sharedUnitPrefabGuid);
        return sharedUnitPrefabGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CombatMusicListener_Shared_UnitPrefabGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CustomizationFeatures_AccessoriesIndex
    {
      get
      {
        int accessoriesIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_AccessoriesIndex, (void*) &accessoriesIndex);
        return accessoriesIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_AccessoriesIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CustomizationFeatures_EyeColorIndex
    {
      get
      {
        int featuresEyeColorIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_EyeColorIndex, (void*) &featuresEyeColorIndex);
        return featuresEyeColorIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_EyeColorIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CustomizationFeatures_FaceIndex
    {
      get
      {
        int featuresFaceIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_FaceIndex, (void*) &featuresFaceIndex);
        return featuresFaceIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_FaceIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CustomizationFeatures_FeaturesIndex
    {
      get
      {
        int featuresFeaturesIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_FeaturesIndex, (void*) &featuresFeaturesIndex);
        return featuresFeaturesIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_FeaturesIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CustomizationFeatures_GenderIndex
    {
      get
      {
        int featuresGenderIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_GenderIndex, (void*) &featuresGenderIndex);
        return featuresGenderIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_GenderIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CustomizationFeatures_HairColorIndex
    {
      get
      {
        int featuresHairColorIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_HairColorIndex, (void*) &featuresHairColorIndex);
        return featuresHairColorIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_HairColorIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CustomizationFeatures_HairStyleIndex
    {
      get
      {
        int featuresHairStyleIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_HairStyleIndex, (void*) &featuresHairStyleIndex);
        return featuresHairStyleIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_HairStyleIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CustomizationFeatures_SkintoneIndex
    {
      get
      {
        int featuresSkintoneIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_SkintoneIndex, (void*) &featuresSkintoneIndex);
        return featuresSkintoneIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_CustomizationFeatures_SkintoneIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DeathRagdollForce_Force
    {
      get
      {
        int ragdollForceForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force, (void*) &ragdollForceForce);
        return ragdollForceForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold
    {
      get
      {
        int hardnessThreshold;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold, (void*) &hardnessThreshold);
        return hardnessThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax
    {
      get
      {
        int playersPushStrengthMax;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax, (void*) &playersPushStrengthMax);
        return playersPushStrengthMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin
    {
      get
      {
        int playersPushStrengthMin;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin, (void*) &playersPushStrengthMin);
        return playersPushStrengthMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold
    {
      get
      {
        int hardnessThreshold;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold, (void*) &hardnessThreshold);
        return hardnessThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax
    {
      get
      {
        int unitsPushStrengthMax;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax, (void*) &unitsPushStrengthMax);
        return unitsPushStrengthMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin
    {
      get
      {
        int unitsPushStrengthMin;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin, (void*) &unitsPushStrengthMin);
        return unitsPushStrengthMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation
    {
      get
      {
        int unitsRadiusVariation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation, (void*) &unitsRadiusVariation);
        return unitsRadiusVariation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Energy_GainPerSecond
    {
      get
      {
        int energyGainPerSecond;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_GainPerSecond, (void*) &energyGainPerSecond);
        return energyGainPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_GainPerSecond, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Energy_MaxEnergy
    {
      get
      {
        int indexEnergyMaxEnergy;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_MaxEnergy, (void*) &indexEnergyMaxEnergy);
        return indexEnergyMaxEnergy;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_MaxEnergy, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Energy_RegainEnergyChance
    {
      get
      {
        int regainEnergyChance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_RegainEnergyChance, (void*) &regainEnergyChance);
        return regainEnergyChance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_RegainEnergyChance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Energy_Value
    {
      get
      {
        int indexEnergyValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_Value, (void*) &indexEnergyValue);
        return indexEnergyValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Energy_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorChestSlotEntity
    {
      get
      {
        int armorChestSlotEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorChestSlotEntity, (void*) &armorChestSlotEntity);
        return armorChestSlotEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorChestSlotEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorChestSlotId
    {
      get
      {
        int armorChestSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorChestSlotId, (void*) &armorChestSlotId);
        return armorChestSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorChestSlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorFootgearSlotEntity
    {
      get
      {
        int footgearSlotEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorFootgearSlotEntity, (void*) &footgearSlotEntity);
        return footgearSlotEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorFootgearSlotEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorFootgearSlotId
    {
      get
      {
        int armorFootgearSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorFootgearSlotId, (void*) &armorFootgearSlotId);
        return armorFootgearSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorFootgearSlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorGlovesSlotEntity
    {
      get
      {
        int glovesSlotEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorGlovesSlotEntity, (void*) &glovesSlotEntity);
        return glovesSlotEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorGlovesSlotEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorGlovesSlotId
    {
      get
      {
        int armorGlovesSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorGlovesSlotId, (void*) &armorGlovesSlotId);
        return armorGlovesSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorGlovesSlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorHeadgearSlotEntity
    {
      get
      {
        int headgearSlotEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorHeadgearSlotEntity, (void*) &headgearSlotEntity);
        return headgearSlotEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorHeadgearSlotEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorHeadgearSlotId
    {
      get
      {
        int armorHeadgearSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorHeadgearSlotId, (void*) &armorHeadgearSlotId);
        return armorHeadgearSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorHeadgearSlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorLegsSlotEntity
    {
      get
      {
        int armorLegsSlotEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLegsSlotEntity, (void*) &armorLegsSlotEntity);
        return armorLegsSlotEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLegsSlotEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorLegsSlotId
    {
      get
      {
        int equipmentArmorLegsSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLegsSlotId, (void*) &equipmentArmorLegsSlotId);
        return equipmentArmorLegsSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLegsSlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ArmorLevel
    {
      get
      {
        int equipmentArmorLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLevel, (void*) &equipmentArmorLevel);
        return equipmentArmorLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ArmorLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_CloakSlotEntity
    {
      get
      {
        int equipmentCloakSlotEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_CloakSlotEntity, (void*) &equipmentCloakSlotEntity);
        return equipmentCloakSlotEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_CloakSlotEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_CloakSlotId
    {
      get
      {
        int equipmentCloakSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_CloakSlotId, (void*) &equipmentCloakSlotId);
        return equipmentCloakSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_CloakSlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ClothChestSlotEntity
    {
      get
      {
        int clothChestSlotEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothChestSlotEntity, (void*) &clothChestSlotEntity);
        return clothChestSlotEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothChestSlotEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ClothChestSlotId
    {
      get
      {
        int clothChestSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothChestSlotId, (void*) &clothChestSlotId);
        return clothChestSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothChestSlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ClothLegsSlotEntity
    {
      get
      {
        int clothLegsSlotEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothLegsSlotEntity, (void*) &clothLegsSlotEntity);
        return clothLegsSlotEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothLegsSlotEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_ClothLegsSlotId
    {
      get
      {
        int equipmentClothLegsSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothLegsSlotId, (void*) &equipmentClothLegsSlotId);
        return equipmentClothLegsSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_ClothLegsSlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_GrimoireSlotEntity
    {
      get
      {
        int grimoireSlotEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_GrimoireSlotEntity, (void*) &grimoireSlotEntity);
        return grimoireSlotEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_GrimoireSlotEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_GrimoireSlotId
    {
      get
      {
        int equipmentGrimoireSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_GrimoireSlotId, (void*) &equipmentGrimoireSlotId);
        return equipmentGrimoireSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_GrimoireSlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_SpellLevel
    {
      get
      {
        int equipmentSpellLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_SpellLevel, (void*) &equipmentSpellLevel);
        return equipmentSpellLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_SpellLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_WeaponLevel
    {
      get
      {
        int equipmentWeaponLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponLevel, (void*) &equipmentWeaponLevel);
        return equipmentWeaponLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_WeaponSlotEntity
    {
      get
      {
        int weaponSlotEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponSlotEntity, (void*) &weaponSlotEntity);
        return weaponSlotEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponSlotEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equipment_WeaponSlotId
    {
      get
      {
        int equipmentWeaponSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponSlotId, (void*) &equipmentWeaponSlotId);
        return equipmentWeaponSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Equipment_WeaponSlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_FallToHeight_Gravity
    {
      get
      {
        int fallToHeightGravity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight_Gravity, (void*) &fallToHeightGravity);
        return fallToHeightGravity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight_Gravity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_IsDead
    {
      get
      {
        int indexHealthIsDead;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &indexHealthIsDead);
        return indexHealthIsDead;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxHealth
    {
      get
      {
        int indexHealthMaxHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &indexHealthMaxHealth);
        return indexHealthMaxHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxRecoveryHealth
    {
      get
      {
        int maxRecoveryHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &maxRecoveryHealth);
        return maxRecoveryHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_TimeOfDeath
    {
      get
      {
        int healthTimeOfDeath;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &healthTimeOfDeath);
        return healthTimeOfDeath;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_Value
    {
      get
      {
        int indexHealthValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &indexHealthValue);
        return indexHealthValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Height_ServerHeightLevel
    {
      get
      {
        int serverHeightLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel, (void*) &serverHeightLevel);
        return serverHeightLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_HybridModelSeed_Seed
    {
      get
      {
        int hybridModelSeedSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed, (void*) &hybridModelSeedSeed);
        return hybridModelSeedSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon_Interacting
    {
      get
      {
        int interactedUponInteracting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &interactedUponInteracting);
        return interactedUponInteracting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_IsSpellControlled_Value
    {
      get
      {
        int spellControlledValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value, (void*) &spellControlledValue);
        return spellControlledValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeLeech_AffectRecovery
    {
      get
      {
        int leechAffectRecovery;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_AffectRecovery, (void*) &leechAffectRecovery);
        return leechAffectRecovery;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_AffectRecovery, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeLeech_PhysicalLifeLeechFactor
    {
      get
      {
        int physicalLifeLeechFactor;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_PhysicalLifeLeechFactor, (void*) &physicalLifeLeechFactor);
        return physicalLifeLeechFactor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_PhysicalLifeLeechFactor, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeLeech_PrimaryLeechFactor
    {
      get
      {
        int primaryLeechFactor;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_PrimaryLeechFactor, (void*) &primaryLeechFactor);
        return primaryLeechFactor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_PrimaryLeechFactor, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeLeech_SpellLifeLeechFactor
    {
      get
      {
        int spellLifeLeechFactor;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_SpellLifeLeechFactor, (void*) &spellLifeLeechFactor);
        return spellLifeLeechFactor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_LifeLeech_SpellLifeLeechFactor, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Mounter_Acceleration
    {
      get
      {
        int mounterAcceleration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_Acceleration, (void*) &mounterAcceleration);
        return mounterAcceleration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_Acceleration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Mounter_GallopMaxSpeed
    {
      get
      {
        int mounterGallopMaxSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_GallopMaxSpeed, (void*) &mounterGallopMaxSpeed);
        return mounterGallopMaxSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_GallopMaxSpeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Mounter_GallopMaxSpeedMultiplier
    {
      get
      {
        int maxSpeedMultiplier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_GallopMaxSpeedMultiplier, (void*) &maxSpeedMultiplier);
        return maxSpeedMultiplier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_GallopMaxSpeedMultiplier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Mounter_TurnRate
    {
      get
      {
        int indexMounterTurnRate;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_TurnRate, (void*) &indexMounterTurnRate);
        return indexMounterTurnRate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Mounter_TurnRate, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Movement_Speed
    {
      get
      {
        int indexMovementSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed, (void*) &indexMovementSpeed);
        return indexMovementSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime
    {
      get
      {
        int clientCommandTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime, (void*) &clientCommandTime);
        return clientCommandTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_Movement
    {
      get
      {
        int interpolatedSharedMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement, (void*) &interpolatedSharedMovement);
        return interpolatedSharedMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity
    {
      get
      {
        int serverMoveVelocity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity, (void*) &serverMoveVelocity);
        return serverMoveVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition
    {
      get
      {
        int sharedServerPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition, (void*) &sharedServerPosition);
        return sharedServerPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation
    {
      get
      {
        int sharedServerRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation, (void*) &sharedServerRotation);
        return sharedServerRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity
    {
      get
      {
        int sharedServerVelocity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity, (void*) &sharedServerVelocity);
        return sharedServerVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_Simulate
    {
      get
      {
        int interpolatedSharedSimulate;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate, (void*) &interpolatedSharedSimulate);
        return interpolatedSharedSimulate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlayerCharacter_Name
    {
      get
      {
        int playerCharacterName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter_Name, (void*) &playerCharacterName);
        return playerCharacterName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter_Name, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlayerCharacter_SmartClanName
    {
      get
      {
        int characterSmartClanName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter_SmartClanName, (void*) &characterSmartClanName);
        return characterSmartClanName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_PlayerCharacter_SmartClanName, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RespawnCharacter_IsReadyToRespawn
    {
      get
      {
        int isReadyToRespawn;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter_IsReadyToRespawn, (void*) &isReadyToRespawn);
        return isReadyToRespawn;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter_IsReadyToRespawn, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RespawnCharacter_TimeOfDeath
    {
      get
      {
        int characterTimeOfDeath;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter_TimeOfDeath, (void*) &characterTimeOfDeath);
        return characterTimeOfDeath;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_RespawnCharacter_TimeOfDeath, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Stealthable_IsStealthed
    {
      get
      {
        int stealthableIsStealthed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_IsStealthed, (void*) &stealthableIsStealthed);
        return stealthableIsStealthed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_IsStealthed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Stealthable_ModelInvisible
    {
      get
      {
        int stealthableModelInvisible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_ModelInvisible, (void*) &stealthableModelInvisible);
        return stealthableModelInvisible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_ModelInvisible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Stealthable_StealthBushId
    {
      get
      {
        int stealthableStealthBushId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_StealthBushId, (void*) &stealthableStealthBushId);
        return stealthableStealthBushId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_StealthBushId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TakeDamageInSun_SunDamageDisabled
    {
      get
      {
        int sunDamageDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TakeDamageInSun_SunDamageDisabled, (void*) &sunDamageDisabled);
        return sunDamageDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TakeDamageInSun_SunDamageDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_AimDirection
    {
      get
      {
        int directionAimDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection, (void*) &directionAimDirection);
        return directionAimDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_DefaultRotationSpeed
    {
      get
      {
        int defaultRotationSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed, (void*) &defaultRotationSpeed);
        return defaultRotationSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_Direction
    {
      get
      {
        int directionDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction, (void*) &directionDirection);
        return directionDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement
    {
      get
      {
        int rotateTowardsMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement, (void*) &rotateTowardsMovement);
        return rotateTowardsMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_RotateTowardsMouse
    {
      get
      {
        int rotateTowardsMouse;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse, (void*) &rotateTowardsMouse);
        return rotateTowardsMouse;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TravelToTargetRadius_Radius
    {
      get
      {
        int targetRadiusRadius;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TravelToTargetRadius_Radius, (void*) &targetRadiusRadius);
        return targetRadiusRadius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_TravelToTargetRadius_Radius, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_AttackSpeed
    {
      get
      {
        int statsAttackSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_AttackSpeed, (void*) &statsAttackSpeed);
        return statsAttackSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_AttackSpeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_FireResistance
    {
      get
      {
        int statsFireResistance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_FireResistance, (void*) &statsFireResistance);
        return statsFireResistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_FireResistance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_GarlicResistance
    {
      get
      {
        int garlicResistance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_GarlicResistance, (void*) &garlicResistance);
        return garlicResistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_GarlicResistance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_HealthRecovery
    {
      get
      {
        int statsHealthRecovery;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_HealthRecovery, (void*) &statsHealthRecovery);
        return statsHealthRecovery;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_HealthRecovery, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_HolyResistance
    {
      get
      {
        int statsHolyResistance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_HolyResistance, (void*) &statsHolyResistance);
        return statsHolyResistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_HolyResistance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_PassiveHealthRegen
    {
      get
      {
        int passiveHealthRegen;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PassiveHealthRegen, (void*) &passiveHealthRegen);
        return passiveHealthRegen;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PassiveHealthRegen, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_PhysicalCriticalStrikeChance
    {
      get
      {
        int criticalStrikeChance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalCriticalStrikeChance, (void*) &criticalStrikeChance);
        return criticalStrikeChance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalCriticalStrikeChance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_PhysicalCriticalStrikeDamage
    {
      get
      {
        int criticalStrikeDamage;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalCriticalStrikeDamage, (void*) &criticalStrikeDamage);
        return criticalStrikeDamage;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalCriticalStrikeDamage, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_PhysicalPower
    {
      get
      {
        int statsPhysicalPower;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalPower, (void*) &statsPhysicalPower);
        return statsPhysicalPower;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalPower, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_PhysicalResistance
    {
      get
      {
        int physicalResistance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalResistance, (void*) &physicalResistance);
        return physicalResistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PhysicalResistance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_PrimaryAttackSpeed
    {
      get
      {
        int primaryAttackSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PrimaryAttackSpeed, (void*) &primaryAttackSpeed);
        return primaryAttackSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PrimaryAttackSpeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_PvPProtected
    {
      get
      {
        int statsPvPprotected;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PvPProtected, (void*) &statsPvPprotected);
        return statsPvPprotected;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PvPProtected, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_PvPResilience
    {
      get
      {
        int statsPvPresilience;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PvPResilience, (void*) &statsPvPresilience);
        return statsPvPresilience;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_PvPResilience, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_ReducedResourceDurabilityLoss
    {
      get
      {
        int resourceDurabilityLoss;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ReducedResourceDurabilityLoss, (void*) &resourceDurabilityLoss);
        return resourceDurabilityLoss;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ReducedResourceDurabilityLoss, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_ResourcePower
    {
      get
      {
        int statsResourcePower;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ResourcePower, (void*) &statsResourcePower);
        return statsResourcePower;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ResourcePower, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_ResourceYieldModifier
    {
      get
      {
        int resourceYieldModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ResourceYieldModifier, (void*) &resourceYieldModifier);
        return resourceYieldModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_ResourceYieldModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_SiegePower
    {
      get
      {
        int unitStatsSiegePower;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SiegePower, (void*) &unitStatsSiegePower);
        return unitStatsSiegePower;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SiegePower, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_SilverResistance
    {
      get
      {
        int silverResistance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SilverResistance, (void*) &silverResistance);
        return silverResistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SilverResistance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_SpellCriticalStrikeChance
    {
      get
      {
        int criticalStrikeChance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellCriticalStrikeChance, (void*) &criticalStrikeChance);
        return criticalStrikeChance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellCriticalStrikeChance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_SpellCriticalStrikeDamage
    {
      get
      {
        int criticalStrikeDamage;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellCriticalStrikeDamage, (void*) &criticalStrikeDamage);
        return criticalStrikeDamage;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellCriticalStrikeDamage, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_SpellPower
    {
      get
      {
        int unitStatsSpellPower;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellPower, (void*) &unitStatsSpellPower);
        return unitStatsSpellPower;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellPower, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_SpellResistance
    {
      get
      {
        int statsSpellResistance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellResistance, (void*) &statsSpellResistance);
        return statsSpellResistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SpellResistance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitStats_SunResistance
    {
      get
      {
        int statsSunResistance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SunResistance, (void*) &statsSunResistance);
        return statsSunResistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_UnitStats_SunResistance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Vision_Range
    {
      get
      {
        int indexVisionRange;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Vision_Range, (void*) &indexVisionRange);
        return indexVisionRange;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_FrameChangedIndex_Vision_Range, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BagHolder
    {
      get
      {
        int startOffsetBagHolder;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_BagHolder, (void*) &startOffsetBagHolder);
        return startOffsetBagHolder;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_BagHolder, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BagHolder
    {
      get
      {
        int dataSizeBagHolder;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_BagHolder, (void*) &dataSizeBagHolder);
        return dataSizeBagHolder;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_BagHolder, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Blood
    {
      get
      {
        int startOffsetBlood;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Blood, (void*) &startOffsetBlood);
        return startOffsetBlood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Blood, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Blood
    {
      get
      {
        int componentDataSizeBlood;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Blood, (void*) &componentDataSizeBlood);
        return componentDataSizeBlood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Blood, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CanFly
    {
      get
      {
        int startOffsetCanFly;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CanFly, (void*) &startOffsetCanFly);
        return startOffsetCanFly;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CanFly, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CanFly
    {
      get
      {
        int componentDataSizeCanFly;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CanFly, (void*) &componentDataSizeCanFly);
        return componentDataSizeCanFly;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CanFly, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CharacterVoiceActivity
    {
      get
      {
        int characterVoiceActivity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CharacterVoiceActivity, (void*) &characterVoiceActivity);
        return characterVoiceActivity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CharacterVoiceActivity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CharacterVoiceActivity
    {
      get
      {
        int characterVoiceActivity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CharacterVoiceActivity, (void*) &characterVoiceActivity);
        return characterVoiceActivity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CharacterVoiceActivity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CombatMusicListener_Shared
    {
      get
      {
        int musicListenerShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CombatMusicListener_Shared, (void*) &musicListenerShared);
        return musicListenerShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CombatMusicListener_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CombatMusicListener_Shared
    {
      get
      {
        int musicListenerShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CombatMusicListener_Shared, (void*) &musicListenerShared);
        return musicListenerShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CombatMusicListener_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CustomizationFeatures
    {
      get
      {
        int customizationFeatures;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CustomizationFeatures, (void*) &customizationFeatures);
        return customizationFeatures;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_CustomizationFeatures, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CustomizationFeatures
    {
      get
      {
        int customizationFeatures;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CustomizationFeatures, (void*) &customizationFeatures);
        return customizationFeatures;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_CustomizationFeatures, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DeathRagdollForce
    {
      get
      {
        int deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DeathRagdollForce
    {
      get
      {
        int deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Energy
    {
      get
      {
        int startOffsetEnergy;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Energy, (void*) &startOffsetEnergy);
        return startOffsetEnergy;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Energy, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Energy
    {
      get
      {
        int componentDataSizeEnergy;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Energy, (void*) &componentDataSizeEnergy);
        return componentDataSizeEnergy;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Energy, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Equipment
    {
      get
      {
        int startOffsetEquipment;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Equipment, (void*) &startOffsetEquipment);
        return startOffsetEquipment;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Equipment, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Equipment
    {
      get
      {
        int dataSizeEquipment;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Equipment, (void*) &dataSizeEquipment);
        return dataSizeEquipment;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Equipment, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_FallToHeight
    {
      get
      {
        int offsetFallToHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_FallToHeight, (void*) &offsetFallToHeight);
        return offsetFallToHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_FallToHeight, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_FallToHeight
    {
      get
      {
        int sizeFallToHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_FallToHeight, (void*) &sizeFallToHeight);
        return sizeFallToHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_FallToHeight, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Health
    {
      get
      {
        int startOffsetHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &startOffsetHealth);
        return startOffsetHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Health
    {
      get
      {
        int componentDataSizeHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &componentDataSizeHealth);
        return componentDataSizeHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Height
    {
      get
      {
        int startOffsetHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Height, (void*) &startOffsetHeight);
        return startOffsetHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Height, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Height
    {
      get
      {
        int componentDataSizeHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Height, (void*) &componentDataSizeHeight);
        return componentDataSizeHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Height, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_HybridModelSeed
    {
      get
      {
        int offsetHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed, (void*) &offsetHybridModelSeed);
        return offsetHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_HybridModelSeed
    {
      get
      {
        int sizeHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed, (void*) &sizeHybridModelSeed);
        return sizeHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InteractedUpon
    {
      get
      {
        int offsetInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &offsetInteractedUpon);
        return offsetInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InteractedUpon
    {
      get
      {
        int sizeInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &sizeInteractedUpon);
        return sizeInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeLeech
    {
      get
      {
        int startOffsetLifeLeech;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_LifeLeech, (void*) &startOffsetLifeLeech);
        return startOffsetLifeLeech;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_LifeLeech, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeLeech
    {
      get
      {
        int dataSizeLifeLeech;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_LifeLeech, (void*) &dataSizeLifeLeech);
        return dataSizeLifeLeech;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_LifeLeech, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Mounter
    {
      get
      {
        int startOffsetMounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Mounter, (void*) &startOffsetMounter);
        return startOffsetMounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Mounter, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Mounter
    {
      get
      {
        int componentDataSizeMounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Mounter, (void*) &componentDataSizeMounter);
        return componentDataSizeMounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Mounter, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Movement
    {
      get
      {
        int startOffsetMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Movement, (void*) &startOffsetMovement);
        return startOffsetMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Movement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Movement
    {
      get
      {
        int dataSizeMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Movement, (void*) &dataSizeMovement);
        return dataSizeMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Movement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_PlayerCharacter
    {
      get
      {
        int offsetPlayerCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_PlayerCharacter, (void*) &offsetPlayerCharacter);
        return offsetPlayerCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_PlayerCharacter, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_PlayerCharacter
    {
      get
      {
        int sizePlayerCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_PlayerCharacter, (void*) &sizePlayerCharacter);
        return sizePlayerCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_PlayerCharacter, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_RespawnCharacter
    {
      get
      {
        int respawnCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_RespawnCharacter, (void*) &respawnCharacter);
        return respawnCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_RespawnCharacter, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_RespawnCharacter
    {
      get
      {
        int respawnCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_RespawnCharacter, (void*) &respawnCharacter);
        return respawnCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_RespawnCharacter, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Stealthable
    {
      get
      {
        int offsetStealthable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Stealthable, (void*) &offsetStealthable);
        return offsetStealthable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Stealthable, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Stealthable
    {
      get
      {
        int dataSizeStealthable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Stealthable, (void*) &dataSizeStealthable);
        return dataSizeStealthable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Stealthable, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TakeDamageInSun
    {
      get
      {
        int offsetTakeDamageInSun;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TakeDamageInSun, (void*) &offsetTakeDamageInSun);
        return offsetTakeDamageInSun;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TakeDamageInSun, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TakeDamageInSun
    {
      get
      {
        int sizeTakeDamageInSun;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TakeDamageInSun, (void*) &sizeTakeDamageInSun);
        return sizeTakeDamageInSun;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TakeDamageInSun, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TargetDirection
    {
      get
      {
        int offsetTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection, (void*) &offsetTargetDirection);
        return offsetTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TargetDirection
    {
      get
      {
        int sizeTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TargetDirection, (void*) &sizeTargetDirection);
        return sizeTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TravelToTargetRadius
    {
      get
      {
        int travelToTargetRadius;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TravelToTargetRadius, (void*) &travelToTargetRadius);
        return travelToTargetRadius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_TravelToTargetRadius, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TravelToTargetRadius
    {
      get
      {
        int travelToTargetRadius;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TravelToTargetRadius, (void*) &travelToTargetRadius);
        return travelToTargetRadius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_TravelToTargetRadius, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_UnitStats
    {
      get
      {
        int startOffsetUnitStats;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_UnitStats, (void*) &startOffsetUnitStats);
        return startOffsetUnitStats;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_UnitStats, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_UnitStats
    {
      get
      {
        int dataSizeUnitStats;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_UnitStats, (void*) &dataSizeUnitStats);
        return dataSizeUnitStats;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_UnitStats, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Vision
    {
      get
      {
        int startOffsetVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Vision, (void*) &startOffsetVision);
        return startOffsetVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataStartOffset_Vision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Vision
    {
      get
      {
        int componentDataSizeVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Vision, (void*) &componentDataSizeVision);
        return componentDataSizeVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_ComponentDataSize_Vision, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityBar_Shared
    {
      get
      {
        ulong abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BagHolder
    {
      get
      {
        ulong compBitBagHolder;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_BagHolder, (void*) &compBitBagHolder);
        return compBitBagHolder;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_BagHolder, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Blood
    {
      get
      {
        ulong compBitBlood;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Blood, (void*) &compBitBlood);
        return compBitBlood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Blood, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CanFly
    {
      get
      {
        ulong compBitCanFly;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CanFly, (void*) &compBitCanFly);
        return compBitCanFly;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CanFly, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CharacterVoiceActivity
    {
      get
      {
        ulong characterVoiceActivity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CharacterVoiceActivity, (void*) &characterVoiceActivity);
        return characterVoiceActivity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CharacterVoiceActivity, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CombatMusicListener_Shared
    {
      get
      {
        ulong musicListenerShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CombatMusicListener_Shared, (void*) &musicListenerShared);
        return musicListenerShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CombatMusicListener_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CustomizationFeatures
    {
      get
      {
        ulong customizationFeatures;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CustomizationFeatures, (void*) &customizationFeatures);
        return customizationFeatures;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_CustomizationFeatures, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DeathRagdollForce
    {
      get
      {
        ulong deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DynamicCollision
    {
      get
      {
        ulong dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Energy
    {
      get
      {
        ulong compBitEnergy;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Energy, (void*) &compBitEnergy);
        return compBitEnergy;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Energy, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Equipment
    {
      get
      {
        ulong compBitEquipment;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Equipment, (void*) &compBitEquipment);
        return compBitEquipment;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Equipment, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_FallToHeight
    {
      get
      {
        ulong compBitFallToHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_FallToHeight, (void*) &compBitFallToHeight);
        return compBitFallToHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_FallToHeight, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Health
    {
      get
      {
        ulong compBitHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Health, (void*) &compBitHealth);
        return compBitHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Health, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Height
    {
      get
      {
        ulong compBitHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Height, (void*) &compBitHeight);
        return compBitHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Height, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_HybridModelSeed
    {
      get
      {
        ulong bitHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_HybridModelSeed, (void*) &bitHybridModelSeed);
        return bitHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InteractedUpon
    {
      get
      {
        ulong bitInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &bitInteractedUpon);
        return bitInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_IsSpellControlled
    {
      get
      {
        ulong isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeLeech
    {
      get
      {
        ulong compBitLifeLeech;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_LifeLeech, (void*) &compBitLifeLeech);
        return compBitLifeLeech;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_LifeLeech, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Mounter
    {
      get
      {
        ulong compBitMounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Mounter, (void*) &compBitMounter);
        return compBitMounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Mounter, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Movement
    {
      get
      {
        ulong compBitMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Movement, (void*) &compBitMovement);
        return compBitMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Movement, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_NetworkInterpolated_Shared
    {
      get
      {
        ulong interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_PlayerCharacter
    {
      get
      {
        ulong bitPlayerCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_PlayerCharacter, (void*) &bitPlayerCharacter);
        return bitPlayerCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_PlayerCharacter, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_RespawnCharacter
    {
      get
      {
        ulong respawnCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_RespawnCharacter, (void*) &respawnCharacter);
        return respawnCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_RespawnCharacter, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Stealthable
    {
      get
      {
        ulong compBitStealthable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Stealthable, (void*) &compBitStealthable);
        return compBitStealthable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Stealthable, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TakeDamageInSun
    {
      get
      {
        ulong bitTakeDamageInSun;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TakeDamageInSun, (void*) &bitTakeDamageInSun);
        return bitTakeDamageInSun;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TakeDamageInSun, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TargetDirection
    {
      get
      {
        ulong bitTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TargetDirection, (void*) &bitTargetDirection);
        return bitTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TargetDirection, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TravelToTargetRadius
    {
      get
      {
        ulong travelToTargetRadius;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TravelToTargetRadius, (void*) &travelToTargetRadius);
        return travelToTargetRadius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_TravelToTargetRadius, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_UnitStats
    {
      get
      {
        ulong compBitUnitStats;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_UnitStats, (void*) &compBitUnitStats);
        return compBitUnitStats;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_UnitStats, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Vision
    {
      get
      {
        ulong compBitVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Vision, (void*) &compBitVision);
        return compBitVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_Vision, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_FollowerBuffer
    {
      get
      {
        ulong bitFollowerBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_FollowerBuffer, (void*) &bitFollowerBuffer);
        return bitFollowerBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_FollowerBuffer, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InventoryInstanceElement
    {
      get
      {
        ulong inventoryInstanceElement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_InventoryInstanceElement, (void*) &inventoryInstanceElement);
        return inventoryInstanceElement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbdgdebikk.NativeFieldInfoPtr_CompBit_InventoryInstanceElement, (void*) &value);
      }
    }
  }
}
