// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BakedChunkCells
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BakedChunkCells
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Blob;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStaticMaskIndexAndRotation_Public_Static_Int32_TileCellCoordinate_int2_TileRotation_byref_OrthogonalRotation_0;
    [FieldOffset(0)]
    public BlobAssetReference<ChunkCellsBlob> Blob;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1086093, RefRangeEnd = 1086095, XrefRangeStart = 1086090, XrefRangeEnd = 1086093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetStaticMaskIndexAndRotation(
      TileCellCoordinate worldCellCoord,
      int2 chunkWorldTileOffset,
      TileRotation chunkRotation,
      out OrthogonalRotation maskRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &worldCellCoord;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkWorldTileOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref maskRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BakedChunkCells.NativeMethodInfoPtr_GetStaticMaskIndexAndRotation_Public_Static_Int32_TileCellCoordinate_int2_TileRotation_byref_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BakedChunkCells()
    {
      Il2CppClassPointerStore<BakedChunkCells>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (BakedChunkCells));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BakedChunkCells>.NativeClassPtr);
      BakedChunkCells.NativeFieldInfoPtr_Blob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedChunkCells>.NativeClassPtr, nameof (Blob));
      BakedChunkCells.NativeMethodInfoPtr_GetStaticMaskIndexAndRotation_Public_Static_Int32_TileCellCoordinate_int2_TileRotation_byref_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakedChunkCells>.NativeClassPtr, 100685555);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BakedChunkCells>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
