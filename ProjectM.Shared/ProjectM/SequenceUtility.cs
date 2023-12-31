// Decompiled with JetBrains decompiler
// Type: ProjectM.SequenceUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public static class SequenceUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayImpactSequence_Public_Static_Void_EntityManager_PrefabLookupMap_PrefabGUID_Entity_float3_quaternion_SequenceGUID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_float3_quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_Entity_Translation_Rotation_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityCommandBuffer_Entity_Entity_Translation_Rotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_Entity_float3_quaternion_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequenceOneShot_Public_Static_SequenceState_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequenceOneShot_Public_Static_SequenceState_EntityManager_Entity_Entity_float3_quaternion_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityCommandBuffer_Entity_Entity_float3_quaternion_Boolean_Entity_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 748220, RefRangeEnd = 748221, XrefRangeStart = 748177, XrefRangeEnd = 748220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PlayImpactSequence(
      EntityManager entityManager,
      PrefabLookupMap prefabLookupMap,
      PrefabGUID impactMappingGuid,
      Entity target,
      float3 position,
      quaternion rotation,
      SequenceGUID impactSequenceGuid = default (SequenceGUID),
      bool skipMaterialSequence = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &impactMappingGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &impactSequenceGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &skipMaterialSequence;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceUtility.NativeMethodInfoPtr_PlayImpactSequence_Public_Static_Void_EntityManager_PrefabLookupMap_PrefabGUID_Entity_float3_quaternion_SequenceGUID_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 748282, RefRangeEnd = 748287, XrefRangeStart = 748221, XrefRangeEnd = 748282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SequenceState PlaySequence(
      EntityManager entityManager,
      Entity sequencePrefab,
      float3 position,
      quaternion rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sequencePrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_float3_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 748294, RefRangeEnd = 748319, XrefRangeStart = 748287, XrefRangeEnd = 748294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SequenceState PlaySequence(
      EntityManager entityManager,
      Entity targetEntity,
      Entity sequencePrefab,
      Entity secondaryTargetEntity = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequencePrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryTargetEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 748320, RefRangeEnd = 748327, XrefRangeStart = 748319, XrefRangeEnd = 748320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SequenceState PlaySequence(
      EntityManager entityManager,
      Entity targetEntity,
      Entity sequencePrefab,
      Translation translation,
      Rotation rotation,
      Entity secondaryTargetEntity = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequencePrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryTargetEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_Entity_Translation_Rotation_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(34)]
    [CachedScanResults(RefRangeStart = 748349, RefRangeEnd = 748383, XrefRangeStart = 748327, XrefRangeEnd = 748349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SequenceState PlaySequence(
      EntityCommandBuffer commandBuffer,
      Entity targetEntity,
      Entity sequencePrefab,
      Translation translation,
      Rotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequencePrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityCommandBuffer_Entity_Entity_Translation_Rotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 748418, RefRangeEnd = 748434, XrefRangeStart = 748383, XrefRangeEnd = 748418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SequenceState PlaySequence(
      EntityManager entityManager,
      Entity targetEntity,
      Entity sequencePrefab,
      float3 position,
      quaternion rotation,
      bool oneShot = true,
      Entity secondaryTargetEntity = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequencePrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &oneShot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryTargetEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_Entity_float3_quaternion_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 748447, RefRangeEnd = 748449, XrefRangeStart = 748434, XrefRangeEnd = 748447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SequenceState PlaySequenceOneShot(
      EntityManager entityManager,
      Entity targetEntity,
      Entity sequencePrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequencePrefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceUtility.NativeMethodInfoPtr_PlaySequenceOneShot_Public_Static_SequenceState_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 748509, RefRangeEnd = 748511, XrefRangeStart = 748449, XrefRangeEnd = 748509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SequenceState PlaySequenceOneShot(
      EntityManager entityManager,
      Entity targetEntity,
      Entity sequencePrefab,
      float3 position,
      quaternion rotation,
      Entity secondaryTargetEntity = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequencePrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryTargetEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceUtility.NativeMethodInfoPtr_PlaySequenceOneShot_Public_Static_SequenceState_EntityManager_Entity_Entity_float3_quaternion_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748511, XrefRangeEnd = 748533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SequenceState PlaySequence(
      EntityCommandBuffer commandBuffer,
      Entity targetEntity,
      Entity sequencePrefab,
      float3 position,
      quaternion rotation,
      bool oneShot = true,
      Entity secondaryTargetEntity = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sequencePrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &oneShot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryTargetEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityCommandBuffer_Entity_Entity_float3_quaternion_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SequenceUtility()
    {
      Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SequenceUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr);
      SequenceUtility.NativeMethodInfoPtr_PlayImpactSequence_Public_Static_Void_EntityManager_PrefabLookupMap_PrefabGUID_Entity_float3_quaternion_SequenceGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr, 100665888);
      SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_float3_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr, 100665889);
      SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr, 100665890);
      SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_Entity_Translation_Rotation_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr, 100665891);
      SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityCommandBuffer_Entity_Entity_Translation_Rotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr, 100665892);
      SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityManager_Entity_Entity_float3_quaternion_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr, 100665893);
      SequenceUtility.NativeMethodInfoPtr_PlaySequenceOneShot_Public_Static_SequenceState_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr, 100665894);
      SequenceUtility.NativeMethodInfoPtr_PlaySequenceOneShot_Public_Static_SequenceState_EntityManager_Entity_Entity_float3_quaternion_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr, 100665895);
      SequenceUtility.NativeMethodInfoPtr_PlaySequence_Public_Static_SequenceState_EntityCommandBuffer_Entity_Entity_float3_quaternion_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceUtility>.NativeClassPtr, 100665896);
    }

    public SequenceUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
