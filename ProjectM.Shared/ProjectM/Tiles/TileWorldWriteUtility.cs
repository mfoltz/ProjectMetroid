// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileWorldWriteUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TileWorldWriteUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_TILE_LEVEL_CAPACITY;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllocateWorld_Public_Static_TileWorldWriteable_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellRW_Public_Static_TileCell_byref_TileWorld_TileCellCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeCell_Public_Static_Void_TileCell_Byte_Byte_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllocateAndPushLevel_Public_Static_byref_TileLayerData_TileCell_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PopAndFreeLevel_Public_Static_Void_TileCell_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightLevelLayer_Public_Static_TileLayer_TileCell_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileLayer_Public_Static_TileLayer_TileCell_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellPtr_Public_Static_ptr_TileCellData_TileCell_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileLayerPtr_Public_Static_ptr_TileLayerData_TileLayer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FreeCell_Public_Static_Void_TileCell_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryEnsureTileLayerExists_Public_Static_Boolean_TileCell_TileLayerIndex_Boolean_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllocateChunk_Public_Static_Void_byref_TileWorld_TerrainChunk_NativeArray_1_ChunkCellBaseHeightLevel_NativeArray_1_ChunkTileBaseHeightLevel_NativeArray_1_ChunkBaseGameplayHeights_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeallocateChunk_Public_Static_Void_byref_TileWorld_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PtrToTempNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerHeights_Public_Static_Void_ptr_TileCellData_byref_TileCellGameplayHeights_TileLayerIndex_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_TileCell_TileLayer_byref_BitMask2D_16x16_StandardLayerFlags_byref_StandardLayerFlags_NativeHashMap_2_BitMask2D_16x16_Byte_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793131, XrefRangeEnd = 793134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileWorldWriteable AllocateWorld(int2 cellCount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cellCount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_AllocateWorld_Public_Static_TileWorldWriteable_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileWorldWriteable*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 793138, RefRangeEnd = 793142, XrefRangeStart = 793134, XrefRangeEnd = 793138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCell GetCellRW(ref TileWorld world, TileCellCoordinate cellCoordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellCoordinate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_GetCellRW_Public_Static_TileCell_byref_TileWorld_TileCellCoordinate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCell*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793179, RefRangeEnd = 793180, XrefRangeStart = 793142, XrefRangeEnd = 793179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InitializeCell(
      TileCell cell,
      byte baseHeightLevel,
      byte staticMaxHeightLevel,
      bool isServer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &cell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &baseHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &staticMaxHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isServer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_InitializeCell_Public_Static_Void_TileCell_Byte_Byte_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 793216, RefRangeEnd = 793218, XrefRangeStart = 793180, XrefRangeEnd = 793216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static ref TileLayerData AllocateAndPushLevel(TileCell cell, bool isServer)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793253, RefRangeEnd = 793254, XrefRangeStart = 793218, XrefRangeEnd = 793253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PopAndFreeLevel(TileCell cell, bool allowPopLastLevel = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allowPopLastLevel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_PopAndFreeLevel_Public_Static_Void_TileCell_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793254, XrefRangeEnd = 793263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileLayer GetHeightLevelLayer(TileCell cell, byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_GetHeightLevelLayer_Public_Static_TileLayer_TileCell_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileLayer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 793272, RefRangeEnd = 793279, XrefRangeStart = 793263, XrefRangeEnd = 793272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileLayer GetTileLayer(TileCell cell, TileLayerIndex tileLayer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_GetTileLayer_Public_Static_TileLayer_TileCell_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileLayer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCellData* GetCellPtr(TileCell cell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cell;
      System.IntPtr exc;
      System.IntPtr cellPtr = IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_GetCellPtr_Public_Static_ptr_TileCellData_TileCell_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return (TileCellData*) (void*) cellPtr;
    }

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileLayerData* GetTileLayerPtr(TileLayer layer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &layer;
      System.IntPtr exc;
      System.IntPtr tileLayerPtr = IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_GetTileLayerPtr_Public_Static_ptr_TileLayerData_TileLayer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return (TileLayerData*) (void*) tileLayerPtr;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 793307, RefRangeEnd = 793309, XrefRangeStart = 793279, XrefRangeEnd = 793307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FreeCell(TileCell cell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cell;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_FreeCell_Public_Static_Void_TileCell_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793317, RefRangeEnd = 793318, XrefRangeStart = 793309, XrefRangeEnd = 793317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryEnsureTileLayerExists(
      TileCell cell,
      TileLayerIndex tileLayer,
      bool isServer,
      out bool allocatedNewLayer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &cell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref allocatedNewLayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_TryEnsureTileLayerExists_Public_Static_Boolean_TileCell_TileLayerIndex_Boolean_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793374, RefRangeEnd = 793375, XrefRangeStart = 793318, XrefRangeEnd = 793374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AllocateChunk(
      ref TileWorld tileWorld,
      TerrainChunk chunkCoordinate,
      NativeArray<ChunkCellBaseHeightLevel> baseHeightLevelsPerCell,
      NativeArray<ChunkTileBaseHeightLevel> baseHeightLevelsPerChunkTile,
      NativeArray<ChunkBaseGameplayHeights> chunkBaseGameplayHeights,
      bool isServer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkCoordinate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &baseHeightLevelsPerCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &baseHeightLevelsPerChunkTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkBaseGameplayHeights;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &isServer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_AllocateChunk_Public_Static_Void_byref_TileWorld_TerrainChunk_NativeArray_1_ChunkCellBaseHeightLevel_NativeArray_1_ChunkTileBaseHeightLevel_NativeArray_1_ChunkBaseGameplayHeights_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793393, RefRangeEnd = 793394, XrefRangeStart = 793375, XrefRangeEnd = 793393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DeallocateChunk(ref TileWorld tileWorld, TerrainChunk chunkCoordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkCoordinate;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_DeallocateChunk_Public_Static_Void_byref_TileWorld_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 296180, RefRangeEnd = 296186, XrefRangeStart = 296180, XrefRangeEnd = 296186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeArray<T> PtrToTempNativeArray<T>(void* ptr, int length)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ptr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.MethodInfoStoreGeneric_PtrToTempNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 793409, RefRangeEnd = 793411, XrefRangeStart = 793394, XrefRangeEnd = 793409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetLayerHeights(
      TileCellData* cellPtr,
      [In] ref TileCellGameplayHeights layerHeights,
      TileLayerIndex fromTileLayer,
      TileLayerIndex toTileLayerExclusive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) (void*) cellPtr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref layerHeights;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromTileLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toTileLayerExclusive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_SetLayerHeights_Public_Static_Void_ptr_TileCellData_byref_TileCellGameplayHeights_TileLayerIndex_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793425, RefRangeEnd = 793426, XrefRangeStart = 793411, XrefRangeEnd = 793425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Internal_Static_Void_TileCell_TileLayer_byref_BitMask2D_16x16_StandardLayerFlags_byref_StandardLayerFlags_NativeHashMap_2_BitMask2D_16x16_Byte_0(
      TileCell cell,
      TileLayer layer,
      [In] ref BitMask2D_16x16 mask,
      StandardLayerFlags enumType,
      ref StandardLayerFlags usedLayerFlags,
      NativeHashMap<BitMask2D_16x16, byte> layerMaskToIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &cell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mask;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &enumType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref usedLayerFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMaskToIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldWriteUtility.NativeMethodInfoPtr_Method_Internal_Static_Void_TileCell_TileLayer_byref_BitMask2D_16x16_StandardLayerFlags_byref_StandardLayerFlags_NativeHashMap_2_BitMask2D_16x16_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileWorldWriteUtility()
    {
      Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileWorldWriteUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr);
      TileWorldWriteUtility.NativeFieldInfoPtr_DEFAULT_TILE_LEVEL_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, nameof (DEFAULT_TILE_LEVEL_CAPACITY));
      TileWorldWriteUtility.NativeMethodInfoPtr_AllocateWorld_Public_Static_TileWorldWriteable_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669853);
      TileWorldWriteUtility.NativeMethodInfoPtr_GetCellRW_Public_Static_TileCell_byref_TileWorld_TileCellCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669854);
      TileWorldWriteUtility.NativeMethodInfoPtr_InitializeCell_Public_Static_Void_TileCell_Byte_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669855);
      TileWorldWriteUtility.NativeMethodInfoPtr_AllocateAndPushLevel_Public_Static_byref_TileLayerData_TileCell_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669856);
      TileWorldWriteUtility.NativeMethodInfoPtr_PopAndFreeLevel_Public_Static_Void_TileCell_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669857);
      TileWorldWriteUtility.NativeMethodInfoPtr_GetHeightLevelLayer_Public_Static_TileLayer_TileCell_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669858);
      TileWorldWriteUtility.NativeMethodInfoPtr_GetTileLayer_Public_Static_TileLayer_TileCell_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669859);
      TileWorldWriteUtility.NativeMethodInfoPtr_GetCellPtr_Public_Static_ptr_TileCellData_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669860);
      TileWorldWriteUtility.NativeMethodInfoPtr_GetTileLayerPtr_Public_Static_ptr_TileLayerData_TileLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669861);
      TileWorldWriteUtility.NativeMethodInfoPtr_FreeCell_Public_Static_Void_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669862);
      TileWorldWriteUtility.NativeMethodInfoPtr_TryEnsureTileLayerExists_Public_Static_Boolean_TileCell_TileLayerIndex_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669863);
      TileWorldWriteUtility.NativeMethodInfoPtr_AllocateChunk_Public_Static_Void_byref_TileWorld_TerrainChunk_NativeArray_1_ChunkCellBaseHeightLevel_NativeArray_1_ChunkTileBaseHeightLevel_NativeArray_1_ChunkBaseGameplayHeights_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669864);
      TileWorldWriteUtility.NativeMethodInfoPtr_DeallocateChunk_Public_Static_Void_byref_TileWorld_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669865);
      TileWorldWriteUtility.NativeMethodInfoPtr_PtrToTempNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669866);
      TileWorldWriteUtility.NativeMethodInfoPtr_SetLayerHeights_Public_Static_Void_ptr_TileCellData_byref_TileCellGameplayHeights_TileLayerIndex_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669867);
      TileWorldWriteUtility.NativeMethodInfoPtr_Method_Internal_Static_Void_TileCell_TileLayer_byref_BitMask2D_16x16_StandardLayerFlags_byref_StandardLayerFlags_NativeHashMap_2_BitMask2D_16x16_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr, 100669868);
    }

    public TileWorldWriteUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int DEFAULT_TILE_LEVEL_CAPACITY
    {
      get
      {
        int tileLevelCapacity;
        IL2CPP.il2cpp_field_static_get_value(TileWorldWriteUtility.NativeFieldInfoPtr_DEFAULT_TILE_LEVEL_CAPACITY, (void*) &tileLevelCapacity);
        return tileLevelCapacity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileWorldWriteUtility.NativeFieldInfoPtr_DEFAULT_TILE_LEVEL_CAPACITY, (void*) &value);
      }
    }

    private sealed class MethodInfoStoreGeneric_PtrToTempNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileWorldWriteUtility.NativeMethodInfoPtr_PtrToTempNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<TileWorldWriteUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
