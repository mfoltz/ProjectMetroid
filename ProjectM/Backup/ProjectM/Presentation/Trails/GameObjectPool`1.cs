// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.GameObjectPool`1
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation.Trails
{
  public class GameObjectPool<TKey> : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__FreeObjectsPerPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__InstantiatePrefabFunc;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_TKey_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Preallocate_Public_Void_TKey_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInstance_Public_GameObject_TKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReturnInstance_Public_Void_TKey_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Keys_Public_IEnumerable_1_TKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstancesForKey_Public_IEnumerable_1_GameObject_TKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyInstancesForKey_Public_Void_TKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyInstances_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1113755, RefRangeEnd = 1113756, XrefRangeStart = 1113750, XrefRangeEnd = 1113755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameObjectPool(Il2CppSystem.Func<TKey, GameObject> instantiateFunc)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) instantiateFunc);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameObjectPool<TKey>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_TKey_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Preallocate(TKey key, int count)
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
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameObjectPool<TKey>.NativeMethodInfoPtr_Preallocate_Public_Void_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113756, XrefRangeEnd = 1113764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameObject GetInstance(TKey key)
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameObjectPool<TKey>.NativeMethodInfoPtr_GetInstance_Public_GameObject_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113764, XrefRangeEnd = 1113773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReturnInstance(TKey key, GameObject instance)
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
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) instance);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameObjectPool<TKey>.NativeMethodInfoPtr_ReturnInstance_Public_Void_TKey_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 632802, RefRangeEnd = 632859, XrefRangeStart = 632802, XrefRangeEnd = 632859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerable<TKey> Keys()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameObjectPool<TKey>.NativeMethodInfoPtr_Keys_Public_IEnumerable_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<TKey>) null : new IEnumerable<TKey>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1113774, RefRangeEnd = 1113775, XrefRangeStart = 1113773, XrefRangeEnd = 1113774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerable<GameObject> InstancesForKey(TKey key)
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameObjectPool<TKey>.NativeMethodInfoPtr_InstancesForKey_Public_IEnumerable_1_GameObject_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<GameObject>) null : new IEnumerable<GameObject>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113775, XrefRangeEnd = 1113784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyInstancesForKey(TKey key)
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
      IL2CPP.il2cpp_runtime_invoke(GameObjectPool<TKey>.NativeMethodInfoPtr_DestroyInstancesForKey_Public_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113784, XrefRangeEnd = 1113801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyInstances()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameObjectPool<TKey>.NativeMethodInfoPtr_DestroyInstances_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameObjectPool()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", "GameObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr);
      GameObjectPool<TKey>.NativeFieldInfoPtr__FreeObjectsPerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr, nameof (_FreeObjectsPerPrefab));
      GameObjectPool<TKey>.NativeFieldInfoPtr__InstantiatePrefabFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr, nameof (_InstantiatePrefabFunc));
      GameObjectPool<TKey>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_TKey_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr, 100688148);
      GameObjectPool<TKey>.NativeMethodInfoPtr_Preallocate_Public_Void_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr, 100688149);
      GameObjectPool<TKey>.NativeMethodInfoPtr_GetInstance_Public_GameObject_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr, 100688150);
      GameObjectPool<TKey>.NativeMethodInfoPtr_ReturnInstance_Public_Void_TKey_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr, 100688151);
      GameObjectPool<TKey>.NativeMethodInfoPtr_Keys_Public_IEnumerable_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr, 100688152);
      GameObjectPool<TKey>.NativeMethodInfoPtr_InstancesForKey_Public_IEnumerable_1_GameObject_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr, 100688153);
      GameObjectPool<TKey>.NativeMethodInfoPtr_DestroyInstancesForKey_Public_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr, 100688154);
      GameObjectPool<TKey>.NativeMethodInfoPtr_DestroyInstances_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool<TKey>>.NativeClassPtr, 100688155);
    }

    public GameObjectPool(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Dictionary<TKey, Queue<GameObject>> _FreeObjectsPerPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameObjectPool<TKey>.NativeFieldInfoPtr__FreeObjectsPerPrefab));
        return pointer == System.IntPtr.Zero ? (Dictionary<TKey, Queue<GameObject>>) null : new Dictionary<TKey, Queue<GameObject>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameObjectPool<TKey>.NativeFieldInfoPtr__FreeObjectsPerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<TKey, GameObject> _InstantiatePrefabFunc
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameObjectPool<TKey>.NativeFieldInfoPtr__InstantiatePrefabFunc));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<TKey, GameObject>) null : new Il2CppSystem.Func<TKey, GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameObjectPool<TKey>.NativeFieldInfoPtr__InstantiatePrefabFunc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
