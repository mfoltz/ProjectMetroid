// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.Game
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Physics;
using ProjectM.Shared;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM.Scripting
{
  public static class Game : Il2CppSystem.Object
  {
    static Game()
    {
      Il2CppClassPointerStore<Game>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (Game));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Game>.NativeClassPtr);
    }

    public Game(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static class SpawnChains : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_ServerGameManager_Entity_FixedString32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_EntityCommandBuffer_ComponentDataFromEntity_1_ActiveChildElement_ComponentDataFromEntity_1_SpawnChainChild_Entity_FixedString32_FixedString32_0;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 772234, RefRangeEnd = 772238, XrefRangeStart = 772233, XrefRangeEnd = 772234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void CreateTransitionEvent(
        ServerGameManager game,
        Entity spawnChainEntity,
        FixedString32 transitionId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnChainEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &transitionId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Game.SpawnChains.NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_ServerGameManager_Entity_FixedString32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772238, XrefRangeEnd = 772239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void CreateTransitionEvent(
        EntityCommandBuffer spawnBuffer,
        ComponentDataFromEntity<SpawnChainData.ActiveChildElement> getActiveChildElement,
        ComponentDataFromEntity<SpawnChainChild> getSpawnChainChild,
        Entity spawnChainEntity,
        FixedString32 transitionId,
        FixedString32 secondaryTransitionId = default (FixedString32))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &spawnBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getActiveChildElement;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getSpawnChainChild;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnChainEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &transitionId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryTransitionId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Game.SpawnChains.NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_EntityCommandBuffer_ComponentDataFromEntity_1_ActiveChildElement_ComponentDataFromEntity_1_SpawnChainChild_Entity_FixedString32_FixedString32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SpawnChains()
      {
        Il2CppClassPointerStore<Game.SpawnChains>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Game>.NativeClassPtr, nameof (SpawnChains));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Game.SpawnChains>.NativeClassPtr);
        Game.SpawnChains.NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_ServerGameManager_Entity_FixedString32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.SpawnChains>.NativeClassPtr, 100668379);
        Game.SpawnChains.NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_EntityCommandBuffer_ComponentDataFromEntity_1_ActiveChildElement_ComponentDataFromEntity_1_SpawnChainChild_Entity_FixedString32_FixedString32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.SpawnChains>.NativeClassPtr, 100668380);
      }

      public SpawnChains(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public static class Abilities : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_IsCasting_Public_Static_Boolean_ServerGameManager_Entity_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 772243, RefRangeEnd = 772244, XrefRangeStart = 772239, XrefRangeEnd = 772243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool IsCasting(ServerGameManager game, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Abilities.NativeMethodInfoPtr_IsCasting_Public_Static_Boolean_ServerGameManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Abilities()
      {
        Il2CppClassPointerStore<Game.Abilities>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Game>.NativeClassPtr, nameof (Abilities));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Game.Abilities>.NativeClassPtr);
        Game.Abilities.NativeMethodInfoPtr_IsCasting_Public_Static_Boolean_ServerGameManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Abilities>.NativeClassPtr, 100668381);
      }

      public Abilities(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public static class Camera : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_RotateCameraToWorldSpaceYaw_Public_Static_Void_ClientGameManager_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RotateCameraToWorldSpaceYaw_Public_Static_Void_EntityManager_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RotateCamera_Private_Static_Void_EntityManager_Single_Entity_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772244, XrefRangeEnd = 772245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RotateCameraToWorldSpaceYaw(ClientGameManager game, float yaw)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yaw;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Game.Camera.NativeMethodInfoPtr_RotateCameraToWorldSpaceYaw_Public_Static_Void_ClientGameManager_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 772269, RefRangeEnd = 772272, XrefRangeStart = 772245, XrefRangeEnd = 772269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RotateCameraToWorldSpaceYaw(EntityManager entityManager, float yaw)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yaw;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Game.Camera.NativeMethodInfoPtr_RotateCameraToWorldSpaceYaw_Public_Static_Void_EntityManager_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772272, XrefRangeEnd = 772278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RotateCamera(
        EntityManager entityManager,
        float yaw,
        Entity topdownCameraEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yaw;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &topdownCameraEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Game.Camera.NativeMethodInfoPtr_RotateCamera_Private_Static_Void_EntityManager_Single_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Camera()
      {
        Il2CppClassPointerStore<Game.Camera>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Game>.NativeClassPtr, nameof (Camera));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Game.Camera>.NativeClassPtr);
        Game.Camera.NativeMethodInfoPtr_RotateCameraToWorldSpaceYaw_Public_Static_Void_ClientGameManager_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Camera>.NativeClassPtr, 100668382);
        Game.Camera.NativeMethodInfoPtr_RotateCameraToWorldSpaceYaw_Public_Static_Void_EntityManager_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Camera>.NativeClassPtr, 100668383);
        Game.Camera.NativeMethodInfoPtr_RotateCamera_Private_Static_Void_EntityManager_Single_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Camera>.NativeClassPtr, 100668384);
      }

      public Camera(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public static class Curves : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Single_ServerGameManager_Single_CurveReference_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 772280, RefRangeEnd = 772281, XrefRangeStart = 772278, XrefRangeEnd = 772280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe float Evaluate(
        ServerGameManager game,
        float t,
        CurveReference curveReference)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &curveReference;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Curves.NativeMethodInfoPtr_Evaluate_Public_Static_Single_ServerGameManager_Single_CurveReference_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Curves()
      {
        Il2CppClassPointerStore<Game.Curves>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Game>.NativeClassPtr, nameof (Curves));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Game.Curves>.NativeClassPtr);
        Game.Curves.NativeMethodInfoPtr_Evaluate_Public_Static_Single_ServerGameManager_Single_CurveReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Curves>.NativeClassPtr, 100668385);
      }

      public Curves(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public static class Physics : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTrigger_Public_Static_Void_byref_ServerGameManager_TriggerId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInHitCollider_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_quaternion_float3_TriggerShape_HitFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CreateSphereTrigger_Public_Static_TriggerId_byref_ServerGameManager_Entity_TriggerCallbackDelegate_Entity_Single_HitFilter_float3_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SphereTrigger_Public_Static_Void_byref_ServerGameManager_Entity_TriggerCallbackDelegate_Entity_float3_Single_HitFilter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SphereTrigger_Public_Static_Void_byref_ServerGameManager_Entity_Int32_Entity_float3_Single_HitFilter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_HitFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_HitFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_Single_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_quaternion_float3_HitFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_quaternion_float3_HitFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInBoxCast_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInBoxCast_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInBoxCast_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_Single_Single_HitFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_Single_Single_HitFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInRay_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_HitFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsEntityInRay_Public_Static_Boolean_byref_ServerGameManager_Entity_float3_float3_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_Single_HitFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_Single_HitFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInSphereWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_Single_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInSphereWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_Single_CollisionFilter_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInSphereCastWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_float3_Single_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInSphereCastWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_float3_Single_CollisionFilter_Boolean_Boolean_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 772295, RefRangeEnd = 772296, XrefRangeStart = 772281, XrefRangeEnd = 772295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RemoveTrigger(ref ServerGameManager game, TriggerId triggerId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &triggerId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_RemoveTrigger_Public_Static_Void_byref_ServerGameManager_TriggerId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 772303, RefRangeEnd = 772310, XrefRangeStart = 772296, XrefRangeEnd = 772303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInHitCollider(
        ref ServerGameManager game,
        Entity self,
        float3 position,
        quaternion rotation,
        float3 offset,
        TriggerShape triggerShape,
        HitFilter hitFilter,
        bool debugOneShot,
        bool ignoreSpellCollision = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[9];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &triggerShape;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollision;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInHitCollider_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_quaternion_float3_TriggerShape_HitFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 772352, RefRangeEnd = 772357, XrefRangeStart = 772310, XrefRangeEnd = 772352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe TriggerId CreateSphereTrigger(
        ref ServerGameManager game,
        Entity self,
        ServerScriptMapper.TriggerCallbackDelegate callback,
        Entity contextEntity,
        float radius,
        HitFilter hitFilter,
        float3 offset = default (float3),
        bool collideWithTerrain = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &collideWithTerrain;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_CreateSphereTrigger_Public_Static_TriggerId_byref_ServerGameManager_Entity_TriggerCallbackDelegate_Entity_Single_HitFilter_float3_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TriggerId*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 772376, RefRangeEnd = 772380, XrefRangeStart = 772357, XrefRangeEnd = 772376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SphereTrigger(
        ref ServerGameManager game,
        Entity self,
        ServerScriptMapper.TriggerCallbackDelegate callback,
        Entity contextEntity,
        float3 startPosition,
        float radius,
        HitFilter hitFilter)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_SphereTrigger_Public_Static_Void_byref_ServerGameManager_Entity_TriggerCallbackDelegate_Entity_float3_Single_HitFilter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772380, XrefRangeEnd = 772397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SphereTrigger(
        ref ServerGameManager game,
        Entity self,
        int functionHash,
        Entity contextEntity,
        float3 startPosition,
        float radius,
        HitFilter hitFilter)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &functionHash;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_SphereTrigger_Public_Static_Void_byref_ServerGameManager_Entity_Int32_Entity_float3_Single_HitFilter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772397, XrefRangeEnd = 772398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInSphere(
        ref ClientGameManager game,
        Entity contextEntity,
        float3 position,
        float radius,
        HitFilter hitFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_HitFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 772399, RefRangeEnd = 772407, XrefRangeStart = 772398, XrefRangeEnd = 772399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInSphere(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 position,
        float radius,
        HitFilter hitFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_HitFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 772408, RefRangeEnd = 772409, XrefRangeStart = 772407, XrefRangeEnd = 772408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInSphere(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 position,
        float radius,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772409, XrefRangeEnd = 772410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInSphere(
        ref ClientGameManager game,
        Entity contextEntity,
        float3 position,
        float radius,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 772425, RefRangeEnd = 772430, XrefRangeStart = 772410, XrefRangeEnd = 772425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInSphere(
        ref PhysicsData physicsData,
        EntityManager entityManager,
        Entity contextEntity,
        float3 position,
        float radius,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[9];
        numPtr[0] = (System.IntPtr) ref physicsData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_Single_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 772431, RefRangeEnd = 772432, XrefRangeStart = 772430, XrefRangeEnd = 772431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInBox(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 position,
        float3 offset,
        quaternion rotation,
        float3 size,
        HitFilter hitFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[9];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_quaternion_float3_HitFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 772433, RefRangeEnd = 772434, XrefRangeStart = 772432, XrefRangeEnd = 772433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInBox(
        ref ClientGameManager game,
        Entity contextEntity,
        float3 position,
        float3 offset,
        quaternion rotation,
        float3 size,
        HitFilter hitFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[9];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_quaternion_float3_HitFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772434, XrefRangeEnd = 772435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInBox(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 position,
        float3 offset,
        quaternion rotation,
        float3 size,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[10];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772435, XrefRangeEnd = 772436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInBox(
        ref ClientGameManager game,
        Entity contextEntity,
        float3 position,
        float3 offset,
        quaternion rotation,
        float3 size,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[10];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772436, XrefRangeEnd = 772437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInBoxCast(
        ref ClientGameManager game,
        Entity contextEntity,
        float3 fromPosition,
        float3 offset,
        float3 toPosition,
        quaternion rotation,
        float3 size,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[11];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &toPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInBoxCast_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772437, XrefRangeEnd = 772438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInBoxCast(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 fromPosition,
        float3 offset,
        float3 toPosition,
        quaternion rotation,
        float3 size,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[11];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &toPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInBoxCast_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 772453, RefRangeEnd = 772460, XrefRangeStart = 772438, XrefRangeEnd = 772453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInBoxCast(
        ref PhysicsData physicsData,
        EntityManager entityManager,
        Entity contextEntity,
        float3 fromPosition,
        float3 offset,
        float3 toPosition,
        quaternion rotation,
        float3 size,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[12];
        numPtr[0] = (System.IntPtr) ref physicsData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &toPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInBoxCast_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772460, XrefRangeEnd = 772461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInCone(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 position,
        float3 direction,
        float radius,
        float angle,
        HitFilter hitFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[9];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_Single_Single_HitFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772461, XrefRangeEnd = 772462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInCone(
        ref ClientGameManager game,
        Entity contextEntity,
        float3 position,
        float3 direction,
        float radius,
        float angle,
        HitFilter hitFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[9];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_Single_Single_HitFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772462, XrefRangeEnd = 772463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInCone(
        ref ClientGameManager game,
        Entity contextEntity,
        float3 position,
        float3 direction,
        float radius,
        float angle,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[10];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772463, XrefRangeEnd = 772464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInCone(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 position,
        float3 direction,
        float radius,
        float angle,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[10];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 772479, RefRangeEnd = 772484, XrefRangeStart = 772464, XrefRangeEnd = 772479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInCone(
        ref PhysicsData physicsData,
        EntityManager entityManager,
        Entity contextEntity,
        float3 position,
        float3 direction,
        float radius,
        float angle,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[11];
        numPtr[0] = (System.IntPtr) ref physicsData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 772496, RefRangeEnd = 772497, XrefRangeStart = 772484, XrefRangeEnd = 772496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInRay(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 fromPosition,
        float3 toPosition,
        HitFilter hitFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInRay_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_HitFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 772509, RefRangeEnd = 772515, XrefRangeStart = 772497, XrefRangeEnd = 772509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool IsEntityInRay(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 fromPosition,
        float3 toPosition,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_IsEntityInRay_Public_Static_Boolean_byref_ServerGameManager_Entity_float3_float3_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772515, XrefRangeEnd = 772516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInDonut(
        ref ClientGameManager game,
        Entity contextEntity,
        float3 position,
        float radius,
        float innerRadius,
        HitFilter hitFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &innerRadius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_Single_HitFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772516, XrefRangeEnd = 772517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInDonut(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 position,
        float radius,
        float innerRadius,
        HitFilter hitFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &innerRadius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_Single_HitFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772517, XrefRangeEnd = 772518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInDonut(
        ref ServerGameManager game,
        Entity contextEntity,
        float3 position,
        float radius,
        float innerRadius,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[9];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &innerRadius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772518, XrefRangeEnd = 772519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInDonut(
        ref ClientGameManager game,
        Entity contextEntity,
        float3 position,
        float radius,
        float innerRadius,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[9];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &innerRadius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 772534, RefRangeEnd = 772539, XrefRangeStart = 772519, XrefRangeEnd = 772534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<HitResult> GetEntitiesInDonut(
        ref PhysicsData physicsData,
        EntityManager entityManager,
        Entity contextEntity,
        float3 position,
        float radius,
        float innerRadius,
        HitFilter hitFilter,
        CollisionFilter collisionFilter,
        bool ignoreSpellCollisionBlock = false,
        bool debugOneShot = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[10];
        numPtr[0] = (System.IntPtr) ref physicsData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &contextEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &innerRadius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hitFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<HitResult>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 772540, RefRangeEnd = 772545, XrefRangeStart = 772539, XrefRangeEnd = 772540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<ColliderCastHit> GetEntitiesInSphereWithoutFilter(
        ref ServerGameManager game,
        float3 position,
        float radius,
        bool debugOneShot = false,
        bool ignoreSpellCollisionBlock = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphereWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_Single_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<ColliderCastHit>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772545, XrefRangeEnd = 772546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<ColliderCastHit> GetEntitiesInSphereWithoutFilter(
        ref ServerGameManager game,
        float3 position,
        float radius,
        CollisionFilter collisionFilter,
        bool debugOneShot = false,
        bool ignoreSpellCollisionBlock = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphereWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_Single_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<ColliderCastHit>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 772547, RefRangeEnd = 772548, XrefRangeStart = 772546, XrefRangeEnd = 772547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<ColliderCastHit> GetEntitiesInSphereCastWithoutFilter(
        ref ServerGameManager game,
        float3 fromPosition,
        float3 toPosition,
        float radius,
        bool debugOneShot = false,
        bool ignoreSpellCollisionBlock = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphereCastWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_float3_Single_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<ColliderCastHit>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 772560, RefRangeEnd = 772563, XrefRangeStart = 772548, XrefRangeEnd = 772560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe NativeArray<ColliderCastHit> GetEntitiesInSphereCastWithoutFilter(
        ref ServerGameManager game,
        float3 fromPosition,
        float3 toPosition,
        float radius,
        CollisionFilter collisionFilter,
        bool debugOneShot = false,
        bool ignoreSpellCollisionBlock = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &debugOneShot;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSpellCollisionBlock;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphereCastWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_float3_Single_CollisionFilter_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<ColliderCastHit>*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Physics()
      {
        Il2CppClassPointerStore<Game.Physics>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Game>.NativeClassPtr, nameof (Physics));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr);
        Game.Physics.NativeMethodInfoPtr_RemoveTrigger_Public_Static_Void_byref_ServerGameManager_TriggerId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668386);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInHitCollider_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_quaternion_float3_TriggerShape_HitFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668387);
        Game.Physics.NativeMethodInfoPtr_CreateSphereTrigger_Public_Static_TriggerId_byref_ServerGameManager_Entity_TriggerCallbackDelegate_Entity_Single_HitFilter_float3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668388);
        Game.Physics.NativeMethodInfoPtr_SphereTrigger_Public_Static_Void_byref_ServerGameManager_Entity_TriggerCallbackDelegate_Entity_float3_Single_HitFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668389);
        Game.Physics.NativeMethodInfoPtr_SphereTrigger_Public_Static_Void_byref_ServerGameManager_Entity_Int32_Entity_float3_Single_HitFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668390);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_HitFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668391);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_HitFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668392);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668393);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668394);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphere_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_Single_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668395);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_quaternion_float3_HitFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668396);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_quaternion_float3_HitFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668397);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668398);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInBox_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668399);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInBoxCast_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668400);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInBoxCast_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668401);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInBoxCast_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_float3_float3_quaternion_float3_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668402);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_Single_Single_HitFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668403);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_Single_Single_HitFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668404);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668405);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668406);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInCone_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668407);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInRay_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_float3_HitFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668408);
        Game.Physics.NativeMethodInfoPtr_IsEntityInRay_Public_Static_Boolean_byref_ServerGameManager_Entity_float3_float3_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668409);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_Single_HitFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668410);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_Single_HitFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668411);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ServerGameManager_Entity_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668412);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_ClientGameManager_Entity_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668413);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInDonut_Public_Static_NativeArray_1_HitResult_byref_PhysicsData_EntityManager_Entity_float3_Single_Single_HitFilter_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668414);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphereWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668415);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphereWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_Single_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668416);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphereCastWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_float3_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668417);
        Game.Physics.NativeMethodInfoPtr_GetEntitiesInSphereCastWithoutFilter_Public_Static_NativeArray_1_ColliderCastHit_byref_ServerGameManager_float3_float3_Single_CollisionFilter_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.Physics>.NativeClassPtr, 100668418);
      }

      public Physics(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public static class SpellMods : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_TryApplyArithmeticSpellMods_Public_Static_Boolean_byref_ServerGameManager_SpellModArithmeticTarget_Entity_byref_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryApplyPrefabGUIDSpellMods_Public_Static_Boolean_byref_ServerGameManager_SpellModPrefabGuidTarget_Entity_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryApplySequenceGUIDSpellMods_Public_Static_Boolean_byref_ServerGameManager_SpellModSequenceGuidTarget_Entity_byref_SequenceGUID_0;

      [CallerCount(18)]
      [CachedScanResults(RefRangeStart = 772589, RefRangeEnd = 772607, XrefRangeStart = 772563, XrefRangeEnd = 772589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryApplyArithmeticSpellMods(
        ref ServerGameManager game,
        SpellModArithmeticTarget targetType,
        Entity targetEntity,
        ref float value)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.SpellMods.NativeMethodInfoPtr_TryApplyArithmeticSpellMods_Public_Static_Boolean_byref_ServerGameManager_SpellModArithmeticTarget_Entity_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772607, XrefRangeEnd = 772622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryApplyPrefabGUIDSpellMods(
        ref ServerGameManager game,
        SpellModPrefabGuidTarget targetType,
        Entity targetEntity,
        ref PrefabGUID value)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.SpellMods.NativeMethodInfoPtr_TryApplyPrefabGUIDSpellMods_Public_Static_Boolean_byref_ServerGameManager_SpellModPrefabGuidTarget_Entity_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772622, XrefRangeEnd = 772637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryApplySequenceGUIDSpellMods(
        ref ServerGameManager game,
        SpellModSequenceGuidTarget targetType,
        Entity targetEntity,
        ref SequenceGUID value)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Game.SpellMods.NativeMethodInfoPtr_TryApplySequenceGUIDSpellMods_Public_Static_Boolean_byref_ServerGameManager_SpellModSequenceGuidTarget_Entity_byref_SequenceGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static SpellMods()
      {
        Il2CppClassPointerStore<Game.SpellMods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Game>.NativeClassPtr, nameof (SpellMods));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Game.SpellMods>.NativeClassPtr);
        Game.SpellMods.NativeMethodInfoPtr_TryApplyArithmeticSpellMods_Public_Static_Boolean_byref_ServerGameManager_SpellModArithmeticTarget_Entity_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.SpellMods>.NativeClassPtr, 100668419);
        Game.SpellMods.NativeMethodInfoPtr_TryApplyPrefabGUIDSpellMods_Public_Static_Boolean_byref_ServerGameManager_SpellModPrefabGuidTarget_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.SpellMods>.NativeClassPtr, 100668420);
        Game.SpellMods.NativeMethodInfoPtr_TryApplySequenceGUIDSpellMods_Public_Static_Boolean_byref_ServerGameManager_SpellModSequenceGuidTarget_Entity_byref_SequenceGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game.SpellMods>.NativeClassPtr, 100668421);
      }

      public SpellMods(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
