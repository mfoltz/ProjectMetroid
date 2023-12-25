// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cjjdkdfkkh
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding.Placement;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_cjjdkdfkkh
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
    private static readonly System.IntPtr NativeFieldInfoPtr_AiMove_Shared_HasNextWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiMove_Shared_HasWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiMove_Shared_NextWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiMove_Shared_Waypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementDestroyData_DestroyReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Vision_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Vision_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Vision_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasNextWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_NextWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_Waypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Vision_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AiMove_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AiMove_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Vision;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Vision;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AiMove_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
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
    public bool AiMove_Shared_HasNextWaypoint;
    [FieldOffset(113)]
    public bool AiMove_Shared_HasWaypoint;
    [FieldOffset(114)]
    public int2 AiMove_Shared_NextWaypoint;
    [FieldOffset(122)]
    public int2 AiMove_Shared_Waypoint;
    [FieldOffset(130)]
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(146)]
    public bool Health_IsDead;
    [FieldOffset(147)]
    public ModifiableFloat Health_MaxHealth;
    [FieldOffset(155)]
    public float Health_MaxRecoveryHealth;
    [FieldOffset(159)]
    public double Health_TimeOfDeath;
    [FieldOffset(167)]
    public float Health_Value;
    [FieldOffset(171)]
    public byte Height_ServerHeightLevel;
    [FieldOffset(172)]
    public ushort HybridModelSeed_Seed;
    [FieldOffset(174)]
    public bool InteractedUpon_Interacting;
    [FieldOffset(175)]
    public ModifiableBool IsSpellControlled_Value;
    [FieldOffset(179)]
    public ModifiableFloat Movement_Speed;
    [FieldOffset(187)]
    public double NetworkInterpolated_Shared_LastClientCommandTime;
    [FieldOffset(195)]
    public float2 NetworkInterpolated_Shared_Movement;
    [FieldOffset(203)]
    public float NetworkInterpolated_Shared_ServerMoveVelocity;
    [FieldOffset(207)]
    public float2 NetworkInterpolated_Shared_ServerPosition;
    [FieldOffset(215)]
    public quaternion NetworkInterpolated_Shared_ServerRotation;
    [FieldOffset(231)]
    public float2 NetworkInterpolated_Shared_ServerVelocity;
    [FieldOffset(239)]
    public bool NetworkInterpolated_Shared_Simulate;
    [FieldOffset(240)]
    public TileModelDestroyReason PlacementDestroyData_DestroyReason;
    [FieldOffset(244)]
    public float3 TargetDirection_AimDirection;
    [FieldOffset(256)]
    public float TargetDirection_DefaultRotationSpeed;
    [FieldOffset(260)]
    public float3 TargetDirection_Direction;
    [FieldOffset(272)]
    public ModifiableBool TargetDirection_ForceRotateTowardsMovement;
    [FieldOffset(276)]
    public ModifiableBool TargetDirection_RotateTowardsMouse;
    [FieldOffset(280)]
    public int Team_FactionIndex;
    [FieldOffset(284)]
    public int Team_Value;
    [FieldOffset(288)]
    public TileType TileModel_DisabledTileTypes;
    [FieldOffset(289)]
    public ModifiableFloat Vision_Range;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1574456, XrefRangeEnd = 1574872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cjjdkdfkkh.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1575033, RefRangeEnd = 1575034, XrefRangeStart = 1574872, XrefRangeEnd = 1575033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cjjdkdfkkh.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cjjdkdfkkh()
    {
      Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cjjdkdfkkh));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr);
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_CastAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_CastAbility));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_CastAbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_CastAbilityPrefabGuid));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_CastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_CastGroup));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_CastGroupPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_CastGroupPrefabGuid));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_CastStartTime));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_CastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_CastTime));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_CooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_CooldownModifier));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_GlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_GlobalCooldown));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_InterruptTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_InterruptTypes));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_LimitAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_LimitAbilityPriority));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_PostCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_PostCastTime));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_PrimaryCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_PrimaryCooldownModifier));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_ServerCastCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_ServerCastCounter));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_ServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_ServerInterruptCounter));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_SpellCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_SpellCooldownModifier));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_TravelCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_TravelCooldownModifier));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AbilityBar_Shared_WeaponCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AbilityBar_Shared_WeaponCooldownModifier));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AiMove_Shared_HasNextWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AiMove_Shared_HasNextWaypoint));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AiMove_Shared_HasWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AiMove_Shared_HasWaypoint));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AiMove_Shared_NextWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AiMove_Shared_NextWaypoint));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_AiMove_Shared_Waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (AiMove_Shared_Waypoint));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (Health_IsDead));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (Health_MaxHealth));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (Health_MaxRecoveryHealth));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (Health_TimeOfDeath));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (Health_Value));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_Height_ServerHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (Height_ServerHeightLevel));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_HybridModelSeed_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (HybridModelSeed_Seed));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (InteractedUpon_Interacting));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_IsSpellControlled_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (IsSpellControlled_Value));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_Movement_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (Movement_Speed));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_NetworkInterpolated_Shared_LastClientCommandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (NetworkInterpolated_Shared_LastClientCommandTime));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_NetworkInterpolated_Shared_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (NetworkInterpolated_Shared_Movement));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerMoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerMoveVelocity));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerPosition));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerRotation));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerVelocity));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_NetworkInterpolated_Shared_Simulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (NetworkInterpolated_Shared_Simulate));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_PlacementDestroyData_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (PlacementDestroyData_DestroyReason));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_TargetDirection_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (TargetDirection_AimDirection));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_TargetDirection_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (TargetDirection_DefaultRotationSpeed));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_TargetDirection_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (TargetDirection_Direction));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_TargetDirection_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (TargetDirection_ForceRotateTowardsMovement));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_TargetDirection_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (TargetDirection_RotateTowardsMouse));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (Team_Value));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_Vision_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (Vision_Range));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_AbilityBar_Shared_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_AbilityBar_Shared_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_AiMove_Shared_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_AiMove_Shared_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Health_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_Health_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Health_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_Health_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Height_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_Height_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Height_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_Height_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_HybridModelSeed_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_HybridModelSeed_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_IsSpellControlled_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_IsSpellControlled_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Movement_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_Movement_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Movement_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_Movement_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_NetworkInterpolated_Shared_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_NetworkInterpolated_Shared_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_PlacementDestroyData_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_PlacementDestroyData_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_TargetDirection_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_TargetDirection_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Vision_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_Vision_Start));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Vision_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedFields_Vision_Count));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AiMove_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Health));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Height));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_HybridModelSeed));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_IsSpellControlled));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Movement));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_PlacementDestroyData));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Vision));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastAbility));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastGroup));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastStartTime));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastTime));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CooldownModifier));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_GlobalCooldown));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_InterruptTypes));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_PostCastTime));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_ServerCastCounter));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasNextWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AiMove_Shared_HasNextWaypoint));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AiMove_Shared_HasWaypoint));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_NextWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AiMove_Shared_NextWaypoint));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_Waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_AiMove_Shared_Waypoint));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Health_IsDead));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxHealth));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxRecoveryHealth));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Health_TimeOfDeath));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Health_Value));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Height_ServerHeightLevel));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_HybridModelSeed_Seed));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon_Interacting));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_IsSpellControlled_Value));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Movement_Speed));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_Movement));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_Simulate));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_PlacementDestroyData_DestroyReason));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_AimDirection));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_DefaultRotationSpeed));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_Direction));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_RotateTowardsMouse));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Vision_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (FrameChangedIndex_Vision_Range));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityBar_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_AbilityBar_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_AiMove_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_AiMove_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_AiMove_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_AiMove_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_Health));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_Health));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_Height));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_Height));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_HybridModelSeed));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_HybridModelSeed));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_InteractedUpon));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_InteractedUpon));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_IsSpellControlled));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_IsSpellControlled));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_Movement));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_Movement));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_NetworkInterpolated_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_NetworkInterpolated_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_PlacementDestroyData));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_PlacementDestroyData));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_TargetDirection));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_TargetDirection));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataStartOffset_Vision));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (ComponentDataSize_Vision));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_AbilityBar_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_AiMove_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_AiMove_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_Health));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_Height));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_HybridModelSeed));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_InteractedUpon));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_IsSpellControlled));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_Movement));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_NetworkInterpolated_Shared));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_PlacementDestroyData));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_TargetDirection));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, nameof (CompBit_Vision));
      Snapshot_cjjdkdfkkh.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, 100664582);
      Snapshot_cjjdkdfkkh.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, 100664583);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cjjdkdfkkh>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityBar_Shared_Start
    {
      get
      {
        int abilityBarSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start, (void*) &abilityBarSharedStart);
        return abilityBarSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityBar_Shared_Count
    {
      get
      {
        int abilityBarSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count, (void*) &abilityBarSharedCount);
        return abilityBarSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AiMove_Shared_Start
    {
      get
      {
        int aiMoveSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Start, (void*) &aiMoveSharedStart);
        return aiMoveSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AiMove_Shared_Count
    {
      get
      {
        int aiMoveSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Count, (void*) &aiMoveSharedCount);
        return aiMoveSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_AiMove_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Start
    {
      get
      {
        int fieldsHealthStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &fieldsHealthStart);
        return fieldsHealthStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Count
    {
      get
      {
        int fieldsHealthCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &fieldsHealthCount);
        return fieldsHealthCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Height_Start
    {
      get
      {
        int fieldsHeightStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Height_Start, (void*) &fieldsHeightStart);
        return fieldsHeightStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Height_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Height_Count
    {
      get
      {
        int fieldsHeightCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Height_Count, (void*) &fieldsHeightCount);
        return fieldsHeightCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Height_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_HybridModelSeed_Start
    {
      get
      {
        int hybridModelSeedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start, (void*) &hybridModelSeedStart);
        return hybridModelSeedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_HybridModelSeed_Count
    {
      get
      {
        int hybridModelSeedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count, (void*) &hybridModelSeedCount);
        return hybridModelSeedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Start
    {
      get
      {
        int interactedUponStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &interactedUponStart);
        return interactedUponStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Count
    {
      get
      {
        int interactedUponCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &interactedUponCount);
        return interactedUponCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_IsSpellControlled_Start
    {
      get
      {
        int spellControlledStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start, (void*) &spellControlledStart);
        return spellControlledStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_IsSpellControlled_Count
    {
      get
      {
        int spellControlledCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count, (void*) &spellControlledCount);
        return spellControlledCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Movement_Start
    {
      get
      {
        int fieldsMovementStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Movement_Start, (void*) &fieldsMovementStart);
        return fieldsMovementStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Movement_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Movement_Count
    {
      get
      {
        int fieldsMovementCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Movement_Count, (void*) &fieldsMovementCount);
        return fieldsMovementCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Movement_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_NetworkInterpolated_Shared_Start
    {
      get
      {
        int interpolatedSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start, (void*) &interpolatedSharedStart);
        return interpolatedSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_NetworkInterpolated_Shared_Count
    {
      get
      {
        int interpolatedSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count, (void*) &interpolatedSharedCount);
        return interpolatedSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlacementDestroyData_Start
    {
      get
      {
        int destroyDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start, (void*) &destroyDataStart);
        return destroyDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlacementDestroyData_Count
    {
      get
      {
        int destroyDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count, (void*) &destroyDataCount);
        return destroyDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TargetDirection_Start
    {
      get
      {
        int targetDirectionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start, (void*) &targetDirectionStart);
        return targetDirectionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TargetDirection_Count
    {
      get
      {
        int targetDirectionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count, (void*) &targetDirectionCount);
        return targetDirectionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Vision_Start
    {
      get
      {
        int fieldsVisionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Vision_Start, (void*) &fieldsVisionStart);
        return fieldsVisionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Vision_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Vision_Count
    {
      get
      {
        int fieldsVisionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Vision_Count, (void*) &fieldsVisionCount);
        return fieldsVisionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedFields_Vision_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AiMove_Shared
    {
      get
      {
        int indexAiMoveShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared, (void*) &indexAiMoveShared);
        return indexAiMoveShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health
    {
      get
      {
        int changedIndexHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &changedIndexHealth);
        return changedIndexHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Height
    {
      get
      {
        int changedIndexHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Height, (void*) &changedIndexHeight);
        return changedIndexHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_HybridModelSeed
    {
      get
      {
        int indexHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed, (void*) &indexHybridModelSeed);
        return indexHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon
    {
      get
      {
        int indexInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &indexInteractedUpon);
        return indexInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Movement
    {
      get
      {
        int changedIndexMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Movement, (void*) &changedIndexMovement);
        return changedIndexMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Movement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection
    {
      get
      {
        int indexTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection, (void*) &indexTargetDirection);
        return indexTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Vision
    {
      get
      {
        int changedIndexVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Vision, (void*) &changedIndexVision);
        return changedIndexVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Vision, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastAbility
    {
      get
      {
        int sharedCastAbility;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility, (void*) &sharedCastAbility);
        return sharedCastAbility;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid
    {
      get
      {
        int abilityPrefabGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid, (void*) &abilityPrefabGuid);
        return abilityPrefabGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastGroup
    {
      get
      {
        int barSharedCastGroup;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup, (void*) &barSharedCastGroup);
        return barSharedCastGroup;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid
    {
      get
      {
        int castGroupPrefabGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid, (void*) &castGroupPrefabGuid);
        return castGroupPrefabGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastStartTime
    {
      get
      {
        int sharedCastStartTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime, (void*) &sharedCastStartTime);
        return sharedCastStartTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastTime
    {
      get
      {
        int barSharedCastTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime, (void*) &barSharedCastTime);
        return barSharedCastTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_GlobalCooldown
    {
      get
      {
        int sharedGlobalCooldown;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown, (void*) &sharedGlobalCooldown);
        return sharedGlobalCooldown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_InterruptTypes
    {
      get
      {
        int sharedInterruptTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes, (void*) &sharedInterruptTypes);
        return sharedInterruptTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority
    {
      get
      {
        int limitAbilityPriority;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority, (void*) &limitAbilityPriority);
        return limitAbilityPriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_PostCastTime
    {
      get
      {
        int sharedPostCastTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime, (void*) &sharedPostCastTime);
        return sharedPostCastTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_ServerCastCounter
    {
      get
      {
        int serverCastCounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter, (void*) &serverCastCounter);
        return serverCastCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter
    {
      get
      {
        int interruptCounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter, (void*) &interruptCounter);
        return interruptCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AiMove_Shared_HasNextWaypoint
    {
      get
      {
        int sharedHasNextWaypoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasNextWaypoint, (void*) &sharedHasNextWaypoint);
        return sharedHasNextWaypoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasNextWaypoint, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AiMove_Shared_HasWaypoint
    {
      get
      {
        int sharedHasWaypoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasWaypoint, (void*) &sharedHasWaypoint);
        return sharedHasWaypoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_HasWaypoint, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AiMove_Shared_NextWaypoint
    {
      get
      {
        int sharedNextWaypoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_NextWaypoint, (void*) &sharedNextWaypoint);
        return sharedNextWaypoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_NextWaypoint, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AiMove_Shared_Waypoint
    {
      get
      {
        int moveSharedWaypoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_Waypoint, (void*) &moveSharedWaypoint);
        return moveSharedWaypoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_AiMove_Shared_Waypoint, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_IsDead
    {
      get
      {
        int indexHealthIsDead;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &indexHealthIsDead);
        return indexHealthIsDead;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxHealth
    {
      get
      {
        int indexHealthMaxHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &indexHealthMaxHealth);
        return indexHealthMaxHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxRecoveryHealth
    {
      get
      {
        int maxRecoveryHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &maxRecoveryHealth);
        return maxRecoveryHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_TimeOfDeath
    {
      get
      {
        int healthTimeOfDeath;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &healthTimeOfDeath);
        return healthTimeOfDeath;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_Value
    {
      get
      {
        int indexHealthValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &indexHealthValue);
        return indexHealthValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Height_ServerHeightLevel
    {
      get
      {
        int serverHeightLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel, (void*) &serverHeightLevel);
        return serverHeightLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_HybridModelSeed_Seed
    {
      get
      {
        int hybridModelSeedSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed, (void*) &hybridModelSeedSeed);
        return hybridModelSeedSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon_Interacting
    {
      get
      {
        int interactedUponInteracting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &interactedUponInteracting);
        return interactedUponInteracting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_IsSpellControlled_Value
    {
      get
      {
        int spellControlledValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value, (void*) &spellControlledValue);
        return spellControlledValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Movement_Speed
    {
      get
      {
        int indexMovementSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed, (void*) &indexMovementSpeed);
        return indexMovementSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime
    {
      get
      {
        int clientCommandTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime, (void*) &clientCommandTime);
        return clientCommandTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_Movement
    {
      get
      {
        int interpolatedSharedMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement, (void*) &interpolatedSharedMovement);
        return interpolatedSharedMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity
    {
      get
      {
        int serverMoveVelocity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity, (void*) &serverMoveVelocity);
        return serverMoveVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition
    {
      get
      {
        int sharedServerPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition, (void*) &sharedServerPosition);
        return sharedServerPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation
    {
      get
      {
        int sharedServerRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation, (void*) &sharedServerRotation);
        return sharedServerRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity
    {
      get
      {
        int sharedServerVelocity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity, (void*) &sharedServerVelocity);
        return sharedServerVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_Simulate
    {
      get
      {
        int interpolatedSharedSimulate;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate, (void*) &interpolatedSharedSimulate);
        return interpolatedSharedSimulate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlacementDestroyData_DestroyReason
    {
      get
      {
        int dataDestroyReason;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason, (void*) &dataDestroyReason);
        return dataDestroyReason;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_AimDirection
    {
      get
      {
        int directionAimDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection, (void*) &directionAimDirection);
        return directionAimDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_DefaultRotationSpeed
    {
      get
      {
        int defaultRotationSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed, (void*) &defaultRotationSpeed);
        return defaultRotationSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_Direction
    {
      get
      {
        int directionDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction, (void*) &directionDirection);
        return directionDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement
    {
      get
      {
        int rotateTowardsMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement, (void*) &rotateTowardsMovement);
        return rotateTowardsMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_RotateTowardsMouse
    {
      get
      {
        int rotateTowardsMouse;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse, (void*) &rotateTowardsMouse);
        return rotateTowardsMouse;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Vision_Range
    {
      get
      {
        int indexVisionRange;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Vision_Range, (void*) &indexVisionRange);
        return indexVisionRange;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_FrameChangedIndex_Vision_Range, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AiMove_Shared
    {
      get
      {
        int offsetAiMoveShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_AiMove_Shared, (void*) &offsetAiMoveShared);
        return offsetAiMoveShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_AiMove_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AiMove_Shared
    {
      get
      {
        int sizeAiMoveShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_AiMove_Shared, (void*) &sizeAiMoveShared);
        return sizeAiMoveShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_AiMove_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Health
    {
      get
      {
        int startOffsetHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &startOffsetHealth);
        return startOffsetHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Health
    {
      get
      {
        int componentDataSizeHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &componentDataSizeHealth);
        return componentDataSizeHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Height
    {
      get
      {
        int startOffsetHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Height, (void*) &startOffsetHeight);
        return startOffsetHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Height, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Height
    {
      get
      {
        int componentDataSizeHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Height, (void*) &componentDataSizeHeight);
        return componentDataSizeHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Height, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_HybridModelSeed
    {
      get
      {
        int offsetHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed, (void*) &offsetHybridModelSeed);
        return offsetHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_HybridModelSeed
    {
      get
      {
        int sizeHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed, (void*) &sizeHybridModelSeed);
        return sizeHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InteractedUpon
    {
      get
      {
        int offsetInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &offsetInteractedUpon);
        return offsetInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InteractedUpon
    {
      get
      {
        int sizeInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &sizeInteractedUpon);
        return sizeInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Movement
    {
      get
      {
        int startOffsetMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Movement, (void*) &startOffsetMovement);
        return startOffsetMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Movement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Movement
    {
      get
      {
        int dataSizeMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Movement, (void*) &dataSizeMovement);
        return dataSizeMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Movement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TargetDirection
    {
      get
      {
        int offsetTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection, (void*) &offsetTargetDirection);
        return offsetTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TargetDirection
    {
      get
      {
        int sizeTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_TargetDirection, (void*) &sizeTargetDirection);
        return sizeTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Vision
    {
      get
      {
        int startOffsetVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Vision, (void*) &startOffsetVision);
        return startOffsetVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataStartOffset_Vision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Vision
    {
      get
      {
        int componentDataSizeVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Vision, (void*) &componentDataSizeVision);
        return componentDataSizeVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_ComponentDataSize_Vision, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityBar_Shared
    {
      get
      {
        ulong abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AiMove_Shared
    {
      get
      {
        ulong compBitAiMoveShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_AiMove_Shared, (void*) &compBitAiMoveShared);
        return compBitAiMoveShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_AiMove_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Health
    {
      get
      {
        ulong compBitHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Health, (void*) &compBitHealth);
        return compBitHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Health, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Height
    {
      get
      {
        ulong compBitHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Height, (void*) &compBitHeight);
        return compBitHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Height, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_HybridModelSeed
    {
      get
      {
        ulong bitHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_HybridModelSeed, (void*) &bitHybridModelSeed);
        return bitHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InteractedUpon
    {
      get
      {
        ulong bitInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &bitInteractedUpon);
        return bitInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_IsSpellControlled
    {
      get
      {
        ulong isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Movement
    {
      get
      {
        ulong compBitMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Movement, (void*) &compBitMovement);
        return compBitMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Movement, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_NetworkInterpolated_Shared
    {
      get
      {
        ulong interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_PlacementDestroyData
    {
      get
      {
        ulong placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TargetDirection
    {
      get
      {
        ulong bitTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_TargetDirection, (void*) &bitTargetDirection);
        return bitTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_TargetDirection, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Vision
    {
      get
      {
        ulong compBitVision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Vision, (void*) &compBitVision);
        return compBitVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjjdkdfkkh.NativeFieldInfoPtr_CompBit_Vision, (void*) &value);
      }
    }
  }
}
