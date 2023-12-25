// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleTerritoryHeightsSystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleTerritoryHeightsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkLoadedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadedEventsQueue;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessChunkTerritories_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessChunkTerritories_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessChunkTerritories_Private_Void_BoundsMinMax_DynamicBuffer_1_ChunkBaseGameplayHeights_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTerritoryChunkHeights_Private_Static_Void_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_byref_BoundsMinMax_byref_DynamicBuffer_1_ChunkBaseGameplayHeights_byref_Byte_byref_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForProcessChunkTerritories_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197177, XrefRangeEnd = 1197196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleTerritoryHeightsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197196, XrefRangeEnd = 1197199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleTerritoryHeightsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197199, XrefRangeEnd = 1197252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleTerritoryHeightsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1197267, RefRangeEnd = 1197268, XrefRangeStart = 1197252, XrefRangeEnd = 1197267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessChunkTerritories(
      BoundsMinMax chunkTileBounds,
      DynamicBuffer<ChunkBaseGameplayHeights> chunkBaseGameplayHeights)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &chunkTileBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkBaseGameplayHeights;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.NativeMethodInfoPtr_ProcessChunkTerritories_Private_Void_BoundsMinMax_DynamicBuffer_1_ChunkBaseGameplayHeights_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1197284, RefRangeEnd = 1197285, XrefRangeStart = 1197268, XrefRangeEnd = 1197284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetTerritoryChunkHeights(
      [In] ref CastleTerritory territory,
      [In] ref DynamicBuffer<CastleTerritoryTiles> territoryTiles,
      [In] ref BoundsMinMax chunkTileBounds,
      [In] ref DynamicBuffer<ChunkBaseGameplayHeights> gameplayHeights,
      out byte minHeight,
      out byte maxHeight)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref territory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref territoryTiles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunkTileBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayHeights;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref minHeight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref maxHeight;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.NativeMethodInfoPtr_GetTerritoryChunkHeights_Private_Static_Void_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_byref_BoundsMinMax_byref_DynamicBuffer_1_ChunkBaseGameplayHeights_byref_Byte_byref_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleTerritoryHeightsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197285, XrefRangeEnd = 1197321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleTerritoryHeightsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197321, XrefRangeEnd = 1197340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForProcessChunkTerritories_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessChunkTerritories_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197340, XrefRangeEnd = 1197344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleTerritoryHeightsSystem()
    {
      Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (CastleTerritoryHeightsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr);
      CastleTerritoryHeightsSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, nameof (_TerrainManager));
      CastleTerritoryHeightsSystem.NativeFieldInfoPtr__ChunkLoadedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, nameof (_ChunkLoadedQuery));
      CastleTerritoryHeightsSystem.NativeFieldInfoPtr__LoadedEventsQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, nameof (_LoadedEventsQueue));
      CastleTerritoryHeightsSystem.NativeFieldInfoPtr___ProcessChunkTerritories_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, "<>ProcessChunkTerritories_LambdaJob0_entityQuery");
      CastleTerritoryHeightsSystem.NativeFieldInfoPtr___ProcessChunkTerritories_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, "<>ProcessChunkTerritories_LambdaJob0_profilerMarker");
      CastleTerritoryHeightsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, 100664090);
      CastleTerritoryHeightsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, 100664091);
      CastleTerritoryHeightsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, 100664092);
      CastleTerritoryHeightsSystem.NativeMethodInfoPtr_ProcessChunkTerritories_Private_Void_BoundsMinMax_DynamicBuffer_1_ChunkBaseGameplayHeights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, 100664093);
      CastleTerritoryHeightsSystem.NativeMethodInfoPtr_GetTerritoryChunkHeights_Private_Static_Void_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_byref_BoundsMinMax_byref_DynamicBuffer_1_ChunkBaseGameplayHeights_byref_Byte_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, 100664094);
      CastleTerritoryHeightsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, 100664095);
      CastleTerritoryHeightsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, 100664096);
      CastleTerritoryHeightsSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessChunkTerritories_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, 100664097);
      CastleTerritoryHeightsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, 100664098);
    }

    public CastleTerritoryHeightsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleTerritoryHeightsSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleTerritoryHeightsSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _ChunkLoadedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleTerritoryHeightsSystem.NativeFieldInfoPtr__ChunkLoadedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleTerritoryHeightsSystem.NativeFieldInfoPtr__ChunkLoadedQuery)) = value;
      }
    }

    public unsafe NativeQueue<TerrainChunkLoadedEvent> _LoadedEventsQueue
    {
      get
      {
        return *(NativeQueue<TerrainChunkLoadedEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleTerritoryHeightsSystem.NativeFieldInfoPtr__LoadedEventsQueue));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleTerritoryHeightsSystem.NativeFieldInfoPtr__LoadedEventsQueue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<TerrainChunkLoadedEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __ProcessChunkTerritories_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleTerritoryHeightsSystem.NativeFieldInfoPtr___ProcessChunkTerritories_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleTerritoryHeightsSystem.NativeFieldInfoPtr___ProcessChunkTerritories_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ProcessChunkTerritories_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleTerritoryHeightsSystem.NativeFieldInfoPtr___ProcessChunkTerritories_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleTerritoryHeightsSystem.NativeFieldInfoPtr___ProcessChunkTerritories_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.CastleTerritoryHeightsSystem/<>c__DisplayClass6_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass6_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_chunkTileBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_chunkBaseGameplayHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessChunkTerritories_b__0_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0;
      [FieldOffset(0)]
      public BoundsMinMax chunkTileBounds;
      [FieldOffset(16)]
      public DynamicBuffer<ChunkBaseGameplayHeights> chunkBaseGameplayHeights;
      [FieldOffset(32)]
      public EntityManager entityManager;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessChunkTerritories_b__0(
        Entity territoryEntity,
        [In] ref CastleTerritory territory,
        [In] ref DynamicBuffer<CastleTerritoryTiles> territoryTiles)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &territoryEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref territory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref territoryTiles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ProcessChunkTerritories_b__0_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass6_0>.NativeClassPtr);
        CastleTerritoryHeightsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_chunkTileBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (chunkTileBounds));
        CastleTerritoryHeightsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_chunkBaseGameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (chunkBaseGameplayHeights));
        CastleTerritoryHeightsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (entityManager));
        CastleTerritoryHeightsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass6_0>.NativeClassPtr, 100664099);
        CastleTerritoryHeightsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ProcessChunkTerritories_b__0_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass6_0>.NativeClassPtr, 100664100);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass6_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.CastleTerritoryHeightsSystem/ProjectM.CastleBuilding.<>c__DisplayClass_ProcessChunkTerritories_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessChunkTerritories_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_chunkTileBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_chunkBaseGameplayHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleTerritoryHeightsSystem_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public BoundsMinMax chunkTileBounds;
      [FieldOffset(16)]
      public DynamicBuffer<ChunkBaseGameplayHeights> chunkBaseGameplayHeights;
      [FieldOffset(32)]
      public EntityManager entityManager;
      [FieldOffset(40)]
      public CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(120)]
      public unsafe CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197147, XrefRangeEnd = 1197152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity territoryEntity,
        [In] ref CastleTerritory territory,
        [In] ref DynamicBuffer<CastleTerritoryTiles> territoryTiles)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &territoryEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref territory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref territoryTiles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1003168, RefRangeEnd = 1003171, XrefRangeStart = 1003168, XrefRangeEnd = 1003171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CastleTerritoryHeightsSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1003171, RefRangeEnd = 1003174, XrefRangeStart = 1003171, XrefRangeEnd = 1003174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CastleTerritoryHeightsSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197152, XrefRangeEnd = 1197154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1197163, RefRangeEnd = 1197164, XrefRangeStart = 1197154, XrefRangeEnd = 1197163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1197166, RefRangeEnd = 1197167, XrefRangeStart = 1197164, XrefRangeEnd = 1197166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CastleTerritoryHeightsSystem componentSystem,
        ref CastleTerritoryHeightsSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleTerritoryHeightsSystem_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197167, XrefRangeEnd = 1197171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197171, XrefRangeEnd = 1197177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessChunkTerritories_LambdaJob0()
      {
        Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleTerritoryHeightsSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessChunkTerritories_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr);
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr_chunkTileBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, nameof (chunkTileBounds));
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr_chunkBaseGameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, nameof (chunkBaseGameplayHeights));
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, 100664101);
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, 100664102);
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, 100664103);
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, 100664104);
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, 100664105);
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleTerritoryHeightsSystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, 100664106);
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, 100664107);
        CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, 100664108);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_territoryEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_territory;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_territoryTiles;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleTerritoryHeightsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_territoryEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CastleTerritory> forParameter_territory;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryTiles> forParameter_territoryTiles;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1197063, RefRangeEnd = 1197064, XrefRangeStart = 1197056, XrefRangeEnd = 1197063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CastleTerritoryHeightsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleTerritoryHeightsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1197071, RefRangeEnd = 1197072, XrefRangeStart = 1197064, XrefRangeEnd = 1197071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_territoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_territoryEntity));
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_territory));
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_territoryTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_territoryTiles));
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleTerritoryHeightsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664109);
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664110);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_territoryEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_territory;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_territoryTiles;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_territoryEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleTerritory>.Runtime runtime_territory;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryTiles>.Runtime runtime_territoryTiles;

          static Runtimes()
          {
            Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_territoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_territoryEntity));
            CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_territory));
            CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_territoryTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_territoryTiles));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.CastleTerritoryHeightsSystem/ProjectM.CastleBuilding.<>c__DisplayClass_ProcessChunkTerritories_LambdaJob0/ProjectM.CastleBuilding.RunWithoutJobSystem_0000020A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000020A$PostfixBurstDelegate");
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664111);
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664112);
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664113);
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664114);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.CastleTerritoryHeightsSystem/ProjectM.CastleBuilding.<>c__DisplayClass_ProcessChunkTerritories_LambdaJob0/ProjectM.CastleBuilding.RunWithoutJobSystem_0000020A$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197072, XrefRangeEnd = 1197086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197086, XrefRangeEnd = 1197104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197104, XrefRangeEnd = 1197119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1197146, RefRangeEnd = 1197147, XrefRangeStart = 1197119, XrefRangeEnd = 1197146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000020A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664115);
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664116);
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664117);
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664118);
          CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664120);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleTerritoryHeightsSystem.__c__DisplayClass_ProcessChunkTerritories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
