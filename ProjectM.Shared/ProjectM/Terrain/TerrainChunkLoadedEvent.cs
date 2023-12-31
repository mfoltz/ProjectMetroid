// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainChunkLoadedEvent
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
  public struct TerrainChunkLoadedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkEntity;
    [FieldOffset(0)]
    public ChunkSceneId ChunkId;
    [FieldOffset(8)]
    public Entity ChunkEntity;

    static TerrainChunkLoadedEvent()
    {
      Il2CppClassPointerStore<TerrainChunkLoadedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainChunkLoadedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainChunkLoadedEvent>.NativeClassPtr);
      TerrainChunkLoadedEvent.NativeFieldInfoPtr_ChunkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkLoadedEvent>.NativeClassPtr, nameof (ChunkId));
      TerrainChunkLoadedEvent.NativeFieldInfoPtr_ChunkEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkLoadedEvent>.NativeClassPtr, nameof (ChunkEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainChunkLoadedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
