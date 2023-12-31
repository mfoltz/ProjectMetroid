// Decompiled with JetBrains decompiler
// Type: NativeArrayUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
public static class NativeArrayUtilities : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearTileArrayBounds_Public_Static_Void_NativeArray_1_T_BoundsMinMax_int2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyWithinBounds_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_byref_BoundsMinMax_int2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyArrayArea_Public_Static_Void_NativeArray_1_T_int2_int2_NativeArray_1_T_int2_int2_int2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyArrayArea_Public_Static_Void_NativeSlice_1_T_int2_int2_NativeSlice_1_T_int2_int2_int2_0;

  [CallerCount(0)]
  public static unsafe void ClearTileArrayBounds<T>(
    this NativeArray<T> array,
    BoundsMinMax arrayBounds,
    int2 arraySize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &array;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayBounds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arraySize;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NativeArrayUtilities.MethodInfoStoreGeneric_ClearTileArrayBounds_Public_Static_Void_NativeArray_1_T_BoundsMinMax_int2_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public static unsafe void CopyWithinBounds<T>(
    NativeArray<T> src,
    NativeArray<T> dst,
    [In] ref BoundsMinMax arrayBounds,
    int2 arraySize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &src;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dst;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayBounds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &arraySize;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NativeArrayUtilities.MethodInfoStoreGeneric_CopyWithinBounds_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_byref_BoundsMinMax_int2_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 716176, RefRangeEnd = 716177, XrefRangeStart = 716174, XrefRangeEnd = 716176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyArrayArea<T>(
    NativeArray<T> src,
    int2 srcStart,
    int2 srcArraySize,
    NativeArray<T> dst,
    int2 dstStart,
    int2 dstArraySize,
    int2 copyAreaSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &src;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcArraySize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dst;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dstStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dstArraySize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &copyAreaSize;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NativeArrayUtilities.MethodInfoStoreGeneric_CopyArrayArea_Public_Static_Void_NativeArray_1_T_int2_int2_NativeArray_1_T_int2_int2_int2_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716177, XrefRangeEnd = 716178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyArrayArea<T>(
    NativeSlice<T> src,
    int2 srcStart,
    int2 srcArraySize,
    NativeSlice<T> dst,
    int2 dstStart,
    int2 dstArraySize,
    int2 copyAreaSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &src;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcArraySize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dst;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dstStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dstArraySize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &copyAreaSize;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NativeArrayUtilities.MethodInfoStoreGeneric_CopyArrayArea_Public_Static_Void_NativeSlice_1_T_int2_int2_NativeSlice_1_T_int2_int2_int2_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NativeArrayUtilities()
  {
    Il2CppClassPointerStore<NativeArrayUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (NativeArrayUtilities));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayUtilities>.NativeClassPtr);
    NativeArrayUtilities.NativeMethodInfoPtr_ClearTileArrayBounds_Public_Static_Void_NativeArray_1_T_BoundsMinMax_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUtilities>.NativeClassPtr, 100663437);
    NativeArrayUtilities.NativeMethodInfoPtr_CopyWithinBounds_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_byref_BoundsMinMax_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUtilities>.NativeClassPtr, 100663438);
    NativeArrayUtilities.NativeMethodInfoPtr_CopyArrayArea_Public_Static_Void_NativeArray_1_T_int2_int2_NativeArray_1_T_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUtilities>.NativeClassPtr, 100663439);
    NativeArrayUtilities.NativeMethodInfoPtr_CopyArrayArea_Public_Static_Void_NativeSlice_1_T_int2_int2_NativeSlice_1_T_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUtilities>.NativeClassPtr, 100663440);
  }

  public NativeArrayUtilities(System.IntPtr pointer)
    : base(pointer)
  {
  }

  private sealed class MethodInfoStoreGeneric_ClearTileArrayBounds_Public_Static_Void_NativeArray_1_T_BoundsMinMax_int2_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUtilities.NativeMethodInfoPtr_ClearTileArrayBounds_Public_Static_Void_NativeArray_1_T_BoundsMinMax_int2_0, Il2CppClassPointerStore<NativeArrayUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_CopyWithinBounds_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_byref_BoundsMinMax_int2_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUtilities.NativeMethodInfoPtr_CopyWithinBounds_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_byref_BoundsMinMax_int2_0, Il2CppClassPointerStore<NativeArrayUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_CopyArrayArea_Public_Static_Void_NativeArray_1_T_int2_int2_NativeArray_1_T_int2_int2_int2_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUtilities.NativeMethodInfoPtr_CopyArrayArea_Public_Static_Void_NativeArray_1_T_int2_int2_NativeArray_1_T_int2_int2_int2_0, Il2CppClassPointerStore<NativeArrayUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_CopyArrayArea_Public_Static_Void_NativeSlice_1_T_int2_int2_NativeSlice_1_T_int2_int2_int2_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUtilities.NativeMethodInfoPtr_CopyArrayArea_Public_Static_Void_NativeSlice_1_T_int2_int2_NativeSlice_1_T_int2_int2_int2_0, Il2CppClassPointerStore<NativeArrayUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
