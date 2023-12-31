// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.DestroyUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  public static class DestroyUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityManager_Entity_DestroyDebugReason_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyWithReason_Public_Static_Void_EntityManager_Entity_DestroyReason_DestroyDebugReason_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDestroyEvent_Private_Static_Void_EntityManager_Entity_DestroyReason_DestroyDebugReason_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityManager_NativeArray_1_Entity_DestroyReason_DestroyDebugReason_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityCommandBuffer_Entity_DestroyDebugReason_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyWithReason_Public_Static_Void_EntityCommandBuffer_Entity_DestroyReason_DestroyDebugReason_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDestroyEvent_Private_Static_Void_EntityCommandBuffer_Entity_DestroyReason_DestroyDebugReason_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_ParallelWriter_Int32_Entity_DestroyReason_DestroyDebugReason_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckForIssue_Private_Static_Boolean_Entity_Boolean_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AssertValidEntityToDestroy_Private_Static_Void_Entity_Boolean_Nullable_Unboxed_1_Int32_0;

    [CallerCount(82)]
    [CachedScanResults(RefRangeStart = 799509, RefRangeEnd = 799591, XrefRangeStart = 799485, XrefRangeEnd = 799509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Destroy(
      EntityManager entityManager,
      Entity entity,
      DestroyDebugReason debugReason = DestroyDebugReason.None,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &debugReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyUtility.NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityManager_Entity_DestroyDebugReason_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 799615, RefRangeEnd = 799624, XrefRangeStart = 799591, XrefRangeEnd = 799615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyWithReason(
      EntityManager entityManager,
      Entity entity,
      DestroyReason reason,
      DestroyDebugReason debugReason = DestroyDebugReason.None,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &reason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &debugReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyUtility.NativeMethodInfoPtr_DestroyWithReason_Public_Static_Void_EntityManager_Entity_DestroyReason_DestroyDebugReason_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 799628, RefRangeEnd = 799631, XrefRangeStart = 799624, XrefRangeEnd = 799628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateDestroyEvent(
      EntityManager entityManager,
      Entity entity,
      DestroyReason reason,
      DestroyDebugReason debugReason)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &reason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &debugReason;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyUtility.NativeMethodInfoPtr_CreateDestroyEvent_Private_Static_Void_EntityManager_Entity_DestroyReason_DestroyDebugReason_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 799655, RefRangeEnd = 799673, XrefRangeStart = 799631, XrefRangeEnd = 799655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Destroy(
      EntityManager entityManager,
      NativeArray<Entity> entities,
      DestroyReason reason = DestroyReason.Default,
      DestroyDebugReason debugReason = DestroyDebugReason.None,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &reason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &debugReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyUtility.NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityManager_NativeArray_1_Entity_DestroyReason_DestroyDebugReason_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(166)]
    [CachedScanResults(RefRangeStart = 799692, RefRangeEnd = 799858, XrefRangeStart = 799673, XrefRangeEnd = 799692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Destroy(
      EntityCommandBuffer commandBuffer,
      Entity entity,
      DestroyDebugReason debugReason = DestroyDebugReason.None,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &debugReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyUtility.NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityCommandBuffer_Entity_DestroyDebugReason_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 799877, RefRangeEnd = 799894, XrefRangeStart = 799858, XrefRangeEnd = 799877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyWithReason(
      EntityCommandBuffer commandBuffer,
      Entity entity,
      DestroyReason reason,
      DestroyDebugReason debugReason = DestroyDebugReason.None,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &reason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &debugReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyUtility.NativeMethodInfoPtr_DestroyWithReason_Public_Static_Void_EntityCommandBuffer_Entity_DestroyReason_DestroyDebugReason_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799894, XrefRangeEnd = 799898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateDestroyEvent(
      EntityCommandBuffer commandBuffer,
      Entity entity,
      DestroyReason reason,
      DestroyDebugReason debugReason)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &reason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &debugReason;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyUtility.NativeMethodInfoPtr_CreateDestroyEvent_Private_Static_Void_EntityCommandBuffer_Entity_DestroyReason_DestroyDebugReason_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 799918, RefRangeEnd = 799919, XrefRangeStart = 799898, XrefRangeEnd = 799918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Destroy(
      EntityCommandBuffer.ParallelWriter commandBuffer,
      int threadIndex,
      Entity entity,
      DestroyReason reason = DestroyReason.Default,
      DestroyDebugReason debugReason = DestroyDebugReason.None,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &threadIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &reason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &debugReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyUtility.NativeMethodInfoPtr_Destroy_Public_Static_Void_ParallelWriter_Int32_Entity_DestroyReason_DestroyDebugReason_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 799923, RefRangeEnd = 799925, XrefRangeStart = 799919, XrefRangeEnd = 799923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckForIssue(
      Entity entity,
      bool createdWithValidECB,
      Nullable_Unboxed<int> entityCapacity = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &createdWithValidECB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityCapacity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyUtility.NativeMethodInfoPtr_CheckForIssue_Private_Static_Boolean_Entity_Boolean_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 799929, RefRangeEnd = 799935, XrefRangeStart = 799925, XrefRangeEnd = 799929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AssertValidEntityToDestroy(
      Entity entity,
      bool createdWithValidECB,
      Nullable_Unboxed<int> entityCapacity = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &createdWithValidECB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityCapacity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyUtility.NativeMethodInfoPtr_AssertValidEntityToDestroy_Private_Static_Void_Entity_Boolean_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyUtility()
    {
      Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (DestroyUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr);
      DestroyUtility.NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityManager_Entity_DestroyDebugReason_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr, 100670557);
      DestroyUtility.NativeMethodInfoPtr_DestroyWithReason_Public_Static_Void_EntityManager_Entity_DestroyReason_DestroyDebugReason_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr, 100670558);
      DestroyUtility.NativeMethodInfoPtr_CreateDestroyEvent_Private_Static_Void_EntityManager_Entity_DestroyReason_DestroyDebugReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr, 100670559);
      DestroyUtility.NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityManager_NativeArray_1_Entity_DestroyReason_DestroyDebugReason_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr, 100670560);
      DestroyUtility.NativeMethodInfoPtr_Destroy_Public_Static_Void_EntityCommandBuffer_Entity_DestroyDebugReason_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr, 100670561);
      DestroyUtility.NativeMethodInfoPtr_DestroyWithReason_Public_Static_Void_EntityCommandBuffer_Entity_DestroyReason_DestroyDebugReason_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr, 100670562);
      DestroyUtility.NativeMethodInfoPtr_CreateDestroyEvent_Private_Static_Void_EntityCommandBuffer_Entity_DestroyReason_DestroyDebugReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr, 100670563);
      DestroyUtility.NativeMethodInfoPtr_Destroy_Public_Static_Void_ParallelWriter_Int32_Entity_DestroyReason_DestroyDebugReason_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr, 100670564);
      DestroyUtility.NativeMethodInfoPtr_CheckForIssue_Private_Static_Boolean_Entity_Boolean_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr, 100670565);
      DestroyUtility.NativeMethodInfoPtr_AssertValidEntityToDestroy_Private_Static_Void_Entity_Boolean_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUtility>.NativeClassPtr, 100670566);
    }

    public DestroyUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
