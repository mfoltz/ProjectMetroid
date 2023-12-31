// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainChunkMetadata
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TerrainChunkMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Coordinate;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubSceneGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldZone;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkName;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasChunkPortals;
    [FieldOffset(0)]
    public TerrainChunk Coordinate;
    [FieldOffset(8)]
    public SubSceneGUID SubSceneGUID;
    [FieldOffset(24)]
    public OrthogonalRotation Rotation;
    [FieldOffset(28)]
    public WorldZone WorldZone;
    [FieldOffset(32)]
    public FixedString128 ChunkName;
    [FieldOffset(160)]
    public bool HasChunkPortals;

    static TerrainChunkMetadata()
    {
      Il2CppClassPointerStore<TerrainChunkMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainChunkMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainChunkMetadata>.NativeClassPtr);
      TerrainChunkMetadata.NativeFieldInfoPtr_Coordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkMetadata>.NativeClassPtr, nameof (Coordinate));
      TerrainChunkMetadata.NativeFieldInfoPtr_SubSceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkMetadata>.NativeClassPtr, nameof (SubSceneGUID));
      TerrainChunkMetadata.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkMetadata>.NativeClassPtr, nameof (Rotation));
      TerrainChunkMetadata.NativeFieldInfoPtr_WorldZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkMetadata>.NativeClassPtr, nameof (WorldZone));
      TerrainChunkMetadata.NativeFieldInfoPtr_ChunkName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkMetadata>.NativeClassPtr, nameof (ChunkName));
      TerrainChunkMetadata.NativeFieldInfoPtr_HasChunkPortals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkMetadata>.NativeClassPtr, nameof (HasChunkPortals));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainChunkMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
