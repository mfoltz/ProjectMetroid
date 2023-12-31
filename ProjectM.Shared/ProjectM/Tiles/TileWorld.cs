// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileWorld
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
  public struct TileWorld
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldCells;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldCellCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidCellId_Public_Boolean_TileCellCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellIndex_Public_Int32_TileCellCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCell_Public_Boolean_TileCellCoordinate_byref_TileCell_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCellIdForWorldTile_Public_Boolean_int2_byref_TileCellCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayHeight_Public_Single_byref_float3_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGameplayHeight_Public_Boolean_byref_float3_byref_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGameplayHeightBilinear_Private_Boolean_int2x4_Byte_float2_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGameplayHeight_Public_Boolean_int2_Byte_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_int2_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCellTileLayer_Public_Boolean_TileCoordinate_byref_TileCell_byref_TileLayer_byref_int2_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCellTileLayer_Public_Boolean_int2_Byte_byref_TileCell_byref_TileLayer_byref_int2_Boolean_0;
    [FieldOffset(0)]
    public NativeArray<TileCellData> WorldCells;
    [FieldOffset(16)]
    public int2 WorldCellCount;

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 792623, RefRangeEnd = 792633, XrefRangeStart = 792623, XrefRangeEnd = 792623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidCellId(TileCellCoordinate cellCoordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cellCoordinate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_IsValidCellId_Public_Boolean_TileCellCoordinate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 792633, RefRangeEnd = 792635, XrefRangeStart = 792633, XrefRangeEnd = 792633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetCellIndex(TileCellCoordinate cellCoordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cellCoordinate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_GetCellIndex_Public_Int32_TileCellCoordinate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(32)]
    [CachedScanResults(RefRangeStart = 792642, RefRangeEnd = 792674, XrefRangeStart = 792635, XrefRangeEnd = 792642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetCell(TileCellCoordinate cellCoordinate, out TileCell cell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cellCoordinate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cell;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_TryGetCell_Public_Boolean_TileCellCoordinate_byref_TileCell_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 792674, RefRangeEnd = 792683, XrefRangeStart = 792674, XrefRangeEnd = 792674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetCellIdForWorldTile(
      int2 worldTile,
      out TileCellCoordinate cellCoordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cellCoordinate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_TryGetCellIdForWorldTile_Public_Boolean_int2_byref_TileCellCoordinate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 792684, RefRangeEnd = 792699, XrefRangeStart = 792683, XrefRangeEnd = 792684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetGameplayHeight([In] ref float3 worldPosition, bool bilinearInterpolate = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bilinearInterpolate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_GetGameplayHeight_Public_Single_byref_float3_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 792706, RefRangeEnd = 792715, XrefRangeStart = 792699, XrefRangeEnd = 792706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetGameplayHeight(
      [In] ref float3 worldPosition,
      out float gameplayHeight,
      bool bilinearInterpolate = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayHeight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bilinearInterpolate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_TryGetGameplayHeight_Public_Boolean_byref_float3_byref_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792740, RefRangeEnd = 792741, XrefRangeStart = 792715, XrefRangeEnd = 792740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetGameplayHeightBilinear(
      int2x4 tiles,
      byte heightLevel,
      float2 tileT,
      out float gameplayHeight)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &tiles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileT;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_TryGetGameplayHeightBilinear_Private_Boolean_int2x4_Byte_float2_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 792748, RefRangeEnd = 792753, XrefRangeStart = 792741, XrefRangeEnd = 792748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetGameplayHeight(
      int2 worldTile,
      byte heightLevel,
      out float gameplayHeight)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_TryGetGameplayHeight_Public_Boolean_int2_Byte_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 792769, RefRangeEnd = 792776, XrefRangeStart = 792753, XrefRangeEnd = 792769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetIsGrounded(int2 worldTile, byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_int2_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792777, RefRangeEnd = 792778, XrefRangeStart = 792776, XrefRangeEnd = 792777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetCellTileLayer(
      TileCoordinate tileCoordinate,
      out TileCell tileCell,
      out TileLayer tileLayer,
      out int2 tileInCell,
      bool clampHeightLevel = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &tileCoordinate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileInCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &clampHeightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_TryGetCellTileLayer_Public_Boolean_TileCoordinate_byref_TileCell_byref_TileLayer_byref_int2_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 792781, RefRangeEnd = 792786, XrefRangeStart = 792778, XrefRangeEnd = 792781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetCellTileLayer(
      int2 worldTile,
      byte heightLevel,
      out TileCell tileCell,
      out TileLayer tileLayer,
      out int2 tileInCell,
      bool clampHeightLevel = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileInCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &clampHeightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorld.NativeMethodInfoPtr_TryGetCellTileLayer_Public_Boolean_int2_Byte_byref_TileCell_byref_TileLayer_byref_int2_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileWorld()
    {
      Il2CppClassPointerStore<TileWorld>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileWorld));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileWorld>.NativeClassPtr);
      TileWorld.NativeFieldInfoPtr_WorldCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, nameof (WorldCells));
      TileWorld.NativeFieldInfoPtr_WorldCellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, nameof (WorldCellCount));
      TileWorld.NativeMethodInfoPtr_IsValidCellId_Public_Boolean_TileCellCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669789);
      TileWorld.NativeMethodInfoPtr_GetCellIndex_Public_Int32_TileCellCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669790);
      TileWorld.NativeMethodInfoPtr_TryGetCell_Public_Boolean_TileCellCoordinate_byref_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669791);
      TileWorld.NativeMethodInfoPtr_TryGetCellIdForWorldTile_Public_Boolean_int2_byref_TileCellCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669792);
      TileWorld.NativeMethodInfoPtr_GetGameplayHeight_Public_Single_byref_float3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669793);
      TileWorld.NativeMethodInfoPtr_TryGetGameplayHeight_Public_Boolean_byref_float3_byref_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669794);
      TileWorld.NativeMethodInfoPtr_TryGetGameplayHeightBilinear_Private_Boolean_int2x4_Byte_float2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669795);
      TileWorld.NativeMethodInfoPtr_TryGetGameplayHeight_Public_Boolean_int2_Byte_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669796);
      TileWorld.NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_int2_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669797);
      TileWorld.NativeMethodInfoPtr_TryGetCellTileLayer_Public_Boolean_TileCoordinate_byref_TileCell_byref_TileLayer_byref_int2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669798);
      TileWorld.NativeMethodInfoPtr_TryGetCellTileLayer_Public_Boolean_int2_Byte_byref_TileCell_byref_TileLayer_byref_int2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, 100669799);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileWorld>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
