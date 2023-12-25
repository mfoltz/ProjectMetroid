// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_dihkeehk
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_dihkeehk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleTerritoryDecay;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleTerritoryOccupant;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleTerritoryDecay;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleTerritoryOccupant;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleTerritoryDecay_byref_BufferFromEntity_1_Snapshot_CastleTerritoryOccupant_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleTerritoryDecay_DynamicBuffer_1_Snapshot_CastleTerritoryOccupant_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1579177, XrefRangeEnd = 1579252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_CastleTerritoryDecay> get_buffer_CastleTerritoryDecay,
      ref BufferFromEntity<Snapshot_CastleTerritoryOccupant> get_buffer_CastleTerritoryOccupant)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleTerritoryDecay;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_CastleTerritoryOccupant;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_dihkeehk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleTerritoryDecay_byref_BufferFromEntity_1_Snapshot_CastleTerritoryOccupant_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1579275, RefRangeEnd = 1579276, XrefRangeStart = 1579252, XrefRangeEnd = 1579275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_CastleTerritoryDecay> buffer_CastleTerritoryDecay,
      DynamicBuffer<Snapshot_CastleTerritoryOccupant> buffer_CastleTerritoryOccupant)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleTerritoryDecay;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_CastleTerritoryOccupant;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_dihkeehk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleTerritoryDecay_DynamicBuffer_1_Snapshot_CastleTerritoryOccupant_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_dihkeehk()
    {
      Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_dihkeehk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr);
      Snapshot_dihkeehk.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_dihkeehk.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_dihkeehk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChangedIndex_CastleTerritoryDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, nameof (FrameChangedIndex_CastleTerritoryDecay));
      Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChangedIndex_CastleTerritoryOccupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, nameof (FrameChangedIndex_CastleTerritoryOccupant));
      Snapshot_dihkeehk.NativeFieldInfoPtr_CompBit_CastleTerritoryDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, nameof (CompBit_CastleTerritoryDecay));
      Snapshot_dihkeehk.NativeFieldInfoPtr_CompBit_CastleTerritoryOccupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, nameof (CompBit_CastleTerritoryOccupant));
      Snapshot_dihkeehk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_CastleTerritoryDecay_byref_BufferFromEntity_1_Snapshot_CastleTerritoryOccupant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, 100664626);
      Snapshot_dihkeehk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_CastleTerritoryDecay_DynamicBuffer_1_Snapshot_CastleTerritoryOccupant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, 100664627);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_dihkeehk>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dihkeehk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dihkeehk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleTerritoryDecay
    {
      get
      {
        int castleTerritoryDecay;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChangedIndex_CastleTerritoryDecay, (void*) &castleTerritoryDecay);
        return castleTerritoryDecay;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChangedIndex_CastleTerritoryDecay, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleTerritoryOccupant
    {
      get
      {
        int territoryOccupant;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChangedIndex_CastleTerritoryOccupant, (void*) &territoryOccupant);
        return territoryOccupant;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dihkeehk.NativeFieldInfoPtr_FrameChangedIndex_CastleTerritoryOccupant, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleTerritoryDecay
    {
      get
      {
        ulong castleTerritoryDecay;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dihkeehk.NativeFieldInfoPtr_CompBit_CastleTerritoryDecay, (void*) &castleTerritoryDecay);
        return castleTerritoryDecay;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dihkeehk.NativeFieldInfoPtr_CompBit_CastleTerritoryDecay, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleTerritoryOccupant
    {
      get
      {
        ulong territoryOccupant;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dihkeehk.NativeFieldInfoPtr_CompBit_CastleTerritoryOccupant, (void*) &territoryOccupant);
        return territoryOccupant;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dihkeehk.NativeFieldInfoPtr_CompBit_CastleTerritoryOccupant, (void*) &value);
      }
    }
  }
}
