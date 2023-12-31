// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainChunkPortalBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TerrainChunkPortalBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ToChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToChunkPortalIndex;
    [FieldOffset(0)]
    public TerrainChunk ToChunk;
    [FieldOffset(8)]
    public int ToChunkPortalIndex;

    static TerrainChunkPortalBuffer()
    {
      Il2CppClassPointerStore<TerrainChunkPortalBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainChunkPortalBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainChunkPortalBuffer>.NativeClassPtr);
      TerrainChunkPortalBuffer.NativeFieldInfoPtr_ToChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkPortalBuffer>.NativeClassPtr, nameof (ToChunk));
      TerrainChunkPortalBuffer.NativeFieldInfoPtr_ToChunkPortalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkPortalBuffer>.NativeClassPtr, nameof (ToChunkPortalIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainChunkPortalBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
