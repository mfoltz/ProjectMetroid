// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.FastIterationDictionary`2
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Presentation.Trails
{
  public class FastIterationDictionary<TKey, TValue> : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Values;
    private static readonly System.IntPtr NativeFieldInfoPtr__IndexToKey;
    private static readonly System.IntPtr NativeFieldInfoPtr__KeyToIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetIndex_Public_Boolean_TKey_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_TValue_TKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Int32_TKey_TValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_TKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GrowArraysIfNeeded_Private_Void_Int32_0;

    public unsafe int Count
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 1113718, RefRangeEnd = 1113723, XrefRangeStart = 1113708, XrefRangeEnd = 1113718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1113734, RefRangeEnd = 1113735, XrefRangeStart = 1113723, XrefRangeEnd = 1113734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FastIterationDictionary(int capacity)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &capacity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1113736, RefRangeEnd = 1113740, XrefRangeStart = 1113735, XrefRangeEnd = 1113736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetIndex(TKey key, out int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TKey& local1;
      if (!typeof (TKey).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TKey> local2 = (object) key;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TKey&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TKey&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref key;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetIndex_Public_Boolean_TKey_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe TValue Get(TKey key)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TKey& local1;
      if (!typeof (TKey).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TKey> local2 = (object) key;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TKey&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TKey&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref key;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_Get_Public_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<TValue>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113740, XrefRangeEnd = 1113742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int Add(TKey key, TValue value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TKey& local1;
      if (!typeof (TKey).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TKey> local2 = (object) key;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TKey&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TKey&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref key;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local3;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local4 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = local4 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
      }
      else
        local3 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Int32_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113742, XrefRangeEnd = 1113746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Remove(TKey key)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TKey& local1;
      if (!typeof (TKey).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TKey> local2 = (object) key;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TKey&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TKey&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref key;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113746, XrefRangeEnd = 1113750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void GrowArraysIfNeeded(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_GrowArraysIfNeeded_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FastIterationDictionary()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", "FastIterationDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr);
      FastIterationDictionary<TKey, TValue>.NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, nameof (Values));
      FastIterationDictionary<TKey, TValue>.NativeFieldInfoPtr__IndexToKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, nameof (_IndexToKey));
      FastIterationDictionary<TKey, TValue>.NativeFieldInfoPtr__KeyToIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, nameof (_KeyToIndex));
      FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, 100688140);
      FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, 100688141);
      FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetIndex_Public_Boolean_TKey_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, 100688142);
      FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_Get_Public_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, 100688143);
      FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Int32_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, 100688144);
      FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, 100688145);
      FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, 100688146);
      FastIterationDictionary<TKey, TValue>.NativeMethodInfoPtr_GrowArraysIfNeeded_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastIterationDictionary<TKey, TValue>>.NativeClassPtr, 100688147);
    }

    public FastIterationDictionary(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppArrayBase<TValue> Values
    {
      get
      {
        return Il2CppArrayBase<TValue>.WrapNativeGenericArrayPointer(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FastIterationDictionary<TKey, TValue>.NativeFieldInfoPtr_Values)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FastIterationDictionary<TKey, TValue>.NativeFieldInfoPtr_Values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppArrayBase<TKey> _IndexToKey
    {
      get
      {
        return Il2CppArrayBase<TKey>.WrapNativeGenericArrayPointer(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FastIterationDictionary<TKey, TValue>.NativeFieldInfoPtr__IndexToKey)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FastIterationDictionary<TKey, TValue>.NativeFieldInfoPtr__IndexToKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<TKey, int> _KeyToIndex
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FastIterationDictionary<TKey, TValue>.NativeFieldInfoPtr__KeyToIndex));
        return pointer == System.IntPtr.Zero ? (Dictionary<TKey, int>) null : new Dictionary<TKey, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FastIterationDictionary<TKey, TValue>.NativeFieldInfoPtr__KeyToIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
