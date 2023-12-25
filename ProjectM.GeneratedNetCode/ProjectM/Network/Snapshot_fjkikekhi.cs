﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_fjkikekhi
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
  public struct Snapshot_fjkikekhi
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconPosition_TilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconTargetEntity_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconTargetEntity_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnLocationSelector_IsLocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpawnLocationSelector_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpawnLocationSelector_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnLocationSelector;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnLocationSelector_IsLocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpawnLocationSelector;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpawnLocationSelector;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_MapIconPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_MapIconTargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpawnLocationSelector;
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
    public bool SpawnLocationSelector_IsLocked;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1582941, XrefRangeEnd = 1582959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_fjkikekhi.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1582981, RefRangeEnd = 1582982, XrefRangeStart = 1582959, XrefRangeEnd = 1582981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_fjkikekhi.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_fjkikekhi()
    {
      Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_fjkikekhi));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr);
      Snapshot_fjkikekhi.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_MapIconPosition_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (MapIconPosition_TilePosition));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_MapIconTargetEntity_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (MapIconTargetEntity_TargetEntity));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_MapIconTargetEntity_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (MapIconTargetEntity_TargetNetworkId));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_SpawnLocationSelector_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (SpawnLocationSelector_IsLocked));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedFields_MapIconPosition_Start));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedFields_MapIconPosition_Count));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedFields_MapIconTargetEntity_Start));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedFields_MapIconTargetEntity_Count));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_SpawnLocationSelector_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedFields_SpawnLocationSelector_Start));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_SpawnLocationSelector_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedFields_SpawnLocationSelector_Count));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedIndex_MapIconPosition));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedIndex_MapIconTargetEntity));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_SpawnLocationSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedIndex_SpawnLocationSelector));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedIndex_MapIconPosition_TilePosition));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedIndex_MapIconTargetEntity_TargetEntity));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedIndex_MapIconTargetEntity_TargetNetworkId));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_SpawnLocationSelector_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (FrameChangedIndex_SpawnLocationSelector_IsLocked));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (ComponentDataStartOffset_MapIconPosition));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataSize_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (ComponentDataSize_MapIconPosition));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (ComponentDataStartOffset_MapIconTargetEntity));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (ComponentDataSize_MapIconTargetEntity));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnLocationSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (ComponentDataStartOffset_SpawnLocationSelector));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataSize_SpawnLocationSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (ComponentDataSize_SpawnLocationSelector));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_CompBit_MapIconPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (CompBit_MapIconPosition));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_CompBit_MapIconTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (CompBit_MapIconTargetEntity));
      Snapshot_fjkikekhi.NativeFieldInfoPtr_CompBit_SpawnLocationSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, nameof (CompBit_SpawnLocationSelector));
      Snapshot_fjkikekhi.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, 100664664);
      Snapshot_fjkikekhi.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, 100664665);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_fjkikekhi>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconPosition_Start
    {
      get
      {
        int iconPositionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start, (void*) &iconPositionStart);
        return iconPositionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconPosition_Count
    {
      get
      {
        int iconPositionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count, (void*) &iconPositionCount);
        return iconPositionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconPosition_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconTargetEntity_Start
    {
      get
      {
        int targetEntityStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start, (void*) &targetEntityStart);
        return targetEntityStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MapIconTargetEntity_Count
    {
      get
      {
        int targetEntityCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count, (void*) &targetEntityCount);
        return targetEntityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_MapIconTargetEntity_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpawnLocationSelector_Start
    {
      get
      {
        int locationSelectorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_SpawnLocationSelector_Start, (void*) &locationSelectorStart);
        return locationSelectorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_SpawnLocationSelector_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpawnLocationSelector_Count
    {
      get
      {
        int locationSelectorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_SpawnLocationSelector_Count, (void*) &locationSelectorCount);
        return locationSelectorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedFields_SpawnLocationSelector_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconPosition
    {
      get
      {
        int indexMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition, (void*) &indexMapIconPosition);
        return indexMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconTargetEntity
    {
      get
      {
        int iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnLocationSelector
    {
      get
      {
        int locationSelector;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_SpawnLocationSelector, (void*) &locationSelector);
        return locationSelector;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_SpawnLocationSelector, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconPosition_TilePosition
    {
      get
      {
        int positionTilePosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition, (void*) &positionTilePosition);
        return positionTilePosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconPosition_TilePosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconTargetEntity_TargetEntity
    {
      get
      {
        int entityTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity, (void*) &entityTargetEntity);
        return entityTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MapIconTargetEntity_TargetNetworkId
    {
      get
      {
        int entityTargetNetworkId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId, (void*) &entityTargetNetworkId);
        return entityTargetNetworkId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_MapIconTargetEntity_TargetNetworkId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnLocationSelector_IsLocked
    {
      get
      {
        int selectorIsLocked;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_SpawnLocationSelector_IsLocked, (void*) &selectorIsLocked);
        return selectorIsLocked;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_FrameChangedIndex_SpawnLocationSelector_IsLocked, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_MapIconPosition
    {
      get
      {
        int offsetMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition, (void*) &offsetMapIconPosition);
        return offsetMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_MapIconPosition
    {
      get
      {
        int sizeMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataSize_MapIconPosition, (void*) &sizeMapIconPosition);
        return sizeMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataSize_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_MapIconTargetEntity
    {
      get
      {
        int iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataStartOffset_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_MapIconTargetEntity
    {
      get
      {
        int iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataSize_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpawnLocationSelector
    {
      get
      {
        int locationSelector;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnLocationSelector, (void*) &locationSelector);
        return locationSelector;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnLocationSelector, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpawnLocationSelector
    {
      get
      {
        int locationSelector;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataSize_SpawnLocationSelector, (void*) &locationSelector);
        return locationSelector;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_ComponentDataSize_SpawnLocationSelector, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_MapIconPosition
    {
      get
      {
        ulong bitMapIconPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_CompBit_MapIconPosition, (void*) &bitMapIconPosition);
        return bitMapIconPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_CompBit_MapIconPosition, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_MapIconTargetEntity
    {
      get
      {
        ulong iconTargetEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_CompBit_MapIconTargetEntity, (void*) &iconTargetEntity);
        return iconTargetEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_CompBit_MapIconTargetEntity, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpawnLocationSelector
    {
      get
      {
        ulong locationSelector;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_CompBit_SpawnLocationSelector, (void*) &locationSelector);
        return locationSelector;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fjkikekhi.NativeFieldInfoPtr_CompBit_SpawnLocationSelector, (void*) &value);
      }
    }
  }
}
