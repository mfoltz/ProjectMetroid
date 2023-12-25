// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cedekbhedh
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using ProjectM.Tiles;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_cedekbhedh
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloorRoof_RoofEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeart_CastleRaidEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeart_CastleSiegeEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeart_CastleTerritoryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeart_MinorCastleSiegeEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartConnection_CastleHeartEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoomConnection_RoomEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleWorkstation_WorkstationLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatedTime_CreateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleDestroyData_WasDismantled;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_CanRepair;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_CurrentEditor;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_IsDismantling;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_IsEdited;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModel_IsRepairing;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_CastleFreeClaimUntilTimePoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_CurrentRecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_FloorCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_FuelPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_HasCastleItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_MinutesRemaining;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_NestCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_PrisonCellCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_SafetyBoxCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_ServantCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pylonstation_TombCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationServants_Servants;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleFloorRoof_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleFloorRoof_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleHeart_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleHeart_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleRoomConnection_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleRoomConnection_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Pylonstation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Pylonstation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StationServants_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StationServants_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UserOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UserOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleFloorRoof;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeart;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleRoomConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UserOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ActiveServantMission;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleMemberNames;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleTeleporterElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Restricted_InventoryBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleFloorRoof_RoofEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleRaidEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleSiegeEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleTerritoryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_MinorCastleSiegeEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleRoomConnection_RoomEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_CastleFreeClaimUntilTimePoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_CurrentRecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_FloorCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_FuelPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_HasCastleItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_MinutesRemaining;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_NestCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_PrisonCellCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_SafetyBoxCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_ServantCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_TombCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UserOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleFloorRoof;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleFloorRoof;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeart;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleHeart;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoomConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleRoomConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Pylonstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Pylonstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_UserOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_UserOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleFloorRoof;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleHeart;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleRoomConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EditableTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Pylonstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_UserOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ActiveServantMission;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleMemberNames;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleTeleporterElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InventoryBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Restricted_InventoryBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_ActiveServantMission_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachToParentsBuffer_byref_BufferFromEntity_1_Snapshot_CastleMemberNames_byref_BufferFromEntity_1_Snapshot_CastleTeleporterElement_byref_BufferFromEntity_1_Snapshot_InventoryBuffer_byref_BufferFromEntity_1_Snapshot_Restricted_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_ActiveServantMission_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_DynamicBuffer_1_Snapshot_CastleBuildingAttachToParentsBuffer_DynamicBuffer_1_Snapshot_CastleMemberNames_DynamicBuffer_1_Snapshot_CastleTeleporterElement_DynamicBuffer_1_Snapshot_InventoryBuffer_DynamicBuffer_1_Snapshot_Restricted_InventoryBuffer_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(24)]
    public NetworkId CastleFloorRoof_RoofEntity;
    [FieldOffset(32)]
    public double CastleHeart_CastleRaidEndTime;
    [FieldOffset(40)]
    public double CastleHeart_CastleSiegeEndTime;
    [FieldOffset(48)]
    public MapZoneId CastleHeart_CastleTerritoryId;
    [FieldOffset(60)]
    public double CastleHeart_MinorCastleSiegeEndTime;
    [FieldOffset(68)]
    public NetworkId CastleHeartConnection_CastleHeartEntity;
    [FieldOffset(76)]
    public NetworkId CastleRoomConnection_RoomEntity;
    [FieldOffset(84)]
    public WorkstationLevel CastleWorkstation_WorkstationLevel;
    [FieldOffset(85)]
    public double CreatedTime_CreateTime;
    [FieldOffset(93)]
    public bool DismantleDestroyData_WasDismantled;
    [FieldOffset(94)]
    public bool EditableTileModel_CanRepair;
    [FieldOffset(95)]
    public NetworkId EditableTileModel_CurrentEditor;
    [FieldOffset(103)]
    public bool EditableTileModel_IsDismantling;
    [FieldOffset(104)]
    public bool EditableTileModel_IsEdited;
    [FieldOffset(105)]
    public bool EditableTileModel_IsRepairing;
    [FieldOffset(106)]
    public bool Health_IsDead;
    [FieldOffset(107)]
    public ModifiableFloat Health_MaxHealth;
    [FieldOffset(115)]
    public float Health_MaxRecoveryHealth;
    [FieldOffset(119)]
    public double Health_TimeOfDeath;
    [FieldOffset(127)]
    public float Health_Value;
    [FieldOffset(131)]
    public bool InteractedUpon_Interacting;
    [FieldOffset(132)]
    public double Pylonstation_CastleFreeClaimUntilTimePoint;
    [FieldOffset(140)]
    public PrefabGUID Pylonstation_CurrentRecipeGuid;
    [FieldOffset(144)]
    public int Pylonstation_FloorCount;
    [FieldOffset(148)]
    public float Pylonstation_FuelPercentage;
    [FieldOffset(152)]
    public bool Pylonstation_HasCastleItems;
    [FieldOffset(153)]
    public int Pylonstation_Level;
    [FieldOffset(157)]
    public int Pylonstation_MinutesRemaining;
    [FieldOffset(161)]
    public byte Pylonstation_NestCount;
    [FieldOffset(162)]
    public byte Pylonstation_PrisonCellCount;
    [FieldOffset(163)]
    public float Pylonstation_Progress;
    [FieldOffset(167)]
    public byte Pylonstation_SafetyBoxCount;
    [FieldOffset(168)]
    public int Pylonstation_ServantCount;
    [FieldOffset(172)]
    public PylonstationState Pylonstation_State;
    [FieldOffset(173)]
    public byte Pylonstation_TombCount;
    [FieldOffset(174)]
    public float StaticTransformCompatible_NonStaticTransform_Height;
    [FieldOffset(178)]
    public float2 StaticTransformCompatible_NonStaticTransform_Pos;
    [FieldOffset(186)]
    public TileRotation StaticTransformCompatible_NonStaticTransform_Rotation;
    [FieldOffset(187)]
    public StaticTransformIndex StaticTransformCompatible_StaticTransform;
    [FieldOffset(199)]
    public bool StaticTransformCompatible_UseStaticTransform;
    [FieldOffset(200)]
    public ServantType StationServants_Servants;
    [FieldOffset(204)]
    public int Team_FactionIndex;
    [FieldOffset(208)]
    public int Team_Value;
    [FieldOffset(212)]
    public ProjectM.TileType TileModel_DisabledTileTypes;
    [FieldOffset(213)]
    public NetworkId UserOwner_Owner;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1562818, XrefRangeEnd = 1563378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_ActiveServantMission> get_buffer_ActiveServantMission,
      ref BufferFromEntity<Snapshot_CastleBuildingAttachedChildrenBuffer> get_buffer_CastleBuildingAttachedChildrenBuffer,
      ref BufferFromEntity<Snapshot_CastleBuildingAttachToParentsBuffer> get_buffer_CastleBuildingAttachToParentsBuffer,
      ref BufferFromEntity<Snapshot_CastleMemberNames> get_buffer_CastleMemberNames,
      ref BufferFromEntity<Snapshot_CastleTeleporterElement> get_buffer_CastleTeleporterElement,
      ref BufferFromEntity<Snapshot_InventoryBuffer> get_buffer_InventoryBuffer,
      ref BufferFromEntity<Snapshot_Restricted_InventoryBuffer> get_buffer_Restricted_InventoryBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_ActiveServantMission;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleBuildingAttachedChildrenBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleBuildingAttachToParentsBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleMemberNames;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleTeleporterElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_InventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_Restricted_InventoryBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cedekbhedh.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_ActiveServantMission_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachToParentsBuffer_byref_BufferFromEntity_1_Snapshot_CastleMemberNames_byref_BufferFromEntity_1_Snapshot_CastleTeleporterElement_byref_BufferFromEntity_1_Snapshot_InventoryBuffer_byref_BufferFromEntity_1_Snapshot_Restricted_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1563631, RefRangeEnd = 1563632, XrefRangeStart = 1563378, XrefRangeEnd = 1563631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_ActiveServantMission> buffer_ActiveServantMission,
      DynamicBuffer<Snapshot_CastleBuildingAttachedChildrenBuffer> buffer_CastleBuildingAttachedChildrenBuffer,
      DynamicBuffer<Snapshot_CastleBuildingAttachToParentsBuffer> buffer_CastleBuildingAttachToParentsBuffer,
      DynamicBuffer<Snapshot_CastleMemberNames> buffer_CastleMemberNames,
      DynamicBuffer<Snapshot_CastleTeleporterElement> buffer_CastleTeleporterElement,
      DynamicBuffer<Snapshot_InventoryBuffer> buffer_InventoryBuffer,
      DynamicBuffer<Snapshot_Restricted_InventoryBuffer> buffer_Restricted_InventoryBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_ActiveServantMission;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleBuildingAttachedChildrenBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleBuildingAttachToParentsBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleMemberNames;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleTeleporterElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_InventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_Restricted_InventoryBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cedekbhedh.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_ActiveServantMission_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_DynamicBuffer_1_Snapshot_CastleBuildingAttachToParentsBuffer_DynamicBuffer_1_Snapshot_CastleMemberNames_DynamicBuffer_1_Snapshot_CastleTeleporterElement_DynamicBuffer_1_Snapshot_InventoryBuffer_DynamicBuffer_1_Snapshot_Restricted_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cedekbhedh()
    {
      Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cedekbhedh));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr);
      Snapshot_cedekbhedh.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CastleFloorRoof_RoofEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CastleFloorRoof_RoofEntity));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CastleHeart_CastleRaidEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CastleHeart_CastleRaidEndTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CastleHeart_CastleSiegeEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CastleHeart_CastleSiegeEndTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CastleHeart_CastleTerritoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CastleHeart_CastleTerritoryId));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CastleHeart_MinorCastleSiegeEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CastleHeart_MinorCastleSiegeEndTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CastleHeartConnection_CastleHeartEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CastleHeartConnection_CastleHeartEntity));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CastleRoomConnection_RoomEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CastleRoomConnection_RoomEntity));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CastleWorkstation_WorkstationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CastleWorkstation_WorkstationLevel));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CreatedTime_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CreatedTime_CreateTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_DismantleDestroyData_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (DismantleDestroyData_WasDismantled));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_EditableTileModel_CanRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (EditableTileModel_CanRepair));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_EditableTileModel_CurrentEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (EditableTileModel_CurrentEditor));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_EditableTileModel_IsDismantling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (EditableTileModel_IsDismantling));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_EditableTileModel_IsEdited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (EditableTileModel_IsEdited));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_EditableTileModel_IsRepairing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (EditableTileModel_IsRepairing));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Health_IsDead));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Health_MaxHealth));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Health_MaxRecoveryHealth));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Health_TimeOfDeath));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Health_Value));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (InteractedUpon_Interacting));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_CastleFreeClaimUntilTimePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_CastleFreeClaimUntilTimePoint));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_CurrentRecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_CurrentRecipeGuid));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_FloorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_FloorCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_FuelPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_FuelPercentage));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_HasCastleItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_HasCastleItems));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_Level));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_MinutesRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_MinutesRemaining));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_NestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_NestCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_PrisonCellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_PrisonCellCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_Progress));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_SafetyBoxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_SafetyBoxCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_ServantCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_ServantCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_State));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Pylonstation_TombCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Pylonstation_TombCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (StaticTransformCompatible_StaticTransform));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (StaticTransformCompatible_UseStaticTransform));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_StationServants_Servants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (StationServants_Servants));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (Team_Value));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_UserOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (UserOwner_Owner));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleFloorRoof_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CastleFloorRoof_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleFloorRoof_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CastleFloorRoof_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeart_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CastleHeart_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeart_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CastleHeart_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CastleHeartConnection_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CastleHeartConnection_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleRoomConnection_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CastleRoomConnection_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleRoomConnection_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CastleRoomConnection_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CastleWorkstation_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CastleWorkstation_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CreatedTime_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_CreatedTime_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_DismantleDestroyData_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_DismantleDestroyData_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_EditableTileModel_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_EditableTileModel_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Health_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_Health_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Health_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_Health_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Pylonstation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_Pylonstation_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Pylonstation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_Pylonstation_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StationServants_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_StationServants_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StationServants_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_StationServants_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_UserOwner_Start));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedFields_UserOwner_Count));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleFloorRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleFloorRoof));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeart));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeartConnection));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleRoomConnection));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleWorkstation));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CreatedTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_DismantleDestroyData));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Health));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_StationServants));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_UserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_UserOwner));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_ActiveServantMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_ActiveServantMission));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleBuildingAttachedChildrenBuffer));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleBuildingAttachToParentsBuffer));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleMemberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleMemberNames));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleTeleporterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleTeleporterElement));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_InventoryBuffer));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Restricted_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Restricted_InventoryBuffer));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleFloorRoof_RoofEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleFloorRoof_RoofEntity));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleRaidEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeart_CastleRaidEndTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleSiegeEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeart_CastleSiegeEndTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleTerritoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeart_CastleTerritoryId));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_MinorCastleSiegeEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeart_MinorCastleSiegeEndTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleHeartConnection_CastleHeartEntity));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleRoomConnection_RoomEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleRoomConnection_RoomEntity));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CastleWorkstation_WorkstationLevel));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_CreatedTime_CreateTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_DismantleDestroyData_WasDismantled));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_CanRepair));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_CurrentEditor));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsDismantling));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsEdited));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_EditableTileModel_IsRepairing));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Health_IsDead));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxHealth));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxRecoveryHealth));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Health_TimeOfDeath));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Health_Value));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon_Interacting));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_CastleFreeClaimUntilTimePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_CastleFreeClaimUntilTimePoint));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_CurrentRecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_CurrentRecipeGuid));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_FloorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_FloorCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_FuelPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_FuelPercentage));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_HasCastleItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_HasCastleItems));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_Level));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_MinutesRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_MinutesRemaining));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_NestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_NestCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_PrisonCellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_PrisonCellCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_Progress));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_SafetyBoxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_SafetyBoxCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_ServantCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_ServantCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_State));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_TombCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Pylonstation_TombCount));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_StaticTransform));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_UseStaticTransform));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_StationServants_Servants));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_UserOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (FrameChangedIndex_UserOwner_Owner));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleFloorRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleFloorRoof));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleFloorRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_CastleFloorRoof));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleHeart));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_CastleHeart));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleHeartConnection));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_CastleHeartConnection));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleRoomConnection));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_CastleRoomConnection));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleWorkstation));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_CastleWorkstation));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_CreatedTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_CreatedTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_DismantleDestroyData));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_DismantleDestroyData));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_EditableTileModel));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_EditableTileModel));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_Health));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_Health));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_InteractedUpon));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_InteractedUpon));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_Pylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_Pylonstation));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_Pylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_Pylonstation));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_StaticTransformCompatible));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_StaticTransformCompatible));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_StationServants));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_StationServants));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_UserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataStartOffset_UserOwner));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_UserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (ComponentDataSize_UserOwner));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleFloorRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_CastleFloorRoof));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_CastleHeart));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_CastleHeartConnection));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_CastleRoomConnection));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_CastleWorkstation));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_CreatedTime));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_DismantleDestroyData));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_EditableTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_EditableTileModel));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_Health));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_InteractedUpon));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Pylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_Pylonstation));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_StaticTransformCompatible));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_StationServants));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_UserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_UserOwner));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_ActiveServantMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_ActiveServantMission));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_CastleBuildingAttachedChildrenBuffer));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_CastleBuildingAttachToParentsBuffer));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleMemberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_CastleMemberNames));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleTeleporterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_CastleTeleporterElement));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_InventoryBuffer));
      Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Restricted_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, nameof (CompBit_Restricted_InventoryBuffer));
      Snapshot_cedekbhedh.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_ActiveServantMission_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachedChildrenBuffer_byref_BufferFromEntity_1_Snapshot_CastleBuildingAttachToParentsBuffer_byref_BufferFromEntity_1_Snapshot_CastleMemberNames_byref_BufferFromEntity_1_Snapshot_CastleTeleporterElement_byref_BufferFromEntity_1_Snapshot_InventoryBuffer_byref_BufferFromEntity_1_Snapshot_Restricted_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, 100664488);
      Snapshot_cedekbhedh.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_ActiveServantMission_DynamicBuffer_1_Snapshot_CastleBuildingAttachedChildrenBuffer_DynamicBuffer_1_Snapshot_CastleBuildingAttachToParentsBuffer_DynamicBuffer_1_Snapshot_CastleMemberNames_DynamicBuffer_1_Snapshot_CastleTeleporterElement_DynamicBuffer_1_Snapshot_InventoryBuffer_DynamicBuffer_1_Snapshot_Restricted_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, 100664489);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cedekbhedh>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleFloorRoof_Start
    {
      get
      {
        int castleFloorRoofStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleFloorRoof_Start, (void*) &castleFloorRoofStart);
        return castleFloorRoofStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleFloorRoof_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleFloorRoof_Count
    {
      get
      {
        int castleFloorRoofCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleFloorRoof_Count, (void*) &castleFloorRoofCount);
        return castleFloorRoofCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleFloorRoof_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleHeart_Start
    {
      get
      {
        int castleHeartStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeart_Start, (void*) &castleHeartStart);
        return castleHeartStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeart_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleHeart_Count
    {
      get
      {
        int castleHeartCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeart_Count, (void*) &castleHeartCount);
        return castleHeartCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeart_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleHeartConnection_Start
    {
      get
      {
        int heartConnectionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start, (void*) &heartConnectionStart);
        return heartConnectionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleHeartConnection_Count
    {
      get
      {
        int heartConnectionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count, (void*) &heartConnectionCount);
        return heartConnectionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleHeartConnection_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleRoomConnection_Start
    {
      get
      {
        int roomConnectionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleRoomConnection_Start, (void*) &roomConnectionStart);
        return roomConnectionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleRoomConnection_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleRoomConnection_Count
    {
      get
      {
        int roomConnectionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleRoomConnection_Count, (void*) &roomConnectionCount);
        return roomConnectionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleRoomConnection_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleWorkstation_Start
    {
      get
      {
        int workstationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start, (void*) &workstationStart);
        return workstationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleWorkstation_Count
    {
      get
      {
        int workstationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count, (void*) &workstationCount);
        return workstationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CreatedTime_Start
    {
      get
      {
        int createdTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start, (void*) &createdTimeStart);
        return createdTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CreatedTime_Count
    {
      get
      {
        int createdTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count, (void*) &createdTimeCount);
        return createdTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DismantleDestroyData_Start
    {
      get
      {
        int destroyDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start, (void*) &destroyDataStart);
        return destroyDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DismantleDestroyData_Count
    {
      get
      {
        int destroyDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count, (void*) &destroyDataCount);
        return destroyDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EditableTileModel_Start
    {
      get
      {
        int editableTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start, (void*) &editableTileModelStart);
        return editableTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EditableTileModel_Count
    {
      get
      {
        int editableTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count, (void*) &editableTileModelCount);
        return editableTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_EditableTileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Start
    {
      get
      {
        int fieldsHealthStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &fieldsHealthStart);
        return fieldsHealthStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Count
    {
      get
      {
        int fieldsHealthCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &fieldsHealthCount);
        return fieldsHealthCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Start
    {
      get
      {
        int interactedUponStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &interactedUponStart);
        return interactedUponStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Count
    {
      get
      {
        int interactedUponCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &interactedUponCount);
        return interactedUponCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Pylonstation_Start
    {
      get
      {
        int pylonstationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Pylonstation_Start, (void*) &pylonstationStart);
        return pylonstationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Pylonstation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Pylonstation_Count
    {
      get
      {
        int pylonstationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Pylonstation_Count, (void*) &pylonstationCount);
        return pylonstationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Pylonstation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Start
    {
      get
      {
        int transformCompatibleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &transformCompatibleStart);
        return transformCompatibleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Count
    {
      get
      {
        int transformCompatibleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &transformCompatibleCount);
        return transformCompatibleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StationServants_Start
    {
      get
      {
        int stationServantsStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StationServants_Start, (void*) &stationServantsStart);
        return stationServantsStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StationServants_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StationServants_Count
    {
      get
      {
        int stationServantsCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StationServants_Count, (void*) &stationServantsCount);
        return stationServantsCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_StationServants_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UserOwner_Start
    {
      get
      {
        int fieldsUserOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Start, (void*) &fieldsUserOwnerStart);
        return fieldsUserOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UserOwner_Count
    {
      get
      {
        int fieldsUserOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Count, (void*) &fieldsUserOwnerCount);
        return fieldsUserOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleFloorRoof
    {
      get
      {
        int indexCastleFloorRoof;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleFloorRoof, (void*) &indexCastleFloorRoof);
        return indexCastleFloorRoof;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleFloorRoof, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeart
    {
      get
      {
        int indexCastleHeart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart, (void*) &indexCastleHeart);
        return indexCastleHeart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeartConnection
    {
      get
      {
        int castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleRoomConnection
    {
      get
      {
        int castleRoomConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleRoomConnection, (void*) &castleRoomConnection);
        return castleRoomConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleRoomConnection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleWorkstation
    {
      get
      {
        int castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CreatedTime
    {
      get
      {
        int indexCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime, (void*) &indexCreatedTime);
        return indexCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health
    {
      get
      {
        int changedIndexHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &changedIndexHealth);
        return changedIndexHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon
    {
      get
      {
        int indexInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &indexInteractedUpon);
        return indexInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation
    {
      get
      {
        int indexPylonstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation, (void*) &indexPylonstation);
        return indexPylonstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StationServants
    {
      get
      {
        int indexStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StationServants, (void*) &indexStationServants);
        return indexStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StationServants, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UserOwner
    {
      get
      {
        int changedIndexUserOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_UserOwner, (void*) &changedIndexUserOwner);
        return changedIndexUserOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_UserOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ActiveServantMission
    {
      get
      {
        int activeServantMission;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_ActiveServantMission, (void*) &activeServantMission);
        return activeServantMission;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_ActiveServantMission, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        int attachedChildrenBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer, (void*) &attachedChildrenBuffer);
        return attachedChildrenBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachedChildrenBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleBuildingAttachToParentsBuffer
    {
      get
      {
        int attachToParentsBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer, (void*) &attachToParentsBuffer);
        return attachToParentsBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleBuildingAttachToParentsBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleMemberNames
    {
      get
      {
        int castleMemberNames;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleMemberNames, (void*) &castleMemberNames);
        return castleMemberNames;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleMemberNames, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleTeleporterElement
    {
      get
      {
        int teleporterElement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleTeleporterElement, (void*) &teleporterElement);
        return teleporterElement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleTeleporterElement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InventoryBuffer
    {
      get
      {
        int indexInventoryBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer, (void*) &indexInventoryBuffer);
        return indexInventoryBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Restricted_InventoryBuffer
    {
      get
      {
        int restrictedInventoryBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Restricted_InventoryBuffer, (void*) &restrictedInventoryBuffer);
        return restrictedInventoryBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Restricted_InventoryBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleFloorRoof_RoofEntity
    {
      get
      {
        int floorRoofRoofEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleFloorRoof_RoofEntity, (void*) &floorRoofRoofEntity);
        return floorRoofRoofEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleFloorRoof_RoofEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeart_CastleRaidEndTime
    {
      get
      {
        int castleRaidEndTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleRaidEndTime, (void*) &castleRaidEndTime);
        return castleRaidEndTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleRaidEndTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeart_CastleSiegeEndTime
    {
      get
      {
        int castleSiegeEndTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleSiegeEndTime, (void*) &castleSiegeEndTime);
        return castleSiegeEndTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleSiegeEndTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeart_CastleTerritoryId
    {
      get
      {
        int castleTerritoryId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleTerritoryId, (void*) &castleTerritoryId);
        return castleTerritoryId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_CastleTerritoryId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeart_MinorCastleSiegeEndTime
    {
      get
      {
        int castleSiegeEndTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_MinorCastleSiegeEndTime, (void*) &castleSiegeEndTime);
        return castleSiegeEndTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeart_MinorCastleSiegeEndTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleHeartConnection_CastleHeartEntity
    {
      get
      {
        int castleHeartEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity, (void*) &castleHeartEntity);
        return castleHeartEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleHeartConnection_CastleHeartEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleRoomConnection_RoomEntity
    {
      get
      {
        int connectionRoomEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleRoomConnection_RoomEntity, (void*) &connectionRoomEntity);
        return connectionRoomEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleRoomConnection_RoomEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleWorkstation_WorkstationLevel
    {
      get
      {
        int workstationLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel, (void*) &workstationLevel);
        return workstationLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CreatedTime_CreateTime
    {
      get
      {
        int createdTimeCreateTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime, (void*) &createdTimeCreateTime);
        return createdTimeCreateTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DismantleDestroyData_WasDismantled
    {
      get
      {
        int dataWasDismantled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled, (void*) &dataWasDismantled);
        return dataWasDismantled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_CanRepair
    {
      get
      {
        int tileModelCanRepair;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair, (void*) &tileModelCanRepair);
        return tileModelCanRepair;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CanRepair, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_CurrentEditor
    {
      get
      {
        int modelCurrentEditor;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor, (void*) &modelCurrentEditor);
        return modelCurrentEditor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_CurrentEditor, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsDismantling
    {
      get
      {
        int modelIsDismantling;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling, (void*) &modelIsDismantling);
        return modelIsDismantling;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsDismantling, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsEdited
    {
      get
      {
        int tileModelIsEdited;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited, (void*) &tileModelIsEdited);
        return tileModelIsEdited;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsEdited, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EditableTileModel_IsRepairing
    {
      get
      {
        int modelIsRepairing;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing, (void*) &modelIsRepairing);
        return modelIsRepairing;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_EditableTileModel_IsRepairing, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_IsDead
    {
      get
      {
        int indexHealthIsDead;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &indexHealthIsDead);
        return indexHealthIsDead;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxHealth
    {
      get
      {
        int indexHealthMaxHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &indexHealthMaxHealth);
        return indexHealthMaxHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxRecoveryHealth
    {
      get
      {
        int maxRecoveryHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &maxRecoveryHealth);
        return maxRecoveryHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_TimeOfDeath
    {
      get
      {
        int healthTimeOfDeath;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &healthTimeOfDeath);
        return healthTimeOfDeath;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_Value
    {
      get
      {
        int indexHealthValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &indexHealthValue);
        return indexHealthValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon_Interacting
    {
      get
      {
        int interactedUponInteracting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &interactedUponInteracting);
        return interactedUponInteracting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_CastleFreeClaimUntilTimePoint
    {
      get
      {
        int claimUntilTimePoint;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_CastleFreeClaimUntilTimePoint, (void*) &claimUntilTimePoint);
        return claimUntilTimePoint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_CastleFreeClaimUntilTimePoint, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_CurrentRecipeGuid
    {
      get
      {
        int currentRecipeGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_CurrentRecipeGuid, (void*) &currentRecipeGuid);
        return currentRecipeGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_CurrentRecipeGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_FloorCount
    {
      get
      {
        int pylonstationFloorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_FloorCount, (void*) &pylonstationFloorCount);
        return pylonstationFloorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_FloorCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_FuelPercentage
    {
      get
      {
        int pylonstationFuelPercentage;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_FuelPercentage, (void*) &pylonstationFuelPercentage);
        return pylonstationFuelPercentage;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_FuelPercentage, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_HasCastleItems
    {
      get
      {
        int pylonstationHasCastleItems;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_HasCastleItems, (void*) &pylonstationHasCastleItems);
        return pylonstationHasCastleItems;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_HasCastleItems, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_Level
    {
      get
      {
        int pylonstationLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_Level, (void*) &pylonstationLevel);
        return pylonstationLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_Level, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_MinutesRemaining
    {
      get
      {
        int minutesRemaining;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_MinutesRemaining, (void*) &minutesRemaining);
        return minutesRemaining;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_MinutesRemaining, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_NestCount
    {
      get
      {
        int pylonstationNestCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_NestCount, (void*) &pylonstationNestCount);
        return pylonstationNestCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_NestCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_PrisonCellCount
    {
      get
      {
        int pylonstationPrisonCellCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_PrisonCellCount, (void*) &pylonstationPrisonCellCount);
        return pylonstationPrisonCellCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_PrisonCellCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_Progress
    {
      get
      {
        int pylonstationProgress;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_Progress, (void*) &pylonstationProgress);
        return pylonstationProgress;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_Progress, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_SafetyBoxCount
    {
      get
      {
        int pylonstationSafetyBoxCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_SafetyBoxCount, (void*) &pylonstationSafetyBoxCount);
        return pylonstationSafetyBoxCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_SafetyBoxCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_ServantCount
    {
      get
      {
        int pylonstationServantCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_ServantCount, (void*) &pylonstationServantCount);
        return pylonstationServantCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_ServantCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_State
    {
      get
      {
        int pylonstationState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_State, (void*) &pylonstationState);
        return pylonstationState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_State, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Pylonstation_TombCount
    {
      get
      {
        int pylonstationTombCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_TombCount, (void*) &pylonstationTombCount);
        return pylonstationTombCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Pylonstation_TombCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height
    {
      get
      {
        int staticTransformHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &staticTransformHeight);
        return staticTransformHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos
    {
      get
      {
        int staticTransformPos;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &staticTransformPos);
        return staticTransformPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation
    {
      get
      {
        int transformRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &transformRotation);
        return transformRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_StaticTransform
    {
      get
      {
        int compatibleStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &compatibleStaticTransform);
        return compatibleStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_UseStaticTransform
    {
      get
      {
        int useStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &useStaticTransform);
        return useStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StationServants_Servants
    {
      get
      {
        int servantsServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants, (void*) &servantsServants);
        return servantsServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UserOwner_Owner
    {
      get
      {
        int indexUserOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_UserOwner_Owner, (void*) &indexUserOwnerOwner);
        return indexUserOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_FrameChangedIndex_UserOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleFloorRoof
    {
      get
      {
        int offsetCastleFloorRoof;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleFloorRoof, (void*) &offsetCastleFloorRoof);
        return offsetCastleFloorRoof;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleFloorRoof, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleFloorRoof
    {
      get
      {
        int sizeCastleFloorRoof;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleFloorRoof, (void*) &sizeCastleFloorRoof);
        return sizeCastleFloorRoof;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleFloorRoof, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleHeart
    {
      get
      {
        int offsetCastleHeart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeart, (void*) &offsetCastleHeart);
        return offsetCastleHeart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeart, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleHeart
    {
      get
      {
        int dataSizeCastleHeart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleHeart, (void*) &dataSizeCastleHeart);
        return dataSizeCastleHeart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleHeart, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleHeartConnection
    {
      get
      {
        int castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleHeartConnection
    {
      get
      {
        int castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleRoomConnection
    {
      get
      {
        int castleRoomConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoomConnection, (void*) &castleRoomConnection);
        return castleRoomConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoomConnection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleRoomConnection
    {
      get
      {
        int castleRoomConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleRoomConnection, (void*) &castleRoomConnection);
        return castleRoomConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleRoomConnection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleWorkstation
    {
      get
      {
        int castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleWorkstation
    {
      get
      {
        int castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CreatedTime
    {
      get
      {
        int offsetCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime, (void*) &offsetCreatedTime);
        return offsetCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CreatedTime
    {
      get
      {
        int dataSizeCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CreatedTime, (void*) &dataSizeCreatedTime);
        return dataSizeCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EditableTileModel
    {
      get
      {
        int editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Health
    {
      get
      {
        int startOffsetHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &startOffsetHealth);
        return startOffsetHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Health
    {
      get
      {
        int componentDataSizeHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &componentDataSizeHealth);
        return componentDataSizeHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InteractedUpon
    {
      get
      {
        int offsetInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &offsetInteractedUpon);
        return offsetInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InteractedUpon
    {
      get
      {
        int sizeInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &sizeInteractedUpon);
        return sizeInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Pylonstation
    {
      get
      {
        int offsetPylonstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_Pylonstation, (void*) &offsetPylonstation);
        return offsetPylonstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_Pylonstation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Pylonstation
    {
      get
      {
        int sizePylonstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_Pylonstation, (void*) &sizePylonstation);
        return sizePylonstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_Pylonstation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StationServants
    {
      get
      {
        int offsetStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_StationServants, (void*) &offsetStationServants);
        return offsetStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_StationServants, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StationServants
    {
      get
      {
        int sizeStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_StationServants, (void*) &sizeStationServants);
        return sizeStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_StationServants, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_UserOwner
    {
      get
      {
        int startOffsetUserOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_UserOwner, (void*) &startOffsetUserOwner);
        return startOffsetUserOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataStartOffset_UserOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_UserOwner
    {
      get
      {
        int dataSizeUserOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_UserOwner, (void*) &dataSizeUserOwner);
        return dataSizeUserOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_ComponentDataSize_UserOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleFloorRoof
    {
      get
      {
        ulong bitCastleFloorRoof;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleFloorRoof, (void*) &bitCastleFloorRoof);
        return bitCastleFloorRoof;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleFloorRoof, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleHeart
    {
      get
      {
        ulong compBitCastleHeart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleHeart, (void*) &compBitCastleHeart);
        return compBitCastleHeart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleHeart, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleHeartConnection
    {
      get
      {
        ulong castleHeartConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleHeartConnection, (void*) &castleHeartConnection);
        return castleHeartConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleHeartConnection, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleRoomConnection
    {
      get
      {
        ulong castleRoomConnection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleRoomConnection, (void*) &castleRoomConnection);
        return castleRoomConnection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleRoomConnection, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleWorkstation
    {
      get
      {
        ulong castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CreatedTime
    {
      get
      {
        ulong compBitCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CreatedTime, (void*) &compBitCreatedTime);
        return compBitCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CreatedTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DismantleDestroyData
    {
      get
      {
        ulong dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EditableTileModel
    {
      get
      {
        ulong editableTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_EditableTileModel, (void*) &editableTileModel);
        return editableTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_EditableTileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Health
    {
      get
      {
        ulong compBitHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Health, (void*) &compBitHealth);
        return compBitHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Health, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InteractedUpon
    {
      get
      {
        ulong bitInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &bitInteractedUpon);
        return bitInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Pylonstation
    {
      get
      {
        ulong compBitPylonstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Pylonstation, (void*) &compBitPylonstation);
        return compBitPylonstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Pylonstation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StaticTransformCompatible
    {
      get
      {
        ulong transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StationServants
    {
      get
      {
        ulong bitStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_StationServants, (void*) &bitStationServants);
        return bitStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_StationServants, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_UserOwner
    {
      get
      {
        ulong compBitUserOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_UserOwner, (void*) &compBitUserOwner);
        return compBitUserOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_UserOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ActiveServantMission
    {
      get
      {
        ulong activeServantMission;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_ActiveServantMission, (void*) &activeServantMission);
        return activeServantMission;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_ActiveServantMission, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleBuildingAttachedChildrenBuffer
    {
      get
      {
        ulong attachedChildrenBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer, (void*) &attachedChildrenBuffer);
        return attachedChildrenBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleBuildingAttachedChildrenBuffer, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleBuildingAttachToParentsBuffer
    {
      get
      {
        ulong attachToParentsBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer, (void*) &attachToParentsBuffer);
        return attachToParentsBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleBuildingAttachToParentsBuffer, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleMemberNames
    {
      get
      {
        ulong castleMemberNames;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleMemberNames, (void*) &castleMemberNames);
        return castleMemberNames;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleMemberNames, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleTeleporterElement
    {
      get
      {
        ulong teleporterElement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleTeleporterElement, (void*) &teleporterElement);
        return teleporterElement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_CastleTeleporterElement, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InventoryBuffer
    {
      get
      {
        ulong bitInventoryBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_InventoryBuffer, (void*) &bitInventoryBuffer);
        return bitInventoryBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_InventoryBuffer, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Restricted_InventoryBuffer
    {
      get
      {
        ulong restrictedInventoryBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Restricted_InventoryBuffer, (void*) &restrictedInventoryBuffer);
        return restrictedInventoryBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cedekbhedh.NativeFieldInfoPtr_CompBit_Restricted_InventoryBuffer, (void*) &value);
      }
    }
  }
}
