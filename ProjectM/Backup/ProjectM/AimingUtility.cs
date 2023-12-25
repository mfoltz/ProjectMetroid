// Decompiled with JetBrains decompiler
// Type: ProjectM.AimingUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Presentation;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public static class AimingUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldIgnoreEntity_Private_Static_Boolean_byref_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldIgnore_Public_Static_Boolean_byref_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllLinkedEntitiesHidden_Private_Static_Boolean_byref_EntityManager_byref_DynamicBuffer_1_LinkedEntityGroup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TestAABBAABB_Public_Static_Boolean_byref_AABB_byref_AABB_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FadeOutBoundingBox_Public_Static_AABB_float3_byref_FadeTargetsSingleton_byref_CurrentFadingDataSingleton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EstimateInsideFadeOut_Public_Static_Boolean_float3_byref_FadeTargetsSingleton_float3_byref_CurrentFadingDataSingleton_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EstimateInsideFadeOut_Public_Static_Boolean_float3_float3_float3_byref_CurrentFadingDataSingleton_Single_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045549, XrefRangeEnd = 1045558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShouldIgnoreEntity([In] ref EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AimingUtility.NativeMethodInfoPtr_ShouldIgnoreEntity_Private_Static_Boolean_byref_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1045574, RefRangeEnd = 1045576, XrefRangeStart = 1045558, XrefRangeEnd = 1045574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShouldIgnore([In] ref EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AimingUtility.NativeMethodInfoPtr_ShouldIgnore_Public_Static_Boolean_byref_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1045603, RefRangeEnd = 1045604, XrefRangeStart = 1045576, XrefRangeEnd = 1045603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AllLinkedEntitiesHidden(
      [In] ref EntityManager entityManager,
      [In] ref DynamicBuffer<LinkedEntityGroup> linkedEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref linkedEntities;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AimingUtility.NativeMethodInfoPtr_AllLinkedEntitiesHidden_Private_Static_Boolean_byref_EntityManager_byref_DynamicBuffer_1_LinkedEntityGroup_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool TestAABBAABB([In] ref AABB a, [In] ref AABB b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AimingUtility.NativeMethodInfoPtr_TestAABBAABB_Public_Static_Boolean_byref_AABB_byref_AABB_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045604, XrefRangeEnd = 1045634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AABB FadeOutBoundingBox(
      float3 camera,
      [In] ref FadeTargetsSingleton fadeTargets,
      [In] ref CurrentFadingDataSingleton fadingData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &camera;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fadeTargets;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fadingData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AimingUtility.NativeMethodInfoPtr_FadeOutBoundingBox_Public_Static_AABB_float3_byref_FadeTargetsSingleton_byref_CurrentFadingDataSingleton_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AABB*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045634, XrefRangeEnd = 1045654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool EstimateInsideFadeOut(
      float3 camera,
      [In] ref FadeTargetsSingleton fadeTargets,
      float3 position,
      [In] ref CurrentFadingDataSingleton fadingData,
      float insideStrength = 0.0f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &camera;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fadeTargets;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref fadingData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &insideStrength;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AimingUtility.NativeMethodInfoPtr_EstimateInsideFadeOut_Public_Static_Boolean_float3_byref_FadeTargetsSingleton_float3_byref_CurrentFadingDataSingleton_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1045658, RefRangeEnd = 1045659, XrefRangeStart = 1045654, XrefRangeEnd = 1045658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool EstimateInsideFadeOut(
      float3 camera,
      float3 fadeTarget,
      float3 position,
      [In] ref CurrentFadingDataSingleton fadingData,
      float insideStrength = 0.0f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &camera;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fadeTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref fadingData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &insideStrength;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AimingUtility.NativeMethodInfoPtr_EstimateInsideFadeOut_Public_Static_Boolean_float3_float3_float3_byref_CurrentFadingDataSingleton_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AimingUtility()
    {
      Il2CppClassPointerStore<AimingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AimingUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AimingUtility>.NativeClassPtr);
      AimingUtility.NativeMethodInfoPtr_ShouldIgnoreEntity_Private_Static_Boolean_byref_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimingUtility>.NativeClassPtr, 100681920);
      AimingUtility.NativeMethodInfoPtr_ShouldIgnore_Public_Static_Boolean_byref_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimingUtility>.NativeClassPtr, 100681921);
      AimingUtility.NativeMethodInfoPtr_AllLinkedEntitiesHidden_Private_Static_Boolean_byref_EntityManager_byref_DynamicBuffer_1_LinkedEntityGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimingUtility>.NativeClassPtr, 100681922);
      AimingUtility.NativeMethodInfoPtr_TestAABBAABB_Public_Static_Boolean_byref_AABB_byref_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimingUtility>.NativeClassPtr, 100681923);
      AimingUtility.NativeMethodInfoPtr_FadeOutBoundingBox_Public_Static_AABB_float3_byref_FadeTargetsSingleton_byref_CurrentFadingDataSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimingUtility>.NativeClassPtr, 100681924);
      AimingUtility.NativeMethodInfoPtr_EstimateInsideFadeOut_Public_Static_Boolean_float3_byref_FadeTargetsSingleton_float3_byref_CurrentFadingDataSingleton_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimingUtility>.NativeClassPtr, 100681925);
      AimingUtility.NativeMethodInfoPtr_EstimateInsideFadeOut_Public_Static_Boolean_float3_float3_float3_byref_CurrentFadingDataSingleton_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimingUtility>.NativeClassPtr, 100681926);
    }

    public AimingUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
