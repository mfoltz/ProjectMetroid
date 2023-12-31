// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BitMask2D_32x32
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BitMask2D_32x32
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Cell0_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cell1_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cell0_1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cell1_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCell8ByMorton_Public_Static_byref_UInt64_byref_BitMask2D_32x32_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCell16_Public_Static_byref_BitMask2D_16x16_byref_BitMask2D_32x32_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCell16ByMorton_Private_Static_byref_BitMask2D_16x16_byref_BitMask2D_32x32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBit_Public_Boolean_int2_0;
    [FieldOffset(0)]
    public BitMask2D_16x16 Cell0_0;
    [FieldOffset(32)]
    public BitMask2D_16x16 Cell1_0;
    [FieldOffset(64)]
    public BitMask2D_16x16 Cell0_1;
    [FieldOffset(96)]
    public BitMask2D_16x16 Cell1_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790907, XrefRangeEnd = 790908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static ref ulong GetCell8ByMorton(ref BitMask2D_32x32 data, int2 cell)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790908, XrefRangeEnd = 790909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static ref BitMask2D_16x16 GetCell16(ref BitMask2D_32x32 data, int2 cell)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(0)]
    public static ref BitMask2D_16x16 GetCell16ByMorton(ref BitMask2D_32x32 data, int morton)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790909, XrefRangeEnd = 790924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetBit(int2 coordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &coordinate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMask2D_32x32.NativeMethodInfoPtr_GetBit_Public_Boolean_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BitMask2D_32x32()
    {
      Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (BitMask2D_32x32));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr);
      BitMask2D_32x32.NativeFieldInfoPtr_Cell0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr, nameof (Cell0_0));
      BitMask2D_32x32.NativeFieldInfoPtr_Cell1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr, nameof (Cell1_0));
      BitMask2D_32x32.NativeFieldInfoPtr_Cell0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr, nameof (Cell0_1));
      BitMask2D_32x32.NativeFieldInfoPtr_Cell1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr, nameof (Cell1_1));
      BitMask2D_32x32.NativeMethodInfoPtr_GetCell8ByMorton_Public_Static_byref_UInt64_byref_BitMask2D_32x32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr, 100669617);
      BitMask2D_32x32.NativeMethodInfoPtr_GetCell16_Public_Static_byref_BitMask2D_16x16_byref_BitMask2D_32x32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr, 100669618);
      BitMask2D_32x32.NativeMethodInfoPtr_GetCell16ByMorton_Private_Static_byref_BitMask2D_16x16_byref_BitMask2D_32x32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr, 100669619);
      BitMask2D_32x32.NativeMethodInfoPtr_GetBit_Public_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr, 100669620);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitMask2D_32x32>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
