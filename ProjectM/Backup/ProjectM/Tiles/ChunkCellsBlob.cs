// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.ChunkCellsBlob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkCellsBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Masks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cells;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMask_Public_BitMask2D_16x16_Int32_0;
    [FieldOffset(0)]
    public BlobArray<BitMask2D_16x16> Masks;
    [FieldOffset(8)]
    public BlobArray<ChunkCellsBlob.TileCell> Cells;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1086099, RefRangeEnd = 1086102, XrefRangeStart = 1086095, XrefRangeEnd = 1086099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetMask(int maskIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &maskIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkCellsBlob.NativeMethodInfoPtr_GetMask_Public_BitMask2D_16x16_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ChunkCellsBlob()
    {
      Il2CppClassPointerStore<ChunkCellsBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (ChunkCellsBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkCellsBlob>.NativeClassPtr);
      ChunkCellsBlob.NativeFieldInfoPtr_Masks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkCellsBlob>.NativeClassPtr, nameof (Masks));
      ChunkCellsBlob.NativeFieldInfoPtr_Cells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkCellsBlob>.NativeClassPtr, nameof (Cells));
      ChunkCellsBlob.NativeMethodInfoPtr_GetMask_Public_BitMask2D_16x16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkCellsBlob>.NativeClassPtr, 100685556);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkCellsBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TileCell
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CellBaseHeightLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileLayers;
      private static readonly System.IntPtr NativeFieldInfoPtr_WalkableMaskIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_FlightCollisionMaskIndex;
      [FieldOffset(0)]
      public int CellBaseHeightLevel;
      [FieldOffset(4)]
      public BlobArray<ChunkCellsBlob.TileLayer> TileLayers;
      [FieldOffset(12)]
      public int WalkableMaskIndex;
      [FieldOffset(16)]
      public int FlightCollisionMaskIndex;

      static TileCell()
      {
        Il2CppClassPointerStore<ChunkCellsBlob.TileCell>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkCellsBlob>.NativeClassPtr, nameof (TileCell));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkCellsBlob.TileCell>.NativeClassPtr);
        ChunkCellsBlob.TileCell.NativeFieldInfoPtr_CellBaseHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkCellsBlob.TileCell>.NativeClassPtr, nameof (CellBaseHeightLevel));
        ChunkCellsBlob.TileCell.NativeFieldInfoPtr_TileLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkCellsBlob.TileCell>.NativeClassPtr, nameof (TileLayers));
        ChunkCellsBlob.TileCell.NativeFieldInfoPtr_WalkableMaskIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkCellsBlob.TileCell>.NativeClassPtr, nameof (WalkableMaskIndex));
        ChunkCellsBlob.TileCell.NativeFieldInfoPtr_FlightCollisionMaskIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkCellsBlob.TileCell>.NativeClassPtr, nameof (FlightCollisionMaskIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkCellsBlob.TileCell>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TileLayer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockBuildingMaskIndex;
      [FieldOffset(0)]
      public int BlockBuildingMaskIndex;

      static TileLayer()
      {
        Il2CppClassPointerStore<ChunkCellsBlob.TileLayer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkCellsBlob>.NativeClassPtr, nameof (TileLayer));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkCellsBlob.TileLayer>.NativeClassPtr);
        ChunkCellsBlob.TileLayer.NativeFieldInfoPtr_BlockBuildingMaskIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkCellsBlob.TileLayer>.NativeClassPtr, nameof (BlockBuildingMaskIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkCellsBlob.TileLayer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
