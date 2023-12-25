// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_debdghice
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
  public struct Snapshot_debdghice
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
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_Movement_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_LastClientCommandTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerMoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_Shared_Simulate;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Height_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Height_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Movement_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Movement_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
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
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(128)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_HardnessThreshold;
    [FieldOffset(136)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_PushStrengthMax;
    [FieldOffset(144)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_PushStrengthMin;
    [FieldOffset(152)]
    public ModifiableFloat DynamicCollision_AgainstUnits_HardnessThreshold;
    [FieldOffset(160)]
    public ModifiableFloat DynamicCollision_AgainstUnits_PushStrengthMax;
    [FieldOffset(168)]
    public ModifiableFloat DynamicCollision_AgainstUnits_PushStrengthMin;
    [FieldOffset(176)]
    public float DynamicCollision_AgainstUnits_RadiusVariation;
    [FieldOffset(180)]
    public bool Health_IsDead;
    [FieldOffset(181)]
    public ModifiableFloat Health_MaxHealth;
    [FieldOffset(189)]
    public float Health_MaxRecoveryHealth;
    [FieldOffset(193)]
    public double Health_TimeOfDeath;
    [FieldOffset(201)]
    public float Health_Value;
    [FieldOffset(205)]
    public byte Height_ServerHeightLevel;
    [FieldOffset(206)]
    public ModifiableFloat Movement_Speed;
    [FieldOffset(214)]
    public double NetworkInterpolated_Shared_LastClientCommandTime;
    [FieldOffset(222)]
    public float2 NetworkInterpolated_Shared_Movement;
    [FieldOffset(230)]
    public float NetworkInterpolated_Shared_ServerMoveVelocity;
    [FieldOffset(234)]
    public float2 NetworkInterpolated_Shared_ServerPosition;
    [FieldOffset(242)]
    public quaternion NetworkInterpolated_Shared_ServerRotation;
    [FieldOffset(258)]
    public float2 NetworkInterpolated_Shared_ServerVelocity;
    [FieldOffset(266)]
    public bool NetworkInterpolated_Shared_Simulate;
    [FieldOffset(267)]
    public float3 TargetDirection_AimDirection;
    [FieldOffset(279)]
    public float TargetDirection_DefaultRotationSpeed;
    [FieldOffset(283)]
    public float3 TargetDirection_Direction;
    [FieldOffset(295)]
    public ModifiableBool TargetDirection_ForceRotateTowardsMovement;
    [FieldOffset(299)]
    public ModifiableBool TargetDirection_RotateTowardsMouse;
    [FieldOffset(303)]
    public int Team_FactionIndex;
    [FieldOffset(307)]
    public int Team_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1577859, XrefRangeEnd = 1578173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_debdghice.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1578327, RefRangeEnd = 1578328, XrefRangeStart = 1578173, XrefRangeEnd = 1578327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_debdghice.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_debdghice()
    {
      Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_debdghice));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr);
      Snapshot_debdghice.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_debdghice.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_CastAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_CastAbility));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_CastAbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_CastAbilityPrefabGuid));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_CastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_CastGroup));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_CastGroupPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_CastGroupPrefabGuid));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_CastStartTime));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_CastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_CastTime));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_CooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_CooldownModifier));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_GlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_GlobalCooldown));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_InterruptTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_InterruptTypes));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_LimitAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_LimitAbilityPriority));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_PostCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_PostCastTime));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_PrimaryCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_PrimaryCooldownModifier));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_ServerCastCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_ServerCastCounter));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_ServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_ServerInterruptCounter));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_SpellCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_SpellCooldownModifier));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_TravelCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_TravelCooldownModifier));
      Snapshot_debdghice.NativeFieldInfoPtr_AbilityBar_Shared_WeaponCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (AbilityBar_Shared_WeaponCooldownModifier));
      Snapshot_debdghice.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_debdghice.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_HardnessThreshold));
      Snapshot_debdghice.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_PushStrengthMax));
      Snapshot_debdghice.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_PushStrengthMin));
      Snapshot_debdghice.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_HardnessThreshold));
      Snapshot_debdghice.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_PushStrengthMax));
      Snapshot_debdghice.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_PushStrengthMin));
      Snapshot_debdghice.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_RadiusVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_RadiusVariation));
      Snapshot_debdghice.NativeFieldInfoPtr_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (Health_IsDead));
      Snapshot_debdghice.NativeFieldInfoPtr_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (Health_MaxHealth));
      Snapshot_debdghice.NativeFieldInfoPtr_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (Health_MaxRecoveryHealth));
      Snapshot_debdghice.NativeFieldInfoPtr_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (Health_TimeOfDeath));
      Snapshot_debdghice.NativeFieldInfoPtr_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (Health_Value));
      Snapshot_debdghice.NativeFieldInfoPtr_Height_ServerHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (Height_ServerHeightLevel));
      Snapshot_debdghice.NativeFieldInfoPtr_Movement_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (Movement_Speed));
      Snapshot_debdghice.NativeFieldInfoPtr_NetworkInterpolated_Shared_LastClientCommandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (NetworkInterpolated_Shared_LastClientCommandTime));
      Snapshot_debdghice.NativeFieldInfoPtr_NetworkInterpolated_Shared_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (NetworkInterpolated_Shared_Movement));
      Snapshot_debdghice.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerMoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerMoveVelocity));
      Snapshot_debdghice.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerPosition));
      Snapshot_debdghice.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerRotation));
      Snapshot_debdghice.NativeFieldInfoPtr_NetworkInterpolated_Shared_ServerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (NetworkInterpolated_Shared_ServerVelocity));
      Snapshot_debdghice.NativeFieldInfoPtr_NetworkInterpolated_Shared_Simulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (NetworkInterpolated_Shared_Simulate));
      Snapshot_debdghice.NativeFieldInfoPtr_TargetDirection_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (TargetDirection_AimDirection));
      Snapshot_debdghice.NativeFieldInfoPtr_TargetDirection_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (TargetDirection_DefaultRotationSpeed));
      Snapshot_debdghice.NativeFieldInfoPtr_TargetDirection_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (TargetDirection_Direction));
      Snapshot_debdghice.NativeFieldInfoPtr_TargetDirection_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (TargetDirection_ForceRotateTowardsMovement));
      Snapshot_debdghice.NativeFieldInfoPtr_TargetDirection_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (TargetDirection_RotateTowardsMouse));
      Snapshot_debdghice.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_debdghice.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (Team_Value));
      Snapshot_debdghice.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_AbilityBar_Shared_Start));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_AbilityBar_Shared_Count));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_DynamicCollision_Start));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_DynamicCollision_Count));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Health_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_Health_Start));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Health_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_Health_Count));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Height_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_Height_Start));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Height_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_Height_Count));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Movement_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_Movement_Start));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Movement_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_Movement_Count));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_NetworkInterpolated_Shared_Start));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_NetworkInterpolated_Shared_Count));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_TargetDirection_Start));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_TargetDirection_Count));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Health));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Height));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Movement));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastAbility));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastGroup));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastStartTime));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CastTime));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_CooldownModifier));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_GlobalCooldown));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_InterruptTypes));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_PostCastTime));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_ServerCastCounter));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Health_IsDead));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxHealth));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxRecoveryHealth));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Health_TimeOfDeath));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Health_Value));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Height_ServerHeightLevel));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Movement_Speed));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_Movement));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_NetworkInterpolated_Shared_Simulate));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_AimDirection));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_DefaultRotationSpeed));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_Direction));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_RotateTowardsMouse));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityBar_Shared));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataSize_AbilityBar_Shared));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataStartOffset_DynamicCollision));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataSize_DynamicCollision));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataStartOffset_Health));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataSize_Health));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataStartOffset_Height));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataSize_Height));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataStartOffset_Movement));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataSize_Movement));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataStartOffset_NetworkInterpolated_Shared));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataSize_NetworkInterpolated_Shared));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataStartOffset_TargetDirection));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataSize_TargetDirection));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_debdghice.NativeFieldInfoPtr_CompBit_AbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (CompBit_AbilityBar_Shared));
      Snapshot_debdghice.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_debdghice.NativeFieldInfoPtr_CompBit_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (CompBit_DynamicCollision));
      Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (CompBit_Health));
      Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (CompBit_Height));
      Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (CompBit_Movement));
      Snapshot_debdghice.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (CompBit_NetworkInterpolated_Shared));
      Snapshot_debdghice.NativeFieldInfoPtr_CompBit_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (CompBit_TargetDirection));
      Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_debdghice.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, 100664620);
      Snapshot_debdghice.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, 100664621);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_debdghice>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityBar_Shared_Start
    {
      get
      {
        int abilityBarSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start, (void*) &abilityBarSharedStart);
        return abilityBarSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityBar_Shared_Count
    {
      get
      {
        int abilityBarSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count, (void*) &abilityBarSharedCount);
        return abilityBarSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_AbilityBar_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DynamicCollision_Start
    {
      get
      {
        int dynamicCollisionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start, (void*) &dynamicCollisionStart);
        return dynamicCollisionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DynamicCollision_Count
    {
      get
      {
        int dynamicCollisionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count, (void*) &dynamicCollisionCount);
        return dynamicCollisionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Start
    {
      get
      {
        int fieldsHealthStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &fieldsHealthStart);
        return fieldsHealthStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Count
    {
      get
      {
        int fieldsHealthCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &fieldsHealthCount);
        return fieldsHealthCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Height_Start
    {
      get
      {
        int fieldsHeightStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Height_Start, (void*) &fieldsHeightStart);
        return fieldsHeightStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Height_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Height_Count
    {
      get
      {
        int fieldsHeightCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Height_Count, (void*) &fieldsHeightCount);
        return fieldsHeightCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Height_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Movement_Start
    {
      get
      {
        int fieldsMovementStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Movement_Start, (void*) &fieldsMovementStart);
        return fieldsMovementStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Movement_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Movement_Count
    {
      get
      {
        int fieldsMovementCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Movement_Count, (void*) &fieldsMovementCount);
        return fieldsMovementCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Movement_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_NetworkInterpolated_Shared_Start
    {
      get
      {
        int interpolatedSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start, (void*) &interpolatedSharedStart);
        return interpolatedSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_NetworkInterpolated_Shared_Count
    {
      get
      {
        int interpolatedSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count, (void*) &interpolatedSharedCount);
        return interpolatedSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_NetworkInterpolated_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TargetDirection_Start
    {
      get
      {
        int targetDirectionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start, (void*) &targetDirectionStart);
        return targetDirectionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TargetDirection_Count
    {
      get
      {
        int targetDirectionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count, (void*) &targetDirectionCount);
        return targetDirectionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health
    {
      get
      {
        int changedIndexHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &changedIndexHealth);
        return changedIndexHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Height
    {
      get
      {
        int changedIndexHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Height, (void*) &changedIndexHeight);
        return changedIndexHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Movement
    {
      get
      {
        int changedIndexMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Movement, (void*) &changedIndexMovement);
        return changedIndexMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Movement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection
    {
      get
      {
        int indexTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection, (void*) &indexTargetDirection);
        return indexTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastAbility
    {
      get
      {
        int sharedCastAbility;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility, (void*) &sharedCastAbility);
        return sharedCastAbility;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbility, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid
    {
      get
      {
        int abilityPrefabGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid, (void*) &abilityPrefabGuid);
        return abilityPrefabGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastAbilityPrefabGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastGroup
    {
      get
      {
        int barSharedCastGroup;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup, (void*) &barSharedCastGroup);
        return barSharedCastGroup;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroup, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid
    {
      get
      {
        int castGroupPrefabGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid, (void*) &castGroupPrefabGuid);
        return castGroupPrefabGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastGroupPrefabGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastStartTime
    {
      get
      {
        int sharedCastStartTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime, (void*) &sharedCastStartTime);
        return sharedCastStartTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastStartTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CastTime
    {
      get
      {
        int barSharedCastTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime, (void*) &barSharedCastTime);
        return barSharedCastTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CastTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_CooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_CooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_GlobalCooldown
    {
      get
      {
        int sharedGlobalCooldown;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown, (void*) &sharedGlobalCooldown);
        return sharedGlobalCooldown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_GlobalCooldown, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_InterruptTypes
    {
      get
      {
        int sharedInterruptTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes, (void*) &sharedInterruptTypes);
        return sharedInterruptTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_InterruptTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority
    {
      get
      {
        int limitAbilityPriority;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority, (void*) &limitAbilityPriority);
        return limitAbilityPriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_LimitAbilityPriority, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_PostCastTime
    {
      get
      {
        int sharedPostCastTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime, (void*) &sharedPostCastTime);
        return sharedPostCastTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PostCastTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_PrimaryCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_ServerCastCounter
    {
      get
      {
        int serverCastCounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter, (void*) &serverCastCounter);
        return serverCastCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerCastCounter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter
    {
      get
      {
        int interruptCounter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter, (void*) &interruptCounter);
        return interruptCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_ServerInterruptCounter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_SpellCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_TravelCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier
    {
      get
      {
        int cooldownModifier;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier, (void*) &cooldownModifier);
        return cooldownModifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_AbilityBar_Shared_WeaponCooldownModifier, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold
    {
      get
      {
        int hardnessThreshold;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold, (void*) &hardnessThreshold);
        return hardnessThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax
    {
      get
      {
        int playersPushStrengthMax;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax, (void*) &playersPushStrengthMax);
        return playersPushStrengthMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin
    {
      get
      {
        int playersPushStrengthMin;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin, (void*) &playersPushStrengthMin);
        return playersPushStrengthMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold
    {
      get
      {
        int hardnessThreshold;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold, (void*) &hardnessThreshold);
        return hardnessThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax
    {
      get
      {
        int unitsPushStrengthMax;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax, (void*) &unitsPushStrengthMax);
        return unitsPushStrengthMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin
    {
      get
      {
        int unitsPushStrengthMin;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin, (void*) &unitsPushStrengthMin);
        return unitsPushStrengthMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation
    {
      get
      {
        int unitsRadiusVariation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation, (void*) &unitsRadiusVariation);
        return unitsRadiusVariation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_IsDead
    {
      get
      {
        int indexHealthIsDead;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &indexHealthIsDead);
        return indexHealthIsDead;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxHealth
    {
      get
      {
        int indexHealthMaxHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &indexHealthMaxHealth);
        return indexHealthMaxHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxRecoveryHealth
    {
      get
      {
        int maxRecoveryHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &maxRecoveryHealth);
        return maxRecoveryHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_TimeOfDeath
    {
      get
      {
        int healthTimeOfDeath;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &healthTimeOfDeath);
        return healthTimeOfDeath;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_Value
    {
      get
      {
        int indexHealthValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &indexHealthValue);
        return indexHealthValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Height_ServerHeightLevel
    {
      get
      {
        int serverHeightLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel, (void*) &serverHeightLevel);
        return serverHeightLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Height_ServerHeightLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Movement_Speed
    {
      get
      {
        int indexMovementSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed, (void*) &indexMovementSpeed);
        return indexMovementSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Movement_Speed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime
    {
      get
      {
        int clientCommandTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime, (void*) &clientCommandTime);
        return clientCommandTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_LastClientCommandTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_Movement
    {
      get
      {
        int interpolatedSharedMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement, (void*) &interpolatedSharedMovement);
        return interpolatedSharedMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Movement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity
    {
      get
      {
        int serverMoveVelocity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity, (void*) &serverMoveVelocity);
        return serverMoveVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerMoveVelocity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition
    {
      get
      {
        int sharedServerPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition, (void*) &sharedServerPosition);
        return sharedServerPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation
    {
      get
      {
        int sharedServerRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation, (void*) &sharedServerRotation);
        return sharedServerRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerRotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity
    {
      get
      {
        int sharedServerVelocity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity, (void*) &sharedServerVelocity);
        return sharedServerVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_ServerVelocity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_NetworkInterpolated_Shared_Simulate
    {
      get
      {
        int interpolatedSharedSimulate;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate, (void*) &interpolatedSharedSimulate);
        return interpolatedSharedSimulate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_NetworkInterpolated_Shared_Simulate, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_AimDirection
    {
      get
      {
        int directionAimDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection, (void*) &directionAimDirection);
        return directionAimDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_DefaultRotationSpeed
    {
      get
      {
        int defaultRotationSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed, (void*) &defaultRotationSpeed);
        return defaultRotationSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_Direction
    {
      get
      {
        int directionDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction, (void*) &directionDirection);
        return directionDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement
    {
      get
      {
        int rotateTowardsMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement, (void*) &rotateTowardsMovement);
        return rotateTowardsMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_RotateTowardsMouse
    {
      get
      {
        int rotateTowardsMouse;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse, (void*) &rotateTowardsMouse);
        return rotateTowardsMouse;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityBar_Shared
    {
      get
      {
        int abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Health
    {
      get
      {
        int startOffsetHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &startOffsetHealth);
        return startOffsetHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Health
    {
      get
      {
        int componentDataSizeHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &componentDataSizeHealth);
        return componentDataSizeHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Height
    {
      get
      {
        int startOffsetHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Height, (void*) &startOffsetHeight);
        return startOffsetHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Height, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Height
    {
      get
      {
        int componentDataSizeHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Height, (void*) &componentDataSizeHeight);
        return componentDataSizeHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Height, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Movement
    {
      get
      {
        int startOffsetMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Movement, (void*) &startOffsetMovement);
        return startOffsetMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Movement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Movement
    {
      get
      {
        int dataSizeMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Movement, (void*) &dataSizeMovement);
        return dataSizeMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Movement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_NetworkInterpolated_Shared
    {
      get
      {
        int interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TargetDirection
    {
      get
      {
        int offsetTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection, (void*) &offsetTargetDirection);
        return offsetTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TargetDirection
    {
      get
      {
        int sizeTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_TargetDirection, (void*) &sizeTargetDirection);
        return sizeTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityBar_Shared
    {
      get
      {
        ulong abilityBarShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_AbilityBar_Shared, (void*) &abilityBarShared);
        return abilityBarShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_AbilityBar_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DynamicCollision
    {
      get
      {
        ulong dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Health
    {
      get
      {
        ulong compBitHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Health, (void*) &compBitHealth);
        return compBitHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Health, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Height
    {
      get
      {
        ulong compBitHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Height, (void*) &compBitHeight);
        return compBitHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Height, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Movement
    {
      get
      {
        ulong compBitMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Movement, (void*) &compBitMovement);
        return compBitMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Movement, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_NetworkInterpolated_Shared
    {
      get
      {
        ulong interpolatedShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared, (void*) &interpolatedShared);
        return interpolatedShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_NetworkInterpolated_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TargetDirection
    {
      get
      {
        ulong bitTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_TargetDirection, (void*) &bitTargetDirection);
        return bitTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_TargetDirection, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_debdghice.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }
  }
}
