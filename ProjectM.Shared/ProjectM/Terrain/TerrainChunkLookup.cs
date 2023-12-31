// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainChunkLookup
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TerrainChunkLookup
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadedTerrainChunksEntities;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_TerrainChunkLookup_NativeHashMap_2_ChunkSceneId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCoreChunk_Public_Boolean_TerrainChunk_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCoreChunkLoaded_Public_Boolean_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetChunk_Public_Boolean_ChunkSceneId_byref_Entity_0;
    [FieldOffset(0)]
    public NativeHashMap<ChunkSceneId, Entity> LoadedTerrainChunksEntities;

    [CallerCount(46)]
    [CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TerrainChunkLookup Create(NativeHashMap<ChunkSceneId, Entity> terrainChunks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &terrainChunks;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkLookup.NativeMethodInfoPtr_Create_Public_Static_TerrainChunkLookup_NativeHashMap_2_ChunkSceneId_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunkLookup*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 767520, RefRangeEnd = 767531, XrefRangeStart = 767516, XrefRangeEnd = 767520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetCoreChunk(TerrainChunk coordinate, out Entity terrainChunkEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &coordinate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainChunkEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkLookup.NativeMethodInfoPtr_TryGetCoreChunk_Public_Boolean_TerrainChunk_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 767535, RefRangeEnd = 767537, XrefRangeStart = 767531, XrefRangeEnd = 767535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsCoreChunkLoaded(TerrainChunk coordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &coordinate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkLookup.NativeMethodInfoPtr_IsCoreChunkLoaded_Public_Boolean_TerrainChunk_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 767540, RefRangeEnd = 767547, XrefRangeStart = 767537, XrefRangeEnd = 767540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetChunk(ChunkSceneId chunkSceneId, out Entity terrainChunkEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &chunkSceneId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainChunkEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkLookup.NativeMethodInfoPtr_TryGetChunk_Public_Boolean_ChunkSceneId_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TerrainChunkLookup()
    {
      Il2CppClassPointerStore<TerrainChunkLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainChunkLookup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainChunkLookup>.NativeClassPtr);
      TerrainChunkLookup.NativeFieldInfoPtr_LoadedTerrainChunksEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkLookup>.NativeClassPtr, nameof (LoadedTerrainChunksEntities));
      TerrainChunkLookup.NativeMethodInfoPtr_Create_Public_Static_TerrainChunkLookup_NativeHashMap_2_ChunkSceneId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkLookup>.NativeClassPtr, 100667922);
      TerrainChunkLookup.NativeMethodInfoPtr_TryGetCoreChunk_Public_Boolean_TerrainChunk_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkLookup>.NativeClassPtr, 100667923);
      TerrainChunkLookup.NativeMethodInfoPtr_IsCoreChunkLoaded_Public_Boolean_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkLookup>.NativeClassPtr, 100667924);
      TerrainChunkLookup.NativeMethodInfoPtr_TryGetChunk_Public_Boolean_ChunkSceneId_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkLookup>.NativeClassPtr, 100667925);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainChunkLookup>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
