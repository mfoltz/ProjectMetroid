// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using ProjectM.Scripting;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class BuffUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_Entity_PrefabGUID_BufferFromEntity_1_BuffBuffer_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_PrefabGUID_DynamicBuffer_1_BuffBuffer_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffInstanceCount_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffInstanceCount_Public_Static_Int32_EntityManager_PrefabGUID_DynamicBuffer_1_BuffBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffStacks_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffStacks_Public_Static_Int32_EntityManager_PrefabGUID_DynamicBuffer_1_BuffBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBuffStacks_Public_Static_Void_Entity_byref_Buff_Byte_Byte_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveBuff_Public_Static_Boolean_byref_BuffSpawner_EntityCommandBuffer_PrefabGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MergedBuffInstances_Private_Static_Void_BuffSpawner_Entity_byref_NativeList_1_BuffInstanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySpawnBuff_Public_Static_Boolean_byref_BuffSpawner_byref_TrySpawnBuffArgs_Allocator_byref_Entity_Byte_Boolean_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySpawnBuffWithEntityManager_Public_Static_Boolean_byref_BuffSpawner_byref_TrySpawnBuffArgs_Allocator_byref_Entity_Byte_Nullable_Unboxed_1_Int32_Boolean_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetApplyBuffResult_Private_Static_TrySpawnBuffResult_BuffSpawner_TrySpawnBuffArgs_Byte_Boolean_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Single_byref_BuffInstanceData_byref_Int32_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBlockedDueToBuffResistance_Private_Static_Boolean_byref_BuffInstanceData_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlockedByBuffCategoryResult_Private_Static_BuffCategoryResult_BuffInstanceData_Buffable_BuffInstanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlockedByKnockbackResult_Private_Static_ApplyKnockbackResult_BuffInstanceData_BuffInstanceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupInitialInstanceData_Private_Static_BuffInstanceData_TrySpawnBuffArgs_Buff_Entity_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnBuff_Private_Static_Void_byref_BuffSpawner_EntityCommandBuffer_byref_BuffInstanceData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnBuff_Private_Static_Void_byref_BuffSpawner_EntityManager_byref_BuffInstanceData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBuff_Private_Static_Void_byref_BuffSpawner_EntityCommandBuffer_byref_BuffInstanceData_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBuffImmediate_Private_Static_Void_byref_BuffSpawner_EntityManager_byref_BuffInstanceData_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_Byte_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_Byte_EntityManager_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 725437, RefRangeEnd = 725438, XrefRangeStart = 725422, XrefRangeEnd = 725437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBuff(
      Entity entity,
      PrefabGUID buffGuid,
      BufferFromEntity<BuffBuffer> getBuffBuffer,
      out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buffGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getBuffBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_Entity_PrefabGUID_BufferFromEntity_1_BuffBuffer_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 725453, RefRangeEnd = 725462, XrefRangeStart = 725438, XrefRangeEnd = 725453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBuff(
      EntityManager entityManager,
      Entity entity,
      PrefabGUID buffGuid,
      out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725462, XrefRangeEnd = 725471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBuff(
      PrefabGUID buffGuid,
      DynamicBuffer<BuffBuffer> buffBuffer,
      out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buffBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_PrefabGUID_DynamicBuffer_1_BuffBuffer_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725471, XrefRangeEnd = 725487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetBuffInstanceCount(
      EntityManager entityManager,
      Entity entity,
      PrefabGUID buffGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_GetBuffInstanceCount_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725487, XrefRangeEnd = 725500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetBuffInstanceCount(
      EntityManager entityManager,
      PrefabGUID buffGuid,
      DynamicBuffer<BuffBuffer> buffBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buffGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_GetBuffInstanceCount_Public_Static_Int32_EntityManager_PrefabGUID_DynamicBuffer_1_BuffBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725500, XrefRangeEnd = 725519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetBuffStacks(
      EntityManager entityManager,
      Entity entity,
      PrefabGUID buffGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_GetBuffStacks_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725519, XrefRangeEnd = 725535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetBuffStacks(
      EntityManager entityManager,
      PrefabGUID buffGuid,
      DynamicBuffer<BuffBuffer> buffBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buffGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_GetBuffStacks_Public_Static_Int32_EntityManager_PrefabGUID_DynamicBuffer_1_BuffBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725535, XrefRangeEnd = 725563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasBuff<T>(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.MethodInfoStoreGeneric_HasBuff_Public_Static_Boolean_EntityManager_Entity_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 725588, RefRangeEnd = 725598, XrefRangeStart = 725563, XrefRangeEnd = 725588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 725602, RefRangeEnd = 725603, XrefRangeStart = 725598, XrefRangeEnd = 725602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBuffStacks(
      Entity entity,
      ref Buff buff,
      byte previousStacks,
      byte newStacks,
      EntityCommandBuffer commandBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &previousStacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newStacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_SetBuffStacks_Public_Static_Void_Entity_byref_Buff_Byte_Byte_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 725628, RefRangeEnd = 725634, XrefRangeStart = 725603, XrefRangeEnd = 725628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryRemoveBuff(
      ref BuffUtility.BuffSpawner buffSpawner,
      EntityCommandBuffer destroyCommandBuffer,
      PrefabGUID buffPrefab,
      Entity buffable)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref buffSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffable;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_TryRemoveBuff_Public_Static_Boolean_byref_BuffSpawner_EntityCommandBuffer_PrefabGUID_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 725718, RefRangeEnd = 725719, XrefRangeStart = 725634, XrefRangeEnd = 725718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void MergedBuffInstances(
      BuffUtility.BuffSpawner buffSpawner,
      Entity target,
      ref NativeList<BuffUtility.BuffInstanceData> mergedBuffs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mergedBuffs;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_MergedBuffInstances_Private_Static_Void_BuffSpawner_Entity_byref_NativeList_1_BuffInstanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 725755, RefRangeEnd = 725814, XrefRangeStart = 725719, XrefRangeEnd = 725755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TrySpawnBuff(
      ref BuffUtility.BuffSpawner buffSpawner,
      [In] ref BuffUtility.TrySpawnBuffArgs args,
      Allocator allocatorToUse,
      out Entity buffEntity,
      byte stacks = 1,
      bool recursiveOwner = false,
      Nullable_Unboxed<int> overrideKnockbackImportance = default (Nullable_Unboxed<int>),
      Nullable_Unboxed<float> overrideDuration = default (Nullable_Unboxed<float>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref buffSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref args;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allocatorToUse;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &recursiveOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideKnockbackImportance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideDuration;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_TrySpawnBuff_Public_Static_Boolean_byref_BuffSpawner_byref_TrySpawnBuffArgs_Allocator_byref_Entity_Byte_Boolean_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 725850, RefRangeEnd = 725852, XrefRangeStart = 725814, XrefRangeEnd = 725850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TrySpawnBuffWithEntityManager(
      ref BuffUtility.BuffSpawner buffSpawner,
      [In] ref BuffUtility.TrySpawnBuffArgs args,
      Allocator allocatorToUse,
      out Entity buffEntity,
      byte stacks = 1,
      Nullable_Unboxed<int> overrideKnockbackImportance = default (Nullable_Unboxed<int>),
      bool recursiveOwner = false,
      Nullable_Unboxed<float> overrideDuration = default (Nullable_Unboxed<float>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref buffSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref args;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allocatorToUse;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideKnockbackImportance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &recursiveOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideDuration;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_TrySpawnBuffWithEntityManager_Public_Static_Boolean_byref_BuffSpawner_byref_TrySpawnBuffArgs_Allocator_byref_Entity_Byte_Nullable_Unboxed_1_Int32_Boolean_Nullable_Unboxed_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 725947, RefRangeEnd = 725949, XrefRangeStart = 725852, XrefRangeEnd = 725947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BuffUtility.TrySpawnBuffResult GetApplyBuffResult(
      BuffUtility.BuffSpawner buffSpawner,
      BuffUtility.TrySpawnBuffArgs args,
      byte stacks,
      bool recursiveOwner,
      Nullable_Unboxed<int> overrideKnockbackImportance,
      Nullable_Unboxed<float> overrideDuration,
      out BuffUtility.BuffInstanceData instanceData,
      out int oldBuffInstanceIndex,
      out Entity diminishingReturnBuffPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &buffSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &args;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &recursiveOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideKnockbackImportance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref instanceData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref oldBuffInstanceIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref diminishingReturnBuffPrefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_GetApplyBuffResult_Private_Static_TrySpawnBuffResult_BuffSpawner_TrySpawnBuffArgs_Byte_Boolean_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Single_byref_BuffInstanceData_byref_Int32_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BuffUtility.TrySpawnBuffResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 725979, RefRangeEnd = 725980, XrefRangeStart = 725949, XrefRangeEnd = 725979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsBlockedDueToBuffResistance(
      ref BuffUtility.BuffInstanceData instanceData,
      EntityManager entityManager,
      Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref instanceData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_IsBlockedDueToBuffResistance_Private_Static_Boolean_byref_BuffInstanceData_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 725997, RefRangeEnd = 725998, XrefRangeStart = 725980, XrefRangeEnd = 725997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BuffUtility.BuffCategoryResult BlockedByBuffCategoryResult(
      BuffUtility.BuffInstanceData selfBuff,
      Buffable buffable,
      BuffUtility.BuffInstanceData otherBuff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &selfBuff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buffable;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &otherBuff;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_BlockedByBuffCategoryResult_Private_Static_BuffCategoryResult_BuffInstanceData_Buffable_BuffInstanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BuffUtility.BuffCategoryResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725998, XrefRangeEnd = 726003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BuffUtility.ApplyKnockbackResult BlockedByKnockbackResult(
      BuffUtility.BuffInstanceData selfBuff,
      BuffUtility.BuffInstanceData otherBuff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &selfBuff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &otherBuff;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_BlockedByKnockbackResult_Private_Static_ApplyKnockbackResult_BuffInstanceData_BuffInstanceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BuffUtility.ApplyKnockbackResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726024, RefRangeEnd = 726025, XrefRangeStart = 726003, XrefRangeEnd = 726024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BuffUtility.BuffInstanceData SetupInitialInstanceData(
      BuffUtility.TrySpawnBuffArgs args,
      Buff prefabBuffData,
      Entity owner,
      EntityManager entityManager,
      Entity buffPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &args;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabBuffData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &buffPrefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_SetupInitialInstanceData_Private_Static_BuffInstanceData_TrySpawnBuffArgs_Buff_Entity_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BuffUtility.BuffInstanceData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726100, RefRangeEnd = 726101, XrefRangeStart = 726025, XrefRangeEnd = 726100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SpawnBuff(
      ref BuffUtility.BuffSpawner buffSpawner,
      EntityCommandBuffer initCommandBuffer,
      ref BuffUtility.BuffInstanceData instanceData,
      Entity buffPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref buffSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref instanceData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffPrefab;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_SpawnBuff_Private_Static_Void_byref_BuffSpawner_EntityCommandBuffer_byref_BuffInstanceData_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726179, RefRangeEnd = 726180, XrefRangeStart = 726101, XrefRangeEnd = 726179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SpawnBuff(
      ref BuffUtility.BuffSpawner buffSpawner,
      EntityManager entityManager,
      ref BuffUtility.BuffInstanceData instanceData,
      Entity buffPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref buffSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref instanceData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffPrefab;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_SpawnBuff_Private_Static_Void_byref_BuffSpawner_EntityManager_byref_BuffInstanceData_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726231, RefRangeEnd = 726232, XrefRangeStart = 726180, XrefRangeEnd = 726231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateBuff(
      ref BuffUtility.BuffSpawner buffSpawner,
      EntityCommandBuffer initCommandBuffer,
      ref BuffUtility.BuffInstanceData instanceData,
      Entity buffPrefab,
      int oldBuffInstanceIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref buffSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref instanceData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &oldBuffInstanceIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_UpdateBuff_Private_Static_Void_byref_BuffSpawner_EntityCommandBuffer_byref_BuffInstanceData_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726283, RefRangeEnd = 726284, XrefRangeStart = 726232, XrefRangeEnd = 726283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateBuffImmediate(
      ref BuffUtility.BuffSpawner buffSpawner,
      EntityManager entityManager,
      ref BuffUtility.BuffInstanceData instanceData,
      Entity prefab,
      int oldBuffInstanceIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref buffSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref instanceData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &oldBuffInstanceIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_UpdateBuffImmediate_Private_Static_Void_byref_BuffSpawner_EntityManager_byref_BuffInstanceData_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726284, XrefRangeEnd = 726288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateStacksIncreaseEvent(
      Entity buffEntity,
      byte newStacks,
      EntityCommandBuffer initCommandBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newStacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &initCommandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726292, RefRangeEnd = 726293, XrefRangeStart = 726288, XrefRangeEnd = 726292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateStacksIncreaseEvent(
      Entity buffEntity,
      byte oldStacks,
      byte newStacks,
      EntityCommandBuffer initCommandBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &buffEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &oldStacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newStacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &initCommandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_Byte_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726293, XrefRangeEnd = 726307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateStacksIncreaseEvent(
      Entity buffEntity,
      byte newStacks,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newStacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726307, XrefRangeEnd = 726321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateStacksIncreaseEvent(
      Entity buffEntity,
      byte oldStacks,
      byte newStacks,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &buffEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &oldStacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newStacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffUtility.NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_Byte_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuffUtility()
    {
      Il2CppClassPointerStore<BuffUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BuffUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr);
      BuffUtility.NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_Entity_PrefabGUID_BufferFromEntity_1_BuffBuffer_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664149);
      BuffUtility.NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664150);
      BuffUtility.NativeMethodInfoPtr_TryGetBuff_Public_Static_Boolean_PrefabGUID_DynamicBuffer_1_BuffBuffer_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664151);
      BuffUtility.NativeMethodInfoPtr_GetBuffInstanceCount_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664152);
      BuffUtility.NativeMethodInfoPtr_GetBuffInstanceCount_Public_Static_Int32_EntityManager_PrefabGUID_DynamicBuffer_1_BuffBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664153);
      BuffUtility.NativeMethodInfoPtr_GetBuffStacks_Public_Static_Int32_EntityManager_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664154);
      BuffUtility.NativeMethodInfoPtr_GetBuffStacks_Public_Static_Int32_EntityManager_PrefabGUID_DynamicBuffer_1_BuffBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664155);
      BuffUtility.NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664156);
      BuffUtility.NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664157);
      BuffUtility.NativeMethodInfoPtr_SetBuffStacks_Public_Static_Void_Entity_byref_Buff_Byte_Byte_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664158);
      BuffUtility.NativeMethodInfoPtr_TryRemoveBuff_Public_Static_Boolean_byref_BuffSpawner_EntityCommandBuffer_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664159);
      BuffUtility.NativeMethodInfoPtr_MergedBuffInstances_Private_Static_Void_BuffSpawner_Entity_byref_NativeList_1_BuffInstanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664160);
      BuffUtility.NativeMethodInfoPtr_TrySpawnBuff_Public_Static_Boolean_byref_BuffSpawner_byref_TrySpawnBuffArgs_Allocator_byref_Entity_Byte_Boolean_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664161);
      BuffUtility.NativeMethodInfoPtr_TrySpawnBuffWithEntityManager_Public_Static_Boolean_byref_BuffSpawner_byref_TrySpawnBuffArgs_Allocator_byref_Entity_Byte_Nullable_Unboxed_1_Int32_Boolean_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664162);
      BuffUtility.NativeMethodInfoPtr_GetApplyBuffResult_Private_Static_TrySpawnBuffResult_BuffSpawner_TrySpawnBuffArgs_Byte_Boolean_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Single_byref_BuffInstanceData_byref_Int32_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664163);
      BuffUtility.NativeMethodInfoPtr_IsBlockedDueToBuffResistance_Private_Static_Boolean_byref_BuffInstanceData_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664164);
      BuffUtility.NativeMethodInfoPtr_BlockedByBuffCategoryResult_Private_Static_BuffCategoryResult_BuffInstanceData_Buffable_BuffInstanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664165);
      BuffUtility.NativeMethodInfoPtr_BlockedByKnockbackResult_Private_Static_ApplyKnockbackResult_BuffInstanceData_BuffInstanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664166);
      BuffUtility.NativeMethodInfoPtr_SetupInitialInstanceData_Private_Static_BuffInstanceData_TrySpawnBuffArgs_Buff_Entity_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664167);
      BuffUtility.NativeMethodInfoPtr_SpawnBuff_Private_Static_Void_byref_BuffSpawner_EntityCommandBuffer_byref_BuffInstanceData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664168);
      BuffUtility.NativeMethodInfoPtr_SpawnBuff_Private_Static_Void_byref_BuffSpawner_EntityManager_byref_BuffInstanceData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664169);
      BuffUtility.NativeMethodInfoPtr_UpdateBuff_Private_Static_Void_byref_BuffSpawner_EntityCommandBuffer_byref_BuffInstanceData_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664170);
      BuffUtility.NativeMethodInfoPtr_UpdateBuffImmediate_Private_Static_Void_byref_BuffSpawner_EntityManager_byref_BuffInstanceData_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664171);
      BuffUtility.NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664172);
      BuffUtility.NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_Byte_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664173);
      BuffUtility.NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664174);
      BuffUtility.NativeMethodInfoPtr_CreateStacksIncreaseEvent_Public_Static_Void_Entity_Byte_Byte_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, 100664175);
    }

    public BuffUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BuffSpawner
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IsDebuggingActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffsModifiedOrSpawned;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffsDestroyed;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsPvE;
      private static readonly System.IntPtr NativeFieldInfoPtr_DeallocateListsOnCompletion;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_BuffSpawner_BuffSpawnerSystemData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_BuffSpawner_ServerGameManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_BuffSpawner_String_byref_EntityManager_SingletonAccessor_1_ServerGameBalanceSettings_SingletonAccessor_1_LogEntitySpawnDestroy_byref_PrefabLookupMap_Entity_NativeList_1_BuffInstanceData_NativeList_1_Entity_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PlaybackAndDisposeWithoutSystemData_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PlaybackAndDispose_Public_Void_BuffSpawnerSystemData_0;
      [FieldOffset(0)]
      public bool IsDebuggingActive;
      [FieldOffset(8)]
      public EntityManager EntityManager;
      [FieldOffset(16)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(32)]
      public NativeList<BuffUtility.BuffInstanceData> BuffsModifiedOrSpawned;
      [FieldOffset(48)]
      public NativeList<Entity> BuffsDestroyed;
      [FieldOffset(64)]
      public PrefabLookupMap PrefabLookupMap;
      [FieldOffset(112)]
      public Entity ScrollingCombatPrefab;
      [FieldOffset(120)]
      public bool IsPvE;
      [FieldOffset(121)]
      public bool DeallocateListsOnCompletion;

      [CallerCount(52)]
      [CachedScanResults(RefRangeStart = 724976, RefRangeEnd = 725028, XrefRangeStart = 724950, XrefRangeEnd = 724976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe BuffUtility.BuffSpawner Create(
        BuffUtility.BuffSpawnerSystemData buffSpawnerSystemData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffSpawnerSystemData);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffSpawner.NativeMethodInfoPtr_Create_Public_Static_BuffSpawner_BuffSpawnerSystemData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BuffUtility.BuffSpawner*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 725054, RefRangeEnd = 725055, XrefRangeStart = 725028, XrefRangeEnd = 725054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe BuffUtility.BuffSpawner Create(ServerGameManager gameManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &gameManager;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffSpawner.NativeMethodInfoPtr_Create_Public_Static_BuffSpawner_ServerGameManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BuffUtility.BuffSpawner*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725055, XrefRangeEnd = 725062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe BuffUtility.BuffSpawner Create(
        string worldName,
        [In] ref EntityManager entityManager,
        SingletonAccessor<ServerGameBalanceSettings> serverGameBalanceSettingsAccessor,
        SingletonAccessor<LogEntitySpawnDestroy> logSpawnDestroyAccessor,
        [In] ref PrefabLookupMap prefabLookupMap,
        Entity scrollingCombatTextEventPrefab,
        NativeList<BuffUtility.BuffInstanceData> emptyBuffsModifiedOrSpawned,
        NativeList<Entity> emptyBuffsDestroyed,
        bool deallocateListsOnCompletion)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[9];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(worldName);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverGameBalanceSettingsAccessor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &logSpawnDestroyAccessor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabLookupMap;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &scrollingCombatTextEventPrefab;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &emptyBuffsModifiedOrSpawned;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &emptyBuffsDestroyed;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &deallocateListsOnCompletion;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffSpawner.NativeMethodInfoPtr_Create_Public_Static_BuffSpawner_String_byref_EntityManager_SingletonAccessor_1_ServerGameBalanceSettings_SingletonAccessor_1_LogEntitySpawnDestroy_byref_PrefabLookupMap_Entity_NativeList_1_BuffInstanceData_NativeList_1_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BuffUtility.BuffSpawner*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 725063, RefRangeEnd = 725064, XrefRangeStart = 725062, XrefRangeEnd = 725063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void PlaybackAndDisposeWithoutSystemData()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffSpawner.NativeMethodInfoPtr_PlaybackAndDisposeWithoutSystemData_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(52)]
      [CachedScanResults(RefRangeStart = 725167, RefRangeEnd = 725219, XrefRangeStart = 725064, XrefRangeEnd = 725167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void PlaybackAndDispose(BuffUtility.BuffSpawnerSystemData buffSpawnerData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffSpawnerData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffSpawner.NativeMethodInfoPtr_PlaybackAndDispose_Public_Void_BuffSpawnerSystemData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BuffSpawner()
      {
        Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, nameof (BuffSpawner));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr);
        BuffUtility.BuffSpawner.NativeFieldInfoPtr_IsDebuggingActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, nameof (IsDebuggingActive));
        BuffUtility.BuffSpawner.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, nameof (EntityManager));
        BuffUtility.BuffSpawner.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, nameof (CommandBuffer));
        BuffUtility.BuffSpawner.NativeFieldInfoPtr_BuffsModifiedOrSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, nameof (BuffsModifiedOrSpawned));
        BuffUtility.BuffSpawner.NativeFieldInfoPtr_BuffsDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, nameof (BuffsDestroyed));
        BuffUtility.BuffSpawner.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, nameof (PrefabLookupMap));
        BuffUtility.BuffSpawner.NativeFieldInfoPtr_ScrollingCombatPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, nameof (ScrollingCombatPrefab));
        BuffUtility.BuffSpawner.NativeFieldInfoPtr_IsPvE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, nameof (IsPvE));
        BuffUtility.BuffSpawner.NativeFieldInfoPtr_DeallocateListsOnCompletion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, nameof (DeallocateListsOnCompletion));
        BuffUtility.BuffSpawner.NativeMethodInfoPtr_Create_Public_Static_BuffSpawner_BuffSpawnerSystemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, 100664176);
        BuffUtility.BuffSpawner.NativeMethodInfoPtr_Create_Public_Static_BuffSpawner_ServerGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, 100664177);
        BuffUtility.BuffSpawner.NativeMethodInfoPtr_Create_Public_Static_BuffSpawner_String_byref_EntityManager_SingletonAccessor_1_ServerGameBalanceSettings_SingletonAccessor_1_LogEntitySpawnDestroy_byref_PrefabLookupMap_Entity_NativeList_1_BuffInstanceData_NativeList_1_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, 100664178);
        BuffUtility.BuffSpawner.NativeMethodInfoPtr_PlaybackAndDisposeWithoutSystemData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, 100664179);
        BuffUtility.BuffSpawner.NativeMethodInfoPtr_PlaybackAndDispose_Public_Void_BuffSpawnerSystemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, 100664180);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffUtility.BuffSpawner>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class BuffSpawnerSystemData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_OwnerSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerGameBalanceSettingsAccessor;
      private static readonly System.IntPtr NativeFieldInfoPtr_LogEntitySpawnDestroyAccessor;
      private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrameAccessor;
      private static readonly System.IntPtr NativeFieldInfoPtr__BuffsModifiedOrSpawned;
      private static readonly System.IntPtr NativeFieldInfoPtr__BuffsDestroyed;
      private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameUsed;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_BuffSpawnerSystemData_ComponentSystemBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetLists_Public_Void_byref_NativeList_1_BuffInstanceData_byref_NativeList_1_Entity_byref_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RecycleLists_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(52)]
      [CachedScanResults(RefRangeStart = 725247, RefRangeEnd = 725299, XrefRangeStart = 725219, XrefRangeEnd = 725247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe BuffUtility.BuffSpawnerSystemData Create(ComponentSystemBase system)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffSpawnerSystemData.NativeMethodInfoPtr_Create_Public_Static_BuffSpawnerSystemData_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725299, XrefRangeEnd = 725315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void GetLists(
        out NativeList<BuffUtility.BuffInstanceData> buffsModifiedOrSpawned,
        out NativeList<Entity> buffsDestroyed,
        out bool deallocateAfterUse)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref buffsModifiedOrSpawned;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffsDestroyed;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref deallocateAfterUse;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffSpawnerSystemData.NativeMethodInfoPtr_GetLists_Public_Void_byref_NativeList_1_BuffInstanceData_byref_NativeList_1_Entity_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(52)]
      [CachedScanResults(RefRangeStart = 725330, RefRangeEnd = 725382, XrefRangeStart = 725315, XrefRangeEnd = 725330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffSpawnerSystemData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void RecycleLists()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffSpawnerSystemData.NativeMethodInfoPtr_RecycleLists_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BuffSpawnerSystemData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffSpawnerSystemData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BuffSpawnerSystemData()
      {
        Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, nameof (BuffSpawnerSystemData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr);
        BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_OwnerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, nameof (OwnerSystem));
        BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, nameof (PrefabCollectionSystem));
        BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_ServerGameBalanceSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, nameof (ServerGameBalanceSettingsAccessor));
        BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_LogEntitySpawnDestroyAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, nameof (LogEntitySpawnDestroyAccessor));
        BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__WorldFrameAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, nameof (_WorldFrameAccessor));
        BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__BuffsModifiedOrSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, nameof (_BuffsModifiedOrSpawned));
        BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__BuffsDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, nameof (_BuffsDestroyed));
        BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__LastFrameUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, nameof (_LastFrameUsed));
        BuffUtility.BuffSpawnerSystemData.NativeMethodInfoPtr_Create_Public_Static_BuffSpawnerSystemData_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, 100664181);
        BuffUtility.BuffSpawnerSystemData.NativeMethodInfoPtr_GetLists_Public_Void_byref_NativeList_1_BuffInstanceData_byref_NativeList_1_Entity_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, 100664182);
        BuffUtility.BuffSpawnerSystemData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, 100664183);
        BuffUtility.BuffSpawnerSystemData.NativeMethodInfoPtr_RecycleLists_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, 100664184);
        BuffUtility.BuffSpawnerSystemData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffSpawnerSystemData>.NativeClassPtr, 100664185);
      }

      public BuffSpawnerSystemData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ComponentSystemBase OwnerSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_OwnerSystem));
          return pointer == System.IntPtr.Zero ? (ComponentSystemBase) null : new ComponentSystemBase(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_OwnerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabCollectionSystem PrefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_PrefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SingletonAccessor<ServerGameBalanceSettings> ServerGameBalanceSettingsAccessor
      {
        get
        {
          return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_ServerGameBalanceSettingsAccessor));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_ServerGameBalanceSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SingletonAccessor<LogEntitySpawnDestroy> LogEntitySpawnDestroyAccessor
      {
        get
        {
          return *(SingletonAccessor<LogEntitySpawnDestroy>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_LogEntitySpawnDestroyAccessor));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr_LogEntitySpawnDestroyAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<LogEntitySpawnDestroy>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SingletonAccessor<WorldFrame> _WorldFrameAccessor
      {
        get
        {
          return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__WorldFrameAccessor));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__WorldFrameAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<BuffUtility.BuffInstanceData> _BuffsModifiedOrSpawned
      {
        get
        {
          return *(NativeList<BuffUtility.BuffInstanceData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__BuffsModifiedOrSpawned));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__BuffsModifiedOrSpawned), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<BuffUtility.BuffInstanceData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Entity> _BuffsDestroyed
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__BuffsDestroyed));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__BuffsDestroyed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe int _LastFrameUsed
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__LastFrameUsed));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffUtility.BuffSpawnerSystemData.NativeFieldInfoPtr__LastFrameUsed)) = value;
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TrySpawnBuffArgs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Creator;
      private static readonly System.IntPtr NativeFieldInfoPtr_Target;
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
      [FieldOffset(0)]
      public Entity Creator;
      [FieldOffset(8)]
      public Entity Target;
      [FieldOffset(16)]
      public Entity Prefab;

      static TrySpawnBuffArgs()
      {
        Il2CppClassPointerStore<BuffUtility.TrySpawnBuffArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, nameof (TrySpawnBuffArgs));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffUtility.TrySpawnBuffArgs>.NativeClassPtr);
        BuffUtility.TrySpawnBuffArgs.NativeFieldInfoPtr_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.TrySpawnBuffArgs>.NativeClassPtr, nameof (Creator));
        BuffUtility.TrySpawnBuffArgs.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.TrySpawnBuffArgs>.NativeClassPtr, nameof (Target));
        BuffUtility.TrySpawnBuffArgs.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.TrySpawnBuffArgs>.NativeClassPtr, nameof (Prefab));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffUtility.TrySpawnBuffArgs>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SpawnBuffInstanceKey
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Target;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffType;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpawnBuffInstanceKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public Entity Target;
      [FieldOffset(8)]
      public PrefabGUID BuffType;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725382, XrefRangeEnd = 725383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(BuffUtility.SpawnBuffInstanceKey other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.SpawnBuffInstanceKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpawnBuffInstanceKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725383, XrefRangeEnd = 725388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.SpawnBuffInstanceKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.SpawnBuffInstanceKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static SpawnBuffInstanceKey()
      {
        Il2CppClassPointerStore<BuffUtility.SpawnBuffInstanceKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, nameof (SpawnBuffInstanceKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffUtility.SpawnBuffInstanceKey>.NativeClassPtr);
        BuffUtility.SpawnBuffInstanceKey.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.SpawnBuffInstanceKey>.NativeClassPtr, nameof (Target));
        BuffUtility.SpawnBuffInstanceKey.NativeFieldInfoPtr_BuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.SpawnBuffInstanceKey>.NativeClassPtr, nameof (BuffType));
        BuffUtility.SpawnBuffInstanceKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpawnBuffInstanceKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.SpawnBuffInstanceKey>.NativeClassPtr, 100664186);
        BuffUtility.SpawnBuffInstanceKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.SpawnBuffInstanceKey>.NativeClassPtr, 100664187);
        BuffUtility.SpawnBuffInstanceKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.SpawnBuffInstanceKey>.NativeClassPtr, 100664188);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffUtility.SpawnBuffInstanceKey>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BuffInstanceData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Owner;
      private static readonly System.IntPtr NativeFieldInfoPtr_Creator;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffData;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffCategory;
      private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackImportance;
      private static readonly System.IntPtr NativeFieldInfoPtr_Age;
      private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_ModifiedInThisJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_PreviousStacks;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Target_Public_get_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Stacks_Public_get_Byte_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_Stacks_Public_set_Void_Byte_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxStacks_Public_get_Byte_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxStacks_Public_set_Void_Byte_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FromBuff_Public_Static_BuffInstanceData_BuffBuffer_EntityManager_0;
      [FieldOffset(0)]
      public Entity Owner;
      [FieldOffset(8)]
      public Entity Creator;
      [FieldOffset(16)]
      public Entity Entity;
      [FieldOffset(24)]
      public PrefabGUID Type;
      [FieldOffset(32)]
      public Buff BuffData;
      [FieldOffset(64)]
      public Nullable_Unboxed<BuffCategory> BuffCategory;
      [FieldOffset(96)]
      public Nullable_Unboxed<int> KnockbackImportance;
      [FieldOffset(104)]
      public Nullable_Unboxed<Age> Age;
      [FieldOffset(112)]
      public Nullable_Unboxed<LifeTime> LifeTime;
      [FieldOffset(124)]
      public bool ModifiedInThisJob;
      [FieldOffset(125)]
      public byte PreviousStacks;

      public unsafe Entity Target
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffInstanceData.NativeMethodInfoPtr_get_Target_Public_get_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(0)] set
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &value;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffInstanceData.NativeMethodInfoPtr_set_Target_Public_set_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe byte Stacks
      {
        [CallerCount(0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffInstanceData.NativeMethodInfoPtr_get_Stacks_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(byte*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(0)] set
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &value;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffInstanceData.NativeMethodInfoPtr_set_Stacks_Public_set_Void_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe byte MaxStacks
      {
        [CallerCount(0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffInstanceData.NativeMethodInfoPtr_get_MaxStacks_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(byte*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(0)] set
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &value;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffInstanceData.NativeMethodInfoPtr_set_MaxStacks_Public_set_Void_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 725421, RefRangeEnd = 725422, XrefRangeStart = 725388, XrefRangeEnd = 725421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe BuffUtility.BuffInstanceData FromBuff(
        BuffBuffer buff,
        EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffUtility.BuffInstanceData.NativeMethodInfoPtr_FromBuff_Public_Static_BuffInstanceData_BuffBuffer_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BuffUtility.BuffInstanceData*) IL2CPP.il2cpp_object_unbox(num);
      }

      static BuffInstanceData()
      {
        Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffUtility>.NativeClassPtr, nameof (BuffInstanceData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr);
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (Owner));
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (Creator));
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (Entity));
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (Type));
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_BuffData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (BuffData));
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_BuffCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (BuffCategory));
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_KnockbackImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (KnockbackImportance));
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_Age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (Age));
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (LifeTime));
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_ModifiedInThisJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (ModifiedInThisJob));
        BuffUtility.BuffInstanceData.NativeFieldInfoPtr_PreviousStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, nameof (PreviousStacks));
        BuffUtility.BuffInstanceData.NativeMethodInfoPtr_get_Target_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, 100664189);
        BuffUtility.BuffInstanceData.NativeMethodInfoPtr_set_Target_Public_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, 100664190);
        BuffUtility.BuffInstanceData.NativeMethodInfoPtr_get_Stacks_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, 100664191);
        BuffUtility.BuffInstanceData.NativeMethodInfoPtr_set_Stacks_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, 100664192);
        BuffUtility.BuffInstanceData.NativeMethodInfoPtr_get_MaxStacks_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, 100664193);
        BuffUtility.BuffInstanceData.NativeMethodInfoPtr_set_MaxStacks_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, 100664194);
        BuffUtility.BuffInstanceData.NativeMethodInfoPtr_FromBuff_Public_Static_BuffInstanceData_BuffBuffer_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, 100664195);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffUtility.BuffInstanceData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum TrySpawnBuffResult
    {
      Success_NewBuff,
      Success_ReusedBuff,
      TargetIsNotBuffable,
      TargetDoesNotExist,
      BlockedDueToPvERestrictions,
      KnockbackBlocked,
      CategoryBlocked,
      DiminishingReturnBlocked,
      DiminishingReturnImmune,
      BlockedDueToBuffResistance,
    }

    public enum BuffCategoryResult
    {
      Success,
      Success_RemoveOld,
      Blocked,
    }

    public enum ApplyKnockbackResult
    {
      Success,
      Success_RemoveOld,
      Blocked,
    }

    private sealed class MethodInfoStoreGeneric_HasBuff_Public_Static_Boolean_EntityManager_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BuffUtility.NativeMethodInfoPtr_HasBuff_Public_Static_Boolean_EntityManager_Entity_0, Il2CppClassPointerStore<BuffUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
