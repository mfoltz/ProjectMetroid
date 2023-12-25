// Decompiled with JetBrains decompiler
// Type: ProjectM.TileHeightSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
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
  public class TileHeightSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__DirtyTileBoundsManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075680, XrefRangeEnd = 1075696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileHeightSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075696, XrefRangeEnd = 1075735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileHeightSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileHeightSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileHeightSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileHeightSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileHeightSystem()
    {
      Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TileHeightSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr);
      TileHeightSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr, nameof (_TerrainManager));
      TileHeightSystem.NativeFieldInfoPtr__DirtyTileBoundsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr, nameof (_DirtyTileBoundsManager));
      TileHeightSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      TileHeightSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr, 100684716);
      TileHeightSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr, 100684717);
      TileHeightSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr, 100684718);
      TileHeightSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr, 100684719);
    }

    public TileHeightSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileHeightSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileHeightSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DirtyTileBoundsManager _DirtyTileBoundsManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileHeightSystem.NativeFieldInfoPtr__DirtyTileBoundsManager));
        return pointer == System.IntPtr.Zero ? (DirtyTileBoundsManager) null : new DirtyTileBoundsManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileHeightSystem.NativeFieldInfoPtr__DirtyTileBoundsManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileHeightSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileHeightSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateTileHeightJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetChunkTerrainHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetChunkBaseTerrainHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_DirtyWorldBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookup;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTerrainHeights_Private_Void_Entity_BufferFromEntity_1_ChunkBaseTerrainHeights_BufferFromEntity_1_ChunkTerrainHeights_Intersection_NativeList_1_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHeights_Private_Void_byref_TileDatas_1_TileHeightData_NativeArray_1_UInt16_TilePosition_BoundsMinMax_int2_Single_0;
      [FieldOffset(0)]
      public TerrainChunkLookup TerrainChunks;
      [FieldOffset(16)]
      public BufferFromEntity<ChunkTerrainHeights> GetChunkTerrainHeights;
      [FieldOffset(56)]
      public BufferFromEntity<ChunkBaseTerrainHeights> GetChunkBaseTerrainHeights;
      [FieldOffset(96)]
      public NativeList<BoundsMinMax> DirtyWorldBounds;
      [FieldOffset(112)]
      public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;
      [FieldOffset(144)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(176)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(208)]
      public SpatialLookupParams SpatialLookup;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075594, XrefRangeEnd = 1075610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileHeightSystem.UpdateTileHeightJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1075670, RefRangeEnd = 1075671, XrefRangeStart = 1075610, XrefRangeEnd = 1075670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateTerrainHeights(
        Entity chunkEntity,
        BufferFromEntity<ChunkBaseTerrainHeights> getBaseHeights,
        BufferFromEntity<ChunkTerrainHeights> getHeights,
        TerrainChunk.Intersection intersection,
        NativeList<Entity> spatialEntities)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &chunkEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getBaseHeights;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getHeights;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &intersection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &spatialEntities;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileHeightSystem.UpdateTileHeightJob.NativeMethodInfoPtr_UpdateTerrainHeights_Private_Void_Entity_BufferFromEntity_1_ChunkBaseTerrainHeights_BufferFromEntity_1_ChunkTerrainHeights_Intersection_NativeList_1_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1075679, RefRangeEnd = 1075680, XrefRangeStart = 1075671, XrefRangeEnd = 1075679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateHeights(
        ref TileDatas<TileHeightData> heightTiles,
        NativeArray<ushort> chunkHeights,
        TilePosition tilePosition,
        BoundsMinMax dirtyBounds,
        int2 chunkTileOffset,
        float entityHeight)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref heightTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkHeights;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dirtyBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkTileOffset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &entityHeight;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileHeightSystem.UpdateTileHeightJob.NativeMethodInfoPtr_UpdateHeights_Private_Void_byref_TileDatas_1_TileHeightData_NativeArray_1_UInt16_TilePosition_BoundsMinMax_int2_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateTileHeightJob()
      {
        Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileHeightSystem>.NativeClassPtr, nameof (UpdateTileHeightJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr);
        TileHeightSystem.UpdateTileHeightJob.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, nameof (TerrainChunks));
        TileHeightSystem.UpdateTileHeightJob.NativeFieldInfoPtr_GetChunkTerrainHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, nameof (GetChunkTerrainHeights));
        TileHeightSystem.UpdateTileHeightJob.NativeFieldInfoPtr_GetChunkBaseTerrainHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, nameof (GetChunkBaseTerrainHeights));
        TileHeightSystem.UpdateTileHeightJob.NativeFieldInfoPtr_DirtyWorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, nameof (DirtyWorldBounds));
        TileHeightSystem.UpdateTileHeightJob.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, nameof (GetLocalToWorld));
        TileHeightSystem.UpdateTileHeightJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, nameof (GetTileData));
        TileHeightSystem.UpdateTileHeightJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, nameof (GetTilePosition));
        TileHeightSystem.UpdateTileHeightJob.NativeFieldInfoPtr_SpatialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, nameof (SpatialLookup));
        TileHeightSystem.UpdateTileHeightJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, 100684720);
        TileHeightSystem.UpdateTileHeightJob.NativeMethodInfoPtr_UpdateTerrainHeights_Private_Void_Entity_BufferFromEntity_1_ChunkBaseTerrainHeights_BufferFromEntity_1_ChunkTerrainHeights_Intersection_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, 100684721);
        TileHeightSystem.UpdateTileHeightJob.NativeMethodInfoPtr_UpdateHeights_Private_Void_byref_TileDatas_1_TileHeightData_NativeArray_1_UInt16_TilePosition_BoundsMinMax_int2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, 100684722);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileHeightSystem.UpdateTileHeightJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
