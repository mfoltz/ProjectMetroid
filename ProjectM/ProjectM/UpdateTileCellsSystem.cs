// Decompiled with JetBrains decompiler
// Type: ProjectM.UpdateTileCellsSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Pathfinding;
using ProjectM.Terrain;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class UpdateTileCellsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__DirtyTileBoundsManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentChunkLayerTracker;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultSurfaceLevelCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultNonSurfaceLevelCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_1;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_2;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateAndScheduleJob_Protected_Void_TileWorldWriteable_TerrainChunkLookup_NativeList_1_DirtyTileCell_SpatialLookupParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1077111, RefRangeEnd = 1077113, XrefRangeStart = 1077087, XrefRangeEnd = 1077111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateTileCellsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077113, XrefRangeEnd = 1077116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateTileCellsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1077154, RefRangeEnd = 1077157, XrefRangeStart = 1077116, XrefRangeEnd = 1077154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateAndScheduleJob(
      TileWorldWriteable tileWorldWriteable,
      TerrainChunkLookup terrainChunks,
      NativeList<DirtyTileCell> dirtyTileCells,
      SpatialLookupParams spatialLookup)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &tileWorldWriteable;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainChunks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dirtyTileCells;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &spatialLookup;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.NativeMethodInfoPtr_CreateAndScheduleJob_Protected_Void_TileWorldWriteable_TerrainChunkLookup_NativeList_1_DirtyTileCell_SpatialLookupParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateTileCellsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateTileCellsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateTileCellsSystem()
    {
      Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UpdateTileCellsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr);
      UpdateTileCellsSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (_TerrainManager));
      UpdateTileCellsSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      UpdateTileCellsSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      UpdateTileCellsSystem.NativeFieldInfoPtr__DirtyTileBoundsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (_DirtyTileBoundsManager));
      UpdateTileCellsSystem.NativeFieldInfoPtr__CurrentChunkLayerTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (_CurrentChunkLayerTracker));
      UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultSurfaceLevelCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (DefaultSurfaceLevelCollision));
      UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (DefaultNonSurfaceLevelCollision));
      UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (DefaultNonSurfaceLevelCollisionIndex_1));
      UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (DefaultNonSurfaceLevelCollisionIndex_2));
      UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (DefaultNonSurfaceLevelCollisionIndex_3));
      UpdateTileCellsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, 100684736);
      UpdateTileCellsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, 100684737);
      UpdateTileCellsSystem.NativeMethodInfoPtr_CreateAndScheduleJob_Protected_Void_TileWorldWriteable_TerrainChunkLookup_NativeList_1_DirtyTileCell_SpatialLookupParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, 100684738);
      UpdateTileCellsSystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, 100684739);
      UpdateTileCellsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, 100684741);
    }

    public UpdateTileCellsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DirtyTileBoundsManager _DirtyTileBoundsManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem.NativeFieldInfoPtr__DirtyTileBoundsManager));
        return pointer == System.IntPtr.Zero ? (DirtyTileBoundsManager) null : new DirtyTileBoundsManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem.NativeFieldInfoPtr__DirtyTileBoundsManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeArray<TileModelLayerEnum> _CurrentChunkLayerTracker
    {
      get
      {
        return *(NativeArray<TileModelLayerEnum>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem.NativeFieldInfoPtr__CurrentChunkLayerTracker));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem.NativeFieldInfoPtr__CurrentChunkLayerTracker), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<TileModelLayerEnum>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public static unsafe byte DefaultSurfaceLevelCollision
    {
      get
      {
        byte surfaceLevelCollision;
        IL2CPP.il2cpp_field_static_get_value(UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultSurfaceLevelCollision, (void*) &surfaceLevelCollision);
        return surfaceLevelCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultSurfaceLevelCollision, (void*) &value);
      }
    }

    public static unsafe byte DefaultNonSurfaceLevelCollision
    {
      get
      {
        byte surfaceLevelCollision;
        IL2CPP.il2cpp_field_static_get_value(UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollision, (void*) &surfaceLevelCollision);
        return surfaceLevelCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollision, (void*) &value);
      }
    }

    public static unsafe int DefaultNonSurfaceLevelCollisionIndex_1
    {
      get
      {
        int levelCollisionIndex1;
        IL2CPP.il2cpp_field_static_get_value(UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_1, (void*) &levelCollisionIndex1);
        return levelCollisionIndex1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_1, (void*) &value);
      }
    }

    public static unsafe int DefaultNonSurfaceLevelCollisionIndex_2
    {
      get
      {
        int levelCollisionIndex2;
        IL2CPP.il2cpp_field_static_get_value(UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_2, (void*) &levelCollisionIndex2);
        return levelCollisionIndex2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_2, (void*) &value);
      }
    }

    public static unsafe int DefaultNonSurfaceLevelCollisionIndex_3
    {
      get
      {
        int levelCollisionIndex3;
        IL2CPP.il2cpp_field_static_get_value(UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_3, (void*) &levelCollisionIndex3);
        return levelCollisionIndex3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UpdateTileCellsSystem.NativeFieldInfoPtr_DefaultNonSurfaceLevelCollisionIndex_3, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct JobProfilerMarkers
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdateCell;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrepareCell;
      private static readonly System.IntPtr NativeFieldInfoPtr_Heights;
      private static readonly System.IntPtr NativeFieldInfoPtr_MinMaxHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_Collision;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticCollision1;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticCollision2;
      private static readonly System.IntPtr NativeFieldInfoPtr_LineOfSight;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticLineOfSight;
      private static readonly System.IntPtr NativeFieldInfoPtr_Pathfinding;
      private static readonly System.IntPtr NativeFieldInfoPtr_Pathfinding_Static;
      private static readonly System.IntPtr NativeFieldInfoPtr_Pathfinding_FindPortals;
      private static readonly System.IntPtr NativeFieldInfoPtr_Pathfinding_Expand;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_JobProfilerMarkers_0;
      [FieldOffset(0)]
      public ProfilerMarker UpdateCell;
      [FieldOffset(8)]
      public ProfilerMarker PrepareCell;
      [FieldOffset(16)]
      public ProfilerMarker Heights;
      [FieldOffset(24)]
      public ProfilerMarker MinMaxHeights;
      [FieldOffset(32)]
      public ProfilerMarker Collision;
      [FieldOffset(40)]
      public ProfilerMarker StaticCollision;
      [FieldOffset(48)]
      public ProfilerMarker StaticCollision1;
      [FieldOffset(56)]
      public ProfilerMarker StaticCollision2;
      [FieldOffset(64)]
      public ProfilerMarker LineOfSight;
      [FieldOffset(72)]
      public ProfilerMarker StaticLineOfSight;
      [FieldOffset(80)]
      public ProfilerMarker Pathfinding;
      [FieldOffset(88)]
      public ProfilerMarker Pathfinding_Static;
      [FieldOffset(96)]
      public ProfilerMarker Pathfinding_FindPortals;
      [FieldOffset(104)]
      public ProfilerMarker Pathfinding_Expand;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1075981, RefRangeEnd = 1075982, XrefRangeStart = 1075939, XrefRangeEnd = 1075981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe UpdateTileCellsSystem.JobProfilerMarkers Create()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.JobProfilerMarkers.NativeMethodInfoPtr_Create_Public_Static_JobProfilerMarkers_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(UpdateTileCellsSystem.JobProfilerMarkers*) IL2CPP.il2cpp_object_unbox(num);
      }

      static JobProfilerMarkers()
      {
        Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (JobProfilerMarkers));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr);
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_UpdateCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (UpdateCell));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_PrepareCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (PrepareCell));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_Heights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (Heights));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_MinMaxHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (MinMaxHeights));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_Collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (Collision));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_StaticCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (StaticCollision));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_StaticCollision1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (StaticCollision1));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_StaticCollision2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (StaticCollision2));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_LineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (LineOfSight));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_StaticLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (StaticLineOfSight));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_Pathfinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (Pathfinding));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_Pathfinding_Static = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (Pathfinding_Static));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_Pathfinding_FindPortals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (Pathfinding_FindPortals));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeFieldInfoPtr_Pathfinding_Expand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, nameof (Pathfinding_Expand));
        UpdateTileCellsSystem.JobProfilerMarkers.NativeMethodInfoPtr_Create_Public_Static_JobProfilerMarkers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, 100684742);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateTileCellsSystem.JobProfilerMarkers>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateCellsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_DirtyTileCells;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileModel;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsServer;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProfilerMarkers;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentChunkLayerTracker;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedChunkCells;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetChunkBaseGameplayHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedTileCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedTileCollisionBoundsBlobRef;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedLineOfSightTiles;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedLineOfSightTileDataBoundsRef;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPathfindingTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPathfindingTileDataBoundsRef;
      private static readonly System.IntPtr NativeFieldInfoPtr_StandardLayerFlags_IsGroundedIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_StandardLayerFlags_BlockBuildingIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_CellBasedMask_CollideFlyMovementIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_CellBasedMask_WalkableMaskIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_DoExecute_Private_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_InitializeCell_Private_Void_byref_CellMaskBuilder_byref_CellData_TileCell_byref_TerrainCache_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetStaticLevelRange_Private_Static_Void_TileCell_int2_PrefabGUID_Byte_StaticTileModelData_byref_Int32_byref_Int32_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BuildDynamicEntitiesPerLayer_Private_Static_Void_NativeList_1_TileModelSpatialEntity_byref_TileModelLayerArrayInfo_byref_NativeArray_1_TileModelSpatialEntity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTerrainCache_Private_Void_byref_TerrainCache_BoundsMinMax_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeMaskBuilder_Private_Static_Int32_byref_CellMaskBuilder_TileCellMaskType_Int32_Nullable_Unboxed_1_TileLayerIndex_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StoreStaticMasksAndResetCell_Private_Static_Void_byref_CellMaskBuilder_byref_TileCell_TileType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCellBasedMasks_Private_Static_Void_TileCell_TileCellCoordinate_byref_CellMaskBuilder_byref_TerrainCache_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeNewCellMaskArray_Private_Static_Void_byref_CellMaskBuilder_byref_TileCell_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCellCollision_Private_Void_TileCell_byref_CellData_byref_TerrainCache_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeCollisionCellMaskBuilder_Private_Static_Void_byref_TileCell_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ClearCollisionTiles_Private_Static_Void_TileCell_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTerrainCache_Collision_Private_Void_byref_TerrainCache_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteStaticCollisionInCell_Private_Void_TileCell_TileModelLayerEnum_byref_TerrainCache_byref_CellData_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteDynamicEntitiesInCell_Private_Void_TileCell_TileModelLayerEnum_byref_CellData_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteDynamicCollision_Private_Void_TilePosition_byref_TileDatas_1_CollisionData_TileModelLayerEnum_BoundsMinMax_TileLayerIndex_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteStaticCollision_Private_Void_TilePosition_byref_TileDatas2dArray_1_CollisionData_NativeArray_1_TileModelLayerEnum_TileModelLayerEnum_BoundsMinMax_NativeSlice_1_BitMask2D_16x16_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteCollisionTile_Private_Static_Void_TileModelLayerEnum_int2_MapCollisionFlags_NativeArray_1_TileModelLayerEnum_NativeSlice_1_BitMask2D_16x16_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCellHeights_Private_Void_TileCell_byref_CellData_byref_TerrainCache_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTerrainCache_Heights_Private_Void_byref_TerrainCache_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHeights_Private_Void_TileCell_byref_CellData_byref_TerrainCache_NativeArray_1_UInt16_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ResetCellHeights_Private_Static_Void_TileCell_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteStaticBakedHeight_Private_Static_TileCellGameplayHeights_NativeArray_1_UInt16_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteDynamicEntityCellHeights_Private_Static_Void_byref_TileDatas_1_TileHeightData_TilePosition_BoundsMinMax_Single_byref_TileCellGameplayHeights_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCellLineOfSight_Private_Void_TileCell_byref_CellData_byref_TerrainCache_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeLineOfSightCellMaskBuilder_Private_Static_Void_byref_TileCell_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTerrainCache_LineOfSight_Private_Void_byref_TerrainCache_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteStaticLineOfSightInCell_Private_Void_TileCell_TileModelLayerEnum_byref_TerrainCache_byref_CellData_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteStaticLineOfSight_Private_Void_TilePosition_byref_TileDatas_1_LineOfSightTileData_NativeArray_1_TileModelLayerEnum_TileModelLayerEnum_int2_BoundsMinMax_NativeSlice_1_BitMask2D_16x16_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteDynamicLineOfSightInCell_Private_Void_TileCell_TileModelLayerEnum_byref_CellData_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteDynamicLineOfSight_Private_Void_TileCell_TilePosition_byref_TileDatas_1_LineOfSightTileData_TileModelLayerEnum_int2_BoundsMinMax_TileLayerIndex_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteTile_Private_Static_Void_TileModelLayerEnum_int2_LineOfSightTileFlags_NativeArray_1_TileModelLayerEnum_NativeSlice_1_BitMask2D_16x16_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCellPathfinding_Private_Void_TileCell_byref_CellData_byref_TerrainCache_byref_CellMaskBuilder_byref_NativeHashSet_1_TileCellCoordinate_byref_TileWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddCellToExpandIfValid_Private_Static_Void_TileCellCoordinate_byref_NativeHashSet_1_TileCellCoordinate_byref_TileWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTerrainCache_Pathfinding_Private_Void_byref_TerrainCache_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ClearPathfindingTiles_Private_Static_Void_TileCell_byref_CellMaskBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteStaticPathfindingInCell_Private_Void_TileCell_TileModelLayerEnum_byref_TerrainCache_byref_CellData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteStaticPathfinding_Private_Void_NativeArray_1_PathfindingTile_TilePosition_byref_TileDatas_1_PathfindingTileData_NativeArray_1_TileModelLayerEnum_TileModelLayerEnum_int2_BoundsMinMax_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteDynamicPathfindingInCell_Private_Void_TileCell_TileModelLayerEnum_byref_CellData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteDynamicPathfinding_Private_Void_TileCell_TilePosition_byref_TileDatas_1_PathfindingTileData_TileModelLayerEnum_int2_BoundsMinMax_TileLayerIndex_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteTile_Private_Static_Void_NativeArray_1_PathfindingTile_TileModelLayerEnum_int2_PathfindingTileData_NativeArray_1_TileModelLayerEnum_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TerrainTypeToPathfindingTile_Private_Static_PathfindingTile_TerrainType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FindPortals_Private_Void_TileCell_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandPathfinding_Private_Void_NativeHashSet_1_TileCellCoordinate_byref_TileWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetPathfindingTilesOrDefault_Private_Static_NativeArray_1_PathfindingTile_TileCellCoordinate_byref_TileWorld_Byte_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref_CellMaskBuilder_TileCell_TileLayer_TileLayerIndex_TileCellMaskType_Int32_0;
      [FieldOffset(0)]
      public TileWorldWriteable TileWorld;
      [FieldOffset(24)]
      public TerrainChunkLookup TerrainChunks;
      [FieldOffset(40)]
      public NativeList<DirtyTileCell> DirtyTileCells;
      [FieldOffset(56)]
      public ComponentDataFromEntity<TileModel> GetTileModel;
      [FieldOffset(88)]
      public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;
      [FieldOffset(120)]
      public bool IsServer;
      [FieldOffset(128)]
      public SpatialLookupParams SpatialLookup;
      [FieldOffset(208)]
      public UpdateTileCellsSystem.JobProfilerMarkers ProfilerMarkers;
      [FieldOffset(320)]
      public NativeArray<TileModelLayerEnum> CurrentChunkLayerTracker;
      [FieldOffset(336)]
      public ComponentDataFromEntity<BakedChunkCells> GetBakedChunkCells;
      [FieldOffset(368)]
      public BufferFromEntity<ChunkBaseGameplayHeights> GetChunkBaseGameplayHeights;
      [FieldOffset(408)]
      public BufferFromEntity<BakedCollisionTiles> GetBakedTileCollision;
      [FieldOffset(448)]
      public ComponentDataFromEntity<BakedCollisionTilesBoundsRef> GetBakedTileCollisionBoundsBlobRef;
      [FieldOffset(480)]
      public BufferFromEntity<BakedLineOfSightTiles> GetBakedLineOfSightTiles;
      [FieldOffset(520)]
      public ComponentDataFromEntity<BakedLineOfSightTileDataBoundsRef> GetBakedLineOfSightTileDataBoundsRef;
      [FieldOffset(552)]
      public BufferFromEntity<BakedPathfindingTileData> GetBakedPathfindingTileData;
      [FieldOffset(592)]
      public ComponentDataFromEntity<BakedPathfindingTileDataBoundsRef> GetBakedPathfindingTileDataBoundsRef;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076060, XrefRangeEnd = 1076061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076134, RefRangeEnd = 1076135, XrefRangeStart = 1076061, XrefRangeEnd = 1076134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void DoExecute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_DoExecute_Private_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076179, RefRangeEnd = 1076180, XrefRangeStart = 1076135, XrefRangeEnd = 1076179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void InitializeCell(
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder builderContext,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData,
        TileCell cell,
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref builderContext;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainCache;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_InitializeCell_Private_Void_byref_CellMaskBuilder_byref_CellData_TileCell_byref_TerrainCache_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1076190, RefRangeEnd = 1076193, XrefRangeStart = 1076180, XrefRangeEnd = 1076190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void GetStaticLevelRange(
        TileCell cell,
        int2 worldTile,
        PrefabGUID prefabGuid,
        byte heightLevel,
        StaticTileModelData staticData,
        out int startLayer,
        out int count,
        bool log = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldTile;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &staticData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref startLayer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref count;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &log;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_GetStaticLevelRange_Private_Static_Void_TileCell_int2_PrefabGUID_Byte_StaticTileModelData_byref_Int32_byref_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076213, RefRangeEnd = 1076214, XrefRangeStart = 1076193, XrefRangeEnd = 1076213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void BuildDynamicEntitiesPerLayer(
        NativeList<TileModelSpatialEntity> dynamicEntityList,
        out TileModelLayerArrayInfo dynamicLayerLocations,
        out NativeArray<TileModelSpatialEntity> dynamicEntitiesByLayer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &dynamicEntityList;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dynamicLayerLocations;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref dynamicEntitiesByLayer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_BuildDynamicEntitiesPerLayer_Private_Static_Void_NativeList_1_TileModelSpatialEntity_byref_TileModelLayerArrayInfo_byref_NativeArray_1_TileModelSpatialEntity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076231, RefRangeEnd = 1076232, XrefRangeStart = 1076214, XrefRangeEnd = 1076231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateTerrainCache(
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache,
        BoundsMinMax cellWorldBounds)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref terrainCache;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellWorldBounds;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateTerrainCache_Private_Void_byref_TerrainCache_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1076246, RefRangeEnd = 1076249, XrefRangeStart = 1076232, XrefRangeEnd = 1076246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe int FinalizeMaskBuilder(
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder,
        TileCellMaskType enumType,
        int enumFlagCount,
        Nullable_Unboxed<TileLayerIndex> tileLayerIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref cellMaskBuilder;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &enumType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &enumFlagCount;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayerIndex;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_FinalizeMaskBuilder_Private_Static_Int32_byref_CellMaskBuilder_TileCellMaskType_Int32_Nullable_Unboxed_1_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076273, RefRangeEnd = 1076274, XrefRangeStart = 1076249, XrefRangeEnd = 1076273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void StoreStaticMasksAndResetCell(
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder maskBuilder,
        [In] ref TileCell tileCell,
        TileType dirtyTileTypes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref maskBuilder;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dirtyTileTypes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_StoreStaticMasksAndResetCell_Private_Static_Void_byref_CellMaskBuilder_byref_TileCell_TileType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076302, RefRangeEnd = 1076303, XrefRangeStart = 1076274, XrefRangeEnd = 1076302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void UpdateCellBasedMasks(
        TileCell cell,
        TileCellCoordinate worldCellCoord,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder,
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldCellCoord;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainCache;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateCellBasedMasks_Private_Static_Void_TileCell_TileCellCoordinate_byref_CellMaskBuilder_byref_TerrainCache_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076374, RefRangeEnd = 1076375, XrefRangeStart = 1076303, XrefRangeEnd = 1076374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void FinalizeNewCellMaskArray(
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder maskBuilder,
        [In] ref TileCell cell)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref maskBuilder;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cell;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_FinalizeNewCellMaskArray_Private_Static_Void_byref_CellMaskBuilder_byref_TileCell_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076394, RefRangeEnd = 1076395, XrefRangeStart = 1076375, XrefRangeEnd = 1076394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateCellCollision(
        TileCell cell,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData,
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainCache;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateCellCollision_Private_Void_TileCell_byref_CellData_byref_TerrainCache_byref_CellMaskBuilder_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076413, RefRangeEnd = 1076414, XrefRangeStart = 1076395, XrefRangeEnd = 1076413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void FinalizeCollisionCellMaskBuilder(
        [In] ref TileCell cell,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_FinalizeCollisionCellMaskBuilder_Private_Static_Void_byref_TileCell_byref_CellMaskBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076447, RefRangeEnd = 1076448, XrefRangeStart = 1076414, XrefRangeEnd = 1076447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void ClearCollisionTiles(
        TileCell cell,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_ClearCollisionTiles_Private_Static_Void_TileCell_byref_CellMaskBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076463, RefRangeEnd = 1076464, XrefRangeStart = 1076448, XrefRangeEnd = 1076463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateTerrainCache_Collision(
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref terrainCache;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateTerrainCache_Collision_Private_Void_byref_TerrainCache_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1076513, RefRangeEnd = 1076517, XrefRangeStart = 1076464, XrefRangeEnd = 1076513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteStaticCollisionInCell(
        TileCell cell,
        TileModelLayerEnum layer,
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainCache;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticCollisionInCell_Private_Void_TileCell_TileModelLayerEnum_byref_TerrainCache_byref_CellData_byref_CellMaskBuilder_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1076529, RefRangeEnd = 1076533, XrefRangeStart = 1076517, XrefRangeEnd = 1076529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteDynamicEntitiesInCell(
        TileCell cell,
        TileModelLayerEnum layer,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicEntitiesInCell_Private_Void_TileCell_TileModelLayerEnum_byref_CellData_byref_CellMaskBuilder_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076552, RefRangeEnd = 1076553, XrefRangeStart = 1076533, XrefRangeEnd = 1076552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteDynamicCollision(
        TilePosition tileModelTilePosition,
        ref TileDatas<CollisionData> collisionTiles,
        TileModelLayerEnum layer,
        BoundsMinMax cellWorldBounds,
        TileLayerIndex tileLayerIndex,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &tileModelTilePosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &cellWorldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayerIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicCollision_Private_Void_TilePosition_byref_TileDatas_1_CollisionData_TileModelLayerEnum_BoundsMinMax_TileLayerIndex_byref_CellMaskBuilder_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076566, RefRangeEnd = 1076567, XrefRangeStart = 1076553, XrefRangeEnd = 1076566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteStaticCollision(
        TilePosition tileModelTilePosition,
        ref TileDatas2dArray<CollisionData> collisionTiles,
        NativeArray<TileModelLayerEnum> layerTracker,
        TileModelLayerEnum layer,
        BoundsMinMax cellWorldBounds,
        NativeSlice<BitMask2D_16x16> layerMasks)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &tileModelTilePosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &layerTracker;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &cellWorldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMasks;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticCollision_Private_Void_TilePosition_byref_TileDatas2dArray_1_CollisionData_NativeArray_1_TileModelLayerEnum_TileModelLayerEnum_BoundsMinMax_NativeSlice_1_BitMask2D_16x16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1076574, RefRangeEnd = 1076576, XrefRangeStart = 1076567, XrefRangeEnd = 1076574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void WriteCollisionTile(
        TileModelLayerEnum layer,
        int2 localCellTile,
        MapCollisionFlags collisionFlags,
        NativeArray<TileModelLayerEnum> layerTracker,
        NativeSlice<BitMask2D_16x16> layerMasks)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localCellTile;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFlags;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layerTracker;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMasks;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteCollisionTile_Private_Static_Void_TileModelLayerEnum_int2_MapCollisionFlags_NativeArray_1_TileModelLayerEnum_NativeSlice_1_BitMask2D_16x16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076591, RefRangeEnd = 1076592, XrefRangeStart = 1076576, XrefRangeEnd = 1076591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateCellHeights(
        TileCell cell,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData,
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainCache;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateCellHeights_Private_Void_TileCell_byref_CellData_byref_TerrainCache_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076604, RefRangeEnd = 1076605, XrefRangeStart = 1076592, XrefRangeEnd = 1076604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateTerrainCache_Heights(
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref terrainCache;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateTerrainCache_Heights_Private_Void_byref_TerrainCache_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076659, RefRangeEnd = 1076660, XrefRangeStart = 1076605, XrefRangeEnd = 1076659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateHeights(
        TileCell cell,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData,
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache,
        NativeArray<ushort> chunkBaseHeights)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainCache;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkBaseHeights;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateHeights_Private_Void_TileCell_byref_CellData_byref_TerrainCache_NativeArray_1_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076673, RefRangeEnd = 1076674, XrefRangeStart = 1076660, XrefRangeEnd = 1076673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void ResetCellHeights(TileCell cell)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &cell;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_ResetCellHeights_Private_Static_Void_TileCell_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076684, RefRangeEnd = 1076685, XrefRangeStart = 1076674, XrefRangeEnd = 1076684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe TileCellGameplayHeights WriteStaticBakedHeight(
        NativeArray<ushort> chunkBaseHeights,
        int2 cellChunkTileOffset)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunkBaseHeights;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellChunkTileOffset;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticBakedHeight_Private_Static_TileCellGameplayHeights_NativeArray_1_UInt16_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TileCellGameplayHeights*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076692, RefRangeEnd = 1076693, XrefRangeStart = 1076685, XrefRangeEnd = 1076692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void WriteDynamicEntityCellHeights(
        ref TileDatas<TileHeightData> entityHeightTiles,
        TilePosition tilePosition,
        BoundsMinMax cellWorldBounds,
        float entityWorldPosY,
        ref TileCellGameplayHeights layerHeights)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref entityHeightTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cellWorldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityWorldPosY;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref layerHeights;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicEntityCellHeights_Private_Static_Void_byref_TileDatas_1_TileHeightData_TilePosition_BoundsMinMax_Single_byref_TileCellGameplayHeights_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076711, RefRangeEnd = 1076712, XrefRangeStart = 1076693, XrefRangeEnd = 1076711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateCellLineOfSight(
        TileCell cell,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData,
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainCache;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateCellLineOfSight_Private_Void_TileCell_byref_CellData_byref_TerrainCache_byref_CellMaskBuilder_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076730, RefRangeEnd = 1076731, XrefRangeStart = 1076712, XrefRangeEnd = 1076730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void FinalizeLineOfSightCellMaskBuilder(
        [In] ref TileCell cell,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_FinalizeLineOfSightCellMaskBuilder_Private_Static_Void_byref_TileCell_byref_CellMaskBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076746, RefRangeEnd = 1076747, XrefRangeStart = 1076731, XrefRangeEnd = 1076746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateTerrainCache_LineOfSight(
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref terrainCache;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateTerrainCache_LineOfSight_Private_Void_byref_TerrainCache_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1076782, RefRangeEnd = 1076786, XrefRangeStart = 1076747, XrefRangeEnd = 1076782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteStaticLineOfSightInCell(
        TileCell cell,
        TileModelLayerEnum layer,
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainCache;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticLineOfSightInCell_Private_Void_TileCell_TileModelLayerEnum_byref_TerrainCache_byref_CellData_byref_CellMaskBuilder_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076796, RefRangeEnd = 1076797, XrefRangeStart = 1076786, XrefRangeEnd = 1076796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteStaticLineOfSight(
        TilePosition tileModelTilePosition,
        ref TileDatas<LineOfSightTileData> lineOfSightTiles,
        NativeArray<TileModelLayerEnum> layerTracker,
        TileModelLayerEnum layer,
        int2 cellWorldTileOffset,
        BoundsMinMax intersectedCellWorldBounds,
        NativeSlice<BitMask2D_16x16> layerMasks)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &tileModelTilePosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lineOfSightTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &layerTracker;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &cellWorldTileOffset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &intersectedCellWorldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMasks;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticLineOfSight_Private_Void_TilePosition_byref_TileDatas_1_LineOfSightTileData_NativeArray_1_TileModelLayerEnum_TileModelLayerEnum_int2_BoundsMinMax_NativeSlice_1_BitMask2D_16x16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1076810, RefRangeEnd = 1076814, XrefRangeStart = 1076797, XrefRangeEnd = 1076810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteDynamicLineOfSightInCell(
        TileCell cell,
        TileModelLayerEnum layer,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicLineOfSightInCell_Private_Void_TileCell_TileModelLayerEnum_byref_CellData_byref_CellMaskBuilder_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076833, RefRangeEnd = 1076834, XrefRangeStart = 1076814, XrefRangeEnd = 1076833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteDynamicLineOfSight(
        TileCell cell,
        TilePosition tileModelTilePosition,
        ref TileDatas<LineOfSightTileData> lineOfSightTiles,
        TileModelLayerEnum layer,
        int2 cellWorldTileOffset,
        BoundsMinMax intersectedCellWorldBounds,
        TileLayerIndex tileLayer,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelTilePosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lineOfSightTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &cellWorldTileOffset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &intersectedCellWorldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicLineOfSight_Private_Void_TileCell_TilePosition_byref_TileDatas_1_LineOfSightTileData_TileModelLayerEnum_int2_BoundsMinMax_TileLayerIndex_byref_CellMaskBuilder_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1076841, RefRangeEnd = 1076843, XrefRangeStart = 1076834, XrefRangeEnd = 1076841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void WriteTile(
        TileModelLayerEnum layer,
        int2 localCellTile,
        LineOfSightTileFlags lineOfSightFlags,
        NativeArray<TileModelLayerEnum> layerTracker,
        NativeSlice<BitMask2D_16x16> layerMasks)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localCellTile;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lineOfSightFlags;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layerTracker;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMasks;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteTile_Private_Static_Void_TileModelLayerEnum_int2_LineOfSightTileFlags_NativeArray_1_TileModelLayerEnum_NativeSlice_1_BitMask2D_16x16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076871, RefRangeEnd = 1076872, XrefRangeStart = 1076843, XrefRangeEnd = 1076871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateCellPathfinding(
        TileCell cell,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData,
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder,
        ref NativeHashSet<TileCellCoordinate> cellsToExpandPathfindingFor,
        ref TileWorld tileWorld)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainCache;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellsToExpandPathfindingFor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateCellPathfinding_Private_Void_TileCell_byref_CellData_byref_TerrainCache_byref_CellMaskBuilder_byref_NativeHashSet_1_TileCellCoordinate_byref_TileWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1076876, RefRangeEnd = 1076880, XrefRangeStart = 1076872, XrefRangeEnd = 1076876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void AddCellToExpandIfValid(
        TileCellCoordinate coord,
        ref NativeHashSet<TileCellCoordinate> cellsToExpandPathfindingFor,
        ref TileWorld tileWorld)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &coord;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellsToExpandPathfindingFor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_AddCellToExpandIfValid_Private_Static_Void_TileCellCoordinate_byref_NativeHashSet_1_TileCellCoordinate_byref_TileWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076895, RefRangeEnd = 1076896, XrefRangeStart = 1076880, XrefRangeEnd = 1076895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateTerrainCache_Pathfinding(
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref terrainCache;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateTerrainCache_Pathfinding_Private_Void_byref_TerrainCache_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076906, RefRangeEnd = 1076907, XrefRangeStart = 1076896, XrefRangeEnd = 1076906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void ClearPathfindingTiles(
        TileCell cell,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder cellMaskBuilder)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellMaskBuilder;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_ClearPathfindingTiles_Private_Static_Void_TileCell_byref_CellMaskBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1076948, RefRangeEnd = 1076952, XrefRangeStart = 1076907, XrefRangeEnd = 1076948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteStaticPathfindingInCell(
        TileCell cell,
        TileModelLayerEnum layer,
        ref UpdateTileCellsSystem.UpdateCellsJob.TerrainCache terrainCache,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainCache;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticPathfindingInCell_Private_Void_TileCell_TileModelLayerEnum_byref_TerrainCache_byref_CellData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076962, RefRangeEnd = 1076963, XrefRangeStart = 1076952, XrefRangeEnd = 1076962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteStaticPathfinding(
        NativeArray<PathfindingTile> pathfindingTiles,
        TilePosition tileModelTilePosition,
        ref TileDatas<PathfindingTileData> tileModelPathfindingTiles,
        NativeArray<TileModelLayerEnum> layerTracker,
        TileModelLayerEnum layer,
        int2 cellWorldTileOffset,
        BoundsMinMax intersectedCellWorldBounds)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &pathfindingTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelTilePosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileModelPathfindingTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layerTracker;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &cellWorldTileOffset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &intersectedCellWorldBounds;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticPathfinding_Private_Void_NativeArray_1_PathfindingTile_TilePosition_byref_TileDatas_1_PathfindingTileData_NativeArray_1_TileModelLayerEnum_TileModelLayerEnum_int2_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1076976, RefRangeEnd = 1076980, XrefRangeStart = 1076963, XrefRangeEnd = 1076976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteDynamicPathfindingInCell(
        TileCell cell,
        TileModelLayerEnum layer,
        ref UpdateTileCellsSystem.UpdateCellsJob.CellData cellData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicPathfindingInCell_Private_Void_TileCell_TileModelLayerEnum_byref_CellData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1076995, RefRangeEnd = 1076996, XrefRangeStart = 1076980, XrefRangeEnd = 1076995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void WriteDynamicPathfinding(
        TileCell cell,
        TilePosition tileModelTilePosition,
        ref TileDatas<PathfindingTileData> tileModelPathfindingTiles,
        TileModelLayerEnum layer,
        int2 cellWorldTileOffset,
        BoundsMinMax intersectedCellWorldBounds,
        TileLayerIndex tileLayerIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &cell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelTilePosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileModelPathfindingTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &cellWorldTileOffset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &intersectedCellWorldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayerIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicPathfinding_Private_Void_TileCell_TilePosition_byref_TileDatas_1_PathfindingTileData_TileModelLayerEnum_int2_BoundsMinMax_TileLayerIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1077002, RefRangeEnd = 1077004, XrefRangeStart = 1076996, XrefRangeEnd = 1077002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void WriteTile(
        NativeArray<PathfindingTile> pathfindingTiles,
        TileModelLayerEnum layer,
        int2 localCellTile,
        PathfindingTileData tileModelTileData,
        NativeArray<TileModelLayerEnum> layerTracker)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &pathfindingTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localCellTile;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelTileData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &layerTracker;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteTile_Private_Static_Void_NativeArray_1_PathfindingTile_TileModelLayerEnum_int2_PathfindingTileData_NativeArray_1_TileModelLayerEnum_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1077004, RefRangeEnd = 1077005, XrefRangeStart = 1077004, XrefRangeEnd = 1077004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe PathfindingTile TerrainTypeToPathfindingTile(TerrainType terrainType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &terrainType;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_TerrainTypeToPathfindingTile_Private_Static_PathfindingTile_TerrainType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PathfindingTile*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1077024, RefRangeEnd = 1077025, XrefRangeStart = 1077005, XrefRangeEnd = 1077024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void FindPortals(TileCell cell)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &cell;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_FindPortals_Private_Void_TileCell_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1077073, RefRangeEnd = 1077074, XrefRangeStart = 1077025, XrefRangeEnd = 1077073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandPathfinding(
        NativeHashSet<TileCellCoordinate> cellsToExpandPathfindingFor,
        ref TileWorld tileWorld)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &cellsToExpandPathfindingFor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_ExpandPathfinding_Private_Void_NativeHashSet_1_TileCellCoordinate_byref_TileWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1077077, RefRangeEnd = 1077080, XrefRangeStart = 1077074, XrefRangeEnd = 1077077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<PathfindingTile> GetPathfindingTilesOrDefault(
        TileCellCoordinate cellCoordinate,
        ref TileWorld tileWorld,
        byte heightLevel)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &cellCoordinate;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_GetPathfindingTilesOrDefault_Private_Static_NativeArray_1_PathfindingTile_TileCellCoordinate_byref_TileWorld_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<PathfindingTile>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1077083, RefRangeEnd = 1077087, XrefRangeStart = 1077080, XrefRangeEnd = 1077083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Internal_Static_Void_byref_CellMaskBuilder_TileCell_TileLayer_TileLayerIndex_TileCellMaskType_Int32_0(
        ref UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder builderContext,
        TileCell tileCell,
        TileLayer tileLayer,
        TileLayerIndex tileLayerIndex,
        TileCellMaskType flagType,
        int flagIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref builderContext;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileCell;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayerIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flagType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &flagIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_Method_Internal_Static_Void_byref_CellMaskBuilder_TileCell_TileLayer_TileLayerIndex_TileCellMaskType_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateCellsJob()
      {
        Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateTileCellsSystem>.NativeClassPtr, nameof (UpdateCellsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr);
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (TileWorld));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (TerrainChunks));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_DirtyTileCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (DirtyTileCells));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_GetTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (GetTileModel));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (GetLocalToWorld));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (IsServer));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_SpatialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (SpatialLookup));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_ProfilerMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (ProfilerMarkers));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_CurrentChunkLayerTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (CurrentChunkLayerTracker));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_GetBakedChunkCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (GetBakedChunkCells));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_GetChunkBaseGameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (GetChunkBaseGameplayHeights));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_GetBakedTileCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (GetBakedTileCollision));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_GetBakedTileCollisionBoundsBlobRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (GetBakedTileCollisionBoundsBlobRef));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_GetBakedLineOfSightTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (GetBakedLineOfSightTiles));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_GetBakedLineOfSightTileDataBoundsRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (GetBakedLineOfSightTileDataBoundsRef));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_GetBakedPathfindingTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (GetBakedPathfindingTileData));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_GetBakedPathfindingTileDataBoundsRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (GetBakedPathfindingTileDataBoundsRef));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_StandardLayerFlags_IsGroundedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (StandardLayerFlags_IsGroundedIndex));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_StandardLayerFlags_BlockBuildingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (StandardLayerFlags_BlockBuildingIndex));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_CellBasedMask_CollideFlyMovementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (CellBasedMask_CollideFlyMovementIndex));
        UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_CellBasedMask_WalkableMaskIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (CellBasedMask_WalkableMaskIndex));
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684743);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_DoExecute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684744);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_InitializeCell_Private_Void_byref_CellMaskBuilder_byref_CellData_TileCell_byref_TerrainCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684745);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_GetStaticLevelRange_Private_Static_Void_TileCell_int2_PrefabGUID_Byte_StaticTileModelData_byref_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684746);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_BuildDynamicEntitiesPerLayer_Private_Static_Void_NativeList_1_TileModelSpatialEntity_byref_TileModelLayerArrayInfo_byref_NativeArray_1_TileModelSpatialEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684747);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateTerrainCache_Private_Void_byref_TerrainCache_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684748);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_FinalizeMaskBuilder_Private_Static_Int32_byref_CellMaskBuilder_TileCellMaskType_Int32_Nullable_Unboxed_1_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684749);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_StoreStaticMasksAndResetCell_Private_Static_Void_byref_CellMaskBuilder_byref_TileCell_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684750);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateCellBasedMasks_Private_Static_Void_TileCell_TileCellCoordinate_byref_CellMaskBuilder_byref_TerrainCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684751);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_FinalizeNewCellMaskArray_Private_Static_Void_byref_CellMaskBuilder_byref_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684752);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateCellCollision_Private_Void_TileCell_byref_CellData_byref_TerrainCache_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684753);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_FinalizeCollisionCellMaskBuilder_Private_Static_Void_byref_TileCell_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684754);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_ClearCollisionTiles_Private_Static_Void_TileCell_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684755);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateTerrainCache_Collision_Private_Void_byref_TerrainCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684756);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticCollisionInCell_Private_Void_TileCell_TileModelLayerEnum_byref_TerrainCache_byref_CellData_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684757);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicEntitiesInCell_Private_Void_TileCell_TileModelLayerEnum_byref_CellData_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684758);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicCollision_Private_Void_TilePosition_byref_TileDatas_1_CollisionData_TileModelLayerEnum_BoundsMinMax_TileLayerIndex_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684759);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticCollision_Private_Void_TilePosition_byref_TileDatas2dArray_1_CollisionData_NativeArray_1_TileModelLayerEnum_TileModelLayerEnum_BoundsMinMax_NativeSlice_1_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684760);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteCollisionTile_Private_Static_Void_TileModelLayerEnum_int2_MapCollisionFlags_NativeArray_1_TileModelLayerEnum_NativeSlice_1_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684761);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateCellHeights_Private_Void_TileCell_byref_CellData_byref_TerrainCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684762);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateTerrainCache_Heights_Private_Void_byref_TerrainCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684763);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateHeights_Private_Void_TileCell_byref_CellData_byref_TerrainCache_NativeArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684764);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_ResetCellHeights_Private_Static_Void_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684765);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticBakedHeight_Private_Static_TileCellGameplayHeights_NativeArray_1_UInt16_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684766);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicEntityCellHeights_Private_Static_Void_byref_TileDatas_1_TileHeightData_TilePosition_BoundsMinMax_Single_byref_TileCellGameplayHeights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684767);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateCellLineOfSight_Private_Void_TileCell_byref_CellData_byref_TerrainCache_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684768);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_FinalizeLineOfSightCellMaskBuilder_Private_Static_Void_byref_TileCell_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684769);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateTerrainCache_LineOfSight_Private_Void_byref_TerrainCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684770);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticLineOfSightInCell_Private_Void_TileCell_TileModelLayerEnum_byref_TerrainCache_byref_CellData_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684771);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticLineOfSight_Private_Void_TilePosition_byref_TileDatas_1_LineOfSightTileData_NativeArray_1_TileModelLayerEnum_TileModelLayerEnum_int2_BoundsMinMax_NativeSlice_1_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684772);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicLineOfSightInCell_Private_Void_TileCell_TileModelLayerEnum_byref_CellData_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684773);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicLineOfSight_Private_Void_TileCell_TilePosition_byref_TileDatas_1_LineOfSightTileData_TileModelLayerEnum_int2_BoundsMinMax_TileLayerIndex_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684774);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteTile_Private_Static_Void_TileModelLayerEnum_int2_LineOfSightTileFlags_NativeArray_1_TileModelLayerEnum_NativeSlice_1_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684775);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateCellPathfinding_Private_Void_TileCell_byref_CellData_byref_TerrainCache_byref_CellMaskBuilder_byref_NativeHashSet_1_TileCellCoordinate_byref_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684776);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_AddCellToExpandIfValid_Private_Static_Void_TileCellCoordinate_byref_NativeHashSet_1_TileCellCoordinate_byref_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684777);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_UpdateTerrainCache_Pathfinding_Private_Void_byref_TerrainCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684778);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_ClearPathfindingTiles_Private_Static_Void_TileCell_byref_CellMaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684779);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticPathfindingInCell_Private_Void_TileCell_TileModelLayerEnum_byref_TerrainCache_byref_CellData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684780);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteStaticPathfinding_Private_Void_NativeArray_1_PathfindingTile_TilePosition_byref_TileDatas_1_PathfindingTileData_NativeArray_1_TileModelLayerEnum_TileModelLayerEnum_int2_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684781);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicPathfindingInCell_Private_Void_TileCell_TileModelLayerEnum_byref_CellData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684782);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteDynamicPathfinding_Private_Void_TileCell_TilePosition_byref_TileDatas_1_PathfindingTileData_TileModelLayerEnum_int2_BoundsMinMax_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684783);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_WriteTile_Private_Static_Void_NativeArray_1_PathfindingTile_TileModelLayerEnum_int2_PathfindingTileData_NativeArray_1_TileModelLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684784);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_TerrainTypeToPathfindingTile_Private_Static_PathfindingTile_TerrainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684785);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_FindPortals_Private_Void_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684786);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_ExpandPathfinding_Private_Void_NativeHashSet_1_TileCellCoordinate_byref_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684787);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_GetPathfindingTilesOrDefault_Private_Static_NativeArray_1_PathfindingTile_TileCellCoordinate_byref_TileWorld_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684788);
        UpdateTileCellsSystem.UpdateCellsJob.NativeMethodInfoPtr_Method_Internal_Static_Void_byref_CellMaskBuilder_TileCell_TileLayer_TileLayerIndex_TileCellMaskType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, 100684790);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe int StandardLayerFlags_IsGroundedIndex
      {
        get
        {
          int flagsIsGroundedIndex;
          IL2CPP.il2cpp_field_static_get_value(UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_StandardLayerFlags_IsGroundedIndex, (void*) &flagsIsGroundedIndex);
          return flagsIsGroundedIndex;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_StandardLayerFlags_IsGroundedIndex, (void*) &value);
        }
      }

      public static unsafe int StandardLayerFlags_BlockBuildingIndex
      {
        get
        {
          int blockBuildingIndex;
          IL2CPP.il2cpp_field_static_get_value(UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_StandardLayerFlags_BlockBuildingIndex, (void*) &blockBuildingIndex);
          return blockBuildingIndex;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_StandardLayerFlags_BlockBuildingIndex, (void*) &value);
        }
      }

      public static unsafe int CellBasedMask_CollideFlyMovementIndex
      {
        get
        {
          int flyMovementIndex;
          IL2CPP.il2cpp_field_static_get_value(UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_CellBasedMask_CollideFlyMovementIndex, (void*) &flyMovementIndex);
          return flyMovementIndex;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_CellBasedMask_CollideFlyMovementIndex, (void*) &value);
        }
      }

      public static unsafe int CellBasedMask_WalkableMaskIndex
      {
        get
        {
          int walkableMaskIndex;
          IL2CPP.il2cpp_field_static_get_value(UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_CellBasedMask_WalkableMaskIndex, (void*) &walkableMaskIndex);
          return walkableMaskIndex;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateTileCellsSystem.UpdateCellsJob.NativeFieldInfoPtr_CellBasedMask_WalkableMaskIndex, (void*) &value);
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct TerrainCache
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_ChunkExists;
        private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunkEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunk;
        private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunkTile;
        private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedForTileTypes;
        private static readonly System.IntPtr NativeFieldInfoPtr_ChunkWorldTileOffset;
        private static readonly System.IntPtr NativeFieldInfoPtr_BakedChunkCells;
        private static readonly System.IntPtr NativeFieldInfoPtr_Heights_BakedGameplayHeights;
        private static readonly System.IntPtr NativeFieldInfoPtr_Collision_BakedCollision;
        private static readonly System.IntPtr NativeFieldInfoPtr_Collision_BakedCollisionTileBoundsBlob;
        private static readonly System.IntPtr NativeFieldInfoPtr_LineOfSight_BakedLineOfSight;
        private static readonly System.IntPtr NativeFieldInfoPtr_LineOfSight_BakedLineOfSightTileDataBoundsRef;
        private static readonly System.IntPtr NativeFieldInfoPtr_Pathfinding_BakedPathfindingTileData;
        private static readonly System.IntPtr NativeFieldInfoPtr_Pathfinding_BakedPathfindingTileDataBoundsRef;
        [FieldOffset(0)]
        public bool ChunkExists;
        [FieldOffset(4)]
        public Entity TerrainChunkEntity;
        [FieldOffset(12)]
        public TerrainChunk TerrainChunk;
        [FieldOffset(20)]
        public TilePosition TerrainChunkTile;
        [FieldOffset(32)]
        public TileType UpdatedForTileTypes;
        [FieldOffset(36)]
        public int2 ChunkWorldTileOffset;
        [FieldOffset(48)]
        public BakedChunkCells BakedChunkCells;
        [FieldOffset(56)]
        public NativeArray<ushort> Heights_BakedGameplayHeights;
        [FieldOffset(72)]
        public NativeArray<BakedCollisionTiles> Collision_BakedCollision;
        [FieldOffset(88)]
        public BakedCollisionTilesBoundsRef Collision_BakedCollisionTileBoundsBlob;
        [FieldOffset(96)]
        public NativeArray<BakedLineOfSightTiles> LineOfSight_BakedLineOfSight;
        [FieldOffset(112)]
        public BakedLineOfSightTileDataBoundsRef LineOfSight_BakedLineOfSightTileDataBoundsRef;
        [FieldOffset(120)]
        public NativeArray<BakedPathfindingTileData> Pathfinding_BakedPathfindingTileData;
        [FieldOffset(136)]
        public BakedPathfindingTileDataBoundsRef Pathfinding_BakedPathfindingTileDataBoundsRef;

        static TerrainCache()
        {
          Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (TerrainCache));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr);
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_ChunkExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (ChunkExists));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_TerrainChunkEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (TerrainChunkEntity));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_TerrainChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (TerrainChunk));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_TerrainChunkTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (TerrainChunkTile));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_UpdatedForTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (UpdatedForTileTypes));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_ChunkWorldTileOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (ChunkWorldTileOffset));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_BakedChunkCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (BakedChunkCells));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_Heights_BakedGameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (Heights_BakedGameplayHeights));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_Collision_BakedCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (Collision_BakedCollision));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_Collision_BakedCollisionTileBoundsBlob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (Collision_BakedCollisionTileBoundsBlob));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_LineOfSight_BakedLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (LineOfSight_BakedLineOfSight));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_LineOfSight_BakedLineOfSightTileDataBoundsRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (LineOfSight_BakedLineOfSightTileDataBoundsRef));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_Pathfinding_BakedPathfindingTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (Pathfinding_BakedPathfindingTileData));
          UpdateTileCellsSystem.UpdateCellsJob.TerrainCache.NativeFieldInfoPtr_Pathfinding_BakedPathfindingTileDataBoundsRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, nameof (Pathfinding_BakedPathfindingTileDataBoundsRef));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.TerrainCache>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct CellData
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_CellCoordinate;
        private static readonly System.IntPtr NativeFieldInfoPtr_DirtyTileTypes;
        private static readonly System.IntPtr NativeFieldInfoPtr_CellWorldBounds;
        private static readonly System.IntPtr NativeFieldInfoPtr_CellBoundsInChunkSpace;
        private static readonly System.IntPtr NativeFieldInfoPtr_InitializeCell;
        private static readonly System.IntPtr NativeFieldInfoPtr_DynamicEntities;
        private static readonly System.IntPtr NativeFieldInfoPtr_DynamicLayerLocations;
        private static readonly System.IntPtr NativeFieldInfoPtr_DynamicEntitiesByLayer;
        private static readonly System.IntPtr NativeFieldInfoPtr_Heights_EntitiesByHeights;
        [FieldOffset(0)]
        public TileCellCoordinate CellCoordinate;
        [FieldOffset(8)]
        public TileType DirtyTileTypes;
        [FieldOffset(12)]
        public BoundsMinMax CellWorldBounds;
        [FieldOffset(28)]
        public BoundsMinMax CellBoundsInChunkSpace;
        [FieldOffset(44)]
        public bool InitializeCell;
        [FieldOffset(48)]
        public NativeList<TileModelSpatialEntity> DynamicEntities;
        [FieldOffset(64)]
        public TileModelLayerArrayInfo DynamicLayerLocations;
        [FieldOffset(96)]
        public NativeArray<TileModelSpatialEntity> DynamicEntitiesByLayer;
        [FieldOffset(112)]
        public NativeList<TileModelSpatialEntity> Heights_EntitiesByHeights;

        static CellData()
        {
          Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (CellData));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr);
          UpdateTileCellsSystem.UpdateCellsJob.CellData.NativeFieldInfoPtr_CellCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr, nameof (CellCoordinate));
          UpdateTileCellsSystem.UpdateCellsJob.CellData.NativeFieldInfoPtr_DirtyTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr, nameof (DirtyTileTypes));
          UpdateTileCellsSystem.UpdateCellsJob.CellData.NativeFieldInfoPtr_CellWorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr, nameof (CellWorldBounds));
          UpdateTileCellsSystem.UpdateCellsJob.CellData.NativeFieldInfoPtr_CellBoundsInChunkSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr, nameof (CellBoundsInChunkSpace));
          UpdateTileCellsSystem.UpdateCellsJob.CellData.NativeFieldInfoPtr_InitializeCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr, nameof (InitializeCell));
          UpdateTileCellsSystem.UpdateCellsJob.CellData.NativeFieldInfoPtr_DynamicEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr, nameof (DynamicEntities));
          UpdateTileCellsSystem.UpdateCellsJob.CellData.NativeFieldInfoPtr_DynamicLayerLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr, nameof (DynamicLayerLocations));
          UpdateTileCellsSystem.UpdateCellsJob.CellData.NativeFieldInfoPtr_DynamicEntitiesByLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr, nameof (DynamicEntitiesByLayer));
          UpdateTileCellsSystem.UpdateCellsJob.CellData.NativeFieldInfoPtr_Heights_EntitiesByHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr, nameof (Heights_EntitiesByHeights));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellData>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct CellMaskBuilder
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_TempBitMasks;
        private static readonly System.IntPtr NativeFieldInfoPtr_BuilderMaskKeyToMaskIndex;
        private static readonly System.IntPtr NativeFieldInfoPtr_MaskBuilderList;
        private static readonly System.IntPtr NativeFieldInfoPtr_Masks;
        private static readonly System.IntPtr NativeMethodInfoPtr_Allocate_Public_Static_CellMaskBuilder_Allocator_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ClearAndAssertTempListCapacity_Public_Void_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetBuilderMask_Public_BitMask2D_16x16_TileCellMaskType_Int32_TileLayerIndex_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_AddCellMask_Public_Byte_TileCellMaskType_Int32_byref_BitMask2D_16x16_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_AddLayerMask_Public_Byte_TileCellMaskType_Int32_TileLayerIndex_byref_BitMask2D_16x16_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_AddMask_Private_Byte_TileCellMaskType_Int32_Int32_byref_BitMask2D_16x16_0;
        [FieldOffset(0)]
        public NativeList<BitMask2D_16x16> TempBitMasks;
        [FieldOffset(16)]
        public NativeHashMap<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey, byte> BuilderMaskKeyToMaskIndex;
        [FieldOffset(32)]
        public NativeList<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder> MaskBuilderList;
        [FieldOffset(48)]
        public BitMaskCollectionBuilder Masks;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1075997, RefRangeEnd = 1075998, XrefRangeStart = 1075987, XrefRangeEnd = 1075997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder Allocate(
          Allocator allocator)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &allocator;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_Allocate_Public_Static_CellMaskBuilder_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 1076007, RefRangeEnd = 1076010, XrefRangeStart = 1075998, XrefRangeEnd = 1076007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ClearAndAssertTempListCapacity(int requiredCapacity)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &requiredCapacity;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_ClearAndAssertTempListCapacity_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1076017, RefRangeEnd = 1076018, XrefRangeStart = 1076010, XrefRangeEnd = 1076017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void Reset()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_Reset_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1076028, RefRangeEnd = 1076029, XrefRangeStart = 1076018, XrefRangeEnd = 1076028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void Dispose()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 1076036, RefRangeEnd = 1076038, XrefRangeStart = 1076029, XrefRangeEnd = 1076036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BitMask2D_16x16 GetBuilderMask(
          TileCellMaskType type,
          int flagIndex,
          TileLayerIndex tileLayerIndex)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) &type;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flagIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayerIndex;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_GetBuilderMask_Public_BitMask2D_16x16_TileCellMaskType_Int32_TileLayerIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1076039, RefRangeEnd = 1076040, XrefRangeStart = 1076038, XrefRangeEnd = 1076039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe byte AddCellMask(
          TileCellMaskType type,
          int flagIndex,
          [In] ref BitMask2D_16x16 mask)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) &type;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flagIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mask;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_AddCellMask_Public_Byte_TileCellMaskType_Int32_byref_BitMask2D_16x16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(byte*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 1076041, RefRangeEnd = 1076044, XrefRangeStart = 1076040, XrefRangeEnd = 1076041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe byte AddLayerMask(
          TileCellMaskType type,
          int flagIndex,
          TileLayerIndex tileLayerIndex,
          [In] ref BitMask2D_16x16 mask)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) &type;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flagIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayerIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mask;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_AddLayerMask_Public_Byte_TileCellMaskType_Int32_TileLayerIndex_byref_BitMask2D_16x16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(byte*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 1076055, RefRangeEnd = 1076057, XrefRangeStart = 1076044, XrefRangeEnd = 1076055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe byte AddMask(
          TileCellMaskType type,
          int flagIndex,
          int tileLayerIndex,
          [In] ref BitMask2D_16x16 mask)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) &type;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flagIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayerIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mask;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_AddMask_Private_Byte_TileCellMaskType_Int32_Int32_byref_BitMask2D_16x16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(byte*) IL2CPP.il2cpp_object_unbox(num);
        }

        static CellMaskBuilder()
        {
          Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (CellMaskBuilder));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr);
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeFieldInfoPtr_TempBitMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, nameof (TempBitMasks));
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeFieldInfoPtr_BuilderMaskKeyToMaskIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, nameof (BuilderMaskKeyToMaskIndex));
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeFieldInfoPtr_MaskBuilderList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, nameof (MaskBuilderList));
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeFieldInfoPtr_Masks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, nameof (Masks));
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_Allocate_Public_Static_CellMaskBuilder_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, 100684791);
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_ClearAndAssertTempListCapacity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, 100684792);
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, 100684793);
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, 100684794);
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_GetBuilderMask_Public_BitMask2D_16x16_TileCellMaskType_Int32_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, 100684795);
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_AddCellMask_Public_Byte_TileCellMaskType_Int32_byref_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, 100684796);
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_AddLayerMask_Public_Byte_TileCellMaskType_Int32_TileLayerIndex_byref_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, 100684797);
          UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.NativeMethodInfoPtr_AddMask_Private_Byte_TileCellMaskType_Int32_Int32_byref_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, 100684798);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct MaskBuilder
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_Type;
          private static readonly System.IntPtr NativeFieldInfoPtr_FlagIndex;
          private static readonly System.IntPtr NativeFieldInfoPtr_CellMaskIndex;
          private static readonly System.IntPtr NativeFieldInfoPtr_TileLayerIndex;
          private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_MaskBuilder_0;
          [FieldOffset(0)]
          public TileCellMaskType Type;
          [FieldOffset(4)]
          public int FlagIndex;
          [FieldOffset(8)]
          public byte CellMaskIndex;
          [FieldOffset(12)]
          public int TileLayerIndex;

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075982, XrefRangeEnd = 1075983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe int CompareTo(
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder other)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = (System.IntPtr) &other;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_MaskBuilder_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(int*) IL2CPP.il2cpp_object_unbox(num);
          }

          static MaskBuilder()
          {
            Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, nameof (MaskBuilder));
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder>.NativeClassPtr);
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder>.NativeClassPtr, nameof (Type));
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder.NativeFieldInfoPtr_FlagIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder>.NativeClassPtr, nameof (FlagIndex));
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder.NativeFieldInfoPtr_CellMaskIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder>.NativeClassPtr, nameof (CellMaskIndex));
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder.NativeFieldInfoPtr_TileLayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder>.NativeClassPtr, nameof (TileLayerIndex));
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_MaskBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder>.NativeClassPtr, 100684799);
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.MaskBuilder>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct BuilderMaskKey
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_Type;
          private static readonly System.IntPtr NativeFieldInfoPtr_FlagIndex;
          private static readonly System.IntPtr NativeFieldInfoPtr_TileLayerIndex;
          private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BuilderMaskKey_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
          [FieldOffset(0)]
          public TileCellMaskType Type;
          [FieldOffset(4)]
          public int FlagIndex;
          [FieldOffset(8)]
          public int TileLayerIndex;

          [CallerCount(4)]
          [CachedScanResults(RefRangeStart = 261679, RefRangeEnd = 261683, XrefRangeStart = 261679, XrefRangeEnd = 261683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe bool Equals(
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey other)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = (System.IntPtr) &other;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BuilderMaskKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*) IL2CPP.il2cpp_object_unbox(num);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075983, XrefRangeEnd = 1075986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe bool Equals(Il2CppSystem.Object obj)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*) IL2CPP.il2cpp_object_unbox(num);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075986, XrefRangeEnd = 1075987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public override unsafe int GetHashCode()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(int*) IL2CPP.il2cpp_object_unbox(num);
          }

          static BuilderMaskKey()
          {
            Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder>.NativeClassPtr, nameof (BuilderMaskKey));
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey>.NativeClassPtr);
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey>.NativeClassPtr, nameof (Type));
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey.NativeFieldInfoPtr_FlagIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey>.NativeClassPtr, nameof (FlagIndex));
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey.NativeFieldInfoPtr_TileLayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey>.NativeClassPtr, nameof (TileLayerIndex));
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BuilderMaskKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey>.NativeClassPtr, 100684800);
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey>.NativeClassPtr, 100684801);
            UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey>.NativeClassPtr, 100684802);
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.CellMaskBuilder.BuilderMaskKey>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct SortByHeightLevel
      {
        private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_TileModelSpatialEntity_TileModelSpatialEntity_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076057, XrefRangeEnd = 1076060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe int Compare(TileModelSpatialEntity a, TileModelSpatialEntity b)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &a;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem.UpdateCellsJob.SortByHeightLevel.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_TileModelSpatialEntity_TileModelSpatialEntity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        static SortByHeightLevel()
        {
          Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.SortByHeightLevel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob>.NativeClassPtr, nameof (SortByHeightLevel));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.SortByHeightLevel>.NativeClassPtr);
          UpdateTileCellsSystem.UpdateCellsJob.SortByHeightLevel.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_TileModelSpatialEntity_TileModelSpatialEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.SortByHeightLevel>.NativeClassPtr, 100684803);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateTileCellsSystem.UpdateCellsJob.SortByHeightLevel>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }
  }
}
