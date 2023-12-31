// Decompiled with JetBrains decompiler
// Type: ProjectM.ChunkPortal
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkPortal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromChunkPortalIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToChunkPortalIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_InPositionOffset;
    [FieldOffset(0)]
    public TerrainChunk FromChunk;
    [FieldOffset(8)]
    public int FromChunkPortalIndex;
    [FieldOffset(12)]
    public TerrainChunk ToChunk;
    [FieldOffset(20)]
    public int ToChunkPortalIndex;
    [FieldOffset(24)]
    public float3 InPositionOffset;

    static ChunkPortal()
    {
      Il2CppClassPointerStore<ChunkPortal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ChunkPortal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkPortal>.NativeClassPtr);
      ChunkPortal.NativeFieldInfoPtr_FromChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortal>.NativeClassPtr, nameof (FromChunk));
      ChunkPortal.NativeFieldInfoPtr_FromChunkPortalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortal>.NativeClassPtr, nameof (FromChunkPortalIndex));
      ChunkPortal.NativeFieldInfoPtr_ToChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortal>.NativeClassPtr, nameof (ToChunk));
      ChunkPortal.NativeFieldInfoPtr_ToChunkPortalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortal>.NativeClassPtr, nameof (ToChunkPortalIndex));
      ChunkPortal.NativeFieldInfoPtr_InPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPortal>.NativeClassPtr, nameof (InPositionOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkPortal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
