// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.GenericGameFunction`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Scripting
{
  public class GenericGameFunction<T> : Il2CppSystem.Object where T : class
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EMPTY_ARRAY;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameFunctions;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSortedFunctionsLists_Public_Void_Int32_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFunction_Public_Void_String_MethodInfo_String_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySetFunction_Private_Static_Boolean_MethodInfo_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSortedFunctions_Public_Il2CppReferenceArray_1_DelegateAndComponentType_1_T_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

    [CallerCount(24)]
    [CachedScanResults(RefRangeStart = 774323, RefRangeEnd = 774347, XrefRangeStart = 774318, XrefRangeEnd = 774323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GenericGameFunction()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericGameFunction<T>.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 774356, RefRangeEnd = 774360, XrefRangeStart = 774347, XrefRangeEnd = 774356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateSortedFunctionsLists(int typeId, List<string> baseTypes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &typeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) baseTypes);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericGameFunction<T>.NativeMethodInfoPtr_CreateSortedFunctionsLists_Public_Void_Int32_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 774366, RefRangeEnd = 774367, XrefRangeStart = 774360, XrefRangeEnd = 774366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFunction(
      string typeName,
      MethodInfo method,
      string methodName,
      Il2CppSystem.Type type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(typeName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericGameFunction<T>.NativeMethodInfoPtr_SetFunction_Public_Void_String_MethodInfo_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774367, XrefRangeEnd = 774402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TrySetFunction(MethodInfo methodInfo, out T function)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) methodInfo);
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref function;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GenericGameFunction<T>.NativeMethodInfoPtr_TrySetFunction_Private_Static_Boolean_MethodInfo_byref_T_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref function;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774407, RefRangeEnd = 774409, XrefRangeStart = 774402, XrefRangeEnd = 774407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<DelegateAndComponentType<T>> GetSortedFunctions(
      int functionHash,
      int gameObjectTypeId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &functionHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameObjectTypeId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericGameFunction<T>.NativeMethodInfoPtr_GetSortedFunctions_Public_Il2CppReferenceArray_1_DelegateAndComponentType_1_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DelegateAndComponentType<T>>) null : new Il2CppReferenceArray<DelegateAndComponentType<T>>(nativeObject);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774410, RefRangeEnd = 774412, XrefRangeStart = 774409, XrefRangeEnd = 774410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericGameFunction<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GenericGameFunction()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", "GenericGameFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr);
      GenericGameFunction<T>.NativeFieldInfoPtr_EMPTY_ARRAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr, nameof (EMPTY_ARRAY));
      GenericGameFunction<T>.NativeFieldInfoPtr__GameFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr, nameof (_GameFunctions));
      GenericGameFunction<T>.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr, 100668607);
      GenericGameFunction<T>.NativeMethodInfoPtr_CreateSortedFunctionsLists_Public_Void_Int32_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr, 100668608);
      GenericGameFunction<T>.NativeMethodInfoPtr_SetFunction_Public_Void_String_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr, 100668609);
      GenericGameFunction<T>.NativeMethodInfoPtr_TrySetFunction_Private_Static_Boolean_MethodInfo_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr, 100668610);
      GenericGameFunction<T>.NativeMethodInfoPtr_GetSortedFunctions_Public_Il2CppReferenceArray_1_DelegateAndComponentType_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr, 100668611);
      GenericGameFunction<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericGameFunction<T>>.NativeClassPtr, 100668612);
    }

    public GenericGameFunction(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppReferenceArray<DelegateAndComponentType<T>> EMPTY_ARRAY
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GenericGameFunction<T>.NativeFieldInfoPtr_EMPTY_ARRAY, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DelegateAndComponentType<T>>) null : new Il2CppReferenceArray<DelegateAndComponentType<T>>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GenericGameFunction<T>.NativeFieldInfoPtr_EMPTY_ARRAY, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, GameFunction<T>> _GameFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericGameFunction<T>.NativeFieldInfoPtr__GameFunctions));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, GameFunction<T>>) null : new Dictionary<int, GameFunction<T>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericGameFunction<T>.NativeFieldInfoPtr__GameFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
