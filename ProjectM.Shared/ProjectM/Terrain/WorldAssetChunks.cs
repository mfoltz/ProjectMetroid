// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.WorldAssetChunks
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
  public struct WorldAssetChunks
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Coordinate;
    private static readonly System.IntPtr NativeFieldInfoPtr_MetadataEntity;
    [FieldOffset(0)]
    public TerrainChunk Coordinate;
    [FieldOffset(8)]
    public Entity MetadataEntity;

    static WorldAssetChunks()
    {
      Il2CppClassPointerStore<WorldAssetChunks>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (WorldAssetChunks));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldAssetChunks>.NativeClassPtr);
      WorldAssetChunks.NativeFieldInfoPtr_Coordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldAssetChunks>.NativeClassPtr, nameof (Coordinate));
      WorldAssetChunks.NativeFieldInfoPtr_MetadataEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldAssetChunks>.NativeClassPtr, nameof (MetadataEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldAssetChunks>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
