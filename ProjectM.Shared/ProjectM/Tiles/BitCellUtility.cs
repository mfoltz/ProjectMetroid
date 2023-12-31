// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BitCellUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public static class BitCellUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_FillBounds_Public_Static_Void_byref_BitMask2D_16x16_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FillBounds_Public_Static_Void_NativeArray_1_BitMask2D_16x16_int2_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Shift_Public_Static_BitMask2D_32x32_BitMask2D_16x16_int2_byref_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateCellShift_Private_Static_Void_Int32_byref_Int32_byref_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Shift_Into_Private_Static_Void_ptr_UInt64_int2_ptr_UInt64_int2_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShiftingMaskX_Public_Static_Void_Int32_byref_UInt64_byref_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InvertRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_Static_BitMask2D_16x16_byref_BitMask2D_16x16_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReflectVertical_Private_Static_UInt64_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReflectHorizontal_Private_Static_UInt64_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReflectDiagonal_Private_Static_UInt64_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate90_Private_Static_UInt64_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate180_Private_Static_UInt64_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate270_Private_Static_UInt64_UInt64_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 790877, RefRangeEnd = 790879, XrefRangeStart = 790872, XrefRangeEnd = 790877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FillBounds(ref BitMask2D_16x16 mask2D, BoundsMinMax localCellBounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref mask2D;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localCellBounds;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_FillBounds_Public_Static_Void_byref_BitMask2D_16x16_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790879, XrefRangeEnd = 790883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FillBounds(
      NativeArray<BitMask2D_16x16> area,
      int2 areaCellCount,
      BoundsMinMax areaBounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &area;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &areaCellCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &areaBounds;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_FillBounds_Public_Static_Void_NativeArray_1_BitMask2D_16x16_int2_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790883, XrefRangeEnd = 790884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BitMask2D_32x32 Shift(
      BitMask2D_16x16 mask2D,
      int2 shift,
      out int2 resultCellOffset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &mask2D;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shift;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref resultCellOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_Shift_Public_Static_BitMask2D_32x32_BitMask2D_16x16_int2_byref_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_32x32*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe void CalculateCellShift(
      int shift,
      out int shiftSubCells,
      out byte shifSubCellLines)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &shift;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref shiftSubCells;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref shifSubCellLines;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_CalculateCellShift_Private_Static_Void_Int32_byref_Int32_byref_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790898, RefRangeEnd = 790899, XrefRangeStart = 790884, XrefRangeEnd = 790898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Shift_Into(
      ulong* fromCells,
      int2 processFromCellSize,
      ulong* toCells,
      int2 shiftCells,
      int2 shiftSubCell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) (void*) fromCells;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &processFromCellSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) toCells;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &shiftCells;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &shiftSubCell;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_Shift_Into_Private_Static_Void_ptr_UInt64_int2_ptr_UInt64_int2_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe void GetShiftingMaskX(int shiftBitsX0, out ulong xMask0, out ulong xMask1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &shiftBitsX0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref xMask0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref xMask1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_GetShiftingMaskX_Public_Static_Void_Int32_byref_UInt64_byref_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790899, RefRangeEnd = 790900, XrefRangeStart = 790899, XrefRangeEnd = 790899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe OrthogonalRotation InvertRotation(OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_InvertRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(OrthogonalRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 790900, RefRangeEnd = 790903, XrefRangeStart = 790900, XrefRangeEnd = 790900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BitMask2D_16x16 Rotate(
      [In] ref BitMask2D_16x16 bitMask2D,
      OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref bitMask2D;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_Rotate_Public_Static_BitMask2D_16x16_byref_BitMask2D_16x16_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe ulong ReflectVertical(ulong value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_ReflectVertical_Private_Static_UInt64_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe ulong ReflectHorizontal(ulong value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_ReflectHorizontal_Private_Static_UInt64_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 790903, RefRangeEnd = 790905, XrefRangeStart = 790903, XrefRangeEnd = 790903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ulong ReflectDiagonal(ulong value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_ReflectDiagonal_Private_Static_UInt64_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790905, XrefRangeEnd = 790906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ulong Rotate90(ulong value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_Rotate90_Private_Static_UInt64_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe ulong Rotate180(ulong value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_Rotate180_Private_Static_UInt64_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790906, XrefRangeEnd = 790907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ulong Rotate270(ulong value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitCellUtility.NativeMethodInfoPtr_Rotate270_Private_Static_UInt64_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BitCellUtility()
    {
      Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (BitCellUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr);
      BitCellUtility.NativeMethodInfoPtr_FillBounds_Public_Static_Void_byref_BitMask2D_16x16_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669603);
      BitCellUtility.NativeMethodInfoPtr_FillBounds_Public_Static_Void_NativeArray_1_BitMask2D_16x16_int2_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669604);
      BitCellUtility.NativeMethodInfoPtr_Shift_Public_Static_BitMask2D_32x32_BitMask2D_16x16_int2_byref_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669605);
      BitCellUtility.NativeMethodInfoPtr_CalculateCellShift_Private_Static_Void_Int32_byref_Int32_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669606);
      BitCellUtility.NativeMethodInfoPtr_Shift_Into_Private_Static_Void_ptr_UInt64_int2_ptr_UInt64_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669607);
      BitCellUtility.NativeMethodInfoPtr_GetShiftingMaskX_Public_Static_Void_Int32_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669608);
      BitCellUtility.NativeMethodInfoPtr_InvertRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669609);
      BitCellUtility.NativeMethodInfoPtr_Rotate_Public_Static_BitMask2D_16x16_byref_BitMask2D_16x16_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669610);
      BitCellUtility.NativeMethodInfoPtr_ReflectVertical_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669611);
      BitCellUtility.NativeMethodInfoPtr_ReflectHorizontal_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669612);
      BitCellUtility.NativeMethodInfoPtr_ReflectDiagonal_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669613);
      BitCellUtility.NativeMethodInfoPtr_Rotate90_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669614);
      BitCellUtility.NativeMethodInfoPtr_Rotate180_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669615);
      BitCellUtility.NativeMethodInfoPtr_Rotate270_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellUtility>.NativeClassPtr, 100669616);
    }

    public BitCellUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
