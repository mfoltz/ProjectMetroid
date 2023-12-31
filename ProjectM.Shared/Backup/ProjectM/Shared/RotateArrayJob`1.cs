// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.RotateArrayJob`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Terrain;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Shared
{
  public struct RotateArrayJob<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Array;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArrayDimensions;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RotateArray_Public_Static_Void_NativeArray_1_T_int2_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate90_Public_Static_Void_NativeArray_1_T_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate270_Public_Static_Void_NativeArray_1_T_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate180_Public_Static_Void_NativeArray_1_T_int2_0;
    public NativeArray<T> Array;
    public int2 ArrayDimensions;
    public OrthogonalRotation Rotation;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803001, XrefRangeEnd = 803003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RotateArrayJob<T>.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 803011, RefRangeEnd = 803018, XrefRangeStart = 803003, XrefRangeEnd = 803011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RotateArray(
      NativeArray<T> array,
      int2 arrayDimensions,
      OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &array;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayDimensions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RotateArrayJob<T>.NativeMethodInfoPtr_RotateArray_Public_Static_Void_NativeArray_1_T_int2_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803018, XrefRangeEnd = 803024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Rotate90(NativeArray<T> array, int2 arrayDimensions)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &array;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayDimensions;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RotateArrayJob<T>.NativeMethodInfoPtr_Rotate90_Public_Static_Void_NativeArray_1_T_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803024, XrefRangeEnd = 803030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Rotate270(NativeArray<T> array, int2 arrayDimensions)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &array;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayDimensions;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RotateArrayJob<T>.NativeMethodInfoPtr_Rotate270_Public_Static_Void_NativeArray_1_T_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803030, XrefRangeEnd = 803036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Rotate180(NativeArray<T> array, int2 arrayDimensions)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &array;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayDimensions;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RotateArrayJob<T>.NativeMethodInfoPtr_Rotate180_Public_Static_Void_NativeArray_1_T_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RotateArrayJob()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", "RotateArrayJob`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr);
      RotateArrayJob<T>.NativeFieldInfoPtr_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr, nameof (Array));
      RotateArrayJob<T>.NativeFieldInfoPtr_ArrayDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr, nameof (ArrayDimensions));
      RotateArrayJob<T>.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr, nameof (Rotation));
      RotateArrayJob<T>.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr, 100670784);
      RotateArrayJob<T>.NativeMethodInfoPtr_RotateArray_Public_Static_Void_NativeArray_1_T_int2_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr, 100670785);
      RotateArrayJob<T>.NativeMethodInfoPtr_Rotate90_Public_Static_Void_NativeArray_1_T_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr, 100670786);
      RotateArrayJob<T>.NativeMethodInfoPtr_Rotate270_Public_Static_Void_NativeArray_1_T_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr, 100670787);
      RotateArrayJob<T>.NativeMethodInfoPtr_Rotate180_Public_Static_Void_NativeArray_1_T_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr, 100670788);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RotateArrayJob<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
