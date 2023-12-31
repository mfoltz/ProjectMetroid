// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ProcessChunkTask
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProcessChunkTask
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldTransformationMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalTransformationMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkWorldBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkId;
    [FieldOffset(0)]
    public float4x4 WorldTransformationMatrix;
    [FieldOffset(64)]
    public float4x4 LocalTransformationMatrix;
    [FieldOffset(128)]
    public TerrainChunk TerrainChunk;
    [FieldOffset(136)]
    public BoundsMinMax ChunkWorldBounds;
    [FieldOffset(152)]
    public Entity TerrainEntity;
    [FieldOffset(160)]
    public OrthogonalRotation ChunkRotation;
    [FieldOffset(164)]
    public WorldType WorldTarget;
    [FieldOffset(168)]
    public ChunkSceneId ChunkId;

    static ProcessChunkTask()
    {
      Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ProcessChunkTask));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr);
      ProcessChunkTask.NativeFieldInfoPtr_WorldTransformationMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr, nameof (WorldTransformationMatrix));
      ProcessChunkTask.NativeFieldInfoPtr_LocalTransformationMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr, nameof (LocalTransformationMatrix));
      ProcessChunkTask.NativeFieldInfoPtr_TerrainChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr, nameof (TerrainChunk));
      ProcessChunkTask.NativeFieldInfoPtr_ChunkWorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr, nameof (ChunkWorldBounds));
      ProcessChunkTask.NativeFieldInfoPtr_TerrainEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr, nameof (TerrainEntity));
      ProcessChunkTask.NativeFieldInfoPtr_ChunkRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr, nameof (ChunkRotation));
      ProcessChunkTask.NativeFieldInfoPtr_WorldTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr, nameof (WorldTarget));
      ProcessChunkTask.NativeFieldInfoPtr_ChunkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr, nameof (ChunkId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProcessChunkTask>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
