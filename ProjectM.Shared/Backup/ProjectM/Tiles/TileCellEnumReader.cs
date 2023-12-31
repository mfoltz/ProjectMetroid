// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileCellEnumReader
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileCellEnumReader
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AllBitMasks;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileEnum_Public_Int32_TileCell_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileEnum_Public_Int32_TileCell_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedBitMask_OR_Public_BitMask2D_16x16_TileCell_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedBitMask_AND_Public_BitMask2D_16x16_TileCell_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddFlagMask_Public_Void_Int32_Byte_0;
    [FieldOffset(0)]
    public FixedList64<TileCellEnumReader.MaskData> _AllBitMasks;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792587, RefRangeEnd = 792588, XrefRangeStart = 792586, XrefRangeEnd = 792587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetTileEnum(TileCell cell, int tileX, int tileY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &cell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileY;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellEnumReader.NativeMethodInfoPtr_GetTileEnum_Public_Int32_TileCell_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 792594, RefRangeEnd = 792601, XrefRangeStart = 792588, XrefRangeEnd = 792594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetTileEnum(TileCell cell, int2 tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellEnumReader.NativeMethodInfoPtr_GetTileEnum_Public_Int32_TileCell_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792608, RefRangeEnd = 792609, XrefRangeStart = 792601, XrefRangeEnd = 792608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetCombinedBitMask_OR(TileCell cell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cell;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellEnumReader.NativeMethodInfoPtr_GetCombinedBitMask_OR_Public_BitMask2D_16x16_TileCell_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792609, XrefRangeEnd = 792616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetCombinedBitMask_AND(TileCell cell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cell;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellEnumReader.NativeMethodInfoPtr_GetCombinedBitMask_AND_Public_BitMask2D_16x16_TileCell_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792616, XrefRangeEnd = 792619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileCellEnumReader.NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792622, RefRangeEnd = 792623, XrefRangeStart = 792619, XrefRangeEnd = 792622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddFlagMask(int flag, byte indexInCell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &flag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &indexInCell;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileCellEnumReader.NativeMethodInfoPtr_AddFlagMask_Public_Void_Int32_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileCellEnumReader()
    {
      Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileCellEnumReader));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr);
      TileCellEnumReader.NativeFieldInfoPtr__AllBitMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr, nameof (_AllBitMasks));
      TileCellEnumReader.NativeMethodInfoPtr_GetTileEnum_Public_Int32_TileCell_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr, 100669783);
      TileCellEnumReader.NativeMethodInfoPtr_GetTileEnum_Public_Int32_TileCell_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr, 100669784);
      TileCellEnumReader.NativeMethodInfoPtr_GetCombinedBitMask_OR_Public_BitMask2D_16x16_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr, 100669785);
      TileCellEnumReader.NativeMethodInfoPtr_GetCombinedBitMask_AND_Public_BitMask2D_16x16_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr, 100669786);
      TileCellEnumReader.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr, 100669787);
      TileCellEnumReader.NativeMethodInfoPtr_AddFlagMask_Public_Void_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr, 100669788);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MaskData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IndexInCell;
      private static readonly System.IntPtr NativeFieldInfoPtr_Flag;
      [FieldOffset(0)]
      public byte IndexInCell;
      [FieldOffset(4)]
      public int Flag;

      static MaskData()
      {
        Il2CppClassPointerStore<TileCellEnumReader.MaskData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileCellEnumReader>.NativeClassPtr, nameof (MaskData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCellEnumReader.MaskData>.NativeClassPtr);
        TileCellEnumReader.MaskData.NativeFieldInfoPtr_IndexInCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellEnumReader.MaskData>.NativeClassPtr, nameof (IndexInCell));
        TileCellEnumReader.MaskData.NativeFieldInfoPtr_Flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellEnumReader.MaskData>.NativeClassPtr, nameof (Flag));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileCellEnumReader.MaskData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
