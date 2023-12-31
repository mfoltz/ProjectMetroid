// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkPortalData
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
  public struct ChunkPortalData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PortalEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_PortalPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_PortalRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToChunkPortalIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_InPositionOffset;
    [FieldOffset(0)]
    public Entity PortalEntity;
    [FieldOffset(8)]
    public float3 PortalPosition;
    [FieldOffset(20)]
    public quaternion PortalRotation;
    [FieldOffset(36)]
    public TerrainChunk ToChunk;
    [FieldOffset(44)]
    public int ToChunkPortalIndex;
    [FieldOffset(48)]
    public float3 InPositionOffset;

    static ChunkPortalData()
    {
      Il2CppClassPointerStore<ChunkPortalData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkPortalData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkPortalData>.NativeClassPtr);
      ChunkPortalData.NativeFieldInfoPtr_PortalEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortalData>.NativeClassPtr, nameof (PortalEntity));
      ChunkPortalData.NativeFieldInfoPtr_PortalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortalData>.NativeClassPtr, nameof (PortalPosition));
      ChunkPortalData.NativeFieldInfoPtr_PortalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortalData>.NativeClassPtr, nameof (PortalRotation));
      ChunkPortalData.NativeFieldInfoPtr_ToChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortalData>.NativeClassPtr, nameof (ToChunk));
      ChunkPortalData.NativeFieldInfoPtr_ToChunkPortalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortalData>.NativeClassPtr, nameof (ToChunkPortalIndex));
      ChunkPortalData.NativeFieldInfoPtr_InPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortalData>.NativeClassPtr, nameof (InPositionOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkPortalData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
