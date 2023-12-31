// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainChunkMetadataLoadedEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TerrainChunkMetadataLoadedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_MetadataEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SceneMetadataEntity;
    [FieldOffset(0)]
    public TerrainChunk TerrainChunk;
    [FieldOffset(8)]
    public Entity MetadataEntity;
    [FieldOffset(16)]
    public Entity SceneMetadataEntity;

    static TerrainChunkMetadataLoadedEvent()
    {
      Il2CppClassPointerStore<TerrainChunkMetadataLoadedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainChunkMetadataLoadedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainChunkMetadataLoadedEvent>.NativeClassPtr);
      TerrainChunkMetadataLoadedEvent.NativeFieldInfoPtr_TerrainChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkMetadataLoadedEvent>.NativeClassPtr, nameof (TerrainChunk));
      TerrainChunkMetadataLoadedEvent.NativeFieldInfoPtr_MetadataEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkMetadataLoadedEvent>.NativeClassPtr, nameof (MetadataEntity));
      TerrainChunkMetadataLoadedEvent.NativeFieldInfoPtr_SceneMetadataEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkMetadataLoadedEvent>.NativeClassPtr, nameof (SceneMetadataEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainChunkMetadataLoadedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
