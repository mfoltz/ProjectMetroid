// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cfbjghgjgf
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_cfbjghgjgf
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementOwner_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Controller_Controlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_Emoter_IsEmoting;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputCommandDataProxy_CommandDataEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionMapper_ProgressionEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Shapeshift_IsShapeshifted;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_User_CharacterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_User_ClanEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_User_Generation;
    private static readonly System.IntPtr NativeFieldInfoPtr_User_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_User_IsAdmin;
    private static readonly System.IntPtr NativeFieldInfoPtr_User_IsConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr_User_LocalCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_User_PlatformId;
    private static readonly System.IntPtr NativeFieldInfoPtr_User_UserContent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserHeartCount_HeartCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AchievementOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AchievementOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Controller_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Controller_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Emoter_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Emoter_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InputCommandDataProxy_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InputCommandDataProxy_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ProgressionMapper_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ProgressionMapper_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Shapeshift_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Shapeshift_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_User_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_User_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UserHeartCount_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UserHeartCount_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AchievementOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Controller;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Emoter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InputCommandDataProxy;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ProgressionMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Shapeshift;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_User;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UserHeartCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AllyPermission;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_QueuedWorkstationCraftAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RespawnPointOwnerBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UnlockedWaypointElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UserMapZoneElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AchievementOwner_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Controller_Controlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Emoter_IsEmoting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InputCommandDataProxy_CommandDataEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ProgressionMapper_ProgressionEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Shapeshift_IsShapeshifted;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_User_CharacterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_User_ClanEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_User_Generation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_User_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_User_IsAdmin;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_User_IsConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_User_LocalCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_User_PlatformId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_User_UserContent;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UserHeartCount_HeartCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AchievementOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AchievementOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Controller;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Controller;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Emoter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Emoter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandDataProxy;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InputCommandDataProxy;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ProgressionMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ProgressionMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Shapeshift;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Shapeshift;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_User;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_User;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_UserHeartCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_UserHeartCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AchievementOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Controller;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Emoter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InputCommandDataProxy;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ProgressionMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Shapeshift;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_User;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_UserHeartCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AllyPermission;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_QueuedWorkstationCraftAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_RespawnPointOwnerBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_UnlockedWaypointElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_UserMapZoneElement;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AllyPermission_byref_BufferFromEntity_1_Snapshot_QueuedWorkstationCraftAction_byref_BufferFromEntity_1_Snapshot_RespawnPointOwnerBuffer_byref_BufferFromEntity_1_Snapshot_UnlockedWaypointElement_byref_BufferFromEntity_1_Snapshot_UserMapZoneElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AllyPermission_DynamicBuffer_1_Snapshot_QueuedWorkstationCraftAction_DynamicBuffer_1_Snapshot_RespawnPointOwnerBuffer_DynamicBuffer_1_Snapshot_UnlockedWaypointElement_DynamicBuffer_1_Snapshot_UserMapZoneElement_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public NetworkId AchievementOwner_Entity;
    [FieldOffset(16)]
    public NetworkId Controller_Controlled;
    [FieldOffset(24)]
    public ModifiableBool Emoter_IsEmoting;
    [FieldOffset(28)]
    public NetworkId InputCommandDataProxy_CommandDataEntity;
    [FieldOffset(36)]
    public NetworkId ProgressionMapper_ProgressionEntity;
    [FieldOffset(44)]
    public ModifiableBool Shapeshift_IsShapeshifted;
    [FieldOffset(48)]
    public int Team_FactionIndex;
    [FieldOffset(52)]
    public int Team_Value;
    [FieldOffset(56)]
    public FixedString64 User_CharacterName;
    [FieldOffset(120)]
    public NetworkId User_ClanEntity;
    [FieldOffset(128)]
    public int User_Generation;
    [FieldOffset(132)]
    public int User_Index;
    [FieldOffset(136)]
    public bool User_IsAdmin;
    [FieldOffset(137)]
    public bool User_IsConnected;
    [FieldOffset(138)]
    public NetworkId User_LocalCharacter;
    [FieldOffset(146)]
    public ulong User_PlatformId;
    [FieldOffset(154)]
    public UserContentFlags User_UserContent;
    [FieldOffset(158)]
    public int UserHeartCount_HeartCount;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1567384, XrefRangeEnd = 1567683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_AllyPermission> get_buffer_AllyPermission,
      ref BufferFromEntity<Snapshot_QueuedWorkstationCraftAction> get_buffer_QueuedWorkstationCraftAction,
      ref BufferFromEntity<Snapshot_RespawnPointOwnerBuffer> get_buffer_RespawnPointOwnerBuffer,
      ref BufferFromEntity<Snapshot_UnlockedWaypointElement> get_buffer_UnlockedWaypointElement,
      ref BufferFromEntity<Snapshot_UserMapZoneElement> get_buffer_UserMapZoneElement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_AllyPermission;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_QueuedWorkstationCraftAction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_RespawnPointOwnerBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_UnlockedWaypointElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_UserMapZoneElement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cfbjghgjgf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AllyPermission_byref_BufferFromEntity_1_Snapshot_QueuedWorkstationCraftAction_byref_BufferFromEntity_1_Snapshot_RespawnPointOwnerBuffer_byref_BufferFromEntity_1_Snapshot_UnlockedWaypointElement_byref_BufferFromEntity_1_Snapshot_UserMapZoneElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1567834, RefRangeEnd = 1567835, XrefRangeStart = 1567683, XrefRangeEnd = 1567834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_AllyPermission> buffer_AllyPermission,
      DynamicBuffer<Snapshot_QueuedWorkstationCraftAction> buffer_QueuedWorkstationCraftAction,
      DynamicBuffer<Snapshot_RespawnPointOwnerBuffer> buffer_RespawnPointOwnerBuffer,
      DynamicBuffer<Snapshot_UnlockedWaypointElement> buffer_UnlockedWaypointElement,
      DynamicBuffer<Snapshot_UserMapZoneElement> buffer_UserMapZoneElement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_AllyPermission;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_QueuedWorkstationCraftAction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_RespawnPointOwnerBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_UnlockedWaypointElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_UserMapZoneElement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cfbjghgjgf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AllyPermission_DynamicBuffer_1_Snapshot_QueuedWorkstationCraftAction_DynamicBuffer_1_Snapshot_RespawnPointOwnerBuffer_DynamicBuffer_1_Snapshot_UnlockedWaypointElement_DynamicBuffer_1_Snapshot_UserMapZoneElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cfbjghgjgf()
    {
      Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cfbjghgjgf));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr);
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_AchievementOwner_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (AchievementOwner_Entity));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_Controller_Controlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (Controller_Controlled));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_Emoter_IsEmoting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (Emoter_IsEmoting));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_InputCommandDataProxy_CommandDataEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (InputCommandDataProxy_CommandDataEntity));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ProgressionMapper_ProgressionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ProgressionMapper_ProgressionEntity));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_Shapeshift_IsShapeshifted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (Shapeshift_IsShapeshifted));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (Team_Value));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_User_CharacterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (User_CharacterName));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_User_ClanEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (User_ClanEntity));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_User_Generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (User_Generation));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_User_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (User_Index));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_User_IsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (User_IsAdmin));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_User_IsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (User_IsConnected));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_User_LocalCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (User_LocalCharacter));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_User_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (User_PlatformId));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_User_UserContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (User_UserContent));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_UserHeartCount_HeartCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (UserHeartCount_HeartCount));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_AchievementOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_AchievementOwner_Start));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_AchievementOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_AchievementOwner_Count));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Controller_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_Controller_Start));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Controller_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_Controller_Count));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Emoter_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_Emoter_Start));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Emoter_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_Emoter_Count));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_InputCommandDataProxy_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_InputCommandDataProxy_Start));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_InputCommandDataProxy_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_InputCommandDataProxy_Count));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_ProgressionMapper_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_ProgressionMapper_Start));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_ProgressionMapper_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_ProgressionMapper_Count));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Shapeshift_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_Shapeshift_Start));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Shapeshift_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_Shapeshift_Count));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_User_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_User_Start));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_User_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_User_Count));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_UserHeartCount_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_UserHeartCount_Start));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_UserHeartCount_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedFields_UserHeartCount_Count));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_AchievementOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_AchievementOwner));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_Controller));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Emoter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_Emoter));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_InputCommandDataProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_InputCommandDataProxy));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_ProgressionMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_ProgressionMapper));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Shapeshift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_Shapeshift));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_User));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UserHeartCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_UserHeartCount));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_AllyPermission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_AllyPermission));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_QueuedWorkstationCraftAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_QueuedWorkstationCraftAction));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_RespawnPointOwnerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_RespawnPointOwnerBuffer));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UnlockedWaypointElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_UnlockedWaypointElement));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UserMapZoneElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_UserMapZoneElement));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_AchievementOwner_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_AchievementOwner_Entity));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Controller_Controlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_Controller_Controlled));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Emoter_IsEmoting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_Emoter_IsEmoting));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_InputCommandDataProxy_CommandDataEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_InputCommandDataProxy_CommandDataEntity));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_ProgressionMapper_ProgressionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_ProgressionMapper_ProgressionEntity));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Shapeshift_IsShapeshifted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_Shapeshift_IsShapeshifted));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_CharacterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_User_CharacterName));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_ClanEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_User_ClanEntity));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_Generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_User_Generation));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_User_Index));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_IsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_User_IsAdmin));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_IsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_User_IsConnected));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_LocalCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_User_LocalCharacter));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_User_PlatformId));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_UserContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_User_UserContent));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UserHeartCount_HeartCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (FrameChangedIndex_UserHeartCount_HeartCount));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_AchievementOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataStartOffset_AchievementOwner));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_AchievementOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataSize_AchievementOwner));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataStartOffset_Controller));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataSize_Controller));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Emoter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataStartOffset_Emoter));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Emoter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataSize_Emoter));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandDataProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataStartOffset_InputCommandDataProxy));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_InputCommandDataProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataSize_InputCommandDataProxy));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_ProgressionMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataStartOffset_ProgressionMapper));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_ProgressionMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataSize_ProgressionMapper));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Shapeshift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataStartOffset_Shapeshift));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Shapeshift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataSize_Shapeshift));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataStartOffset_User));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataSize_User));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_UserHeartCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataStartOffset_UserHeartCount));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_UserHeartCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (ComponentDataSize_UserHeartCount));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_AchievementOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_AchievementOwner));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_Controller));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Emoter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_Emoter));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_InputCommandDataProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_InputCommandDataProxy));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_ProgressionMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_ProgressionMapper));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Shapeshift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_Shapeshift));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_User));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_UserHeartCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_UserHeartCount));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_AllyPermission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_AllyPermission));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_QueuedWorkstationCraftAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_QueuedWorkstationCraftAction));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_RespawnPointOwnerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_RespawnPointOwnerBuffer));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_UnlockedWaypointElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_UnlockedWaypointElement));
      Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_UserMapZoneElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, nameof (CompBit_UserMapZoneElement));
      Snapshot_cfbjghgjgf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AllyPermission_byref_BufferFromEntity_1_Snapshot_QueuedWorkstationCraftAction_byref_BufferFromEntity_1_Snapshot_RespawnPointOwnerBuffer_byref_BufferFromEntity_1_Snapshot_UnlockedWaypointElement_byref_BufferFromEntity_1_Snapshot_UserMapZoneElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, 100664508);
      Snapshot_cfbjghgjgf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AllyPermission_DynamicBuffer_1_Snapshot_QueuedWorkstationCraftAction_DynamicBuffer_1_Snapshot_RespawnPointOwnerBuffer_DynamicBuffer_1_Snapshot_UnlockedWaypointElement_DynamicBuffer_1_Snapshot_UserMapZoneElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, 100664509);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cfbjghgjgf>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AchievementOwner_Start
    {
      get
      {
        int achievementOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_AchievementOwner_Start, (void*) &achievementOwnerStart);
        return achievementOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_AchievementOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AchievementOwner_Count
    {
      get
      {
        int achievementOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_AchievementOwner_Count, (void*) &achievementOwnerCount);
        return achievementOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_AchievementOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Controller_Start
    {
      get
      {
        int fieldsControllerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Controller_Start, (void*) &fieldsControllerStart);
        return fieldsControllerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Controller_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Controller_Count
    {
      get
      {
        int fieldsControllerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Controller_Count, (void*) &fieldsControllerCount);
        return fieldsControllerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Controller_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Emoter_Start
    {
      get
      {
        int fieldsEmoterStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Emoter_Start, (void*) &fieldsEmoterStart);
        return fieldsEmoterStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Emoter_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Emoter_Count
    {
      get
      {
        int fieldsEmoterCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Emoter_Count, (void*) &fieldsEmoterCount);
        return fieldsEmoterCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Emoter_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InputCommandDataProxy_Start
    {
      get
      {
        int commandDataProxyStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_InputCommandDataProxy_Start, (void*) &commandDataProxyStart);
        return commandDataProxyStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_InputCommandDataProxy_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InputCommandDataProxy_Count
    {
      get
      {
        int commandDataProxyCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_InputCommandDataProxy_Count, (void*) &commandDataProxyCount);
        return commandDataProxyCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_InputCommandDataProxy_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ProgressionMapper_Start
    {
      get
      {
        int progressionMapperStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_ProgressionMapper_Start, (void*) &progressionMapperStart);
        return progressionMapperStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_ProgressionMapper_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ProgressionMapper_Count
    {
      get
      {
        int progressionMapperCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_ProgressionMapper_Count, (void*) &progressionMapperCount);
        return progressionMapperCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_ProgressionMapper_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Shapeshift_Start
    {
      get
      {
        int fieldsShapeshiftStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Shapeshift_Start, (void*) &fieldsShapeshiftStart);
        return fieldsShapeshiftStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Shapeshift_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Shapeshift_Count
    {
      get
      {
        int fieldsShapeshiftCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Shapeshift_Count, (void*) &fieldsShapeshiftCount);
        return fieldsShapeshiftCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Shapeshift_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_User_Start
    {
      get
      {
        int changedFieldsUserStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_User_Start, (void*) &changedFieldsUserStart);
        return changedFieldsUserStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_User_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_User_Count
    {
      get
      {
        int changedFieldsUserCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_User_Count, (void*) &changedFieldsUserCount);
        return changedFieldsUserCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_User_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UserHeartCount_Start
    {
      get
      {
        int userHeartCountStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_UserHeartCount_Start, (void*) &userHeartCountStart);
        return userHeartCountStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_UserHeartCount_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UserHeartCount_Count
    {
      get
      {
        int userHeartCountCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_UserHeartCount_Count, (void*) &userHeartCountCount);
        return userHeartCountCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedFields_UserHeartCount_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AchievementOwner
    {
      get
      {
        int achievementOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_AchievementOwner, (void*) &achievementOwner);
        return achievementOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_AchievementOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Controller
    {
      get
      {
        int changedIndexController;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Controller, (void*) &changedIndexController);
        return changedIndexController;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Controller, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Emoter
    {
      get
      {
        int changedIndexEmoter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Emoter, (void*) &changedIndexEmoter);
        return changedIndexEmoter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Emoter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InputCommandDataProxy
    {
      get
      {
        int commandDataProxy;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_InputCommandDataProxy, (void*) &commandDataProxy);
        return commandDataProxy;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_InputCommandDataProxy, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ProgressionMapper
    {
      get
      {
        int progressionMapper;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_ProgressionMapper, (void*) &progressionMapper);
        return progressionMapper;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_ProgressionMapper, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Shapeshift
    {
      get
      {
        int changedIndexShapeshift;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Shapeshift, (void*) &changedIndexShapeshift);
        return changedIndexShapeshift;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Shapeshift, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_User
    {
      get
      {
        int changedIndexUser;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User, (void*) &changedIndexUser);
        return changedIndexUser;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UserHeartCount
    {
      get
      {
        int indexUserHeartCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UserHeartCount, (void*) &indexUserHeartCount);
        return indexUserHeartCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UserHeartCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AllyPermission
    {
      get
      {
        int indexAllyPermission;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_AllyPermission, (void*) &indexAllyPermission);
        return indexAllyPermission;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_AllyPermission, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_QueuedWorkstationCraftAction
    {
      get
      {
        int workstationCraftAction;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_QueuedWorkstationCraftAction, (void*) &workstationCraftAction);
        return workstationCraftAction;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_QueuedWorkstationCraftAction, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RespawnPointOwnerBuffer
    {
      get
      {
        int pointOwnerBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_RespawnPointOwnerBuffer, (void*) &pointOwnerBuffer);
        return pointOwnerBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_RespawnPointOwnerBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UnlockedWaypointElement
    {
      get
      {
        int unlockedWaypointElement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UnlockedWaypointElement, (void*) &unlockedWaypointElement);
        return unlockedWaypointElement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UnlockedWaypointElement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UserMapZoneElement
    {
      get
      {
        int userMapZoneElement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UserMapZoneElement, (void*) &userMapZoneElement);
        return userMapZoneElement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UserMapZoneElement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AchievementOwner_Entity
    {
      get
      {
        int achievementOwnerEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_AchievementOwner_Entity, (void*) &achievementOwnerEntity);
        return achievementOwnerEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_AchievementOwner_Entity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Controller_Controlled
    {
      get
      {
        int controllerControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Controller_Controlled, (void*) &controllerControlled);
        return controllerControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Controller_Controlled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Emoter_IsEmoting
    {
      get
      {
        int indexEmoterIsEmoting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Emoter_IsEmoting, (void*) &indexEmoterIsEmoting);
        return indexEmoterIsEmoting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Emoter_IsEmoting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InputCommandDataProxy_CommandDataEntity
    {
      get
      {
        int commandDataEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_InputCommandDataProxy_CommandDataEntity, (void*) &commandDataEntity);
        return commandDataEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_InputCommandDataProxy_CommandDataEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ProgressionMapper_ProgressionEntity
    {
      get
      {
        int progressionEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_ProgressionMapper_ProgressionEntity, (void*) &progressionEntity);
        return progressionEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_ProgressionMapper_ProgressionEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Shapeshift_IsShapeshifted
    {
      get
      {
        int shapeshiftIsShapeshifted;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Shapeshift_IsShapeshifted, (void*) &shapeshiftIsShapeshifted);
        return shapeshiftIsShapeshifted;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Shapeshift_IsShapeshifted, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_User_CharacterName
    {
      get
      {
        int userCharacterName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_CharacterName, (void*) &userCharacterName);
        return userCharacterName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_CharacterName, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_User_ClanEntity
    {
      get
      {
        int indexUserClanEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_ClanEntity, (void*) &indexUserClanEntity);
        return indexUserClanEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_ClanEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_User_Generation
    {
      get
      {
        int indexUserGeneration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_Generation, (void*) &indexUserGeneration);
        return indexUserGeneration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_Generation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_User_Index
    {
      get
      {
        int changedIndexUserIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_Index, (void*) &changedIndexUserIndex);
        return changedIndexUserIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_Index, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_User_IsAdmin
    {
      get
      {
        int indexUserIsAdmin;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_IsAdmin, (void*) &indexUserIsAdmin);
        return indexUserIsAdmin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_IsAdmin, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_User_IsConnected
    {
      get
      {
        int indexUserIsConnected;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_IsConnected, (void*) &indexUserIsConnected);
        return indexUserIsConnected;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_IsConnected, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_User_LocalCharacter
    {
      get
      {
        int userLocalCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_LocalCharacter, (void*) &userLocalCharacter);
        return userLocalCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_LocalCharacter, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_User_PlatformId
    {
      get
      {
        int indexUserPlatformId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_PlatformId, (void*) &indexUserPlatformId);
        return indexUserPlatformId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_PlatformId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_User_UserContent
    {
      get
      {
        int indexUserUserContent;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_UserContent, (void*) &indexUserUserContent);
        return indexUserUserContent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_User_UserContent, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UserHeartCount_HeartCount
    {
      get
      {
        int heartCountHeartCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UserHeartCount_HeartCount, (void*) &heartCountHeartCount);
        return heartCountHeartCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_FrameChangedIndex_UserHeartCount_HeartCount, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AchievementOwner
    {
      get
      {
        int achievementOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_AchievementOwner, (void*) &achievementOwner);
        return achievementOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_AchievementOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AchievementOwner
    {
      get
      {
        int achievementOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_AchievementOwner, (void*) &achievementOwner);
        return achievementOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_AchievementOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Controller
    {
      get
      {
        int offsetController;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Controller, (void*) &offsetController);
        return offsetController;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Controller, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Controller
    {
      get
      {
        int dataSizeController;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Controller, (void*) &dataSizeController);
        return dataSizeController;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Controller, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Emoter
    {
      get
      {
        int startOffsetEmoter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Emoter, (void*) &startOffsetEmoter);
        return startOffsetEmoter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Emoter, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Emoter
    {
      get
      {
        int componentDataSizeEmoter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Emoter, (void*) &componentDataSizeEmoter);
        return componentDataSizeEmoter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Emoter, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InputCommandDataProxy
    {
      get
      {
        int commandDataProxy;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandDataProxy, (void*) &commandDataProxy);
        return commandDataProxy;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandDataProxy, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InputCommandDataProxy
    {
      get
      {
        int commandDataProxy;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_InputCommandDataProxy, (void*) &commandDataProxy);
        return commandDataProxy;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_InputCommandDataProxy, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ProgressionMapper
    {
      get
      {
        int progressionMapper;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_ProgressionMapper, (void*) &progressionMapper);
        return progressionMapper;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_ProgressionMapper, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ProgressionMapper
    {
      get
      {
        int progressionMapper;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_ProgressionMapper, (void*) &progressionMapper);
        return progressionMapper;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_ProgressionMapper, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Shapeshift
    {
      get
      {
        int offsetShapeshift;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Shapeshift, (void*) &offsetShapeshift);
        return offsetShapeshift;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Shapeshift, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Shapeshift
    {
      get
      {
        int dataSizeShapeshift;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Shapeshift, (void*) &dataSizeShapeshift);
        return dataSizeShapeshift;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Shapeshift, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_User
    {
      get
      {
        int dataStartOffsetUser;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_User, (void*) &dataStartOffsetUser);
        return dataStartOffsetUser;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_User, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_User
    {
      get
      {
        int componentDataSizeUser;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_User, (void*) &componentDataSizeUser);
        return componentDataSizeUser;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_User, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_UserHeartCount
    {
      get
      {
        int offsetUserHeartCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_UserHeartCount, (void*) &offsetUserHeartCount);
        return offsetUserHeartCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataStartOffset_UserHeartCount, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_UserHeartCount
    {
      get
      {
        int sizeUserHeartCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_UserHeartCount, (void*) &sizeUserHeartCount);
        return sizeUserHeartCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_ComponentDataSize_UserHeartCount, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AchievementOwner
    {
      get
      {
        ulong achievementOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_AchievementOwner, (void*) &achievementOwner);
        return achievementOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_AchievementOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Controller
    {
      get
      {
        ulong compBitController;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Controller, (void*) &compBitController);
        return compBitController;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Controller, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Emoter
    {
      get
      {
        ulong compBitEmoter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Emoter, (void*) &compBitEmoter);
        return compBitEmoter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Emoter, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InputCommandDataProxy
    {
      get
      {
        ulong commandDataProxy;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_InputCommandDataProxy, (void*) &commandDataProxy);
        return commandDataProxy;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_InputCommandDataProxy, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ProgressionMapper
    {
      get
      {
        ulong progressionMapper;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_ProgressionMapper, (void*) &progressionMapper);
        return progressionMapper;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_ProgressionMapper, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Shapeshift
    {
      get
      {
        ulong compBitShapeshift;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Shapeshift, (void*) &compBitShapeshift);
        return compBitShapeshift;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Shapeshift, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_User
    {
      get
      {
        ulong compBitUser;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_User, (void*) &compBitUser);
        return compBitUser;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_User, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_UserHeartCount
    {
      get
      {
        ulong bitUserHeartCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_UserHeartCount, (void*) &bitUserHeartCount);
        return bitUserHeartCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_UserHeartCount, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AllyPermission
    {
      get
      {
        ulong bitAllyPermission;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_AllyPermission, (void*) &bitAllyPermission);
        return bitAllyPermission;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_AllyPermission, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_QueuedWorkstationCraftAction
    {
      get
      {
        ulong workstationCraftAction;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_QueuedWorkstationCraftAction, (void*) &workstationCraftAction);
        return workstationCraftAction;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_QueuedWorkstationCraftAction, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_RespawnPointOwnerBuffer
    {
      get
      {
        ulong pointOwnerBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_RespawnPointOwnerBuffer, (void*) &pointOwnerBuffer);
        return pointOwnerBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_RespawnPointOwnerBuffer, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_UnlockedWaypointElement
    {
      get
      {
        ulong unlockedWaypointElement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_UnlockedWaypointElement, (void*) &unlockedWaypointElement);
        return unlockedWaypointElement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_UnlockedWaypointElement, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_UserMapZoneElement
    {
      get
      {
        ulong userMapZoneElement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_UserMapZoneElement, (void*) &userMapZoneElement);
        return userMapZoneElement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfbjghgjgf.NativeFieldInfoPtr_CompBit_UserMapZoneElement, (void*) &value);
      }
    }
  }
}
