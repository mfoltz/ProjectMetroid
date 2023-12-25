// Decompiled with JetBrains decompiler
// Type: ProjectM.ShowTilePlacementSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Terrain;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class ShowTilePlacementSystem : 
    DrawTileGridSystem<ShowTilePlacement, ShowTilePlacementSystem.GridIsActive>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__DrawQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetText_Private_Static_String_PrefabCollectionSystem_NativeQueue_1_HoverData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetChunkPlacementColor_Private_Static_Void_TilePosition_PrefabGUID_byref_TileDatas2dArray_1_PlacementData_BoundsMinMax_int2_ParallelWriter_HoverData_Instance_ShowTilePlacement_TerrainChunkIntersection_ShowTilePlacement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075243, XrefRangeEnd = 1075268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTilePlacementSystem.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075268, XrefRangeEnd = 1075344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTilePlacementSystem.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075344, XrefRangeEnd = 1075365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetText(
      PrefabCollectionSystem prefabCollectionSystem,
      NativeQueue<ShowTilePlacementSystem.HoverData> hoverDatas)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hoverDatas;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ShowTilePlacementSystem.NativeMethodInfoPtr_GetText_Private_Static_String_PrefabCollectionSystem_NativeQueue_1_HoverData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1075384, RefRangeEnd = 1075385, XrefRangeStart = 1075365, XrefRangeEnd = 1075384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetChunkPlacementColor(
      TilePosition tileModelPosition,
      PrefabGUID prefabGuid,
      ref TileDatas2dArray<PlacementData> placementTiles,
      BoundsMinMax tileModelWorldBounds,
      int2 mouseTile,
      NativeQueue<ShowTilePlacementSystem.HoverData>.ParallelWriter hoveredPlacementDatas,
      DrawTileGridJob<ShowTilePlacement>.Instance instanceData,
      DrawTileGridJob<ShowTilePlacement>.TerrainChunkIntersection intersection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &tileModelPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref placementTiles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelWorldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mouseTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hoveredPlacementDatas;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &instanceData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &intersection;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowTilePlacementSystem.NativeMethodInfoPtr_SetChunkPlacementColor_Private_Static_Void_TilePosition_PrefabGUID_byref_TileDatas2dArray_1_PlacementData_BoundsMinMax_int2_ParallelWriter_HoverData_Instance_ShowTilePlacement_TerrainChunkIntersection_ShowTilePlacement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075385, XrefRangeEnd = 1075388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShowTilePlacementSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowTilePlacementSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075388, XrefRangeEnd = 1075391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTilePlacementSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShowTilePlacementSystem()
    {
      Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShowTilePlacementSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr);
      ShowTilePlacementSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, nameof (_TerrainManager));
      ShowTilePlacementSystem.NativeFieldInfoPtr__DrawQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, nameof (_DrawQuery));
      ShowTilePlacementSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      ShowTilePlacementSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ShowTilePlacementSystem.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, 100684706);
      ShowTilePlacementSystem.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, 100684707);
      ShowTilePlacementSystem.NativeMethodInfoPtr_GetText_Private_Static_String_PrefabCollectionSystem_NativeQueue_1_HoverData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, 100684708);
      ShowTilePlacementSystem.NativeMethodInfoPtr_SetChunkPlacementColor_Private_Static_Void_TilePosition_PrefabGUID_byref_TileDatas2dArray_1_PlacementData_BoundsMinMax_int2_ParallelWriter_HoverData_Instance_ShowTilePlacement_TerrainChunkIntersection_ShowTilePlacement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, 100684709);
      ShowTilePlacementSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, 100684710);
      ShowTilePlacementSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, 100684711);
    }

    public ShowTilePlacementSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTilePlacementSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTilePlacementSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _DrawQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTilePlacementSystem.NativeFieldInfoPtr__DrawQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTilePlacementSystem.NativeFieldInfoPtr__DrawQuery)) = value;
      }
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTilePlacementSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTilePlacementSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTilePlacementSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTilePlacementSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GridIsActive
    {
      static GridIsActive()
      {
        Il2CppClassPointerStore<ShowTilePlacementSystem.GridIsActive>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, nameof (GridIsActive));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTilePlacementSystem.GridIsActive>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTilePlacementSystem.GridIsActive>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HoverData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementData;
      [FieldOffset(0)]
      public PrefabGUID PrefabGUID;
      [FieldOffset(8)]
      public PlacementData PlacementData;

      static HoverData()
      {
        Il2CppClassPointerStore<ShowTilePlacementSystem.HoverData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, nameof (HoverData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTilePlacementSystem.HoverData>.NativeClassPtr);
        ShowTilePlacementSystem.HoverData.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.HoverData>.NativeClassPtr, nameof (PrefabGUID));
        ShowTilePlacementSystem.HoverData.NativeFieldInfoPtr_PlacementData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.HoverData>.NativeClassPtr, nameof (PlacementData));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTilePlacementSystem.HoverData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ShowTilePlacementJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DrawGridJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPlacementTiles;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPlacementTilesBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_MergedPlacementJobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_MousePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_HoveredPlacementDatas;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public DrawTileGridJob<ShowTilePlacement> DrawGridJob;
      [FieldOffset(152)]
      public TerrainChunkLookup TerrainChunks;
      [FieldOffset(168)]
      public BufferFromEntity<BakedPlacementTiles> GetBakedPlacementTiles;
      [FieldOffset(208)]
      public BufferFromEntity<BakedPlacementTilesBounds> GetBakedPlacementTilesBounds;
      [FieldOffset(248)]
      public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;
      [FieldOffset(280)]
      public ComponentDataFromEntity<PrefabGUID> GetPrefabGUID;
      [FieldOffset(312)]
      public GetPlacementResult.MergedPlacementJobData MergedPlacementJobData;
      [FieldOffset(480)]
      public SpatialLookupParams SpatialLookupParams;
      [FieldOffset(560)]
      public float3 MousePosition;
      [FieldOffset(576)]
      public NativeQueue<ShowTilePlacementSystem.HoverData>.ParallelWriter HoveredPlacementDatas;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075134, XrefRangeEnd = 1075243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ShowTilePlacementSystem.ShowTilePlacementJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ShowTilePlacementJob()
      {
        Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTilePlacementSystem>.NativeClassPtr, nameof (ShowTilePlacementJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr);
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeFieldInfoPtr_DrawGridJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, nameof (DrawGridJob));
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, nameof (TerrainChunks));
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeFieldInfoPtr_GetBakedPlacementTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, nameof (GetBakedPlacementTiles));
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeFieldInfoPtr_GetBakedPlacementTilesBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, nameof (GetBakedPlacementTilesBounds));
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, nameof (GetLocalToWorld));
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeFieldInfoPtr_GetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, nameof (GetPrefabGUID));
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeFieldInfoPtr_MergedPlacementJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, nameof (MergedPlacementJobData));
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, nameof (SpatialLookupParams));
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeFieldInfoPtr_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, nameof (MousePosition));
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeFieldInfoPtr_HoveredPlacementDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, nameof (HoveredPlacementDatas));
        ShowTilePlacementSystem.ShowTilePlacementJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, 100684712);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTilePlacementSystem.ShowTilePlacementJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
