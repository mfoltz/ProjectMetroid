// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.GameFunction`1
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
  public class GameFunction<T> : Il2CppSystem.Object where T : class
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EMPTY_ARRAY;
    private static readonly System.IntPtr NativeFieldInfoPtr__FunctionDict;
    private static readonly System.IntPtr NativeFieldInfoPtr__SortedFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadList;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSortedFunctionsLists_Public_Virtual_Final_New_Void_Int32_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasFunctions_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSortedFunctions_Public_Il2CppReferenceArray_1_DelegateAndComponentType_1_T_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFunction_Public_Boolean_String_MethodInfo_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySetFunction_Private_Static_Boolean_MethodInfo_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsMethodCompatibleWithDelegate_Public_Static_Boolean_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParametersEqual_Private_Static_Boolean_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_ParameterInfo_0;

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 773832, RefRangeEnd = 773848, XrefRangeStart = 773813, XrefRangeEnd = 773832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameFunction()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameFunction<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(32)]
    [CachedScanResults(RefRangeStart = 773866, RefRangeEnd = 773898, XrefRangeStart = 773848, XrefRangeEnd = 773866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void CreateSortedFunctionsLists(int typeId, List<string> baseTypes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &typeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) baseTypes);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameFunction<T>.NativeMethodInfoPtr_CreateSortedFunctionsLists_Public_Virtual_Final_New_Void_Int32_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool HasFunctions(int gameObjectTypeId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &gameObjectTypeId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameFunction<T>.NativeMethodInfoPtr_HasFunctions_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 773903, RefRangeEnd = 773919, XrefRangeStart = 773898, XrefRangeEnd = 773903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<DelegateAndComponentType<T>> GetSortedFunctions(
      int gameObjectTypeId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &gameObjectTypeId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameFunction<T>.NativeMethodInfoPtr_GetSortedFunctions_Public_Il2CppReferenceArray_1_DelegateAndComponentType_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DelegateAndComponentType<T>>) null : new Il2CppReferenceArray<DelegateAndComponentType<T>>(nativeObject);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 773923, RefRangeEnd = 773939, XrefRangeStart = 773919, XrefRangeEnd = 773923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SetFunction(string typeName, MethodInfo method, Il2CppSystem.Type type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(typeName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameFunction<T>.NativeMethodInfoPtr_SetFunction_Public_Boolean_String_MethodInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 773940, RefRangeEnd = 773956, XrefRangeStart = 773939, XrefRangeEnd = 773940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameFunction<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773956, XrefRangeEnd = 773985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFunction<T>.NativeMethodInfoPtr_TrySetFunction_Private_Static_Boolean_MethodInfo_byref_T_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
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

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773985, XrefRangeEnd = 774007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsMethodCompatibleWithDelegate(MethodInfo method)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameFunction<T>.NativeMethodInfoPtr_IsMethodCompatibleWithDelegate_Public_Static_Boolean_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774007, XrefRangeEnd = 774020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ParametersEqual(
      Il2CppReferenceArray<ParameterInfo> a,
      Il2CppReferenceArray<ParameterInfo> b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameFunction<T>.NativeMethodInfoPtr_ParametersEqual_Private_Static_Boolean_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_ParameterInfo_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GameFunction()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", "GameFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr);
      GameFunction<T>.NativeFieldInfoPtr_EMPTY_ARRAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, nameof (EMPTY_ARRAY));
      GameFunction<T>.NativeFieldInfoPtr__FunctionDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, nameof (_FunctionDict));
      GameFunction<T>.NativeFieldInfoPtr__SortedFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, nameof (_SortedFunctions));
      GameFunction<T>.NativeFieldInfoPtr__LoadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, nameof (_LoadList));
      GameFunction<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, 100668579);
      GameFunction<T>.NativeMethodInfoPtr_CreateSortedFunctionsLists_Public_Virtual_Final_New_Void_Int32_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, 100668580);
      GameFunction<T>.NativeMethodInfoPtr_HasFunctions_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, 100668581);
      GameFunction<T>.NativeMethodInfoPtr_GetSortedFunctions_Public_Il2CppReferenceArray_1_DelegateAndComponentType_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, 100668582);
      GameFunction<T>.NativeMethodInfoPtr_SetFunction_Public_Boolean_String_MethodInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, 100668583);
      GameFunction<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, 100668584);
      GameFunction<T>.NativeMethodInfoPtr_TrySetFunction_Private_Static_Boolean_MethodInfo_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, 100668585);
      GameFunction<T>.NativeMethodInfoPtr_IsMethodCompatibleWithDelegate_Public_Static_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, 100668586);
      GameFunction<T>.NativeMethodInfoPtr_ParametersEqual_Private_Static_Boolean_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFunction<T>>.NativeClassPtr, 100668587);
    }

    public GameFunction(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppReferenceArray<DelegateAndComponentType<T>> EMPTY_ARRAY
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GameFunction<T>.NativeFieldInfoPtr_EMPTY_ARRAY, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DelegateAndComponentType<T>>) null : new Il2CppReferenceArray<DelegateAndComponentType<T>>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameFunction<T>.NativeFieldInfoPtr_EMPTY_ARRAY, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<string, T> _FunctionDict
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFunction<T>.NativeFieldInfoPtr__FunctionDict));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, T>) null : new Dictionary<string, T>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFunction<T>.NativeFieldInfoPtr__FunctionDict), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, Il2CppReferenceArray<DelegateAndComponentType<T>>> _SortedFunctions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFunction<T>.NativeFieldInfoPtr__SortedFunctions));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<DelegateAndComponentType<T>>>) null : new Dictionary<int, Il2CppReferenceArray<DelegateAndComponentType<T>>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFunction<T>.NativeFieldInfoPtr__SortedFunctions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<DelegateAndComponentType<T>> _LoadList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFunction<T>.NativeFieldInfoPtr__LoadList));
        return pointer == System.IntPtr.Zero ? (List<DelegateAndComponentType<T>>) null : new List<DelegateAndComponentType<T>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFunction<T>.NativeFieldInfoPtr__LoadList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
