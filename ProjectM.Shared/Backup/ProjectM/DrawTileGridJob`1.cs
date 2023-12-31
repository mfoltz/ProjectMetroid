// Decompiled with JetBrains decompiler
// Type: ProjectM.DrawTileGridJob`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public struct DrawTileGridJob<TShowGridComponent> where TShowGridComponent : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowGridDataType;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawGridType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorBufferType;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevelOffset;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredComponentTypes_Public_Static_Il2CppStructArray_1_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobData_Public_Static_DrawTileGridJob_1_TShowGridComponent_SystemBase_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunk_Public_Chunk_TShowGridComponent_ArchetypeChunk_0;
    public EntityTypeHandle EntityType;
    public ComponentTypeHandle<Translation> TranslationType;
    public ComponentTypeHandle<TShowGridComponent> ShowGridDataType;
    public ComponentTypeHandle<DrawGrid> DrawGridType;
    public BufferTypeHandle<DrawGridBuffer> ColorBufferType;
    public int HeightLevelOffset;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733780, XrefRangeEnd = 733791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppStructArray<ComponentType> GetRequiredComponentTypes()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.NativeMethodInfoPtr_GetRequiredComponentTypes_Public_Static_Il2CppStructArray_1_ComponentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<ComponentType>) null : new Il2CppStructArray<ComponentType>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733791, XrefRangeEnd = 733803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DrawTileGridJob<TShowGridComponent> CreateJobData(
      SystemBase system,
      int heightLevelOffset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevelOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.NativeMethodInfoPtr_CreateJobData_Public_Static_DrawTileGridJob_1_TShowGridComponent_SystemBase_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DrawTileGridJob<TShowGridComponent>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 733805, RefRangeEnd = 733813, XrefRangeStart = 733803, XrefRangeEnd = 733805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DrawTileGridJob<TShowGridComponent>.Chunk GetChunk(ArchetypeChunk chunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &chunk;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.NativeMethodInfoPtr_GetChunk_Public_Chunk_TShowGridComponent_ArchetypeChunk_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DrawTileGridJob<TShowGridComponent>.Chunk*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DrawTileGridJob()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "DrawTileGridJob`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TShowGridComponent>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr);
      DrawTileGridJob<TShowGridComponent>.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, nameof (EntityType));
      DrawTileGridJob<TShowGridComponent>.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, nameof (TranslationType));
      DrawTileGridJob<TShowGridComponent>.NativeFieldInfoPtr_ShowGridDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, nameof (ShowGridDataType));
      DrawTileGridJob<TShowGridComponent>.NativeFieldInfoPtr_DrawGridType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, nameof (DrawGridType));
      DrawTileGridJob<TShowGridComponent>.NativeFieldInfoPtr_ColorBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, nameof (ColorBufferType));
      DrawTileGridJob<TShowGridComponent>.NativeFieldInfoPtr_HeightLevelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, nameof (HeightLevelOffset));
      DrawTileGridJob<TShowGridComponent>.NativeMethodInfoPtr_GetRequiredComponentTypes_Public_Static_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, 100664833);
      DrawTileGridJob<TShowGridComponent>.NativeMethodInfoPtr_CreateJobData_Public_Static_DrawTileGridJob_1_TShowGridComponent_SystemBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, 100664834);
      DrawTileGridJob<TShowGridComponent>.NativeMethodInfoPtr_GetChunk_Public_Chunk_TShowGridComponent_ArchetypeChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, 100664835);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public struct Chunk
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__Entities;
      private static readonly System.IntPtr NativeFieldInfoPtr__ShowGrids;
      private static readonly System.IntPtr NativeFieldInfoPtr__Translations;
      private static readonly System.IntPtr NativeFieldInfoPtr__DrawGrids;
      private static readonly System.IntPtr NativeFieldInfoPtr__ColorBuffers;
      private static readonly System.IntPtr NativeFieldInfoPtr__HeightLevelOffset;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetInstance_Public_Instance_TShowGridComponent_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ForChunk_Public_Static_Chunk_TShowGridComponent_ArchetypeChunk_byref_DrawTileGridJob_1_TShowGridComponent_0;
      public NativeArray<Entity> _Entities;
      public NativeArray<TShowGridComponent> _ShowGrids;
      public NativeArray<Translation> _Translations;
      public NativeArray<DrawGrid> _DrawGrids;
      public BufferAccessor<DrawGridBuffer> _ColorBuffers;
      public int _HeightLevelOffset;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 733737, RefRangeEnd = 733738, XrefRangeStart = 733717, XrefRangeEnd = 733737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DrawTileGridJob<TShowGridComponent>.Instance GetInstance(int chunkElementIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &chunkElementIndex;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.Chunk.NativeMethodInfoPtr_GetInstance_Public_Instance_TShowGridComponent_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DrawTileGridJob<TShowGridComponent>.Instance*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733738, XrefRangeEnd = 733750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe DrawTileGridJob<TShowGridComponent>.Chunk ForChunk(
        ArchetypeChunk chunk,
        ref DrawTileGridJob<TShowGridComponent> jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.Chunk.NativeMethodInfoPtr_ForChunk_Public_Static_Chunk_TShowGridComponent_ArchetypeChunk_byref_DrawTileGridJob_1_TShowGridComponent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DrawTileGridJob<TShowGridComponent>.Chunk*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Chunk()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, nameof (Chunk<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TShowGridComponent>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr);
        DrawTileGridJob<TShowGridComponent>.Chunk.NativeFieldInfoPtr__Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr, nameof (_Entities));
        DrawTileGridJob<TShowGridComponent>.Chunk.NativeFieldInfoPtr__ShowGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr, nameof (_ShowGrids));
        DrawTileGridJob<TShowGridComponent>.Chunk.NativeFieldInfoPtr__Translations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr, nameof (_Translations));
        DrawTileGridJob<TShowGridComponent>.Chunk.NativeFieldInfoPtr__DrawGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr, nameof (_DrawGrids));
        DrawTileGridJob<TShowGridComponent>.Chunk.NativeFieldInfoPtr__ColorBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr, nameof (_ColorBuffers));
        DrawTileGridJob<TShowGridComponent>.Chunk.NativeFieldInfoPtr__HeightLevelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr, nameof (_HeightLevelOffset));
        DrawTileGridJob<TShowGridComponent>.Chunk.NativeMethodInfoPtr_GetInstance_Public_Instance_TShowGridComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr, 100664836);
        DrawTileGridJob<TShowGridComponent>.Chunk.NativeMethodInfoPtr_ForChunk_Public_Static_Chunk_TShowGridComponent_ArchetypeChunk_byref_DrawTileGridJob_1_TShowGridComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr, 100664837);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Chunk>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public struct Instance
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShowGridData;
      private static readonly System.IntPtr NativeFieldInfoPtr_Colors;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_Translation;
      private static readonly System.IntPtr NativeFieldInfoPtr_DrawSize;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainChunkIntersections_Public_NativeList_1_TerrainChunkIntersection_TShowGridComponent_TerrainChunkLookup_Color_Allocator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureIndex_Public_Int32_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldXY_Public_int2_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTextureIndexFromWorldTile_Public_Boolean_int2_byref_Int32_0;
      public Entity Entity;
      public TShowGridComponent ShowGridData;
      public NativeArray<Color32> Colors;
      public BoundsMinMax WorldBounds;
      public float3 Translation;
      public int DrawSize;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 733761, RefRangeEnd = 733762, XrefRangeStart = 733750, XrefRangeEnd = 733761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NativeList<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection> GetTerrainChunkIntersections(
        TerrainChunkLookup terrainChunks,
        Color outOfBoundsColor,
        Allocator allocator)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &terrainChunks;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outOfBoundsColor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.Instance.NativeMethodInfoPtr_GetTerrainChunkIntersections_Public_NativeList_1_TerrainChunkIntersection_TShowGridComponent_TerrainChunkLookup_Color_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int GetTextureIndex(int x, int y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.Instance.NativeMethodInfoPtr_GetTextureIndex_Public_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int2 GetWorldXY(int x, int y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.Instance.NativeMethodInfoPtr_GetWorldXY_Public_int2_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int2*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 733765, RefRangeEnd = 733767, XrefRangeStart = 733762, XrefRangeEnd = 733765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetTextureIndexFromWorldTile(int2 worldTile, out int textureIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &worldTile;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref textureIndex;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.Instance.NativeMethodInfoPtr_TryGetTextureIndexFromWorldTile_Public_Boolean_int2_byref_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Instance()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, nameof (Instance<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TShowGridComponent>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr);
        DrawTileGridJob<TShowGridComponent>.Instance.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, nameof (Entity));
        DrawTileGridJob<TShowGridComponent>.Instance.NativeFieldInfoPtr_ShowGridData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, nameof (ShowGridData));
        DrawTileGridJob<TShowGridComponent>.Instance.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, nameof (Colors));
        DrawTileGridJob<TShowGridComponent>.Instance.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, nameof (WorldBounds));
        DrawTileGridJob<TShowGridComponent>.Instance.NativeFieldInfoPtr_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, nameof (Translation));
        DrawTileGridJob<TShowGridComponent>.Instance.NativeFieldInfoPtr_DrawSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, nameof (DrawSize));
        DrawTileGridJob<TShowGridComponent>.Instance.NativeMethodInfoPtr_GetTerrainChunkIntersections_Public_NativeList_1_TerrainChunkIntersection_TShowGridComponent_TerrainChunkLookup_Color_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, 100664838);
        DrawTileGridJob<TShowGridComponent>.Instance.NativeMethodInfoPtr_GetTextureIndex_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, 100664839);
        DrawTileGridJob<TShowGridComponent>.Instance.NativeMethodInfoPtr_GetWorldXY_Public_int2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, 100664840);
        DrawTileGridJob<TShowGridComponent>.Instance.NativeMethodInfoPtr_TryGetTextureIndexFromWorldTile_Public_Boolean_int2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, 100664841);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.Instance>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public struct TerrainChunkIntersection
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunkEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalChunkBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_Size;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunk;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkTileIndex_Public_Int32_byref_Instance_TShowGridComponent_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTile_Public_int2_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldTile_Public_int2_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureIndex_Public_Int32_byref_Instance_TShowGridComponent_Int32_Int32_0;
      public Entity TerrainChunkEntity;
      public BoundsMinMax LocalChunkBounds;
      public BoundsMinMax WorldBounds;
      public int2 Size;
      public TerrainChunk TerrainChunk;

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 733768, RefRangeEnd = 733775, XrefRangeStart = 733767, XrefRangeEnd = 733768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int GetChunkTileIndex(
        [In] ref DrawTileGridJob<TShowGridComponent>.Instance instance,
        int x,
        int y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref instance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeMethodInfoPtr_GetChunkTileIndex_Public_Int32_byref_Instance_TShowGridComponent_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int2 GetLocalTile(int x, int y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeMethodInfoPtr_GetLocalTile_Public_int2_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int2*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int2 GetWorldTile(int x, int y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeMethodInfoPtr_GetWorldTile_Public_int2_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int2*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 733775, RefRangeEnd = 733780, XrefRangeStart = 733775, XrefRangeEnd = 733775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int GetTextureIndex(
        [In] ref DrawTileGridJob<TShowGridComponent>.Instance instance,
        int x,
        int y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref instance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeMethodInfoPtr_GetTextureIndex_Public_Int32_byref_Instance_TShowGridComponent_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TerrainChunkIntersection()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>>.NativeClassPtr, nameof (TerrainChunkIntersection<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TShowGridComponent>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr);
        DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeFieldInfoPtr_TerrainChunkEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr, nameof (TerrainChunkEntity));
        DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeFieldInfoPtr_LocalChunkBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr, nameof (LocalChunkBounds));
        DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr, nameof (WorldBounds));
        DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr, nameof (Size));
        DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeFieldInfoPtr_TerrainChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr, nameof (TerrainChunk));
        DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeMethodInfoPtr_GetChunkTileIndex_Public_Int32_byref_Instance_TShowGridComponent_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr, 100664842);
        DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeMethodInfoPtr_GetLocalTile_Public_int2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr, 100664843);
        DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeMethodInfoPtr_GetWorldTile_Public_int2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr, 100664844);
        DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection.NativeMethodInfoPtr_GetTextureIndex_Public_Int32_byref_Instance_TShowGridComponent_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr, 100664845);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawTileGridJob<TShowGridComponent>.TerrainChunkIntersection>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
