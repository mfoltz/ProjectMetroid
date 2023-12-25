// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acbicfeedbb
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_acbicfeedbb
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoofOrnaments_EastOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoofOrnaments_NorthOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoofOrnaments_SouthOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoofOrnaments_WestOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleRoofOrnaments_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleRoofOrnaments_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_EastOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_NorthOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_SouthOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_WestOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoofOrnaments;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleRoofOrnaments;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleRoofOrnaments;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public NetworkId CastleRoofOrnaments_EastOrnament;
    [FieldOffset(16)]
    public NetworkId CastleRoofOrnaments_NorthOrnament;
    [FieldOffset(24)]
    public NetworkId CastleRoofOrnaments_SouthOrnament;
    [FieldOffset(32)]
    public NetworkId CastleRoofOrnaments_WestOrnament;
    [FieldOffset(40)]
    public float StaticTransformCompatible_NonStaticTransform_Height;
    [FieldOffset(44)]
    public float2 StaticTransformCompatible_NonStaticTransform_Pos;
    [FieldOffset(52)]
    public TileRotation StaticTransformCompatible_NonStaticTransform_Rotation;
    [FieldOffset(53)]
    public StaticTransformIndex StaticTransformCompatible_StaticTransform;
    [FieldOffset(65)]
    public bool StaticTransformCompatible_UseStaticTransform;
    [FieldOffset(66)]
    public ProjectM.TileType TileModel_DisabledTileTypes;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1523368, XrefRangeEnd = 1523411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acbicfeedbb.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1523459, RefRangeEnd = 1523460, XrefRangeStart = 1523411, XrefRangeEnd = 1523459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acbicfeedbb.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acbicfeedbb()
    {
      Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acbicfeedbb));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr);
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_CastleRoofOrnaments_EastOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (CastleRoofOrnaments_EastOrnament));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_CastleRoofOrnaments_NorthOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (CastleRoofOrnaments_NorthOrnament));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_CastleRoofOrnaments_SouthOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (CastleRoofOrnaments_SouthOrnament));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_CastleRoofOrnaments_WestOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (CastleRoofOrnaments_WestOrnament));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (StaticTransformCompatible_StaticTransform));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (StaticTransformCompatible_UseStaticTransform));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_CastleRoofOrnaments_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedFields_CastleRoofOrnaments_Start));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_CastleRoofOrnaments_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedFields_CastleRoofOrnaments_Count));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Start));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Count));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_CastleRoofOrnaments));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_EastOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_CastleRoofOrnaments_EastOrnament));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_NorthOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_CastleRoofOrnaments_NorthOrnament));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_SouthOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_CastleRoofOrnaments_SouthOrnament));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_WestOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_CastleRoofOrnaments_WestOrnament));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_StaticTransform));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_UseStaticTransform));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoofOrnaments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleRoofOrnaments));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataSize_CastleRoofOrnaments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (ComponentDataSize_CastleRoofOrnaments));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (ComponentDataStartOffset_StaticTransformCompatible));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (ComponentDataSize_StaticTransformCompatible));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_CompBit_CastleRoofOrnaments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (CompBit_CastleRoofOrnaments));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_CompBit_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (CompBit_StaticTransformCompatible));
      Snapshot_acbicfeedbb.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_acbicfeedbb.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, 100664132);
      Snapshot_acbicfeedbb.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, 100664133);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acbicfeedbb>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleRoofOrnaments_Start
    {
      get
      {
        int roofOrnamentsStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_CastleRoofOrnaments_Start, (void*) &roofOrnamentsStart);
        return roofOrnamentsStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_CastleRoofOrnaments_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleRoofOrnaments_Count
    {
      get
      {
        int roofOrnamentsCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_CastleRoofOrnaments_Count, (void*) &roofOrnamentsCount);
        return roofOrnamentsCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_CastleRoofOrnaments_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Start
    {
      get
      {
        int transformCompatibleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &transformCompatibleStart);
        return transformCompatibleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Count
    {
      get
      {
        int transformCompatibleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &transformCompatibleCount);
        return transformCompatibleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleRoofOrnaments
    {
      get
      {
        int castleRoofOrnaments;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments, (void*) &castleRoofOrnaments);
        return castleRoofOrnaments;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleRoofOrnaments_EastOrnament
    {
      get
      {
        int ornamentsEastOrnament;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_EastOrnament, (void*) &ornamentsEastOrnament);
        return ornamentsEastOrnament;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_EastOrnament, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleRoofOrnaments_NorthOrnament
    {
      get
      {
        int ornamentsNorthOrnament;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_NorthOrnament, (void*) &ornamentsNorthOrnament);
        return ornamentsNorthOrnament;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_NorthOrnament, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleRoofOrnaments_SouthOrnament
    {
      get
      {
        int ornamentsSouthOrnament;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_SouthOrnament, (void*) &ornamentsSouthOrnament);
        return ornamentsSouthOrnament;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_SouthOrnament, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleRoofOrnaments_WestOrnament
    {
      get
      {
        int ornamentsWestOrnament;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_WestOrnament, (void*) &ornamentsWestOrnament);
        return ornamentsWestOrnament;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_CastleRoofOrnaments_WestOrnament, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height
    {
      get
      {
        int staticTransformHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &staticTransformHeight);
        return staticTransformHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos
    {
      get
      {
        int staticTransformPos;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &staticTransformPos);
        return staticTransformPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation
    {
      get
      {
        int transformRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &transformRotation);
        return transformRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_StaticTransform
    {
      get
      {
        int compatibleStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &compatibleStaticTransform);
        return compatibleStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_UseStaticTransform
    {
      get
      {
        int useStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &useStaticTransform);
        return useStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleRoofOrnaments
    {
      get
      {
        int castleRoofOrnaments;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoofOrnaments, (void*) &castleRoofOrnaments);
        return castleRoofOrnaments;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataStartOffset_CastleRoofOrnaments, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleRoofOrnaments
    {
      get
      {
        int castleRoofOrnaments;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataSize_CastleRoofOrnaments, (void*) &castleRoofOrnaments);
        return castleRoofOrnaments;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataSize_CastleRoofOrnaments, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleRoofOrnaments
    {
      get
      {
        ulong castleRoofOrnaments;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_CompBit_CastleRoofOrnaments, (void*) &castleRoofOrnaments);
        return castleRoofOrnaments;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_CompBit_CastleRoofOrnaments, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StaticTransformCompatible
    {
      get
      {
        ulong transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbicfeedbb.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }
  }
}
