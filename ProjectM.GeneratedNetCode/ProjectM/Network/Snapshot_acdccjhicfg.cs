// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acdccjhicfg
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_acdccjhicfg
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanInviteRequest_Shared_ClanName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanInviteRequest_Shared_ClanNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanInviteRequest_Shared_FromUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanInviteRequest_Shared_FromUserName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanInviteRequest_Shared_ToUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanInviteRequest_Shared_ToUserName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ClanInviteRequest_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ClanInviteRequest_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ClanName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ClanNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_FromUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_FromUserName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ToUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ToUserName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ClanInviteRequest_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ClanInviteRequest_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ClanInviteRequest_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public FixedString64 ClanInviteRequest_Shared_ClanName;
    [FieldOffset(72)]
    public NetworkId ClanInviteRequest_Shared_ClanNetworkId;
    [FieldOffset(80)]
    public int ClanInviteRequest_Shared_FromUserIndex;
    [FieldOffset(84)]
    public FixedString64 ClanInviteRequest_Shared_FromUserName;
    [FieldOffset(148)]
    public int ClanInviteRequest_Shared_ToUserIndex;
    [FieldOffset(152)]
    public FixedString64 ClanInviteRequest_Shared_ToUserName;
    [FieldOffset(216)]
    public float LifeTime_Duration;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1525474, XrefRangeEnd = 1525525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acdccjhicfg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1525550, RefRangeEnd = 1525551, XrefRangeStart = 1525525, XrefRangeEnd = 1525550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acdccjhicfg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acdccjhicfg()
    {
      Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acdccjhicfg));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr);
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_ClanInviteRequest_Shared_ClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (ClanInviteRequest_Shared_ClanName));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_ClanInviteRequest_Shared_ClanNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (ClanInviteRequest_Shared_ClanNetworkId));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_ClanInviteRequest_Shared_FromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (ClanInviteRequest_Shared_FromUserIndex));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_ClanInviteRequest_Shared_FromUserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (ClanInviteRequest_Shared_FromUserName));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_ClanInviteRequest_Shared_ToUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (ClanInviteRequest_Shared_ToUserIndex));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_ClanInviteRequest_Shared_ToUserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (ClanInviteRequest_Shared_ToUserName));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_ClanInviteRequest_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedFields_ClanInviteRequest_Shared_Start));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_ClanInviteRequest_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedFields_ClanInviteRequest_Shared_Count));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedIndex_ClanInviteRequest_Shared));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedIndex_ClanInviteRequest_Shared_ClanName));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ClanNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedIndex_ClanInviteRequest_Shared_ClanNetworkId));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_FromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedIndex_ClanInviteRequest_Shared_FromUserIndex));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_FromUserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedIndex_ClanInviteRequest_Shared_FromUserName));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ToUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedIndex_ClanInviteRequest_Shared_ToUserIndex));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ToUserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedIndex_ClanInviteRequest_Shared_ToUserName));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataStartOffset_ClanInviteRequest_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (ComponentDataStartOffset_ClanInviteRequest_Shared));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataSize_ClanInviteRequest_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (ComponentDataSize_ClanInviteRequest_Shared));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_CompBit_ClanInviteRequest_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (CompBit_ClanInviteRequest_Shared));
      Snapshot_acdccjhicfg.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_acdccjhicfg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, 100664154);
      Snapshot_acdccjhicfg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, 100664155);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acdccjhicfg>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ClanInviteRequest_Shared_Start
    {
      get
      {
        int requestSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_ClanInviteRequest_Shared_Start, (void*) &requestSharedStart);
        return requestSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_ClanInviteRequest_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ClanInviteRequest_Shared_Count
    {
      get
      {
        int requestSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_ClanInviteRequest_Shared_Count, (void*) &requestSharedCount);
        return requestSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_ClanInviteRequest_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanInviteRequest_Shared
    {
      get
      {
        int inviteRequestShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared, (void*) &inviteRequestShared);
        return inviteRequestShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanInviteRequest_Shared_ClanName
    {
      get
      {
        int requestSharedClanName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ClanName, (void*) &requestSharedClanName);
        return requestSharedClanName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ClanName, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanInviteRequest_Shared_ClanNetworkId
    {
      get
      {
        int sharedClanNetworkId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ClanNetworkId, (void*) &sharedClanNetworkId);
        return sharedClanNetworkId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ClanNetworkId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanInviteRequest_Shared_FromUserIndex
    {
      get
      {
        int sharedFromUserIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_FromUserIndex, (void*) &sharedFromUserIndex);
        return sharedFromUserIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_FromUserIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanInviteRequest_Shared_FromUserName
    {
      get
      {
        int sharedFromUserName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_FromUserName, (void*) &sharedFromUserName);
        return sharedFromUserName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_FromUserName, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanInviteRequest_Shared_ToUserIndex
    {
      get
      {
        int sharedToUserIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ToUserIndex, (void*) &sharedToUserIndex);
        return sharedToUserIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ToUserIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ClanInviteRequest_Shared_ToUserName
    {
      get
      {
        int sharedToUserName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ToUserName, (void*) &sharedToUserName);
        return sharedToUserName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_ClanInviteRequest_Shared_ToUserName, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ClanInviteRequest_Shared
    {
      get
      {
        int inviteRequestShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataStartOffset_ClanInviteRequest_Shared, (void*) &inviteRequestShared);
        return inviteRequestShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataStartOffset_ClanInviteRequest_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ClanInviteRequest_Shared
    {
      get
      {
        int inviteRequestShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataSize_ClanInviteRequest_Shared, (void*) &inviteRequestShared);
        return inviteRequestShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataSize_ClanInviteRequest_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ClanInviteRequest_Shared
    {
      get
      {
        ulong inviteRequestShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_CompBit_ClanInviteRequest_Shared, (void*) &inviteRequestShared);
        return inviteRequestShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_CompBit_ClanInviteRequest_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdccjhicfg.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }
  }
}
