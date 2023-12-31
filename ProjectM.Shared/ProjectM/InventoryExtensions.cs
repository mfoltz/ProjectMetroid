// Decompiled with JetBrains decompiler
// Type: ProjectM.InventoryExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class InventoryExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsIndexWithinRange_Public_Static_Boolean_byref_NativeArray_1_InventoryBuffer_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAtIndex_Public_Static_Boolean_byref_NativeArray_1_InventoryBuffer_Int32_byref_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsIndexWithinRange_Public_Static_Boolean_byref_DynamicBuffer_1_T_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAtIndex_Public_Static_Boolean_byref_DynamicBuffer_1_T_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnsureWithinRange_Public_Static_Void_byref_DynamicBuffer_1_T_byref_Int32_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 739697, RefRangeEnd = 739699, XrefRangeStart = 739694, XrefRangeEnd = 739697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsIndexWithinRange(
      [In] ref this NativeArray<InventoryBuffer> inventoryBuffer,
      int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref inventoryBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryExtensions.NativeMethodInfoPtr_IsIndexWithinRange_Public_Static_Boolean_byref_NativeArray_1_InventoryBuffer_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739699, XrefRangeEnd = 739700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAtIndex(
      [In] ref this NativeArray<InventoryBuffer> inventory,
      int index,
      out InventoryBuffer entry)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entry;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryExtensions.NativeMethodInfoPtr_TryGetAtIndex_Public_Static_Boolean_byref_NativeArray_1_InventoryBuffer_Int32_byref_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 739702, RefRangeEnd = 739708, XrefRangeStart = 739700, XrefRangeEnd = 739702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsIndexWithinRange<T>([In] ref this DynamicBuffer<T> buffer, int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryExtensions.MethodInfoStoreGeneric_IsIndexWithinRange_Public_Static_Boolean_byref_DynamicBuffer_1_T_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool TryGetAtIndex<T>(
      [In] ref this DynamicBuffer<T> buffer,
      int index,
      out T entry)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref entry;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InventoryExtensions.MethodInfoStoreGeneric_TryGetAtIndex_Public_Static_Boolean_byref_DynamicBuffer_1_T_Int32_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref entry;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe void EnsureWithinRange<T>([In] ref this DynamicBuffer<T> buffer, ref int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryExtensions.MethodInfoStoreGeneric_EnsureWithinRange_Public_Static_Void_byref_DynamicBuffer_1_T_byref_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InventoryExtensions()
    {
      Il2CppClassPointerStore<InventoryExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InventoryExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryExtensions>.NativeClassPtr);
      InventoryExtensions.NativeMethodInfoPtr_IsIndexWithinRange_Public_Static_Boolean_byref_NativeArray_1_InventoryBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryExtensions>.NativeClassPtr, 100665266);
      InventoryExtensions.NativeMethodInfoPtr_TryGetAtIndex_Public_Static_Boolean_byref_NativeArray_1_InventoryBuffer_Int32_byref_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryExtensions>.NativeClassPtr, 100665267);
      InventoryExtensions.NativeMethodInfoPtr_IsIndexWithinRange_Public_Static_Boolean_byref_DynamicBuffer_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryExtensions>.NativeClassPtr, 100665268);
      InventoryExtensions.NativeMethodInfoPtr_TryGetAtIndex_Public_Static_Boolean_byref_DynamicBuffer_1_T_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryExtensions>.NativeClassPtr, 100665269);
      InventoryExtensions.NativeMethodInfoPtr_EnsureWithinRange_Public_Static_Void_byref_DynamicBuffer_1_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryExtensions>.NativeClassPtr, 100665270);
    }

    public InventoryExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_IsIndexWithinRange_Public_Static_Boolean_byref_DynamicBuffer_1_T_Int32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(InventoryExtensions.NativeMethodInfoPtr_IsIndexWithinRange_Public_Static_Boolean_byref_DynamicBuffer_1_T_Int32_0, Il2CppClassPointerStore<InventoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetAtIndex_Public_Static_Boolean_byref_DynamicBuffer_1_T_Int32_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(InventoryExtensions.NativeMethodInfoPtr_TryGetAtIndex_Public_Static_Boolean_byref_DynamicBuffer_1_T_Int32_byref_T_0, Il2CppClassPointerStore<InventoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_EnsureWithinRange_Public_Static_Void_byref_DynamicBuffer_1_T_byref_Int32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(InventoryExtensions.NativeMethodInfoPtr_EnsureWithinRange_Public_Static_Void_byref_DynamicBuffer_1_T_byref_Int32_0, Il2CppClassPointerStore<InventoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
