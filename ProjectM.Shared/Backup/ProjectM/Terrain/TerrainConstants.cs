// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainConstants
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  public static class TerrainConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GridSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockWidth;
    private static readonly System.IntPtr NativeFieldInfoPtr_CornerWidth;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileWidth;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkBoundsHeight;

    static TerrainConstants()
    {
      Il2CppClassPointerStore<TerrainConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainConstants>.NativeClassPtr);
      TerrainConstants.NativeFieldInfoPtr_GridSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainConstants>.NativeClassPtr, nameof (GridSize));
      TerrainConstants.NativeFieldInfoPtr_BlockWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainConstants>.NativeClassPtr, nameof (BlockWidth));
      TerrainConstants.NativeFieldInfoPtr_CornerWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainConstants>.NativeClassPtr, nameof (CornerWidth));
      TerrainConstants.NativeFieldInfoPtr_TileWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainConstants>.NativeClassPtr, nameof (TileWidth));
      TerrainConstants.NativeFieldInfoPtr_ChunkBoundsHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainConstants>.NativeClassPtr, nameof (ChunkBoundsHeight));
    }

    public TerrainConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe uint GridSize
    {
      get
      {
        uint gridSize;
        IL2CPP.il2cpp_field_static_get_value(TerrainConstants.NativeFieldInfoPtr_GridSize, (void*) &gridSize);
        return gridSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerrainConstants.NativeFieldInfoPtr_GridSize, (void*) &value);
      }
    }

    public static unsafe int BlockWidth
    {
      get
      {
        int blockWidth;
        IL2CPP.il2cpp_field_static_get_value(TerrainConstants.NativeFieldInfoPtr_BlockWidth, (void*) &blockWidth);
        return blockWidth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerrainConstants.NativeFieldInfoPtr_BlockWidth, (void*) &value);
      }
    }

    public static unsafe int CornerWidth
    {
      get
      {
        int cornerWidth;
        IL2CPP.il2cpp_field_static_get_value(TerrainConstants.NativeFieldInfoPtr_CornerWidth, (void*) &cornerWidth);
        return cornerWidth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerrainConstants.NativeFieldInfoPtr_CornerWidth, (void*) &value);
      }
    }

    public static unsafe int TileWidth
    {
      get
      {
        int tileWidth;
        IL2CPP.il2cpp_field_static_get_value(TerrainConstants.NativeFieldInfoPtr_TileWidth, (void*) &tileWidth);
        return tileWidth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerrainConstants.NativeFieldInfoPtr_TileWidth, (void*) &value);
      }
    }

    public static unsafe float ChunkBoundsHeight
    {
      get
      {
        float chunkBoundsHeight;
        IL2CPP.il2cpp_field_static_get_value(TerrainConstants.NativeFieldInfoPtr_ChunkBoundsHeight, (void*) &chunkBoundsHeight);
        return chunkBoundsHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerrainConstants.NativeFieldInfoPtr_ChunkBoundsHeight, (void*) &value);
      }
    }
  }
}
