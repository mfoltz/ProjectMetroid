// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleFloorAndWallsUpdateSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleFloorAndWallsUpdateSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedFloorsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MovedFloorsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemovedFloorsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedWallsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MovedWallsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemovedWallsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsServer;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBoundsForWalls_Private_Static_BoundsMinMax_TilePosition_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetWall_Private_Static_Boolean_TilePosition_TilePivotSettings_Entity_ComponentDataFromEntity_1_CastleRoomWall_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_byref_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFloorForWall_Private_Static_Boolean_TilePosition_TilePivotSettings_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_byref_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateNeighbourFloors_Private_Static_Void_byref_GetNeighbourFloorsJobData_ComponentDataFromEntity_1_CastleFloor_Entity_TilePosition_SpatialLookupParams_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFloorWallsForFloor_Private_Static_Void_Entity_TilePosition_ComponentDataFromEntity_1_CastleRoomWall_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_SpatialLookupParams_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFloorWallsForWall_Private_Static_Void_Entity_TilePosition_TilePivotSettings_ComponentDataFromEntity_1_CastleRoomWall_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_SpatialLookupParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CleanupNeighbourFloorsForFloor_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CleanupWallsForFloor_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_CastleRoomWall_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CleanupFloorsForWall_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_CastleRoomWall_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFloorGrounded_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_byref_TileWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128224, XrefRangeEnd = 1128287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128287, XrefRangeEnd = 1128382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128382, XrefRangeEnd = 1128384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax GetBoundsForWalls(
      TilePosition floorTile,
      TilePivotSettings floorPivotSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &floorTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorPivotSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_GetBoundsForWalls_Private_Static_BoundsMinMax_TilePosition_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1128405, RefRangeEnd = 1128406, XrefRangeStart = 1128384, XrefRangeEnd = 1128405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetWall(
      TilePosition floorTilePosition,
      TilePivotSettings floorTilePivot,
      Entity potentialWall,
      ComponentDataFromEntity<CastleRoomWall> getCastleWall,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      ComponentDataFromEntity<TileData> getTileData,
      out CardinalDirection cardinalDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &floorTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorTilePivot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &potentialWall;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleWall;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getTileData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref cardinalDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_TryGetWall_Private_Static_Boolean_TilePosition_TilePivotSettings_Entity_ComponentDataFromEntity_1_CastleRoomWall_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_byref_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1128426, RefRangeEnd = 1128427, XrefRangeStart = 1128406, XrefRangeEnd = 1128426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetFloorForWall(
      TilePosition wallTilePosition,
      TilePivotSettings wallPivotSettings,
      Entity potentialFloor,
      ComponentDataFromEntity<CastleFloor> getCastleFloor,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      ComponentDataFromEntity<TileData> getTileData,
      out CardinalDirection cardinalDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &wallTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &wallPivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &potentialFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getTileData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref cardinalDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_TryGetFloorForWall_Private_Static_Boolean_TilePosition_TilePivotSettings_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_byref_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128500, RefRangeEnd = 1128502, XrefRangeStart = 1128427, XrefRangeEnd = 1128500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateNeighbourFloors(
      ref RoomUtility.GetNeighbourFloorsJobData jobData,
      ComponentDataFromEntity<CastleFloor> getCastleFloor,
      Entity floor,
      TilePosition tile,
      SpatialLookupParams spatialLookupParams,
      bool clearFloorEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &floor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &spatialLookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &clearFloorEntities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_UpdateNeighbourFloors_Private_Static_Void_byref_GetNeighbourFloorsJobData_ComponentDataFromEntity_1_CastleFloor_Entity_TilePosition_SpatialLookupParams_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128569, RefRangeEnd = 1128571, XrefRangeStart = 1128502, XrefRangeEnd = 1128569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateFloorWallsForFloor(
      Entity floor,
      TilePosition floorTilePosition,
      ComponentDataFromEntity<CastleRoomWall> getCastleWall,
      ComponentDataFromEntity<CastleFloor> getCastleFloor,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      ComponentDataFromEntity<TileData> getTileData,
      SpatialLookupParams spatialLookupParams,
      bool clearFloorEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &floor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleWall;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getTileData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &spatialLookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &clearFloorEntities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_UpdateFloorWallsForFloor_Private_Static_Void_Entity_TilePosition_ComponentDataFromEntity_1_CastleRoomWall_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_SpatialLookupParams_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128630, RefRangeEnd = 1128632, XrefRangeStart = 1128571, XrefRangeEnd = 1128630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateFloorWallsForWall(
      Entity wall,
      TilePosition wallTilePosition,
      TilePivotSettings wallPivotSettings,
      ComponentDataFromEntity<CastleRoomWall> getCastleWall,
      ComponentDataFromEntity<CastleFloor> getCastleFloor,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      ComponentDataFromEntity<TileData> getTileData,
      SpatialLookupParams spatialLookupParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &wall;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &wallTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wallPivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleWall;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &getTileData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &spatialLookupParams;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_UpdateFloorWallsForWall_Private_Static_Void_Entity_TilePosition_TilePivotSettings_ComponentDataFromEntity_1_CastleRoomWall_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_SpatialLookupParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128658, RefRangeEnd = 1128660, XrefRangeStart = 1128632, XrefRangeEnd = 1128658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CleanupNeighbourFloorsForFloor(
      Entity floor,
      ComponentDataFromEntity<CastleFloor> getCastleFloor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &floor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_CleanupNeighbourFloorsForFloor_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128689, RefRangeEnd = 1128691, XrefRangeStart = 1128660, XrefRangeEnd = 1128689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CleanupWallsForFloor(
      Entity floor,
      ComponentDataFromEntity<CastleFloor> getCastleFloor,
      ComponentDataFromEntity<CastleRoomWall> getCastleWall)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &floor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleWall;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_CleanupWallsForFloor_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_CastleRoomWall_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128713, RefRangeEnd = 1128715, XrefRangeStart = 1128691, XrefRangeEnd = 1128713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CleanupFloorsForWall(
      Entity wall,
      ComponentDataFromEntity<CastleFloor> getCastleFloor,
      ComponentDataFromEntity<CastleRoomWall> getCastleWall)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &wall;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleWall;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_CleanupFloorsForWall_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_CastleRoomWall_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128747, RefRangeEnd = 1128749, XrefRangeStart = 1128715, XrefRangeEnd = 1128747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateFloorGrounded(
      Entity floorEntity,
      ComponentDataFromEntity<CastleFloor> getCastleFloor,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      ref TileWorld tileWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &floorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_UpdateFloorGrounded_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_byref_TileWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleFloorAndWallsUpdateSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleFloorAndWallsUpdateSystem()
    {
      Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleFloorAndWallsUpdateSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr);
      CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__AddedFloorsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (_AddedFloorsQuery));
      CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__MovedFloorsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (_MovedFloorsQuery));
      CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__RemovedFloorsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (_RemovedFloorsQuery));
      CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__AddedWallsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (_AddedWallsQuery));
      CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__MovedWallsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (_MovedWallsQuery));
      CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__RemovedWallsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (_RemovedWallsQuery));
      CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (_IsServer));
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689660);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689661);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_GetBoundsForWalls_Private_Static_BoundsMinMax_TilePosition_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689662);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_TryGetWall_Private_Static_Boolean_TilePosition_TilePivotSettings_Entity_ComponentDataFromEntity_1_CastleRoomWall_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_byref_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689663);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_TryGetFloorForWall_Private_Static_Boolean_TilePosition_TilePivotSettings_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_byref_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689664);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_UpdateNeighbourFloors_Private_Static_Void_byref_GetNeighbourFloorsJobData_ComponentDataFromEntity_1_CastleFloor_Entity_TilePosition_SpatialLookupParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689665);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_UpdateFloorWallsForFloor_Private_Static_Void_Entity_TilePosition_ComponentDataFromEntity_1_CastleRoomWall_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_SpatialLookupParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689666);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_UpdateFloorWallsForWall_Private_Static_Void_Entity_TilePosition_TilePivotSettings_ComponentDataFromEntity_1_CastleRoomWall_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileData_SpatialLookupParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689667);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_CleanupNeighbourFloorsForFloor_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689668);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_CleanupWallsForFloor_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_CastleRoomWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689669);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_CleanupFloorsForWall_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_CastleRoomWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689670);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_UpdateFloorGrounded_Private_Static_Void_Entity_ComponentDataFromEntity_1_CastleFloor_ComponentDataFromEntity_1_TilePosition_byref_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689671);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689672);
      CastleFloorAndWallsUpdateSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, 100689673);
    }

    public CastleFloorAndWallsUpdateSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _AddedFloorsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__AddedFloorsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__AddedFloorsQuery)) = value;
      }
    }

    public unsafe EntityQuery _MovedFloorsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__MovedFloorsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__MovedFloorsQuery)) = value;
      }
    }

    public unsafe EntityQuery _RemovedFloorsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__RemovedFloorsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__RemovedFloorsQuery)) = value;
      }
    }

    public unsafe EntityQuery _AddedWallsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__AddedWallsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__AddedWallsQuery)) = value;
      }
    }

    public unsafe EntityQuery _MovedWallsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__MovedWallsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__MovedWallsQuery)) = value;
      }
    }

    public unsafe EntityQuery _RemovedWallsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__RemovedWallsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__RemovedWallsQuery)) = value;
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _IsServer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__IsServer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorAndWallsUpdateSystem.NativeFieldInfoPtr__IsServer)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleAddedFloorEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AddedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_RoomUtilityJobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleAddedFloor_Private_Void_byref_EntityEvent_CastleFloor_TilePosition_byref_AddedEvent_CastleFloor_TilePosition_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.AddedEvent> AddedEventType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<CastleRoomWall> GetCastleWall;
      [FieldOffset(96)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(128)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(160)]
      public RoomUtility.GetNeighbourFloorsJobData RoomUtilityJobData;
      [FieldOffset(352)]
      public SpatialLookupParams SpatialLookupParams;
      [FieldOffset(432)]
      public TileWorld TileWorld;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128101, XrefRangeEnd = 1128110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1128113, RefRangeEnd = 1128114, XrefRangeStart = 1128110, XrefRangeEnd = 1128113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleAddedFloor(
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.AddedEvent addedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref addedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeMethodInfoPtr_HandleAddedFloor_Private_Void_byref_EntityEvent_CastleFloor_TilePosition_byref_AddedEvent_CastleFloor_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleAddedFloorEventsJob()
      {
        Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (HandleAddedFloorEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr);
        CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_AddedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (AddedEventType));
        CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (GetCastleWall));
        CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (GetTilePosition));
        CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (GetTileData));
        CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_RoomUtilityJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (RoomUtilityJobData));
        CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (SpatialLookupParams));
        CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (TileWorld));
        CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, 100689674);
        CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob.NativeMethodInfoPtr_HandleAddedFloor_Private_Void_byref_EntityEvent_CastleFloor_TilePosition_byref_AddedEvent_CastleFloor_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, 100689675);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedFloorEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleRemovedFloorEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IsServer;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemovedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleRemovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_RemovedEvent_CastleFloor_TilePosition_0;
      [FieldOffset(0)]
      public bool IsServer;
      [FieldOffset(4)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(40)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.RemovedEvent> RemovedEventType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(104)]
      public ComponentDataFromEntity<CastleRoomWall> GetCastleWall;
      [FieldOffset(136)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128114, XrefRangeEnd = 1128124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1128138, RefRangeEnd = 1128139, XrefRangeStart = 1128124, XrefRangeEnd = 1128138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleRemovedFloor(
        [In] ref Entity eventEntity,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.RemovedEvent removedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref eventEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref removedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeMethodInfoPtr_HandleRemovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_RemovedEvent_CastleFloor_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleRemovedFloorEventsJob()
      {
        Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (HandleRemovedFloorEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr);
        CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (IsServer));
        CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (EntityType));
        CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_RemovedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (RemovedEventType));
        CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (GetCastleFloor));
        CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (GetCastleWall));
        CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, 100689676);
        CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob.NativeMethodInfoPtr_HandleRemovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_RemovedEvent_CastleFloor_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, 100689677);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleMovedFloorEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_RoomUtilityJobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleMovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_UpdatedEvent_CastleFloor_TilePosition_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(40)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.UpdatedEvent> UpdatedEventType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<CastleRoomWall> GetCastleWall;
      [FieldOffset(104)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(136)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(168)]
      public RoomUtility.GetNeighbourFloorsJobData RoomUtilityJobData;
      [FieldOffset(360)]
      public TileWorld TileWorld;
      [FieldOffset(384)]
      public SpatialLookupParams SpatialLookupParams;
      [FieldOffset(464)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128139, XrefRangeEnd = 1128149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1128160, RefRangeEnd = 1128161, XrefRangeStart = 1128149, XrefRangeEnd = 1128160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleMovedFloor(
        [In] ref Entity eventEntity,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.UpdatedEvent updatedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref eventEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref updatedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeMethodInfoPtr_HandleMovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_UpdatedEvent_CastleFloor_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleMovedFloorEventsJob()
      {
        Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (HandleMovedFloorEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr);
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (EntityType));
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_UpdatedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (UpdatedEventType));
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (GetCastleWall));
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (GetTilePosition));
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (GetTileData));
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_RoomUtilityJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (RoomUtilityJobData));
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (TileWorld));
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (SpatialLookupParams));
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, 100689678);
        CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob.NativeMethodInfoPtr_HandleMovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_UpdatedEvent_CastleFloor_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, 100689679);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedFloorEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleAddedWallEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AddedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleAddedWall_Private_Void_byref_EntityEvent_CastleRoomWall_TilePosition_byref_AddedEvent_CastleRoomWall_TilePosition_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.AddedEvent> AddedEventType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<CastleRoomWall> GetCastleWall;
      [FieldOffset(96)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(128)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(160)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(192)]
      public SpatialLookupParams SpatialLookupParams;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128161, XrefRangeEnd = 1128170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1128177, RefRangeEnd = 1128178, XrefRangeStart = 1128170, XrefRangeEnd = 1128177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleAddedWall(
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.AddedEvent addedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref addedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeMethodInfoPtr_HandleAddedWall_Private_Void_byref_EntityEvent_CastleRoomWall_TilePosition_byref_AddedEvent_CastleRoomWall_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleAddedWallEventsJob()
      {
        Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (HandleAddedWallEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr);
        CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_AddedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (AddedEventType));
        CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (GetCastleWall));
        CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (GetCastleFloor));
        CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (GetTilePosition));
        CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (GetTileData));
        CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (SpatialLookupParams));
        CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr, 100689680);
        CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob.NativeMethodInfoPtr_HandleAddedWall_Private_Void_byref_EntityEvent_CastleRoomWall_TilePosition_byref_AddedEvent_CastleRoomWall_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr, 100689681);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleAddedWallEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleRemovedWallEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemovedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleRemovedWall_Private_Void_byref_Entity_byref_EntityEvent_CastleRoomWall_TilePosition_byref_RemovedEvent_CastleRoomWall_TilePosition_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(40)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.RemovedEvent> RemovedEventType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(104)]
      public ComponentDataFromEntity<CastleRoomWall> GetCastleWall;
      [FieldOffset(136)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128178, XrefRangeEnd = 1128188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1128198, RefRangeEnd = 1128199, XrefRangeStart = 1128188, XrefRangeEnd = 1128198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleRemovedWall(
        [In] ref Entity eventEntity,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.RemovedEvent removedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref eventEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref removedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob.NativeMethodInfoPtr_HandleRemovedWall_Private_Void_byref_Entity_byref_EntityEvent_CastleRoomWall_TilePosition_byref_RemovedEvent_CastleRoomWall_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleRemovedWallEventsJob()
      {
        Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (HandleRemovedWallEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr);
        CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr, nameof (EntityType));
        CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob.NativeFieldInfoPtr_RemovedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr, nameof (RemovedEventType));
        CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr, nameof (GetCastleFloor));
        CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr, nameof (GetCastleWall));
        CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr, 100689682);
        CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob.NativeMethodInfoPtr_HandleRemovedWall_Private_Void_byref_Entity_byref_EntityEvent_CastleRoomWall_TilePosition_byref_RemovedEvent_CastleRoomWall_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr, 100689683);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleRemovedWallEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleMovedWallEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleMovedWall_Private_Void_byref_Entity_byref_EntityEvent_CastleRoomWall_TilePosition_byref_UpdatedEvent_CastleRoomWall_TilePosition_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(40)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.UpdatedEvent> UpdatedEventType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(104)]
      public ComponentDataFromEntity<CastleRoomWall> GetCastleWall;
      [FieldOffset(136)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(168)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(200)]
      public SpatialLookupParams SpatialLookupParams;
      [FieldOffset(280)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128199, XrefRangeEnd = 1128209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1128223, RefRangeEnd = 1128224, XrefRangeStart = 1128209, XrefRangeEnd = 1128223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleMovedWall(
        [In] ref Entity eventEntity,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.UpdatedEvent updatedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref eventEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref updatedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeMethodInfoPtr_HandleMovedWall_Private_Void_byref_Entity_byref_EntityEvent_CastleRoomWall_TilePosition_byref_UpdatedEvent_CastleRoomWall_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleMovedWallEventsJob()
      {
        Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem>.NativeClassPtr, nameof (HandleMovedWallEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr);
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (EntityType));
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_UpdatedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (UpdatedEventType));
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (GetCastleFloor));
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (GetCastleWall));
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (GetTilePosition));
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (GetTileData));
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (SpatialLookupParams));
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, 100689684);
        CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob.NativeMethodInfoPtr_HandleMovedWall_Private_Void_byref_Entity_byref_EntityEvent_CastleRoomWall_TilePosition_byref_UpdatedEvent_CastleRoomWall_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, 100689685);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleFloorAndWallsUpdateSystem.HandleMovedWallEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
