// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.GameManager_Shared
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Scripting
{
  public static class GameManager_Shared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentlyExecutingEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentlyExecutingPefabGUID;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetList_Public_Static_DataList_1_T_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuffer_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffer_Public_Static_DynamicBuffer_1_T_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetComponent_Public_Static_T_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_Static_ValueTuple_Unboxed_2_T1_T2_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_Static_ValueTuple_Unboxed_3_T1_T2_T3_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_Static_ValueTuple_Unboxed_4_T1_T2_T3_T4_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasComponent_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasComponents_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasComponents_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasComponents_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetComponentImmediate_Public_Static_Void_EntityManager_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetComponentDeferred_Public_Static_Void_EntityCommandBuffer_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddComponentDeferred_Public_Static_Void_EntityCommandBuffer_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_byref_T3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasSingleton_Public_Static_Boolean_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSingleton_Public_Static_T_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSingleton_Public_Static_Boolean_EntityManager_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSingletonEntity_Public_Static_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSingletonEntity_Public_Static_Boolean_EntityManager_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugName_Public_Static_String_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Static_Entity_EntityManager_PrefabLookupMap_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Static_Entity_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Static_Entity_EntityManager_EntityCommandBuffer_PrefabLookupMap_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Static_Entity_EntityManager_EntityCommandBuffer_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabEntity_Public_Static_Entity_PrefabLookupMap_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOwnerOrSelf_Public_Static_Entity_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOwner_Public_Static_Entity_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasOwner_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetOwner_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInput_Public_Static_EntityInput_EntityManager_Entity_0;

    [CallerCount(0)]
    public static unsafe DataList<T> GetList<T>(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_GetList_Public_Static_DataList_1_T_EntityManager_Entity_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DataList<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774540, XrefRangeEnd = 774542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBuffer<T>(
      EntityManager entityManager,
      Entity entity,
      out DynamicBuffer<T> buffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_TryGetBuffer_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774542, XrefRangeEnd = 774551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DynamicBuffer<T> GetBuffer<T>(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_GetBuffer_Public_Static_DynamicBuffer_1_T_EntityManager_Entity_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774551, XrefRangeEnd = 774560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T GetComponent<T>(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_GetComponent_Public_Static_T_EntityManager_Entity_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774560, XrefRangeEnd = 774562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ValueTuple_Unboxed<T1, T2> GetComponents<T1, T2>(
      EntityManager entityManager,
      Entity entity)
      where T1 : unmanaged
      where T2 : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_GetComponents_Public_Static_ValueTuple_Unboxed_2_T1_T2_EntityManager_Entity_0<T1, T2>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValueTuple_Unboxed<T1, T2>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774562, XrefRangeEnd = 774563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ValueTuple_Unboxed<T1, T2, T3> GetComponents<T1, T2, T3>(
      EntityManager entityManager,
      Entity entity)
      where T1 : unmanaged
      where T2 : unmanaged
      where T3 : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_GetComponents_Public_Static_ValueTuple_Unboxed_3_T1_T2_T3_EntityManager_Entity_0<T1, T2, T3>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValueTuple_Unboxed<T1, T2, T3>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe ValueTuple_Unboxed<T1, T2, T3, T4> GetComponents<T1, T2, T3, T4>(
      EntityManager entityManager,
      Entity entity)
      where T1 : unmanaged
      where T2 : unmanaged
      where T3 : unmanaged
      where T4 : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_GetComponents_Public_Static_ValueTuple_Unboxed_4_T1_T2_T3_T4_EntityManager_Entity_0<T1, T2, T3, T4>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValueTuple_Unboxed<T1, T2, T3, T4>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774563, XrefRangeEnd = 774564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasComponent<T>(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_HasComponent_Public_Static_Boolean_EntityManager_Entity_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool HasComponents<T1, T2>(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_HasComponents_Public_Static_Boolean_EntityManager_Entity_0<T1, T2>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool HasComponents<T1, T2, T3>(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_HasComponents_Public_Static_Boolean_EntityManager_Entity_0<T1, T2, T3>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool HasComponents<T1, T2, T3, T4>(
      EntityManager entityManager,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_HasComponents_Public_Static_Boolean_EntityManager_Entity_0<T1, T2, T3, T4>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774564, XrefRangeEnd = 774572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetComponentImmediate<T>(
      EntityManager entityManager,
      Entity entity,
      T component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) component;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref component;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_SetComponentImmediate_Public_Static_Void_EntityManager_Entity_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774572, XrefRangeEnd = 774573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetComponentDeferred<T>(
      EntityCommandBuffer commandBuffer,
      Entity entity,
      T component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) component;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref component;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_SetComponentDeferred_Public_Static_Void_EntityCommandBuffer_Entity_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774573, XrefRangeEnd = 774574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddComponentDeferred<T>(
      EntityCommandBuffer commandBuffer,
      Entity entity,
      T component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) component;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref component;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_AddComponentDeferred_Public_Static_Void_EntityCommandBuffer_Entity_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774574, XrefRangeEnd = 774577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetComponents<T1, T2>(
      EntityManager entityManager,
      Entity entity,
      out T1 component1,
      out T2 component2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      T1& local1;
      if (!typeof (T1).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(T1*) &zero1);
      }
      else
        local1 = ref component1;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero2;
      // ISSUE: variable of a reference type
      T2& local2;
      if (!typeof (T2).IsValueType)
      {
        zero2 = System.IntPtr.Zero;
        local2 = ref (*(T2*) &zero2);
      }
      else
        local2 = ref component2;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr exc;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_0<T1, T2>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T1).IsValueType)
      {
        ref T1 local3 = ref component1;
        System.IntPtr objectPointer = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T1>(objectPointer, false, false);
        local3 = (T1) valueGeneric;
      }
      if (!typeof (T2).IsValueType)
      {
        ref T2 local4 = ref component2;
        System.IntPtr objectPointer = zero2;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T2>(objectPointer, false, false);
        local4 = (T2) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774577, XrefRangeEnd = 774581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetComponents<T1, T2, T3>(
      EntityManager entityManager,
      Entity entity,
      out T1 component1,
      out T2 component2,
      out T3 component3)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      T1& local1;
      if (!typeof (T1).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(T1*) &zero1);
      }
      else
        local1 = ref component1;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero2;
      // ISSUE: variable of a reference type
      T2& local2;
      if (!typeof (T2).IsValueType)
      {
        zero2 = System.IntPtr.Zero;
        local2 = ref (*(T2*) &zero2);
      }
      else
        local2 = ref component2;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr num3 = (System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      System.IntPtr zero3;
      // ISSUE: variable of a reference type
      T3& local3;
      if (!typeof (T3).IsValueType)
      {
        zero3 = System.IntPtr.Zero;
        local3 = ref (*(T3*) &zero3);
      }
      else
        local3 = ref component3;
      *(System.IntPtr*) num3 = (System.IntPtr) ref local3;
      System.IntPtr exc;
      System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_byref_T3_0<T1, T2, T3>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T1).IsValueType)
      {
        ref T1 local4 = ref component1;
        System.IntPtr objectPointer = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T1>(objectPointer, false, false);
        local4 = (T1) valueGeneric;
      }
      if (!typeof (T2).IsValueType)
      {
        ref T2 local5 = ref component2;
        System.IntPtr objectPointer = zero2;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T2>(objectPointer, false, false);
        local5 = (T2) valueGeneric;
      }
      if (!typeof (T3).IsValueType)
      {
        ref T3 local6 = ref component3;
        System.IntPtr objectPointer = zero3;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T3>(objectPointer, false, false);
        local6 = (T3) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774581, XrefRangeEnd = 774586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetComponents<T1, T2, T3, T4>(
      EntityManager entityManager,
      Entity entity,
      out T1 component1,
      out T2 component2,
      out T3 component3,
      out T4 component4)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      T1& local1;
      if (!typeof (T1).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(T1*) &zero1);
      }
      else
        local1 = ref component1;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero2;
      // ISSUE: variable of a reference type
      T2& local2;
      if (!typeof (T2).IsValueType)
      {
        zero2 = System.IntPtr.Zero;
        local2 = ref (*(T2*) &zero2);
      }
      else
        local2 = ref component2;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr num3 = (System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      System.IntPtr zero3;
      // ISSUE: variable of a reference type
      T3& local3;
      if (!typeof (T3).IsValueType)
      {
        zero3 = System.IntPtr.Zero;
        local3 = ref (*(T3*) &zero3);
      }
      else
        local3 = ref component3;
      *(System.IntPtr*) num3 = (System.IntPtr) ref local3;
      System.IntPtr num4 = (System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
      System.IntPtr zero4;
      // ISSUE: variable of a reference type
      T4& local4;
      if (!typeof (T4).IsValueType)
      {
        zero4 = System.IntPtr.Zero;
        local4 = ref (*(T4*) &zero4);
      }
      else
        local4 = ref component4;
      *(System.IntPtr*) num4 = (System.IntPtr) ref local4;
      System.IntPtr exc;
      System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0<T1, T2, T3, T4>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T1).IsValueType)
      {
        ref T1 local5 = ref component1;
        System.IntPtr objectPointer = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T1>(objectPointer, false, false);
        local5 = (T1) valueGeneric;
      }
      if (!typeof (T2).IsValueType)
      {
        ref T2 local6 = ref component2;
        System.IntPtr objectPointer = zero2;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T2>(objectPointer, false, false);
        local6 = (T2) valueGeneric;
      }
      if (!typeof (T3).IsValueType)
      {
        ref T3 local7 = ref component3;
        System.IntPtr objectPointer = zero3;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T3>(objectPointer, false, false);
        local7 = (T3) valueGeneric;
      }
      if (!typeof (T4).IsValueType)
      {
        ref T4 local8 = ref component4;
        System.IntPtr objectPointer = zero4;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T4>(objectPointer, false, false);
        local8 = (T4) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774586, XrefRangeEnd = 774594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasSingleton<T>(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_HasSingleton_Public_Static_Boolean_EntityManager_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe T GetSingleton<T>(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_GetSingleton_Public_Static_T_EntityManager_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(0)]
    public static unsafe bool TryGetSingleton<T>(EntityManager entityManager, out T component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
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
        local1 = ref component;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_TryGetSingleton_Public_Static_Boolean_EntityManager_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref component;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774594, XrefRangeEnd = 774608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetSingletonEntity<T>(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_GetSingletonEntity_Public_Static_Entity_EntityManager_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool TryGetSingletonEntity<T>(
      EntityManager entityManager,
      out Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_TryGetSingletonEntity_Public_Static_Boolean_EntityManager_byref_Entity_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool HasBuff<T>(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_HasBuff_Public_Static_Boolean_EntityManager_Entity_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774609, RefRangeEnd = 774611, XrefRangeStart = 774608, XrefRangeEnd = 774609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasBuff(
      EntityManager entityManager,
      Entity entity,
      PrefabGUID buffPrefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774612, RefRangeEnd = 774614, XrefRangeStart = 774611, XrefRangeEnd = 774612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBuff(
      EntityManager entityManager,
      Entity entity,
      PrefabGUID entityGUID,
      out Entity buff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool TryGetBuff<T>(
      EntityManager entityManager,
      Entity entity,
      out Entity buff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.MethodInfoStoreGeneric_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774614, XrefRangeEnd = 774617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Destroy(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774618, RefRangeEnd = 774620, XrefRangeStart = 774617, XrefRangeEnd = 774618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetDebugName(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_GetDebugName_Public_Static_String_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774627, RefRangeEnd = 774629, XrefRangeStart = 774620, XrefRangeEnd = 774627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity InstantiateEntityImmediate(
      EntityManager entityManager,
      PrefabLookupMap prefabGuidMap,
      Entity creator,
      PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuidMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &creator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Static_Entity_EntityManager_PrefabLookupMap_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 774669, RefRangeEnd = 774672, XrefRangeStart = 774629, XrefRangeEnd = 774669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity InstantiateEntityImmediate(
      EntityManager entityManager,
      Entity creator,
      Entity prefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &creator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Static_Entity_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774696, RefRangeEnd = 774698, XrefRangeStart = 774672, XrefRangeEnd = 774696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity InstantiateEntityDeferred(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      PrefabLookupMap prefabGuidMap,
      Entity owner,
      PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuidMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Static_Entity_EntityManager_EntityCommandBuffer_PrefabLookupMap_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774716, RefRangeEnd = 774718, XrefRangeStart = 774698, XrefRangeEnd = 774716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity InstantiateEntityDeferred(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      Entity creator,
      Entity prefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &creator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Static_Entity_EntityManager_EntityCommandBuffer_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774724, RefRangeEnd = 774726, XrefRangeStart = 774718, XrefRangeEnd = 774724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetPrefabEntity(
      PrefabLookupMap prefabGuidMap,
      PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &prefabGuidMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_GetPrefabEntity_Public_Static_Entity_PrefabLookupMap_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 774736, RefRangeEnd = 774739, XrefRangeStart = 774726, XrefRangeEnd = 774736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetOwnerOrSelf(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_GetOwnerOrSelf_Public_Static_Entity_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774742, RefRangeEnd = 774744, XrefRangeStart = 774739, XrefRangeEnd = 774742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetOwner(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_GetOwner_Public_Static_Entity_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774751, RefRangeEnd = 774753, XrefRangeStart = 774744, XrefRangeEnd = 774751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasOwner(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_HasOwner_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 774763, RefRangeEnd = 774767, XrefRangeStart = 774753, XrefRangeEnd = 774763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetOwner(
      EntityManager entityManager,
      Entity entity,
      out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_TryGetOwner_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774770, RefRangeEnd = 774772, XrefRangeStart = 774767, XrefRangeEnd = 774770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityInput GetInput(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager_Shared.NativeMethodInfoPtr_GetInput_Public_Static_EntityInput_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityInput*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GameManager_Shared()
    {
      Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (GameManager_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr);
      GameManager_Shared.NativeFieldInfoPtr_CurrentlyExecutingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, nameof (CurrentlyExecutingEntity));
      GameManager_Shared.NativeFieldInfoPtr_CurrentlyExecutingPefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, nameof (CurrentlyExecutingPefabGUID));
      GameManager_Shared.NativeMethodInfoPtr_GetList_Public_Static_DataList_1_T_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668654);
      GameManager_Shared.NativeMethodInfoPtr_TryGetBuffer_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668655);
      GameManager_Shared.NativeMethodInfoPtr_GetBuffer_Public_Static_DynamicBuffer_1_T_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668656);
      GameManager_Shared.NativeMethodInfoPtr_GetComponent_Public_Static_T_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668657);
      GameManager_Shared.NativeMethodInfoPtr_GetComponents_Public_Static_ValueTuple_Unboxed_2_T1_T2_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668658);
      GameManager_Shared.NativeMethodInfoPtr_GetComponents_Public_Static_ValueTuple_Unboxed_3_T1_T2_T3_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668659);
      GameManager_Shared.NativeMethodInfoPtr_GetComponents_Public_Static_ValueTuple_Unboxed_4_T1_T2_T3_T4_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668660);
      GameManager_Shared.NativeMethodInfoPtr_HasComponent_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668661);
      GameManager_Shared.NativeMethodInfoPtr_HasComponents_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668662);
      GameManager_Shared.NativeMethodInfoPtr_HasComponents_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668663);
      GameManager_Shared.NativeMethodInfoPtr_HasComponents_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668664);
      GameManager_Shared.NativeMethodInfoPtr_SetComponentImmediate_Public_Static_Void_EntityManager_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668665);
      GameManager_Shared.NativeMethodInfoPtr_SetComponentDeferred_Public_Static_Void_EntityCommandBuffer_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668666);
      GameManager_Shared.NativeMethodInfoPtr_AddComponentDeferred_Public_Static_Void_EntityCommandBuffer_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668667);
      GameManager_Shared.NativeMethodInfoPtr_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668668);
      GameManager_Shared.NativeMethodInfoPtr_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_byref_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668669);
      GameManager_Shared.NativeMethodInfoPtr_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668670);
      GameManager_Shared.NativeMethodInfoPtr_HasSingleton_Public_Static_Boolean_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668671);
      GameManager_Shared.NativeMethodInfoPtr_GetSingleton_Public_Static_T_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668672);
      GameManager_Shared.NativeMethodInfoPtr_TryGetSingleton_Public_Static_Boolean_EntityManager_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668673);
      GameManager_Shared.NativeMethodInfoPtr_GetSingletonEntity_Public_Static_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668674);
      GameManager_Shared.NativeMethodInfoPtr_TryGetSingletonEntity_Public_Static_Boolean_EntityManager_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668675);
      GameManager_Shared.NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668676);
      GameManager_Shared.NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668677);
      GameManager_Shared.NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668678);
      GameManager_Shared.NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668679);
      GameManager_Shared.NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668680);
      GameManager_Shared.NativeMethodInfoPtr_GetDebugName_Public_Static_String_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668681);
      GameManager_Shared.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Static_Entity_EntityManager_PrefabLookupMap_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668682);
      GameManager_Shared.NativeMethodInfoPtr_InstantiateEntityImmediate_Public_Static_Entity_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668683);
      GameManager_Shared.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Static_Entity_EntityManager_EntityCommandBuffer_PrefabLookupMap_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668684);
      GameManager_Shared.NativeMethodInfoPtr_InstantiateEntityDeferred_Public_Static_Entity_EntityManager_EntityCommandBuffer_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668685);
      GameManager_Shared.NativeMethodInfoPtr_GetPrefabEntity_Public_Static_Entity_PrefabLookupMap_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668686);
      GameManager_Shared.NativeMethodInfoPtr_GetOwnerOrSelf_Public_Static_Entity_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668687);
      GameManager_Shared.NativeMethodInfoPtr_GetOwner_Public_Static_Entity_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668688);
      GameManager_Shared.NativeMethodInfoPtr_HasOwner_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668689);
      GameManager_Shared.NativeMethodInfoPtr_TryGetOwner_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668690);
      GameManager_Shared.NativeMethodInfoPtr_GetInput_Public_Static_EntityInput_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr, 100668691);
    }

    public GameManager_Shared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Entity CurrentlyExecutingEntity
    {
      get
      {
        Entity currentlyExecutingEntity;
        IL2CPP.il2cpp_field_static_get_value(GameManager_Shared.NativeFieldInfoPtr_CurrentlyExecutingEntity, (void*) &currentlyExecutingEntity);
        return currentlyExecutingEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameManager_Shared.NativeFieldInfoPtr_CurrentlyExecutingEntity, (void*) &value);
      }
    }

    public static unsafe PrefabGUID CurrentlyExecutingPefabGUID
    {
      get
      {
        PrefabGUID executingPefabGuid;
        IL2CPP.il2cpp_field_static_get_value(GameManager_Shared.NativeFieldInfoPtr_CurrentlyExecutingPefabGUID, (void*) &executingPefabGuid);
        return executingPefabGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameManager_Shared.NativeFieldInfoPtr_CurrentlyExecutingPefabGUID, (void*) &value);
      }
    }

    private sealed class MethodInfoStoreGeneric_GetList_Public_Static_DataList_1_T_EntityManager_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_GetList_Public_Static_DataList_1_T_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetBuffer_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_TryGetBuffer_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_T_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetBuffer_Public_Static_DynamicBuffer_1_T_EntityManager_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_GetBuffer_Public_Static_DynamicBuffer_1_T_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponent_Public_Static_T_EntityManager_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_GetComponent_Public_Static_T_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponents_Public_Static_ValueTuple_Unboxed_2_T1_T2_EntityManager_Entity_0<T1, T2>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_GetComponents_Public_Static_ValueTuple_Unboxed_2_T1_T2_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponents_Public_Static_ValueTuple_Unboxed_3_T1_T2_T3_EntityManager_Entity_0<T1, T2, T3>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_GetComponents_Public_Static_ValueTuple_Unboxed_3_T1_T2_T3_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetComponents_Public_Static_ValueTuple_Unboxed_4_T1_T2_T3_T4_EntityManager_Entity_0<T1, T2, T3, T4>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_GetComponents_Public_Static_ValueTuple_Unboxed_4_T1_T2_T3_T4_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[4]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponent_Public_Static_Boolean_EntityManager_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_HasComponent_Public_Static_Boolean_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponents_Public_Static_Boolean_EntityManager_Entity_0<T1, T2>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_HasComponents_Public_Static_Boolean_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponents_Public_Static_Boolean_EntityManager_Entity_0<T1, T2, T3>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_HasComponents_Public_Static_Boolean_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasComponents_Public_Static_Boolean_EntityManager_Entity_0<T1, T2, T3, T4>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_HasComponents_Public_Static_Boolean_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[4]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetComponentImmediate_Public_Static_Void_EntityManager_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_SetComponentImmediate_Public_Static_Void_EntityManager_Entity_T_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetComponentDeferred_Public_Static_Void_EntityCommandBuffer_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_SetComponentDeferred_Public_Static_Void_EntityCommandBuffer_Entity_T_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AddComponentDeferred_Public_Static_Void_EntityCommandBuffer_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_AddComponentDeferred_Public_Static_Void_EntityCommandBuffer_Entity_T_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_0<T1, T2>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_byref_T3_0<T1, T2, T3>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_byref_T3_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0<T1, T2, T3, T4>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_TryGetComponents_Public_Static_Boolean_EntityManager_Entity_byref_T1_byref_T2_byref_T3_byref_T4_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[4]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasSingleton_Public_Static_Boolean_EntityManager_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_HasSingleton_Public_Static_Boolean_EntityManager_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetSingleton_Public_Static_T_EntityManager_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_GetSingleton_Public_Static_T_EntityManager_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetSingleton_Public_Static_Boolean_EntityManager_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_TryGetSingleton_Public_Static_Boolean_EntityManager_byref_T_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetSingletonEntity_Public_Static_Entity_EntityManager_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_GetSingletonEntity_Public_Static_Entity_EntityManager_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetSingletonEntity_Public_Static_Boolean_EntityManager_byref_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_TryGetSingletonEntity_Public_Static_Boolean_EntityManager_byref_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_HasBuff_Public_Static_Boolean_EntityManager_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManager_Shared.NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0, Il2CppClassPointerStore<GameManager_Shared>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
