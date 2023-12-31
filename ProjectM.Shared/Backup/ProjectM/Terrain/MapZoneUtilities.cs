// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  public static class MapZoneUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultCastleTileExpansionAroundBlocks;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetMapZoneForWorldPos_Public_Static_Boolean_EntityManager_byref_MapZoneCollection_float2_byref_SpatialMapZoneData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TransformVertices_Public_Static_Void_NativeArray_1_float2_TerrainChunk_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculatePolygonMinMax_Public_Static_Void_NativeArray_1_float2_byref_int2_byref_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindFloorsForPolygon_Public_Static_Void_BoundsMinMax_NativeArray_1_float2_Allocator_byref_NativeList_1_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildFloorArrays_Public_Static_Void_NativeArray_1_int2_Allocator_byref_BoundsMinMax_byref_BoundsMinMax_byref_NativeArray_1_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTerritoryTileEnabledStates_Public_Static_Void_NativeArray_1_Boolean_BoundsMinMax_BoundsMinMax_NativeArray_1_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawTerritoryFloorBounds_Public_Static_Void_BoundsMinMax_Single_NativeArray_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_int2_NativeArray_1_Boolean_PDM_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 766706, RefRangeEnd = 766708, XrefRangeStart = 766647, XrefRangeEnd = 766706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetMapZoneForWorldPos(
      EntityManager entityManager,
      [In] ref MapZoneCollection mapZoneCollection,
      float2 worldPos,
      out SpatialMapZoneData mapZoneData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneUtilities.NativeMethodInfoPtr_TryGetMapZoneForWorldPos_Public_Static_Boolean_EntityManager_byref_MapZoneCollection_float2_byref_SpatialMapZoneData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766713, RefRangeEnd = 766714, XrefRangeStart = 766708, XrefRangeEnd = 766713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TransformVertices(
      NativeArray<float2> vertices,
      TerrainChunk terrainChunk,
      OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &vertices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneUtilities.NativeMethodInfoPtr_TransformVertices_Public_Static_Void_NativeArray_1_float2_TerrainChunk_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 766715, RefRangeEnd = 766717, XrefRangeStart = 766714, XrefRangeEnd = 766715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CalculatePolygonMinMax(
      NativeArray<float2> vertices,
      out int2 min,
      out int2 max)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &vertices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref max;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneUtilities.NativeMethodInfoPtr_CalculatePolygonMinMax_Public_Static_Void_NativeArray_1_float2_byref_int2_byref_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766729, RefRangeEnd = 766730, XrefRangeStart = 766717, XrefRangeEnd = 766729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FindFloorsForPolygon(
      BoundsMinMax worldBounds,
      NativeArray<float2> polygon,
      Allocator allocator,
      out NativeList<int2> enabledFloorBlocks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &polygon;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref enabledFloorBlocks;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneUtilities.NativeMethodInfoPtr_FindFloorsForPolygon_Public_Static_Void_BoundsMinMax_NativeArray_1_float2_Allocator_byref_NativeList_1_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 766734, RefRangeEnd = 766737, XrefRangeStart = 766730, XrefRangeEnd = 766734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void BuildFloorArrays(
      NativeArray<int2> floorBlocks,
      Allocator allocator,
      out BoundsMinMax blockSpaceBounds,
      out BoundsMinMax worldSpaceTerritoryTileBounds,
      out NativeArray<bool> floorBlocksEnabled,
      int territoryTileExpansion = 1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &floorBlocks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockSpaceBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref worldSpaceTerritoryTileBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref floorBlocksEnabled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &territoryTileExpansion;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneUtilities.NativeMethodInfoPtr_BuildFloorArrays_Public_Static_Void_NativeArray_1_int2_Allocator_byref_BoundsMinMax_byref_BoundsMinMax_byref_NativeArray_1_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766742, RefRangeEnd = 766743, XrefRangeStart = 766737, XrefRangeEnd = 766742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTerritoryTileEnabledStates(
      NativeArray<bool> castleFloorTilesArray,
      BoundsMinMax floorSpaceBounds,
      BoundsMinMax worldSpaceTerritoryBounds,
      NativeArray<bool> enabledFloorTiles,
      int territoryTileExpansion = 1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &castleFloorTilesArray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorSpaceBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldSpaceTerritoryBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &enabledFloorTiles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &territoryTileExpansion;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneUtilities.NativeMethodInfoPtr_SetTerritoryTileEnabledStates_Public_Static_Void_NativeArray_1_Boolean_BoundsMinMax_BoundsMinMax_NativeArray_1_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 766761, RefRangeEnd = 766763, XrefRangeStart = 766743, XrefRangeEnd = 766761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawTerritoryFloorBounds(
      BoundsMinMax floorSpaceBounds,
      float y,
      NativeArray<bool> blockValidity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &floorSpaceBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &blockValidity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneUtilities.NativeMethodInfoPtr_DrawTerritoryFloorBounds_Public_Static_Void_BoundsMinMax_Single_NativeArray_1_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe bool Method_Internal_Static_Boolean_Int32_Int32_int2_NativeArray_1_Boolean_PDM_0(
      int bX,
      int bY,
      int2 range,
      NativeArray<bool> validity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &bX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &range;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &validity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneUtilities.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_int2_NativeArray_1_Boolean_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MapZoneUtilities()
    {
      Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (MapZoneUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr);
      MapZoneUtilities.NativeFieldInfoPtr_DefaultCastleTileExpansionAroundBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr, nameof (DefaultCastleTileExpansionAroundBlocks));
      MapZoneUtilities.NativeMethodInfoPtr_TryGetMapZoneForWorldPos_Public_Static_Boolean_EntityManager_byref_MapZoneCollection_float2_byref_SpatialMapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr, 100667783);
      MapZoneUtilities.NativeMethodInfoPtr_TransformVertices_Public_Static_Void_NativeArray_1_float2_TerrainChunk_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr, 100667784);
      MapZoneUtilities.NativeMethodInfoPtr_CalculatePolygonMinMax_Public_Static_Void_NativeArray_1_float2_byref_int2_byref_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr, 100667785);
      MapZoneUtilities.NativeMethodInfoPtr_FindFloorsForPolygon_Public_Static_Void_BoundsMinMax_NativeArray_1_float2_Allocator_byref_NativeList_1_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr, 100667786);
      MapZoneUtilities.NativeMethodInfoPtr_BuildFloorArrays_Public_Static_Void_NativeArray_1_int2_Allocator_byref_BoundsMinMax_byref_BoundsMinMax_byref_NativeArray_1_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr, 100667787);
      MapZoneUtilities.NativeMethodInfoPtr_SetTerritoryTileEnabledStates_Public_Static_Void_NativeArray_1_Boolean_BoundsMinMax_BoundsMinMax_NativeArray_1_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr, 100667788);
      MapZoneUtilities.NativeMethodInfoPtr_DrawTerritoryFloorBounds_Public_Static_Void_BoundsMinMax_Single_NativeArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr, 100667789);
      MapZoneUtilities.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_int2_NativeArray_1_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneUtilities>.NativeClassPtr, 100667790);
    }

    public MapZoneUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int DefaultCastleTileExpansionAroundBlocks
    {
      get
      {
        int expansionAroundBlocks;
        IL2CPP.il2cpp_field_static_get_value(MapZoneUtilities.NativeFieldInfoPtr_DefaultCastleTileExpansionAroundBlocks, (void*) &expansionAroundBlocks);
        return expansionAroundBlocks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapZoneUtilities.NativeFieldInfoPtr_DefaultCastleTileExpansionAroundBlocks, (void*) &value);
      }
    }
  }
}
