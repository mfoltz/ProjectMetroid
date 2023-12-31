// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.EditorSpawnChunk
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EditorSpawnChunk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkCoordinate;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkHasSpawnPoints;
    [FieldOffset(0)]
    public TerrainChunk ChunkCoordinate;
    [FieldOffset(8)]
    public SubSceneGUID ChunkGuid;
    [FieldOffset(24)]
    public bool ChunkHasSpawnPoints;

    static EditorSpawnChunk()
    {
      Il2CppClassPointerStore<EditorSpawnChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (EditorSpawnChunk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorSpawnChunk>.NativeClassPtr);
      EditorSpawnChunk.NativeFieldInfoPtr_ChunkCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSpawnChunk>.NativeClassPtr, nameof (ChunkCoordinate));
      EditorSpawnChunk.NativeFieldInfoPtr_ChunkGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSpawnChunk>.NativeClassPtr, nameof (ChunkGuid));
      EditorSpawnChunk.NativeFieldInfoPtr_ChunkHasSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSpawnChunk>.NativeClassPtr, nameof (ChunkHasSpawnPoints));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EditorSpawnChunk>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
