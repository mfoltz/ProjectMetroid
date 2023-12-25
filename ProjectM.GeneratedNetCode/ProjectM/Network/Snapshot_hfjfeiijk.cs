// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_hfjfeiijk
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_hfjfeiijk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycle_CastlePvPEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycle_Cloudiness;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycle_DayDurationInSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycle_NextBloodMoonDay;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycle_PlayerPvPEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycle_ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DayNightCycle_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DayNightCycle_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_CastlePvPEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_Cloudiness;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_DayDurationInSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_NextBloodMoonDay;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_PlayerPvPEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DayNightCycle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DayNightCycle;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DayNightCycle;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public bool DayNightCycle_CastlePvPEnabled;
    [FieldOffset(9)]
    public float DayNightCycle_Cloudiness;
    [FieldOffset(13)]
    public float DayNightCycle_DayDurationInSeconds;
    [FieldOffset(17)]
    public int DayNightCycle_NextBloodMoonDay;
    [FieldOffset(21)]
    public bool DayNightCycle_PlayerPvPEnabled;
    [FieldOffset(22)]
    public double DayNightCycle_ServerTime;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1586465, XrefRangeEnd = 1586538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_hfjfeiijk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1586558, RefRangeEnd = 1586559, XrefRangeStart = 1586538, XrefRangeEnd = 1586558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_hfjfeiijk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_hfjfeiijk()
    {
      Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_hfjfeiijk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr);
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_DayNightCycle_CastlePvPEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (DayNightCycle_CastlePvPEnabled));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_DayNightCycle_Cloudiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (DayNightCycle_Cloudiness));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_DayNightCycle_DayDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (DayNightCycle_DayDurationInSeconds));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_DayNightCycle_NextBloodMoonDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (DayNightCycle_NextBloodMoonDay));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_DayNightCycle_PlayerPvPEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (DayNightCycle_PlayerPvPEnabled));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_DayNightCycle_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (DayNightCycle_ServerTime));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedFields_DayNightCycle_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChangedFields_DayNightCycle_Start));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedFields_DayNightCycle_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChangedFields_DayNightCycle_Count));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChangedIndex_DayNightCycle));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_CastlePvPEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChangedIndex_DayNightCycle_CastlePvPEnabled));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_Cloudiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChangedIndex_DayNightCycle_Cloudiness));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_DayDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChangedIndex_DayNightCycle_DayDurationInSeconds));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_NextBloodMoonDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChangedIndex_DayNightCycle_NextBloodMoonDay));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_PlayerPvPEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChangedIndex_DayNightCycle_PlayerPvPEnabled));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (FrameChangedIndex_DayNightCycle_ServerTime));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_ComponentDataStartOffset_DayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (ComponentDataStartOffset_DayNightCycle));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_ComponentDataSize_DayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (ComponentDataSize_DayNightCycle));
      Snapshot_hfjfeiijk.NativeFieldInfoPtr_CompBit_DayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, nameof (CompBit_DayNightCycle));
      Snapshot_hfjfeiijk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, 100664690);
      Snapshot_hfjfeiijk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, 100664691);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_hfjfeiijk>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DayNightCycle_Start
    {
      get
      {
        int dayNightCycleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedFields_DayNightCycle_Start, (void*) &dayNightCycleStart);
        return dayNightCycleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedFields_DayNightCycle_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DayNightCycle_Count
    {
      get
      {
        int dayNightCycleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedFields_DayNightCycle_Count, (void*) &dayNightCycleCount);
        return dayNightCycleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedFields_DayNightCycle_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DayNightCycle
    {
      get
      {
        int indexDayNightCycle;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle, (void*) &indexDayNightCycle);
        return indexDayNightCycle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DayNightCycle_CastlePvPEnabled
    {
      get
      {
        int castlePvPenabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_CastlePvPEnabled, (void*) &castlePvPenabled);
        return castlePvPenabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_CastlePvPEnabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DayNightCycle_Cloudiness
    {
      get
      {
        int nightCycleCloudiness;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_Cloudiness, (void*) &nightCycleCloudiness);
        return nightCycleCloudiness;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_Cloudiness, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DayNightCycle_DayDurationInSeconds
    {
      get
      {
        int durationInSeconds;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_DayDurationInSeconds, (void*) &durationInSeconds);
        return durationInSeconds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_DayDurationInSeconds, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DayNightCycle_NextBloodMoonDay
    {
      get
      {
        int nextBloodMoonDay;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_NextBloodMoonDay, (void*) &nextBloodMoonDay);
        return nextBloodMoonDay;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_NextBloodMoonDay, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DayNightCycle_PlayerPvPEnabled
    {
      get
      {
        int playerPvPenabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_PlayerPvPEnabled, (void*) &playerPvPenabled);
        return playerPvPenabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_PlayerPvPEnabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DayNightCycle_ServerTime
    {
      get
      {
        int nightCycleServerTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_ServerTime, (void*) &nightCycleServerTime);
        return nightCycleServerTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_FrameChangedIndex_DayNightCycle_ServerTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DayNightCycle
    {
      get
      {
        int offsetDayNightCycle;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_ComponentDataStartOffset_DayNightCycle, (void*) &offsetDayNightCycle);
        return offsetDayNightCycle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_ComponentDataStartOffset_DayNightCycle, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DayNightCycle
    {
      get
      {
        int sizeDayNightCycle;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_ComponentDataSize_DayNightCycle, (void*) &sizeDayNightCycle);
        return sizeDayNightCycle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_ComponentDataSize_DayNightCycle, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DayNightCycle
    {
      get
      {
        ulong bitDayNightCycle;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_CompBit_DayNightCycle, (void*) &bitDayNightCycle);
        return bitDayNightCycle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_hfjfeiijk.NativeFieldInfoPtr_CompBit_DayNightCycle, (void*) &value);
      }
    }
  }
}
