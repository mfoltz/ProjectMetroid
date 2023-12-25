// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_kdbikhddc
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
  public struct Snapshot_kdbikhddc
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StoredBlood_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_StoredBlood_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StoredBlood_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StoredBlood_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StoredBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StoredBlood_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StoredBlood_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StoredBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StoredBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StoredBlood;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float StoredBlood_BloodQuality;
    [FieldOffset(12)]
    public PrefabGUID StoredBlood_BloodType;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1589909, XrefRangeEnd = 1589948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_kdbikhddc.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1589960, RefRangeEnd = 1589961, XrefRangeStart = 1589948, XrefRangeEnd = 1589960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_kdbikhddc.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_kdbikhddc()
    {
      Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_kdbikhddc));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr);
      Snapshot_kdbikhddc.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_StoredBlood_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (StoredBlood_BloodQuality));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_StoredBlood_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (StoredBlood_BloodType));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedFields_StoredBlood_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (FrameChangedFields_StoredBlood_Start));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedFields_StoredBlood_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (FrameChangedFields_StoredBlood_Count));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedIndex_StoredBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (FrameChangedIndex_StoredBlood));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedIndex_StoredBlood_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (FrameChangedIndex_StoredBlood_BloodQuality));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedIndex_StoredBlood_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (FrameChangedIndex_StoredBlood_BloodType));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_ComponentDataStartOffset_StoredBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (ComponentDataStartOffset_StoredBlood));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_ComponentDataSize_StoredBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (ComponentDataSize_StoredBlood));
      Snapshot_kdbikhddc.NativeFieldInfoPtr_CompBit_StoredBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, nameof (CompBit_StoredBlood));
      Snapshot_kdbikhddc.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, 100664736);
      Snapshot_kdbikhddc.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, 100664737);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_kdbikhddc>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StoredBlood_Start
    {
      get
      {
        int storedBloodStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedFields_StoredBlood_Start, (void*) &storedBloodStart);
        return storedBloodStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedFields_StoredBlood_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StoredBlood_Count
    {
      get
      {
        int storedBloodCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedFields_StoredBlood_Count, (void*) &storedBloodCount);
        return storedBloodCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedFields_StoredBlood_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StoredBlood
    {
      get
      {
        int indexStoredBlood;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedIndex_StoredBlood, (void*) &indexStoredBlood);
        return indexStoredBlood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedIndex_StoredBlood, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StoredBlood_BloodQuality
    {
      get
      {
        int bloodBloodQuality;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedIndex_StoredBlood_BloodQuality, (void*) &bloodBloodQuality);
        return bloodBloodQuality;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedIndex_StoredBlood_BloodQuality, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StoredBlood_BloodType
    {
      get
      {
        int storedBloodBloodType;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedIndex_StoredBlood_BloodType, (void*) &storedBloodBloodType);
        return storedBloodBloodType;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_FrameChangedIndex_StoredBlood_BloodType, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StoredBlood
    {
      get
      {
        int offsetStoredBlood;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_ComponentDataStartOffset_StoredBlood, (void*) &offsetStoredBlood);
        return offsetStoredBlood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_ComponentDataStartOffset_StoredBlood, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StoredBlood
    {
      get
      {
        int dataSizeStoredBlood;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_ComponentDataSize_StoredBlood, (void*) &dataSizeStoredBlood);
        return dataSizeStoredBlood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_ComponentDataSize_StoredBlood, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StoredBlood
    {
      get
      {
        ulong compBitStoredBlood;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_CompBit_StoredBlood, (void*) &compBitStoredBlood);
        return compBitStoredBlood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kdbikhddc.NativeFieldInfoPtr_CompBit_StoredBlood, (void*) &value);
      }
    }
  }
}
