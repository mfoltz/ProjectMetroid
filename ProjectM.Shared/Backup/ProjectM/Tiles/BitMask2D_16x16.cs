// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BitMask2D_16x16
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BitMask2D_16x16
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SubCell_0_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubCell_1_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubCell_0_1;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubCell_1_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBit_Public_Void_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBitPos_Public_Static_BitMask2D_16x16_BitPos_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBit_Public_Void_Int32_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBit_Public_Void_int2_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBit_Public_Void_BitMask2D_16x16_BitPos_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSet_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSet_Public_Boolean_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSet_Public_Boolean_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSet_Public_Boolean_BitMask2D_16x16_BitPos_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSubCell_Public_BitField64_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_BitCellEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EmptyCell_Public_Static_BitMask2D_16x16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FullCell_Public_Static_BitMask2D_16x16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FillCell_Public_Static_Void_byref_BitMask2D_16x16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitMask2D_16x16_BitMask2D_16x16_BitMask2D_16x16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitMask2D_16x16_BitMask2D_16x16_BitMask2D_16x16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BitMask2D_16x16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitMask2D_16x16_BitMask2D_16x16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitMask2D_16x16_BitMask2D_16x16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InternalEquals_Private_Static_Boolean_byref_BitMask2D_16x16_byref_BitMask2D_16x16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToVisualString_Public_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToVisualString2_Public_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ByteToString_Private_Static_String_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_String_PDM_0;
    [FieldOffset(0)]
    public BitField64 SubCell_0_0;
    [FieldOffset(8)]
    public BitField64 SubCell_1_0;
    [FieldOffset(16)]
    public BitField64 SubCell_0_1;
    [FieldOffset(24)]
    public BitField64 SubCell_1_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790924, XrefRangeEnd = 790930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetBit(int index, bool value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_SetBit_Public_Void_Int32_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790930, RefRangeEnd = 790931, XrefRangeStart = 790930, XrefRangeEnd = 790930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BitMask2D_16x16_BitPos GetBitPos(int2 bitCoordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &bitCoordinate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_GetBitPos_Public_Static_BitMask2D_16x16_BitPos_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16_BitPos*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 790932, RefRangeEnd = 790951, XrefRangeStart = 790931, XrefRangeEnd = 790932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetBit(int bitCoordinateX, int bitCoordinateY, bool value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &bitCoordinateX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bitCoordinateY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_SetBit_Public_Void_Int32_Int32_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790952, RefRangeEnd = 790953, XrefRangeStart = 790951, XrefRangeEnd = 790952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetBit(int2 bitCoordinate, bool value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &bitCoordinate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_SetBit_Public_Void_int2_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790953, XrefRangeEnd = 790954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetBit(BitMask2D_16x16_BitPos bitPos, bool value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &bitPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_SetBit_Public_Void_BitMask2D_16x16_BitPos_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790954, XrefRangeEnd = 790960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSet(int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_IsSet_Public_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 790961, RefRangeEnd = 790971, XrefRangeStart = 790960, XrefRangeEnd = 790961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSet(int bitCoordinateX, int bitCoordinateY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &bitCoordinateX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bitCoordinateY;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_IsSet_Public_Boolean_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 790972, RefRangeEnd = 790986, XrefRangeStart = 790971, XrefRangeEnd = 790972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSet(int2 bitCoordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &bitCoordinate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_IsSet_Public_Boolean_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 790987, RefRangeEnd = 790990, XrefRangeStart = 790986, XrefRangeEnd = 790987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSet(BitMask2D_16x16_BitPos bitPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &bitPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_IsSet_Public_Boolean_BitMask2D_16x16_BitPos_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe BitField64 GetSubCell(byte subCellIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &subCellIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_GetSubCell_Public_BitField64_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitField64*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe BitCellEnumerator GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_GetEnumerator_Public_BitCellEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitCellEnumerator*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 331100, RefRangeEnd = 331104, XrefRangeStart = 331100, XrefRangeEnd = 331104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BitMask2D_16x16 EmptyCell()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_EmptyCell_Public_Static_BitMask2D_16x16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe BitMask2D_16x16 FullCell()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_FullCell_Public_Static_BitMask2D_16x16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe void FillCell(ref BitMask2D_16x16 mask2D)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref mask2D;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_FillCell_Public_Static_Void_byref_BitMask2D_16x16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 790990, RefRangeEnd = 791001, XrefRangeStart = 790990, XrefRangeEnd = 790990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BitMask2D_16x16 operator &(BitMask2D_16x16 a, BitMask2D_16x16 b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitMask2D_16x16_BitMask2D_16x16_BitMask2D_16x16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 791001, RefRangeEnd = 791004, XrefRangeStart = 791001, XrefRangeEnd = 791001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BitMask2D_16x16 operator |(BitMask2D_16x16 a, BitMask2D_16x16 b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitMask2D_16x16_BitMask2D_16x16_BitMask2D_16x16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 791004, RefRangeEnd = 791005, XrefRangeStart = 791004, XrefRangeEnd = 791004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(BitMask2D_16x16 other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BitMask2D_16x16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator !=(BitMask2D_16x16 guid1, BitMask2D_16x16 guid2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &guid1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &guid2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitMask2D_16x16_BitMask2D_16x16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 791004, RefRangeEnd = 791005, XrefRangeStart = 791004, XrefRangeEnd = 791005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(BitMask2D_16x16 guid1, BitMask2D_16x16 guid2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &guid1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &guid2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitMask2D_16x16_BitMask2D_16x16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791005, XrefRangeEnd = 791008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 791004, RefRangeEnd = 791005, XrefRangeStart = 791004, XrefRangeEnd = 791005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool InternalEquals([In] ref BitMask2D_16x16 a, [In] ref BitMask2D_16x16 b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_InternalEquals_Private_Static_Boolean_byref_BitMask2D_16x16_byref_BitMask2D_16x16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791008, XrefRangeEnd = 791009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 791009, RefRangeEnd = 791022, XrefRangeStart = 791009, XrefRangeEnd = 791009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEmpty()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791022, XrefRangeEnd = 791037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string ToVisualString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_ToVisualString_Public_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791037, XrefRangeEnd = 791669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string ToVisualString2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_ToVisualString2_Public_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(32)]
    [CachedScanResults(RefRangeStart = 791678, RefRangeEnd = 791710, XrefRangeStart = 791669, XrefRangeEnd = 791678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ByteToString(byte b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_ByteToString_Private_Static_String_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791710, XrefRangeEnd = 791714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Method_Internal_Static_String_String_PDM_0(string s)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(s);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BitMask2D_16x16.NativeMethodInfoPtr_Method_Internal_Static_String_String_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static BitMask2D_16x16()
    {
      Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (BitMask2D_16x16));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr);
      BitMask2D_16x16.NativeFieldInfoPtr_SubCell_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, nameof (SubCell_0_0));
      BitMask2D_16x16.NativeFieldInfoPtr_SubCell_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, nameof (SubCell_1_0));
      BitMask2D_16x16.NativeFieldInfoPtr_SubCell_0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, nameof (SubCell_0_1));
      BitMask2D_16x16.NativeFieldInfoPtr_SubCell_1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, nameof (SubCell_1_1));
      BitMask2D_16x16.NativeMethodInfoPtr_SetBit_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669621);
      BitMask2D_16x16.NativeMethodInfoPtr_GetBitPos_Public_Static_BitMask2D_16x16_BitPos_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669622);
      BitMask2D_16x16.NativeMethodInfoPtr_SetBit_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669623);
      BitMask2D_16x16.NativeMethodInfoPtr_SetBit_Public_Void_int2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669624);
      BitMask2D_16x16.NativeMethodInfoPtr_SetBit_Public_Void_BitMask2D_16x16_BitPos_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669625);
      BitMask2D_16x16.NativeMethodInfoPtr_IsSet_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669626);
      BitMask2D_16x16.NativeMethodInfoPtr_IsSet_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669627);
      BitMask2D_16x16.NativeMethodInfoPtr_IsSet_Public_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669628);
      BitMask2D_16x16.NativeMethodInfoPtr_IsSet_Public_Boolean_BitMask2D_16x16_BitPos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669629);
      BitMask2D_16x16.NativeMethodInfoPtr_GetSubCell_Public_BitField64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669630);
      BitMask2D_16x16.NativeMethodInfoPtr_GetEnumerator_Public_BitCellEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669631);
      BitMask2D_16x16.NativeMethodInfoPtr_EmptyCell_Public_Static_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669632);
      BitMask2D_16x16.NativeMethodInfoPtr_FullCell_Public_Static_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669633);
      BitMask2D_16x16.NativeMethodInfoPtr_FillCell_Public_Static_Void_byref_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669634);
      BitMask2D_16x16.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitMask2D_16x16_BitMask2D_16x16_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669635);
      BitMask2D_16x16.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitMask2D_16x16_BitMask2D_16x16_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669636);
      BitMask2D_16x16.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669637);
      BitMask2D_16x16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitMask2D_16x16_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669638);
      BitMask2D_16x16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitMask2D_16x16_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669639);
      BitMask2D_16x16.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669640);
      BitMask2D_16x16.NativeMethodInfoPtr_InternalEquals_Private_Static_Boolean_byref_BitMask2D_16x16_byref_BitMask2D_16x16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669641);
      BitMask2D_16x16.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669642);
      BitMask2D_16x16.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669643);
      BitMask2D_16x16.NativeMethodInfoPtr_ToVisualString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669644);
      BitMask2D_16x16.NativeMethodInfoPtr_ToVisualString2_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669645);
      BitMask2D_16x16.NativeMethodInfoPtr_ByteToString_Private_Static_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669646);
      BitMask2D_16x16.NativeMethodInfoPtr_Method_Internal_Static_String_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, 100669647);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitMask2D_16x16>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
