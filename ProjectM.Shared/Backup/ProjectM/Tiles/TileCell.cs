// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileCell
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileCell
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CELL_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_EmptyMask2D;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ptr;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_TileCellData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetReadonlyRef_Public_byref_TileCellData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BaseHeightLevel_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StaticMaxLevel_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LayerCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Exists_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClampedTileLayerIndex_Public_TileLayerIndex_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValidTileLayerIndex_Public_Boolean_Byte_byref_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileLayerIndex_Public_TileLayerIndex_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileLayerIndex_Public_Static_TileLayerIndex_Byte_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldTileToCellTile_Public_Static_int2_TileCellCoordinate_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidTileLayer_Public_Boolean_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileLayer_Public_TileLayer_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTileLayer_Public_Boolean_TileLayerIndex_byref_TileLayer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTileLayerFromHeightLevel_Public_Boolean_Byte_byref_TileLayer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasTileLayer_Public_Boolean_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalTileToIndex_Public_Static_Int32_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaskByIndex_Public_byref_BitMask2D_16x16_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellBasedMask_Public_byref_BitMask2D_16x16_CellBasedFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddCellBasedCollideFlyMovementMaskToEnumReader_Public_Void_byref_TileCellEnumReader_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_CellBasedFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightLevelForTileLayer_Public_Byte_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalCoordinateFromWorldCellCoordinate_Public_Static_TileCellCoordinate_TileCellCoordinate_TileCellCoordinate_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldCoordinateOfCellFromLocalCellCoordinate_Public_Static_TileCellCoordinate_TileCellCoordinate_TileCellCoordinate_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InvertRotation_Private_Static_TileRotation_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RotateCellInChunk_Private_Static_int2_int2_TileRotation_0;
    [FieldOffset(0)]
    public unsafe TileCellData* Ptr;

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileCell(TileCellData* ptr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) (void*) ptr;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr__ctor_Internal_Void_ptr_TileCellData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref TileCellData GetReadonlyRef()
    {
      // ISSUE: unable to decompile the method.
    }

    public unsafe byte BaseHeightLevel
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 791853, RefRangeEnd = 791865, XrefRangeStart = 791853, XrefRangeEnd = 791853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_get_BaseHeightLevel_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe byte StaticMaxLevel
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 791865, RefRangeEnd = 791873, XrefRangeStart = 791865, XrefRangeEnd = 791865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_get_StaticMaxLevel_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int LayerCount
    {
      [CallerCount(17), CachedScanResults(RefRangeStart = 791874, RefRangeEnd = 791891, XrefRangeStart = 791873, XrefRangeEnd = 791874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_get_LayerCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool Exists
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 791891, RefRangeEnd = 791897, XrefRangeStart = 791891, XrefRangeEnd = 791891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_get_Exists_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 791898, RefRangeEnd = 791905, XrefRangeStart = 791897, XrefRangeEnd = 791898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileLayerIndex GetClampedTileLayerIndex(byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_GetClampedTileLayerIndex_Public_TileLayerIndex_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileLayerIndex*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 791906, RefRangeEnd = 791913, XrefRangeStart = 791905, XrefRangeEnd = 791906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetValidTileLayerIndex(
      byte heightLevel,
      out TileLayerIndex tileLayerIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileLayerIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_TryGetValidTileLayerIndex_Public_Boolean_Byte_byref_TileLayerIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 791913, RefRangeEnd = 791924, XrefRangeStart = 791913, XrefRangeEnd = 791913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileLayerIndex GetTileLayerIndex(byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_GetTileLayerIndex_Public_TileLayerIndex_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileLayerIndex*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 791924, RefRangeEnd = 791925, XrefRangeStart = 791924, XrefRangeEnd = 791924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileLayerIndex GetTileLayerIndex(
      byte heightLevel,
      byte baseTileHeightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &baseTileHeightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_GetTileLayerIndex_Public_Static_TileLayerIndex_Byte_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileLayerIndex*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 791925, RefRangeEnd = 791929, XrefRangeStart = 791925, XrefRangeEnd = 791925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 WorldTileToCellTile(TileCellCoordinate cellCoordinate, int2 worldTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cellCoordinate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldTile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_WorldTileToCellTile_Public_Static_int2_TileCellCoordinate_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 791933, RefRangeEnd = 791937, XrefRangeStart = 791929, XrefRangeEnd = 791933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidTileLayer(TileLayerIndex tileLayer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileLayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_IsValidTileLayer_Public_Boolean_TileLayerIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 791938, RefRangeEnd = 791957, XrefRangeStart = 791937, XrefRangeEnd = 791938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileLayer GetTileLayer(TileLayerIndex tileLayer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileLayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_GetTileLayer_Public_TileLayer_TileLayerIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileLayer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 791958, RefRangeEnd = 791968, XrefRangeStart = 791957, XrefRangeEnd = 791958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetTileLayer(TileLayerIndex tileLayer, out TileLayer layer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref layer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_TryGetTileLayer_Public_Boolean_TileLayerIndex_byref_TileLayer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 791971, RefRangeEnd = 791976, XrefRangeStart = 791968, XrefRangeEnd = 791971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetTileLayerFromHeightLevel(byte heightLevel, out TileLayer layer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref layer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_TryGetTileLayerFromHeightLevel_Public_Boolean_Byte_byref_TileLayer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 791977, RefRangeEnd = 791987, XrefRangeStart = 791976, XrefRangeEnd = 791977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasTileLayer(TileLayerIndex tileLayer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileLayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_HasTileLayer_Public_Boolean_TileLayerIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 791987, RefRangeEnd = 791994, XrefRangeStart = 791987, XrefRangeEnd = 791987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int LocalTileToIndex(int2 localCellTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localCellTile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_LocalTileToIndex_Public_Static_Int32_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 792001, RefRangeEnd = 792017, XrefRangeStart = 791994, XrefRangeEnd = 792001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref BitMask2D_16x16 GetMaskByIndex(int cellMaskIndex)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 792019, RefRangeEnd = 792021, XrefRangeStart = 792017, XrefRangeEnd = 792019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref BitMask2D_16x16 GetCellBasedMask(CellBasedFlags flag)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 792025, RefRangeEnd = 792028, XrefRangeStart = 792021, XrefRangeEnd = 792025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddCellBasedCollideFlyMovementMaskToEnumReader(
      ref TileCellEnumReader collisionReader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref collisionReader;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_AddCellBasedCollideFlyMovementMaskToEnumReader_Public_Void_byref_TileCellEnumReader_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 792038, RefRangeEnd = 792040, XrefRangeStart = 792028, XrefRangeEnd = 792038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetCellMaskIndex(CellBasedFlags flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_CellBasedFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 792044, RefRangeEnd = 792051, XrefRangeStart = 792040, XrefRangeEnd = 792044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe byte GetHeightLevelForTileLayer(TileLayerIndex tileLayer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileLayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_GetHeightLevelForTileLayer_Public_Byte_TileLayerIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792063, RefRangeEnd = 792064, XrefRangeStart = 792051, XrefRangeEnd = 792063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCellCoordinate GetLocalCoordinateFromWorldCellCoordinate(
      TileCellCoordinate worldCellCoord,
      TileCellCoordinate chunkCellOffset,
      TileRotation chunkRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldCellCoord;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkCellOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_GetLocalCoordinateFromWorldCellCoordinate_Public_Static_TileCellCoordinate_TileCellCoordinate_TileCellCoordinate_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCellCoordinate*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792064, XrefRangeEnd = 792065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCellCoordinate GetWorldCoordinateOfCellFromLocalCellCoordinate(
      TileCellCoordinate localCellCoord,
      TileCellCoordinate chunkCellOffset,
      TileRotation chunkRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &localCellCoord;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkCellOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_GetWorldCoordinateOfCellFromLocalCellCoordinate_Public_Static_TileCellCoordinate_TileCellCoordinate_TileCellCoordinate_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCellCoordinate*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe TileRotation InvertRotation(TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_InvertRotation_Private_Static_TileRotation_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 792065, RefRangeEnd = 792070, XrefRangeStart = 792065, XrefRangeEnd = 792065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 RotateCellInChunk(int2 coord, TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &coord;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCell.NativeMethodInfoPtr_RotateCellInChunk_Private_Static_int2_int2_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileCell()
    {
      Il2CppClassPointerStore<TileCell>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileCell));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCell>.NativeClassPtr);
      TileCell.NativeFieldInfoPtr_CELL_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCell>.NativeClassPtr, nameof (CELL_SIZE));
      TileCell.NativeFieldInfoPtr_EmptyMask2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCell>.NativeClassPtr, nameof (EmptyMask2D));
      TileCell.NativeFieldInfoPtr_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCell>.NativeClassPtr, nameof (Ptr));
      TileCell.NativeMethodInfoPtr__ctor_Internal_Void_ptr_TileCellData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669671);
      TileCell.NativeMethodInfoPtr_GetReadonlyRef_Public_byref_TileCellData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669672);
      TileCell.NativeMethodInfoPtr_get_BaseHeightLevel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669673);
      TileCell.NativeMethodInfoPtr_get_StaticMaxLevel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669674);
      TileCell.NativeMethodInfoPtr_get_LayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669675);
      TileCell.NativeMethodInfoPtr_get_Exists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669676);
      TileCell.NativeMethodInfoPtr_GetClampedTileLayerIndex_Public_TileLayerIndex_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669677);
      TileCell.NativeMethodInfoPtr_TryGetValidTileLayerIndex_Public_Boolean_Byte_byref_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669678);
      TileCell.NativeMethodInfoPtr_GetTileLayerIndex_Public_TileLayerIndex_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669679);
      TileCell.NativeMethodInfoPtr_GetTileLayerIndex_Public_Static_TileLayerIndex_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669680);
      TileCell.NativeMethodInfoPtr_WorldTileToCellTile_Public_Static_int2_TileCellCoordinate_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669681);
      TileCell.NativeMethodInfoPtr_IsValidTileLayer_Public_Boolean_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669682);
      TileCell.NativeMethodInfoPtr_GetTileLayer_Public_TileLayer_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669683);
      TileCell.NativeMethodInfoPtr_TryGetTileLayer_Public_Boolean_TileLayerIndex_byref_TileLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669684);
      TileCell.NativeMethodInfoPtr_TryGetTileLayerFromHeightLevel_Public_Boolean_Byte_byref_TileLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669685);
      TileCell.NativeMethodInfoPtr_HasTileLayer_Public_Boolean_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669686);
      TileCell.NativeMethodInfoPtr_LocalTileToIndex_Public_Static_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669687);
      TileCell.NativeMethodInfoPtr_GetMaskByIndex_Public_byref_BitMask2D_16x16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669688);
      TileCell.NativeMethodInfoPtr_GetCellBasedMask_Public_byref_BitMask2D_16x16_CellBasedFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669689);
      TileCell.NativeMethodInfoPtr_AddCellBasedCollideFlyMovementMaskToEnumReader_Public_Void_byref_TileCellEnumReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669690);
      TileCell.NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_CellBasedFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669691);
      TileCell.NativeMethodInfoPtr_GetHeightLevelForTileLayer_Public_Byte_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669692);
      TileCell.NativeMethodInfoPtr_GetLocalCoordinateFromWorldCellCoordinate_Public_Static_TileCellCoordinate_TileCellCoordinate_TileCellCoordinate_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669693);
      TileCell.NativeMethodInfoPtr_GetWorldCoordinateOfCellFromLocalCellCoordinate_Public_Static_TileCellCoordinate_TileCellCoordinate_TileCellCoordinate_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669694);
      TileCell.NativeMethodInfoPtr_InvertRotation_Private_Static_TileRotation_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669695);
      TileCell.NativeMethodInfoPtr_RotateCellInChunk_Private_Static_int2_int2_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCell>.NativeClassPtr, 100669696);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileCell>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CELL_SIZE
    {
      get
      {
        int cellSize;
        IL2CPP.il2cpp_field_static_get_value(TileCell.NativeFieldInfoPtr_CELL_SIZE, (void*) &cellSize);
        return cellSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileCell.NativeFieldInfoPtr_CELL_SIZE, (void*) &value);
      }
    }

    public static unsafe BitMask2D_16x16 EmptyMask2D
    {
      get
      {
        BitMask2D_16x16 emptyMask2D;
        IL2CPP.il2cpp_field_static_get_value(TileCell.NativeFieldInfoPtr_EmptyMask2D, (void*) &emptyMask2D);
        return emptyMask2D;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileCell.NativeFieldInfoPtr_EmptyMask2D, (void*) &value);
      }
    }
  }
}
