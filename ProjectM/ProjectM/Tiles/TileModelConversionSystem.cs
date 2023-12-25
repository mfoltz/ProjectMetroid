// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileModelConversionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public class TileModelConversionSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCacheTileData_Private_TileData_TileModelComponent_PrefabGUID_TileHeightsConversionSystem_Dictionary_2_PrefabGUID_TileData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMinMaxHeight_Public_Static_Void_TileModelComponent_byref_Single_byref_Single_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateTileBlobData_Public_Static_TileData_TileDataConversionData_TilePivotSettings_TileSnapType_Nullable_Unboxed_1_HeightPlacementConfig_BoundsMinMax_Single_Single_Boolean_PrefabGUID_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlobifyTileDataArray_Private_Static_Void_BlobBuilder_NativeList_1_DataStruct_TileDataType_TileType_byref_TileDatas_1_TileDataType_byref_TileType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlobifyTileDataArray2d_Private_Static_Void_BlobBuilder_NativeArray_1_TempDataStruct_TileDataType_BoundsMinMax_TileType_byref_TileDatas2dArray_1_TileDataType_byref_TileType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTileDataComponent_Private_TileDataConversionData_PrefabGUID_TileDatasComponent_TileHeightsConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBoundsForTiles_Private_Static_BoundsMinMax_NativeList_1_DataStruct_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddData_Private_Static_Void_NativeList_1_DataStruct_T_List_1_int2_ITileData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddData_Private_Static_Void_byref_NativeArray_1_TempDataStruct_T_BoundsMinMax_List_1_int2_ITileData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryExpandBounds_Private_Static_Void_byref_BoundsMinMax_List_1_int2_ITileData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddHeights_Private_Void_PrefabGUID_NativeList_1_DataStruct_TileHeightData_NativeList_1_DataStruct_TileHeightData_TileHeightsConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTileDataEntityComponents_Public_Static_Void_EntityManager_Entity_TileData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTagComponentIfExists_Public_Static_Void_EntityManager_Entity_TileType_TileType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRestrictionAreaBounds_Private_Static_BoundsMinMax_TileModelComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086649, XrefRangeEnd = 1086675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086720, RefRangeEnd = 1086721, XrefRangeStart = 1086675, XrefRangeEnd = 1086720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileData GetOrCacheTileData(
      TileModelComponent tileModelComponent,
      PrefabGUID prefabGuid,
      TileHeightsConversionSystem tileHeightConversion,
      Dictionary<PrefabGUID, TileData> tileDataBlobCache)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileModelComponent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileHeightConversion);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileDataBlobCache);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.NativeMethodInfoPtr_GetOrCacheTileData_Private_TileData_TileModelComponent_PrefabGUID_TileHeightsConversionSystem_Dictionary_2_PrefabGUID_TileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086721, XrefRangeEnd = 1086729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetMinMaxHeight(
      TileModelComponent tileModelComponent,
      out float minY,
      out float maxY,
      out bool multiLevelTileModel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileModelComponent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref minY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref maxY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref multiLevelTileModel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.NativeMethodInfoPtr_GetMinMaxHeight_Public_Static_Void_TileModelComponent_byref_Single_byref_Single_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086764, RefRangeEnd = 1086765, XrefRangeStart = 1086729, XrefRangeEnd = 1086764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileData CreateTileBlobData(
      TileModelConversionSystem.TileDataConversionData tileData,
      TilePivotSettings pivotSettings,
      TileSnapType snapType,
      Nullable_Unboxed<HeightPlacementConfig> heightPlacementConfig,
      BoundsMinMax restrictionAreaBounds,
      float minHeight,
      float maxHeight,
      bool multiLevelTileModel,
      PrefabGUID prefabGuid,
      Allocator tempAllocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &tileData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &snapType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightPlacementConfig;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictionAreaBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &minHeight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &maxHeight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &multiLevelTileModel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &tempAllocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.NativeMethodInfoPtr_CreateTileBlobData_Public_Static_TileData_TileDataConversionData_TilePivotSettings_TileSnapType_Nullable_Unboxed_1_HeightPlacementConfig_BoundsMinMax_Single_Single_Boolean_PrefabGUID_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086773, RefRangeEnd = 1086774, XrefRangeStart = 1086765, XrefRangeEnd = 1086773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void BlobifyTileDataArray<TileDataType>(
      BlobBuilder blobBuilder,
      NativeList<TileDatas<TileDataType>.DataStruct> tileDatas,
      ProjectM.TileType tileType,
      ref TileDatas<TileDataType> blobDataFieldRef,
      ref ProjectM.TileType allIncludedTileTypes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &blobBuilder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileDatas;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blobDataFieldRef;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref allIncludedTileTypes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.MethodInfoStoreGeneric_BlobifyTileDataArray_Private_Static_Void_BlobBuilder_NativeList_1_DataStruct_TileDataType_TileType_byref_TileDatas_1_TileDataType_byref_TileType_0<TileDataType>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086795, RefRangeEnd = 1086796, XrefRangeStart = 1086774, XrefRangeEnd = 1086795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void BlobifyTileDataArray2d<TileDataType>(
      BlobBuilder blobBuilder,
      NativeArray<TileDatas2dArray<TileDataType>.TempDataStruct> tileDatas,
      BoundsMinMax localBounds,
      ProjectM.TileType tileType,
      ref TileDatas2dArray<TileDataType> blobDataFieldRef,
      ref ProjectM.TileType allIncludedTileTypes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &blobBuilder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileDatas;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tileType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref blobDataFieldRef;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref allIncludedTileTypes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.MethodInfoStoreGeneric_BlobifyTileDataArray2d_Private_Static_Void_BlobBuilder_NativeArray_1_TempDataStruct_TileDataType_BoundsMinMax_TileType_byref_TileDatas2dArray_1_TileDataType_byref_TileType_0<TileDataType>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087051, RefRangeEnd = 1087052, XrefRangeStart = 1086796, XrefRangeEnd = 1087051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileModelConversionSystem.TileDataConversionData ConvertTileDataComponent(
      PrefabGUID prefabGuid,
      TileDatasComponent tileDatasComponent,
      TileHeightsConversionSystem tileHeightConversion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileDatasComponent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileHeightConversion);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.NativeMethodInfoPtr_ConvertTileDataComponent_Private_TileDataConversionData_PrefabGUID_TileDatasComponent_TileHeightsConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileModelConversionSystem.TileDataConversionData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087066, RefRangeEnd = 1087067, XrefRangeStart = 1087052, XrefRangeEnd = 1087066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax GetBoundsForTiles<T>(NativeList<TileDatas<T>.DataStruct> tiles)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tiles;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.MethodInfoStoreGeneric_GetBoundsForTiles_Private_Static_BoundsMinMax_NativeList_1_DataStruct_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087088, RefRangeEnd = 1087089, XrefRangeStart = 1087067, XrefRangeEnd = 1087088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryAddData<T>(
      NativeList<TileDatas<T>.DataStruct> result,
      List<int2> tiles,
      ITileData data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tiles);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.MethodInfoStoreGeneric_TryAddData_Private_Static_Void_NativeList_1_DataStruct_T_List_1_int2_ITileData_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087154, RefRangeEnd = 1087155, XrefRangeStart = 1087089, XrefRangeEnd = 1087154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryAddData<T>(
      ref NativeArray<TileDatas2dArray<T>.TempDataStruct> result,
      BoundsMinMax bounds,
      List<int2> tiles,
      ITileData data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tiles);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.MethodInfoStoreGeneric_TryAddData_Private_Static_Void_byref_NativeArray_1_TempDataStruct_T_BoundsMinMax_List_1_int2_ITileData_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087175, RefRangeEnd = 1087176, XrefRangeStart = 1087155, XrefRangeEnd = 1087175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryExpandBounds<T>(
      ref BoundsMinMax bounds,
      List<int2> tiles,
      ITileData data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tiles);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.MethodInfoStoreGeneric_TryExpandBounds_Private_Static_Void_byref_BoundsMinMax_List_1_int2_ITileData_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087176, XrefRangeEnd = 1087192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryAddHeights(
      PrefabGUID prefabGuid,
      NativeList<TileDatas<TileHeightData>.DataStruct> gameplayHeightTiles,
      NativeList<TileDatas<TileHeightData>.DataStruct> terrainHeightTiles,
      TileHeightsConversionSystem tileHeightConversion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayHeightTiles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainHeightTiles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileHeightConversion);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.NativeMethodInfoPtr_TryAddHeights_Private_Void_PrefabGUID_NativeList_1_DataStruct_TileHeightData_NativeList_1_DataStruct_TileHeightData_TileHeightsConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087237, RefRangeEnd = 1087238, XrefRangeStart = 1087192, XrefRangeEnd = 1087237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddTileDataEntityComponents(
      EntityManager entityManager,
      Entity entity,
      TileData tileData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.NativeMethodInfoPtr_AddTileDataEntityComponents_Public_Static_Void_EntityManager_Entity_TileData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1087239, RefRangeEnd = 1087246, XrefRangeStart = 1087238, XrefRangeEnd = 1087239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddTagComponentIfExists<TagComponent>(
      EntityManager entityManager,
      Entity entity,
      ProjectM.TileType allTileTypes,
      ProjectM.TileType expectedTileType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allTileTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &expectedTileType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.MethodInfoStoreGeneric_AddTagComponentIfExists_Public_Static_Void_EntityManager_Entity_TileType_TileType_0<TagComponent>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087246, XrefRangeEnd = 1087258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax GetRestrictionAreaBounds(TileModelComponent tileModelComponent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileModelComponent);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.NativeMethodInfoPtr_GetRestrictionAreaBounds_Private_Static_BoundsMinMax_TileModelComponent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileModelConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileModelConversionSystem()
    {
      Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileModelConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr);
      TileModelConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685573);
      TileModelConversionSystem.NativeMethodInfoPtr_GetOrCacheTileData_Private_TileData_TileModelComponent_PrefabGUID_TileHeightsConversionSystem_Dictionary_2_PrefabGUID_TileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685574);
      TileModelConversionSystem.NativeMethodInfoPtr_GetMinMaxHeight_Public_Static_Void_TileModelComponent_byref_Single_byref_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685575);
      TileModelConversionSystem.NativeMethodInfoPtr_CreateTileBlobData_Public_Static_TileData_TileDataConversionData_TilePivotSettings_TileSnapType_Nullable_Unboxed_1_HeightPlacementConfig_BoundsMinMax_Single_Single_Boolean_PrefabGUID_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685576);
      TileModelConversionSystem.NativeMethodInfoPtr_BlobifyTileDataArray_Private_Static_Void_BlobBuilder_NativeList_1_DataStruct_TileDataType_TileType_byref_TileDatas_1_TileDataType_byref_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685577);
      TileModelConversionSystem.NativeMethodInfoPtr_BlobifyTileDataArray2d_Private_Static_Void_BlobBuilder_NativeArray_1_TempDataStruct_TileDataType_BoundsMinMax_TileType_byref_TileDatas2dArray_1_TileDataType_byref_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685578);
      TileModelConversionSystem.NativeMethodInfoPtr_ConvertTileDataComponent_Private_TileDataConversionData_PrefabGUID_TileDatasComponent_TileHeightsConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685579);
      TileModelConversionSystem.NativeMethodInfoPtr_GetBoundsForTiles_Private_Static_BoundsMinMax_NativeList_1_DataStruct_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685580);
      TileModelConversionSystem.NativeMethodInfoPtr_TryAddData_Private_Static_Void_NativeList_1_DataStruct_T_List_1_int2_ITileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685581);
      TileModelConversionSystem.NativeMethodInfoPtr_TryAddData_Private_Static_Void_byref_NativeArray_1_TempDataStruct_T_BoundsMinMax_List_1_int2_ITileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685582);
      TileModelConversionSystem.NativeMethodInfoPtr_TryExpandBounds_Private_Static_Void_byref_BoundsMinMax_List_1_int2_ITileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685583);
      TileModelConversionSystem.NativeMethodInfoPtr_TryAddHeights_Private_Void_PrefabGUID_NativeList_1_DataStruct_TileHeightData_NativeList_1_DataStruct_TileHeightData_TileHeightsConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685584);
      TileModelConversionSystem.NativeMethodInfoPtr_AddTileDataEntityComponents_Public_Static_Void_EntityManager_Entity_TileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685585);
      TileModelConversionSystem.NativeMethodInfoPtr_AddTagComponentIfExists_Public_Static_Void_EntityManager_Entity_TileType_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685586);
      TileModelConversionSystem.NativeMethodInfoPtr_GetRestrictionAreaBounds_Private_Static_BoundsMinMax_TileModelComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685587);
      TileModelConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685588);
      TileModelConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, 100685589);
    }

    public TileModelConversionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TileDataConversionData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalTileDataBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileModelLayer;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionDatas2D;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_SurfaceFluffDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_LineOfSightTileDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_PathfindingTileDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameplayHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionLocalBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementLocalBounds;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_DisposeIfExists_Private_Void_byref_NativeList_1_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_DisposeIfExists_Private_Void_byref_NativeArray_1_T_0;
      [FieldOffset(0)]
      public BoundsMinMax TotalTileDataBounds;
      [FieldOffset(16)]
      public TileModelLayerEnum TileModelLayer;
      [FieldOffset(24)]
      public NativeList<TileDatas<ProjectM.CollisionData>.DataStruct> CollisionDatas;
      [FieldOffset(40)]
      public NativeArray<TileDatas2dArray<ProjectM.CollisionData>.TempDataStruct> CollisionDatas2D;
      [FieldOffset(56)]
      public NativeArray<TileDatas2dArray<PlacementData>.TempDataStruct> PlacementDatas;
      [FieldOffset(72)]
      public NativeList<TileDatas<SurfaceFluffData>.DataStruct> SurfaceFluffDatas;
      [FieldOffset(88)]
      public NativeList<TileDatas<LineOfSightTileData>.DataStruct> LineOfSightTileDatas;
      [FieldOffset(104)]
      public NativeList<TileDatas<PathfindingTileData>.DataStruct> PathfindingTileDatas;
      [FieldOffset(120)]
      public NativeList<TileDatas<TileHeightData>.DataStruct> GameplayHeights;
      [FieldOffset(136)]
      public NativeList<TileDatas<TileHeightData>.DataStruct> TerrainHeights;
      [FieldOffset(152)]
      public BoundsMinMax CollisionLocalBounds;
      [FieldOffset(168)]
      public BoundsMinMax PlacementLocalBounds;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1086627, RefRangeEnd = 1086628, XrefRangeStart = 1086604, XrefRangeEnd = 1086627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.TileDataConversionData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1086630, RefRangeEnd = 1086636, XrefRangeStart = 1086628, XrefRangeEnd = 1086630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void DisposeIfExists<T>(ref NativeList<T> list)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref list;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.TileDataConversionData.MethodInfoStoreGeneric_DisposeIfExists_Private_Void_byref_NativeList_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1086638, RefRangeEnd = 1086639, XrefRangeStart = 1086636, XrefRangeEnd = 1086638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void DisposeIfExists<T>(ref NativeArray<T> array)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref array;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.TileDataConversionData.MethodInfoStoreGeneric_DisposeIfExists_Private_Void_byref_NativeArray_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TileDataConversionData()
      {
        Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, nameof (TileDataConversionData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr);
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_TotalTileDataBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (TotalTileDataBounds));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_TileModelLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (TileModelLayer));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_CollisionDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (CollisionDatas));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_CollisionDatas2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (CollisionDatas2D));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_PlacementDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (PlacementDatas));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_SurfaceFluffDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (SurfaceFluffDatas));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_LineOfSightTileDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (LineOfSightTileDatas));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_PathfindingTileDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (PathfindingTileDatas));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_GameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (GameplayHeights));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_TerrainHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (TerrainHeights));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_CollisionLocalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (CollisionLocalBounds));
        TileModelConversionSystem.TileDataConversionData.NativeFieldInfoPtr_PlacementLocalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, nameof (PlacementLocalBounds));
        TileModelConversionSystem.TileDataConversionData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, 100685590);
        TileModelConversionSystem.TileDataConversionData.NativeMethodInfoPtr_DisposeIfExists_Private_Void_byref_NativeList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, 100685591);
        TileModelConversionSystem.TileDataConversionData.NativeMethodInfoPtr_DisposeIfExists_Private_Void_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, 100685592);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      private sealed class MethodInfoStoreGeneric_DisposeIfExists_Private_Void_byref_NativeList_1_T_0<T>
      {
        internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileModelConversionSystem.TileDataConversionData.NativeMethodInfoPtr_DisposeIfExists_Private_Void_byref_NativeList_1_T_0, Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))));
      }

      private sealed class MethodInfoStoreGeneric_DisposeIfExists_Private_Void_byref_NativeArray_1_T_0<T>
      {
        internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileModelConversionSystem.TileDataConversionData.NativeMethodInfoPtr_DisposeIfExists_Private_Void_byref_NativeArray_1_T_0, Il2CppClassPointerStore<TileModelConversionSystem.TileDataConversionData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))));
      }
    }

    [ObfuscatedName("ProjectM.Tiles.TileModelConversionSystem/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileHeightConversion;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileDataBlobCache;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_TileModelComponent_PrefabGuidComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileModelConversionSystem.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086639, XrefRangeEnd = 1086649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        TileModelComponent tileModelComponent,
        PrefabGuidComponent prefabGuidComponent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileModelComponent);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabGuidComponent);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileModelConversionSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_TileModelComponent_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<TileModelConversionSystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelConversionSystem.__c__DisplayClass0_0>.NativeClassPtr);
        TileModelConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
        TileModelConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_tileHeightConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (tileHeightConversion));
        TileModelConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_tileDataBlobCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelConversionSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (tileDataBlobCache));
        TileModelConversionSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem.__c__DisplayClass0_0>.NativeClassPtr, 100685593);
        TileModelConversionSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_TileModelComponent_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelConversionSystem.__c__DisplayClass0_0>.NativeClassPtr, 100685594);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe TileModelConversionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TileModelConversionSystem) null : new TileModelConversionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileModelConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TileHeightsConversionSystem tileHeightConversion
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_tileHeightConversion));
          return pointer == System.IntPtr.Zero ? (TileHeightsConversionSystem) null : new TileHeightsConversionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileModelConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_tileHeightConversion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<PrefabGUID, TileData> tileDataBlobCache
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_tileDataBlobCache));
          return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, TileData>) null : new Dictionary<PrefabGUID, TileData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileModelConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_tileDataBlobCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_BlobifyTileDataArray_Private_Static_Void_BlobBuilder_NativeList_1_DataStruct_TileDataType_TileType_byref_TileDatas_1_TileDataType_byref_TileType_0<TileDataType>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileModelConversionSystem.NativeMethodInfoPtr_BlobifyTileDataArray_Private_Static_Void_BlobBuilder_NativeList_1_DataStruct_TileDataType_TileType_byref_TileDatas_1_TileDataType_byref_TileType_0, Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TileDataType>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_BlobifyTileDataArray2d_Private_Static_Void_BlobBuilder_NativeArray_1_TempDataStruct_TileDataType_BoundsMinMax_TileType_byref_TileDatas2dArray_1_TileDataType_byref_TileType_0<TileDataType>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileModelConversionSystem.NativeMethodInfoPtr_BlobifyTileDataArray2d_Private_Static_Void_BlobBuilder_NativeArray_1_TempDataStruct_TileDataType_BoundsMinMax_TileType_byref_TileDatas2dArray_1_TileDataType_byref_TileType_0, Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TileDataType>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetBoundsForTiles_Private_Static_BoundsMinMax_NativeList_1_DataStruct_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileModelConversionSystem.NativeMethodInfoPtr_GetBoundsForTiles_Private_Static_BoundsMinMax_NativeList_1_DataStruct_T_0, Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryAddData_Private_Static_Void_NativeList_1_DataStruct_T_List_1_int2_ITileData_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileModelConversionSystem.NativeMethodInfoPtr_TryAddData_Private_Static_Void_NativeList_1_DataStruct_T_List_1_int2_ITileData_0, Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryAddData_Private_Static_Void_byref_NativeArray_1_TempDataStruct_T_BoundsMinMax_List_1_int2_ITileData_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileModelConversionSystem.NativeMethodInfoPtr_TryAddData_Private_Static_Void_byref_NativeArray_1_TempDataStruct_T_BoundsMinMax_List_1_int2_ITileData_0, Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryExpandBounds_Private_Static_Void_byref_BoundsMinMax_List_1_int2_ITileData_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileModelConversionSystem.NativeMethodInfoPtr_TryExpandBounds_Private_Static_Void_byref_BoundsMinMax_List_1_int2_ITileData_0, Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AddTagComponentIfExists_Public_Static_Void_EntityManager_Entity_TileType_TileType_0<TagComponent>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileModelConversionSystem.NativeMethodInfoPtr_AddTagComponentIfExists_Public_Static_Void_EntityManager_Entity_TileType_TileType_0, Il2CppClassPointerStore<TileModelConversionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TagComponent>.NativeClassPtr))
      }))));
    }
  }
}
