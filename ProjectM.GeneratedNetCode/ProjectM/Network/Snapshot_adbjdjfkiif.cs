// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_adbjdjfkiif
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_adbjdjfkiif
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
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroConsumer_AggroReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroConsumer_AggroTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroConsumer_AlertTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroConsumer_DeaggroReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiMove_Shared_HasNextWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiMove_Shared_HasWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiMove_Shared_NextWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiMove_Shared_Waypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeathRagdollForce_Force;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_RadiusVariation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Height_ServerHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybridModelSeed_Seed;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSpellControlled_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Movement_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_LastClientCommandTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerMoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_Simulate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stealthable_IsStealthed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stealthable_ModelInvisible;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stealthable_StealthBushId;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Torture_TortureModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevel_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_Vision_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AggroConsumer_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AggroConsumer_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Movement_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Movement_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Stealthable_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Stealthable_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Torture_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Torture_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Vision_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Vision_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Stealthable;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Torture;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Vision;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AggroReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AggroTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AlertTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_DeaggroReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasNextWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_NextWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_Waypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Stealthable_IsStealthed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Stealthable_ModelInvisible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Stealthable_StealthBushId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Torture_TortureModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Vision_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AggroConsumer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AggroConsumer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AiMove_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AiMove_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DynamicCollision;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Stealthable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Stealthable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Torture;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Torture;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Vision;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Vision;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AggroConsumer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AiMove_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Stealthable;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Torture;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Vision;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
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
    public AggroReason AggroConsumer_AggroReason;
    [FieldOffset(116)]
    public NetworkId AggroConsumer_AggroTarget;
    [FieldOffset(124)]
    public NetworkId AggroConsumer_AlertTarget;
    [FieldOffset(132)]
    public DeaggroReason AggroConsumer_DeaggroReason;
    [FieldOffset(136)]
    public bool AiMove_Shared_HasNextWaypoint;
    [FieldOffset(137)]
    public bool AiMove_Shared_HasWaypoint;
    [FieldOffset(138)]
    public int2 AiMove_Shared_NextWaypoint;
    [FieldOffset(146)]
    public int2 AiMove_Shared_Waypoint;
    [FieldOffset(154)]
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(170)]
    public float3 DeathRagdollForce_Force;
    [FieldOffset(182)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_HardnessThreshold;
    [FieldOffset(190)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_PushStrengthMax;
    [FieldOffset(198)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_PushStrengthMin;
    [FieldOffset(206)]
    public ModifiableFloat DynamicCollision_AgainstUnits_HardnessThreshold;
    [FieldOffset(214)]
    public ModifiableFloat DynamicCollision_AgainstUnits_PushStrengthMax;
    [FieldOffset(222)]
    public ModifiableFloat DynamicCollision_AgainstUnits_PushStrengthMin;
    [FieldOffset(230)]
    public float DynamicCollision_AgainstUnits_RadiusVariation;
    [FieldOffset(234)]
    public bool Health_IsDead;
    [FieldOffset(235)]
    public ModifiableFloat Health_MaxHealth;
    [FieldOffset(243)]
    public float Health_MaxRecoveryHealth;
    [FieldOffset(247)]
    public double Health_TimeOfDeath;
    [FieldOffset(255)]
    public float Health_Value;
    [FieldOffset(259)]
    public byte Height_ServerHeightLevel;
    [FieldOffset(260)]
    public ushort HybridModelSeed_Seed;
    [FieldOffset(262)]
    public bool InteractedUpon_Interacting;
    [FieldOffset(263)]
    public ModifiableBool IsSpellControlled_Value;
    [FieldOffset(267)]
    public ModifiableFloat Movement_Speed;
    [FieldOffset(275)]
    public double NetworkInterpolated_Shared_LastClientCommandTime;
    [FieldOffset(283)]
    public float2 NetworkInterpolated_Shared_Movement;
    [FieldOffset(291)]
    public float NetworkInterpolated_Shared_ServerMoveVelocity;
    [FieldOffset(295)]
    public float2 NetworkInterpolated_Shared_ServerPosition;
    [FieldOffset(303)]
    public quaternion NetworkInterpolated_Shared_ServerRotation;
    [FieldOffset(319)]
    public float2 NetworkInterpolated_Shared_ServerVelocity;
    [FieldOffset(327)]
    public bool NetworkInterpolated_Shared_Simulate;
    [FieldOffset(328)]
    public ModifiableBool Stealthable_IsStealthed;
    [FieldOffset(332)]
    public ModifiableBool Stealthable_ModelInvisible;
    [FieldOffset(336)]
    public ModifiableInt Stealthable_StealthBushId;
    [FieldOffset(344)]
    public float3 TargetDirection_AimDirection;
    [FieldOffset(356)]
    public float TargetDirection_DefaultRotationSpeed;
    [FieldOffset(360)]
    public float3 TargetDirection_Direction;
    [FieldOffset(372)]
    public ModifiableBool TargetDirection_ForceRotateTowardsMovement;
    [FieldOffset(376)]
    public ModifiableBool TargetDirection_RotateTowardsMouse;
    [FieldOffset(380)]
    public int Team_FactionIndex;
    [FieldOffset(384)]
    public int Team_Value;
    [FieldOffset(388)]
    public TileType TileModel_DisabledTileTypes;
    [FieldOffset(389)]
    public float Torture_TortureModifier;
    [FieldOffset(393)]
    public int UnitLevel_Level;
    [FieldOffset(397)]
    public ModifiableFloat Vision_Range;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1539180, XrefRangeEnd = 1539687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_adbjdjfkiif.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1539906, RefRangeEnd = 1539907, XrefRangeStart = 1539687, XrefRangeEnd = 1539906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_adbjdjfkiif.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_adbjdjfkiif()
    {
      Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_adbjdjfkiif));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr);
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_CastAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_CastAbility));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_CastAbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_CastAbilityPrefabGuid));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_CastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_CastGroup));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_CastGroupPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_CastGroupPrefabGuid));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_CastStartTime));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_CastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_CastTime));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_CooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_CooldownModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_GlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_GlobalCooldown));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_InterruptTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_InterruptTypes));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_LimitAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_LimitAbilityPriority));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_PostCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_PostCastTime));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_PrimaryCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_PrimaryCooldownModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_ServerCastCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_ServerCastCounter));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_ServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_ServerInterruptCounter));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_SpellCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_SpellCooldownModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_TravelCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_TravelCooldownModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AbilityBar_Shared_WeaponCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AbilityBar_Shared_WeaponCooldownModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AggroConsumer_AggroReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AggroConsumer_AggroReason));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AggroConsumer_AggroTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AggroConsumer_AggroTarget));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AggroConsumer_AlertTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AggroConsumer_AlertTarget));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AggroConsumer_DeaggroReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AggroConsumer_DeaggroReason));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AiMove_Shared_HasNextWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AiMove_Shared_HasNextWaypoint));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AiMove_Shared_HasWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AiMove_Shared_HasWaypoint));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AiMove_Shared_NextWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AiMove_Shared_NextWaypoint));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_AiMove_Shared_Waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (AiMove_Shared_Waypoint));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_DeathRagdollForce_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (DeathRagdollForce_Force));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_HardnessThreshold));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_PushStrengthMax));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_PushStrengthMin));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_HardnessThreshold));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_PushStrengthMax));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_PushStrengthMin));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_RadiusVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_RadiusVariation));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Health_IsDead));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Health_MaxHealth));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Health_MaxRecoveryHealth));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Health_TimeOfDeath));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Health_Value));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Height_ServerHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Height_ServerHeightLevel));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_HybridModelSeed_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (HybridModelSeed_Seed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (InteractedUpon_Interacting));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_IsSpellControlled_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (IsSpellControlled_Value));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Movement_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Movement_Speed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_NetworkInterpolated_Shared_LastClientCommandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (NetworkInterpolated_Shared_LastClientCommandTime));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_NetworkInterpolated_Shared_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (NetworkInterpolated_Shared_Movement));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerMoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerMoveVelocity));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerPosition));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerRotation));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerVelocity));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_NetworkInterpolated_Shared_Simulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (NetworkInterpolated_Shared_Simulate));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Stealthable_IsStealthed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Stealthable_IsStealthed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Stealthable_ModelInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Stealthable_ModelInvisible));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Stealthable_StealthBushId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Stealthable_StealthBushId));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_TargetDirection_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (TargetDirection_AimDirection));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_TargetDirection_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (TargetDirection_DefaultRotationSpeed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_TargetDirection_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (TargetDirection_Direction));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_TargetDirection_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (TargetDirection_ForceRotateTowardsMovement));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_TargetDirection_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (TargetDirection_RotateTowardsMouse));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Team_Value));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Torture_TortureModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Torture_TortureModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_UnitLevel_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (UnitLevel_Level));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_Vision_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (Vision_Range));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_AbilityBar_Shared_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_AbilityBar_Shared_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AggroConsumer_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_AggroConsumer_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AggroConsumer_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_AggroConsumer_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_AiMove_Shared_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_AiMove_Shared_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_DeathRagdollForce_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_DeathRagdollForce_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_DynamicCollision_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_DynamicCollision_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Health_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Health_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Health_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Health_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Height_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Height_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Height_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Height_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_HybridModelSeed_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_HybridModelSeed_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_IsSpellControlled_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_IsSpellControlled_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Movement_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Movement_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Movement_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Movement_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_NetworkInterpolated_Shared_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_NetworkInterpolated_Shared_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Stealthable_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Stealthable_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_TargetDirection_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_TargetDirection_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Torture_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Torture_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Torture_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Torture_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_UnitLevel_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_UnitLevel_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Vision_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Vision_Start));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Vision_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedFields_Vision_Count));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AggroConsumer));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AiMove_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_DeathRagdollForce));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Health));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Height));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_HybridModelSeed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_IsSpellControlled));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Movement));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Stealthable));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Torture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Torture));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_UnitLevel));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Vision));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastAbility));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastGroup));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastStartTime));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastTime));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CooldownModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_GlobalCooldown));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_InterruptTypes));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_PostCastTime));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_ServerCastCounter));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AggroReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AggroConsumer_AggroReason));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AggroTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AggroConsumer_AggroTarget));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AlertTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AggroConsumer_AlertTarget));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_DeaggroReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AggroConsumer_DeaggroReason));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasNextWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AiMove_Shared_HasNextWaypoint));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AiMove_Shared_HasWaypoint));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_NextWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AiMove_Shared_NextWaypoint));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_Waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_AiMove_Shared_Waypoint));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_DeathRagdollForce_Force));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Health_IsDead));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxHealth));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxRecoveryHealth));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Health_TimeOfDeath));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Health_Value));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Height_ServerHeightLevel));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_HybridModelSeed_Seed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon_Interacting));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_IsSpellControlled_Value));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Movement_Speed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_Movement));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_Simulate));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_IsStealthed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Stealthable_IsStealthed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_ModelInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Stealthable_ModelInvisible));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_StealthBushId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Stealthable_StealthBushId));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_AimDirection));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_DefaultRotationSpeed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_Direction));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_RotateTowardsMouse));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Torture_TortureModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Torture_TortureModifier));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_UnitLevel_Level));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Vision_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (FrameChangedIndex_Vision_Range));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityBar_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_AbilityBar_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_AggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_AggroConsumer));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_AggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_AggroConsumer));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_AiMove_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_AiMove_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_AiMove_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_AiMove_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_DeathRagdollForce));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_DeathRagdollForce));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_DynamicCollision));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_DynamicCollision));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_Health));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_Health));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_Height));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_Height));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_HybridModelSeed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_HybridModelSeed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_InteractedUpon));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_InteractedUpon));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_IsSpellControlled));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_IsSpellControlled));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_Movement));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_Movement));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_NetworkInterpolated_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_NetworkInterpolated_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Stealthable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_Stealthable));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Stealthable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_Stealthable));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_TargetDirection));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_TargetDirection));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Torture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_Torture));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Torture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_Torture));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_UnitLevel));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_UnitLevel));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataStartOffset_Vision));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (ComponentDataSize_Vision));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_AbilityBar_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_AggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_AggroConsumer));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_AiMove_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_AiMove_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_DeathRagdollForce));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_DynamicCollision));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_Health));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_Height));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_HybridModelSeed));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_InteractedUpon));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_IsSpellControlled));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_Movement));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_NetworkInterpolated_Shared));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Stealthable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_Stealthable));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_TargetDirection));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Torture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_Torture));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_UnitLevel));
      Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, nameof (CompBit_Vision));
      Snapshot_adbjdjfkiif.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, 100664302);
      Snapshot_adbjdjfkiif.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, 100664303);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_adbjdjfkiif>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityBar_Shared_Start
    {
      get
      {
        int abilityBarSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start, (void*) &abilityBarSharedStart);
        return abilityBarSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityBar_Shared_Count
    {
      get
      {
        int abilityBarSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count, (void*) &abilityBarSharedCount);
        return abilityBarSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AggroConsumer_Start
    {
      get
      {
        int aggroConsumerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AggroConsumer_Start, (void*) &aggroConsumerStart);
        return aggroConsumerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AggroConsumer_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AggroConsumer_Count
    {
      get
      {
        int aggroConsumerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AggroConsumer_Count, (void*) &aggroConsumerCount);
        return aggroConsumerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AggroConsumer_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AiMove_Shared_Start
    {
      get
      {
        int aiMoveSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Start, (void*) &aiMoveSharedStart);
        return aiMoveSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AiMove_Shared_Count
    {
      get
      {
        int aiMoveSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Count, (void*) &aiMoveSharedCount);
        return aiMoveSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DeathRagdollForce_Start
    {
      get
      {
        int ragdollForceStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start, (void*) &ragdollForceStart);
        return ragdollForceStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DeathRagdollForce_Count
    {
      get
      {
        int ragdollForceCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count, (void*) &ragdollForceCount);
        return ragdollForceCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DynamicCollision_Start
    {
      get
      {
        int dynamicCollisionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start, (void*) &dynamicCollisionStart);
        return dynamicCollisionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DynamicCollision_Count
    {
      get
      {
        int dynamicCollisionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count, (void*) &dynamicCollisionCount);
        return dynamicCollisionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Start
    {
      get
      {
        int fieldsHealthStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &fieldsHealthStart);
        return fieldsHealthStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Count
    {
      get
      {
        int fieldsHealthCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &fieldsHealthCount);
        return fieldsHealthCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Height_Start
    {
      get
      {
        int fieldsHeightStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Height_Start, (void*) &fieldsHeightStart);
        return fieldsHeightStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Height_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Height_Count
    {
      get
      {
        int fieldsHeightCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Height_Count, (void*) &fieldsHeightCount);
        return fieldsHeightCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Height_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_HybridModelSeed_Start
    {
      get
      {
        int hybridModelSeedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start, (void*) &hybridModelSeedStart);
        return hybridModelSeedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_HybridModelSeed_Count
    {
      get
      {
        int hybridModelSeedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count, (void*) &hybridModelSeedCount);
        return hybridModelSeedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Start
    {
      get
      {
        int interactedUponStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &interactedUponStart);
        return interactedUponStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Count
    {
      get
      {
        int interactedUponCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &interactedUponCount);
        return interactedUponCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_IsSpellControlled_Start
    {
      get
      {
        int spellControlledStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start, (void*) &spellControlledStart);
        return spellControlledStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_IsSpellControlled_Count
    {
      get
      {
        int spellControlledCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count, (void*) &spellControlledCount);
        return spellControlledCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Movement_Start
    {
      get
      {
        int fieldsMovementStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Movement_Start, (void*) &fieldsMovementStart);
        return fieldsMovementStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Movement_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Movement_Count
    {
      get
      {
        int fieldsMovementCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Movement_Count, (void*) &fieldsMovementCount);
        return fieldsMovementCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Movement_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_NetworkInterpolated_Shared_Start
    {
      get
      {
        int interpolatedSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start, (void*) &interpolatedSharedStart);
        return interpolatedSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_NetworkInterpolated_Shared_Count
    {
      get
      {
        int interpolatedSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count, (void*) &interpolatedSharedCount);
        return interpolatedSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Stealthable_Start
    {
      get
      {
        int stealthableStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Start, (void*) &stealthableStart);
        return stealthableStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Stealthable_Count
    {
      get
      {
        int stealthableCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Count, (void*) &stealthableCount);
        return stealthableCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Stealthable_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TargetDirection_Start
    {
      get
      {
        int targetDirectionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start, (void*) &targetDirectionStart);
        return targetDirectionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TargetDirection_Count
    {
      get
      {
        int targetDirectionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count, (void*) &targetDirectionCount);
        return targetDirectionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Torture_Start
    {
      get
      {
        int fieldsTortureStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Torture_Start, (void*) &fieldsTortureStart);
        return fieldsTortureStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Torture_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Torture_Count
    {
      get
      {
        int fieldsTortureCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Torture_Count, (void*) &fieldsTortureCount);
        return fieldsTortureCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Torture_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UnitLevel_Start
    {
      get
      {
        int fieldsUnitLevelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start, (void*) &fieldsUnitLevelStart);
        return fieldsUnitLevelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UnitLevel_Count
    {
      get
      {
        int fieldsUnitLevelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count, (void*) &fieldsUnitLevelCount);
        return fieldsUnitLevelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_UnitLevel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Vision_Start
    {
      get
      {
        int fieldsVisionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Vision_Start, (void*) &fieldsVisionStart);
        return fieldsVisionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Vision_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Vision_Count
    {
      get
      {
        int fieldsVisionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Vision_Count, (void*) &fieldsVisionCount);
        return fieldsVisionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedFields_Vision_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AggroConsumer
    {
      get
      {
        int indexAggroConsumer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer, (void*) &indexAggroConsumer);
        return indexAggroConsumer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AiMove_Shared
    {
      get
      {
        int indexAiMoveShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared, (void*) &indexAiMoveShared);
        return indexAiMoveShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DeathRagdollForce
    {
      get
      {
        int deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health
    {
      get
      {
        int changedIndexHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &changedIndexHealth);
        return changedIndexHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Height
    {
      get
      {
        int changedIndexHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Height, (void*) &changedIndexHeight);
        return changedIndexHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_HybridModelSeed
    {
      get
      {
        int indexHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed, (void*) &indexHybridModelSeed);
        return indexHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon
    {
      get
      {
        int indexInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &indexInteractedUpon);
        return indexInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Movement
    {
      get
      {
        int changedIndexMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Movement, (void*) &changedIndexMovement);
        return changedIndexMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Movement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Stealthable
    {
      get
      {
        int indexStealthable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable, (void*) &indexStealthable);
        return indexStealthable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection
    {
      get
      {
        int indexTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection, (void*) &indexTargetDirection);
        return indexTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Torture
    {
      get
      {
        int changedIndexTorture;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Torture, (void*) &changedIndexTorture);
        return changedIndexTorture;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Torture, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitLevel
    {
      get
      {
        int changedIndexUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel, (void*) &changedIndexUnitLevel);
        return changedIndexUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Vision
    {
      get
      {
        int changedIndexVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Vision, (void*) &changedIndexVision);
        return changedIndexVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Vision, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastAbility
    {
      get
      {
        int sharedCastAbility;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility, (void*) &sharedCastAbility);
        return sharedCastAbility;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid
    {
      get
      {
        int abilityPrefabGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid, (void*) &abilityPrefabGuid);
        return abilityPrefabGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastGroup
    {
      get
      {
        int barSharedCastGroup;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup, (void*) &barSharedCastGroup);
        return barSharedCastGroup;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid
    {
      get
      {
        int castGroupPrefabGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid, (void*) &castGroupPrefabGuid);
        return castGroupPrefabGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastStartTime
    {
      get
      {
        int sharedCastStartTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime, (void*) &sharedCastStartTime);
        return sharedCastStartTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastTime
    {
      get
      {
        int barSharedCastTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime, (void*) &barSharedCastTime);
        return barSharedCastTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_GlobalCooldown
    {
      get
      {
        int sharedGlobalCooldown;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown, (void*) &sharedGlobalCooldown);
        return sharedGlobalCooldown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_InterruptTypes
    {
      get
      {
        int sharedInterruptTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes, (void*) &sharedInterruptTypes);
        return sharedInterruptTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority
    {
      get
      {
        int limitAbilityPriority;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority, (void*) &limitAbilityPriority);
        return limitAbilityPriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_PostCastTime
    {
      get
      {
        int sharedPostCastTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime, (void*) &sharedPostCastTime);
        return sharedPostCastTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_ServerCastCounter
    {
      get
      {
        int serverCastCounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter, (void*) &serverCastCounter);
        return serverCastCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter
    {
      get
      {
        int interruptCounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter, (void*) &interruptCounter);
        return interruptCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AggroConsumer_AggroReason
    {
      get
      {
        int consumerAggroReason;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AggroReason, (void*) &consumerAggroReason);
        return consumerAggroReason;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AggroReason, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AggroConsumer_AggroTarget
    {
      get
      {
        int consumerAggroTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AggroTarget, (void*) &consumerAggroTarget);
        return consumerAggroTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AggroTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AggroConsumer_AlertTarget
    {
      get
      {
        int consumerAlertTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AlertTarget, (void*) &consumerAlertTarget);
        return consumerAlertTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_AlertTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AggroConsumer_DeaggroReason
    {
      get
      {
        int consumerDeaggroReason;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_DeaggroReason, (void*) &consumerDeaggroReason);
        return consumerDeaggroReason;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AggroConsumer_DeaggroReason, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AiMove_Shared_HasNextWaypoint
    {
      get
      {
        int sharedHasNextWaypoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasNextWaypoint, (void*) &sharedHasNextWaypoint);
        return sharedHasNextWaypoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasNextWaypoint, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AiMove_Shared_HasWaypoint
    {
      get
      {
        int sharedHasWaypoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasWaypoint, (void*) &sharedHasWaypoint);
        return sharedHasWaypoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasWaypoint, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AiMove_Shared_NextWaypoint
    {
      get
      {
        int sharedNextWaypoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_NextWaypoint, (void*) &sharedNextWaypoint);
        return sharedNextWaypoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_NextWaypoint, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AiMove_Shared_Waypoint
    {
      get
      {
        int moveSharedWaypoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_Waypoint, (void*) &moveSharedWaypoint);
        return moveSharedWaypoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_Waypoint, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DeathRagdollForce_Force
    {
      get
      {
        int ragdollForceForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force, (void*) &ragdollForceForce);
        return ragdollForceForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold
    {
      get
      {
        int hardnessThreshold;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold, (void*) &hardnessThreshold);
        return hardnessThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax
    {
      get
      {
        int playersPushStrengthMax;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax, (void*) &playersPushStrengthMax);
        return playersPushStrengthMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin
    {
      get
      {
        int playersPushStrengthMin;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin, (void*) &playersPushStrengthMin);
        return playersPushStrengthMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold
    {
      get
      {
        int hardnessThreshold;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold, (void*) &hardnessThreshold);
        return hardnessThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax
    {
      get
      {
        int unitsPushStrengthMax;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax, (void*) &unitsPushStrengthMax);
        return unitsPushStrengthMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin
    {
      get
      {
        int unitsPushStrengthMin;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin, (void*) &unitsPushStrengthMin);
        return unitsPushStrengthMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation
    {
      get
      {
        int unitsRadiusVariation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation, (void*) &unitsRadiusVariation);
        return unitsRadiusVariation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_IsDead
    {
      get
      {
        int indexHealthIsDead;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &indexHealthIsDead);
        return indexHealthIsDead;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxHealth
    {
      get
      {
        int indexHealthMaxHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &indexHealthMaxHealth);
        return indexHealthMaxHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxRecoveryHealth
    {
      get
      {
        int maxRecoveryHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &maxRecoveryHealth);
        return maxRecoveryHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_TimeOfDeath
    {
      get
      {
        int healthTimeOfDeath;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &healthTimeOfDeath);
        return healthTimeOfDeath;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_Value
    {
      get
      {
        int indexHealthValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &indexHealthValue);
        return indexHealthValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Height_ServerHeightLevel
    {
      get
      {
        int serverHeightLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel, (void*) &serverHeightLevel);
        return serverHeightLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_HybridModelSeed_Seed
    {
      get
      {
        int hybridModelSeedSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed, (void*) &hybridModelSeedSeed);
        return hybridModelSeedSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon_Interacting
    {
      get
      {
        int interactedUponInteracting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &interactedUponInteracting);
        return interactedUponInteracting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_IsSpellControlled_Value
    {
      get
      {
        int spellControlledValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value, (void*) &spellControlledValue);
        return spellControlledValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Movement_Speed
    {
      get
      {
        int indexMovementSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed, (void*) &indexMovementSpeed);
        return indexMovementSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime
    {
      get
      {
        int clientCommandTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime, (void*) &clientCommandTime);
        return clientCommandTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_Movement
    {
      get
      {
        int interpolatedSharedMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement, (void*) &interpolatedSharedMovement);
        return interpolatedSharedMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity
    {
      get
      {
        int serverMoveVelocity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity, (void*) &serverMoveVelocity);
        return serverMoveVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition
    {
      get
      {
        int sharedServerPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition, (void*) &sharedServerPosition);
        return sharedServerPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation
    {
      get
      {
        int sharedServerRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation, (void*) &sharedServerRotation);
        return sharedServerRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity
    {
      get
      {
        int sharedServerVelocity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity, (void*) &sharedServerVelocity);
        return sharedServerVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_Simulate
    {
      get
      {
        int interpolatedSharedSimulate;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate, (void*) &interpolatedSharedSimulate);
        return interpolatedSharedSimulate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Stealthable_IsStealthed
    {
      get
      {
        int stealthableIsStealthed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_IsStealthed, (void*) &stealthableIsStealthed);
        return stealthableIsStealthed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_IsStealthed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Stealthable_ModelInvisible
    {
      get
      {
        int stealthableModelInvisible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_ModelInvisible, (void*) &stealthableModelInvisible);
        return stealthableModelInvisible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_ModelInvisible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Stealthable_StealthBushId
    {
      get
      {
        int stealthableStealthBushId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_StealthBushId, (void*) &stealthableStealthBushId);
        return stealthableStealthBushId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Stealthable_StealthBushId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_AimDirection
    {
      get
      {
        int directionAimDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection, (void*) &directionAimDirection);
        return directionAimDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_DefaultRotationSpeed
    {
      get
      {
        int defaultRotationSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed, (void*) &defaultRotationSpeed);
        return defaultRotationSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_Direction
    {
      get
      {
        int directionDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction, (void*) &directionDirection);
        return directionDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement
    {
      get
      {
        int rotateTowardsMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement, (void*) &rotateTowardsMovement);
        return rotateTowardsMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_RotateTowardsMouse
    {
      get
      {
        int rotateTowardsMouse;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse, (void*) &rotateTowardsMouse);
        return rotateTowardsMouse;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Torture_TortureModifier
    {
      get
      {
        int tortureTortureModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Torture_TortureModifier, (void*) &tortureTortureModifier);
        return tortureTortureModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Torture_TortureModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnitLevel_Level
    {
      get
      {
        int indexUnitLevelLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level, (void*) &indexUnitLevelLevel);
        return indexUnitLevelLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_UnitLevel_Level, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Vision_Range
    {
      get
      {
        int indexVisionRange;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Vision_Range, (void*) &indexVisionRange);
        return indexVisionRange;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_FrameChangedIndex_Vision_Range, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AggroConsumer
    {
      get
      {
        int offsetAggroConsumer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_AggroConsumer, (void*) &offsetAggroConsumer);
        return offsetAggroConsumer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_AggroConsumer, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AggroConsumer
    {
      get
      {
        int sizeAggroConsumer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_AggroConsumer, (void*) &sizeAggroConsumer);
        return sizeAggroConsumer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_AggroConsumer, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AiMove_Shared
    {
      get
      {
        int offsetAiMoveShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_AiMove_Shared, (void*) &offsetAiMoveShared);
        return offsetAiMoveShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_AiMove_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AiMove_Shared
    {
      get
      {
        int sizeAiMoveShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_AiMove_Shared, (void*) &sizeAiMoveShared);
        return sizeAiMoveShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_AiMove_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DeathRagdollForce
    {
      get
      {
        int deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DeathRagdollForce
    {
      get
      {
        int deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Health
    {
      get
      {
        int startOffsetHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &startOffsetHealth);
        return startOffsetHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Health
    {
      get
      {
        int componentDataSizeHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &componentDataSizeHealth);
        return componentDataSizeHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Height
    {
      get
      {
        int startOffsetHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Height, (void*) &startOffsetHeight);
        return startOffsetHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Height, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Height
    {
      get
      {
        int componentDataSizeHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Height, (void*) &componentDataSizeHeight);
        return componentDataSizeHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Height, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_HybridModelSeed
    {
      get
      {
        int offsetHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed, (void*) &offsetHybridModelSeed);
        return offsetHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_HybridModelSeed
    {
      get
      {
        int sizeHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed, (void*) &sizeHybridModelSeed);
        return sizeHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InteractedUpon
    {
      get
      {
        int offsetInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &offsetInteractedUpon);
        return offsetInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InteractedUpon
    {
      get
      {
        int sizeInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &sizeInteractedUpon);
        return sizeInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Movement
    {
      get
      {
        int startOffsetMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Movement, (void*) &startOffsetMovement);
        return startOffsetMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Movement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Movement
    {
      get
      {
        int dataSizeMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Movement, (void*) &dataSizeMovement);
        return dataSizeMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Movement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Stealthable
    {
      get
      {
        int offsetStealthable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Stealthable, (void*) &offsetStealthable);
        return offsetStealthable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Stealthable, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Stealthable
    {
      get
      {
        int dataSizeStealthable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Stealthable, (void*) &dataSizeStealthable);
        return dataSizeStealthable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Stealthable, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TargetDirection
    {
      get
      {
        int offsetTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection, (void*) &offsetTargetDirection);
        return offsetTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TargetDirection
    {
      get
      {
        int sizeTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_TargetDirection, (void*) &sizeTargetDirection);
        return sizeTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Torture
    {
      get
      {
        int startOffsetTorture;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Torture, (void*) &startOffsetTorture);
        return startOffsetTorture;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Torture, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Torture
    {
      get
      {
        int componentDataSizeTorture;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Torture, (void*) &componentDataSizeTorture);
        return componentDataSizeTorture;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Torture, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_UnitLevel
    {
      get
      {
        int startOffsetUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel, (void*) &startOffsetUnitLevel);
        return startOffsetUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_UnitLevel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_UnitLevel
    {
      get
      {
        int dataSizeUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_UnitLevel, (void*) &dataSizeUnitLevel);
        return dataSizeUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_UnitLevel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Vision
    {
      get
      {
        int startOffsetVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Vision, (void*) &startOffsetVision);
        return startOffsetVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataStartOffset_Vision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Vision
    {
      get
      {
        int componentDataSizeVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Vision, (void*) &componentDataSizeVision);
        return componentDataSizeVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_ComponentDataSize_Vision, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityBar_Shared
    {
      get
      {
        ulong abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AggroConsumer
    {
      get
      {
        ulong bitAggroConsumer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_AggroConsumer, (void*) &bitAggroConsumer);
        return bitAggroConsumer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_AggroConsumer, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AiMove_Shared
    {
      get
      {
        ulong compBitAiMoveShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_AiMove_Shared, (void*) &compBitAiMoveShared);
        return compBitAiMoveShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_AiMove_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DeathRagdollForce
    {
      get
      {
        ulong deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DynamicCollision
    {
      get
      {
        ulong dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Health
    {
      get
      {
        ulong compBitHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Health, (void*) &compBitHealth);
        return compBitHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Health, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Height
    {
      get
      {
        ulong compBitHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Height, (void*) &compBitHeight);
        return compBitHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Height, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_HybridModelSeed
    {
      get
      {
        ulong bitHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_HybridModelSeed, (void*) &bitHybridModelSeed);
        return bitHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InteractedUpon
    {
      get
      {
        ulong bitInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &bitInteractedUpon);
        return bitInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_IsSpellControlled
    {
      get
      {
        ulong isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Movement
    {
      get
      {
        ulong compBitMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Movement, (void*) &compBitMovement);
        return compBitMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Movement, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_NetworkInterpolated_Shared
    {
      get
      {
        ulong interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Stealthable
    {
      get
      {
        ulong compBitStealthable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Stealthable, (void*) &compBitStealthable);
        return compBitStealthable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Stealthable, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TargetDirection
    {
      get
      {
        ulong bitTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_TargetDirection, (void*) &bitTargetDirection);
        return bitTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_TargetDirection, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Torture
    {
      get
      {
        ulong compBitTorture;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Torture, (void*) &compBitTorture);
        return compBitTorture;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Torture, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_UnitLevel
    {
      get
      {
        ulong compBitUnitLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_UnitLevel, (void*) &compBitUnitLevel);
        return compBitUnitLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_UnitLevel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Vision
    {
      get
      {
        ulong compBitVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Vision, (void*) &compBitVision);
        return compBitVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbjdjfkiif.NativeFieldInfoPtr_CompBit_Vision, (void*) &value);
      }
    }
  }
}
