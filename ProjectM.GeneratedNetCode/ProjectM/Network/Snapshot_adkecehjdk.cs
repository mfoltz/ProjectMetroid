﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_adkecehjdk
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_adkecehjdk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconPosition_TilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconTargetEntity_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconTargetEntity_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerMapIcon_UserName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_PlayerMapIcon_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_PlayerMapIcon_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlayerMapIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlayerMapIcon_UserName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_PlayerMapIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_PlayerMapIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_PlayerMapIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public int2 MapIconPosition_TilePosition;
    [FieldOffset(16)]
    public NetworkId MapIconTargetEntity_TargetEntity;
    [FieldOffset(24)]
    public NetworkId MapIconTargetEntity_TargetNetworkId;
    [FieldOffset(32)]
    public FixedString64 PlayerMapIcon_UserName;
    [FieldOffset(96)]
    public int Team_FactionIndex;
    [FieldOffset(100)]
    public int Team_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1542078, XrefRangeEnd = 1542129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_adkecehjdk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1542157, RefRangeEnd = 1542158, XrefRangeStart = 1542129, XrefRangeEnd = 1542157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_adkecehjdk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_adkecehjdk()
    {
      Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_adkecehjdk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr);
      Snapshot_adkecehjdk.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_MapIconPosition_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (MapIconPosition_TilePosition));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_MapIconTargetEntity_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (MapIconTargetEntity_TargetEntity));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_MapIconTargetEntity_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (MapIconTargetEntity_TargetNetworkId));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_PlayerMapIcon_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (PlayerMapIcon_UserName));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (Team_Value));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedFields_MapIconPosition_Start));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedFields_MapIconPosition_Count));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedFields_MapIconTargetEntity_Start));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedFields_MapIconTargetEntity_Count));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_PlayerMapIcon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedFields_PlayerMapIcon_Start));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_PlayerMapIcon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedFields_PlayerMapIcon_Count));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedIndex_MapIconPosition));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedIndex_MapIconTargetEntity));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_PlayerMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedIndex_PlayerMapIcon));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedIndex_MapIconPosition_TilePosition));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedIndex_MapIconTargetEntity_TargetEntity));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedIndex_MapIconTargetEntity_TargetNetworkId));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_PlayerMapIcon_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedIndex_PlayerMapIcon_UserName));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (ComponentDataStartOffset_MapIconPosition));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (ComponentDataSize_MapIconPosition));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (ComponentDataStartOffset_MapIconTargetEntity));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (ComponentDataSize_MapIconTargetEntity));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_PlayerMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (ComponentDataStartOffset_PlayerMapIcon));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_PlayerMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (ComponentDataSize_PlayerMapIcon));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (CompBit_MapIconPosition));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (CompBit_MapIconTargetEntity));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_PlayerMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (CompBit_PlayerMapIcon));
      Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_adkecehjdk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, 100664326);
      Snapshot_adkecehjdk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, 100664327);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_adkecehjdk>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconPosition_Start
    {
      get
      {
        int iconPositionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start, (void*) &iconPositionStart);
        return iconPositionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconPosition_Count
    {
      get
      {
        int iconPositionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count, (void*) &iconPositionCount);
        return iconPositionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconTargetEntity_Start
    {
      get
      {
        int targetEntityStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start, (void*) &targetEntityStart);
        return targetEntityStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconTargetEntity_Count
    {
      get
      {
        int targetEntityCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count, (void*) &targetEntityCount);
        return targetEntityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlayerMapIcon_Start
    {
      get
      {
        int playerMapIconStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_PlayerMapIcon_Start, (void*) &playerMapIconStart);
        return playerMapIconStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_PlayerMapIcon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlayerMapIcon_Count
    {
      get
      {
        int playerMapIconCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_PlayerMapIcon_Count, (void*) &playerMapIconCount);
        return playerMapIconCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_PlayerMapIcon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconPosition
    {
      get
      {
        int indexMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition, (void*) &indexMapIconPosition);
        return indexMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconTargetEntity
    {
      get
      {
        int iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlayerMapIcon
    {
      get
      {
        int indexPlayerMapIcon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_PlayerMapIcon, (void*) &indexPlayerMapIcon);
        return indexPlayerMapIcon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_PlayerMapIcon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconPosition_TilePosition
    {
      get
      {
        int positionTilePosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition, (void*) &positionTilePosition);
        return positionTilePosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconTargetEntity_TargetEntity
    {
      get
      {
        int entityTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity, (void*) &entityTargetEntity);
        return entityTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconTargetEntity_TargetNetworkId
    {
      get
      {
        int entityTargetNetworkId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId, (void*) &entityTargetNetworkId);
        return entityTargetNetworkId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlayerMapIcon_UserName
    {
      get
      {
        int playerMapIconUserName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_PlayerMapIcon_UserName, (void*) &playerMapIconUserName);
        return playerMapIconUserName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_PlayerMapIcon_UserName, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_MapIconPosition
    {
      get
      {
        int offsetMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition, (void*) &offsetMapIconPosition);
        return offsetMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_MapIconPosition
    {
      get
      {
        int sizeMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_MapIconPosition, (void*) &sizeMapIconPosition);
        return sizeMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_MapIconTargetEntity
    {
      get
      {
        int iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_MapIconTargetEntity
    {
      get
      {
        int iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_PlayerMapIcon
    {
      get
      {
        int offsetPlayerMapIcon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_PlayerMapIcon, (void*) &offsetPlayerMapIcon);
        return offsetPlayerMapIcon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_PlayerMapIcon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_PlayerMapIcon
    {
      get
      {
        int sizePlayerMapIcon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_PlayerMapIcon, (void*) &sizePlayerMapIcon);
        return sizePlayerMapIcon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_PlayerMapIcon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_MapIconPosition
    {
      get
      {
        ulong bitMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_MapIconPosition, (void*) &bitMapIconPosition);
        return bitMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_MapIconTargetEntity
    {
      get
      {
        ulong iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_PlayerMapIcon
    {
      get
      {
        ulong bitPlayerMapIcon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_PlayerMapIcon, (void*) &bitPlayerMapIcon);
        return bitPlayerMapIcon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_PlayerMapIcon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adkecehjdk.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }
  }
}
