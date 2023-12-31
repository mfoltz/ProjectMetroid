// Decompiled with JetBrains decompiler
// Type: ProjectM.HitFilterUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM
{
  public static class HitFilterUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBlocked_Public_Static_Boolean_byref_CollisionWorld_byref_EntityManager_Boolean_Entity_float3_float3_byref_NativeList_1_RaycastHit_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Static_Boolean_EntityManager_Entity_Entity_HitFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckHealth_Private_Static_Boolean_EntityManager_HitFilter_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckImmaterial_Private_Static_Boolean_EntityManager_HitFilter_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckTeam_Private_Static_Boolean_EntityManager_HitFilter_Entity_Entity_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 747929, RefRangeEnd = 747937, XrefRangeStart = 747875, XrefRangeEnd = 747929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsBlocked(
      ref CollisionWorld collisionWorld,
      ref EntityManager entityManager,
      bool ignoreImmaterial,
      Entity hitEntity,
      float3 hitPosition,
      float3 originPosition,
      ref NativeList<RaycastHit> raycastHits,
      bool showDebugCasts = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreImmaterial;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hitEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hitPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &originPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref raycastHits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebugCasts;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitFilterUtility.NativeMethodInfoPtr_IsBlocked_Public_Static_Boolean_byref_CollisionWorld_byref_EntityManager_Boolean_Entity_float3_float3_byref_NativeList_1_RaycastHit_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 747938, RefRangeEnd = 747945, XrefRangeStart = 747937, XrefRangeEnd = 747938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Check(
      EntityManager entityManager,
      Entity contextEntity,
      Entity entityHit,
      HitFilter hitFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityHit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitFilterUtility.NativeMethodInfoPtr_Check_Public_Static_Boolean_EntityManager_Entity_Entity_HitFilter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747945, XrefRangeEnd = 747951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckHealth(
      EntityManager entityManager,
      HitFilter hitFilter,
      Entity entityHit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityHit;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitFilterUtility.NativeMethodInfoPtr_CheckHealth_Private_Static_Boolean_EntityManager_HitFilter_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747951, XrefRangeEnd = 747955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckImmaterial(
      EntityManager entityManager,
      HitFilter hitFilter,
      Entity entityHit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityHit;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitFilterUtility.NativeMethodInfoPtr_CheckImmaterial_Private_Static_Boolean_EntityManager_HitFilter_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747955, XrefRangeEnd = 747982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckTeam(
      EntityManager entityManager,
      HitFilter hitFilter,
      Entity contextEntity,
      Entity entityHit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityHit;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitFilterUtility.NativeMethodInfoPtr_CheckTeam_Private_Static_Boolean_EntityManager_HitFilter_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HitFilterUtility()
    {
      Il2CppClassPointerStore<HitFilterUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HitFilterUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitFilterUtility>.NativeClassPtr);
      HitFilterUtility.NativeMethodInfoPtr_IsBlocked_Public_Static_Boolean_byref_CollisionWorld_byref_EntityManager_Boolean_Entity_float3_float3_byref_NativeList_1_RaycastHit_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFilterUtility>.NativeClassPtr, 100665872);
      HitFilterUtility.NativeMethodInfoPtr_Check_Public_Static_Boolean_EntityManager_Entity_Entity_HitFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFilterUtility>.NativeClassPtr, 100665873);
      HitFilterUtility.NativeMethodInfoPtr_CheckHealth_Private_Static_Boolean_EntityManager_HitFilter_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFilterUtility>.NativeClassPtr, 100665874);
      HitFilterUtility.NativeMethodInfoPtr_CheckImmaterial_Private_Static_Boolean_EntityManager_HitFilter_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFilterUtility>.NativeClassPtr, 100665875);
      HitFilterUtility.NativeMethodInfoPtr_CheckTeam_Private_Static_Boolean_EntityManager_HitFilter_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFilterUtility>.NativeClassPtr, 100665876);
    }

    public HitFilterUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
