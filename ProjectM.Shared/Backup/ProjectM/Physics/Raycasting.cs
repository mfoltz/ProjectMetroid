// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.Raycasting
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM.Physics
{
  public static class Raycasting : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RAYCAST_OFFSET;
    private static readonly System.IntPtr NativeFieldInfoPtr_RAYCAST_OFFSET3;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultHeight;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyAndSortResults_Public_Static_Void_byref_CollisionWorld_NativeList_1_ColliderCastHit_NativeList_1_PhysicsCastResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyResults_Public_Static_Void_byref_CollisionWorld_NativeList_1_ColliderCastHit_NativeList_1_PhysicsCastResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRay_Public_Static_RaycastInput_Ray_Int32_CollisionFilterFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRay_Public_Static_RaycastInput_float3_float3_CollisionFilterFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunSingleFrontFace_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_byref_NativeList_1_RaycastHit_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Single_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_byref_RaycastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SingleWithIgnore_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_NativeHashSet_1_Entity_byref_RaycastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Single_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_byref_NativeList_1_RaycastHit_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConeCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_Single_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConeCastDebug_Private_Static_Void_float3_float3_Single_Single_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SphereCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OverlappingSphere_Public_Static_Boolean_byref_CollisionWorld_float3_Single_CollisionFilter_NativeList_1_DistanceHit_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DonutCast_Public_Static_Boolean_byref_CollisionWorld_byref_EntityManager_float3_float3_Single_Single_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OverlappingDonutCast_Public_Static_Boolean_byref_CollisionWorld_float3_Single_Single_CollisionFilter_NativeList_1_DistanceHit_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWithinDonutShape_Private_Static_Boolean_float3_Single_Single_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_ColliderCastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_DistanceHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_RaycastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_EntityManager_NativeList_1_ColliderCastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdjustHitPositions_Public_Static_Void_byref_CollisionWorld_byref_NativeList_1_ColliderCastHit_CollisionFilter_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_EntityManager_NativeList_1_DistanceHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_EntityManager_NativeList_1_RaycastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_byref_ColliderCastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_byref_DistanceHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_byref_RaycastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_EntityManager_byref_ColliderCastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_EntityManager_byref_DistanceHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_EntityManager_byref_RaycastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapPhysicsCastResults_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_PhysicsCastResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapPhysicsCastResults_Public_Static_Void_EntityManager_NativeList_1_PhysicsCastResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SphereCastDebug_Private_Static_Void_float3_float3_Single_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SphereCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_CollisionFilter_byref_ColliderCastHit_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BoxCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_quaternion_float3_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CylinderCastUp_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_Single_Int32_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CylinderCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_quaternion_Single_Single_Int32_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CylinderCastDebug_Private_Static_Void_float3_float3_quaternion_Single_Single_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeight_Public_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeights_Public_Static_Boolean_float2_byref_CollisionWorld_CollisionFilterFlags_byref_NativeList_1_EntityHeight_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightWithIgnore_Public_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_NativeHashSet_1_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHeight_Public_Static_Boolean_float2_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHeight_Public_Static_Boolean_float3_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightSingle_Private_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightSingleWithIgnore_Private_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_NativeHashSet_1_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHeightSingle_Private_Static_Boolean_float2_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHeightSingle_Private_Static_Boolean_float3_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightFilterByHeightLevel_Public_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Byte_ComponentDataFromEntity_1_TilePosition_byref_Boolean_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightFilterByHeightLevelMulti_Private_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Byte_ComponentDataFromEntity_1_TilePosition_byref_Boolean_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRaycastInput_Public_Static_RaycastInput_float2_CollisionFilterFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRaycastInput_Public_Static_RaycastInput_float3_CollisionFilterFlags_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768948, RefRangeEnd = 768949, XrefRangeStart = 768925, XrefRangeEnd = 768948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyAndSortResults(
      ref CollisionWorld collisionWorld,
      NativeList<ColliderCastHit> hits,
      NativeList<PhysicsCastResult> results)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &results;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_CopyAndSortResults_Public_Static_Void_byref_CollisionWorld_NativeList_1_ColliderCastHit_NativeList_1_PhysicsCastResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768949, XrefRangeEnd = 768966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyResults(
      ref CollisionWorld collisionWorld,
      NativeList<ColliderCastHit> hits,
      NativeList<PhysicsCastResult> results)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &results;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_CopyResults_Public_Static_Void_byref_CollisionWorld_NativeList_1_ColliderCastHit_NativeList_1_PhysicsCastResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768976, RefRangeEnd = 768977, XrefRangeStart = 768966, XrefRangeEnd = 768976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RaycastInput GetRay(
      UnityEngine.Ray unityRay,
      int rayLength,
      CollisionFilterFlags collidesWith)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &unityRay;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rayLength;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetRay_Public_Static_RaycastInput_Ray_Int32_CollisionFilterFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RaycastInput*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 768979, RefRangeEnd = 768990, XrefRangeStart = 768977, XrefRangeEnd = 768979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RaycastInput GetRay(
      float3 start,
      float3 end,
      CollisionFilterFlags collidesWith)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetRay_Public_Static_RaycastInput_float3_float3_CollisionFilterFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RaycastInput*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768999, RefRangeEnd = 769000, XrefRangeStart = 768990, XrefRangeEnd = 768999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RunSingleFrontFace(
      ref CollisionWorld collisionWorld,
      RaycastInput input,
      ref NativeList<RaycastHit> allHits,
      bool sortHits = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref allHits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sortHits;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RunSingleFrontFace_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_byref_NativeList_1_RaycastHit_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 769001, RefRangeEnd = 769007, XrefRangeStart = 769000, XrefRangeEnd = 769001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Single(
      ref CollisionWorld world,
      RaycastInput input,
      out RaycastHit result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_Single_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_byref_RaycastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769047, RefRangeEnd = 769048, XrefRangeStart = 769007, XrefRangeEnd = 769047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool SingleWithIgnore(
      ref CollisionWorld world,
      RaycastInput input,
      NativeHashSet<Entity> ignoreWhenRaycasting,
      out RaycastHit result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreWhenRaycasting;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_SingleWithIgnore_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_NativeHashSet_1_Entity_byref_RaycastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 769052, RefRangeEnd = 769057, XrefRangeStart = 769048, XrefRangeEnd = 769052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Single(
      ref CollisionWorld world,
      RaycastInput input,
      ref NativeList<RaycastHit> allHits,
      bool sortHits = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref allHits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sortHits;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_Single_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_byref_NativeList_1_RaycastHit_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 769081, RefRangeEnd = 769084, XrefRangeStart = 769057, XrefRangeEnd = 769081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ConeCast(
      ref CollisionWorld world,
      float3 start,
      float3 direction,
      float radius,
      float angle,
      CollisionFilter filter,
      NativeList<ColliderCastHit> hits,
      bool showDebug = false,
      bool debugOneShot = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_ConeCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_Single_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769084, XrefRangeEnd = 769117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ConeCastDebug(
      float3 start,
      float3 direction,
      float radius,
      float angle,
      bool showDebug,
      bool debugOneShot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_ConeCastDebug_Private_Static_Void_float3_float3_Single_Single_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 769133, RefRangeEnd = 769139, XrefRangeStart = 769117, XrefRangeEnd = 769133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool SphereCast(
      ref CollisionWorld world,
      float3 start,
      float3 end,
      float radius,
      CollisionFilter filter,
      NativeList<ColliderCastHit> hits,
      bool showDebug = false,
      bool debugOneShot = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_SphereCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 769140, RefRangeEnd = 769144, XrefRangeStart = 769139, XrefRangeEnd = 769140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool OverlappingSphere(
      ref CollisionWorld world,
      float3 position,
      float radius,
      CollisionFilter filter,
      NativeList<DistanceHit> hits,
      bool showDebug = false,
      bool debugOneShot = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_OverlappingSphere_Public_Static_Boolean_byref_CollisionWorld_float3_Single_CollisionFilter_NativeList_1_DistanceHit_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 769177, RefRangeEnd = 769179, XrefRangeStart = 769144, XrefRangeEnd = 769177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool DonutCast(
      ref CollisionWorld world,
      ref EntityManager entityManager,
      float3 start,
      float3 end,
      float radius,
      float innerRadius,
      CollisionFilter filter,
      NativeList<ColliderCastHit> hits,
      bool showDebug = false,
      bool debugOneShot = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &innerRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_DonutCast_Public_Static_Boolean_byref_CollisionWorld_byref_EntityManager_float3_float3_Single_Single_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769194, RefRangeEnd = 769195, XrefRangeStart = 769179, XrefRangeEnd = 769194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool OverlappingDonutCast(
      ref CollisionWorld world,
      float3 position,
      float radius,
      float innerRadius,
      CollisionFilter filter,
      NativeList<DistanceHit> hits,
      bool showDebug = false,
      bool debugOneShot = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &innerRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_OverlappingDonutCast_Public_Static_Boolean_byref_CollisionWorld_float3_Single_Single_CollisionFilter_NativeList_1_DistanceHit_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsWithinDonutShape(
      float3 donutCenter,
      float sqInnerRadius,
      float maxHeightDiff,
      float3 hitPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &donutCenter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sqInnerRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxHeightDiff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hitPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_IsWithinDonutShape_Private_Static_Boolean_float3_Single_Single_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769195, XrefRangeEnd = 769212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitsToPhysicsParent(
      ComponentDataFromEntity<RedirectCollisionChecksToParent> getRedirectPhysics,
      NativeList<ColliderCastHit> hits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &getRedirectPhysics;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_ColliderCastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769212, XrefRangeEnd = 769229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitsToPhysicsParent(
      ComponentDataFromEntity<RedirectCollisionChecksToParent> getRedirectPhysics,
      NativeList<DistanceHit> hits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &getRedirectPhysics;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_DistanceHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769229, XrefRangeEnd = 769246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitsToPhysicsParent(
      ComponentDataFromEntity<RedirectCollisionChecksToParent> getRedirectPhysics,
      NativeList<RaycastHit> hits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &getRedirectPhysics;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_RaycastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 769263, RefRangeEnd = 769269, XrefRangeStart = 769246, XrefRangeEnd = 769263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitsToPhysicsParent(
      EntityManager entityManager,
      NativeList<ColliderCastHit> hits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_EntityManager_NativeList_1_ColliderCastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 769293, RefRangeEnd = 769297, XrefRangeStart = 769269, XrefRangeEnd = 769293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AdjustHitPositions(
      ref CollisionWorld collisionWorld,
      ref NativeList<ColliderCastHit> hits,
      CollisionFilter collisionFilter,
      float3 castOrigin)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &castOrigin;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_AdjustHitPositions_Public_Static_Void_byref_CollisionWorld_byref_NativeList_1_ColliderCastHit_CollisionFilter_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 769314, RefRangeEnd = 769316, XrefRangeStart = 769297, XrefRangeEnd = 769314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitsToPhysicsParent(
      EntityManager entityManager,
      NativeList<DistanceHit> hits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_EntityManager_NativeList_1_DistanceHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 769333, RefRangeEnd = 769336, XrefRangeStart = 769316, XrefRangeEnd = 769333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitsToPhysicsParent(
      EntityManager entityManager,
      NativeList<RaycastHit> hits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_EntityManager_NativeList_1_RaycastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769336, XrefRangeEnd = 769342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitToPhysicsParent(
      ComponentDataFromEntity<RedirectCollisionChecksToParent> getRedirectPhysics,
      ref ColliderCastHit hit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &getRedirectPhysics;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hit;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_byref_ColliderCastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769342, XrefRangeEnd = 769348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitToPhysicsParent(
      ComponentDataFromEntity<RedirectCollisionChecksToParent> getRedirectPhysics,
      ref DistanceHit hit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &getRedirectPhysics;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hit;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_byref_DistanceHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769348, XrefRangeEnd = 769354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitToPhysicsParent(
      ComponentDataFromEntity<RedirectCollisionChecksToParent> getRedirectPhysics,
      ref RaycastHit hit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &getRedirectPhysics;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hit;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_byref_RaycastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769354, XrefRangeEnd = 769360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitToPhysicsParent(
      EntityManager entityManager,
      ref ColliderCastHit hit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hit;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_EntityManager_byref_ColliderCastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769360, XrefRangeEnd = 769366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitToPhysicsParent(
      EntityManager entityManager,
      ref DistanceHit hit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hit;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_EntityManager_byref_DistanceHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769366, XrefRangeEnd = 769372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapHitToPhysicsParent(
      EntityManager entityManager,
      ref RaycastHit hit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hit;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_EntityManager_byref_RaycastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769372, XrefRangeEnd = 769389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapPhysicsCastResults(
      ComponentDataFromEntity<RedirectCollisionChecksToParent> getRedirectPhysics,
      NativeList<PhysicsCastResult> results)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &getRedirectPhysics;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &results;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapPhysicsCastResults_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_PhysicsCastResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769403, RefRangeEnd = 769404, XrefRangeStart = 769389, XrefRangeEnd = 769403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemapPhysicsCastResults(
      EntityManager entityManager,
      NativeList<PhysicsCastResult> results)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &results;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_RemapPhysicsCastResults_Public_Static_Void_EntityManager_NativeList_1_PhysicsCastResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769404, XrefRangeEnd = 769412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SphereCastDebug(
      float3 start,
      float3 end,
      float radius,
      bool showDebug,
      bool debugOneShot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_SphereCastDebug_Private_Static_Void_float3_float3_Single_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769412, XrefRangeEnd = 769428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool SphereCast(
      ref CollisionWorld world,
      float3 start,
      float3 end,
      float radius,
      CollisionFilter filter,
      out ColliderCastHit hit,
      bool showDebug = false,
      bool debugOneShot = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref hit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_SphereCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_CollisionFilter_byref_ColliderCastHit_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 769444, RefRangeEnd = 769448, XrefRangeStart = 769428, XrefRangeEnd = 769444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool BoxCast(
      ref CollisionWorld world,
      float3 start,
      float3 end,
      quaternion orientation,
      float3 size,
      CollisionFilter filter,
      NativeList<ColliderCastHit> hits,
      bool showDebug = false,
      bool debugOneShot = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &orientation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_BoxCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_quaternion_float3_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 769464, RefRangeEnd = 769466, XrefRangeStart = 769448, XrefRangeEnd = 769464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CylinderCastUp(
      ref CollisionWorld world,
      float3 start,
      float3 end,
      float radius,
      float height,
      int sideCount,
      CollisionFilter filter,
      NativeList<ColliderCastHit> hits,
      bool showDebug = false,
      bool debugOneShot = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &sideCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_CylinderCastUp_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_Single_Int32_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769485, RefRangeEnd = 769486, XrefRangeStart = 769466, XrefRangeEnd = 769485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CylinderCast(
      ref CollisionWorld world,
      float3 start,
      float3 end,
      quaternion orientation,
      float radius,
      float height,
      int sideCount,
      CollisionFilter filter,
      NativeList<ColliderCastHit> hits,
      bool showDebug = false,
      bool debugOneShot = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) ref world;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &orientation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &sideCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_CylinderCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_quaternion_Single_Single_Int32_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 180498, RefRangeEnd = 180504, XrefRangeStart = 180498, XrefRangeEnd = 180504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CylinderCastDebug(
      float3 start,
      float3 end,
      quaternion orientation,
      float radius,
      float height,
      bool showDebug,
      bool debugOneShot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &orientation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebug;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_CylinderCastDebug_Private_Static_Void_float3_float3_quaternion_Single_Single_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 769493, RefRangeEnd = 769506, XrefRangeStart = 769486, XrefRangeEnd = 769493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetHeight(
      float2 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      float defaultHeight = -50f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetHeight_Public_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769506, XrefRangeEnd = 769533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHeights(
      float2 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      ref NativeList<EntityHeight> entityHeights)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityHeights;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetHeights_Public_Static_Boolean_float2_byref_CollisionWorld_CollisionFilterFlags_byref_NativeList_1_EntityHeight_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769540, RefRangeEnd = 769541, XrefRangeStart = 769533, XrefRangeEnd = 769540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetHeightWithIgnore(
      float2 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      NativeHashSet<Entity> ignoreWhenRaycasting,
      float defaultHeight = -50f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreWhenRaycasting;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetHeightWithIgnore_Public_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_NativeHashSet_1_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769547, RefRangeEnd = 769548, XrefRangeStart = 769541, XrefRangeEnd = 769547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetHeight(
      float2 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      out float height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref height;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_TryGetHeight_Public_Static_Boolean_float2_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 769556, RefRangeEnd = 769561, XrefRangeStart = 769548, XrefRangeEnd = 769556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetHeight(
      float3 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      out float height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref height;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_TryGetHeight_Public_Static_Boolean_float3_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 769567, RefRangeEnd = 769569, XrefRangeStart = 769561, XrefRangeEnd = 769567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetHeightSingle(
      float2 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      float defaultHeight = -50f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetHeightSingle_Private_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 769575, RefRangeEnd = 769577, XrefRangeStart = 769569, XrefRangeEnd = 769575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetHeightSingleWithIgnore(
      float2 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      NativeHashSet<Entity> ignoreWhenRaycasting,
      float defaultHeight = -50f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreWhenRaycasting;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetHeightSingleWithIgnore_Private_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_NativeHashSet_1_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 769582, RefRangeEnd = 769584, XrefRangeStart = 769577, XrefRangeEnd = 769582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetHeightSingle(
      float2 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      out float height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref height;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_TryGetHeightSingle_Private_Static_Boolean_float2_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 769594, RefRangeEnd = 769596, XrefRangeStart = 769584, XrefRangeEnd = 769594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetHeightSingle(
      float3 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      out float height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref height;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_TryGetHeightSingle_Private_Static_Boolean_float3_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769603, RefRangeEnd = 769604, XrefRangeStart = 769596, XrefRangeEnd = 769603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetHeightFilterByHeightLevel(
      float2 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      byte heightLevel,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      out bool hitMatchingHeightLevel,
      float defaultHeight = -50f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitMatchingHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetHeightFilterByHeightLevel_Public_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Byte_ComponentDataFromEntity_1_TilePosition_byref_Boolean_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 769641, RefRangeEnd = 769643, XrefRangeStart = 769604, XrefRangeEnd = 769641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetHeightFilterByHeightLevelMulti(
      float2 pos,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      byte heightLevel,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      ref bool hitMatchingHeightLevel,
      float defaultHeight = -50f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitMatchingHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetHeightFilterByHeightLevelMulti_Private_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Byte_ComponentDataFromEntity_1_TilePosition_byref_Boolean_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 769648, RefRangeEnd = 769656, XrefRangeStart = 769643, XrefRangeEnd = 769648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RaycastInput GetRaycastInput(float2 pos, CollisionFilterFlags collidesWith)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetRaycastInput_Public_Static_RaycastInput_float2_CollisionFilterFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RaycastInput*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769656, XrefRangeEnd = 769661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RaycastInput GetRaycastInput(float3 pos, CollisionFilterFlags collidesWith)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Raycasting.NativeMethodInfoPtr_GetRaycastInput_Public_Static_RaycastInput_float3_CollisionFilterFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RaycastInput*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Raycasting()
    {
      Il2CppClassPointerStore<Raycasting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Physics", nameof (Raycasting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Raycasting>.NativeClassPtr);
      Raycasting.NativeFieldInfoPtr_RAYCAST_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, nameof (RAYCAST_OFFSET));
      Raycasting.NativeFieldInfoPtr_RAYCAST_OFFSET3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, nameof (RAYCAST_OFFSET3));
      Raycasting.NativeFieldInfoPtr_MinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, nameof (MinHeight));
      Raycasting.NativeFieldInfoPtr_MaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, nameof (MaxHeight));
      Raycasting.NativeFieldInfoPtr_DefaultHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, nameof (DefaultHeight));
      Raycasting.NativeMethodInfoPtr_CopyAndSortResults_Public_Static_Void_byref_CollisionWorld_NativeList_1_ColliderCastHit_NativeList_1_PhysicsCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668036);
      Raycasting.NativeMethodInfoPtr_CopyResults_Public_Static_Void_byref_CollisionWorld_NativeList_1_ColliderCastHit_NativeList_1_PhysicsCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668037);
      Raycasting.NativeMethodInfoPtr_GetRay_Public_Static_RaycastInput_Ray_Int32_CollisionFilterFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668038);
      Raycasting.NativeMethodInfoPtr_GetRay_Public_Static_RaycastInput_float3_float3_CollisionFilterFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668039);
      Raycasting.NativeMethodInfoPtr_RunSingleFrontFace_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_byref_NativeList_1_RaycastHit_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668040);
      Raycasting.NativeMethodInfoPtr_Single_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668041);
      Raycasting.NativeMethodInfoPtr_SingleWithIgnore_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_NativeHashSet_1_Entity_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668042);
      Raycasting.NativeMethodInfoPtr_Single_Public_Static_Boolean_byref_CollisionWorld_RaycastInput_byref_NativeList_1_RaycastHit_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668043);
      Raycasting.NativeMethodInfoPtr_ConeCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_Single_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668044);
      Raycasting.NativeMethodInfoPtr_ConeCastDebug_Private_Static_Void_float3_float3_Single_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668045);
      Raycasting.NativeMethodInfoPtr_SphereCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668046);
      Raycasting.NativeMethodInfoPtr_OverlappingSphere_Public_Static_Boolean_byref_CollisionWorld_float3_Single_CollisionFilter_NativeList_1_DistanceHit_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668047);
      Raycasting.NativeMethodInfoPtr_DonutCast_Public_Static_Boolean_byref_CollisionWorld_byref_EntityManager_float3_float3_Single_Single_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668048);
      Raycasting.NativeMethodInfoPtr_OverlappingDonutCast_Public_Static_Boolean_byref_CollisionWorld_float3_Single_Single_CollisionFilter_NativeList_1_DistanceHit_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668049);
      Raycasting.NativeMethodInfoPtr_IsWithinDonutShape_Private_Static_Boolean_float3_Single_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668050);
      Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_ColliderCastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668051);
      Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_DistanceHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668052);
      Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668053);
      Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_EntityManager_NativeList_1_ColliderCastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668054);
      Raycasting.NativeMethodInfoPtr_AdjustHitPositions_Public_Static_Void_byref_CollisionWorld_byref_NativeList_1_ColliderCastHit_CollisionFilter_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668055);
      Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_EntityManager_NativeList_1_DistanceHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668056);
      Raycasting.NativeMethodInfoPtr_RemapHitsToPhysicsParent_Public_Static_Void_EntityManager_NativeList_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668057);
      Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_byref_ColliderCastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668058);
      Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_byref_DistanceHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668059);
      Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668060);
      Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_EntityManager_byref_ColliderCastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668061);
      Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_EntityManager_byref_DistanceHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668062);
      Raycasting.NativeMethodInfoPtr_RemapHitToPhysicsParent_Public_Static_Void_EntityManager_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668063);
      Raycasting.NativeMethodInfoPtr_RemapPhysicsCastResults_Public_Static_Void_ComponentDataFromEntity_1_RedirectCollisionChecksToParent_NativeList_1_PhysicsCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668064);
      Raycasting.NativeMethodInfoPtr_RemapPhysicsCastResults_Public_Static_Void_EntityManager_NativeList_1_PhysicsCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668065);
      Raycasting.NativeMethodInfoPtr_SphereCastDebug_Private_Static_Void_float3_float3_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668066);
      Raycasting.NativeMethodInfoPtr_SphereCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_CollisionFilter_byref_ColliderCastHit_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668067);
      Raycasting.NativeMethodInfoPtr_BoxCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_quaternion_float3_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668068);
      Raycasting.NativeMethodInfoPtr_CylinderCastUp_Public_Static_Boolean_byref_CollisionWorld_float3_float3_Single_Single_Int32_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668069);
      Raycasting.NativeMethodInfoPtr_CylinderCast_Public_Static_Boolean_byref_CollisionWorld_float3_float3_quaternion_Single_Single_Int32_CollisionFilter_NativeList_1_ColliderCastHit_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668070);
      Raycasting.NativeMethodInfoPtr_CylinderCastDebug_Private_Static_Void_float3_float3_quaternion_Single_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668071);
      Raycasting.NativeMethodInfoPtr_GetHeight_Public_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668072);
      Raycasting.NativeMethodInfoPtr_GetHeights_Public_Static_Boolean_float2_byref_CollisionWorld_CollisionFilterFlags_byref_NativeList_1_EntityHeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668073);
      Raycasting.NativeMethodInfoPtr_GetHeightWithIgnore_Public_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_NativeHashSet_1_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668074);
      Raycasting.NativeMethodInfoPtr_TryGetHeight_Public_Static_Boolean_float2_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668075);
      Raycasting.NativeMethodInfoPtr_TryGetHeight_Public_Static_Boolean_float3_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668076);
      Raycasting.NativeMethodInfoPtr_GetHeightSingle_Private_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668077);
      Raycasting.NativeMethodInfoPtr_GetHeightSingleWithIgnore_Private_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_NativeHashSet_1_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668078);
      Raycasting.NativeMethodInfoPtr_TryGetHeightSingle_Private_Static_Boolean_float2_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668079);
      Raycasting.NativeMethodInfoPtr_TryGetHeightSingle_Private_Static_Boolean_float3_byref_CollisionWorld_CollisionFilterFlags_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668080);
      Raycasting.NativeMethodInfoPtr_GetHeightFilterByHeightLevel_Public_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Byte_ComponentDataFromEntity_1_TilePosition_byref_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668081);
      Raycasting.NativeMethodInfoPtr_GetHeightFilterByHeightLevelMulti_Private_Static_Single_float2_byref_CollisionWorld_CollisionFilterFlags_Byte_ComponentDataFromEntity_1_TilePosition_byref_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668082);
      Raycasting.NativeMethodInfoPtr_GetRaycastInput_Public_Static_RaycastInput_float2_CollisionFilterFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668083);
      Raycasting.NativeMethodInfoPtr_GetRaycastInput_Public_Static_RaycastInput_float3_CollisionFilterFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, 100668084);
    }

    public Raycasting(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float RAYCAST_OFFSET
    {
      get
      {
        float raycastOffset;
        IL2CPP.il2cpp_field_static_get_value(Raycasting.NativeFieldInfoPtr_RAYCAST_OFFSET, (void*) &raycastOffset);
        return raycastOffset;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Raycasting.NativeFieldInfoPtr_RAYCAST_OFFSET, (void*) &value);
      }
    }

    public static unsafe float3 RAYCAST_OFFSET3
    {
      get
      {
        float3 raycastOffseT3;
        IL2CPP.il2cpp_field_static_get_value(Raycasting.NativeFieldInfoPtr_RAYCAST_OFFSET3, (void*) &raycastOffseT3);
        return raycastOffseT3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Raycasting.NativeFieldInfoPtr_RAYCAST_OFFSET3, (void*) &value);
      }
    }

    public static unsafe int MinHeight
    {
      get
      {
        int minHeight;
        IL2CPP.il2cpp_field_static_get_value(Raycasting.NativeFieldInfoPtr_MinHeight, (void*) &minHeight);
        return minHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Raycasting.NativeFieldInfoPtr_MinHeight, (void*) &value);
      }
    }

    public static unsafe int MaxHeight
    {
      get
      {
        int maxHeight;
        IL2CPP.il2cpp_field_static_get_value(Raycasting.NativeFieldInfoPtr_MaxHeight, (void*) &maxHeight);
        return maxHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Raycasting.NativeFieldInfoPtr_MaxHeight, (void*) &value);
      }
    }

    public static unsafe int DefaultHeight
    {
      get
      {
        int defaultHeight;
        IL2CPP.il2cpp_field_static_get_value(Raycasting.NativeFieldInfoPtr_DefaultHeight, (void*) &defaultHeight);
        return defaultHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Raycasting.NativeFieldInfoPtr_DefaultHeight, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RaycastJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_World;
      private static readonly System.IntPtr NativeFieldInfoPtr_Inputs;
      private static readonly System.IntPtr NativeFieldInfoPtr_DidHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
      [FieldOffset(0)]
      public CollisionWorld World;
      [FieldOffset(344)]
      public NativeArray<RaycastInput> Inputs;
      [FieldOffset(360)]
      public NativeArray<bool> DidHits;
      [FieldOffset(376)]
      public NativeArray<RaycastHit> Hits;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768915, XrefRangeEnd = 768916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(int index)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Raycasting.RaycastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RaycastJob()
      {
        Il2CppClassPointerStore<Raycasting.RaycastJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, nameof (RaycastJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Raycasting.RaycastJob>.NativeClassPtr);
        Raycasting.RaycastJob.NativeFieldInfoPtr_World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting.RaycastJob>.NativeClassPtr, nameof (World));
        Raycasting.RaycastJob.NativeFieldInfoPtr_Inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting.RaycastJob>.NativeClassPtr, nameof (Inputs));
        Raycasting.RaycastJob.NativeFieldInfoPtr_DidHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting.RaycastJob>.NativeClassPtr, nameof (DidHits));
        Raycasting.RaycastJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting.RaycastJob>.NativeClassPtr, nameof (Hits));
        Raycasting.RaycastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting.RaycastJob>.NativeClassPtr, 100668086);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Raycasting.RaycastJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RaycastAllJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_World;
      private static readonly System.IntPtr NativeFieldInfoPtr_Input;
      private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public CollisionWorld World;
      [FieldOffset(344)]
      public RaycastInput Input;
      [FieldOffset(464)]
      public NativeList<RaycastHit> Hits;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768916, XrefRangeEnd = 768917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Raycasting.RaycastAllJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RaycastAllJob()
      {
        Il2CppClassPointerStore<Raycasting.RaycastAllJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, nameof (RaycastAllJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Raycasting.RaycastAllJob>.NativeClassPtr);
        Raycasting.RaycastAllJob.NativeFieldInfoPtr_World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting.RaycastAllJob>.NativeClassPtr, nameof (World));
        Raycasting.RaycastAllJob.NativeFieldInfoPtr_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting.RaycastAllJob>.NativeClassPtr, nameof (Input));
        Raycasting.RaycastAllJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting.RaycastAllJob>.NativeClassPtr, nameof (Hits));
        Raycasting.RaycastAllJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting.RaycastAllJob>.NativeClassPtr, 100668087);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Raycasting.RaycastAllJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RaycastAllFrontFaceJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_World;
      private static readonly System.IntPtr NativeFieldInfoPtr_Input;
      private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public CollisionWorld World;
      [FieldOffset(344)]
      public RaycastInput Input;
      [FieldOffset(464)]
      public NativeList<RaycastHit> Hits;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768917, XrefRangeEnd = 768925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Raycasting.RaycastAllFrontFaceJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RaycastAllFrontFaceJob()
      {
        Il2CppClassPointerStore<Raycasting.RaycastAllFrontFaceJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Raycasting>.NativeClassPtr, nameof (RaycastAllFrontFaceJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Raycasting.RaycastAllFrontFaceJob>.NativeClassPtr);
        Raycasting.RaycastAllFrontFaceJob.NativeFieldInfoPtr_World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting.RaycastAllFrontFaceJob>.NativeClassPtr, nameof (World));
        Raycasting.RaycastAllFrontFaceJob.NativeFieldInfoPtr_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting.RaycastAllFrontFaceJob>.NativeClassPtr, nameof (Input));
        Raycasting.RaycastAllFrontFaceJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycasting.RaycastAllFrontFaceJob>.NativeClassPtr, nameof (Hits));
        Raycasting.RaycastAllFrontFaceJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycasting.RaycastAllFrontFaceJob>.NativeClassPtr, 100668088);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Raycasting.RaycastAllFrontFaceJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
