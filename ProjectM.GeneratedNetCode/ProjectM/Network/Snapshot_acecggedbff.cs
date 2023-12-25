// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acecggedbff
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
  public struct Snapshot_acecggedbff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconPosition_TilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconTargetEntity_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconTargetEntity_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaypointMapIcon_IsLocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaypointMapIcon_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_WaypointMapIcon_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_WaypointMapIcon_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon_IsLocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_WaypointMapIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_WaypointMapIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_WaypointMapIcon;
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
    public int Team_FactionIndex;
    [FieldOffset(36)]
    public int Team_Value;
    [FieldOffset(40)]
    public bool WaypointMapIcon_IsLocked;
    [FieldOffset(41)]
    public NetworkId WaypointMapIcon_TargetNetworkId;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1528075, XrefRangeEnd = 1528129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acecggedbff.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1528160, RefRangeEnd = 1528161, XrefRangeStart = 1528129, XrefRangeEnd = 1528160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acecggedbff.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acecggedbff()
    {
      Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acecggedbff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr);
      Snapshot_acecggedbff.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acecggedbff.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acecggedbff.NativeFieldInfoPtr_MapIconPosition_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (MapIconPosition_TilePosition));
      Snapshot_acecggedbff.NativeFieldInfoPtr_MapIconTargetEntity_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (MapIconTargetEntity_TargetEntity));
      Snapshot_acecggedbff.NativeFieldInfoPtr_MapIconTargetEntity_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (MapIconTargetEntity_TargetNetworkId));
      Snapshot_acecggedbff.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_acecggedbff.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (Team_Value));
      Snapshot_acecggedbff.NativeFieldInfoPtr_WaypointMapIcon_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (WaypointMapIcon_IsLocked));
      Snapshot_acecggedbff.NativeFieldInfoPtr_WaypointMapIcon_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (WaypointMapIcon_TargetNetworkId));
      Snapshot_acecggedbff.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedFields_MapIconPosition_Start));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedFields_MapIconPosition_Count));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedFields_MapIconTargetEntity_Start));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedFields_MapIconTargetEntity_Count));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_WaypointMapIcon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedFields_WaypointMapIcon_Start));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_WaypointMapIcon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedFields_WaypointMapIcon_Count));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_MapIconPosition));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_MapIconTargetEntity));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_WaypointMapIcon));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_MapIconPosition_TilePosition));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_MapIconTargetEntity_TargetEntity));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_MapIconTargetEntity_TargetNetworkId));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_WaypointMapIcon_IsLocked));
      Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (FrameChangedIndex_WaypointMapIcon_TargetNetworkId));
      Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (ComponentDataStartOffset_MapIconPosition));
      Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (ComponentDataSize_MapIconPosition));
      Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (ComponentDataStartOffset_MapIconTargetEntity));
      Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (ComponentDataSize_MapIconTargetEntity));
      Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_WaypointMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (ComponentDataStartOffset_WaypointMapIcon));
      Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_WaypointMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (ComponentDataSize_WaypointMapIcon));
      Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (CompBit_MapIconPosition));
      Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (CompBit_MapIconTargetEntity));
      Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_WaypointMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, nameof (CompBit_WaypointMapIcon));
      Snapshot_acecggedbff.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, 100664174);
      Snapshot_acecggedbff.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, 100664175);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acecggedbff>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconPosition_Start
    {
      get
      {
        int iconPositionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start, (void*) &iconPositionStart);
        return iconPositionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconPosition_Count
    {
      get
      {
        int iconPositionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count, (void*) &iconPositionCount);
        return iconPositionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconTargetEntity_Start
    {
      get
      {
        int targetEntityStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start, (void*) &targetEntityStart);
        return targetEntityStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconTargetEntity_Count
    {
      get
      {
        int targetEntityCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count, (void*) &targetEntityCount);
        return targetEntityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_WaypointMapIcon_Start
    {
      get
      {
        int waypointMapIconStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_WaypointMapIcon_Start, (void*) &waypointMapIconStart);
        return waypointMapIconStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_WaypointMapIcon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_WaypointMapIcon_Count
    {
      get
      {
        int waypointMapIconCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_WaypointMapIcon_Count, (void*) &waypointMapIconCount);
        return waypointMapIconCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedFields_WaypointMapIcon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconPosition
    {
      get
      {
        int indexMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition, (void*) &indexMapIconPosition);
        return indexMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconTargetEntity
    {
      get
      {
        int iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_WaypointMapIcon
    {
      get
      {
        int indexWaypointMapIcon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon, (void*) &indexWaypointMapIcon);
        return indexWaypointMapIcon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconPosition_TilePosition
    {
      get
      {
        int positionTilePosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition, (void*) &positionTilePosition);
        return positionTilePosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconTargetEntity_TargetEntity
    {
      get
      {
        int entityTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity, (void*) &entityTargetEntity);
        return entityTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconTargetEntity_TargetNetworkId
    {
      get
      {
        int entityTargetNetworkId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId, (void*) &entityTargetNetworkId);
        return entityTargetNetworkId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_WaypointMapIcon_IsLocked
    {
      get
      {
        int waypointMapIconIsLocked;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon_IsLocked, (void*) &waypointMapIconIsLocked);
        return waypointMapIconIsLocked;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon_IsLocked, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_WaypointMapIcon_TargetNetworkId
    {
      get
      {
        int iconTargetNetworkId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon_TargetNetworkId, (void*) &iconTargetNetworkId);
        return iconTargetNetworkId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_FrameChangedIndex_WaypointMapIcon_TargetNetworkId, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_MapIconPosition
    {
      get
      {
        int offsetMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition, (void*) &offsetMapIconPosition);
        return offsetMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_MapIconPosition
    {
      get
      {
        int sizeMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_MapIconPosition, (void*) &sizeMapIconPosition);
        return sizeMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_MapIconTargetEntity
    {
      get
      {
        int iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_MapIconTargetEntity
    {
      get
      {
        int iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_WaypointMapIcon
    {
      get
      {
        int offsetWaypointMapIcon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_WaypointMapIcon, (void*) &offsetWaypointMapIcon);
        return offsetWaypointMapIcon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataStartOffset_WaypointMapIcon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_WaypointMapIcon
    {
      get
      {
        int sizeWaypointMapIcon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_WaypointMapIcon, (void*) &sizeWaypointMapIcon);
        return sizeWaypointMapIcon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_ComponentDataSize_WaypointMapIcon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_MapIconPosition
    {
      get
      {
        ulong bitMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_MapIconPosition, (void*) &bitMapIconPosition);
        return bitMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_MapIconTargetEntity
    {
      get
      {
        ulong iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_WaypointMapIcon
    {
      get
      {
        ulong bitWaypointMapIcon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_WaypointMapIcon, (void*) &bitWaypointMapIcon);
        return bitWaypointMapIcon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acecggedbff.NativeFieldInfoPtr_CompBit_WaypointMapIcon, (void*) &value);
      }
    }
  }
}
