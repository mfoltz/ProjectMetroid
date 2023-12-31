// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileCellMasksUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TileCellMasksUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumFlagCount_IncludeEmptyFlags_Public_Static_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBitCount_Public_Static_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLowestFlagIndex_Public_Static_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBitIndexInFlags_Public_Static_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerMask_Public_Static_BitMask2D_16x16_byref_UnsafeList_1_BitMask2D_16x16_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PushMasksToLayer_Public_Static_Void_byref_UnsafeList_1_BitMask2D_16x16_NativeArray_1_BitMask2D_16x16_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBitMask_Public_Static_byref_BitMask2D_16x16_NativeArray_1_BitMask2D_16x16_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791720, XrefRangeEnd = 791777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetEnumFlagCount_IncludeEmptyFlags<TEnum>() where TEnum : Il2CppSystem.Enum
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellMasksUtility.MethodInfoStoreGeneric_GetEnumFlagCount_IncludeEmptyFlags_Public_Static_Int32_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 257735, RefRangeEnd = 257739, XrefRangeStart = 257735, XrefRangeEnd = 257739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetBitCount(int flags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellMasksUtility.NativeMethodInfoPtr_GetBitCount_Public_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 791781, RefRangeEnd = 791786, XrefRangeStart = 791777, XrefRangeEnd = 791781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetLowestFlagIndex(int targetFlag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &targetFlag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellMasksUtility.NativeMethodInfoPtr_GetLowestFlagIndex_Public_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 791787, RefRangeEnd = 791790, XrefRangeStart = 791786, XrefRangeEnd = 791787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetBitIndexInFlags(int flags, int targetFlag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &flags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetFlag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellMasksUtility.NativeMethodInfoPtr_GetBitIndexInFlags_Public_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791790, XrefRangeEnd = 791795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BitMask2D_16x16 GetLayerMask(
      ref UnsafeList<BitMask2D_16x16> layerMasks,
      int setFlagsInLayer,
      int targetFlag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref layerMasks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &setFlagsInLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetFlag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellMasksUtility.NativeMethodInfoPtr_GetLayerMask_Public_Static_BitMask2D_16x16_byref_UnsafeList_1_BitMask2D_16x16_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791795, XrefRangeEnd = 791798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PushMasksToLayer(
      ref UnsafeList<BitMask2D_16x16> layerMasks,
      NativeArray<BitMask2D_16x16> bitmasks,
      int setMasks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref layerMasks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bitmasks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &setMasks;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileCellMasksUtility.NativeMethodInfoPtr_PushMasksToLayer_Public_Static_Void_byref_UnsafeList_1_BitMask2D_16x16_NativeArray_1_BitMask2D_16x16_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791798, XrefRangeEnd = 791804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static ref BitMask2D_16x16 GetBitMask(
      NativeArray<BitMask2D_16x16> fullBitmaskArray,
      int bitMaskIndex)
    {
      // ISSUE: unable to decompile the method.
    }

    static TileCellMasksUtility()
    {
      Il2CppClassPointerStore<TileCellMasksUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileCellMasksUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCellMasksUtility>.NativeClassPtr);
      TileCellMasksUtility.NativeMethodInfoPtr_GetEnumFlagCount_IncludeEmptyFlags_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellMasksUtility>.NativeClassPtr, 100669651);
      TileCellMasksUtility.NativeMethodInfoPtr_GetBitCount_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellMasksUtility>.NativeClassPtr, 100669652);
      TileCellMasksUtility.NativeMethodInfoPtr_GetLowestFlagIndex_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellMasksUtility>.NativeClassPtr, 100669653);
      TileCellMasksUtility.NativeMethodInfoPtr_GetBitIndexInFlags_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellMasksUtility>.NativeClassPtr, 100669654);
      TileCellMasksUtility.NativeMethodInfoPtr_GetLayerMask_Public_Static_BitMask2D_16x16_byref_UnsafeList_1_BitMask2D_16x16_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellMasksUtility>.NativeClassPtr, 100669655);
      TileCellMasksUtility.NativeMethodInfoPtr_PushMasksToLayer_Public_Static_Void_byref_UnsafeList_1_BitMask2D_16x16_NativeArray_1_BitMask2D_16x16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellMasksUtility>.NativeClassPtr, 100669656);
      TileCellMasksUtility.NativeMethodInfoPtr_GetBitMask_Public_Static_byref_BitMask2D_16x16_NativeArray_1_BitMask2D_16x16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellMasksUtility>.NativeClassPtr, 100669657);
    }

    public TileCellMasksUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_GetEnumFlagCount_IncludeEmptyFlags_Public_Static_Int32_0<TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileCellMasksUtility.NativeMethodInfoPtr_GetEnumFlagCount_IncludeEmptyFlags_Public_Static_Int32_0, Il2CppClassPointerStore<TileCellMasksUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }
  }
}
