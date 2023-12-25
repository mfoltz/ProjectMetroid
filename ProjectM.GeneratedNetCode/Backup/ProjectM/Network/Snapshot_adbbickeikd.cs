// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_adbbickeikd
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
  public struct Snapshot_adbbickeikd
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoom_HasRoof;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoom_IsMissingWalls;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleRoom_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleRoom_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleRoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleRoom_HasRoof;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleRoom_IsMissingWalls;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleRoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleRoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Translation;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public bool CastleRoom_HasRoof;
    [FieldOffset(9)]
    public bool CastleRoom_IsMissingWalls;
    [FieldOffset(10)]
    public float3 Translation_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1538669, XrefRangeEnd = 1538677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_adbbickeikd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1538690, RefRangeEnd = 1538691, XrefRangeStart = 1538677, XrefRangeEnd = 1538690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_adbbickeikd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_adbbickeikd()
    {
      Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_adbbickeikd));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr);
      Snapshot_adbbickeikd.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_CastleRoom_HasRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (CastleRoom_HasRoof));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_CastleRoom_IsMissingWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (CastleRoom_IsMissingWalls));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (Translation_Value));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_CastleRoom_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChangedFields_CastleRoom_Start));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_CastleRoom_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChangedFields_CastleRoom_Count));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_Translation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChangedFields_Translation_Start));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_Translation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChangedFields_Translation_Count));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_CastleRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChangedIndex_CastleRoom));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChangedIndex_Translation));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_CastleRoom_HasRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChangedIndex_CastleRoom_HasRoof));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_CastleRoom_IsMissingWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChangedIndex_CastleRoom_IsMissingWalls));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (FrameChangedIndex_Translation_Value));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleRoom));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataSize_CastleRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (ComponentDataSize_CastleRoom));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataStartOffset_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (ComponentDataStartOffset_Translation));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataSize_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (ComponentDataSize_Translation));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_CompBit_CastleRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (CompBit_CastleRoom));
      Snapshot_adbbickeikd.NativeFieldInfoPtr_CompBit_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, nameof (CompBit_Translation));
      Snapshot_adbbickeikd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, 100664288);
      Snapshot_adbbickeikd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, 100664289);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_adbbickeikd>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleRoom_Start
    {
      get
      {
        int fieldsCastleRoomStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_CastleRoom_Start, (void*) &fieldsCastleRoomStart);
        return fieldsCastleRoomStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_CastleRoom_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleRoom_Count
    {
      get
      {
        int fieldsCastleRoomCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_CastleRoom_Count, (void*) &fieldsCastleRoomCount);
        return fieldsCastleRoomCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_CastleRoom_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Start
    {
      get
      {
        int translationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &translationStart);
        return translationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Count
    {
      get
      {
        int translationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &translationCount);
        return translationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleRoom
    {
      get
      {
        int changedIndexCastleRoom;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_CastleRoom, (void*) &changedIndexCastleRoom);
        return changedIndexCastleRoom;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_CastleRoom, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation
    {
      get
      {
        int indexTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &indexTranslation);
        return indexTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleRoom_HasRoof
    {
      get
      {
        int castleRoomHasRoof;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_CastleRoom_HasRoof, (void*) &castleRoomHasRoof);
        return castleRoomHasRoof;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_CastleRoom_HasRoof, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleRoom_IsMissingWalls
    {
      get
      {
        int roomIsMissingWalls;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_CastleRoom_IsMissingWalls, (void*) &roomIsMissingWalls);
        return roomIsMissingWalls;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_CastleRoom_IsMissingWalls, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation_Value
    {
      get
      {
        int translationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &translationValue);
        return translationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleRoom
    {
      get
      {
        int offsetCastleRoom;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoom, (void*) &offsetCastleRoom);
        return offsetCastleRoom;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoom, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleRoom
    {
      get
      {
        int dataSizeCastleRoom;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataSize_CastleRoom, (void*) &dataSizeCastleRoom);
        return dataSizeCastleRoom;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataSize_CastleRoom, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Translation
    {
      get
      {
        int offsetTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &offsetTranslation);
        return offsetTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Translation
    {
      get
      {
        int dataSizeTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &dataSizeTranslation);
        return dataSizeTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleRoom
    {
      get
      {
        ulong compBitCastleRoom;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_CompBit_CastleRoom, (void*) &compBitCastleRoom);
        return compBitCastleRoom;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_CompBit_CastleRoom, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Translation
    {
      get
      {
        ulong compBitTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_CompBit_Translation, (void*) &compBitTranslation);
        return compBitTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbbickeikd.NativeFieldInfoPtr_CompBit_Translation, (void*) &value);
      }
    }
  }
}
