// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileModelSpatialLookupShared
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TileModelSpatialLookupShared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CELL_SIZE_IN_TILES;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSpatialCellForTile_Public_Static_TileModelSpatialCell_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntities_Public_Static_NativeList_1_Entity_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntities_Public_Static_Void_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_NativeList_1_Entity_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRawSpatialCellEnumerator_Public_Static_Enumerator_TileModelSpatialCell_TileModelSpatialEntity_TileModelSpatialCell_byref_SpatialLookupParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFullEntityDatasInCell_Public_Static_Void_TileCellCoordinate_TileType_byref_SpatialLookupParams_NativeList_1_TileModelSpatialEntity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFullEntityData_Public_Static_NativeList_1_TileModelSpatialEntity_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFullEntityDatas_Public_Static_Void_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_NativeList_1_TileModelSpatialEntity_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Private_Static_Boolean_NativeList_1_TileModelSpatialEntity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInCells_Public_Static_Void_BoundsMinMax_NativeMultiHashMap_2_TileModelSpatialCell_Entity_NativeList_1_Entity_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOverlappingCells_Public_Static_Void_BoundsMinMax_NativeList_1_TileModelSpatialCell_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087959, RefRangeEnd = 1087960, XrefRangeStart = 1087959, XrefRangeEnd = 1087959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileModelSpatialCell GetSpatialCellForTile(int2 worldTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldTile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupShared.NativeMethodInfoPtr_GetSpatialCellForTile_Public_Static_TileModelSpatialCell_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileModelSpatialCell*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 1087964, RefRangeEnd = 1087983, XrefRangeStart = 1087960, XrefRangeEnd = 1087964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<Entity> GetEntities(
      [In] ref BoundsMinMax bounds,
      ProjectM.TileType tileTypes,
      ref SpatialLookupParams lookupParams,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupShared.NativeMethodInfoPtr_GetEntities_Public_Static_NativeList_1_Entity_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1088024, RefRangeEnd = 1088026, XrefRangeStart = 1087983, XrefRangeEnd = 1088024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetEntities(
      [In] ref BoundsMinMax bounds,
      ProjectM.TileType tileTypes,
      ref SpatialLookupParams lookupParams,
      NativeList<Entity> result,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupShared.NativeMethodInfoPtr_GetEntities_Public_Static_Void_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_NativeList_1_Entity_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1088029, RefRangeEnd = 1088030, XrefRangeStart = 1088026, XrefRangeEnd = 1088029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity>.Enumerator GetRawSpatialCellEnumerator(
      TileModelSpatialCell spatialCell,
      ref SpatialLookupParams lookupParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spatialCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookupParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupShared.NativeMethodInfoPtr_GetRawSpatialCellEnumerator_Public_Static_Enumerator_TileModelSpatialCell_TileModelSpatialEntity_TileModelSpatialCell_byref_SpatialLookupParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity>.Enumerator*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088030, XrefRangeEnd = 1088049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetFullEntityDatasInCell(
      TileCellCoordinate tileCellCoordinate,
      ProjectM.TileType tileTypes,
      ref SpatialLookupParams lookupParams,
      NativeList<TileModelSpatialEntity> result,
      bool assertEntitiesNotDestroyed = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &tileCellCoordinate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &assertEntitiesNotDestroyed;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupShared.NativeMethodInfoPtr_GetFullEntityDatasInCell_Public_Static_Void_TileCellCoordinate_TileType_byref_SpatialLookupParams_NativeList_1_TileModelSpatialEntity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088049, XrefRangeEnd = 1088053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<TileModelSpatialEntity> GetFullEntityData(
      [In] ref BoundsMinMax bounds,
      ProjectM.TileType tileTypes,
      ref SpatialLookupParams lookupParams,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupShared.NativeMethodInfoPtr_GetFullEntityData_Public_Static_NativeList_1_TileModelSpatialEntity_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<TileModelSpatialEntity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1088092, RefRangeEnd = 1088093, XrefRangeStart = 1088053, XrefRangeEnd = 1088092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetFullEntityDatas(
      [In] ref BoundsMinMax bounds,
      ProjectM.TileType tileTypes,
      ref SpatialLookupParams lookupParams,
      NativeList<TileModelSpatialEntity> result,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupShared.NativeMethodInfoPtr_GetFullEntityDatas_Public_Static_Void_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_NativeList_1_TileModelSpatialEntity_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1088102, RefRangeEnd = 1088103, XrefRangeStart = 1088093, XrefRangeEnd = 1088102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Contains(NativeList<TileModelSpatialEntity> entries, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entries;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupShared.NativeMethodInfoPtr_Contains_Private_Static_Boolean_NativeList_1_TileModelSpatialEntity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088103, XrefRangeEnd = 1088134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetEntitiesInCells(
      BoundsMinMax bounds,
      NativeMultiHashMap<TileModelSpatialCell, Entity> lookupMap,
      NativeList<Entity> result,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupShared.NativeMethodInfoPtr_GetEntitiesInCells_Public_Static_Void_BoundsMinMax_NativeMultiHashMap_2_TileModelSpatialCell_Entity_NativeList_1_Entity_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1088138, RefRangeEnd = 1088145, XrefRangeStart = 1088134, XrefRangeEnd = 1088138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetOverlappingCells(
      BoundsMinMax bounds,
      NativeList<TileModelSpatialCell> cells)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cells;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupShared.NativeMethodInfoPtr_GetOverlappingCells_Public_Static_Void_BoundsMinMax_NativeList_1_TileModelSpatialCell_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileModelSpatialLookupShared()
    {
      Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileModelSpatialLookupShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr);
      TileModelSpatialLookupShared.NativeFieldInfoPtr_CELL_SIZE_IN_TILES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, nameof (CELL_SIZE_IN_TILES));
      TileModelSpatialLookupShared.NativeMethodInfoPtr_GetSpatialCellForTile_Public_Static_TileModelSpatialCell_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, 100685639);
      TileModelSpatialLookupShared.NativeMethodInfoPtr_GetEntities_Public_Static_NativeList_1_Entity_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, 100685640);
      TileModelSpatialLookupShared.NativeMethodInfoPtr_GetEntities_Public_Static_Void_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_NativeList_1_Entity_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, 100685641);
      TileModelSpatialLookupShared.NativeMethodInfoPtr_GetRawSpatialCellEnumerator_Public_Static_Enumerator_TileModelSpatialCell_TileModelSpatialEntity_TileModelSpatialCell_byref_SpatialLookupParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, 100685642);
      TileModelSpatialLookupShared.NativeMethodInfoPtr_GetFullEntityDatasInCell_Public_Static_Void_TileCellCoordinate_TileType_byref_SpatialLookupParams_NativeList_1_TileModelSpatialEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, 100685643);
      TileModelSpatialLookupShared.NativeMethodInfoPtr_GetFullEntityData_Public_Static_NativeList_1_TileModelSpatialEntity_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, 100685644);
      TileModelSpatialLookupShared.NativeMethodInfoPtr_GetFullEntityDatas_Public_Static_Void_byref_BoundsMinMax_TileType_byref_SpatialLookupParams_NativeList_1_TileModelSpatialEntity_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, 100685645);
      TileModelSpatialLookupShared.NativeMethodInfoPtr_Contains_Private_Static_Boolean_NativeList_1_TileModelSpatialEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, 100685646);
      TileModelSpatialLookupShared.NativeMethodInfoPtr_GetEntitiesInCells_Public_Static_Void_BoundsMinMax_NativeMultiHashMap_2_TileModelSpatialCell_Entity_NativeList_1_Entity_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, 100685647);
      TileModelSpatialLookupShared.NativeMethodInfoPtr_GetOverlappingCells_Public_Static_Void_BoundsMinMax_NativeList_1_TileModelSpatialCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupShared>.NativeClassPtr, 100685648);
    }

    public TileModelSpatialLookupShared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CELL_SIZE_IN_TILES
    {
      get
      {
        int cellSizeInTiles;
        IL2CPP.il2cpp_field_static_get_value(TileModelSpatialLookupShared.NativeFieldInfoPtr_CELL_SIZE_IN_TILES, (void*) &cellSizeInTiles);
        return cellSizeInTiles;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileModelSpatialLookupShared.NativeFieldInfoPtr_CELL_SIZE_IN_TILES, (void*) &value);
      }
    }
  }
}
