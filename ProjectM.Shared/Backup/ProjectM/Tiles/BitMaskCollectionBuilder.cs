// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BitMaskCollectionBuilder
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BitMaskCollectionBuilder
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaskList;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaskToIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterMask_Public_Int32_BitMask2D_16x16_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    [FieldOffset(0)]
    public NativeList<BitMask2D_16x16> MaskList;
    [FieldOffset(16)]
    public NativeHashMap<BitMask2D_16x16, int> MaskToIndex;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 790832, RefRangeEnd = 790834, XrefRangeStart = 790826, XrefRangeEnd = 790832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMaskCollectionBuilder(int capacity, Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &capacity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitMaskCollectionBuilder.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 790847, RefRangeEnd = 790851, XrefRangeStart = 790834, XrefRangeEnd = 790847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int RegisterMask(BitMask2D_16x16 mask, out bool addedNewMask)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &mask;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref addedNewMask;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitMaskCollectionBuilder.NativeMethodInfoPtr_RegisterMask_Public_Int32_BitMask2D_16x16_byref_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 790863, RefRangeEnd = 790865, XrefRangeStart = 790851, XrefRangeEnd = 790863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitMaskCollectionBuilder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790871, RefRangeEnd = 790872, XrefRangeStart = 790865, XrefRangeEnd = 790871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BitMaskCollectionBuilder.NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BitMaskCollectionBuilder()
    {
      Il2CppClassPointerStore<BitMaskCollectionBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (BitMaskCollectionBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitMaskCollectionBuilder>.NativeClassPtr);
      BitMaskCollectionBuilder.NativeFieldInfoPtr_MaskList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMaskCollectionBuilder>.NativeClassPtr, nameof (MaskList));
      BitMaskCollectionBuilder.NativeFieldInfoPtr_MaskToIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMaskCollectionBuilder>.NativeClassPtr, nameof (MaskToIndex));
      BitMaskCollectionBuilder.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMaskCollectionBuilder>.NativeClassPtr, 100669599);
      BitMaskCollectionBuilder.NativeMethodInfoPtr_RegisterMask_Public_Int32_BitMask2D_16x16_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMaskCollectionBuilder>.NativeClassPtr, 100669600);
      BitMaskCollectionBuilder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMaskCollectionBuilder>.NativeClassPtr, 100669601);
      BitMaskCollectionBuilder.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMaskCollectionBuilder>.NativeClassPtr, 100669602);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitMaskCollectionBuilder>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
