// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.HitColliderCastHelper
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Physics;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public static class HitColliderCastHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_DoCollisionCasts_Public_Static_Void_byref_CollisionWorld_byref_EntityManager_Double_Entity_byref_DynamicBuffer_1_HitTrigger_byref_HitColliderCast_byref_Rotation_byref_NativeList_1_ColliderCastHit_byref_NativeList_1_ColliderCastHit_byref_NativeList_1_RaycastHit_byref_NativeList_1_AoETarget_byref_NativeList_1_PhysicsCastResult_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastHits_Private_Static_Void_byref_CollisionWorld_byref_EntityManager_byref_HitColliderCast_float3_float3_Rotation_byref_CollisionFilter_NativeList_1_ColliderCastHit_NativeList_1_ColliderCastHit_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsEntityInGroup_Private_Static_Boolean_byref_DynamicBuffer_1_IgnoreHitsPerTargetElement_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IgnoreAbilityMultiHits_Private_Static_Void_byref_EntityManager_Double_Entity_NativeList_1_ColliderCastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterImmaterialAndTerrainHits_Private_Static_Void_byref_EntityManager_Boolean_NativeList_1_ColliderCastHit_NativeList_1_ColliderCastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterBlockedHits_Private_Static_Void_byref_CollisionWorld_byref_EntityManager_byref_NativeList_1_ColliderCastHit_byref_NativeList_1_RaycastHit_HitColliderCast_float3_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OrderHitsByImportance_Public_Static_Void_Entity_byref_CollisionWorld_byref_EntityManager_HitColliderCast_NativeList_1_PhysicsCastResult_float3_float3_NativeList_1_AoETarget_byref_DynamicBuffer_1_HitTrigger_Int32_Double_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1449387, RefRangeEnd = 1449390, XrefRangeStart = 1449301, XrefRangeEnd = 1449387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DoCollisionCasts(
      ref CollisionWorld collisionWorld,
      ref EntityManager entityManager,
      double serverTime,
      Entity castEntity,
      ref DynamicBuffer<HitTrigger> hitTriggers,
      [In] ref HitColliderCast hitColliderCast,
      [In] ref Rotation rotation,
      ref NativeList<ColliderCastHit> hits,
      ref NativeList<ColliderCastHit> terrainHits,
      ref NativeList<RaycastHit> raycastHits,
      ref NativeList<AoETarget> targets,
      ref NativeList<PhysicsCastResult> results,
      bool showDebug,
      int castIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[14];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &castEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitTriggers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitColliderCast;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainHits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref raycastHits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref targets;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref results;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &castIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitColliderCastHelper.NativeMethodInfoPtr_DoCollisionCasts_Public_Static_Void_byref_CollisionWorld_byref_EntityManager_Double_Entity_byref_DynamicBuffer_1_HitTrigger_byref_HitColliderCast_byref_Rotation_byref_NativeList_1_ColliderCastHit_byref_NativeList_1_ColliderCastHit_byref_NativeList_1_RaycastHit_byref_NativeList_1_AoETarget_byref_NativeList_1_PhysicsCastResult_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1449430, RefRangeEnd = 1449431, XrefRangeStart = 1449390, XrefRangeEnd = 1449430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetCastHits(
      ref CollisionWorld collisionWorld,
      ref EntityManager entityManager,
      [In] ref HitColliderCast hitColliderCast,
      float3 from,
      float3 to,
      Rotation rotation,
      [In] ref CollisionFilter filter,
      NativeList<ColliderCastHit> hits,
      NativeList<ColliderCastHit> terrainHits,
      bool showDebug)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitColliderCast;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainHits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitColliderCastHelper.NativeMethodInfoPtr_GetCastHits_Private_Static_Void_byref_CollisionWorld_byref_EntityManager_byref_HitColliderCast_float3_float3_Rotation_byref_CollisionFilter_NativeList_1_ColliderCastHit_NativeList_1_ColliderCastHit_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1449451, RefRangeEnd = 1449452, XrefRangeStart = 1449431, XrefRangeEnd = 1449451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ContainsEntityInGroup(
      [In] ref this DynamicBuffer<IgnoreHitsPerTargetElement> ignoreHitElements,
      Entity entity,
      int group)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref ignoreHitElements;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &group;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitColliderCastHelper.NativeMethodInfoPtr_ContainsEntityInGroup_Private_Static_Boolean_byref_DynamicBuffer_1_IgnoreHitsPerTargetElement_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1449490, RefRangeEnd = 1449491, XrefRangeStart = 1449452, XrefRangeEnd = 1449490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void IgnoreAbilityMultiHits(
      ref EntityManager entityManager,
      double serverTime,
      Entity castEntity,
      NativeList<ColliderCastHit> hits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitColliderCastHelper.NativeMethodInfoPtr_IgnoreAbilityMultiHits_Private_Static_Void_byref_EntityManager_Double_Entity_NativeList_1_ColliderCastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1449520, RefRangeEnd = 1449521, XrefRangeStart = 1449491, XrefRangeEnd = 1449520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FilterImmaterialAndTerrainHits(
      ref EntityManager entityManager,
      bool ignoreImmaterial,
      NativeList<ColliderCastHit> hits,
      NativeList<ColliderCastHit> terrainHits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreImmaterial;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainHits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitColliderCastHelper.NativeMethodInfoPtr_FilterImmaterialAndTerrainHits_Private_Static_Void_byref_EntityManager_Boolean_NativeList_1_ColliderCastHit_NativeList_1_ColliderCastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449521, XrefRangeEnd = 1449538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FilterBlockedHits(
      ref CollisionWorld collisionWorld,
      ref EntityManager entityManager,
      ref NativeList<ColliderCastHit> hits,
      ref NativeList<RaycastHit> raycastHits,
      HitColliderCast hitColliderCast,
      float3 originPosition,
      bool showDebug)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref raycastHits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hitColliderCast;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &originPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitColliderCastHelper.NativeMethodInfoPtr_FilterBlockedHits_Private_Static_Void_byref_CollisionWorld_byref_EntityManager_byref_NativeList_1_ColliderCastHit_byref_NativeList_1_RaycastHit_HitColliderCast_float3_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1449607, RefRangeEnd = 1449608, XrefRangeStart = 1449538, XrefRangeEnd = 1449607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OrderHitsByImportance(
      Entity entity,
      ref CollisionWorld collisionWorld,
      ref EntityManager entityManager,
      HitColliderCast hitColliderCast,
      NativeList<PhysicsCastResult> hitResults,
      float3 originPosition,
      float3 aimPosition,
      NativeList<AoETarget> targets,
      ref DynamicBuffer<HitTrigger> hitTriggers,
      int castIndex,
      double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hitColliderCast;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hitResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &originPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &aimPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &targets;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitTriggers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &castIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitColliderCastHelper.NativeMethodInfoPtr_OrderHitsByImportance_Public_Static_Void_Entity_byref_CollisionWorld_byref_EntityManager_HitColliderCast_NativeList_1_PhysicsCastResult_float3_float3_NativeList_1_AoETarget_byref_DynamicBuffer_1_HitTrigger_Int32_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HitColliderCastHelper()
    {
      Il2CppClassPointerStore<HitColliderCastHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (HitColliderCastHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitColliderCastHelper>.NativeClassPtr);
      HitColliderCastHelper.NativeMethodInfoPtr_DoCollisionCasts_Public_Static_Void_byref_CollisionWorld_byref_EntityManager_Double_Entity_byref_DynamicBuffer_1_HitTrigger_byref_HitColliderCast_byref_Rotation_byref_NativeList_1_ColliderCastHit_byref_NativeList_1_ColliderCastHit_byref_NativeList_1_RaycastHit_byref_NativeList_1_AoETarget_byref_NativeList_1_PhysicsCastResult_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastHelper>.NativeClassPtr, 100672576);
      HitColliderCastHelper.NativeMethodInfoPtr_GetCastHits_Private_Static_Void_byref_CollisionWorld_byref_EntityManager_byref_HitColliderCast_float3_float3_Rotation_byref_CollisionFilter_NativeList_1_ColliderCastHit_NativeList_1_ColliderCastHit_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastHelper>.NativeClassPtr, 100672577);
      HitColliderCastHelper.NativeMethodInfoPtr_ContainsEntityInGroup_Private_Static_Boolean_byref_DynamicBuffer_1_IgnoreHitsPerTargetElement_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastHelper>.NativeClassPtr, 100672578);
      HitColliderCastHelper.NativeMethodInfoPtr_IgnoreAbilityMultiHits_Private_Static_Void_byref_EntityManager_Double_Entity_NativeList_1_ColliderCastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastHelper>.NativeClassPtr, 100672579);
      HitColliderCastHelper.NativeMethodInfoPtr_FilterImmaterialAndTerrainHits_Private_Static_Void_byref_EntityManager_Boolean_NativeList_1_ColliderCastHit_NativeList_1_ColliderCastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastHelper>.NativeClassPtr, 100672580);
      HitColliderCastHelper.NativeMethodInfoPtr_FilterBlockedHits_Private_Static_Void_byref_CollisionWorld_byref_EntityManager_byref_NativeList_1_ColliderCastHit_byref_NativeList_1_RaycastHit_HitColliderCast_float3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastHelper>.NativeClassPtr, 100672581);
      HitColliderCastHelper.NativeMethodInfoPtr_OrderHitsByImportance_Public_Static_Void_Entity_byref_CollisionWorld_byref_EntityManager_HitColliderCast_NativeList_1_PhysicsCastResult_float3_float3_NativeList_1_AoETarget_byref_DynamicBuffer_1_HitTrigger_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastHelper>.NativeClassPtr, 100672582);
    }

    public HitColliderCastHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
