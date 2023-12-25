// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_ackifjdcjjd
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_ackifjdcjjd
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanTeam_ClanGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanTeam_Motto;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanTeam_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanTeam_TeamValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ClanTeam_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ClanTeam_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanMemberStatus;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_ClanGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_Motto;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_TeamValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ClanTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ClanTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ClanTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ClanMemberStatus;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_ClanMemberStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_ClanMemberStatus_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public Il2CppSystem.Guid ClanTeam_ClanGuid;
    [FieldOffset(24)]
    public FixedString64 ClanTeam_Motto;
    [FieldOffset(88)]
    public FixedString64 ClanTeam_Name;
    [FieldOffset(152)]
    public int ClanTeam_TeamValue;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1538354, XrefRangeEnd = 1538420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_ClanMemberStatus> get_buffer_ClanMemberStatus)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_ClanMemberStatus;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ackifjdcjjd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_ClanMemberStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1538447, RefRangeEnd = 1538448, XrefRangeStart = 1538420, XrefRangeEnd = 1538447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_ClanMemberStatus> buffer_ClanMemberStatus)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_ClanMemberStatus;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ackifjdcjjd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_ClanMemberStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_ackifjdcjjd()
    {
      Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_ackifjdcjjd));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr);
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_ClanTeam_ClanGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (ClanTeam_ClanGuid));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_ClanTeam_Motto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (ClanTeam_Motto));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_ClanTeam_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (ClanTeam_Name));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_ClanTeam_TeamValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (ClanTeam_TeamValue));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedFields_ClanTeam_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (FrameChangedFields_ClanTeam_Start));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedFields_ClanTeam_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (FrameChangedFields_ClanTeam_Count));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (FrameChangedIndex_ClanTeam));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanMemberStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (FrameChangedIndex_ClanMemberStatus));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_ClanGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (FrameChangedIndex_ClanTeam_ClanGuid));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_Motto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (FrameChangedIndex_ClanTeam_Motto));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (FrameChangedIndex_ClanTeam_Name));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_TeamValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (FrameChangedIndex_ClanTeam_TeamValue));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_ComponentDataStartOffset_ClanTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (ComponentDataStartOffset_ClanTeam));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_ComponentDataSize_ClanTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (ComponentDataSize_ClanTeam));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_CompBit_ClanTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (CompBit_ClanTeam));
      Snapshot_ackifjdcjjd.NativeFieldInfoPtr_CompBit_ClanMemberStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, nameof (CompBit_ClanMemberStatus));
      Snapshot_ackifjdcjjd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_ClanMemberStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, 100664282);
      Snapshot_ackifjdcjjd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_ClanMemberStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, 100664283);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_ackifjdcjjd>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ClanTeam_Start
    {
      get
      {
        int fieldsClanTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedFields_ClanTeam_Start, (void*) &fieldsClanTeamStart);
        return fieldsClanTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedFields_ClanTeam_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ClanTeam_Count
    {
      get
      {
        int fieldsClanTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedFields_ClanTeam_Count, (void*) &fieldsClanTeamCount);
        return fieldsClanTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedFields_ClanTeam_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanTeam
    {
      get
      {
        int changedIndexClanTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam, (void*) &changedIndexClanTeam);
        return changedIndexClanTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanMemberStatus
    {
      get
      {
        int clanMemberStatus;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanMemberStatus, (void*) &clanMemberStatus);
        return clanMemberStatus;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanMemberStatus, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanTeam_ClanGuid
    {
      get
      {
        int clanTeamClanGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_ClanGuid, (void*) &clanTeamClanGuid);
        return clanTeamClanGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_ClanGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanTeam_Motto
    {
      get
      {
        int indexClanTeamMotto;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_Motto, (void*) &indexClanTeamMotto);
        return indexClanTeamMotto;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_Motto, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanTeam_Name
    {
      get
      {
        int indexClanTeamName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_Name, (void*) &indexClanTeamName);
        return indexClanTeamName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_Name, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanTeam_TeamValue
    {
      get
      {
        int clanTeamTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_TeamValue, (void*) &clanTeamTeamValue);
        return clanTeamTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_FrameChangedIndex_ClanTeam_TeamValue, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ClanTeam
    {
      get
      {
        int startOffsetClanTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_ComponentDataStartOffset_ClanTeam, (void*) &startOffsetClanTeam);
        return startOffsetClanTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_ComponentDataStartOffset_ClanTeam, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ClanTeam
    {
      get
      {
        int dataSizeClanTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_ComponentDataSize_ClanTeam, (void*) &dataSizeClanTeam);
        return dataSizeClanTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_ComponentDataSize_ClanTeam, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ClanTeam
    {
      get
      {
        ulong compBitClanTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_CompBit_ClanTeam, (void*) &compBitClanTeam);
        return compBitClanTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_CompBit_ClanTeam, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ClanMemberStatus
    {
      get
      {
        ulong clanMemberStatus;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_CompBit_ClanMemberStatus, (void*) &clanMemberStatus);
        return clanMemberStatus;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackifjdcjjd.NativeFieldInfoPtr_CompBit_ClanMemberStatus, (void*) &value);
      }
    }
  }
}
